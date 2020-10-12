CONTENTS FOR THIS FILE
----------------------
INTRODUCTION

REQUIRMENTS

INSTALLATION

USE

MAINTAINERS

FUTURE ADDITIONS	

INTRODUCTION
-------------

Project: Good Smokes

Good Smokes is a cigar database and information site. It is our aim to provide a space where people can not only learn about individual cigars, their shapes, sizes, tastes and makers, 
but also learn about the history behide what they are smoking.


REQUIRMENTS
------------
This module requires you to have Microsoft Visual Studio. You can download this program here https://visualstudio.microsoft.com/downloads/.

The following Nuget Pacackages should be already installed when you download to Visual Studio. However you may need to update some of the versions. 
Please verify the follwing NuGet packages are present before using the application:

Antlr v3.5.0.2

bootstrap v4.5.2

EntityFramework v6.4.4

DummyData v0.0.46

jQuery v3.5.1

jQuery.Validation v1.19.2

Microsoft.aspNet.Identity.Core v2.2.3

Microsoft.AspNet.Identity.EntityFramework v2.2.3

Microft.AspNet.Identity.Orwin v2.2.3

Microsoft.AspNet.WebApi v5.2.7

Microsoft.AspNet.WebApi.Client v5.2.7

Microsoft.AspNet.WebApi.Core v5.2.7

Microsoft.AspNet.WebApi.HelpPage v5.2.7

Microsoft.AspNet.WebApi.Owin v4.1.1

Microsoft.AspNet.WebApi.WebHost v5.2.7

Microsoft.CodeDom.Providers.DotNetCompilerPlatform v3.6.0

Microsoft.jQuery.Unobtrusive.Validation v3.2.11

Microsoft.Owin v4.1.1

Microsoft.Owin.Host.SystemWeb v4.1.1

Microsoft.Owin.Security v4.1.1

Microsoft.Owin.Security.Cookies v4.1.1

Microsoft.Owin.Security.Facebook v4.1.1

Microsoft.Owin.Security.Google v4.1.1

Microsoft.Owin.Security.MicrosoftAccount v4.1.1

Microsoft.Owin.Security.OAuth v4.1.1

Microsoft.Owin.Security.Twitter v4.1.1

Microsoft.Web.Infrastructure v1.0.0

Modernizr v2.8.3

Newtonsoft.Json v12.0.3

Owin v1.0.0

popper.js v1.16.1

WebGrease v1.6.0


INSTALLATION
------------

If you have Visual Studio Code already then you will need to click the download code button in GitHub to complete the download and installation.


USE
----------

Once you finish downloading the folders from GitHub setting everything up in Visual Studion you will need to launch the application. This will take you to the localhost ASP.Net page.

The first this you will need to do is create a username and password. These will serve as your log in credentials from here on.

After you are registered you now should have access to the database. 

From here you can click on the Cigars, Brands, or Sizes tabs to bring up thier index's. You can also visit the Links tab for addition materials on cigars as well as a couple links to cigar buying websites.

In the individual tabs you have the ability to scroll through the exisiting index, view the item details, create new items, editi existing ones, or delete exisiting ones.

*Creating Items*

To create a new item simply click the create button in the top left corner of the index. This will take you to the create menu. Follow the instruction listed here, and add in the required information.

After you are finished click create, and you should see your new item listed in the cooresponding index.

*Deleting Items*

To delete an item first click the delete button on the right side of the item chart in the index. 

This will take you to the delete menu. From here click on the delete button. You will be propted to concent tfurther. Select yes. Your Item should now be deleted.

*Editing Items*

To edit an item begin by clicking on the edit tab to the right of the item you wish to edit.

This will take you to the edit menu. From here you can edit any of the information present except the items ID that cannot be changed and you will create an error if you attempt to change it. 

You can however update associated IDs in the Edit Cigar menu because you are editing the Brand and Size Ids associated with the cigar, not changing the Ids all together.

Once you have reviewed your changes click edit and your changes will be added to the index.

MAINTAINERS
---------------------

Kyle Rambo (Kyle Rambo) krambo89@gmail.com

This project was entirely self funded, and was made possible thanks to the hard work and dedication of the contributors listed above.

Future Additions
-------------

We hope to add multiple new catagories and style changes moving forward. Most noteably:

Drop down menus for the edit and create view which will help users more easily navigate those tasks.

Shape, taste, and drink pairing catagories.

A section about cigars from different countries.



If there are any  bugs or issues with the program please forward questions on to krambo89@gmail.com.
