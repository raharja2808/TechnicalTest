Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Technical

Namespace Controllers
    Public Class TBL_EMPLController
        Inherits System.Web.Mvc.Controller

        Private db As New TechnicalTestEntities

        ' GET: TBL_EMPL
        Function Index() As ActionResult
            Return View(db.TBL_EMPL.ToList())
        End Function

        ' GET: TBL_EMPL/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tBL_EMPL As TBL_EMPL = db.TBL_EMPL.Find(id)
            If IsNothing(tBL_EMPL) Then
                Return HttpNotFound()
            End If
            Return View(tBL_EMPL)
        End Function

        ' GET: TBL_EMPL/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: TBL_EMPL/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="EMPLOYEE_ID,EMPLOYEE_NAME,AGE")> ByVal tBL_EMPL As TBL_EMPL) As ActionResult
            If ModelState.IsValid Then
                db.TBL_EMPL.Add(tBL_EMPL)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tBL_EMPL)
        End Function

        ' GET: TBL_EMPL/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tBL_EMPL As TBL_EMPL = db.TBL_EMPL.Find(id)
            If IsNothing(tBL_EMPL) Then
                Return HttpNotFound()
            End If
            Return View(tBL_EMPL)
        End Function

        ' POST: TBL_EMPL/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="EMPLOYEE_ID,EMPLOYEE_NAME,AGE")> ByVal tBL_EMPL As TBL_EMPL) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tBL_EMPL).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tBL_EMPL)
        End Function

        ' GET: TBL_EMPL/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tBL_EMPL As TBL_EMPL = db.TBL_EMPL.Find(id)
            If IsNothing(tBL_EMPL) Then
                Return HttpNotFound()
            End If
            Return View(tBL_EMPL)
        End Function

        ' POST: TBL_EMPL/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tBL_EMPL As TBL_EMPL = db.TBL_EMPL.Find(id)
            db.TBL_EMPL.Remove(tBL_EMPL)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
