﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FuelStationProject.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FuelStationProject.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM [Customer] WHERE ID=&apos;{0}&apos;.
        /// </summary>
        internal static string DeleteCustomer {
            get {
                return ResourceManager.GetString("DeleteCustomer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM [Employee] WHERE ID=&apos;{0}&apos;.
        /// </summary>
        internal static string DeleteEmployee {
            get {
                return ResourceManager.GetString("DeleteEmployee", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM [Item] WHERE ID=&apos;{0}&apos;.
        /// </summary>
        internal static string DeleteItem {
            get {
                return ResourceManager.GetString("DeleteItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM Transaction WHERE ID=&apos;{0}&apos;.
        /// </summary>
        internal static string DeleteTransaction {
            get {
                return ResourceManager.GetString("DeleteTransaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM TransactionLine WHERE ID=&apos;{0}&apos;.
        /// </summary>
        internal static string DeleteTransactionLine {
            get {
                return ResourceManager.GetString("DeleteTransactionLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM TransactionLine WHERE TransactionID=&apos;{0}&apos;
        ///.
        /// </summary>
        internal static string DeleteTransactionLineByTransactionID {
            get {
                return ResourceManager.GetString("DeleteTransactionLineByTransactionID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///INSERT INTO [dbo].[Customer]
        ///	(ID,[Name], [Surname], [CardNumber]) 
        ///VALUES
        ///	(NEWID(), &apos;{0}&apos;, &apos;{1}&apos; , &apos;{2}&apos; )
        ///.
        /// </summary>
        internal static string InsertCustomer {
            get {
                return ResourceManager.GetString("InsertCustomer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///INSERT INTO [dbo].Employee
        ///	(ID,[Name], [Surname], [DateStart],[DateEnd],[Salary]) 
        ///VALUES
        ///	(NEWID(), &apos;{0}&apos;, &apos; {1}&apos; , &apos;{2}&apos; ,&apos;{3}&apos; ,&apos;{4}&apos;)
        ///
        ///
        ///
        ///.
        /// </summary>
        internal static string InsertEmployee {
            get {
                return ResourceManager.GetString("InsertEmployee", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO [dbo].[Item]
        ///           ([ID],[Code],[Description],[ItemType],[Price],[Cost])
        ///     VALUES
        ///	(NEWID(), &apos;{0}&apos;, &apos; {1}&apos; , &apos;{2}&apos; ,&apos;{3}&apos; ,&apos;{4}&apos;)
        ///
        ///
        ///
        ///.
        /// </summary>
        internal static string InsertItem {
            get {
                return ResourceManager.GetString("InsertItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO [dbo].[Transaction]
        ///           ([ID],[Date],[CustomerID],[DiscountValue],[TotalValue],[TotalCost])
        ///     VALUES
        ///	( &apos;{0}&apos;, &apos;{1}&apos; , &apos;{2}&apos;, &apos;{3}&apos; ,&apos;{4}&apos; ,&apos;{5}&apos;)
        ///.
        /// </summary>
        internal static string InsertTransaction {
            get {
                return ResourceManager.GetString("InsertTransaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO [dbo].[TransactionLine]
        ///           ([ID],[TransactionID],[ItemID],[Quantity],[ItemPrice],[Value])
        ///     VALUES
        ///	(NEWID(), &apos;{0}&apos;, &apos;{1}&apos; , &apos;{2}&apos;, &apos;{3}&apos; ,&apos;{4}&apos; )
        ///.
        /// </summary>
        internal static string InsertTransactionLine {
            get {
                return ResourceManager.GetString("InsertTransactionLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select [ID], [Name], [Surname], [CardNumber] from [Customer] where [CardNumber]=&apos;{0}&apos;.
        /// </summary>
        internal static string SelectCustomerByCardNumber {
            get {
                return ResourceManager.GetString("SelectCustomerByCardNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///Select * from [Customer]
        ///.
        /// </summary>
        internal static string SelectCustomerTable {
            get {
                return ResourceManager.GetString("SelectCustomerTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Employee.
        /// </summary>
        internal static string SelectEmployeeTable {
            get {
                return ResourceManager.GetString("SelectEmployeeTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Item.
        /// </summary>
        internal static string SelectItemTable {
            get {
                return ResourceManager.GetString("SelectItemTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT I.[Description], I.[ItemType],T.[Quantity], T.[ItemPrice],T.[Value] ,T.[ID] ,I.[Cost] FROM [Item] I 
        ///left join  [TransactionLine] T on  I.[ID] = T.[ItemID] 
        ///WHERE T.TransactionID=&apos;{0}&apos;
        ///.
        /// </summary>
        internal static string SelectTransactionLineViewByID {
            get {
                return ResourceManager.GetString("SelectTransactionLineViewByID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM [dbo].[Transaction].
        /// </summary>
        internal static string SelectTransactionTable {
            get {
                return ResourceManager.GetString("SelectTransactionTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT T.[Date], T.[DiscountValue],T.[TotalValue], C.[CardNumber],C.[Surname] ,T.[ID]  FROM [Transaction] T
        ///left join  [Customer] C on  T.[CustomerID] = C.[ID] 
        ///.
        /// </summary>
        internal static string SelectTransactionView {
            get {
                return ResourceManager.GetString("SelectTransactionView", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///UPDATE [dbo].[Customer]
        ///SET [Name] = &apos;{0}&apos;, [Surname]= &apos;{1}&apos;, [CardNumber]= &apos;{2}&apos; 
        ///WHERE ID = &apos;{3}&apos;
        ///.
        /// </summary>
        internal static string UpdateCustomer {
            get {
                return ResourceManager.GetString("UpdateCustomer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE [dbo].Employee
        ///SET [Name] = &apos;{0}&apos;, [Surname]= &apos;{1}&apos;, [DateStart]= &apos;{2}&apos;, [DateEnd]= &apos;{3}&apos;,[Salary]= &apos;{4}&apos;
        ///WHERE ID = &apos;{5}&apos;;
        ///
        ///
        ///
        ///
        ///.
        /// </summary>
        internal static string UpdateEmployee {
            get {
                return ResourceManager.GetString("UpdateEmployee", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE [dbo].Item
        ///SET [Code] = &apos;{0}&apos;, [Description]= &apos;{1}&apos;, [ItemType]= &apos;{2}&apos;, [Price]= &apos;{3}&apos;,[Cost]= &apos;{4}&apos;
        ///WHERE ID = &apos;{5}&apos;;
        ///
        ///
        ///
        ///
        ///
        ///.
        /// </summary>
        internal static string UpdateItem {
            get {
                return ResourceManager.GetString("UpdateItem", resourceCulture);
            }
        }
    }
}
