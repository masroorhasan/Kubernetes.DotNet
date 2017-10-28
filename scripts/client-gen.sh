#!/bin/bash

# constants
CURRENT_DIR=`pwd`
KUBERNETES_BRANCH="release-1.7"
OPENAPI_CLIENT_GEN_DIR="openapi-client-gen"
KUBERNETES_SRC_DIR="Kubernetes.DotNet"

# remove
rm -rf "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}"

# download openapi k8s code gen preprocessor
git clone https://github.com/kubernetes-client/gen.git "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}" --depth=1
mkdir swagger
python "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}/openapi/preprocess_spec.py" "${KUBERNETES_BRANCH}" "${CURRENT_DIR}/swagger/swagger.json"

# generate with appropriate config
if [ -f "${CURRENT_DIR}/src/${KUBERNETES_SRC_DIR}" ]; then
    swagger-codegen generate -i ${CURRENT_DIR}/swagger/swagger.json -l csharp -o ${CURRENT_DIR} -c ${CURRENT_DIR}/scripts/update-config.json
else
    swagger-codegen generate -i ${CURRENT_DIR}/swagger/swagger.json -l csharp -o ${CURRENT_DIR} -c ${CURRENT_DIR}/scripts/init-config.json
fi

# clean up
rm -rf "${CURRENT_DIR}/${OPENAPI_CLIENT_GEN_DIR}"


