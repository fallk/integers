using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A251662
{
public static readonly long[] Value={ 1L,0L,2L,11L,54L,270L,1427L,7740L,43260L,246620L,1430714L,8414356L,50067107L,300829144L,1822766463L,11124747912L,68328754958L,422030501802L,2619631042664L,16332922043614L,102240109896265L,642312449787030L,4048514844039119L,25594403732709300L,162250238001816845L,1031147983109715120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251662Inst : IEnumerable<long>
{
public static readonly long[] Value=A251662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251662.Bytes);
public long this[int i]=>Value[i];

public static A251662Inst Instance=new A251662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251663
{
public static readonly BigInteger[] Value={ 1L,2L,11L,120L,2061L,48918L,1487151L,55188108L,2419385625L,122367255498L,7014349322739L,449405251066368L,31826192109186789L,2468711973793223070L,BigInteger.Parse("208159999898813165079"),BigInteger.Parse("18957203713618483723092"),BigInteger.Parse("1854424578467714146269489"),BigInteger.Parse("193922780991931737971748882"),BigInteger.Parse("21588348501840566333913576795") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251663Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251663.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251663Inst Instance=new A251663Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251664
{
public static readonly BigInteger[] Value={ 1L,3L,26L,430L,10872L,373664L,16295152L,862486944L,53729041280L,3851892172288L,312411790027776L,28284076403710208L,2827642792215049216L,BigInteger.Parse("309396856974126428160"),BigInteger.Parse("36777992050266076762112"),BigInteger.Parse("4719560392385576181243904"),BigInteger.Parse("650284066459536965937364992"),BigInteger.Parse("95752333835299098922624876544"),BigInteger.Parse("15005473998204120386383308390400") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251664Inst Instance=new A251664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251665
{
public static readonly BigInteger[] Value={ 1L,4L,47L,1034L,34349L,1540480L,87311275L,5991370390L,483100288985L,44778459212540L,4691799973171175L,548418557098305250L,BigInteger.Parse("70754785462138421125"),BigInteger.Parse("9987462340422594014200"),BigInteger.Parse("1531136319790275407365475"),BigInteger.Parse("253347224928445454055920750"),BigInteger.Parse("45001449932636667231257800625"),BigInteger.Parse("8541130421294458307989700672500") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251665Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251665.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251665Inst Instance=new A251665Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251666
{
public static readonly BigInteger[] Value={ 1L,5L,74L,2028L,83352L,4607496L,321156000L,27064420704L,2677510124928L,304299947999232L,39075730095810816L,5595805388119057920L,BigInteger.Parse("884245579070535235584"),BigInteger.Parse("152843879008651568329728"),BigInteger.Parse("28688663318934190485491712"),BigInteger.Parse("5811091829207760774331662336"),BigInteger.Parse("1263471121829937070180445552640") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251666Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251666.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251666Inst Instance=new A251666Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251667
{
public static readonly BigInteger[] Value={ 1L,6L,107L,3508L,171741L,11280842L,933014767L,93212094024L,10925496633401L,1470493880790382L,223555405538724819L,BigInteger.Parse("37892802280129883324"),BigInteger.Parse("7086076189702624109653"),BigInteger.Parse("1449303152891376476830962"),BigInteger.Parse("321848482510755456019058519"),BigInteger.Parse("77124029495405859198280522768") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251667Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251667.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251667Inst Instance=new A251667Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251668
{
public static readonly BigInteger[] Value={ 1L,7L,146L,5570L,316376L,24070168L,2303562256L,266121810928L,36054510934400L,5607388438811648L,984840629002206464L,BigInteger.Parse("192818670654633123328"),BigInteger.Parse("41644201910970978233344"),BigInteger.Parse("9836055425319263031070720"),BigInteger.Parse("2522269785922810486307846144"),BigInteger.Parse("697878768774876825573221076992"),BigInteger.Parse("207239855326220163290204654895104") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251668Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251668.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251668Inst Instance=new A251668Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251669
{
public static readonly BigInteger[] Value={ 1L,8L,191L,8310L,537117L,46444164L,5047987707L,662002733394L,101779688986425L,17959176833948928L,3578033935192224951L,BigInteger.Parse("794559576204365478318"),BigInteger.Parse("194620831940208238831701"),BigInteger.Parse("52129134740350115227721340"),BigInteger.Parse("15158273263608217360939225587"),BigInteger.Parse("4755712518628181890216523759754") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251669Inst Instance=new A251669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251670
{
public static readonly BigInteger[] Value={ 1L,9L,242L,11824L,856824L,82986080L,10097121280L,1481787433920L,254874712419200L,50305519571800960L,11209381628379724800UL,BigInteger.Parse("2783746998856794752000"),BigInteger.Parse("762476362390276346060800"),BigInteger.Parse("228363072063685762536960000"),BigInteger.Parse("74247696727054926125971251200"),BigInteger.Parse("26044746725090717967744412672000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251670Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251670.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251670Inst Instance=new A251670Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251671
{
public static readonly BigInteger[] Value={ 1L,6L,180L,43398L,88701816L,1573206748746L,248688444559874580L,BigInteger.Parse("356335498302585834118638"),BigInteger.Parse("4663871943514788530035646937456"),BigInteger.Parse("558720685051192771669885091319459750546"),BigInteger.Parse("612058892657175926094223171960469926874935754700") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251671Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251671.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251671Inst Instance=new A251671Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251672
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,1L,2L,4L,8L,16L,32L,64L,127L,254L,507L,1012L,2020L,4032L,8048L,16064L,32064L,64001L,127748L,254989L,508966L,1015912L,2027792L,4047536L,8079008L,16125952L,32187903L,64248058L,128241127L,255973288L,510930664L,1019833536L,2035619536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251672Inst : IEnumerable<long>
{
public static readonly long[] Value=A251672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251672.Bytes);
public long this[int i]=>Value[i];

public static A251672Inst Instance=new A251672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251673
{
public static readonly long[] Value={ 26L,264L,307L,836L,2285L,2636L,22865L,24846L,30693L,798644L,1042151L,1109111L,1270869L,2012748L,2294675L,3069307L,11129361L,12028229L,12866669L,30001253L,64030648L,110091011L,111091111L,306930693L,2062386218L,2481623254L,10106064399L,10109901101L,10110911101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251673Inst : IEnumerable<long>
{
public static readonly long[] Value=A251673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251673.Bytes);
public long this[int i]=>Value[i];

public static A251673Inst Instance=new A251673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251674
{
public static readonly long[] Value={ 293L,865L,5527L,64309L,1374165L,47407259L,2525118941L,207194435581L,26296727620193L,5146601734676793L,1551231801668961273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251674Inst : IEnumerable<long>
{
public static readonly long[] Value=A251674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251674.Bytes);
public long this[int i]=>Value[i];

public static A251674Inst Instance=new A251674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251675
{
public static readonly long[] Value={ 293L,489L,953L,2257L,5151L,12063L,29839L,72345L,176143L,435429L,1069885L,2629463L,6489171L,15986259L,39377317L,97110263L,239369633L,589963893L,1454573751L,3585822223L,8839317615L,21791873761L,53722460943L,132436498045L,326492433109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251675Inst : IEnumerable<long>
{
public static readonly long[] Value=A251675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251675.Bytes);
public long this[int i]=>Value[i];

public static A251675Inst Instance=new A251675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251676
{
public static readonly long[] Value={ 489L,865L,2089L,5065L,13031L,36075L,100307L,282489L,805963L,2300981L,6582921L,18872307L,54105547L,155166259L,445147549L,1277038995L,3663729245L,10511626757L,30158791311L,86528621567L,248262408987L,712297721821L,2043676016379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251676Inst : IEnumerable<long>
{
public static readonly long[] Value=A251676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251676.Bytes);
public long this[int i]=>Value[i];

public static A251676Inst Instance=new A251676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251677
{
public static readonly long[] Value={ 953L,2089L,5527L,16467L,54523L,184139L,632811L,2196747L,7647815L,26675183L,93098207L,325011115L,1135034003L,3964108395L,13844422191L,48352496787L,168877391803L,589827645215L,2060055442119L,7195028701059L,25129660932207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251677Inst : IEnumerable<long>
{
public static readonly long[] Value=A251677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251677.Bytes);
public long this[int i]=>Value[i];

public static A251677Inst Instance=new A251677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251678
{
public static readonly long[] Value={ 2257L,5065L,16467L,64309L,264983L,1116829L,4748285L,20262955L,86674549L,370897287L,1587178279L,6793752837L,29083759187L,124506509193L,533008374225L,2281819402087L,9768583944333L,41819863365883L,179033174453907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251678Inst : IEnumerable<long>
{
public static readonly long[] Value=A251678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251678.Bytes);
public long this[int i]=>Value[i];

public static A251678Inst Instance=new A251678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251679
{
public static readonly long[] Value={ 5151L,13031L,54523L,264983L,1374165L,7229485L,38111915L,201286237L,1064712861L,5635265205L,29825486345L,157850862859L,835509700715L,4422802653901L,23412470736607L,123932983436039L,656034364529441L,3472740407108381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251679Inst : IEnumerable<long>
{
public static readonly long[] Value=A251679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251679.Bytes);
public long this[int i]=>Value[i];

public static A251679Inst Instance=new A251679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251680
{
public static readonly long[] Value={ 12063L,36075L,184139L,1116829L,7229485L,47407259L,310560937L,2035481639L,13365199539L,87801989105L,576739855753L,3788602403057L,24890263396483L,163532123962817L,1074432510196251L,7059170770215635L,46379935274211457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251680Inst : IEnumerable<long>
{
public static readonly long[] Value=A251680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251680.Bytes);
public long this[int i]=>Value[i];

public static A251680Inst Instance=new A251680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251681
{
public static readonly long[] Value={ 29839L,100307L,632811L,4748285L,38111915L,310560937L,2525118941L,20534822225L,167304924269L,1363558488437L,11111887091463L,90560094584979L,738127134171193L,6016586690293155L,49042746875602219L,399756370338968651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251681Inst : IEnumerable<long>
{
public static readonly long[] Value=A251681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251681.Bytes);
public long this[int i]=>Value[i];

public static A251681Inst Instance=new A251681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251682
{
public static readonly long[] Value={ 293L,489L,489L,953L,865L,953L,2257L,2089L,2089L,2257L,5151L,5065L,5527L,5065L,5151L,12063L,13031L,16467L,16467L,13031L,12063L,29839L,36075L,54523L,64309L,54523L,36075L,29839L,72345L,100307L,184139L,264983L,264983L,184139L,100307L,72345L,176143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251682Inst : IEnumerable<long>
{
public static readonly long[] Value=A251682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251682.Bytes);
public long this[int i]=>Value[i];

public static A251682Inst Instance=new A251682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251683
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,4L,3L,1L,1L,2L,1L,2L,1L,3L,3L,1L,1L,1L,4L,3L,1L,1L,4L,3L,1L,2L,1L,2L,1L,1L,6L,9L,4L,1L,1L,1L,2L,1L,2L,1L,1L,4L,3L,1L,1L,6L,6L,1L,1L,4L,6L,4L,1L,1L,2L,1L,2L,1L,2L,1L,7L,12L,6L,1L,1L,2L,1L,2L,1L,6L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251683Inst : IEnumerable<long>
{
public static readonly long[] Value=A251683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251683.Bytes);
public long this[int i]=>Value[i];

public static A251683Inst Instance=new A251683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251684
{
public static readonly BigInteger[] Value={ 1L,2L,5L,16L,69L,426L,3947L,55612L,1177747L,36816650L,1676270109L,110202314208L,10408422663015L,1407329003121294L,271801891072128621L,BigInteger.Parse("74846096423770137324"),BigInteger.Parse("29351301902680241116593"),BigInteger.Parse("16374214768286861089202358"),BigInteger.Parse("12985582377076992552497257703"),BigInteger.Parse("14629438237685095017820000611400") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251684Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251684.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251684Inst Instance=new A251684Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251685
{
public static readonly long[] Value={ 1L,2L,6L,18L,45L,108L,252L,578L,1270L,2716L,5678L,11678L,23664L,47182L,92538L,178892L,341481L,644648L,1205062L,2231304L,4092646L,7437680L,13398520L,23939558L,42451586L,74754652L,130777182L,227346498L,392806891L,674630766L,1151926416L,1955909898L,3303296389L,5550556238L,9281646642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251685Inst : IEnumerable<long>
{
public static readonly long[] Value=A251685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251685.Bytes);
public long this[int i]=>Value[i];

public static A251685Inst Instance=new A251685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251686
{
public static readonly BigInteger[] Value={ 1L,1L,8L,100L,1556L,27260L,515510L,10284094L,213433728L,4566363088L,100082133066L,2236952393302L,50817223209451L,1170319824912699L,27268900054818390L,641812268110993694L,15239341125950643462UL,BigInteger.Parse("364655982858022960206"),BigInteger.Parse("8785745372509009963892"),BigInteger.Parse("212976842702489760621536") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251686Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251686.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251686Inst Instance=new A251686Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251687
{
public static readonly long[] Value={ 1L,1L,1L,5L,8L,8L,16L,28L,48L,80L,128L,208L,320L,512L,768L,1216L,1792L,2816L,4096L,6400L,9216L,14336L,20480L,31744L,45056L,69632L,98304L,151552L,212992L,327680L,458752L,704512L,983040L,1507328L,2097152L,3211264L,4456448L,6815744L,9437184L,14417920L,19922944L,30408704L,41943040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251687Inst : IEnumerable<long>
{
public static readonly long[] Value=A251687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251687.Bytes);
public long this[int i]=>Value[i];

public static A251687Inst Instance=new A251687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251688
{
public static readonly long[] Value={ 1L,1L,25L,61L,336L,1200L,3600L,13500L,32400L,118800L,259200L,939600L,1944000L,6998400L,13996800L,50155200L,97977600L,349920000L,671846400L,2393452800L,4534963200L,16124313600L,30233088000L,107327462400L,199538380800L,707454259200L,1306069401600L,4625662464000L,8489451110400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251688Inst : IEnumerable<long>
{
public static readonly long[] Value=A251688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251688.Bytes);
public long this[int i]=>Value[i];

public static A251688Inst Instance=new A251688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251689
{
public static readonly long[] Value={ 1L,4L,9L,37L,40L,153L,144L,468L,432L,1260L,1152L,3168L,2880L,7632L,6912L,17856L,16128L,40896L,36864L,92160L,82944L,205056L,184320L,451584L,405504L,986112L,884736L,2138112L,1916928L,4608000L,4128768L,9879552L,8847360L,21086208L,18874368L,44826624L,40108032L,94961664L,84934656L,200540160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251689Inst : IEnumerable<long>
{
public static readonly long[] Value=A251689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251689.Bytes);
public long this[int i]=>Value[i];

public static A251689Inst Instance=new A251689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251690
{
public static readonly long[] Value={ 1L,-1L,-2L,-2L,0L,-1L,0L,-3L,0L,-3L,-3L,0L,-3L,-2L,-3L,-1L,-2L,0L,-1L,-2L,0L,0L,-2L,0L,0L,0L,-2L,0L,-3L,0L,-2L,0L,-1L,0L,-3L,-2L,-1L,-1L,-3L,-1L,0L,-2L,-2L,-3L,-1L,-3L,-1L,-1L,0L,0L,-1L,-1L,-3L,-3L,-1L,0L,-1L,0L,-2L,0L,-3L,-3L,-3L,-2L,-1L,-2L,-1L,-2L,-2L,-2L,-3L,-1L,-3L,-1L,-3L,-1L,0L,-2L,-2L,-2L,-1L,-1L,-2L,-2L,0L,-3L,-3L,-2L,-3L,-1L,-3L,-2L,0L,0L,0L,-2L,-2L,-2L,-2L,-3L,-3L,0L,-2L,0L,-3L,-1L,0L,-2L,-3L,-1L,-3L,0L,-1L,0L,-2L,-1L,-1L,-3L,-3L,-1L,-3L,-3L,0L,-3L,-2L,-3L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251690Inst : IEnumerable<long>
{
public static readonly long[] Value=A251690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251690.Bytes);
public long this[int i]=>Value[i];

public static A251690Inst Instance=new A251690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251691
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,17L,36L,78L,169L,370L,813L,1793L,3971L,8817L,19631L,43804L,97938L,219357L,492072L,1105398L,2486320L,5598805L,12620832L,28477139L,64311189L,145354456L,328772330L,744155150L,1685434388L,3819629781L,8661130303L,19649713303L,44601771038L,101285994072L,230110466746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251691Inst : IEnumerable<long>
{
public static readonly long[] Value=A251691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251691.Bytes);
public long this[int i]=>Value[i];

public static A251691Inst Instance=new A251691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251692
{
public static readonly BigInteger[] Value={ 1L,1L,2L,14L,222L,10384L,1633416L,909329424L,1817382187648L,13096462193012288L,BigInteger.Parse("341920990254898495104") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251692Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251692.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251692Inst Instance=new A251692Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251693
{
public static readonly BigInteger[] Value={ 1L,2L,27L,756L,32805L,1940598L,145746783L,13286025000L,1425299311881L,175940774387370L,24567422246484579L,3828825486242232732L,BigInteger.Parse("658868122100830078125"),BigInteger.Parse("124081133675135015343006"),BigInteger.Parse("25384277097202185803440935"),BigInteger.Parse("5605841615843732059988768592"),BigInteger.Parse("1329181093536536811199747015953") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251693Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251693.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251693Inst Instance=new A251693Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251694
{
public static readonly BigInteger[] Value={ 1L,3L,80L,4480L,389376L,46137344L,6939332608L,1266556600320L,272000000000000L,67204714785144832L,BigInteger.Parse("18780742521990414336"),BigInteger.Parse("5857307089452073484288"),BigInteger.Parse("2016866466756967373209600"),BigInteger.Parse("759982437118771200000000000"),BigInteger.Parse("311070869724989874190180941824"),BigInteger.Parse("137440072511222468264810285891584") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251694Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251694.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251694Inst Instance=new A251694Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251695
{
public static readonly BigInteger[] Value={ 1L,4L,175L,16250L,2348125L,463050000L,115966796875L,35253537343750L,12611991884765625L,5191587030710937500L,BigInteger.Parse("2417311348659677734375"),BigInteger.Parse("1256208098030090332031250"),BigInteger.Parse("720779749270420907470703125"),BigInteger.Parse("452589644988876542822265625000"),BigInteger.Parse("308707218248583408960223388671875") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251695Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251695.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251695Inst Instance=new A251695Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251696
{
public static readonly BigInteger[] Value={ 1L,5L,324L,44928L,9716112L,2870090496L,1077194894400L,490873123897344L,263285585800098048L,BigInteger.Parse("162505400851637010432"),BigInteger.Parse("113463916253636561519616"),BigInteger.Parse("88423664876285081860177920"),BigInteger.Parse("76086820231309990402228260864"),BigInteger.Parse("71651521268311905104861664903168"),BigInteger.Parse("73298071049899905319337719679434752") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251696Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251696.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251696Inst Instance=new A251696Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251697
{
public static readonly BigInteger[] Value={ 1L,6L,539L,104272L,31513125L,13018130762L,6835288192159L,4358439870247764L,3271482918202092041L,BigInteger.Parse("2826044644022395468750"),BigInteger.Parse("2761781119675422226696419"),BigInteger.Parse("3012587650584028093856586776"),BigInteger.Parse("3628565076873134344787430377389"),BigInteger.Parse("4783177086109789054912470697687698"),BigInteger.Parse("6849486554475843842876951982177734375") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251697Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251697.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251697Inst Instance=new A251697Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251698
{
public static readonly BigInteger[] Value={ 1L,7L,832L,214016L,86118400L,47393538048L,33160072265728L,28180480000000000L,BigInteger.Parse("28194546272924860416"),BigInteger.Parse("32466269569728810844160"),BigInteger.Parse("42295727044150128912891904"),BigInteger.Parse("61505801717703291002224115712"),BigInteger.Parse("98762474157744880353280000000000"),BigInteger.Parse("173565347832317233669371533581090816"),BigInteger.Parse("331360760866451564310212841997955235840") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251698Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251698.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251698Inst Instance=new A251698Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251699
{
public static readonly BigInteger[] Value={ 1L,8L,1215L,400950L,207202941L,146509780644L,131737019154363L,143893722808861650L,BigInteger.Parse("185052548743241765625"),BigInteger.Parse("273919266332571877019712"),BigInteger.Parse("458736814135093804224189111"),BigInteger.Parse("857575304752878031562956215918"),BigInteger.Parse("1770298011965146072399475770453365"),BigInteger.Parse("3999656915702652258291935606835937500") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251699Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251699.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251699Inst Instance=new A251699Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251700
{
public static readonly BigInteger[] Value={ 1L,9L,1700L,700000L,451770000L,399077600000L,448380625000000L,612032839680000000L,BigInteger.Parse("983672470878500000000"),BigInteger.Parse("1819783935144064000000000"),BigInteger.Parse("3809045473682732010000000000"),BigInteger.Parse("8900000000000000000000000000000"),BigInteger.Parse("22963427643543537169897000000000000"),BigInteger.Parse("64847222511564256853913600000000000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251700Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251700.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251700Inst Instance=new A251700Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251701
{
public static readonly long[] Value={ 1L,4L,13L,36L,97L,268L,765L,2236L,6625L,19764L,59149L,177268L,531585L,1594492L,4783165L,14349132L,43046977L,129140452L,387420813L,1162261828L,3486784801L,10460353644L,31381060093L,94143179356L,282429537057L,847288610068L,2541865829005L,7625597485716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251701Inst : IEnumerable<long>
{
public static readonly long[] Value=A251701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251701.Bytes);
public long this[int i]=>Value[i];

public static A251701Inst Instance=new A251701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251702
{
public static readonly BigInteger[] Value={ 5L,10L,120L,280840L,3691654113991480L,BigInteger.Parse("8385167839605753859676710992399730619003333960") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251702Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251702.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251702Inst Instance=new A251702Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251703
{
public static readonly long[] Value={ 1L,1L,0L,0L,2L,3L,5L,10L,20L,38L,73L,141L,272L,524L,1010L,1947L,3753L,7234L,13944L,26878L,51809L,99865L,192496L,371048L,715218L,1378627L,2657389L,5122282L,9873516L,19031814L,36685001L,70712613L,136302944L,262732372L,506432930L,976180859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251703Inst : IEnumerable<long>
{
public static readonly long[] Value=A251703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251703.Bytes);
public long this[int i]=>Value[i];

public static A251703Inst Instance=new A251703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251704
{
public static readonly long[] Value={ 1L,1L,0L,1L,3L,5L,9L,18L,35L,67L,129L,249L,480L,925L,1783L,3437L,6625L,12770L,24615L,47447L,91457L,176289L,339808L,655001L,1262555L,2433653L,4691017L,9042226L,17429451L,33596347L,64759041L,124827065L,240611904L,463794357L,893992367L,1723225693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251704Inst : IEnumerable<long>
{
public static readonly long[] Value=A251704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251704.Bytes);
public long this[int i]=>Value[i];

public static A251704Inst Instance=new A251704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251705
{
public static readonly long[] Value={ 1L,1L,1L,0L,3L,5L,9L,17L,34L,65L,125L,241L,465L,896L,1727L,3329L,6417L,12369L,23842L,45957L,88585L,170753L,329137L,634432L,1222907L,2357229L,4543705L,8758273L,16882114L,32541321L,62725413L,120907121L,233055969L,449229824L,865918327L,1669111241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251705Inst : IEnumerable<long>
{
public static readonly long[] Value=A251705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251705.Bytes);
public long this[int i]=>Value[i];

public static A251705Inst Instance=new A251705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251706
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,2L,4L,8L,16L,31L,62L,123L,244L,484L,960L,1904L,3777L,7492L,14861L,29478L,58472L,115984L,230064L,456351L,905210L,1795559L,3561640L,7064808L,14013632L,27797200L,55138049L,109370888L,216946217L,430330794L,853596780L,1693179928L,3358562656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251706Inst : IEnumerable<long>
{
public static readonly long[] Value=A251706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251706.Bytes);
public long this[int i]=>Value[i];

public static A251706Inst Instance=new A251706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251707
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,2L,4L,8L,15L,30L,60L,119L,236L,468L,928L,1841L,3652L,7244L,14369L,28502L,56536L,112144L,222447L,441242L,875240L,1736111L,3443720L,6830904L,13549664L,26876881L,53312520L,105749800L,209763489L,416083258L,825335612L,1637121560L,3247366239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251707Inst : IEnumerable<long>
{
public static readonly long[] Value=A251707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251707.Bytes);
public long this[int i]=>Value[i];

public static A251707Inst Instance=new A251707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251708
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,1L,2L,4L,7L,14L,28L,56L,111L,220L,436L,865L,1716L,3404L,6752L,13393L,26566L,52696L,104527L,207338L,411272L,815792L,1618191L,3209816L,6366936L,12629345L,25051352L,49691432L,98567072L,195515953L,387822090L,769277244L,1525925143L,3026798934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251708Inst : IEnumerable<long>
{
public static readonly long[] Value=A251708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251708.Bytes);
public long this[int i]=>Value[i];

public static A251708Inst Instance=new A251708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251709
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,0L,1L,2L,3L,6L,12L,24L,48L,95L,188L,373L,740L,1468L,2912L,5776L,11457L,22726L,45079L,89418L,177368L,351824L,697872L,1384287L,2745848L,5446617L,10803816L,21430264L,42508704L,84319536L,167254785L,331763722L,658080827L,1305357838L,2589285412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251709Inst : IEnumerable<long>
{
public static readonly long[] Value=A251709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251709.Bytes);
public long this[int i]=>Value[i];

public static A251709Inst Instance=new A251709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251710
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,2L,4L,8L,16L,32L,63L,126L,251L,500L,996L,1984L,3952L,7872L,15681L,31236L,62221L,123942L,246888L,491792L,979632L,1951392L,3887103L,7742970L,15423719L,30723496L,61200104L,121908416L,242837200L,483723008L,963558913L,1919374856L,3823325993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251710Inst : IEnumerable<long>
{
public static readonly long[] Value=A251710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251710.Bytes);
public long this[int i]=>Value[i];

public static A251710Inst Instance=new A251710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251711
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,2L,4L,8L,16L,31L,62L,124L,247L,492L,980L,1952L,3888L,7745L,15428L,30732L,61217L,121942L,242904L,483856L,963824L,1919903L,3824378L,7618024L,15174831L,30227720L,60212536L,119941216L,238918608L,475917313L,948010248L,1888402472L,3761630113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251711Inst : IEnumerable<long>
{
public static readonly long[] Value=A251711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251711.Bytes);
public long this[int i]=>Value[i];

public static A251711Inst Instance=new A251711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251712
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,2L,4L,8L,15L,30L,60L,120L,239L,476L,948L,1888L,3761L,7492L,14924L,29728L,59217L,117958L,234968L,468048L,932335L,1857178L,3699432L,7369136L,14679055L,29240152L,58245336L,116022624L,231112913L,460368648L,917037864L,1826706592L,3638734129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251712Inst : IEnumerable<long>
{
public static readonly long[] Value=A251712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251712.Bytes);
public long this[int i]=>Value[i];

public static A251712Inst Instance=new A251712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251713
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,1L,2L,4L,7L,14L,28L,56L,112L,223L,444L,884L,1761L,3508L,6988L,13920L,27728L,55233L,110022L,219160L,436559L,869610L,1732232L,3450544L,6873360L,13691487L,27272952L,54326744L,108216929L,215564248L,429396264L,855341984L,1703810608L,3393929729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251713Inst : IEnumerable<long>
{
public static readonly long[] Value=A251713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251713.Bytes);
public long this[int i]=>Value[i];

public static A251713Inst Instance=new A251713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251714
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,0L,0L,1L,2L,3L,6L,12L,24L,48L,96L,191L,380L,757L,1508L,3004L,5984L,11920L,23744L,47297L,94214L,187671L,373834L,744664L,1483344L,2954768L,5885792L,11724287L,23354360L,46521049L,92668264L,184591864L,367700384L,732446000L,1459006208L,2906288129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251714Inst : IEnumerable<long>
{
public static readonly long[] Value=A251714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251714.Bytes);
public long this[int i]=>Value[i];

public static A251714Inst Instance=new A251714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251715
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,4L,2L,1L,5L,7L,2L,5L,5L,2L,3L,3L,1L,1L,7L,4L,6L,3L,1L,3L,3L,2L,7L,8L,2L,1L,2L,5L,4L,4L,9L,5L,3L,1L,5L,5L,4L,13L,9L,13L,10L,3L,1L,5L,2L,7L,9L,7L,17L,11L,11L,2L,1L,5L,3L,4L,4L,7L,9L,11L,15L,13L,2L,1L,2L,2L,7L,7L,9L,6L,6L,13L,17L,14L,3L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251715Inst : IEnumerable<long>
{
public static readonly long[] Value=A251715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251715.Bytes);
public long this[int i]=>Value[i];

public static A251715Inst Instance=new A251715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251716
{
public static readonly long[] Value={ 2L,3L,4L,7L,5L,6L,8L,9L,7L,8L,20L,13L,11L,10L,10L,21L,22L,15L,13L,12L,12L,28L,23L,24L,17L,16L,17L,14L,41L,30L,25L,34L,27L,18L,19L,16L,49L,43L,32L,36L,46L,38L,26L,21L,18L,59L,51L,45L,35L,38L,66L,40L,32L,24L,20L,60L,61L,53L,47L,67L,54L,68L,42L,34L,26L,25L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251716Inst : IEnumerable<long>
{
public static readonly long[] Value=A251716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251716.Bytes);
public long this[int i]=>Value[i];

public static A251716Inst Instance=new A251716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251717
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,2L,1L,3L,2L,2L,1L,3L,1L,3L,2L,2L,1L,2L,3L,4L,2L,3L,1L,2L,1L,5L,3L,2L,3L,2L,1L,3L,6L,2L,1L,2L,1L,3L,2L,3L,1L,4L,2L,3L,2L,2L,1L,2L,2L,3L,2L,3L,1L,3L,1L,4L,4L,2L,3L,2L,1L,5L,2L,2L,1L,4L,1L,4L,2L,2L,3L,3L,1L,3L,3L,2L,1L,2L,4L,3L,2L,3L,1L,2L,2L,5L,3L,3L,3L,2L,1L,3L,2L,2L,1L,4L,1L,3L,3L,2L,1L,5L,1L,4L,3L,2L,1L,2L,2L,3L,2L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251717Inst : IEnumerable<long>
{
public static readonly long[] Value=A251717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251717.Bytes);
public long this[int i]=>Value[i];

public static A251717Inst Instance=new A251717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251718
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,2L,1L,3L,4L,2L,3L,4L,3L,5L,2L,2L,4L,3L,1L,3L,2L,4L,3L,2L,5L,4L,2L,3L,4L,2L,1L,5L,6L,2L,3L,2L,1L,3L,6L,4L,4L,4L,6L,3L,4L,5L,3L,6L,4L,6L,2L,4L,3L,4L,2L,5L,8L,5L,6L,3L,3L,4L,4L,2L,3L,2L,3L,7L,6L,5L,3L,4L,4L,6L,2L,2L,5L,7L,1L,5L,5L,4L,6L,2L,4L,6L,5L,5L,4L,2L,2L,5L,3L,3L,3L,4L,1L,3L,5L,7L,5L,4L,3L,3L,5L,2L,4L,5L,7L,4L,7L,4L,3L,7L,4L,3L,2L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251718Inst : IEnumerable<long>
{
public static readonly long[] Value=A251718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251718.Bytes);
public long this[int i]=>Value[i];

public static A251718Inst Instance=new A251718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251719
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,3L,3L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251719Inst : IEnumerable<long>
{
public static readonly long[] Value=A251719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251719.Bytes);
public long this[int i]=>Value[i];

public static A251719Inst Instance=new A251719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251720
{
public static readonly long[] Value={ 12L,45L,175L,539L,1573L,2873L,5491L,8303L,15341L,26071L,35557L,56129L,72283L,86903L,117077L,165731L,212341L,249307L,318719L,367993L,420991L,518003L,613121L,768337L,950309L,1050703L,1135163L,1247941L,1342553L,1621663L,2112899L,2351057L,2608891L,2878829L,3352351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251720Inst : IEnumerable<long>
{
public static readonly long[] Value=A251720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251720.Bytes);
public long this[int i]=>Value[i];

public static A251720Inst Instance=new A251720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251721
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,5L,3L,2L,1L,4L,4L,3L,2L,1L,7L,6L,4L,3L,2L,1L,11L,7L,5L,4L,3L,2L,1L,6L,9L,6L,5L,4L,3L,2L,1L,13L,10L,7L,6L,5L,4L,3L,2L,1L,17L,5L,8L,7L,6L,5L,4L,3L,2L,1L,10L,12L,10L,8L,7L,6L,5L,4L,3L,2L,1L,19L,15L,11L,9L,8L,7L,6L,5L,4L,3L,2L,1L,9L,8L,13L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,8L,16L,14L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,23L,19L,15L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251721Inst : IEnumerable<long>
{
public static readonly long[] Value=A251721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251721.Bytes);
public long this[int i]=>Value[i];

public static A251721Inst Instance=new A251721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251722
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,5L,3L,2L,1L,4L,4L,3L,2L,1L,8L,9L,4L,3L,2L,1L,6L,5L,5L,4L,3L,2L,1L,14L,6L,6L,5L,4L,3L,2L,1L,13L,12L,7L,6L,5L,4L,3L,2L,1L,11L,7L,8L,7L,6L,5L,4L,3L,2L,1L,7L,8L,14L,8L,7L,6L,5L,4L,3L,2L,1L,23L,19L,9L,9L,8L,7L,6L,5L,4L,3L,2L,1L,9L,10L,10L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,17L,17L,21L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,18L,42L,11L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251722Inst : IEnumerable<long>
{
public static readonly long[] Value=A251722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251722.Bytes);
public long this[int i]=>Value[i];

public static A251722Inst Instance=new A251722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251723
{
public static readonly long[] Value={ 1L,4L,5L,14L,8L,21L,10L,26L,46L,15L,56L,43L,19L,45L,79L,77L,31L,89L,65L,29L,105L,74L,113L,162L,88L,41L,86L,41L,99L,353L,98L,164L,48L,298L,57L,181L,185L,127L,197L,194L,75L,355L,76L,143L,74L,462L,478L,167L,81L,165L,269L,89L,437L,274L,273L,291L,90L,291L,198L,98L,511L,734L,219L,106L,214L,783L,340L,578L,124L,240L,362L,488L,380L,379L,251L,393L,529L,261L,530L,669L,150L,708L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251723Inst : IEnumerable<long>
{
public static readonly long[] Value=A251723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251723.Bytes);
public long this[int i]=>Value[i];

public static A251723Inst Instance=new A251723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251724
{
public static readonly long[] Value={ 2L,4L,6L,21L,65L,85L,95L,115L,217L,259L,287L,301L,329L,649L,671L,737L,781L,803L,869L,913L,979L,1067L,1111L,1133L,1177L,1199L,1243L,1703L,1781L,1807L,1937L,1963L,2041L,2119L,2171L,3043L,3077L,3247L,3281L,3349L,3383L,3587L,3791L,3859L,3893L,3961L,4063L,4097L,4267L,4369L,4471L,4573L,4607L,4709L,4777L,4811L,5833L,5909L,5947L,6023L,6289L,6403L,6593L,6631L,6707L,6821L,8579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251724Inst : IEnumerable<long>
{
public static readonly long[] Value=A251724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251724.Bytes);
public long this[int i]=>Value[i];

public static A251724Inst Instance=new A251724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251725
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,6L,1L,2L,1L,8L,3L,1L,1L,2L,1L,6L,3L,12L,1L,2L,1L,14L,1L,8L,1L,6L,1L,1L,12L,18L,2L,2L,1L,20L,14L,6L,1L,8L,1L,12L,3L,24L,1L,2L,1L,6L,18L,14L,1L,2L,4L,8L,20L,30L,1L,6L,1L,32L,3L,1L,4L,12L,1L,18L,24L,8L,1L,2L,1L,38L,3L,20L,4L,14L,1L,6L,1L,42L,1L,8L,5L,44L,30L,12L,1L,6L,4L,24L,32L,48L,5L,2L,1L,8L,12L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251725Inst : IEnumerable<long>
{
public static readonly long[] Value=A251725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251725.Bytes);
public long this[int i]=>Value[i];

public static A251725Inst Instance=new A251725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251726
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,15L,16L,17L,18L,19L,21L,23L,24L,25L,27L,29L,31L,32L,35L,36L,37L,41L,43L,45L,47L,48L,49L,53L,54L,55L,59L,61L,63L,64L,65L,67L,71L,72L,73L,75L,77L,79L,81L,83L,85L,89L,91L,95L,96L,97L,101L,103L,105L,107L,108L,109L,113L,115L,119L,121L,125L,127L,128L,131L,133L,135L,137L,139L,143L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251726Inst : IEnumerable<long>
{
public static readonly long[] Value=A251726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251726.Bytes);
public long this[int i]=>Value[i];

public static A251726Inst Instance=new A251726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251727
{
public static readonly long[] Value={ 10L,14L,20L,22L,26L,28L,30L,33L,34L,38L,39L,40L,42L,44L,46L,50L,51L,52L,56L,57L,58L,60L,62L,66L,68L,69L,70L,74L,76L,78L,80L,82L,84L,86L,87L,88L,90L,92L,93L,94L,98L,99L,100L,102L,104L,106L,110L,111L,112L,114L,116L,117L,118L,120L,122L,123L,124L,126L,129L,130L,132L,134L,136L,138L,140L,141L,142L,145L,146L,148L,150L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251727Inst : IEnumerable<long>
{
public static readonly long[] Value=A251727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251727.Bytes);
public long this[int i]=>Value[i];

public static A251727Inst Instance=new A251727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251728
{
public static readonly long[] Value={ 4L,6L,9L,15L,21L,25L,35L,49L,55L,65L,77L,85L,91L,95L,115L,119L,121L,133L,143L,161L,169L,187L,203L,209L,217L,221L,247L,253L,259L,287L,289L,299L,301L,319L,323L,329L,341L,361L,377L,391L,403L,407L,437L,451L,473L,481L,493L,517L,527L,529L,533L,551L,559L,583L,589L,611L,629L,649L,667L,671L,689L,697L,703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251728Inst : IEnumerable<long>
{
public static readonly long[] Value=A251728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251728.Bytes);
public long this[int i]=>Value[i];

public static A251728Inst Instance=new A251728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251729
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,6L,6L,14L,12L,27L,33L,58L,86L,134L,210L,323L,539L,810L,1371L,2044L,3510L,5263L,8927L,13702L,22870L,35821L,58750L,93343L,152236L,243244L,395078L,634342L,1027876L,1656543L,2676693L,4325727L,6982440L,11299457L,18232217L,29518334L,47641410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251729Inst : IEnumerable<long>
{
public static readonly long[] Value=A251729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251729.Bytes);
public long this[int i]=>Value[i];

public static A251729Inst Instance=new A251729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251730
{
public static readonly BigInteger[] Value={ 10L,152L,2130L,29680L,413402L,5757960L,80198050L,1117014752L,15558008490L,216695104120L,3018173449202L,42037733184720L,585510091136890L,8155103542731752L,113585939507107650L,1582048049556775360L,BigInteger.Parse("22035086754287747402"),BigInteger.Parse("306909166510471688280") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251730Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A251730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251730.Bytes);
public BigInteger this[int i]=>Value[i];

public static A251730Inst Instance=new A251730Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251731
{
public static readonly long[] Value={ 2L,1L,2L,16L,32L,145L,62L,1363L,3458L,19492L,58928L,89308L,70028L,1594318L,1890551L,189871L,31401806L,47918575L,190704887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251731Inst : IEnumerable<long>
{
public static readonly long[] Value=A251731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251731.Bytes);
public long this[int i]=>Value[i];

public static A251731Inst Instance=new A251731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251732
{
public static readonly long[] Value={ 1L,-3L,27L,-189L,1377L,-9963L,72171L,-522693L,3785697L,-27418419L,198581787L,-1438256493L,10416775041L,-75444958683L,546420727467L,-3957528992949L,28662960504897L,-207595523965923L,1503539788339611L,-10889598445730973L,78869448769442337L,-571223078628232779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251732Inst : IEnumerable<long>
{
public static readonly long[] Value=A251732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251732.Bytes);
public long this[int i]=>Value[i];

public static A251732Inst Instance=new A251732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251733
{
public static readonly long[] Value={ 0L,3L,-18L,135L,-972L,7047L,-51030L,369603L,-2676888L,19387755L,-140418522L,1017000927L,-7365772260L,53347641903L,-386377801758L,2798395587675L,-20267773741872L,146792202740307L,-1063163180118690L,7700108905374903L,-55769122053317628L,403915712468279895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251733Inst : IEnumerable<long>
{
public static readonly long[] Value=A251733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251733.Bytes);
public long this[int i]=>Value[i];

public static A251733Inst Instance=new A251733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251734
{
public static readonly long[] Value={ 9L,7L,3L,3L,6L,0L,2L,4L,8L,3L,5L,0L,7L,8L,2L,7L,1L,5L,4L,6L,8L,8L,8L,6L,8L,6L,2L,4L,4L,7L,8L,9L,6L,5L,7L,0L,7L,7L,2L,8L,2L,9L,6L,3L,1L,7L,4L,3L,0L,5L,3L,3L,3L,9L,9L,4L,5L,3L,5L,8L,1L,4L,4L,6L,2L,1L,0L,8L,5L,1L,8L,2L,8L,1L,3L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251734Inst : IEnumerable<long>
{
public static readonly long[] Value=A251734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251734.Bytes);
public long this[int i]=>Value[i];

public static A251734Inst Instance=new A251734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251735
{
public static readonly long[] Value={ 5L,7L,1L,7L,5L,2L,8L,3L,3L,8L,2L,5L,2L,7L,7L,6L,6L,4L,9L,3L,6L,4L,7L,5L,6L,8L,1L,1L,3L,6L,0L,3L,2L,6L,5L,5L,2L,4L,3L,1L,4L,8L,1L,5L,7L,4L,7L,3L,2L,5L,4L,1L,1L,5L,8L,0L,6L,1L,4L,7L,5L,0L,8L,2L,8L,0L,3L,1L,8L,4L,9L,1L,1L,9L,3L,9L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251735Inst : IEnumerable<long>
{
public static readonly long[] Value=A251735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251735.Bytes);
public long this[int i]=>Value[i];

public static A251735Inst Instance=new A251735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251736
{
public static readonly long[] Value={ 1L,2L,5L,5L,8L,9L,9L,12L,12L,15L,15L,15L,20L,24L,24L,24L,24L,29L,28L,28L,28L,32L,32L,32L,30L,37L,43L,40L,41L,43L,43L,43L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251736Inst : IEnumerable<long>
{
public static readonly long[] Value=A251736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251736.Bytes);
public long this[int i]=>Value[i];

public static A251736Inst Instance=new A251736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251737
{
public static readonly long[] Value={ 1L,1L,3L,5L,17L,66L,181L,508L,1283L,3664L,10812L,31171L,88565L,245524L,692416L,1968532L,5609977L,15928174L,44982196L,127190716L,360208608L,1021611491L,2896270245L,8202605953L,23226285083L,65780006703L,186369631872L,528047092459L,1495905404102L,4237308534243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251737Inst : IEnumerable<long>
{
public static readonly long[] Value=A251737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251737.Bytes);
public long this[int i]=>Value[i];

public static A251737Inst Instance=new A251737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251738
{
public static readonly long[] Value={ 1L,4L,6L,6L,5L,8L,7L,8L,9L,10L,10L,9L,10L,10L,10L,11L,11L,11L,12L,11L,12L,11L,11L,12L,13L,12L,11L,13L,12L,13L,13L,13L,12L,13L,13L,14L,13L,14L,13L,14L,14L,14L,14L,14L,14L,15L,15L,15L,14L,14L,15L,14L,15L,15L,15L,15L,16L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251738Inst : IEnumerable<long>
{
public static readonly long[] Value=A251738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251738.Bytes);
public long this[int i]=>Value[i];

public static A251738Inst Instance=new A251738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251739
{
public static readonly long[] Value={ 1L,4L,3L,6L,5L,8L,7L,8L,9L,10L,10L,9L,10L,10L,10L,11L,11L,11L,12L,11L,12L,11L,11L,12L,13L,12L,11L,13L,12L,13L,13L,13L,12L,13L,13L,14L,13L,14L,13L,14L,14L,14L,14L,14L,14L,15L,15L,15L,14L,14L,15L,14L,15L,15L,15L,15L,16L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251739Inst : IEnumerable<long>
{
public static readonly long[] Value=A251739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251739.Bytes);
public long this[int i]=>Value[i];

public static A251739Inst Instance=new A251739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251740
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,1L,2L,4L,8L,16L,32L,63L,126L,252L,503L,1004L,2004L,4000L,7984L,15936L,31809L,63492L,126732L,252961L,504918L,1007832L,2011664L,4015344L,8014752L,15997695L,31931898L,63737064L,127221167L,253937416L,506867000L,1011722336L,2019429328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251740Inst : IEnumerable<long>
{
public static readonly long[] Value=A251740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251740.Bytes);
public long this[int i]=>Value[i];

public static A251740Inst Instance=new A251740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251741
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,1L,2L,4L,8L,16L,31L,62L,124L,248L,495L,988L,1972L,3936L,7856L,15681L,31300L,62476L,124704L,248913L,496838L,991704L,1979472L,3951088L,7886495L,15741690L,31420904L,62717104L,125185295L,249873752L,498755800L,995532128L,1987113168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251741Inst : IEnumerable<long>
{
public static readonly long[] Value=A251741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251741.Bytes);
public long this[int i]=>Value[i];

public static A251741Inst Instance=new A251741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251742
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,0L,1L,2L,4L,8L,15L,30L,60L,120L,240L,479L,956L,1908L,3808L,7601L,15172L,30284L,60448L,120656L,240833L,480710L,959512L,1915216L,3822831L,7630490L,15230696L,30400944L,60681232L,121121631L,241762552L,482565592L,963215968L,1922609105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251742Inst : IEnumerable<long>
{
public static readonly long[] Value=A251742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251742.Bytes);
public long this[int i]=>Value[i];

public static A251742Inst Instance=new A251742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251743
{
public static readonly long[] Value={ 3L,13L,49L,185L,713L,2793L,11049L,43945L,175273L,700073L,2798249L,11188905L,44747433L,178973353L,715860649L,2863377065L,11453377193L,45813246633L,183252462249L,733008800425L,2932033104553L,11728128223913L,46912504507049L,187650001250985L,750599971449513L,3002399818689193L,12009599140539049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251743Inst : IEnumerable<long>
{
public static readonly long[] Value=A251743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251743.Bytes);
public long this[int i]=>Value[i];

public static A251743Inst Instance=new A251743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251744
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,0L,1L,2L,4L,7L,14L,28L,56L,112L,224L,447L,892L,1780L,3553L,7092L,14156L,28256L,56400L,112576L,224705L,448518L,895256L,1786959L,3566826L,7119496L,14210736L,28365072L,56617568L,113010431L,225572344L,450249432L,898711905L,1793856984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251744Inst : IEnumerable<long>
{
public static readonly long[] Value=A251744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251744.Bytes);
public long this[int i]=>Value[i];

public static A251744Inst Instance=new A251744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251745
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,0L,0L,0L,1L,2L,3L,6L,12L,24L,48L,96L,192L,383L,764L,1525L,3044L,6076L,12128L,24208L,48320L,96448L,192513L,384262L,766999L,1530954L,3055832L,6099536L,12174864L,24301408L,48506368L,96820223L,193256184L,385745369L,769959784L,1536863736L,3067627936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251745Inst : IEnumerable<long>
{
public static readonly long[] Value=A251745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251745.Bytes);
public long this[int i]=>Value[i];

public static A251745Inst Instance=new A251745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251746
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,2L,4L,8L,16L,32L,64L,128L,255L,510L,1019L,2036L,4068L,8128L,16240L,32448L,64832L,129536L,258817L,517124L,1033229L,2064422L,4124776L,8241424L,16466608L,32900768L,65736704L,131343872L,262428927L,524340730L,1047648231L,2093232040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251746Inst : IEnumerable<long>
{
public static readonly long[] Value=A251746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251746.Bytes);
public long this[int i]=>Value[i];

public static A251746Inst Instance=new A251746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251747
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,2L,4L,8L,16L,32L,64L,127L,254L,508L,1015L,2028L,4052L,8096L,16176L,32320L,64576L,129025L,257796L,515084L,1029153L,2056278L,4108504L,8208912L,16401648L,32770976L,65477376L,130825727L,261393658L,522272232L,1043515311L,2084974344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251747Inst : IEnumerable<long>
{
public static readonly long[] Value=A251747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251747.Bytes);
public long this[int i]=>Value[i];

public static A251747Inst Instance=new A251747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251748
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,2L,4L,8L,16L,32L,63L,126L,252L,504L,1007L,2012L,4020L,8032L,16048L,32064L,64065L,128004L,255756L,511008L,1021009L,2040006L,4075992L,8143952L,16271856L,32511648L,64959231L,129790458L,259325160L,518139312L,1035257615L,2068475224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251748Inst : IEnumerable<long>
{
public static readonly long[] Value=A251748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251748.Bytes);
public long this[int i]=>Value[i];

public static A251748Inst Instance=new A251748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251749
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,2L,4L,8L,16L,31L,62L,124L,248L,496L,991L,1980L,3956L,7904L,15792L,31553L,63044L,125964L,251680L,502864L,1004737L,2007494L,4011032L,8014160L,16012528L,31993503L,63923962L,127721960L,255192240L,509881616L,1018758495L,2035509496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251749Inst : IEnumerable<long>
{
public static readonly long[] Value=A251749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251749.Bytes);
public long this[int i]=>Value[i];

public static A251749Inst Instance=new A251749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251750
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,2L,4L,8L,15L,30L,60L,120L,240L,480L,959L,1916L,3828L,7648L,15281L,30532L,61004L,121888L,243536L,486592L,972225L,1942534L,3881240L,7754832L,15494383L,30958234L,61855464L,123589040L,246934544L,493382496L,985792767L,1969643000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251750Inst : IEnumerable<long>
{
public static readonly long[] Value=A251750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251750.Bytes);
public long this[int i]=>Value[i];

public static A251750Inst Instance=new A251750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251751
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,2L,4L,7L,14L,28L,56L,112L,224L,448L,895L,1788L,3572L,7137L,14260L,28492L,56928L,113744L,227264L,454080L,907265L,1812742L,3621912L,7236687L,14459114L,28889736L,57722544L,115331344L,230435424L,460416768L,919926271L,1838039800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251751Inst : IEnumerable<long>
{
public static readonly long[] Value=A251751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251751.Bytes);
public long this[int i]=>Value[i];

public static A251751Inst Instance=new A251751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251752
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,6L,12L,24L,48L,96L,192L,384L,767L,1532L,3061L,6116L,12220L,24416L,48784L,97472L,194752L,389120L,777473L,1553414L,3103767L,6201418L,12390616L,24756816L,49464848L,98832224L,197469696L,394550272L,788323071L,1575092728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251752Inst : IEnumerable<long>
{
public static readonly long[] Value=A251752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251752.Bytes);
public long this[int i]=>Value[i];

public static A251752Inst Instance=new A251752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251753
{
public static readonly long[] Value={ 1L,1L,2L,6L,3L,15L,5L,35L,70L,70L,7L,77L,231L,3003L,858L,1430L,1430L,24310L,12155L,230945L,46189L,230945L,176358L,4056234L,676039L,676039L,104006L,312018L,44574L,1292646L,1077205L,33393355L,66786710L,2203961430L,64822395L,90751353L,90751353L,3357800061L,353452638L,1531628098L,3829070245L,156991880045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251753Inst : IEnumerable<long>
{
public static readonly long[] Value=A251753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251753.Bytes);
public long this[int i]=>Value[i];

public static A251753Inst Instance=new A251753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251754
{
public static readonly long[] Value={ 3L,5L,3L,3L,2L,6L,3L,8L,9L,3L,5L,3L,3L,2L,6L,3L,8L,9L,3L,5L,3L,3L,2L,6L,3L,8L,9L,3L,5L,3L,3L,2L,6L,3L,8L,9L,3L,5L,3L,3L,2L,6L,3L,8L,9L,3L,5L,3L,3L,2L,6L,3L,8L,9L,3L,5L,3L,3L,2L,6L,3L,8L,9L,3L,5L,3L,3L,2L,6L,3L,8L,9L,3L,5L,3L,3L,2L,6L,3L,8L,9L,3L,5L,3L,3L,2L,6L,3L,8L,9L,3L,5L,3L,3L,2L,6L,3L,8L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251754Inst : IEnumerable<long>
{
public static readonly long[] Value=A251754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251754.Bytes);
public long this[int i]=>Value[i];

public static A251754Inst Instance=new A251754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251755
{
public static readonly long[] Value={ 0L,2L,6L,3L,2L,3L,6L,2L,9L,9L,2L,6L,3L,2L,3L,6L,2L,9L,9L,2L,6L,3L,2L,3L,6L,2L,9L,9L,2L,6L,3L,2L,3L,6L,2L,9L,9L,2L,6L,3L,2L,3L,6L,2L,9L,9L,2L,6L,3L,2L,3L,6L,2L,9L,9L,2L,6L,3L,2L,3L,6L,2L,9L,9L,2L,6L,3L,2L,3L,6L,2L,9L,9L,2L,6L,3L,2L,3L,6L,2L,9L,9L,2L,6L,3L,2L,3L,6L,2L,9L,9L,2L,6L,3L,2L,3L,6L,2L,9L,9L,2L,6L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251755Inst : IEnumerable<long>
{
public static readonly long[] Value=A251755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251755.Bytes);
public long this[int i]=>Value[i];

public static A251755Inst Instance=new A251755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251756
{
public static readonly long[] Value={ 0L,4L,8L,12L,6L,18L,9L,27L,36L,16L,20L,10L,30L,15L,45L,54L,24L,28L,14L,42L,21L,63L,72L,32L,40L,44L,22L,66L,33L,99L,81L,90L,48L,52L,26L,78L,39L,117L,108L,56L,60L,50L,25L,75L,100L,64L,68L,34L,102L,51L,153L,126L,70L,35L,105L,84L,76L,38L,114L,57L,171L,135L,120L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251756Inst : IEnumerable<long>
{
public static readonly long[] Value=A251756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251756.Bytes);
public long this[int i]=>Value[i];

public static A251756Inst Instance=new A251756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251757
{
public static readonly long[] Value={ 39939L,656709L,762701L,777149L,779619L,790841L,869859L,1106681L,1156299L,1254341L,1320981L,1330319L,1730681L,2251349L,2344211L,2882541L,2924861L,3079469L,3292241L,3419789L,3580901L,3661529L,3781541L,3784439L,3848289L,4358481L,4384979L,4507889L,4524549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251757Inst : IEnumerable<long>
{
public static readonly long[] Value=A251757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251757.Bytes);
public long this[int i]=>Value[i];

public static A251757Inst Instance=new A251757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251758
{
public static readonly long[] Value={ 2L,3L,1L,5L,1L,7L,1L,2L,1L,11L,1L,13L,1L,2L,1L,17L,1L,19L,1L,2L,1L,23L,1L,4L,1L,2L,1L,29L,1L,31L,1L,2L,1L,4L,1L,37L,1L,2L,1L,41L,1L,43L,1L,2L,1L,47L,1L,6L,1L,2L,1L,53L,1L,4L,1L,2L,1L,59L,1L,61L,1L,2L,1L,4L,1L,67L,1L,2L,1L,71L,1L,73L,1L,2L,1L,6L,1L,79L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251758Inst : IEnumerable<long>
{
public static readonly long[] Value=A251758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251758.Bytes);
public long this[int i]=>Value[i];

public static A251758Inst Instance=new A251758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251759
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,2L,4L,8L,16L,32L,64L,128L,256L,511L,1022L,2043L,4084L,8164L,16320L,32624L,65216L,130368L,260608L,520960L,1041409L,2081796L,4161549L,8319014L,16629864L,33243408L,66454192L,132843168L,265555968L,530851328L,1061181696L,2121321983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251759Inst : IEnumerable<long>
{
public static readonly long[] Value=A251759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251759.Bytes);
public long this[int i]=>Value[i];

public static A251759Inst Instance=new A251759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251760
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,2L,4L,8L,16L,32L,64L,128L,255L,510L,1020L,2039L,4076L,8148L,16288L,32560L,65088L,130112L,260096L,519937L,1039364L,2077708L,4153377L,8302678L,16597208L,33178128L,66323696L,132582304L,265034496L,529808896L,1059097855L,2117156346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251760Inst : IEnumerable<long>
{
public static readonly long[] Value=A251760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251760.Bytes);
public long this[int i]=>Value[i];

public static A251760Inst Instance=new A251760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A251761
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,2L,4L,8L,16L,32L,64L,127L,254L,508L,1016L,2031L,4060L,8116L,16224L,32432L,64832L,129600L,259073L,517892L,1035276L,2069536L,4137041L,8270022L,16531928L,33047632L,66062832L,132060832L,263992064L,527725055L,1054932218L,2108829160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A251761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A251761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A251761Inst : IEnumerable<long>
{
public static readonly long[] Value=A251761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A251761.Bytes);
public long this[int i]=>Value[i];

public static A251761Inst Instance=new A251761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}