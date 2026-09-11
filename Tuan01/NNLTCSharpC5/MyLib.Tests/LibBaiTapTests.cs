namespace MyLib.Tests;
using MyLib;
using Xunit;

public class LibBaiTapTests
{
    [Fact] 
    public void GiaiPTBac2_A0_B0_C0_VoSoNghiem() 
    { 
        double x1 = 0, x2 = 0; 
        int result = LibBaiTap.GiaiPTBac2(0, 0, 0, ref x1, ref x2); 
        Assert.Equal(-1, result); 
    } 
 
    [Fact] 
    public void GiaiPTBac2_A0_B0_CKhac0_VoNghiem() 
    { 
        double x1 = 0, x2 = 0; 
        int result = LibBaiTap.GiaiPTBac2(0, 0, 5, ref x1, ref x2); 
        Assert.Equal(0, result); 
    } 
 
    [Fact] 
    public void GiaiPTBac2_PhuongTrinhBac1_CoMotNghiem() 
    { 
        double x1 = 0, x2 = 0; 
        int result = LibBaiTap.GiaiPTBac2(0, 2, -4, ref x1, ref x2); 
        Assert.Equal(1, result); 
        Assert.Equal(2, x1); 
    } 
 
    [Fact] 
    public void GiaiPTBac2_DeltaNhoHon0_VoNghiem() 
    { 
        double x1 = 0, x2 = 0; 
        int result = LibBaiTap.GiaiPTBac2(1, 0, 1, ref x1, ref x2); 
        Assert.Equal(0, result); 
    } 
 
    [Fact] 
    public void GiaiPTBac2_DeltaBang0_CoNghiemKep() 
    { 
        double x1 = 0, x2 = 0; 
        int result = LibBaiTap.GiaiPTBac2(1, -2, 1, ref x1, ref x2); 
        Assert.Equal(1, result); 
        Assert.Equal(1, x1); 
    } 
 
    [Fact] 
    public void GiaiPTBac2_DeltaLonHon0_CoHaiNghiem() 
    { 
        double x1 = 0, x2 = 0; 
        int result = LibBaiTap.GiaiPTBac2(1, -3, 2, ref x1, ref x2); 
        Assert.Equal(2, result); 
        Assert.Equal(1, x1); 
        Assert.Equal(2, x2); 
    }
    [Fact] 
    public void GiaiPTBac2_HaiNghiem_LuonDuocSapXepTangDan() 
    { 
        double x1 = 0, x2 = 0; 
        int result = LibBaiTap.GiaiPTBac2(-1, 3, -2, ref x1, ref x2); 
        Assert.Equal(2, result); 
        Assert.Equal(1, x1); 
        Assert.Equal(2, x2); 
        Assert.True(x1 <= x2); 
    }
}
