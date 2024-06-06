﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// MUX Reference dxaml\xcp\core\input\KeyboardAccelerator.cpp, tag winui3/release/1.4.3, commit 685d2bf

using DirectUI;
using Uno.UI.Xaml;
using Windows.System;
using static Microsoft/* UWP don't rename */.UI.Xaml.Controls._Tracing;

namespace Microsoft.UI.Xaml.Input;

partial class KeyboardAccelerator
{
	//  Add our events to the global event request list.
	//  Need to do this ourselves since we don't derive from CUIElement.
	private void EnterImpl(
		DependencyObject pNamescopeOwner,
		EnterParams enterParams)
	{
		// base.EnterImpl(pNamescopeOwner, enterParams);

		if (enterParams.IsLive)
		{
			//TODO:MZ Implement this
			//// If there are events registered on this element, ask the
			//// EventManager to extract them and create a request for every event.
			//var core = GetContext();
			//if (m_pEventList)
			//{
			//	// Get the event manager.
			//	IFCEXPECT_ASSERT_RETURN(core);
			//	CEventManager * const pEventManager = core->GetEventManager();
			//	IFCEXPECT_ASSERT_RETURN(pEventManager);
			//	IFC_RETURN(pEventManager->AddRequestsInOrder(this, m_pEventList));
			//}
			//KeyboardAcceleratorCollection * const pCollection = do_pointer_cast<KeyboardAcceleratorCollection>(this->GetParentInternal(false /* publicParentOnly */));
			//IFCPTR_RETURN(pCollection);
			//DependencyObject* pParentElement = pCollection->GetParentInternal(false /* publicParentOnly */);

			//// Do not set tooltip if
			//// 1. Parent element has disabled the keyboard accelerator tooltip.
			//// 2. current keyboard accelerator is disabled.

			//KeyboardAcceleratorPlacementMode kaPlacementMode = KeyboardAcceleratorPlacementMode.Auto;

			//var kaPlacementMode = (KeyboardAcceleratorPlacementMode)element.GetValue(UIElement.KeyboardAcceleratorPlacementModeProperty);

			//if (kaPlacementMode == KeyboardAcceleratorPlacementMode.Hidden
			//	|| !this.IsEnabled
			//	|| this.m_key == VirtualKey.None)

			//{
			//	// Don't show a tooltip for an accelerator, no need to make the popup
			//	return;
			//}

			//// Create and set tooltip on parent control, only if this is the first tooltip enabled accelerator in the collection.
			//foreach (DependencyObject accelerator in collection)
			//{
			//	MUX_ASSERT(accelerator is KeyboardAccelerator);

			//	if (((KeyboardAccelerator)accelerator).IsEnabled)
			//	{
			//		if (accelerator == this)
			//		{
			//			FxCallbacks.KeyboardAccelerator_SetToolTip(this, pParentElement);
			//		}
			//		break;
			//	}
			//}
		}
	}
}
