# Necessary packages for R-Instat
# packs_lib <- c("reshape2", "lubridate","plyr", "dplyr", "rtf", "openxlsx", "ggplot2", "extRemes", "GGally", "agridat", "DAAG", "FactoMineR", "plotrix", "candisc", "R6", "openair", "circular", "survival", "Evapotranspiration", "clifro", "devtools", "factoextra", "circlize", "CircStats", "gridExtra", "ggfortify", "rio", "readxl", "lme4", "dummies", "ggthemes", "lazyeval", "stringr", "httr", "jsonlite", "fitdistrplus", "visreg", "climdex.pcic", "mosaic", "ncdf4", "getPass", "RMySQL", "DBI", "EnvStats", "signmedian.test", "sjPlot", "sjmisc", "plotly", "svglite", "htmlTable", "rje", "tidyr", "faraway", "ncdf.tools", "rrefine", "dae", "gapminder", "questionr", "nycflights13", "Lahman", "ncdf4.helpers", "RcppRoll", "cmsaf", "sjlabelled", "maptools", "RColorBrewer", "colorRamps", "mapdata", "rworldmap", "rworldxtra", "e1071", "robustbase", "wakefield")
# Packages including dependencies (generated from miniCRAN package)
packs <- c("abind", "acepack", "agricolae", "agridat", "AlgDesign", 
           "ash", "askpass", "assertthat", "backports", "base64enc", "bayesplot", 
           "BH", "bitops", "boot", "broom", "callr", "candisc", "car", "carData", 
           "caTools", "cellranger", "checkmate", "chron", "circlize", "CircStats", 
           "circular", "class", "classInt", "cli", "clifro", "climdex.pcic", 
           "clipr", "clisymbols", "cluster", "cmsaf", "coda", "codetools", 
           "coin", "colorRamps", "colorspace", "combinat", "cowplot", "crayon", 
           "crosstalk", "curl", "DAAG", "dae", "data.table", "DBI", "deldir", 
           "dendextend", "DEoptimR", "desc", "devtools", "digest", "diptest", 
           "distillery", "dotCall64", "dplyr", "dummies", "e1071", "ellipse", 
           "ellipsis", "emmeans", "EnvStats", "estimability", "evaluate", 
           "Evapotranspiration", "expm", "extrafont", "extrafontdb", "extRemes", 
           "factoextra", "FactoMineR", "fansi", "faraway", "fields", "fitdistrplus", 
           "flashClust", "flexmix", "forcats", "foreach", "foreign", "Formula", 
           "fpc", "fs", "gapminder", "gdata", "gdtools", "generics", "geosphere", 
           "getPass", "GGally", "ggalt", "ggdendro", "ggeffects", "ggformula", 
           "ggfortify", "ggmosaic", "ggplot2", "ggpubr", "ggrepel", "ggridges", 
           "ggsci", "ggsignif", "ggstance", "ggthemes", "gh", "git2r", "glmmTMB", 
           "GlobalOptions", "glue", "gmodels", "goftest", "gplots", "gridExtra", 
           "gtable", "gtools", "haven", "heplots", "hexbin", "highr", "Hmisc", 
           "hms", "htmlTable", "htmltools", "htmlwidgets", "httpuv", "httr", 
           "ini", "insight", "iterators", "JBTools", "jsonlite", "kernlab", 
           "KernSmooth", "klaR", "knitr", "labeling", "labelled", "Lahman", 
           "later", "lattice", "latticeExtra", "lazyeval", "leaflet", "leaps", 
           "LearnBayes", "libcoin", "lme4", "lmomco", "Lmoments", "lsei", 
           "lubridate", "magrittr", "mapdata", "mapproj", "maps", "maptools", 
           "markdown", "MASS", "Matrix", "MatrixModels", "matrixStats", 
           "mclust", "memoise", "mgcv", "mime", "miniUI", "minqa", "mnormt", 
           "modelr", "modeltools", "mosaic", "mosaicCore", "mosaicData", 
           "multcomp", "munsell", "mvtnorm", "ncdf.tools", "ncdf4.helpers", 
           "ncdf4", "nlme", "nloptr", "nnet", "nortest", "npsurv", "numDeriv", 
           "nycflights13", "openair", "openssl", "openxlsx", "pbkrtest", 
           "PCICt", "pillar", "pkgbuild", "pkgconfig", "pkgload", "plogr", 
           "plotly", "plotrix", "plyr", "png", "polynom", "prabclus", "prediction", 
           "prettyunits", "processx", "productplots", "progress", "proj4", 
           "promises", "ps", "psych", "purrr", "pwr", "quantreg", "questionr", 
           "R.methodsS3", "R.oo", "R6", "raster", "rcmdcheck", "RColorBrewer", 
           "Rcpp", "RcppEigen", "RcppRoll", "RCurl", "readODS", "readr", 
           "readxl", "rematch", "remotes", "reshape", "reshape2", "rio", 
           "rje", "rlang", "rlist", "RMySQL", "RNetCDF", "robustbase", "rpart", 
           "rprojroot", "rrefine", "rstudioapi", "rtf", "Rttf2pt1", "rworldmap", 
           "rworldxtra", "sandwich", "scales", "scatterplot3d", "sessioninfo", 
           "sf", "shape", "shiny", "signmedian.test", "sjlabelled", "sjmisc", 
           "sjPlot", "sjstats", "sourcetools", "sp", "spam", "SparseM", 
           "spData", "spdep", "SPEI", "stringdist", "stringi", "stringr", 
           "survival", "svglite", "sys", "TH.data", "tibble", "tidyr", "tidyselect", 
           "TMB", "trimcluster", "units", "usethis", "utf8", "viridis", 
           "viridisLite", "visreg", "wakefield", "weathermetrics", "whisker", 
           "withr", "xfun", "XML", "xml2", "xopen", "xtable", "yaml", "zip", 
           "zoo")
  
versions <- c("1.4-5", "1.4.1", "1.3-0", "1.16", "1.1-7.3", "1.0-15", 
              "1.1", "0.2.0", "1.1.3", "0.1-3", "1.6.0", "1.69.0-1", "1.0-6", 
              "1.3-20", "0.5.1", "3.1.1", "0.8-0", "3.0-2", "3.0-2", "1.17.1.2", 
              "1.1.0", "1.9.1", "2.3-53", "0.4.5", "0.2-6", "0.4-93", "7.3-15", 
              "0.3-1", "1.0.1", "3.2-1", "1.1-9.1", "0.5.0", "1.2.0", "2.0.7-1", 
              "1.9.5", "0.19-2", "0.2-16", "1.3-0", "2.3", "1.4-0", "0.0-8", 
              "0.9.4", "1.3.4", "1.0.0", "3.3", "1.22.1", "3.0-23", "1.12.0", 
              "1.0.0", "0.1-16", "1.9.0", "1.0-8", "1.2.0", "2.0.1", "0.6.18", 
              "0.75-7", "1.0-4", "1.0-0", "0.8.0.1", "1.5.6", "1.7-0.1", "0.4.1", 
              "0.1.0", "1.3.3", "2.3.1", "1.3", "0.13", "1.12", "0.999-3", 
              "0.17", "1.0", "2.0-9", "1.0.5", "1.41", "0.4.0", "1.0.7", "9.6", 
              "1.0-14", "1.01-2", "2.3-15", "0.4.0", "1.4.4", "0.8-71", "1.2-3", 
              "2.1-11.1", "1.2.6", "0.3.0", "2.18.0", "0.1.7", "0.0.2", "1.5-7", 
              "0.2-2", "1.4.0", "0.4.0", "0.1-20", "0.8.0", "0.9.1", "0.4.5", 
              "0.2.0", "3.1.0", "0.2", "0.8.0", "0.5.1", "2.9", "0.5.0", "0.3.1", 
              "4.1.0", "1.0.1", "0.24.0", "0.2.3", "0.1.0", "1.3.0", "2.18.1", 
              "1.1-1", "3.0.1.1", "2.3", "0.2.0", "3.8.1", "2.1.0", "1.3-5", 
              "1.27.2", "0.7", "4.2-0", "0.4.2", "1.13.1", "0.3.6", "1.3", 
              "1.4.5.1", "1.4.0", "0.3.1", "0.1.2", "1.0.10", "0.7.2.9", "1.6", 
              "0.9-27", "2.23-15", "0.6-14", "1.22", "0.3", "2.1.0", "6.0-0", 
              "0.8.0", "0.20-38", "0.6-28", "0.2.1", "2.0.2", "3.0", "2.15.1", 
              "1.0-4", "1.1-21", "2.3.2", "1.2-3", "1.2-0", "1.7.4", "1.5", 
              "2.3.0", "1.2.6", "3.3.0", "0.9-5", "0.9", "7.3-51.1", "1.2-15", 
              "0.4-1", "0.54.0", "5.4.2", "1.1.0", "1.8-27", "0.6", "0.1.1.1", 
              "1.2.4", "1.5-5", "0.1.4", "0.2-22", "1.5.0", "0.6.0", "0.17.0", 
              "1.4-8", "0.5.0", "1.0-8", "0.7.1.295", "0.3-3", "1.16.1", "3.1-137", 
              "1.2.1", "7.3-12", "1.0-4", "0.4-0", "2016.8-1", "1.0.0", "2.6-1", 
              "1.2.2", "4.1.0", "0.4-7", "0.5-4.1", "1.3.1", "1.0.2", "2.0.2", 
              "1.0.2", "0.2.0", "4.8.0", "3.7-4", "1.8.4", "0.1-7", "1.3-9", 
              "2.2-7", "0.3.6.2", "1.0.2", "3.3.0", "0.1.1", "1.2.0", "1.0-8", 
              "1.0.1", "1.3.0", "1.8.12", "0.3.1", "1.2-2", "5.38", "0.7.0", 
              "1.7.1", "1.22.0", "2.4.0", "2.8-19", "1.3.1", "1.1-2", "1.0.0", 
              "0.3.3.5.0", "0.3.0", "1.95-4.12", "1.6.7", "1.3.1", "1.3.0", 
              "1.0.1", "2.0.2", "0.8.8", "1.4.3", "0.5.16", "1.9", "0.3.1", 
              "0.4.6.1", "0.10.17", "1.9-1", "0.93-3", "4.1-13", "1.3-2", "1.0", 
              "0.9.0", "0.4-13", "1.3.7", "1.3-6", "1.01", "2.5-0", "1.0.0", 
              "0.3-41", "1.1.1", "0.7-3", "1.4.4", "1.2.0", "1.5.1", "1.0.17", 
              "2.7.7", "2.6.2", "0.17.3", "0.1.7", "1.3-1", "2.2-2", "1.77", 
              "0.3.0", "1.0-2", "1.7", "0.9.5.1", "1.3.1", "1.4.0", "2.43-3", 
              "1.2.1", "3.1", "1.0-10", "2.0.1", "0.8.3", "0.2.5", "1.7.15", 
              "0.1-2.1", "0.6-2", "1.4.0", "1.1.4", "0.5.1", "0.3.0", "2.5-0", 
              "0.3.3", "1.2.2", "0.3-2", "2.1.2", "0.5", "3.98-1.19", "1.2.0", 
              "1.0.0", "1.8-3", "2.2.0", "2.0.1", "1.8-4")

##################################################

# Returns package names from packs which are not installed with the correct version
packages_not_installed <- function() {
  success <- invisible(mapply(function(p, v) length(find.package(p, quiet = TRUE)) > 0 && compareVersion(as.character(packageVersion(p)), v) >= 0, packs, versions))
  return(names(success)[!success])
}

load_R_Instat_packages <- function() {
  # ggthemes temp added because themes list doesn't contain package names
  # sp needed for plot.region() function which requires sp loaded but gives errors through R-Instat
  # plyr and dplyr loaded in order to avoid conflicts
  # ggplot2 loaded for convenience
  # svglite and ggfortify needed for View Graph dialog
  # PCICt needed to access PCICt class when importing NET cdf files
  # ggmosaic because geom_mosaic aes only work when ggmosaic is loaded
  # wakefield because many functions do not work without loading (https://github.com/trinker/wakefield/issues/11)
  packs_to_load <- c("plyr", "dplyr", "ggplot2", "ggthemes", "svglite", "ggfortify", "PCICt", "sp", "ggmosaic", "wakefield")
  for(pack in packs_to_load) {
    try(library(pack, character.only = TRUE))
  }
}

# Returns package names from packs_to_load which are not loaded
packages_not_loaded <- function() {
  return(packs_to_load[!packs_to_load %in% .packages()])
}

##################################################

success <- invisible(mapply(function(p, v) length(find.package(p, quiet = TRUE)) > 0 && compareVersion(as.character(packageVersion(p)), v) >= 0, packs, versions))
if(!all(success)) install.packages(names(success)[!success], repos = paste0("file:///", getwd(), "/extras"), type = "win.binary")

load_R_Instat_packages()

setwd(dirname(parent.frame(2)$ofile))
source("instat_object_R6.R")
source("data_object_R6.R")
source("labels_and_defaults.R")
source("stand_alone_functions.R")
files <- sort(dir(file.path(getwd(), 'Backend_Components/'), pattern=".R$", full.names = TRUE))
invisible(lapply(files, source, chdir = TRUE))