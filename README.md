<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/500725287/23.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1095658)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# BI Dashboard for ASP.NET Core - How to Customize the Color Palette

This example illustrates how to customize the color palette for dashboard items in the Web Dashboard.

Restore npm packages to launch the project. Note that the script version on the client must match the version of libraries on the server.

## Overview

### Sales by Category Dashboard

In the *Sales By Category* dashboard, the [DashboardConfigurator.CustomPalette](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator.CustomPalette) event is used to substitute the default palette with a custom palette.

Both dashboard items use the global color scheme.

![Web Dashboard - Customizing Color Palettes Global Scheme](images/custom-color-palettes.png)

### Sales by SalesPerson Dashboard

In the *Sales By SalesPerson* dashboard, the color palette is changed in the UI. You can customize color palettes either in the [Dashboard Item Menu](https://docs.devexpress.com/Dashboard/117446/web-dashboard/ui-elements-and-customization/ui-elements/dashboard-item-menu) or in the [Color Scheme Page](https://docs.devexpress.com/Dashboard/117444/web-dashboard/ui-elements-and-customization/ui-elements/dashboard-menu). The pie dashboard item (Quantity) uses the local color scheme, other two dashboard items use the global color scheme.

![Web Dashboard - Customizing Color Palettes Local and Global Scheme](images/custom-color-palettes-local.png)

## Files to Review

- [Program.cs](./CS/WebDashboardCustomColorPalettes/Program.cs)

## Documentation

- [Coloring Basics](https://docs.devexpress.com/Dashboard/116915)
- [Coloring in the Web Dashboard](https://docs.devexpress.com/Dashboard/117152)

## More Examples

- [Dashboard for Web Forms - How to color dashboard item elements](https://github.com/DevExpress-Examples/web-forms-dashboard-color-dashboard-item-elements)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-core-dashboard-customize-color-palettes&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-core-dashboard-customize-color-palettes&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
