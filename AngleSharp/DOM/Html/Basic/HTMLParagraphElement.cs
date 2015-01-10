﻿namespace AngleSharp.DOM.Html
{
    using AngleSharp.Extensions;
    using AngleSharp.Html;

    /// <summary>
    /// Represents the HTML paragraph element.
    /// </summary>
    sealed class HTMLParagraphElement : HTMLElement, IHtmlParagraphElement
    {
        #region ctor

        /// <summary>
        /// Creates a new HTML paragraph element.
        /// </summary>
        public HTMLParagraphElement(Document owner)
            : base(Tags.P, NodeFlags.Special | NodeFlags.ImplicitelyClosed | NodeFlags.ImpliedEnd)
        {
            Owner = owner;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the value of the alignment attribute.
        /// </summary>
        public HorizontalAlignment Align
        {
            get { return GetAttribute(AttributeNames.Align).ToEnum(HorizontalAlignment.Left); }
            set { SetAttribute(AttributeNames.Align, value.ToString()); }
        }

        #endregion
    }
}
