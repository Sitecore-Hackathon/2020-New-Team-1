    ## Path to MSBuild 2017 or 2019
    $msbuildPath = "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin\msbuild.exe"

    ## Path to the *.sln file
    $solutionDir = "C:\projects\2020-New-Team-1"

    ## Path to the deployed site dir
    $targetDir = "C:\inetpub\wwwroot\h20sc.dev.local"

    ## Solution name
    $solutionName = "Hackathon.Boilerplate.sln"

    Write-Host "Building solution in the following directory: $solutionDir"
    Write-Host "The built code will be published to: $targetDir"
    & $msbuildPath $solutionDir\$solutionName "/p:DeployOnBuild=true" "/p:DeployDefaultTarget=WebPublish" "/p:WebPublishMethod=FileSystem" "/p:DeleteExistingFiles=false" "/p:publishUrl=$targetDir"