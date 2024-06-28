
=========================================  By Sina Jangjoo    1403-03-27  ==========================================

--------------------------------------------------NuGet Packages ---------------------------------------------------

1-  NuGet packages that we need to install in this layer are these:  
                • Microsoft.EntityFrameworkCore.SqlServer
                • Microsoft.EntityFrameworkCore.Design


--------------------------------------------------Validations------------------------------------------------------

2-  In ModelState validations when we want to add personalize ModelError<> we have to define TWO properties!
          ModelState.AddModelError("Name", "The description cannot exactly match the Name.");  => ( Key , Description )
          • The first parameter is the "Key" (Where we want to show the validation error in UI. for eg. we show
                this error message under the "Name" <input/> field)
          • The second parameter is "Description" which is our error message words to show in UI
          • Pay attention to set the asp-validation-summary="ModelOnly"!
                In the UI if we set the asp-validation-summary="All" we can see all the error messages together in the same area!



--------------------------------------------------------------------------------------------------------------------

3-  Find(u=>u. ...)  is working based on PK (Primary Key) 

--------------------------------------------------------------------------------------------------------------------

4-  