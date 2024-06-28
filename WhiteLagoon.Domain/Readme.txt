
==================================  By Sina Jangjoo    1403-03-27  ====================================


1-  The INNER layer in clean architecture is "Domain" layer

2-  We define and implement our Database inside this layer

3-  The folder "Entities" in our Domain is exactly our Model folder in MVC architecture


--------------------------------------------  Data Annotation -------------------------------------------

1-	[Key, DatabaseGenerated(DatabaseGeneratedOption.None)] 
    [Display(Name = "Villa Number")]
    public int Villa_Number { get; set; }

        • It means 

