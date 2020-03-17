#include "pch.h"

extern "C" __declspec(dllexport) bool is_expired(const char *bundle_name, const char *app_key, const char *app_secret) {
	if (app_key == NULL || app_secret == NULL) {
		return false;
	}
	if (strstr(bundle_name, app_key) != NULL && strstr(bundle_name, app_secret) != NULL) {
		return true;
	} else {
		return false;
	}
}