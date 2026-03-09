using UnityEditor;

namespace NaughtyAttributes.Editor
{
    public class NaughtyProperty
    {
        public SerializedProperty serializedProperty;
        
        public LabelAttribute labelAttribute;
        
        public SpecialCaseDrawerAttribute specialCaseDrawerAttribute;
        
        public ShowIfAttributeBase showIfAttribute;
        public EnableIfAttributeBase enableIfAttribute;
        public ReadOnlyAttribute readOnlyAttribute;
        public ValidatorAttribute[] validatorAttributes;

        public bool cachedIsVisible = true;
        public bool cachedIsEnabled = true;

        public bool CheckVisibleAndEnabled()
        {
            cachedIsEnabled = PropertyUtility.IsEnabled(readOnlyAttribute, enableIfAttribute, serializedProperty);
            return cachedIsVisible = PropertyUtility.IsVisible(showIfAttribute, serializedProperty);
        }
    }
}
