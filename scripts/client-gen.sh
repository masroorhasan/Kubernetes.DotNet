#!/bin/bash

# Constants
readonly GEN_CREATE_OP="create"
readonly GEN_UPDATE_OP="update"
readonly CURRENT_DIR=`pwd`
readonly OPENAPI_CLIENT_GEN_DIR="openapi-client-gen"
readonly KUBERNETES_SRC_DIR="Kubernetes.DotNet"
readonly CLIENT_LANG="csharp"

# Environment variables
KUBERNETES_BRANCH=$K8S_BRANCH_VERSION
GEN_OP_TYPE=$GEN_OP_TYPE

# Trace
echo "Generating C# client for Kubernetes API:${KUBERNETES_BRANCH}."

# Download openapi k8s code gen preprocessor
mkdir swagger
git clone https://github.com/kubernetes-client/gen.git "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}" --depth=1
python "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}/openapi/preprocess_spec.py" "${CLIENT_LANG}" "${KUBERNETES_BRANCH}" "${CURRENT_DIR}/swagger/swagger.json"

# Download swagger-codegen and generated from swagger spec
wget http://central.maven.org/maven2/io/swagger/swagger-codegen-cli/2.2.3/swagger-codegen-cli-2.2.3.jar -O swagger-codegen-cli.jar
java -jar swagger-codegen-cli.jar generate -i ${CURRENT_DIR}/swagger/swagger.json -l ${CLIENT_LANG} -o ${CURRENT_DIR}/Kubernetes -c ${CURRENT_DIR}/scripts/init-config.json

# Client generator - create
if [ "$GEN_OP_TYPE" == "$GEN_CREATE_OP" ]; then
    # Copy all to mounted host volume
    cp -r ${CURRENT_DIR}/Kubernetes/* ${CURRENT_DIR}/gen/

# Client generator - update
elif [ "$GEN_OP_TYPE" == "$GEN_UPDATE_OP" ]; then
    # Only copy generated API endpoints, HTTP client and models to mounted host volume
    cp -r ${CURRENT_DIR}/Kubernetes/src/Kubernetes.DotNet/Api/* ${CURRENT_DIR}/gen/src/Kubernetes.DotNet/Api/
    cp -r ${CURRENT_DIR}/Kubernetes/src/Kubernetes.DotNet/Client/* ${CURRENT_DIR}/gen/src/Kubernetes.DotNet/Client/
    cp -r ${CURRENT_DIR}/Kubernetes/src/Kubernetes.DotNet/Model/* ${CURRENT_DIR}/gen/src/Kubernetes.DotNet/Model/

# Client generator - invalid
else
    echo "Invalid generator type: ${GEN_OP_TYPE}. Exiting.."
    exit 1
fi

# Clean up
rm swagger-codegen-cli.jar
rm -rf "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}"
rm -rf "${CURRENT_DIR}/Kubernetes/"