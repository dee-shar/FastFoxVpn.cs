#!/bin/bash

api="https://api.fastfoxvpn.com/api/v1"
user_agent="okhttp/3.14.9"

function login_with_uuid() {
	# 1 - uuid: (string): <uuid>
	uuid=$1
}

function get_servers() {
	curl --request GET \
		--url "$api/servers?uuid=$uuid" \
		--user-agent "$user_agent" \
		--header "content-type: application/json"
}
