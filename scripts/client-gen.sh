#!/bin/bash

# Constants
KUBERNETES_BRANCH=$K8S_BRANCH_VERSION
CURRENT_DIR=`pwd`
OPENAPI_CLIENT_GEN_DIR="openapi-client-gen"
KUBERNETES_SRC_DIR="Kubernetes.DotNet"
CLIENT_LANG="csharp"
GEN_SPEC_API_PATH="src/Kubernetes.DotNet/Api"
GEN_SPEC_CLIENT_PATH="src/Kubernetes.DotNet/Client"
GEN_SPEC_MODEL_PATH="src/Kubernetes.DotNet/Model"

####### Client Generation #######
echo "Generating C# client for Kubernetes API:${KUBERNETES_BRANCH}."

# Download openapi k8s code gen preprocessor
mkdir swagger
git clone https://github.com/kubernetes-client/gen.git "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}" --depth=1
python "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}/openapi/preprocess_spec.py" "${CLIENT_LANG}" "${KUBERNETES_BRANCH}" "${CURRENT_DIR}/swagger/swagger.json"

# Download swagger-codegen and generate from swagger spec
wget http://central.maven.org/maven2/io/swagger/swagger-codegen-cli/2.2.3/swagger-codegen-cli-2.2.3.jar -O swagger-codegen-cli.jar
java -jar swagger-codegen-cli.jar generate -i ${CURRENT_DIR}/swagger/swagger.json -l ${CLIENT_LANG} -o ${CURRENT_DIR}/Kubernetes -c ${CURRENT_DIR}/scripts/init-config.json

####### Map generated code on mounted volume #########
mkdir gen/src
mkdir gen/src/Kubernetes.DotNet/

# Copy generated API endpoints
mkdir gen/${GEN_SPEC_API_PATH}
cp -r ${CURRENT_DIR}/Kubernetes/${GEN_SPEC_API_PATH}/* ${CURRENT_DIR}/gen/${GEN_SPEC_API_PATH}/

# Copy generated HTTP client
mkdir gen/${GEN_SPEC_CLIENT_PATH}
cp -r ${CURRENT_DIR}/Kubernetes/${GEN_SPEC_CLIENT_PATH}/* ${CURRENT_DIR}/gen/${GEN_SPEC_CLIENT_PATH}/

# Copy generated models
mkdir gen/${GEN_SPEC_MODEL_PATH}
cp -r ${CURRENT_DIR}/Kubernetes/${GEN_SPEC_MODEL_PATH}/* ${CURRENT_DIR}/gen/${GEN_SPEC_MODEL_PATH}/

# Clean up
rm swagger-codegen-cli.jar
rm -rf "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}"
rm -rf "${CURRENT_DIR}/Kubernetes/"