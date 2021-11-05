module "Resource_group"{
    source = "./Module/Resource_Group"
    rg_name = var.rg_name
    location = var.location

}


module "Webapp" {
    source = "./Module/Webapp"
    depends_on = [
      module.Resource_group
    ]
    app_name  = var.app_name
    location  = var.location
    rg_name  = var.rg_name
    appservicename  = var.appservicename
}