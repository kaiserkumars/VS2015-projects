﻿#pragma checksum "C:\Users\Deepak\documents\visual studio 2015\Projects\IamCharged\IamCharged\Views\Busy.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "55ACFA67088BA9D6AEA6FBC3D9804DBF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IamCharged.Views
{
    partial class Busy : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(global::Windows.UI.Xaml.Controls.ProgressRing obj, global::System.Boolean value)
            {
                obj.IsActive = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class Busy_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IBusy_Bindings
        {
            private global::IamCharged.Views.Busy dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ProgressRing obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;

            private Busy_obj1_BindingsTracking bindingsTracking;

            public Busy_obj1_Bindings()
            {
                this.bindingsTracking = new Busy_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.ProgressRing)target;
                        break;
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IBusy_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // Busy_obj1_Bindings

            public void SetDataRoot(global::IamCharged.Views.Busy newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::IamCharged.Views.Busy obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_IsBusy(obj.IsBusy, phase);
                        this.Update_BusyText(obj.BusyText, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_BusyText(phase);
                    }
                }
            }
            private void Update_IsBusy(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(this.obj2, obj);
                }
            }
            private void Update_BusyText(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                }
            }

            private void UpdateFallback_BusyText(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, "BusyText", null);
                }
            }

            private class Busy_obj1_BindingsTracking
            {
                global::System.WeakReference<Busy_obj1_Bindings> WeakRefToBindingObj; 

                public Busy_obj1_BindingsTracking(Busy_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<Busy_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void DependencyPropertyChanged_IsBusy(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    Busy_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::IamCharged.Views.Busy obj = sender as global::IamCharged.Views.Busy;
        if (obj != null)
        {
            bindings.Update_IsBusy(obj.IsBusy, DATA_CHANGED);
        }
                    }
                }
                public void DependencyPropertyChanged_BusyText(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    Busy_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::IamCharged.Views.Busy obj = sender as global::IamCharged.Views.Busy;
        if (obj != null)
        {
            bindings.Update_BusyText(obj.BusyText, DATA_CHANGED);
        }
        else
        {
        bindings.UpdateFallback_BusyText(DATA_CHANGED);
        }
                    }
                }
                private long tokenDPC_IsBusy = 0;
                private long tokenDPC_BusyText = 0;
                public void UpdateChildListeners_(global::IamCharged.Views.Busy obj)
                {
                    Busy_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::IamCharged.Views.Busy.IsBusyProperty, tokenDPC_IsBusy);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::IamCharged.Views.Busy.BusyTextProperty, tokenDPC_BusyText);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_IsBusy = obj.RegisterPropertyChangedCallback(global::IamCharged.Views.Busy.IsBusyProperty, DependencyPropertyChanged_IsBusy);
                            tokenDPC_BusyText = obj.RegisterPropertyChangedCallback(global::IamCharged.Views.Busy.BusyTextProperty, DependencyPropertyChanged_BusyText);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    Busy_obj1_Bindings bindings = new Busy_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

