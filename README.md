![Logo](documentation/images/smp/Details.png?raw=true "Sitecore Marketplace Website")

# Sitecore Marketplace Website

## Prerequisites

* Install [Sitecore 9.3 (Initial Release)](https://dev.sitecore.net/Downloads/Sitecore_Experience_Platform/93/Sitecore_Experience_Platform_93_Initial_Release.aspx)
* Install SXA 9.3

* Deploy Solution using **build.ps1** 
script

* Create both SXA Tenant and SXA Site like below:

![SXA assets](documentation/images/smp/SXA.png?raw=true "Sitecore Marketplace Website")

* Install our custom SXA Modules:

![Custom SXA module](documentation/images/smp/Modules.png?raw=true "Sitecore Marketplace Website")

## Site Appearance

* `Landing Page` with `Search Bar` and **most popular modules' categories**

![Landing Categories](documentation/images/smp/Landing_Categories.png?raw=true "Sitecore Marketplace Website")


* `Search Results Page`

![Search Page](documentation/images/smp/Search_Page.png "Sitecore Marketplace Website")


* `Module Details Page`

![Details Page](documentation/images/smp/Details.png "Sitecore Marketplace Website")

## Site Structure

* `Easy to maintain`

A few page items allow us to maintain all logic for Featured Modules sections, Search results and Modules details. Sitecore wildcard feature help us to use one page for every model's details.

![Content Structure](documentation/images/smp/Content_Structure.png "Sitecore Marketplace Website")

* `Wise storage`

Modules could be added by content editor and will be stored as bucketable item. The Search Index will use the data for search page and category block on pages.

![Bucket storage](documentation/images/smp/Buckets.png "Sitecore Marketplace Website")