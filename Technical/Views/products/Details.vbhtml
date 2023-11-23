@ModelType Technical.product
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>product</h4>
    <hr />
    <dl class="dl-horizontal">
    </dl>
</div>
<p>
    @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
    @Html.ActionLink("Back to List", "Index")
</p>
