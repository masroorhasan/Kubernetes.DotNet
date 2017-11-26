#!/bin/bash

# constants
KUBERNETES_BRANCH=$K8S_BRANCH_VERSION
CURRENT_DIR=`pwd`
OPENAPI_CLIENT_GEN_DIR="openapi-client-gen"
KUBERNETES_SRC_DIR="Kubernetes.DotNet"
CLIENT_LANG="csharp"

# Trace
echo "Generating C# client for Kubernetes API:${KUBERNETES_BRANCH}."

# create dir for swagger spec
mkdir Swagger

# remove
rm -rf "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}"

# download openapi k8s code gen preprocessor
git clone https://github.com/kubernetes-client/gen.git "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}" --depth=1
python "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}/openapi/preprocess_spec.py" "${CLIENT_LANG}" "${KUBERNETES_BRANCH}" "${CURRENT_DIR}/Swagger/swagger.json"

# download swagger-codegen
wget http://central.maven.org/maven2/io/swagger/swagger-codegen-cli/2.2.3/swagger-codegen-cli-2.2.3.jar -O swagger-codegen-cli.jar

# generate with appropriate config
if [ -f "${CURRENT_DIR}/Kubernetes/src/${KUBERNETES_SRC_DIR}" ]; then
    echo "Updating K8s API."
    java -jar swagger-codegen-cli.jar generate -i ${CURRENT_DIR}/Swagger/swagger.json -l ${CLIENT_LANG} -o ${CURRENT_DIR}/Kubernetes -c ${CURRENT_DIR}/Scripts/update-config.json
else
    echo "Creating K8s API."
    java -jar swagger-codegen-cli.jar generate -i ${CURRENT_DIR}/Swagger/swagger.json -l ${CLIENT_LANG} -o ${CURRENT_DIR}/Kubernetes -c ${CURRENT_DIR}/Scripts/init-config.json
fi

# clean up
rm swagger-codegen-cli.jar
rm -rf "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}"