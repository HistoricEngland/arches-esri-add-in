# Arches ArcGIS Pro Add-in

### Abstract
  The Arches Add-In for ArcGIS Pro allows Arches users to access and manage their Arches data from within ArcGIS Pro. The Add-In leverages Koop geoservices (https://github.com/archesproject/arches-koop) to display existing Arches data within ArcGIS Pro. The Add-In allows user to perform two basic operations: edit existing geometry data and create new geometry data.
  
### [Prerequisites](#prerequisites)
### [Installing the Add-In](#installing-the-add-in)
### [Setting Up Koop services](#setting-up-koop-services)
### [Logging Into Arches](#logging-into-arches)
### [Editing an Existing Resource](#editing-an-existing-resource)
### [Creating a New Resource](#creating-a-new-resource)
  
  
### Prerequisites
  - ArcGIS Pro (v2.5)
  - Arches v5
  - A Koop service to display geometry data from your Arches instance
  
### Installing the Add-In
  To install the Arches download it to the same computer you have ArcGIS Pro installed on. Double click the Add-In to automatically install it to ArcGIS Pro.
  
### Setting Up Koop services
  The Arches-Esri Add-In relies Arches Koop to display Arches resource instance data in ArcGIS Pro. Arches Koop is a node application/server that translates Arches geojson data to an Esri geoservice that can be consumed by ArcGIS Online and ArcGIS Pro. For instructions on setting up a Koop service to serve your Arches data please visit the Arches-Koop repository here: https://github.com/archesproject/arches-koop

### Logging Into Arches
  In order to use the plugin the user must login to an existing deployment of Arches. Follow these step by step instructions to login to your deployment of Arches.
   1. First click the 'Arches Project' tab of the dockpane at the top of the ArcGIS Pro window. 
   2. Next click 'Arches Connection' from the 'Arches Project' tab.
   3. Under 'Arches Server URL' type the URL of your Arches deployment (make sure to include 'http://' and a trailing '/')
   4. For User Name and Password login as the Arches user you would like to edit as (Note: the user will need to have the correct permissions in your Arches deployment to create and/or edit a resource in order to create/edit a resource in the Add-In.)
   5. Finally click 'Connect'. Upon successful connection a message should appear in the dialog box saying 'Connected to Arches Server'
   
### Editing an Existing Resource
  The following steps outline how to edit an existing Arches geometry with the Arches-Esri Add-In
   1. Add your koop service layer(s) to the map, if you have not already.
      1. From the 'ArcGIS Pro Tools' section of the 'Arches Project' dock pane tab, select 'Add Data' -> 'Data from Path'
      2. On the next screen add the path of the Koop layer you would like to add. To add multiple layers you will have to repeat steps for each layer.
   2. Click 'Edit Resource' either in the 'Arches Project' tab in the dockpane or at the bottom of the Arches Project Add-In panel.
   3. Next choose 'Select' from the 'ArcGIS Pro Tools' section of the 'Arches Project' dock pane tab.
   4. Select the an Arches resource instance from one of the Koop layers you added before. Make sure to select one and just one instance.
   5. Once selected, press the 'Register Feature with Arches' button to indicate that this is the feature that you wish to edit.
   6. Now select the geometry(ies) that you wish to append to or replace the registered geometry.
   7. By default the plugin will append the selected geometries to the registered geometry. If you would like to completely relace the registered geometry, check         the 'Replace existing geometry' checkbox.
   8. Finally, click upload to send your new geometries to your Arches instance.
   After editing a geometry the Koop service should refresh to reflect your changes in ArcGIS Pro. You can also view the edits immediately by clicking the 'Edit        Using Arches Resource Editor' button at the bottom of the 'Edit Resource' tab of the Add-In.

### Creating a New Resource
  1. To create a new resource click 'Create Resource' in the 'Arches Project' dockpane or click the 'Create Resource' tab at the bottom of the Arches Add-In.
  2. In the 'Create Resource' tab select resource model and node you would like to create geometry for from the 'Select a Resource Type' dropdown. Note: If you do not see any resource models listed, check the Arches server or your user permissions.
  3. Select a geometry/geometries from the map that you would like to assign to the new resource.
  4. Click 'Upload Geometry to Arches' to create the new resource geometry in Arches.

