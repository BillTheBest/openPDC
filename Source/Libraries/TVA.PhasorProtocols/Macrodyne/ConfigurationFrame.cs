//*******************************************************************************************************
//  ConfigurationFrame.cs - Gbtc
//
//  Tennessee Valley Authority, 2009
//  No copyright is claimed pursuant to 17 USC § 105.  All Other Rights Reserved.
//
//  This software is made freely available under the TVA Open Source Agreement (see below).
//
//  Code Modification History:
//  -----------------------------------------------------------------------------------------------------
//  04/30/2009 - J. Ritchie Carroll
//       Generated original version of source code.
//  08/07/2009 - Josh L. Patterson
//       Edited Comments.
//  09/15/2009 - Stephen C. Wills
//       Added new header and license agreement.
//
//*******************************************************************************************************

#region [ TVA Open Source Agreement ]
/*

 THIS OPEN SOURCE AGREEMENT ("AGREEMENT") DEFINES THE RIGHTS OF USE,REPRODUCTION, DISTRIBUTION,
 MODIFICATION AND REDISTRIBUTION OF CERTAIN COMPUTER SOFTWARE ORIGINALLY RELEASED BY THE
 TENNESSEE VALLEY AUTHORITY, A CORPORATE AGENCY AND INSTRUMENTALITY OF THE UNITED STATES GOVERNMENT
 ("GOVERNMENT AGENCY"). GOVERNMENT AGENCY IS AN INTENDED THIRD-PARTY BENEFICIARY OF ALL SUBSEQUENT
 DISTRIBUTIONS OR REDISTRIBUTIONS OF THE SUBJECT SOFTWARE. ANYONE WHO USES, REPRODUCES, DISTRIBUTES,
 MODIFIES OR REDISTRIBUTES THE SUBJECT SOFTWARE, AS DEFINED HEREIN, OR ANY PART THEREOF, IS, BY THAT
 ACTION, ACCEPTING IN FULL THE RESPONSIBILITIES AND OBLIGATIONS CONTAINED IN THIS AGREEMENT.

 Original Software Designation: openPDC
 Original Software Title: The TVA Open Source Phasor Data Concentrator
 User Registration Requested. Please Visit https://naspi.tva.com/Registration/
 Point of Contact for Original Software: J. Ritchie Carroll <mailto:jrcarrol@tva.gov>

 1. DEFINITIONS

 A. "Contributor" means Government Agency, as the developer of the Original Software, and any entity
 that makes a Modification.

 B. "Covered Patents" mean patent claims licensable by a Contributor that are necessarily infringed by
 the use or sale of its Modification alone or when combined with the Subject Software.

 C. "Display" means the showing of a copy of the Subject Software, either directly or by means of an
 image, or any other device.

 D. "Distribution" means conveyance or transfer of the Subject Software, regardless of means, to
 another.

 E. "Larger Work" means computer software that combines Subject Software, or portions thereof, with
 software separate from the Subject Software that is not governed by the terms of this Agreement.

 F. "Modification" means any alteration of, including addition to or deletion from, the substance or
 structure of either the Original Software or Subject Software, and includes derivative works, as that
 term is defined in the Copyright Statute, 17 USC § 101. However, the act of including Subject Software
 as part of a Larger Work does not in and of itself constitute a Modification.

 G. "Original Software" means the computer software first released under this Agreement by Government
 Agency entitled openPDC, including source code, object code and accompanying documentation, if any.

 H. "Recipient" means anyone who acquires the Subject Software under this Agreement, including all
 Contributors.

 I. "Redistribution" means Distribution of the Subject Software after a Modification has been made.

 J. "Reproduction" means the making of a counterpart, image or copy of the Subject Software.

 K. "Sale" means the exchange of the Subject Software for money or equivalent value.

 L. "Subject Software" means the Original Software, Modifications, or any respective parts thereof.

 M. "Use" means the application or employment of the Subject Software for any purpose.

 2. GRANT OF RIGHTS

 A. Under Non-Patent Rights: Subject to the terms and conditions of this Agreement, each Contributor,
 with respect to its own contribution to the Subject Software, hereby grants to each Recipient a
 non-exclusive, world-wide, royalty-free license to engage in the following activities pertaining to
 the Subject Software:

 1. Use

 2. Distribution

 3. Reproduction

 4. Modification

 5. Redistribution

 6. Display

 B. Under Patent Rights: Subject to the terms and conditions of this Agreement, each Contributor, with
 respect to its own contribution to the Subject Software, hereby grants to each Recipient under Covered
 Patents a non-exclusive, world-wide, royalty-free license to engage in the following activities
 pertaining to the Subject Software:

 1. Use

 2. Distribution

 3. Reproduction

 4. Sale

 5. Offer for Sale

 C. The rights granted under Paragraph B. also apply to the combination of a Contributor's Modification
 and the Subject Software if, at the time the Modification is added by the Contributor, the addition of
 such Modification causes the combination to be covered by the Covered Patents. It does not apply to
 any other combinations that include a Modification. 

 D. The rights granted in Paragraphs A. and B. allow the Recipient to sublicense those same rights.
 Such sublicense must be under the same terms and conditions of this Agreement.

 3. OBLIGATIONS OF RECIPIENT

 A. Distribution or Redistribution of the Subject Software must be made under this Agreement except for
 additions covered under paragraph 3H. 

 1. Whenever a Recipient distributes or redistributes the Subject Software, a copy of this Agreement
 must be included with each copy of the Subject Software; and

 2. If Recipient distributes or redistributes the Subject Software in any form other than source code,
 Recipient must also make the source code freely available, and must provide with each copy of the
 Subject Software information on how to obtain the source code in a reasonable manner on or through a
 medium customarily used for software exchange.

 B. Each Recipient must ensure that the following copyright notice appears prominently in the Subject
 Software:

          No copyright is claimed pursuant to 17 USC § 105.  All Other Rights Reserved.

 C. Each Contributor must characterize its alteration of the Subject Software as a Modification and
 must identify itself as the originator of its Modification in a manner that reasonably allows
 subsequent Recipients to identify the originator of the Modification. In fulfillment of these
 requirements, Contributor must include a file (e.g., a change log file) that describes the alterations
 made and the date of the alterations, identifies Contributor as originator of the alterations, and
 consents to characterization of the alterations as a Modification, for example, by including a
 statement that the Modification is derived, directly or indirectly, from Original Software provided by
 Government Agency. Once consent is granted, it may not thereafter be revoked.

 D. A Contributor may add its own copyright notice to the Subject Software. Once a copyright notice has
 been added to the Subject Software, a Recipient may not remove it without the express permission of
 the Contributor who added the notice.

 E. A Recipient may not make any representation in the Subject Software or in any promotional,
 advertising or other material that may be construed as an endorsement by Government Agency or by any
 prior Recipient of any product or service provided by Recipient, or that may seek to obtain commercial
 advantage by the fact of Government Agency's or a prior Recipient's participation in this Agreement.

 F. In an effort to track usage and maintain accurate records of the Subject Software, each Recipient,
 upon receipt of the Subject Software, is requested to register with Government Agency by visiting the
 following website: https://naspi.tva.com/Registration/. Recipient's name and personal information
 shall be used for statistical purposes only. Once a Recipient makes a Modification available, it is
 requested that the Recipient inform Government Agency at the web site provided above how to access the
 Modification.

 G. Each Contributor represents that that its Modification does not violate any existing agreements,
 regulations, statutes or rules, and further that Contributor has sufficient rights to grant the rights
 conveyed by this Agreement.

 H. A Recipient may choose to offer, and to charge a fee for, warranty, support, indemnity and/or
 liability obligations to one or more other Recipients of the Subject Software. A Recipient may do so,
 however, only on its own behalf and not on behalf of Government Agency or any other Recipient. Such a
 Recipient must make it absolutely clear that any such warranty, support, indemnity and/or liability
 obligation is offered by that Recipient alone. Further, such Recipient agrees to indemnify Government
 Agency and every other Recipient for any liability incurred by them as a result of warranty, support,
 indemnity and/or liability offered by such Recipient.

 I. A Recipient may create a Larger Work by combining Subject Software with separate software not
 governed by the terms of this agreement and distribute the Larger Work as a single product. In such
 case, the Recipient must make sure Subject Software, or portions thereof, included in the Larger Work
 is subject to this Agreement.

 J. Notwithstanding any provisions contained herein, Recipient is hereby put on notice that export of
 any goods or technical data from the United States may require some form of export license from the
 U.S. Government. Failure to obtain necessary export licenses may result in criminal liability under
 U.S. laws. Government Agency neither represents that a license shall not be required nor that, if
 required, it shall be issued. Nothing granted herein provides any such export license.

 4. DISCLAIMER OF WARRANTIES AND LIABILITIES; WAIVER AND INDEMNIFICATION

 A. No Warranty: THE SUBJECT SOFTWARE IS PROVIDED "AS IS" WITHOUT ANY WARRANTY OF ANY KIND, EITHER
 EXPRESSED, IMPLIED, OR STATUTORY, INCLUDING, BUT NOT LIMITED TO, ANY WARRANTY THAT THE SUBJECT
 SOFTWARE WILL CONFORM TO SPECIFICATIONS, ANY IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
 PARTICULAR PURPOSE, OR FREEDOM FROM INFRINGEMENT, ANY WARRANTY THAT THE SUBJECT SOFTWARE WILL BE ERROR
 FREE, OR ANY WARRANTY THAT DOCUMENTATION, IF PROVIDED, WILL CONFORM TO THE SUBJECT SOFTWARE. THIS
 AGREEMENT DOES NOT, IN ANY MANNER, CONSTITUTE AN ENDORSEMENT BY GOVERNMENT AGENCY OR ANY PRIOR
 RECIPIENT OF ANY RESULTS, RESULTING DESIGNS, HARDWARE, SOFTWARE PRODUCTS OR ANY OTHER APPLICATIONS
 RESULTING FROM USE OF THE SUBJECT SOFTWARE. FURTHER, GOVERNMENT AGENCY DISCLAIMS ALL WARRANTIES AND
 LIABILITIES REGARDING THIRD-PARTY SOFTWARE, IF PRESENT IN THE ORIGINAL SOFTWARE, AND DISTRIBUTES IT
 "AS IS."

 B. Waiver and Indemnity: RECIPIENT AGREES TO WAIVE ANY AND ALL CLAIMS AGAINST GOVERNMENT AGENCY, ITS
 AGENTS, EMPLOYEES, CONTRACTORS AND SUBCONTRACTORS, AS WELL AS ANY PRIOR RECIPIENT. IF RECIPIENT'S USE
 OF THE SUBJECT SOFTWARE RESULTS IN ANY LIABILITIES, DEMANDS, DAMAGES, EXPENSES OR LOSSES ARISING FROM
 SUCH USE, INCLUDING ANY DAMAGES FROM PRODUCTS BASED ON, OR RESULTING FROM, RECIPIENT'S USE OF THE
 SUBJECT SOFTWARE, RECIPIENT SHALL INDEMNIFY AND HOLD HARMLESS  GOVERNMENT AGENCY, ITS AGENTS,
 EMPLOYEES, CONTRACTORS AND SUBCONTRACTORS, AS WELL AS ANY PRIOR RECIPIENT, TO THE EXTENT PERMITTED BY
 LAW.  THE FOREGOING RELEASE AND INDEMNIFICATION SHALL APPLY EVEN IF THE LIABILITIES, DEMANDS, DAMAGES,
 EXPENSES OR LOSSES ARE CAUSED, OCCASIONED, OR CONTRIBUTED TO BY THE NEGLIGENCE, SOLE OR CONCURRENT, OF
 GOVERNMENT AGENCY OR ANY PRIOR RECIPIENT.  RECIPIENT'S SOLE REMEDY FOR ANY SUCH MATTER SHALL BE THE
 IMMEDIATE, UNILATERAL TERMINATION OF THIS AGREEMENT.

 5. GENERAL TERMS

 A. Termination: This Agreement and the rights granted hereunder will terminate automatically if a
 Recipient fails to comply with these terms and conditions, and fails to cure such noncompliance within
 thirty (30) days of becoming aware of such noncompliance. Upon termination, a Recipient agrees to
 immediately cease use and distribution of the Subject Software. All sublicenses to the Subject
 Software properly granted by the breaching Recipient shall survive any such termination of this
 Agreement.

 B. Severability: If any provision of this Agreement is invalid or unenforceable under applicable law,
 it shall not affect the validity or enforceability of the remainder of the terms of this Agreement.

 C. Applicable Law: This Agreement shall be subject to United States federal law only for all purposes,
 including, but not limited to, determining the validity of this Agreement, the meaning of its
 provisions and the rights, obligations and remedies of the parties.

 D. Entire Understanding: This Agreement constitutes the entire understanding and agreement of the
 parties relating to release of the Subject Software and may not be superseded, modified or amended
 except by further written agreement duly executed by the parties.

 E. Binding Authority: By accepting and using the Subject Software under this Agreement, a Recipient
 affirms its authority to bind the Recipient to all terms and conditions of this Agreement and that
 Recipient hereby agrees to all terms and conditions herein.

 F. Point of Contact: Any Recipient contact with Government Agency is to be directed to the designated
 representative as follows: J. Ritchie Carroll <mailto:jrcarrol@tva.gov>.

*/
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using TVA.Interop;
using TVA.IO.Checksums;
using TVA.Parsing;

namespace TVA.PhasorProtocols.Macrodyne
{
    /// <summary>
    /// Represents the Macrodyne implementation of a <see cref="IConfigurationFrame"/> that can be sent or received.
    /// </summary>
    [Serializable()]
    public class ConfigurationFrame : ConfigurationFrameBase, ISupportFrameImage<FrameType>
    {
        #region [ Members ]

        /// <summary>
        /// Default voltage phasor INI based configuration entry.
        /// </summary>
        public const string DefaultVoltagePhasorEntry = "V,4500.0,0.0060573,0,0,500,Default 500kV";

        /// <summary>
        /// Default current phasor INI based configuration entry.
        /// </summary>
        public const string DefaultCurrentPhasorEntry = "I,600.00,0.000040382,0,1,1,Default Current";

        /// <summary>
        /// Default frequency INI based configuration entry.
        /// </summary>
        public const string DefaultFrequencyEntry = "F,1000,60,1000,0,0,Frequency";

        // Events

        /// <summary>
        /// Occurs when the Macrodyne INI based configuration file has been reloaded.
        /// </summary>
        public event EventHandler ConfigurationFileReloaded;

        // Fields
        private CommonFrameHeader m_frameHeader;
        private IniFile m_iniFile;
        private ConfigurationCellCollection m_configurationFileCells;
        private OnlineDataFormatFlags m_onlineDataFormatFlags;
        private PhasorDefinition m_defaultPhasorV;
        private PhasorDefinition m_defaultPhasorI;
        private FrequencyDefinition m_defaultFrequency;
        private string m_stationName;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Creates a new <see cref="ConfigurationFrame"/>.
        /// </summary>
        /// <remarks>
        /// This constructor is used by <see cref="FrameImageParserBase{TTypeIdentifier,TOutputType}"/> to parse a Macrodyne configuration frame.
        /// </remarks>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ConfigurationFrame()
            : base(0, new ConfigurationCellCollection(), 0, 0)
        {
            // We just assume current timestamp for configuration frames since they don't provide one
            Timestamp = DateTime.UtcNow.Ticks;
        }

        /// <summary>
        /// Creates a new <see cref="ConfigurationFrame"/>.
        /// </summary>
        /// <param name="onlineDataFormatFlags">Online data format flags to use in this Macrodyne <see cref="ConfigurationFrame"/>.</param>
        /// <param name="unitID">8 character unit ID to use in this Macrodyne <see cref="ConfigurationFrame"/>.</param>
        /// <remarks>
        /// This constructor is used by a consumer to generate a Macrodyne configuration frame.
        /// </remarks>
        public ConfigurationFrame(OnlineDataFormatFlags onlineDataFormatFlags, string unitID, string configurationFileName = null)
            : base(0, new ConfigurationCellCollection(), 0, 0)
        {
            m_onlineDataFormatFlags = onlineDataFormatFlags;
            m_stationName = unitID;

            if (!string.IsNullOrEmpty(configurationFileName))
                m_iniFile = new IniFile(configurationFileName);

            ConfigurationCell configCell = new ConfigurationCell(this);

            // Macrodyne protocol sends data for one device
            Cells.Add(configCell);

            //Refresh(false);
        }

        /// <summary>
        /// Creates a new <see cref="ConfigurationFrame"/> from serialization parameters.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> with populated with data.</param>
        /// <param name="context">The source <see cref="StreamingContext"/> for this deserialization.</param>
        protected ConfigurationFrame(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            // Deserialize configuration frame
            m_frameHeader = (CommonFrameHeader)info.GetValue("frameHeader", typeof(CommonFrameHeader));
            m_onlineDataFormatFlags = (OnlineDataFormatFlags)info.GetValue("onlineDataFormatFlags", typeof(OnlineDataFormatFlags));

            try
            {
                m_iniFile = new IniFile(info.GetString("configurationFileName"));
            }
            catch (SerializationException)
            {
                m_iniFile = null;
            }
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets reference to the <see cref="ConfigurationCellCollection"/> for this <see cref="ConfigurationFrame"/>.
        /// </summary>
        public new ConfigurationCellCollection Cells
        {
            get
            {
                return base.Cells as ConfigurationCellCollection;
            }
        }

        /// <summary>
        /// Gets the identifier that is used to identify the Macrodyne frame.
        /// </summary>
        public FrameType TypeID
        {
            get
            {
                return Macrodyne.FrameType.ConfigurationFrame;
            }
        }

        /// <summary>
        /// Gets or sets current <see cref="CommonFrameHeader"/>.
        /// </summary>
        public CommonFrameHeader CommonHeader
        {
            get
            {
                // Make sure frame header exists
                if (m_frameHeader == null)
                    m_frameHeader = new CommonFrameHeader();

                return m_frameHeader;
            }
            set
            {
                m_frameHeader = value;

                if (m_frameHeader != null)
                {
                    ConfigurationFrameParsingState parsingState = m_frameHeader.State as ConfigurationFrameParsingState;

                    if (parsingState != null)
                    {
                        State = parsingState;

                        // Cache station name for use when cell gets parsed
                        m_stationName = parsingState.HeaderFrame.HeaderData;
                    }
                }
            }
        }

        // This interface implementation satisfies ISupportFrameImage<int>.CommonHeader
        ICommonHeader<FrameType> ISupportFrameImage<FrameType>.CommonHeader
        {
            get
            {
                return CommonHeader;
            }
            set
            {
                CommonHeader = value as CommonFrameHeader;
            }
        }

        /// <summary>
        /// Gets station name retrieved from header frame.
        /// </summary>
        public string StationName
        {
            get
            {
                return m_stationName;
            }
        }

        /// <summary>
        /// Gets or sets the Macrodyne <see cref="Macrodyne.OnlineDataFormatFlags"/> of this <see cref="ConfigurationFrame"/>.
        /// </summary>
        public OnlineDataFormatFlags OnlineDataFormatFlags
        {
            get
            {
                return m_onlineDataFormatFlags;
            }
            set
            {
                m_onlineDataFormatFlags = value;
            }
        }

        /// <summary>
        /// Gets phasor count derived from <see cref="OnlineDataFormatFlags"/> of this <see cref="ConfigurationFrame"/>.
        /// </summary>
        public int PhasorCount
        {
            get
            {
                int count = 1;

                if ((m_onlineDataFormatFlags & Macrodyne.OnlineDataFormatFlags.Phasor2Enabled) == Macrodyne.OnlineDataFormatFlags.Phasor2Enabled)
                    count++;

                if ((m_onlineDataFormatFlags & Macrodyne.OnlineDataFormatFlags.Phasor3Enabled) == Macrodyne.OnlineDataFormatFlags.Phasor3Enabled)
                    count++;

                if ((m_onlineDataFormatFlags & Macrodyne.OnlineDataFormatFlags.Phasor4Enabled) == Macrodyne.OnlineDataFormatFlags.Phasor4Enabled)
                    count++;

                if ((m_onlineDataFormatFlags & Macrodyne.OnlineDataFormatFlags.Phasor5Enabled) == Macrodyne.OnlineDataFormatFlags.Phasor5Enabled)
                    count++;

                if ((m_onlineDataFormatFlags & Macrodyne.OnlineDataFormatFlags.Phasor6Enabled) == Macrodyne.OnlineDataFormatFlags.Phasor6Enabled)
                    count++;

                if ((m_onlineDataFormatFlags & Macrodyne.OnlineDataFormatFlags.Phasor7Enabled) == Macrodyne.OnlineDataFormatFlags.Phasor7Enabled)
                    count++;

                if ((m_onlineDataFormatFlags & Macrodyne.OnlineDataFormatFlags.Phasor8Enabled) == Macrodyne.OnlineDataFormatFlags.Phasor8Enabled)
                    count++;

                if ((m_onlineDataFormatFlags & Macrodyne.OnlineDataFormatFlags.Phasor9Enabled) == Macrodyne.OnlineDataFormatFlags.Phasor9Enabled)
                    count++;

                if ((m_onlineDataFormatFlags & Macrodyne.OnlineDataFormatFlags.Phasor10Enabled) == Macrodyne.OnlineDataFormatFlags.Phasor10Enabled)
                    count++;

                return count;
            }
        }

        /// <summary>
        /// Gets flag that determines if status 2 flags are included in ON-LINE data.
        /// </summary>
        public bool Status2Included
        {
            get
            {
                return (m_onlineDataFormatFlags & Macrodyne.OnlineDataFormatFlags.Status2ByteEnabled) == Macrodyne.OnlineDataFormatFlags.Status2ByteEnabled;
            }
        }

        /// <summary>
        /// Gets flag that determines if timestamp is included in ON-LINE data.
        /// </summary>
        public bool TimestampIncluded
        {
            get
            {
                return (m_onlineDataFormatFlags & Macrodyne.OnlineDataFormatFlags.TimestampEnabled) == Macrodyne.OnlineDataFormatFlags.TimestampEnabled;
            }
        }

        /// <summary>
        /// Gets flag that determines if reference phasor is included in ON-LINE data.
        /// </summary>
        public bool ReferenceIncluded
        {
            get
            {
                return (m_onlineDataFormatFlags & Macrodyne.OnlineDataFormatFlags.ReferenceEnabled) == Macrodyne.OnlineDataFormatFlags.ReferenceEnabled;
            }
        }

        /// <summary>
        /// Gets flag that determines if Digital 1 is included in ON-LINE data.
        /// </summary>
        public bool Digital1Included
        {
            get
            {
                return (m_onlineDataFormatFlags & Macrodyne.OnlineDataFormatFlags.Digital1Enabled) == Macrodyne.OnlineDataFormatFlags.Digital1Enabled;
            }
        }

        /// <summary>
        /// Gets flag that determines if Digital 2 is included in ON-LINE data.
        /// </summary>
        public bool Digital2Included
        {
            get
            {
                return (m_onlineDataFormatFlags & Macrodyne.OnlineDataFormatFlags.Digital2Enabled) == Macrodyne.OnlineDataFormatFlags.Digital2Enabled;
            }
        }

        /// <summary>
        /// Gets length of data frame based on enabled streaming data.
        /// </summary>
        public ushort DataFrameLength
        {
            get
            {
                return (ushort)(9 + PhasorCount * 4 + (Status2Included ? 1 : 0) + (TimestampIncluded ? 6 : 0) + (ReferenceIncluded ? 6 : 0) + (Digital1Included ? 2 : 0) + (Digital2Included ? 2 : 0));
            }
        }

        /// <summary>
        /// Gets the length of the <see cref="ConfigurationFrame"/>.
        /// </summary>
        /// <remarks>
        /// This property is overriden so the length can be extended to include a 1-byte checksum.
        /// </remarks>
        public override int BinaryLength
        {
            get
            {
                // We override normal binary length so we can extend length to include checksum.
                // Also, if frame length was parsed from stream header - we use that length
                // instead of the calculated length...
                if (ParsedBinaryLength > 0)
                    return ParsedBinaryLength;
                else
                    // Subtract one byte for Macrodyne 1-byte CRC
                    return base.BinaryLength - 1;
            }
        }

        /// <summary>
        /// Gets the length of the <see cref="HeaderImage"/>.
        /// </summary>
        protected override int HeaderLength
        {
            get
            {
                // Common header plus two bytes for on-line data format flags
                return CommonFrameHeader.FixedLength + 2;
            }
        }

        /// <summary>
        /// Gets the binary header image of the <see cref="DataFrame"/> object.
        /// </summary>
        protected override byte[] HeaderImage
        {
            get
            {
                byte[] buffer = new byte[HeaderLength];

                buffer.BlockCopy(0, CommonFrameHeader.FixedLength);
                EndianOrder.BigEndian.CopyBytes((ushort)m_onlineDataFormatFlags, buffer, 2);

                return buffer;
            }
        }

        /// <summary>
        /// <see cref="Dictionary{TKey,TValue}"/> of string based property names and values for the <see cref="ConfigurationFrame"/> object.
        /// </summary>
        public override Dictionary<string, string> Attributes
        {
            get
            {
                Dictionary<string, string> baseAttributes = base.Attributes;

                baseAttributes.Add("ON-LINE Data Format Flags", (byte)OnlineDataFormatFlags + ": " + OnlineDataFormatFlags);

                if ((object)m_iniFile != null)
                    baseAttributes.Add("Configuration File Name", m_iniFile.FileName);

                return baseAttributes;
            }
        }

        #endregion

        #region [ Methods ]

        ///// <summary>
        ///// Reload Macrodyne INI based configuration file.
        ///// </summary>
        //public void Refresh()
        //{
        //    Refresh(false);
        //}

        //internal void Refresh(bool refreshCausedByFrameParse)
        //{
        //    if ((object)m_iniFile == null)
        //        return;

        //    // The only time we need an access lock is when we reload the config file...
        //    lock (m_iniFile)
        //    {
        //        if (File.Exists(m_iniFile.FileName))
        //        {
        //            ConfigurationCell pmuCell;
        //            int phasorCount, pmuCount, x, y;

        //            m_defaultPhasorV = new PhasorDefinition(null, 0, m_iniFile["DEFAULT", "PhasorV", DefaultVoltagePhasorEntry]);
        //            m_defaultPhasorI = new PhasorDefinition(null, 0, m_iniFile["DEFAULT", "PhasorI", DefaultCurrentPhasorEntry]);
        //            m_defaultFrequency = new FrequencyDefinition(null, m_iniFile["DEFAULT", "Frequency", DefaultFrequencyEntry]);
        //            FrameRate = ushort.Parse(m_iniFile["CONFIG", "SampleRate", "30"]);

        //            // We read all cells in the config file into their own configuration cell collection - cells parsed
        //            // from the configuration frame will be mapped to their associated config file cell by ID label
        //            // when the configuration cell is parsed from the configuration frame
        //            if (m_configurationFileCells == null)
        //                m_configurationFileCells = new ConfigurationCellCollection();

        //            m_configurationFileCells.Clear();

        //            // Load phasor data for each section in config file...
        //            foreach (string section in m_iniFile.GetSectionNames())
        //            {
        //                if (section.Length > 0)
        //                {
        //                    // Make sure this is not a special section
        //                    if (string.Compare(section, "DEFAULT", true) != 0 && string.Compare(section, "CONFIG", true) != 0)
        //                    {
        //                        // Create new PMU entry structure from config file settings...
        //                        phasorCount = int.Parse(m_iniFile[section, "NumberPhasors", "0"]);

        //                        // Check for PDC code
        //                        int pdcID = int.Parse(m_iniFile[section, "PDC", "-1"]);

        //                        if (pdcID == -1)
        //                        {
        //                            // No PDC entry exists, assume this is a PMU
        //                            pmuCell = new ConfigurationCell(this, 0);
        //                            pmuCell.IDCode = ushort.Parse(m_iniFile[section, "PMU", Cells.Count.ToString()]);
        //                            pmuCell.SectionEntry = section; // This will automatically assign ID label as first 4 digits of section
        //                            pmuCell.StationName = m_iniFile[section, "Name", section];

        //                            for (x = 0; x < phasorCount; x++)
        //                            {
        //                                pmuCell.PhasorDefinitions.Add(new PhasorDefinition(pmuCell, x + 1, m_iniFile[section, "Phasor" + (x + 1), DefaultVoltagePhasorEntry]));
        //                            }

        //                            pmuCell.FrequencyDefinition = new FrequencyDefinition(pmuCell, m_iniFile[section, "Frequency", DefaultFrequencyEntry]);
        //                            m_configurationFileCells.Add(pmuCell);
        //                        }
        //                        else
        //                        {
        //                            // This is a PDC, need to define one virtual entry for each PMU
        //                            pmuCount = int.Parse(m_iniFile[section, "NumberPMUs", "0"]);

        //                            for (x = 0; x < pmuCount; x++)
        //                            {
        //                                // Create a new PMU cell for each PDC entry that exists
        //                                pmuCell = new ConfigurationCell(this, 0);

        //                                // For BPA INI files, PMUs tradionally have an ID number indexed starting at zero or one - so we multiply
        //                                // ID by 1000 and add index to attempt to create a fairly unique ID to help optimize downstream parsing
        //                                pmuCell.IDCode = unchecked((ushort)(pdcID * 1000 + x));
        //                                pmuCell.SectionEntry = string.Format("{0}pmu{1}", section, x); // This will automatically assign ID label as first 4 digits of section
        //                                pmuCell.StationName = string.Format("{0} - Device {1}", m_iniFile[section, "Name", section], (x + 1));

        //                                for (y = 0; y < 2; y++)
        //                                {
        //                                    pmuCell.PhasorDefinitions.Add(new PhasorDefinition(pmuCell, y + 1, m_iniFile[section, "Phasor" + ((x * 2) + (y + 1)), DefaultVoltagePhasorEntry]));
        //                                }

        //                                pmuCell.FrequencyDefinition = new FrequencyDefinition(pmuCell, m_iniFile[section, "Frequency", DefaultFrequencyEntry]);
        //                                m_configurationFileCells.Add(pmuCell);
        //                            }
        //                        }
        //                    }
        //                }
        //            }

        //            // Associate parsed cells with cells defined in INI file
        //            if (m_configurationFileCells.Count > 0 && (Cells != null))
        //            {
        //                ConfigurationCell configurationFileCell = null;
        //                IConfigurationCell configurationCell = null;

        //                if (refreshCausedByFrameParse)
        //                {
        //                    // Create a new configuration cell collection that will account for PDC block cells
        //                    ConfigurationCellCollection cellCollection = new ConfigurationCellCollection();
        //                    ConfigurationCell cell;

        //                    // For freshly parsed configuration frames we'll have no PMU's in configuration
        //                    // frame for PDCxchng blocks - so we'll need to dynamically create them
        //                    for (x = 0; x < Cells.Count; x++)
        //                    {
        //                        // Get current configuration cell
        //                        cell = Cells[x];

        //                        // Lookup INI file configuration cell by ID label
        //                        m_configurationFileCells.TryGetByIDLabel(cell.IDLabel, out configurationCell);
        //                        configurationFileCell = (ConfigurationCell)configurationCell;

        //                        if (configurationFileCell == null)
        //                        {
        //                            // Couldn't find associated INI file cell - just append the parsed cell to the collection
        //                            cellCollection.Add(cell);
        //                        }
        //                        else
        //                        {
        //                            if (configurationFileCell.IsPdcBlockSection)
        //                            {
        //                                // This looks like a PDC block section - so we'll keep adding cells for each defined PMU in the PDC block
        //                                int index = 0;

        //                                do
        //                                {
        //                                    // Lookup PMU by section name
        //                                    m_configurationFileCells.TryGetBySectionEntry(string.Format("{0}pmu{1}", cell.IDLabel, index), ref configurationFileCell);

        //                                    // Add PDC block PMU configuration cell to the collection
        //                                    if (configurationFileCell != null)
        //                                        cellCollection.Add(configurationFileCell);

        //                                    index++;
        //                                }
        //                                while (configurationFileCell != null);
        //                            }
        //                            else
        //                            {
        //                                // As far as we can tell from INI file, this is just a regular PMU
        //                                cell.ConfigurationFileCell = configurationFileCell;
        //                                cellCollection.Add(cell);
        //                            }
        //                        }
        //                    }

        //                    // Assign "new" cell collection which will include PMU's from defined PDC blocks
        //                    Cells.Clear();
        //                    Cells.AddRange(cellCollection);
        //                }
        //                else
        //                {
        //                    // For simple INI file updates, we just re-assign INI file cells associating by section entry
        //                    foreach (ConfigurationCell cell in Cells)
        //                    {
        //                        // Attempt to associate this configuration cell with information read from external INI based configuration file
        //                        m_configurationFileCells.TryGetBySectionEntry(cell.SectionEntry, ref configurationFileCell);
        //                        cell.ConfigurationFileCell = configurationFileCell;
        //                    }
        //                }
        //            }
        //        }
        //        else
        //            throw new InvalidOperationException("Macrodyne config file \"" + m_iniFile.FileName + "\" does not exist.");
        //    }

        //    // In case other classes want to know, we send out a notification that the config file has been reloaded (make sure
        //    // you do this after the write lock has been released to avoid possible dead-lock situations)
        //    if (ConfigurationFileReloaded != null)
        //        ConfigurationFileReloaded(this, EventArgs.Empty);

        //}

        /// <summary>
        /// Parses the binary image.
        /// </summary>
        /// <param name="buffer">Binary image to parse.</param>
        /// <param name="startIndex">Start index into <paramref name="buffer"/> to begin parsing.</param>
        /// <param name="length">Length of valid data within <paramref name="buffer"/>.</param>
        /// <returns>The length of the data that was parsed.</returns>
        /// <exception cref="InvalidOperationException">Invalid binary image detected - check sum did not match.</exception>
        public override int ParseBinaryImage(byte[] buffer, int startIndex, int length)
        {
            // Subtract one byte for Macrodyne 1-byte CRC
            return base.ParseBinaryImage(buffer, startIndex, length) - 1;
        }

        /// <summary>
        /// Parses the binary header image.
        /// </summary>
        /// <param name="buffer">Binary image to parse.</param>
        /// <param name="startIndex">Start index into <paramref name="buffer"/> to begin parsing.</param>
        /// <param name="length">Length of valid data within <paramref name="buffer"/>.</param>
        /// <returns>The length of the data that was parsed.</returns>
        protected override int ParseHeaderImage(byte[] buffer, int startIndex, int length)
        {
            // We already parsed the frame header, so we just skip past it...
            startIndex += CommonFrameHeader.FixedLength;

            // Parse on -line data format
            m_onlineDataFormatFlags = (OnlineDataFormatFlags)EndianOrder.BigEndian.ToUInt16(buffer, startIndex);

            return CommonFrameHeader.FixedLength + 2;
        }

        /// <summary>
        /// Determines if checksum in the <paramref name="buffer"/> is valid.
        /// </summary>
        /// <param name="buffer">Buffer image to validate.</param>
        /// <param name="startIndex">Start index into <paramref name="buffer"/> to perform checksum.</param>
        /// <returns>Flag that determines if checksum over <paramref name="buffer"/> is valid.</returns>
        /// <remarks>
        /// Default implementation expects 2-byte big-endian ordered checksum. So we override method since checksum
        /// in Macrodyne is a single byte.
        /// </remarks>
        protected override bool ChecksumIsValid(byte[] buffer, int startIndex)
        {
            int sumLength = BinaryLength - 2;
            return buffer[startIndex + BinaryLength - 1] == CalculateChecksum(buffer, startIndex + 1, sumLength);
        }

        /// <summary>
        /// Appends checksum onto <paramref name="buffer"/> starting at <paramref name="startIndex"/>.
        /// </summary>
        /// <param name="buffer">Buffer image on which to append checksum.</param>
        /// <param name="startIndex">Index into <paramref name="buffer"/> where checksum should be appended.</param>
        /// <remarks>
        /// Default implementation encodes checksum in big-endian order and expects buffer size large enough to accomodate
        /// 2-byte checksum representation. We override this method since checksum in Macrodyne is a single byte.
        /// </remarks>
        protected override void AppendChecksum(byte[] buffer, int startIndex)
        {
            buffer[startIndex] = (byte)CalculateChecksum(buffer, 1, startIndex);
        }

        /// <summary>
        /// Calculates checksum of given <paramref name="buffer"/>.
        /// </summary>
        /// <param name="buffer">Buffer image over which to calculate checksum.</param>
        /// <param name="offset">Start index into <paramref name="buffer"/> to calculate checksum.</param>
        /// <param name="length">Length of data within <paramref name="buffer"/> to calculate checksum.</param>
        /// <returns>Checksum over specified portion of <paramref name="buffer"/>.</returns>
        protected override ushort CalculateChecksum(byte[] buffer, int offset, int length)
        {
            // Macrodyne uses 8-bit Xor checksum for frames
            return buffer.Xor8CheckSum(offset, length);
        }

        /// <summary>
        /// Populates a <see cref="SerializationInfo"/> with the data needed to serialize the target object.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> to populate with data.</param>
        /// <param name="context">The destination <see cref="StreamingContext"/> for this serialization.</param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            // Serialize configuration frame
            info.AddValue("frameHeader", m_frameHeader, typeof(CommonFrameHeader));
            info.AddValue("onlineDataFormatFlags", m_onlineDataFormatFlags, typeof(OnlineDataFormatFlags));
        }

        #endregion
    }
}