<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CustomDatePicker.ascx.cs" Inherits="CMSApp.CMSFormControls.CustomDatePicker" %>


<link rel="stylesheet" type="text/css" href="/CMSModules/Content/CMSDesk/App_Themes/DatePicker/jquery.datetimepicker.css"/>
<script src="/CMSModules/Content/CMSDesk/App_Themes/DatePicker/jquery.js"></script>
<script src="/CMSModules/Content/CMSDesk/App_Themes/DatePicker/jquery.datetimepicker.full.js"></script>   
               
<asp:TextBox ID="datePicker" runat="server"  CssClass="form-control EditingFormCalendarTextBox CalendarTextBox input-width-58 hasDatepicker" autocomplete="off"></asp:TextBox>           

        

            <script>
                /*jslint browser:true*/
                /*global jQuery, document*/

                jQuery(document).ready(function () {
                    'use strict';

                    jQuery('#m_c_f_BootstrapDatepicker_datePicker').datetimepicker();
                });
            </script>
   







