Imports DevExpress.AspNetCore
Imports DevExpress.DashboardAspNetCore
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports Microsoft.Extensions.FileProviders
' Add services to the container.
' Create a new custom palette.
' Assign a newly created custom palette to the Web Dashboard.
' The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
Imports System.Drawing ' TODO: Error SkippedTokensTrivia ';'

' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia 'return'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia ';'
' Configure the HTTP request pipeline.
' TODO: Error SkippedTokensTrivia 'if'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia '{'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
 ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
''' var builder = WebApplication.CreateBuilder(args);
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
''' IFileProvider? fileProvider = builder.Environment.ContentRootFileProvider;
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' IConfiguration? configuration = builder.Configuration;
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddRazorPages' at character 426
''' 
''' 
''' Input:
''' 
''' // Add services to the container.
''' builder.Services.AddRazorPages
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 456
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddDevExpr...' at character 463
''' 
''' 
''' Input:
''' 
''' builder.Services.AddDevExpressControls
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 501
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddScoped<...' at character 506
''' 
''' 
''' Input:
''' builder.Services.AddScoped<DashboardConfigurator>
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '((IServiceProvider serviceP...' at character 555
''' 
''' 
''' Input:
''' ((IServiceProvider serviceProvider) => {
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''     DashboardConfigurator configurator = new DashboardConfigurator();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'configurator.SetDashboardSt...' at character 672
''' 
''' 
''' Input:
'''     configurator.SetDashboardStorage
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 704
''' 
''' 
''' Input:
''' (
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' new DashboardFileStorage(fileProvider.GetFileInfo("Data/Dashboards").
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'PhysicalPath' at character 774
''' 
''' 
''' Input:
''' PhysicalPath));
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'configurator.SetConnectionS...' at character 795
''' 
''' 
''' Input:
'''     configurator.SetConnectionStringsProvider
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 836
''' 
''' 
''' Input:
''' (
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' new DashboardConnectionStringsProvider(configuration));
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'configurator.CustomPalette' at character 898
''' 
''' 
''' Input:
'''     configurator.CustomPalette += 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'Default_CustomPalette' at character 928
''' 
''' 
''' Input:
''' Default_CustomPalette;
'''    
'''     return 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'configurator' at character 968
''' 
''' 
''' Input:
''' configurator;
''' });
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
''' 
''' void Default_CustomPalette(object sender, CustomPaletteWebEventArgs e) {
'''     if (e.DashboardId == "SalesByCategory") {
''' 
'''         // Create a new custom palette.
'''         List<Color> customColors = new List<Color>();
'''         customColors.Add(Color.LightBlue);
'''         customColors.Add(Color.Aquamarine);
'''         customColors.Add(Color.SkyBlue);
'''         customColors.Add(Color.LightCoral);
'''         customColors.Add(Color.Tomato);
'''         customColors.Add(Color.IndianRed);
'''         customColors.Add(Color.Violet);
'''         customColors.Add(Color.Plum);
'''         customColors.Add(Color.MediumOrchid);
''' 
'''         // Assign a newly created custom palette to the Web Dashboard.
'''         e.Palette = new DashboardPalette(customColors);
'''     }
''' }
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
''' var app = builder.Build();
''' 
''' // Configure the HTTP request pipeline.
''' if 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 1816
''' 
''' 
''' Input:
''' (!
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.Environment.IsDevelopment' at character 1818
''' 
''' 
''' Input:
''' app.Environment.IsDevelopment
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1847
''' 
''' 
''' Input:
''' ()) {
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseExceptionHandler' at character 1858
''' 
''' 
''' Input:
'''     app.UseExceptionHandler
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 1881
''' 
''' 
''' Input:
''' ("/Error");
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseHsts' at character 2031
''' 
''' 
''' Input:
'''     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
'''     app.UseHsts
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 2042
''' 
''' 
''' Input:
''' ();
''' }
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseHttpsRedirection' at character 2050
''' 
''' 
''' Input:
''' app.UseHttpsRedirection
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 2073
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseStaticFiles' at character 2078
''' 
''' 
''' Input:
''' app.UseStaticFiles
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 2096
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseDevExpressControls' at character 2103
''' 
''' 
''' Input:
''' 
''' app.UseDevExpressControls
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 2128
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'EndpointRouteBuilderExtensi...' at character 2133
''' 
''' 
''' Input:
''' EndpointRouteBuilderExtension.MapDashboardRoute
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(app, ' at character 2180
''' 
''' 
''' Input:
''' (app, "dashboardControl", "DefaultDashboard");
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseRouting' at character 2230
''' 
''' 
''' Input:
''' 
''' app.UseRouting
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 2244
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseAuthorization' at character 2251
''' 
''' 
''' Input:
''' 
''' app.UseAuthorization
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 2271
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.MapRazorPages' at character 2278
''' 
''' 
''' Input:
''' 
''' app.MapRazorPages
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 2295
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.Run' at character 2302
''' 
''' 
''' Input:
''' 
''' app.Run
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 2309
''' 
''' 
''' Input:
''' ();
''' 
''' 