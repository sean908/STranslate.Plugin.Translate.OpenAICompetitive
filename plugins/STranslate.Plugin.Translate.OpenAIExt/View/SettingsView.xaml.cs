using System;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;
using STranslate.Plugin.Translate.OpenAIExt.ViewModel;

namespace STranslate.Plugin.Translate.OpenAIExt.View;

public partial class SettingsView
{
    private bool _isCommittingModelSelection;
    private bool _isOpeningModelDropdownForFilter;

    public SettingsView()
    {
        InitializeComponent();

        PART_ModelComboBox.AddHandler(TextBoxBase.TextChangedEvent, new TextChangedEventHandler(OnModelComboBoxTextChanged));
    }

    private void OnModelComboBoxTextChanged(object sender, TextChangedEventArgs e)
    {
        if (_isCommittingModelSelection || !PART_ModelComboBox.IsKeyboardFocusWithin)
            return;

        if (!PART_ModelComboBox.IsDropDownOpen)
        {
            _isOpeningModelDropdownForFilter = true;
            PART_ModelComboBox.IsDropDownOpen = true;
        }
    }

    private void OnModelComboBoxDropDownOpened(object sender, EventArgs e)
    {
        if (_isOpeningModelDropdownForFilter)
        {
            _isOpeningModelDropdownForFilter = false;
            return;
        }

        if (DataContext is SettingsViewModel viewModel)
            viewModel.ShowAllModels();
    }

    private void OnModelComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (PART_ModelComboBox.SelectedItem is not string model ||
            DataContext is not SettingsViewModel viewModel)
        {
            return;
        }

        _isCommittingModelSelection = true;
        Dispatcher.BeginInvoke(new Action(() =>
        {
            try
            {
                viewModel.CommitModelSelection(model);
                PART_ModelComboBox.IsDropDownOpen = false;
            }
            finally
            {
                _isCommittingModelSelection = false;
            }
        }), DispatcherPriority.ContextIdle);
    }
}
