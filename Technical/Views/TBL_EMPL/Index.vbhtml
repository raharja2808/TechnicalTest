@ModelType IEnumerable(Of Technical.TBL_EMPL)

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.EMPLOYEE_NAME)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.AGE)
            </th>
            <th></th>
        </tr>
    
    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.EMPLOYEE_NAME)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.AGE)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.EMPLOYEE_ID }) |
                @Html.ActionLink("Details", "Details", New With {.id = item.EMPLOYEE_ID }) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.EMPLOYEE_ID })
            </td>
        </tr>
    Next
    
    </table>
</body>
</html>
