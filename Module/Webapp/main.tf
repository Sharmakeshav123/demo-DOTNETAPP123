resource "azurerm_app_service_plan" "example" {
  name  = var.app_name
  location  = var.location
  resource_group_name = var.rg_name
  kind = "Windows"

  sku {
    tier = "free"
    size = "S1"
  }
}

resource "azurerm_app_service" "example" {
  name  = var.appservicename
  location = var.location
  
  resource_group_name = var.rg_name
  app_service_plan_id = azurerm_app_service_plan.example.id

  site_config {
    dotnet_framework_version = "v5.0"
    scm_type                 = "LocalGit"
  }

}