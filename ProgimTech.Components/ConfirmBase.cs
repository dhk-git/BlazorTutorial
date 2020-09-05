﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProgimTech.Components
{
    public class ConfirmBase : ComponentBase
    {
        protected bool ShowConfirmation { get; set; }
        
        [Parameter]
        public string ConfirmationTitle { get; set; } = "Delete Confirmation";
        
        [Parameter]
        public string ConfirmationMessage { get; set; } = "Are you sure you want to delete?";

        public void Show()
        {
            ShowConfirmation = true;
            StateHasChanged(); //Re rendering
        }
        [Parameter]
        public EventCallback<bool> ConfirmationChanged { get; set; }

        protected async Task OnConfirmationChange(bool value)
        {
            ShowConfirmation = false;
            await ConfirmationChanged.InvokeAsync(value);
        }
    }
}
