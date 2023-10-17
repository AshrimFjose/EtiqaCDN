#pragma checksum "C:\Users\syamir.eusoff\Documents\Github\ashrim\EtiqaCDN\Views\Freelancer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bab1084798b6964e1da5dfc53ae3011a6d679af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Freelancer_Index), @"mvc.1.0.view", @"/Views/Freelancer/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\syamir.eusoff\Documents\Github\ashrim\EtiqaCDN\Views\_ViewImports.cshtml"
using EtiqaCDN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\syamir.eusoff\Documents\Github\ashrim\EtiqaCDN\Views\_ViewImports.cshtml"
using EtiqaCDN.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bab1084798b6964e1da5dfc53ae3011a6d679af", @"/Views/Freelancer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b14e4533ea162b8d4e163face2fabb9915f71a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Freelancer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--JQUERY-->
<script src=""https://code.jquery.com/jquery-3.7.1.min.js"" integrity=""sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo="" crossorigin=""anonymous""></script>
<!--BOOTSTRAP-->
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN"" crossorigin=""anonymous"">
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL"" crossorigin=""anonymous""></script>
<!--JQUERY DATATABLE-->
<link href=""https://cdn.datatables.net/1.13.6/css/jquery.dataTables.min.css"" rel=""stylesheet"" crossorigin=""anonymous"">
<script src=""https://cdn.datatables.net/1.13.6/js/jquery.dataTables.min.js"" crossorigin=""anonymous""></script>

<div class=""container"">
    <div class=""row"">
        <div class=""col"">            
            <a class=""btn btn-success m-2 text-light"" data-bs-toggl");
            WriteLiteral(@"e=""modal"" data-bs-target=""#createFreelancer"">ADD NEW FREELANCER</a>
        </div>
    </div>
    <hr/>
    <div class=""col"">
        <table id=""freelancer"" class=""display"" style=""width:100%"">
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>UserName</th>
                    <th>Email</th>
                    <th>Phone Number</th>
                    <th>Hobby</th>
                    <th>Skill Sets</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
            </tbody>
        </table>
    </div>
</div>

<!-- Create Modal -->
<div class=""modal fade"" id=""createFreelancer"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                ");
            WriteLiteral(@"<h1 class=""modal-title fs-5"" id=""exampleModalLabel"">ADD NEW FREELANCER</h1>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col mb-3"">                            
                            <label for=""createUserName"" class=""form-label"">User Name</label>
                            <input type=""text"" class=""form-control"" id=""createUserName""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2760, "\"", 2774, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col mb-3"">                            
                            <label for=""createFirstName"" class=""form-label"">First Name</label>
                            <input type=""text"" class=""form-control"" id=""firstName""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3131, "\"", 3145, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""col mb-3"">                            
                            <label for=""createLastName"" class=""form-label"">Last Name</label>
                            <input type=""text"" class=""form-control"" id=""createLastName""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3438, "\"", 3452, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col mb-3"">                            
                            <label for=""createEmail"" class=""form-label"">Email</label>
                            <input type=""email"" class=""form-control"" id=""createEmail""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3803, "\"", 3817, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""col mb-3"">                            
                            <label for=""createPhoneNum"" class=""form-label"">Phone Number</label>
                            <input type=""number"" class=""form-control"" id=""createPhoneNum""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 4115, "\"", 4129, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <label for=""createHobby"" class=""form-label"">Hobby</label>
                            <textarea class=""form-control"" id=""createHobby"" rows=""3""></textarea>
                        </div>
                        <div class=""col mb-3"">
                            <label for=""createSkillset"" class=""form-label"">Skill Sets</label>
                            <textarea class=""form-control"" id=""createSkillset"" rows=""3""></textarea>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""AddFreelancer()"">Add Freelancer</button>
            </div>
        </div>
    </div>
</div>

            WriteLiteral(@"
<!-- View Modal -->
<div class=""modal fade"" id=""viewFreelancer"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h1 class=""modal-title fs-5"" id=""exampleModalLabel"">VIEW FREELANCER</h1>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col mb-3"">                            
                            <label for=""viewUserName"" class=""form-label"">User Name</label>
                            <input type=""text"" class=""form-control"" id=""viewUserName""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 6073, "\"", 6087, 0);
            EndWriteAttribute();
            WriteLiteral(@" readonly>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col mb-3"">                            
                            <label for=""viewFirstName"" class=""form-label"">First Name</label>
                            <input type=""text"" class=""form-control"" id=""viewFirstName""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 6455, "\"", 6469, 0);
            EndWriteAttribute();
            WriteLiteral(@" readonly>
                        </div>
                        <div class=""col mb-3"">                            
                            <label for=""viewLastName"" class=""form-label"">Last Name</label>
                            <input type=""text"" class=""form-control"" id=""viewLastName""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 6767, "\"", 6781, 0);
            EndWriteAttribute();
            WriteLiteral(@" readonly>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col mb-3"">                            
                            <label for=""viewEmail"" class=""form-label"">Email</label>
                            <input type=""email"" class=""form-control"" id=""viewEmail""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 7137, "\"", 7151, 0);
            EndWriteAttribute();
            WriteLiteral(@" readonly>
                        </div>
                        <div class=""col mb-3"">                            
                            <label for=""viewPhoneNum"" class=""form-label"">Phone Number</label>
                            <input type=""number"" class=""form-control"" id=""viewPhoneNum""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 7454, "\"", 7468, 0);
            EndWriteAttribute();
            WriteLiteral(@" readonly>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <label for=""viewHobby"" class=""form-label"">Hobby</label>
                            <textarea class=""form-control"" id=""viewHobby"" rows=""3"" readonly></textarea>
                        </div>
                        <div class=""col mb-3"">
                            <label for=""viewSkillset"" class=""form-label"">Skill Sets</label>
                            <textarea class=""form-control"" id=""viewSkillset"" rows=""3"" readonly></textarea>
                        </div>
                    </div>
                </div>
            </div>            
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<!-- Edit Modal -->
<div class=""modal fade"" id=""editFreelancer"" data-bs-backdrop");
            WriteLiteral(@"=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h1 class=""modal-title fs-5"" id=""exampleModalLabel"">EDIT FREELANCER</h1>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col mb-3"">
                            <label for=""editUserName"" class=""form-label"">User Name</label>
                            <input type=""text"" class=""form-control"" id=""editUserName""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 9302, "\"", 9316, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <input type=\"text\" class=\"form-control\" id=\"editId\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 9399, "\"", 9413, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""display:none;"">
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col mb-3"">                            
                            <label for=""editFirstName"" class=""form-label"">First Name</label>
                            <input type=""text"" class=""form-control"" id=""editFirstName""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 9794, "\"", 9808, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""col mb-3"">                            
                            <label for=""editLastName"" class=""form-label"">Last Name</label>
                            <input type=""text"" class=""form-control"" id=""editLastName""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 10097, "\"", 10111, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col mb-3"">                            
                            <label for=""editEmail"" class=""form-label"">Email</label>
                            <input type=""email"" class=""form-control"" id=""editEmail""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 10458, "\"", 10472, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""col mb-3"">                            
                            <label for=""editPhoneNum"" class=""form-label"">Phone Number</label>
                            <input type=""number"" class=""form-control"" id=""editPhoneNum""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 10766, "\"", 10780, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <label for=""editHobby"" class=""form-label"">Hobby</label>
                            <textarea class=""form-control"" id=""editHobby"" rows=""3""></textarea>
                        </div>
                        <div class=""col mb-3"">
                            <label for=""editSkillset"" class=""form-label"">Skill Sets</label>
                            <textarea class=""form-control"" id=""editSkillset"" rows=""3""></textarea>
                        </div>
                    </div>
                </div>
            </div>            
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""EditFreelancer()"">Edit Freelancer</button>
            </div>
        </div>
    </div>
</d");
            WriteLiteral(@"iv>

<script type=""text/javascript"">
    $(function() {
        // Retrieve List of Freelancers
        $.ajax({
            type: 'GET',
            headers: {
              'Accept': 'application/json',
              'Content-Type': 'application/json',
              'Access-Control-Allow-Origin': '*'
            },
            url: '/api/Freelancer/GetAll',
            dataType: ""json"",
            success: function(response) {
                var data = response.Result;
                var table = $('#freelancer tbody');
                table.empty();
                $('#freelancer').show();
                var len = data.length;
                for (var i = 0; i < len; i++) {
                    var Id = data[i].Id;
                    var FirstName = data[i].FirstName;
                    var LastName = data[i].LastName;
                    var UserName = data[i].UserName;
                    var Email = data[i].Email;
                    var PhoneNum = data[i].PhoneNum;
      ");
            WriteLiteral(@"              var Hobby = data[i].Hobby;
                    var SkillSet = data[i].SkillSet;
                    table.append('<tr>' +
                        '<td>' + FirstName + '</td>' + 
                        '<td>' + LastName + '</td>' + 
                        '<td>' + UserName + '</td>' + 
                        '<td>' + Email + '</td>' + 
                        '<td>' + PhoneNum + '</td>' + 
                        '<td>' + Hobby + '</td>' + 
                        '<td>' + SkillSet + '</td>' +
					    '<td>' + 
						    '<div class=""dropdown"">' +
	                            '<button class=""btn btn-primary dropdown-toggle"" type=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">' +
		                            'Action' +
	                            '</button>' +
	                            '<ul class=""dropdown-menu"">' +
		                            '<li><a class=""dropdown-item"" href=""#"" onclick=""ViewFreelancer(\'' + Id + '\')"" data-bs-toggle=""modal"" data-bs-target=""");
            WriteLiteral(@"#viewFreelancer"">VIEW</a></li>' +
								'<li><a class=""dropdown-item border-top"" href=""#""  onclick=""ViewFreelancer(\'' + Id + '\')"" data-bs-toggle=""modal"" data-bs-target=""#editFreelancer"">EDIT</a></li>' +
		                            '<li><a class=""dropdown-item border-top"" href=""#"" onclick=""DeleteFreelancer(\'' + Id + '\')"">DELETE</a></li>' +
								'</ul>' +
                            '</div>' +
                        '</td>' +
					'</tr>');
                }
                new DataTable(""#freelancer"");
            },
            error: function(err) {
              alert(err);
            }
        });
    });

    function AddFreelancer() {
        $.ajax({
            type: 'POST',
            headers: {
              'Accept': 'application/json',
              'Content-Type': 'application/json',
              'Access-Control-Allow-Origin': '*'
            },
            url: '/api/Freelancer/Create',
            dataType: ""json"",
            data: JSON.stringify({
    ");
            WriteLiteral(@"            'UserName': $('#createUserName').val()
                , 'FirstName': $('#createFirstName').val()
                , 'LastName': $('#createLastName').val()
                , 'Email': $('#createEmail').val()
                , 'PhoneNum': $('#createPhoneNum').val()
                , 'Hobby': $('#createHobby').val()
                , 'SkillSet': $('#createSkillset').val()
            }),
            success: function(response) {
                if (response.Success) {
                    alert(response.Message);
                    location.reload();
                } else {
                    alert(response.Message);
                }
            }
        });
    }

    function ViewFreelancer(id) {
        $.ajax({
            type: 'GET',
            headers: {
              'Accept': 'application/json',
              'Content-Type': 'application/json',
              'Access-Control-Allow-Origin': '*'
            },
            url: '/api/Freelancer/GetById?Id=' + id,
");
            WriteLiteral(@"            dataType: ""json"",
            success: function(response) {
                var data = response.Result;
                var len = data.length;
                for (var i = 0; i < len; i++) {
                    // For View
                    $('#viewFirstName').val(data[i].FirstName);
                    $('#viewLastName').val(data[i].LastName);
                    $('#viewUserName').val(data[i].UserName);
                    $('#viewEmail').val(data[i].Email);
                    $('#viewPhoneNum').val(data[i].PhoneNum);
                    $('#viewHobby').val(data[i].Hobby);
                    $('#viewSkillSet').val(data[i].SkillSet);
                    // For Edit
                    $('#editId').val(data[i].Id);
                    $('#editFirstName').val(data[i].FirstName);
                    $('#editLastName').val(data[i].LastName);
                    $('#editUserName').val(data[i].UserName);
                    $('#editEmail').val(data[i].Email);
                    ");
            WriteLiteral(@"$('#editPhoneNum').val(data[i].PhoneNum);
                    $('#editHobby').val(data[i].Hobby);
                    $('#editSkillSet').val(data[i].SkillSet);
                }
            },
            error: function(err) {
              alert(err);
            }
        });
    }

    function EditFreelancer() {
        var id = $('#editId').val();

        if (id === null || id === '') {
            alert('No record Id detected.');
        } else {
            $.ajax({
                type: 'PUT',
                headers: {
                  'Accept': 'application/json',
                  'Content-Type': 'application/json',
                  'Access-Control-Allow-Origin': '*'
                },
                url: '/api/Freelancer/Update',
                dataType: ""json"",
                data: JSON.stringify({
                    'Id': id
                    , 'UserName': $('#editUserName').val()
                    , 'FirstName': $('#editFirstName').val()
               ");
            WriteLiteral(@"     , 'LastName': $('#editLastName').val()
                    , 'Email': $('#editEmail').val()
                    , 'PhoneNum': $('#editPhoneNum').val()
                    , 'Hobby': $('#editHobby').val()
                    , 'SkillSet': $('#editSkillset').val()
                }),
                success: function(response) {
                    if (response.Success) {
                        alert(response.Message);
                        location.reload();
                    } else {
                        alert(response.Message);
                    }
                }
            });
        }
    }

    function DeleteFreelancer(id) {
        $.ajax({
            type: 'DELETE',
            headers: {
              'Accept': 'application/json',
              'Content-Type': 'application/json',
              'Access-Control-Allow-Origin': '*'
            },
            url: '/api/Freelancer/Delete?Id=' + id,
            dataType: ""json"",
            success: function(r");
            WriteLiteral(@"esponse) {
                if (response.Success) {
                    alert(response.Message);
                    location.reload();
                } else {
                    alert(response.Message);
                }
            }
        });
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591