#!/bin/bash

# constants
CURRENT_DIR=`pwd`
KUBERNETES_BRANCH="release-1.7"
OPENAPI_CLIENT_GEN_DIR="openapi-client-gen"
KUBERNETES_SRC_DIR="Kubernetes.DotNet"
CLIENT_LANG="csharp"

# remove
rm -rf "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}"

# download openapi k8s code gen preprocessor
git clone https://github.com/kubernetes-client/gen.git "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}" --depth=1
mkdir Swagger
python "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}/openapi/preprocess_spec.py" "${CLIENT_LANG}" "${KUBERNETES_BRANCH}" "${CURRENT_DIR}/Swagger/swagger.json"

# generate with appropriate config
if [ -f "${CURRENT_DIR}/Kubernetes/src/${KUBERNETES_SRC_DIR}" ]; then
    swagger-codegen generate -i ${CURRENT_DIR}/Swagger/swagger.json -l ${CLIENT_LANG} -o ${CURRENT_DIR}/Kubernetes -c ${CURRENT_DIR}/Scripts/update-config.json
else
    swagger-codegen generate -i ${CURRENT_DIR}/Swagger/swagger.json -l ${CLIENT_LANG} -o ${CURRENT_DIR}/Kubernetes -c ${CURRENT_DIR}/Scripts/init-config.json
fi

# clean up
rm -rf "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}"