﻿///////////////////////////////////////////////////////////////////////////////
//   Copyright 2012 Z-Ware Ltd.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZAws
{
    abstract class ZAwsObject
    {
        public readonly ZAwsEc2Controller myController;
        protected ZAwsObject(ZAwsEc2Controller controller)
        {
            myController = controller;
        }

        public event EventHandler StatusChanged;
        public event EventHandler ObjectDeleted;

        protected void TriggerStatusChanged()
        {
            if(StatusChanged != null)
            {
                StatusChanged(this, EventArgs.Empty);
            }
        }
        protected void TriggerObjectDeleted()
        {
            if (ObjectDeleted != null)
            {
                ObjectDeleted(this, EventArgs.Empty);
            }
        }

        internal void Update(Object ResponseData)
        {
            if (DoUpdate(ResponseData))
            {
                TriggerStatusChanged();
            }
        }

        //This should be called only by the Controller when the object is noticed not to be there anymore - so the deletion is complete.
        internal virtual void Delete()
        {
            TriggerObjectDeleted();
        }

        public virtual string Id { get { return Name; } }
        public abstract string Name { get; }
        public virtual string Description
        {
            get { return ""; }
        }

        protected abstract bool DoUpdate(Object responseData);
        protected abstract void DoDeleteObject();
        internal abstract bool EqualsData(Object responseData);

        //This is called when the object should be deleted
        public void DeleteObject()
        {
            DoDeleteObject();
        }
    }
}
