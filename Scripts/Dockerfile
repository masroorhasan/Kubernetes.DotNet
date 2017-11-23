# FROM alpine:latest
FROM zenika/alpine-maven:3-jdk-8

# Install git
RUN \
    apk update && apk upgrade && \
    apk add --no-cache bash git openssh

# Install Python
RUN apk add --update \
    python \
    python-dev \
    py-pip \
    build-base \
  && pip install --upgrade pip \
  && pip install virtualenv \
  && pip install urllib3 \
  && rm -rf /var/cache/apk/*

# Copy over files and execute
RUN mkdir -p Scripts
ADD client-gen.sh init-config.json update-config.json Scripts/
CMD ["sh", "Scripts/client-gen.sh"]
