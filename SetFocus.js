var lastFocusedControlId;

/*
* Handles page loaded event, finds first control on the page to set focus on and calles focus control on this control.
* This handler assigned to handle Sys.WebForms.PageRequestManager.getInstance().add_pageLoaded event on MasterPage
*/
function pageLoadedHandler(sender, args) {
// If you do not want focus set to the first element, comment out the next line.
   setTimeout("setFocus()",1000);
}

function setFocus(ctrl) {
    if (Fev_FocusOnFirstFocusableFormElement_FromSetFocus == null || typeof (Fev_FocusOnFirstFocusableFormElement_FromSetFocus) == "undefined") {
        return;
    }
    if (ctrl == null || typeof (ctrl) == "undefined" || ctrl == "") {
        lastFocusedControlId = Fev_FocusOnFirstFocusableFormElement_FromSetFocus();
    }
    else {
        lastFocusedControlId = ctrl;
    }
    if (lastFocusedControlId != null && typeof(lastFocusedControlId) !== "undefined" && lastFocusedControlId != "") {
        var newFocused = $get(lastFocusedControlId);
       if (newFocused) {
            focusControl(newFocused);
        }
    }
}


/*
* Sets the focus to the target control.
*/
function focusControl(targetControl) {
    if (Sys.Browser.agent === Sys.Browser.InternetExplorer) {
        var focusTarget = targetControl;
        targetControl.focus();

        if (focusTarget && (typeof(focusTarget.contentEditable) !== "undefined")) {
               oldContentEditableSetting = focusTarget.contentEditable;
               focusTarget.contentEditable = false;
            }
           else {
               focusTarget = null;
            }  
            if (focusTarget) {
            focusTarget.contentEditable = oldContentEditableSetting;
        }  
    }
    else {
        targetControl.focus();
    }
}

