# SampleProjects

**How It Works
Frontend:**

The form is rendered in a Razor view (Views/Home/User.cshtml).
Users input First Name and Last Name and submit the form.

**Backend:**

The HomeController processes the form data in the Post method.
The submitted data is serialized into JSON and saved to a file named UserName.json.

**File Structure**

/Controllers  
  - HomeController.cs  
/Models  
  - User.cs  
/Views  
  /Home  
    - User.cshtml  
/wwwroot
  /css  
  - Style.css  

Example Data in UserName.json
json

{  
  "FirstName": "John",  
  "LastName": "Doe"  
}  

