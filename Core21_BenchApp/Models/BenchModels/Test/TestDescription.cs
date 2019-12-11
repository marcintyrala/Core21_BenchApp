using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core21_BenchApp.Models.BenchModels.Test
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class TestDescription : BenchObjectBaseClass
    {

        private string descriptionField;

        private TestDescriptionLink[] linksField;

        private TestDescriptionMethod[] methodsField;

        private TestDescriptionInstrument[] instrumentsField;

        private TestDescriptionResumeCycles resumeCyclesField;

        private object extensionsField;

        private TestDescriptionDynamicMeasurementPlans dynamicMeasurementPlansField;

        private object refugeCyclesField;

        private object stopCyclesField;

        private string versionField;

        private string protectionField;

        private string nameField;

        private byte cntTimeAutoRestartField;

        private byte nbMaxAutoRestartField;

        private ushort secuInhibField;

        private uint t1FileSizeField;

        private byte t1PeriodField;

        private uint t2FileSizeField;

        private ushort t2PeriodField;

        private byte normalPeriodField;

        private byte fastPeriodField;

        private byte slowPeriodField;

        private ushort nbMaxPointField;

        private string groupNameField;

        private byte inheritT1Field;

        private byte inheritT2Field;

        private byte inheritMiscField;

        private byte inheritResumeField;

        private string t1StartTriggerConditionField;

        private string t1StopTriggerConditionField;

        private string t2StartTriggerConditionField;

        private string t2StopTriggerConditionField;

        private byte fileVersionField;

        private string rightsField;

        private string scriptRefField;

        private string initField;

        private string stopField;

        private string measuresPlanFileField;

        private string procedureField;

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Link", IsNullable = false)]
        public TestDescriptionLink[] Links
        {
            get
            {
                return this.linksField;
            }
            set
            {
                this.linksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Method", IsNullable = false)]
        public TestDescriptionMethod[] Methods
        {
            get
            {
                return this.methodsField;
            }
            set
            {
                this.methodsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Instrument", IsNullable = false)]
        public TestDescriptionInstrument[] Instruments
        {
            get
            {
                return this.instrumentsField;
            }
            set
            {
                this.instrumentsField = value;
            }
        }

        /// <remarks/>
        public TestDescriptionResumeCycles ResumeCycles
        {
            get
            {
                return this.resumeCyclesField;
            }
            set
            {
                this.resumeCyclesField = value;
            }
        }

        /// <remarks/>
        public object Extensions
        {
            get
            {
                return this.extensionsField;
            }
            set
            {
                this.extensionsField = value;
            }
        }

        /// <remarks/>
        public TestDescriptionDynamicMeasurementPlans DynamicMeasurementPlans
        {
            get
            {
                return this.dynamicMeasurementPlansField;
            }
            set
            {
                this.dynamicMeasurementPlansField = value;
            }
        }

        /// <remarks/>
        public object RefugeCycles
        {
            get
            {
                return this.refugeCyclesField;
            }
            set
            {
                this.refugeCyclesField = value;
            }
        }

        /// <remarks/>
        public object StopCycles
        {
            get
            {
                return this.stopCyclesField;
            }
            set
            {
                this.stopCyclesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Protection
        {
            get
            {
                return this.protectionField;
            }
            set
            {
                this.protectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte CntTimeAutoRestart
        {
            get
            {
                return this.cntTimeAutoRestartField;
            }
            set
            {
                this.cntTimeAutoRestartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte NbMaxAutoRestart
        {
            get
            {
                return this.nbMaxAutoRestartField;
            }
            set
            {
                this.nbMaxAutoRestartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort SecuInhib
        {
            get
            {
                return this.secuInhibField;
            }
            set
            {
                this.secuInhibField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint T1FileSize
        {
            get
            {
                return this.t1FileSizeField;
            }
            set
            {
                this.t1FileSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte T1Period
        {
            get
            {
                return this.t1PeriodField;
            }
            set
            {
                this.t1PeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint T2FileSize
        {
            get
            {
                return this.t2FileSizeField;
            }
            set
            {
                this.t2FileSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort T2Period
        {
            get
            {
                return this.t2PeriodField;
            }
            set
            {
                this.t2PeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte NormalPeriod
        {
            get
            {
                return this.normalPeriodField;
            }
            set
            {
                this.normalPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte FastPeriod
        {
            get
            {
                return this.fastPeriodField;
            }
            set
            {
                this.fastPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte SlowPeriod
        {
            get
            {
                return this.slowPeriodField;
            }
            set
            {
                this.slowPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort NbMaxPoint
        {
            get
            {
                return this.nbMaxPointField;
            }
            set
            {
                this.nbMaxPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GroupName
        {
            get
            {
                return this.groupNameField;
            }
            set
            {
                this.groupNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte InheritT1
        {
            get
            {
                return this.inheritT1Field;
            }
            set
            {
                this.inheritT1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte InheritT2
        {
            get
            {
                return this.inheritT2Field;
            }
            set
            {
                this.inheritT2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte InheritMisc
        {
            get
            {
                return this.inheritMiscField;
            }
            set
            {
                this.inheritMiscField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte InheritResume
        {
            get
            {
                return this.inheritResumeField;
            }
            set
            {
                this.inheritResumeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string T1StartTriggerCondition
        {
            get
            {
                return this.t1StartTriggerConditionField;
            }
            set
            {
                this.t1StartTriggerConditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string T1StopTriggerCondition
        {
            get
            {
                return this.t1StopTriggerConditionField;
            }
            set
            {
                this.t1StopTriggerConditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string T2StartTriggerCondition
        {
            get
            {
                return this.t2StartTriggerConditionField;
            }
            set
            {
                this.t2StartTriggerConditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string T2StopTriggerCondition
        {
            get
            {
                return this.t2StopTriggerConditionField;
            }
            set
            {
                this.t2StopTriggerConditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte FileVersion
        {
            get
            {
                return this.fileVersionField;
            }
            set
            {
                this.fileVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Rights
        {
            get
            {
                return this.rightsField;
            }
            set
            {
                this.rightsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ScriptRef
        {
            get
            {
                return this.scriptRefField;
            }
            set
            {
                this.scriptRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Init
        {
            get
            {
                return this.initField;
            }
            set
            {
                this.initField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Stop
        {
            get
            {
                return this.stopField;
            }
            set
            {
                this.stopField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MeasuresPlanFile
        {
            get
            {
                return this.measuresPlanFileField;
            }
            set
            {
                this.measuresPlanFileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Procedure
        {
            get
            {
                return this.procedureField;
            }
            set
            {
                this.procedureField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TestDescriptionLink
    {

        private string nameField;

        private string referenceField;

        private string optionalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Optional
        {
            get
            {
                return this.optionalField;
            }
            set
            {
                this.optionalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TestDescriptionMethod
    {

        private string nameField;

        private string visibilityField;

        private string referenceField;

        private string visibleInScriptField;

        private string precompileField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Visibility
        {
            get
            {
                return this.visibilityField;
            }
            set
            {
                this.visibilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VisibleInScript
        {
            get
            {
                return this.visibleInScriptField;
            }
            set
            {
                this.visibleInScriptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Precompile
        {
            get
            {
                return this.precompileField;
            }
            set
            {
                this.precompileField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TestDescriptionInstrument
    {

        private string nameField;

        private string menuNameField;

        private string referenceField;

        private string rightsField;

        private string screen1Field;

        private string screen2Field;

        private string screen3Field;

        private string screen4Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MenuName
        {
            get
            {
                return this.menuNameField;
            }
            set
            {
                this.menuNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Rights
        {
            get
            {
                return this.rightsField;
            }
            set
            {
                this.rightsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Screen1
        {
            get
            {
                return this.screen1Field;
            }
            set
            {
                this.screen1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Screen2
        {
            get
            {
                return this.screen2Field;
            }
            set
            {
                this.screen2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Screen3
        {
            get
            {
                return this.screen3Field;
            }
            set
            {
                this.screen3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Screen4
        {
            get
            {
                return this.screen4Field;
            }
            set
            {
                this.screen4Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TestDescriptionResumeCycles
    {

        private TestDescriptionResumeCyclesResumeCycle resumeCycleField;

        /// <remarks/>
        public TestDescriptionResumeCyclesResumeCycle ResumeCycle
        {
            get
            {
                return this.resumeCycleField;
            }
            set
            {
                this.resumeCycleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TestDescriptionResumeCyclesResumeCycle
    {

        private string referenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TestDescriptionDynamicMeasurementPlans
    {

        private string dynamicMeasurementPlanField;

        /// <remarks/>
        public string DynamicMeasurementPlan
        {
            get
            {
                return this.dynamicMeasurementPlanField;
            }
            set
            {
                this.dynamicMeasurementPlanField = value;
            }
        }
    }


}
