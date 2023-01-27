// Copyright © 2023 Nikolay Melnikov. All rights reserved.
// SPDX-License-Identifier: Apache-2.0

namespace Depra.Vibration.Runtime
{
    public interface IVibrationService
    {
        void Vibrate(VibrationType type);

        void CancelAll();
    }
}