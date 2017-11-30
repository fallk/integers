using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A131617
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,11L,14L,15L,16L,17L,18L,19L,20L,23L,25L,29L,31L,41L,44L,52L,58L,81L,91L };
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
public class A131617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131617Inst : IEnumerable<long>
{
public static readonly long[] Value=A131617.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131617.Bytes);
public long this[int i]=>Value[i];

public static A131617Inst Instance=new A131617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131618
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,9L,22L,33L,34L,38L,46L,49L,75L,106L };
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
public class A131618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131618Inst : IEnumerable<long>
{
public static readonly long[] Value=A131618.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131618.Bytes);
public long this[int i]=>Value[i];

public static A131618Inst Instance=new A131618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131619
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,0L,0L,4L,4L,3L,3L,2L,0L,5L,1L,1L,4L,4L,1L,0L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,1L,0L,3L,3L,2L,1L,1L,1L,1L,3L,3L,0L,4L,3L,1L,1L,1L,1L,1L,1L,4L,2L,0L,4L };
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
public class A131619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131619Inst : IEnumerable<long>
{
public static readonly long[] Value=A131619.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131619.Bytes);
public long this[int i]=>Value[i];

public static A131619Inst Instance=new A131619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131620
{
public static readonly long[] Value={ 1L,0L,8L,27L,55L,240L,701L,1909L,5753L,15747L,41138L,104762L,252664L,580609L,1274691L,2665295L,5315469L,10113564L,18353698L,31781680L,52486460L,82606895L,123821091L,176518711L,238906435L,306378988L,371328696L,423932616L };
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
public class A131620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131620Inst : IEnumerable<long>
{
public static readonly long[] Value=A131620.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131620.Bytes);
public long this[int i]=>Value[i];

public static A131620Inst Instance=new A131620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131621
{
public static readonly BigInteger[] Value={ 8L,111L,1562L,8119L,128103L,665857L,10506008L,147830751L,768398401L,12123924128L,63018038201L,994309609247L,13990997937704L,72722761475561L,1147432427450279L,5964153172084899L,94103450048860582L,1324136026968012719L,6882627592338442563L,BigInteger.Parse("108595299810873229246") };
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
public class A131621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131621Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131621.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131621.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131621Inst Instance=new A131621Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131622
{
public static readonly BigInteger[] Value={ 1L,1L,8L,22L,124L,948L,6138L,50832L,468144L,5165280L,54704880L,695854080L,9016051680L,130427750880L,1994479744320L,32575206343680L,555499414471680L,10284817657927680L,196642556903116800L,3994718386866278400L,BigInteger.Parse("84989047758544742400"),BigInteger.Parse("1895851170953432985600") };
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
public class A131622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131622.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131622Inst Instance=new A131622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131623
{
public static readonly long[] Value={ 1L,1L,7L,9L,31L,223L,442L,1529L,6559L,66111L,159952L,742503L,3047656L,19094286L,245173117L,761328969L,3935539271L,20213664703L,117323673136L,897132508439L,15791065424134L,56649181720176L,353387529508691L,1955231849465423L };
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
public class A131623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131623Inst : IEnumerable<long>
{
public static readonly long[] Value=A131623.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131623.Bytes);
public long this[int i]=>Value[i];

public static A131623Inst Instance=new A131623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131672
{
public static readonly long[] Value={ 1L,561L,1155L,2145L,3795L,5005L,5005L,8645L,8645L,11305L,11305L,11305L,11305L,11305L,11305L,11305L,11305L,11305L,11305L,11305L,11305L };
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
public class A131672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131672Inst : IEnumerable<long>
{
public static readonly long[] Value=A131672.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131672.Bytes);
public long this[int i]=>Value[i];

public static A131672Inst Instance=new A131672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131673
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,14L,19L,25L,31L,38L,46L,55L,65L,76L,88L,101L,115L,129L,144L,160L,177L,195L,214L,234L,255L,277L,300L,324L,349L,375L,402L,430L,459L,489L,519L,550L,582L,615L,649L,684L,720L,757L,795L,834L,874L,915L,957L,1000L,1044L,1089L,1135L,1182L,1230L,1279L,1329L,1380L,1432L };
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
public class A131673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131673Inst : IEnumerable<long>
{
public static readonly long[] Value=A131673.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131673.Bytes);
public long this[int i]=>Value[i];

public static A131673Inst Instance=new A131673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131674
{
public static readonly long[] Value={ 0L,1L,3L,5L,8L,12L,17L,23L,29L,36L,44L,53L,63L,74L,86L,99L,113L,127L,142L,158L,175L,193L,212L,232L,253L,275L,298L,322L,347L,373L,400L,428L,457L,487L,517L,548L,580L,613L,647L,682L,718L,755L,793L,832L,872L,913L,955L,998L,1042L,1087L,1133L,1180L,1228L,1277L,1327L,1378L,1430L,1483L };
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
public class A131674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131674Inst : IEnumerable<long>
{
public static readonly long[] Value=A131674.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131674.Bytes);
public long this[int i]=>Value[i];

public static A131674Inst Instance=new A131674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131675
{
public static readonly long[] Value={ 1L,6L,1221L,231880L,13443885L,340203456L,4910472385L,47565216504L,342540938025L,1962871989130L,9382270310061L,38701449021984L,141297910237237L,465502930269300L,1404867737405385L,3930816255364816L,10296122969028753L,25448298063869070L,59744930256741205L };
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
public class A131675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131675Inst : IEnumerable<long>
{
public static readonly long[] Value=A131675.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131675.Bytes);
public long this[int i]=>Value[i];

public static A131675Inst Instance=new A131675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131676
{
public static readonly BigInteger[] Value={ 1L,7L,14245L,28405300L,9191136045L,886286703456L,38188743738145L,932714257963020L,14966184483875625L,173860405001195185L,1563721100613810061L,11427034989921521488UL,BigInteger.Parse("70319024498214551605"),BigInteger.Parse("374482754394635213250"),BigInteger.Parse("1763001772206469563945"),BigInteger.Parse("7462412915610398239816") };
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
public class A131676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131676Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131676.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131676.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131676Inst Instance=new A131676Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131677
{
public static readonly BigInteger[] Value={ 1L,8L,274725L,8903032600L,21521701559085L,9892478959203456L,1527238784041075105L,BigInteger.Parse("109733832449349303000"),BigInteger.Parse("4483781212288588835625"),BigInteger.Parse("118795734924428077310080"),BigInteger.Parse("2233888850312257843810061"),BigInteger.Parse("31811523551546985038211552"),BigInteger.Parse("359951182400070234774044725") };
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
public class A131677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131677Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131677.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131677.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131677Inst Instance=new A131677Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131678
{
public static readonly BigInteger[] Value={ 1L,9L,9065925L,7310502643675L,176327300873583405L,BigInteger.Parse("483041091658815453456"),BigInteger.Parse("320648364425775841520065"),BigInteger.Parse("79074323113562613259765875"),BigInteger.Parse("9403175220694650942397475625"),BigInteger.Parse("639220975955961365494757841040"),BigInteger.Parse("27923612862792073359883606310061"),BigInteger.Parse("852385355738368243011331354210716"),BigInteger.Parse("19346552845649626158477975728463925") };
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
public class A131678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131678Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131678.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131678.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131678Inst Instance=new A131678Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131679
{
public static readonly BigInteger[] Value={ 1L,10L,524816325L,15995379784360900L,BigInteger.Parse("5136081211768056707885"),BigInteger.Parse("104827108835105429096703456"),BigInteger.Parse("359044402823940369662885183425"),BigInteger.Parse("354548318931625565271233374406000"),BigInteger.Parse("140230322081790179721500725877795625"),BigInteger.Parse("27516367648544953143193233240569070880"),BigInteger.Parse("3102623679344954347223585172112606310061") };
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
public class A131679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131679Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131679.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131679.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131679Inst Instance=new A131679Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131680
{
public static readonly BigInteger[] Value={ 1L,11L,54266008005L,BigInteger.Parse("94467113468457039310"),BigInteger.Parse("538562285352301951109430061"),BigInteger.Parse("102370328298891480707678565453456"),BigInteger.Parse("2171004564341130364494477279762016705"),BigInteger.Parse("10015112821822553484101305268477882115400"),BigInteger.Parse("15057116321451208557735379863635553426467625"),BigInteger.Parse("9594364176429126945241161642390324911313805168") };
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
public class A131680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131680Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131680.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131680.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131680Inst Instance=new A131680Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131681
{
public static readonly long[] Value={ 0L,1L,8L,48L,384L,1440L,8640L,40320L,184320L,829440L,5529600L,18247680L,87588864L,474439680L,1532805120L,7664025600L,32699842560L,130288435200L,517321728000L,2184247296000L,9196830720000L,38626689024000L,188841590784000L };
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
public class A131681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131681Inst : IEnumerable<long>
{
public static readonly long[] Value=A131681.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131681.Bytes);
public long this[int i]=>Value[i];

public static A131681Inst Instance=new A131681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131682
{
public static readonly long[] Value={ 2L,7L,42L,242L,1050L,3537L,9842L,23732L,51282L,101675L,188122L,328902L,548522L,878997L,1361250L,2046632L,2998562L,4294287L,6026762L,8306650L,11264442L,15052697L,19848402L,25855452L,33307250L,42469427L,53642682L,67165742L,83418442L,102824925L,125856962L };
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
public class A131682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131682Inst : IEnumerable<long>
{
public static readonly long[] Value=A131682.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131682.Bytes);
public long this[int i]=>Value[i];

public static A131682Inst Instance=new A131682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131683
{
public static readonly long[] Value={ 48L,175L,1680L,25410L,294000L,2295513L,12991440L,57550100L,211281840L,669529875L,1885734928L,4823347830L,11387316720L,25126129245L,52326450000L,103659864168L,196585724720L,358766207415L,632810010000L,1082730294250L,1802581066608L,2927824829985L,4650083620560L };
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
public class A131683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131683Inst : IEnumerable<long>
{
public static readonly long[] Value=A131683.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131683.Bytes);
public long this[int i]=>Value[i];

public static A131683Inst Instance=new A131683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131684
{
public static readonly BigInteger[] Value={ 829440L,3053435L,40040448L,2673065934L,323958835200L,24350583830265L,971969903106048L,23061845117771260L,365309311365605376L,4216355578004498775L,BigInteger.Parse("37787143366734755840"),BigInteger.Parse("275548505246977513866"),BigInteger.Parse("1693398609738955671552"),BigInteger.Parse("9010265266941299501973"),BigInteger.Parse("42393383140543522560000") };
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
public class A131684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131684Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131684.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131684.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131684Inst Instance=new A131684Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131685
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,7L,7L,1L,1L,1L,1L,1L,11L,11L,11L,55L,143L,13L,91L,91L,91L,91L,91L,1001L,17017L,595595L,595595L,17017L,46189L,600457L,3002285L,3002285L,3002285L,3002285L,6605027L,3002285L,726869L,726869L,726869L };
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
public class A131685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131685Inst : IEnumerable<long>
{
public static readonly long[] Value=A131685.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131685.Bytes);
public long this[int i]=>Value[i];

public static A131685Inst Instance=new A131685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131686
{
public static readonly long[] Value={ 208L,373L,653L,989L,1469L,2189L,2981L,4061L,5381L,6701L,8069L,9917L,12029L,14069L,16709L,19541L,22061L,24821L,27989L,31421L,35789L,40661L,45029L,49589L,53549L,56909L,62837L,69389L,76709L,84149L,93581L,100253L,107741L,115541L,124109L,131837L };
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
public class A131686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131686Inst : IEnumerable<long>
{
public static readonly long[] Value=A131686.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131686.Bytes);
public long this[int i]=>Value[i];

public static A131686Inst Instance=new A131686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131687
{
public static readonly long[] Value={ 101L,103L,107L,109L,113L,127L,131L,211L,223L,227L,229L,307L,311L,313L,317L,331L,401L,409L,419L,421L,503L,509L,521L,523L,601L,607L,613L,617L,619L,701L,709L,719L,727L,809L,811L,821L,823L,827L,829L,907L,911L,919L,929L,1009L,1013L,1019L,1021L,1031L,1103L,1109L,1117L,1123L,1129L,1201L,1213L,1217L,1223L,1229L,1231L };
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
public class A131687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131687Inst : IEnumerable<long>
{
public static readonly long[] Value=A131687.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131687.Bytes);
public long this[int i]=>Value[i];

public static A131687Inst Instance=new A131687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131736
{
public static readonly long[] Value={ 0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L };
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
public class A131736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131736Inst : IEnumerable<long>
{
public static readonly long[] Value=A131736.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131736.Bytes);
public long this[int i]=>Value[i];

public static A131736Inst Instance=new A131736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131737
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,3L,3L,4L,5L,5L,6L,7L,7L,8L,9L,9L,10L,11L,11L,12L,13L,13L,14L,15L,15L,16L,17L,17L,18L,19L,19L,20L,21L,21L,22L,23L,23L,24L,25L,25L,26L,27L,27L,28L,29L,29L,30L,31L,31L,32L,33L,33L,34L,35L,35L,36L,37L,37L,38L,39L,39L,40L,41L,41L,42L,43L,43L,44L,45L };
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
public class A131737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131737Inst : IEnumerable<long>
{
public static readonly long[] Value=A131737.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131737.Bytes);
public long this[int i]=>Value[i];

public static A131737Inst Instance=new A131737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131738
{
public static readonly long[] Value={ 0L,-2L,3L,-4L,5L,-6L,7L,-8L,9L,-10L,11L,-12L,13L,-14L,15L,-16L,17L,-18L,19L,-20L,21L,-22L,23L,-24L,25L,-26L,27L,-28L,29L,-30L,31L,-32L,33L,-34L,35L,-36L,37L,-38L,39L,-40L,41L,-42L,43L,-44L,45L,-46L,47L,-48L,49L,-50L,51L,-52L,53L,-54L,55L,-56L,57L,-58L,59L,-60L,61L,-62L,63L,-64L,65L,-66L,67L,-68L,69L,-70L,71L,-72L,73L,-74L,75L };
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
public class A131738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131738Inst : IEnumerable<long>
{
public static readonly long[] Value=A131738.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131738.Bytes);
public long this[int i]=>Value[i];

public static A131738Inst Instance=new A131738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131739
{
public static readonly long[] Value={ 0L,0L,2L,3L,1L,1L,5L,6L,2L,2L,8L,9L,3L,3L,11L,12L,4L,4L,14L,15L,5L,5L,17L,18L,6L,6L,20L,21L,7L,7L,23L,24L,8L,8L,26L,27L,9L,9L,29L,30L,10L,10L,32L,33L,11L,11L,35L,36L,12L,12L,38L,39L,13L,13L,41L,42L,14L,14L,44L,45L,15L,15L,47L,48L,16L,16L,50L,51L,17L,17L,53L,54L,18L,18L,56L,57L,19L,19L,59L };
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
public class A131739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131739Inst : IEnumerable<long>
{
public static readonly long[] Value=A131739.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131739.Bytes);
public long this[int i]=>Value[i];

public static A131739Inst Instance=new A131739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131740
{
public static readonly long[] Value={ 3L,12L,31L,60L,101L,156L,223L,304L,401L,510L,631L,766L,923L,1090L,1265L,1470L,1687L,1926L,2179L,2448L,2735L,3040L,3353L,3698L,4057L,4428L,4817L,5230L,5661L,6106L,6555L,7042L,7535L,8064L,8611L,9172L,9755L,10354L,10973L,11610L,12271L,12954L,13645L };
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
public class A131740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131740Inst : IEnumerable<long>
{
public static readonly long[] Value=A131740.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131740.Bytes);
public long this[int i]=>Value[i];

public static A131740Inst Instance=new A131740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131741
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,29L,31L,37L,41L,67L,73L,83L,89L,101L,107L,127L,139L,157L,179L,193L,227L,233L,263L,271L,281L,307L,331L,337L,379L,389L,397L,401L,409L,431L,433L,467L,491L,499L,509L,563L,571L,613L,641L,647L,743L,769L,809L,823L,883L,887L,907L,937L,983L,1009L,1021L };
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
public class A131741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131741Inst : IEnumerable<long>
{
public static readonly long[] Value=A131741.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131741.Bytes);
public long this[int i]=>Value[i];

public static A131741Inst Instance=new A131741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131742
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,0L,4L,5L,0L,0L,7L,8L,0L,0L,10L,11L,0L,0L,13L,14L,0L,0L,16L,17L,0L,0L,19L,20L,0L,0L,22L,23L,0L,0L,25L,26L,0L,0L,28L,29L,0L,0L,31L,32L,0L,0L,34L,35L,0L,0L,37L,38L,0L,0L,40L,41L,0L,0L,43L,44L,0L,0L,46L,47L,0L,0L,49L,50L,0L,0L,52L,53L,0L,0L,55L,56L,0L,0L,58L,59L,0L,0L,61L,62L,0L,0L,64L };
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
public class A131742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131742Inst : IEnumerable<long>
{
public static readonly long[] Value=A131742.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131742.Bytes);
public long this[int i]=>Value[i];

public static A131742Inst Instance=new A131742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131743
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L };
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
public class A131743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131743Inst : IEnumerable<long>
{
public static readonly long[] Value=A131743.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131743.Bytes);
public long this[int i]=>Value[i];

public static A131743Inst Instance=new A131743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131744
{
public static readonly long[] Value={ 1L,9L,9L,5L,5L,9L,9L,5L,5L,9L,1L,3L,13L,17L,1L,3L,13L,17L,9L,5L,5L,9L,9L,5L,5L,9L,1L,3L,13L,17L,1L,3L,13L,17L,9L,5L,5L,9L,10L,1L,9L,15L,12L,10L,13L,0L,15L,12L,1L,9L,2L,15L,0L,9L,5L,14L,17L,17L,9L,6L,15L,0L,9L,1L,1L,9L,15L,12L,10L,13L,0L,15L,12L,1L,9L,2L,15L,0L,9L,5L,14L,17L,17L,9L };
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
public class A131744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131744Inst : IEnumerable<long>
{
public static readonly long[] Value=A131744.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131744.Bytes);
public long this[int i]=>Value[i];

public static A131744Inst Instance=new A131744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131745
{
public static readonly long[] Value={ 4L,20L,19L,2L,13L,17L,13L,5L,7L,13L,16L,5L,15L,10L,9L,16L,15L,2L,1L,16L,3L,4L,2L,13L,4L,17L,21L,1L,5L,15L,5L,14L,11L,4L,0L,2L,13L,4L,17L,21L,2L,6L,5L,3L,2L,14L,11L,4L,0L,2L,13L,4L,17L,21L,14L,14L,4L,17L,21L,2L,6L,5L,3L,0L,4L,12L,5L,12L,21L,1L,5L,15L,10L,9L,16L,15L,13L,14L,4L,17L };
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
public class A131745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131745Inst : IEnumerable<long>
{
public static readonly long[] Value=A131745.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131745.Bytes);
public long this[int i]=>Value[i];

public static A131745Inst Instance=new A131745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131746
{
public static readonly long[] Value={ 9L,16L,15L,13L,14L,4L,17L,21L,12L,4L,12L,5L,12L,21L,15L,2L,13L,4L,17L,21L,12L,4L,20L,19L,5L,3L,8L,21L,12L,4L,20L,19L,2L,13L,1L,5L,15L,5L,14L,11L,4L,2L,13L,5L,7L,13L,15L,15L,1L,7L,10L,11L,6L,5L,21L,12L,4L,20L,19L,2L,13L,1L,11L,6L,5L,21L,2L,6L,5L,3L,13L,11L,6L,5L,21L,17L,13L,5L,7L };
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
public class A131746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131746Inst : IEnumerable<long>
{
public static readonly long[] Value=A131746.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131746.Bytes);
public long this[int i]=>Value[i];

public static A131746Inst Instance=new A131746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131747
{
public static readonly long[] Value={ 1L,1L,1L,3L,11L,32L,152L,625L,3152L,16154L,90993L,539181L,3398803L,22561791L,157493522L,1151863409L,8803760900L,70149141443L,581461668973L,5004153572628L };
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
public class A131747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131747Inst : IEnumerable<long>
{
public static readonly long[] Value=A131747.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131747.Bytes);
public long this[int i]=>Value[i];

public static A131747Inst Instance=new A131747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131748
{
public static readonly long[] Value={ 2L,5L,739L,47L,4229L,2803L,27617L,142589L,108271L,2347283L,1108739L,300776929L,300776929L,14674550173L,92799126239L };
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
public class A131748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131748Inst : IEnumerable<long>
{
public static readonly long[] Value=A131748.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131748.Bytes);
public long this[int i]=>Value[i];

public static A131748Inst Instance=new A131748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131749
{
public static readonly long[] Value={ 4L,2L,6L,1L,3L,9L,1L,2L,1L,10L,0L,1L,3L,4L,14L,1L,1L,0L,3L,1L,15L,0L,1L,2L,2L,5L,6L,21L,1L,1L,0L,2L,0L,5L,1L,22L,1L,0L,1L,1L,3L,3L,2L,3L,25L,1L,0L,0L,1L,0L,3L,0L,2L,1L,26L,1L,0L,0L,0L,1L,1L,4L,4L,6L,7L,33L,1L,0L,0L,0L,0L,1L,0L,4L,0L,6L,1L,34L,0L,1L,1L,1L,1L,1L,2L,2L,6L,6L,0L,1L,35L };
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
public class A131749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131749Inst : IEnumerable<long>
{
public static readonly long[] Value=A131749.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131749.Bytes);
public long this[int i]=>Value[i];

public static A131749Inst Instance=new A131749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131750
{
public static readonly BigInteger[] Value={ 1L,85L,16381L,3177721L,616461385L,119590330861L,23199907725541L,4500662508423985L,873105326726527441L,BigInteger.Parse("169377932722437899461"),BigInteger.Parse("32858445842826225967885"),BigInteger.Parse("6374369115575565399870121") };
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
public class A131750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131750.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131750Inst Instance=new A131750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131751
{
public static readonly BigInteger[] Value={ 1L,31L,1891L,117181L,7263301L,450207451L,27905598631L,1729696907641L,107213302675081L,6645495068947351L,411913480972060651L,BigInteger.Parse("25531990325198812981"),BigInteger.Parse("1582571486681354344141"),BigInteger.Parse("98093900183918770523731") };
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
public class A131751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131751.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131751Inst Instance=new A131751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131800
{
public static readonly long[] Value={ 1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L,1L,2L,5L,6L };
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
public class A131800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131800Inst : IEnumerable<long>
{
public static readonly long[] Value=A131800.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131800.Bytes);
public long this[int i]=>Value[i];

public static A131800Inst Instance=new A131800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131801
{
public static readonly long[] Value={ 1L,3L,9L,15L,27L,45L,105L,81L,135L,225L,315L,1155L,243L,405L,675L,945L,1575L,3465L,15015L,729L,1215L,2025L,3375L,2835L,4725L,10395L,11025L,17325L,45045L,255255L,2187L,3645L,6075L,10125L,8505L,14175L,23625L,31185L,33075L,51975L,121275L,135135L,225225L };
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
public class A131801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131801Inst : IEnumerable<long>
{
public static readonly long[] Value=A131801.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131801.Bytes);
public long this[int i]=>Value[i];

public static A131801Inst Instance=new A131801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131802
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,3L,0L,1L,1L,2L,0L,3L,0L,3L,1L,1L,0L,7L,0L,1L,1L,3L,0L,5L,0L,5L,1L,1L,1L,8L,0L,1L,1L,7L,0L,5L,0L,3L,3L,1L,0L,14L,0L,3L,1L,3L,0L,7L,1L,7L,1L,1L,0L,14L,0L,1L,3L,8L,1L,5L,0L,3L,1L,5L,0L,20L,0L,1L,3L,3L,1L,5L,0L,14L,2L,1L,0L,14L,1L,1L,1L,7L };
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
public class A131802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131802Inst : IEnumerable<long>
{
public static readonly long[] Value=A131802.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131802.Bytes);
public long this[int i]=>Value[i];

public static A131802Inst Instance=new A131802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131803
{
public static readonly long[] Value={ 4L,8L,11L,3L,8L,12L,3L,7L,11L,4L,6L,9L,3L,6L,10L,1L,8L,12L,3L,7L,12L,4L,7L,11L,3L,6L,10L,1L,7L,10L,2L,5L,11L,4L,6L,9L,4L,8L,11L,3L,6L,10L,1L,5L,9L,12L,4L,7L,3L,6L,10L,1L,6L,10L,1L,5L,10L,2L,5L,9L,1L,4L,8L,11L,11L,4L,6L,9L,4L,8L,11L,3L,6L,10L,1L,5L,9L,12L,4L,7L,4L,8L,11L,3L,8L,12L,3L,7L,11L,4L,6L,9L,3L,6L };
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
public class A131803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131803Inst : IEnumerable<long>
{
public static readonly long[] Value=A131803.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131803.Bytes);
public long this[int i]=>Value[i];

public static A131803Inst Instance=new A131803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131804
{
public static readonly long[] Value={ 0L,0L,-1L,-1L,1L,2L,1L,2L,6L,8L,7L,9L,15L,18L,17L,20L,28L,32L,31L,35L,45L,50L,49L,54L,66L,72L,71L,77L,91L,98L,97L,104L,120L,128L,127L,135L,153L,162L,161L,170L,190L,200L,199L,209L,231L,242L,241L,252L,276L,288L,287L,299L,325L,338L,337L,350L,378L,392L,391L,405L,435L,450L };
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
public class A131804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131804Inst : IEnumerable<long>
{
public static readonly long[] Value=A131804.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131804.Bytes);
public long this[int i]=>Value[i];

public static A131804Inst Instance=new A131804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131805
{
public static readonly long[] Value={ 0L,-1L,1L,0L,4L,3L,9L,8L,16L,15L,25L,24L,36L,35L,49L,48L,64L,63L,81L,80L,100L,99L,121L,120L,144L,143L,169L,168L,196L,195L,225L,224L,256L,255L,289L,288L,324L,323L,361L,360L,400L,399L,441L,440L,484L,483L,529L,528L,576L,575L,625L,624L,676L,675L,729L,728L,784L,783L,841L };
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
public class A131805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131805Inst : IEnumerable<long>
{
public static readonly long[] Value=A131805.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131805.Bytes);
public long this[int i]=>Value[i];

public static A131805Inst Instance=new A131805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131806
{
public static readonly long[] Value={ 0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L,0L,2L,4L,6L };
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
public class A131806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131806Inst : IEnumerable<long>
{
public static readonly long[] Value=A131806.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131806.Bytes);
public long this[int i]=>Value[i];

public static A131806Inst Instance=new A131806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131807
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,4L,5L,6L,7L,8L,8L,8L,9L,10L,11L,12L,12L,12L,13L,14L,15L,16L,16L,16L,16L,16L,16L,16L,17L,18L,18L,18L,18L,18L,18L,18L,19L,20L,21L,22L,22L,22L,23L,24L,25L,26L,26L,26L,26L,26L,26L,26L,27L,28L,29L,30L,31L,32L,32L,32L,33L,34L,35L,36L,37L,38L,38L,38L,38L,38L,39L,40L,40L };
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
public class A131807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131807Inst : IEnumerable<long>
{
public static readonly long[] Value=A131807.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131807.Bytes);
public long this[int i]=>Value[i];

public static A131807Inst Instance=new A131807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131808
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,3L,3L,3L,3L,3L,4L,5L,5L,5L,5L,5L,6L,7L,7L,7L,7L,7L,8L,9L,10L,11L,12L,13L,13L,13L,14L,15L,16L,17L,18L,19L,19L,19L,19L,19L,20L,21L,21L,21L,21L,21L,22L,23L,24L,25L,26L,27L,27L,27L,27L,27L,27L,27L,28L,29L,29L,29L,29L,29L,29L,29L,30L,31L,32L,33L,33L,33L,34L,35L,36L,37L,38L };
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
public class A131808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131808Inst : IEnumerable<long>
{
public static readonly long[] Value=A131808.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131808.Bytes);
public long this[int i]=>Value[i];

public static A131808Inst Instance=new A131808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131809
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,3L,1L,5L,4L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
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
public class A131809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131809Inst : IEnumerable<long>
{
public static readonly long[] Value=A131809.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131809.Bytes);
public long this[int i]=>Value[i];

public static A131809Inst Instance=new A131809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131810
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,2L,1L,2L,3L,2L,2L,2L,3L,3L,3L,2L,2L,2L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,4L,3L,3L,4L,3L,3L,3L,3L,3L,3L,3L,2L,2L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,3L,4L,3L,3L,3L,4L,4L,3L,2L,2L,3L,2L,3L,3L,2L,3L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L };
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
public class A131810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131810Inst : IEnumerable<long>
{
public static readonly long[] Value=A131810.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131810.Bytes);
public long this[int i]=>Value[i];

public static A131810Inst Instance=new A131810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131811
{
public static readonly long[] Value={ 1L,1L,2L,10L,116L };
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
public class A131811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131811Inst : IEnumerable<long>
{
public static readonly long[] Value=A131811.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131811.Bytes);
public long this[int i]=>Value[i];

public static A131811Inst Instance=new A131811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131812
{
public static readonly long[] Value={ 8L,86L,1437L,6654L,81917L,827389L,17956860L,157286397L,1434451965L,12884901885L };
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
public class A131812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131812Inst : IEnumerable<long>
{
public static readonly long[] Value=A131812.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131812.Bytes);
public long this[int i]=>Value[i];

public static A131812Inst Instance=new A131812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131813
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,5L,5L,6L,5L,7L,3L,3L,4L,6L,8L,7L,6L,9L,7L,7L,8L,8L,9L,8L,10L,8L,11L,10L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,9L,11L,13L,15L,10L,12L,14L,16L,12L,15L,11L,14L,17L,12L,16L,13L,16L,14L,18L,12L,17L,13L,17L,14L,19L,14L,20L,15L,12L,18L,13L,18L,14L,21L,13L,19L,15L,13L };
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
public class A131813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131813Inst : IEnumerable<long>
{
public static readonly long[] Value=A131813.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131813.Bytes);
public long this[int i]=>Value[i];

public static A131813Inst Instance=new A131813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131814
{
public static readonly long[] Value={ 0L,1L,3L,10L,4L,5L,7L,9L,14L,17L,24L,26L,34L,36L,38L,40L,48L,53L,59L,65L,67L,74L,83L,116L,139L,141L,143L,145L,147L,162L,177L,187L,214L,148L,157L,163L,170L,175L,194L,206L,208L,257L,273L,276L,301L,309L,317L,342L,352L,453L,462L,500L,504L,505L,511L,525L,527L,546L,552L };
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
public class A131814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131814Inst : IEnumerable<long>
{
public static readonly long[] Value=A131814.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131814.Bytes);
public long this[int i]=>Value[i];

public static A131814Inst Instance=new A131814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131815
{
public static readonly BigInteger[] Value={ 1L,-2L,-12L,-120L,1680L,574560L,100457280L,18871332480L,4068839174400L,997177467686400L,265676948766028800L,BigInteger.Parse("68775633656816486400"),BigInteger.Parse("9975596960728285286400"),BigInteger.Parse("-9408345873371957191680000"),BigInteger.Parse("-16902988368910895971399680000") };
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
public class A131815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131815Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131815.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131815.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131815Inst Instance=new A131815Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131848
{
public static readonly long[] Value={ 0L,0L,0L,2L,1L,3L,0L,2L,2L,4L,0L,2L,4L,4L,6L,2L,2L,3L,2L,3L,5L,4L,4L,3L,1L,1L,26L,27L,1L,3L,2L,3L,5L,7L,34L,33L,33L,34L,37L,39L,1L,3L,0L,43L,1L,43L,46L,1L,2L,4L,49L,50L,0L,1L,54L,55L,51L,54L,53L,55L,57L,54L,51L,54L,57L,59L,62L,63L,63L,66L,69L,71L,1L,3L,4L,2L,73L,75L,69L,71L };
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
public class A131848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131848Inst : IEnumerable<long>
{
public static readonly long[] Value=A131848.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131848.Bytes);
public long this[int i]=>Value[i];

public static A131848Inst Instance=new A131848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131849
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L };
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
public class A131849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131849Inst : IEnumerable<long>
{
public static readonly long[] Value=A131849.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131849.Bytes);
public long this[int i]=>Value[i];

public static A131849Inst Instance=new A131849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131850
{
public static readonly long[] Value={ 8L,28L,42L,44L,50L,52L,70L,76L,98L,110L,117L,124L,138L,148L,164L,171L,174L,182L,186L,188L,230L,236L,242L,244L,261L,266L,268L,273L,279L,285L,286L,290L,292L,310L,316L,322L,333L,345L,357L,369L,370L,385L,388L,406L,410L,412L,425L,426L,428L,434L,436L,465L,475L,477L };
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
public class A131850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131850Inst : IEnumerable<long>
{
public static readonly long[] Value=A131850.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131850.Bytes);
public long this[int i]=>Value[i];

public static A131850Inst Instance=new A131850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131851
{
public static readonly long[] Value={ 0L,1L,0L,1L,-1L,0L,-1L,0L,0L,1L,0L,1L,-1L,0L,-1L,0L,1L,2L,1L,2L,0L,1L,0L,1L,1L,2L,1L,2L,0L,1L,0L,1L,0L,1L,0L,1L,-1L,0L,-1L,0L,0L,1L,0L,1L,-1L,0L,-1L,0L,1L,2L,1L,2L,0L,1L,0L,1L,1L,2L,1L,2L,0L,1L,0L,1L,-1L,0L,-1L,0L,-2L,-1L,-2L,-1L,-1L,0L,-1L,0L,-2L,-1L,-2L,-1L,0L,1L,0L,1L,-1L,0L,-1L,0L,0L,1L,0L,1L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-2L,-1L,-2L,-1L,-1L,0L,-1L,0L,-2L,-1L,-2L };
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
public class A131851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131851Inst : IEnumerable<long>
{
public static readonly long[] Value=A131851.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131851.Bytes);
public long this[int i]=>Value[i];

public static A131851Inst Instance=new A131851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131852
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,0L,1L,1L,-1L,-1L,0L,0L,-1L,-1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,-1L,-1L,0L,0L,-1L,-1L,0L,0L,1L,1L,2L,2L,1L,1L,2L,2L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,-1L,-1L,0L,0L,-1L,-1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,-1L,-1L,0L,0L,-1L,-1L,0L,0L,1L,1L,2L,2L,1L,1L,2L,2L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,0L };
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
public class A131852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131852Inst : IEnumerable<long>
{
public static readonly long[] Value=A131852.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131852.Bytes);
public long this[int i]=>Value[i];

public static A131852Inst Instance=new A131852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131853
{
public static readonly long[] Value={ 0L,5L,10L,15L,20L,30L,40L,45L,60L,65L,75L,80L,85L,90L,95L,105L,120L,125L,130L,135L,150L,160L,165L,170L,175L,180L,190L,195L,210L,215L,225L,235L,240L,245L,250L,255L,260L,270L,300L,320L,325L,330L,335L,340L,350L,360L,365L,380L,390L,420L,430L,450L,455L,470L,480L,485L };
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
public class A131853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131853Inst : IEnumerable<long>
{
public static readonly long[] Value=A131853.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131853.Bytes);
public long this[int i]=>Value[i];

public static A131853Inst Instance=new A131853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131854
{
public static readonly long[] Value={ 0L,2L,5L,7L,8L,10L,13L,15L,20L,22L,28L,30L,32L,34L,37L,39L,40L,42L,45L,47L,52L,54L,60L,62L,65L,67L,73L,75L,80L,82L,85L,87L,88L,90L,93L,95L,97L,99L,105L,107L,112L,114L,117L,119L,120L,122L,125L,127L,128L,130L,133L,135L,136L,138L,141L,143L,148L,150L,156L,158L,160L,162L,165L };
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
public class A131854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131854Inst : IEnumerable<long>
{
public static readonly long[] Value=A131854.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131854.Bytes);
public long this[int i]=>Value[i];

public static A131854Inst Instance=new A131854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131855
{
public static readonly long[] Value={ 0L,1L,4L,5L,10L,11L,14L,15L,16L,17L,20L,21L,26L,27L,30L,31L,40L,41L,44L,45L,56L,57L,60L,61L,64L,65L,68L,69L,74L,75L,78L,79L,80L,81L,84L,85L,90L,91L,94L,95L,104L,105L,108L,109L,120L,121L,124L,125L,130L,131L,134L,135L,146L,147L,150L,151L,160L,161L,164L,165L,170L,171L,174L };
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
public class A131855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131855Inst : IEnumerable<long>
{
public static readonly long[] Value=A131855.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131855.Bytes);
public long this[int i]=>Value[i];

public static A131855Inst Instance=new A131855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131856
{
public static readonly long[] Value={ 2L,7L,22L,32L,37L,42L,47L,52L,62L,67L,82L,87L,97L,107L,112L,117L,122L,127L,162L,167L,182L,227L,242L,247L,262L,292L,302L,322L,327L,342L,352L,357L,362L,367L,372L,382L,422L,482L,487L,502L,512L,517L,522L,527L,532L,542L,552L,557L,572L,577L,587L,592L,597L,602L,607L };
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
public class A131856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131856Inst : IEnumerable<long>
{
public static readonly long[] Value=A131856.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131856.Bytes);
public long this[int i]=>Value[i];

public static A131856Inst Instance=new A131856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131857
{
public static readonly long[] Value={ 2L,3L,6L,7L,18L,19L,22L,23L,32L,33L,36L,37L,42L,43L,46L,47L,48L,49L,52L,53L,58L,59L,62L,63L,66L,67L,70L,71L,82L,83L,86L,87L,96L,97L,100L,101L,106L,107L,110L,111L,112L,113L,116L,117L,122L,123L,126L,127L,162L,163L,166L,167L,178L,179L,182L,183L,226L,227L,230L,231L,242L,243L };
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
public class A131857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131857Inst : IEnumerable<long>
{
public static readonly long[] Value=A131857.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131857.Bytes);
public long this[int i]=>Value[i];

public static A131857Inst Instance=new A131857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131858
{
public static readonly long[] Value={ 1L,11L,16L,21L,26L,31L,41L,56L,61L,81L,91L,121L,131L,146L,151L,161L,171L,176L,181L,186L,191L,211L,241L,251L,256L,261L,266L,271L,276L,286L,296L,301L,316L,321L,331L,336L,341L,346L,351L,361L,376L,381L,386L,391L,406L,416L,421L,426L,431L,436L,446L,451L,466L,471L };
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
public class A131858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131858Inst : IEnumerable<long>
{
public static readonly long[] Value=A131858.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131858.Bytes);
public long this[int i]=>Value[i];

public static A131858Inst Instance=new A131858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131859
{
public static readonly long[] Value={ 1L,3L,9L,11L,16L,18L,21L,23L,24L,26L,29L,31L,33L,35L,41L,43L,48L,50L,53L,55L,56L,58L,61L,63L,81L,83L,89L,91L,113L,115L,121L,123L,129L,131L,137L,139L,144L,146L,149L,151L,152L,154L,157L,159L,161L,163L,169L,171L,176L,178L,181L,183L,184L,186L,189L,191L,209L,211L,217L };
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
public class A131859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131859Inst : IEnumerable<long>
{
public static readonly long[] Value=A131859.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131859.Bytes);
public long this[int i]=>Value[i];

public static A131859Inst Instance=new A131859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131860
{
public static readonly long[] Value={ 3L,18L,23L,33L,43L,48L,53L,58L,63L,83L,113L,123L,163L,178L,183L,243L,258L,263L,278L,288L,293L,298L,303L,308L,318L,323L,338L,343L,353L,363L,368L,373L,378L,383L,418L,423L,438L,483L,498L,503L,513L,523L,528L,533L,538L,543L,553L,568L,573L,593L,603L,633L,643L,658L };
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
public class A131860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131860Inst : IEnumerable<long>
{
public static readonly long[] Value=A131860.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131860.Bytes);
public long this[int i]=>Value[i];

public static A131860Inst Instance=new A131860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131861
{
public static readonly long[] Value={ 1L,3L,9L,11L,16L,17L,18L,19L,21L,23L,24L,25L,26L,27L,29L,31L,33L,35L,41L,43L,48L,49L,50L,51L,53L,55L,56L,57L,58L,59L,61L,63L,81L,83L,89L,91L,113L,115L,121L,123L,129L,131L,137L,139L,144L,145L,146L,147L,149L,151L,152L,153L,154L,155L,157L,159L,161L,163L,169L,171L,176L };
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
public class A131861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131861Inst : IEnumerable<long>
{
public static readonly long[] Value=A131861.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131861.Bytes);
public long this[int i]=>Value[i];

public static A131861Inst Instance=new A131861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131862
{
public static readonly long[] Value={ 2L,3L,6L,7L,18L,19L,22L,23L,32L,33L,34L,35L,36L,37L,38L,39L,42L,43L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,58L,59L,62L,63L,66L,67L,70L,71L,82L,83L,86L,87L,96L,97L,98L,99L,100L,101L,102L,103L,106L,107L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,122L,123L,126L,127L };
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
public class A131862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131862Inst : IEnumerable<long>
{
public static readonly long[] Value=A131862.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131862.Bytes);
public long this[int i]=>Value[i];

public static A131862Inst Instance=new A131862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131863
{
public static readonly long[] Value={ 4L,6L,12L,14L,36L,38L,44L,46L,64L,66L,68L,69L,70L,71L,72L,74L,76L,77L,78L,79L,84L,86L,92L,94L,96L,98L,100L,101L,102L,103L,104L,106L,108L,109L,110L,111L,116L,118L,124L,126L,132L,134L,140L,142L,164L,166L,172L,174L,192L,194L,196L,197L,198L,199L,200L,202L,204L,205L,206L };
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
public class A131863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131863Inst : IEnumerable<long>
{
public static readonly long[] Value=A131863.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131863.Bytes);
public long this[int i]=>Value[i];

public static A131863Inst Instance=new A131863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131880
{
public static readonly long[] Value={ 1L,2L,3L,7L,5L,10L,7L,14L,10L,16L,11L,31L,13L,20L,17L,31L,17L,32L,19L,46L,24L,34L,23L,62L,25L,38L,31L,56L,29L,61L,31L,62L,39L,50L,36L,97L,37L,56L,45L,97L,41L,74L,43L,86L,53L,70L,47L,122L,49L,85L,59L,98L,53L,103L,58L,122L,66L,88L,59L,173L,61L,92L,74L,127L,67L,125L,67L,127L,81L };
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
public class A131880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131880Inst : IEnumerable<long>
{
public static readonly long[] Value=A131880.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131880.Bytes);
public long this[int i]=>Value[i];

public static A131880Inst Instance=new A131880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131881
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,18L,19L,20L,22L,24L,25L,26L,27L,28L,29L,30L,33L,35L,36L,37L,38L,39L,40L,44L,46L,47L,48L,49L,50L,55L,57L,58L,59L,60L,66L,68L,69L,70L,77L,79L,80L,88L,90L,100L,102L,103L,104L,105L,106L,107L,108L,109L,113L,114L };
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
public class A131881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131881Inst : IEnumerable<long>
{
public static readonly long[] Value=A131881.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131881.Bytes);
public long this[int i]=>Value[i];

public static A131881Inst Instance=new A131881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131882
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,16L,22L,32L,42L,58L,80L,102L,134L,176L,218L,276L,334L,414L,516L,618L,752L,886L,1062L,1280L,1498L,1774L,2108L,2442L,2856L,3270L,3786L,4404L,5022L,5774L,6660L,7546L,8608L,9670L,10950L,12448L,13946L,15720L,17494L,19602L,22044L,24486L,27342L };
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
public class A131882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131882Inst : IEnumerable<long>
{
public static readonly long[] Value=A131882.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131882.Bytes);
public long this[int i]=>Value[i];

public static A131882Inst Instance=new A131882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131883
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,4L,4L,4L,4L,4L,4L,6L,6L,6L,6L,6L,6L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,20L,20L,20L,20L,20L,20L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L };
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
public class A131883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131883Inst : IEnumerable<long>
{
public static readonly long[] Value=A131883.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131883.Bytes);
public long this[int i]=>Value[i];

public static A131883Inst Instance=new A131883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131884
{
public static readonly long[] Value={ 276L,306L,396L,552L,564L,660L,696L,780L,828L,888L,966L,996L,1074L,1086L,1098L,1104L,1134L,1218L,1302L,1314L,1320L,1338L,1350L,1356L,1392L,1398L,1410L,1464L,1476L,1488L,1512L,1560L,1572L,1578L,1590L,1632L,1650L,1662L,1674L,1722L,1734L,1758L,1770L,1806L,1836L };
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
public class A131884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131884Inst : IEnumerable<long>
{
public static readonly long[] Value=A131884.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131884.Bytes);
public long this[int i]=>Value[i];

public static A131884Inst Instance=new A131884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131885
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,24L,56L,128L,272L,544L,1056L,2048L,4032L,8064L,16256L,32768L,65792L,131584L,262656L,524288L,1047552L,2095104L,4192256L,8388608L,16781312L,33562624L,67117056L,134217728L,268419072L,536838144L,1073709056L,2147483648L,4295032832L,8590065664L };
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
public class A131885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131885Inst : IEnumerable<long>
{
public static readonly long[] Value=A131885.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131885.Bytes);
public long this[int i]=>Value[i];

public static A131885Inst Instance=new A131885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131886
{
public static readonly long[] Value={ 1L,2L,4L,8L,6L,16L,32L,12L,64L,128L,24L,30L,256L,36L,512L,48L,1024L,2048L,96L,72L,60L,4096L,8192L,192L,16384L,144L,32768L,384L,120L,216L,210L,65536L,131072L,768L,288L,180L,262144L,524288L,1536L,240L,432L,1048576L,576L,2097152L,3072L,4194304L,8388608L };
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
public class A131886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131886Inst : IEnumerable<long>
{
public static readonly long[] Value=A131886.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131886.Bytes);
public long this[int i]=>Value[i];

public static A131886Inst Instance=new A131886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131887
{
public static readonly long[] Value={ 3L,5L,11L,19L,41L,71L,153L,265L,571L,989L,2131L,3691L,7953L,13775L,29681L,51409L,110771L,191861L,413403L,716035L,1542841L,2672279L,5757961L,9973081L,21489003L,37220045L,80198051L,138907099L,299303201L,518408351L,1117014753L,1934726305L,4168755811L,7220496869L };
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
public class A131887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131887Inst : IEnumerable<long>
{
public static readonly long[] Value=A131887.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131887.Bytes);
public long this[int i]=>Value[i];

public static A131887Inst Instance=new A131887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131888
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,6L,2L,8L,3L,12L,4L,30L,5L,16L,5L,24L,7L,36L,9L,60L,11L,210L,15L,32L,7L,48L,12L,72L,16L,120L,21L,180L,26L,420L,36L,2310L,52L,64L,11L,96L,19L,144L,29L,240L,38L,216L,31L,360L,52L,840L,74L,900L,66L,1260L,92L,4620L,135L,30030L,203L };
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
public class A131888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131888Inst : IEnumerable<long>
{
public static readonly long[] Value=A131888.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131888.Bytes);
public long this[int i]=>Value[i];

public static A131888Inst Instance=new A131888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131889
{
public static readonly long[] Value={ 1L,1L,3L,3L,1L,9L,27L,27L,81L,81L,27L,27L,9L,1L,27L,243L,729L,6561L,19683L,19683L,59049L,59049L,19683L,177147L,531441L,531441L,1594323L,1594323L,531441L,531441L,177147L,19683L,59049L,59049L,19683L,19683L,6561L,729L,243L,27L,1L,81L,2187L,19683L,531441L,4782969L };
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
public class A131889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131889Inst : IEnumerable<long>
{
public static readonly long[] Value=A131889.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131889.Bytes);
public long this[int i]=>Value[i];

public static A131889Inst Instance=new A131889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131890
{
public static readonly long[] Value={ 1L,1L,4L,6L,4L,1L,16L,96L,256L,256L,1536L,3456L,3456L,1296L,3456L,3456L,1536L,256L,256L,96L,16L,1L,64L,1536L,16384L,65536L,1572864L,14155776L,56623104L,84934656L,905969664L,3623878656L,6442450944L,4294967296L,17179869184L,25769803776L,17179869184L,4294967296L };
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
public class A131890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131890Inst : IEnumerable<long>
{
public static readonly long[] Value=A131890.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131890.Bytes);
public long this[int i]=>Value[i];

public static A131890Inst Instance=new A131890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131891
{
public static readonly long[] Value={ 1L,1L,5L,10L,10L,5L,1L,25L,250L,1250L,3125L,3125L,31250L,125000L,250000L,250000L,100000L,500000L,1000000L,1000000L,500000L,100000L,250000L,250000L,125000L,31250L,3125L,3125L,1250L,250L,25L,1L,125L,6250L,156250L,1953125L,9765625L,488281250L,9765625000L };
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
public class A131891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131891Inst : IEnumerable<long>
{
public static readonly long[] Value=A131891.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131891.Bytes);
public long this[int i]=>Value[i];

public static A131891Inst Instance=new A131891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131892
{
public static readonly long[] Value={ 1L,1L,6L,15L,20L,15L,6L,1L,36L,540L,4320L,19440L,46656L,46656L,699840L,4374000L,14580000L,27337500L,27337500L,11390625L,91125000L,303750000L,540000000L,540000000L,288000000L,64000000L,288000000L,540000000L,540000000L,303750000L,91125000L,11390625L,27337500L };
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
public class A131892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131892Inst : IEnumerable<long>
{
public static readonly long[] Value=A131892.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131892.Bytes);
public long this[int i]=>Value[i];

public static A131892Inst Instance=new A131892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131893
{
public static readonly long[] Value={ 1L,1L,7L,21L,35L,35L,21L,7L,1L,49L,1029L,12005L,84035L,352947L,823543L,823543L,17294403L,155649627L,778248135L,2334744405L,4202539929L,4202539929L,1801088541L,21012699645L,105063498225L,291843050625L,486405084375L,486405084375L,270225046875L,64339296875L };
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
public class A131893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131893Inst : IEnumerable<long>
{
public static readonly long[] Value=A131893.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131893.Bytes);
public long this[int i]=>Value[i];

public static A131893Inst Instance=new A131893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131894
{
public static readonly long[] Value={ 1L,6L,3L,11L,6L,5L,16L,9L,8L,7L,21L,12L,11L,10L,9L,26L,15L,14L,13L,12L,11L,31L,18L,17L,16L,15L,14L,13L,36L,21L,20L,19L,18L,17L,16L,15L,41L,24L,23L,22L,21L,20L,19L,18L,17L,46L,27L,26L,25L,24L,23L,22L,21L,20L,19L };
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
public class A131894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131894Inst : IEnumerable<long>
{
public static readonly long[] Value=A131894.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131894.Bytes);
public long this[int i]=>Value[i];

public static A131894Inst Instance=new A131894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131895
{
public static readonly long[] Value={ 1L,9L,22L,40L,63L,91L,124L,162L,205L,253L,306L,364L,427L,495L,568L,646L,729L,817L,910L,1008L,1111L,1219L,1332L,1450L,1573L,1701L,1834L,1972L,2115L,2263L,2416L,2574L,2737L,2905L,3078L,3256L,3439L,3627L,3820L,4018L,4221L,4429L,4642L,4860L,5083L,5311L,5544L };
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
public class A131895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131895Inst : IEnumerable<long>
{
public static readonly long[] Value=A131895.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131895.Bytes);
public long this[int i]=>Value[i];

public static A131895Inst Instance=new A131895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132008
{
public static readonly BigInteger[] Value={ 1L,3L,14L,98L,954L,12242L,199156L,3988248L,96094356L,2735515916L,90647239704L,3453539346232L,149695821098056L,7316061672718152L,400012182207670288L,BigInteger.Parse("24301065118906010048"),BigInteger.Parse("1630456684740565109904"),BigInteger.Parse("120168318315515773499952") };
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
public class A132008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132008Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132008.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132008.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132008Inst Instance=new A132008Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132009
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,8L,8L,15L,13L,12L,12L,17L,14L,16L,18L,31L,18L,26L,20L,24L,24L,24L,24L,35L,31L,28L,40L,32L,30L,37L,32L,63L,36L,36L,40L,53L,38L,40L,42L,49L,42L,48L,44L,48L,56L,48L,48L,71L,57L,62L,54L,56L,54L,80L,60L,65L,60L,60L,60L,74L,62L,64L,73L,127L,70L,72L,68L,72L,72L,81L,72L,107L };
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
public class A132009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132009Inst : IEnumerable<long>
{
public static readonly long[] Value=A132009.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132009.Bytes);
public long this[int i]=>Value[i];

public static A132009Inst Instance=new A132009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132010
{
public static readonly long[] Value={ 14L,178L,1641L,7029L,91547L,1097616L,13625900L,65706895L,957913707L,12593013388L };
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
public class A132010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132010Inst : IEnumerable<long>
{
public static readonly long[] Value=A132010.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132010.Bytes);
public long this[int i]=>Value[i];

public static A132010Inst Instance=new A132010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132011
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,5L,5L,5L,6L,7L,7L,7L,8L,9L,9L,9L,10L,11L,12L,12L,13L,14L,15L,15L,16L,17L,18L,18L,19L,20L,21L,22L,24L,25L,26L,27L,29L,30L,31L,32L,34L,35L,36L,37L,40L,42L,43L,44L,47L,49L,50L,51L,54L,56L,57L,58L,61L,64L,66L,67L,70L,73L,75L,76L,79L,82L,84L,85L,88L,91L };
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
public class A132011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132011Inst : IEnumerable<long>
{
public static readonly long[] Value=A132011.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132011.Bytes);
public long this[int i]=>Value[i];

public static A132011Inst Instance=new A132011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132012
{
public static readonly long[] Value={ 3L,5L,7L,15L,17L,19L,25L,35L,51L,69L,81L,87L,123L,129L,141L,159L,177L,255L,267L,275L,309L,321L,339L,393L,447L,489L,501L,519L,537L,705L,795L,807L,849L,879L,1029L,1245L,1257L,1605L,1671L,1689L,1707L,1761L,1779L,1797L,1851L,1923L,1929L,1941L,1959L,1977L,2505L,2595L,2685L };
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
public class A132012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132012Inst : IEnumerable<long>
{
public static readonly long[] Value=A132012.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132012.Bytes);
public long this[int i]=>Value[i];

public static A132012Inst Instance=new A132012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132013
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-2L,1L,0L,0L,-3L,1L,0L,0L,0L,-4L,1L,0L,0L,0L,0L,-5L,1L,0L,0L,0L,0L,0L,-6L,1L,0L,0L,0L,0L,0L,0L,-7L,1L,0L,0L,0L,0L,0L,0L,0L,-8L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-9L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-10L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-11L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-12L,1L };
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
public class A132013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132013Inst : IEnumerable<long>
{
public static readonly long[] Value=A132013.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132013.Bytes);
public long this[int i]=>Value[i];

public static A132013Inst Instance=new A132013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132014
{
public static readonly long[] Value={ 1L,-2L,1L,2L,-4L,1L,0L,6L,-6L,1L,0L,0L,12L,-8L,1L,0L,0L,0L,20L,-10L,1L,0L,0L,0L,0L,30L,-12L,1L,0L,0L,0L,0L,0L,42L,-14L,1L,0L,0L,0L,0L,0L,0L,56L,-16L,1L,0L,0L,0L,0L,0L,0L,0L,72L,-18L,1L,0L,0L,0L,0L,0L,0L,0L,0L,90L,-20L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,110L,-22L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,132L,-24L,1L };
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
public class A132014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132014Inst : IEnumerable<long>
{
public static readonly long[] Value=A132014.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132014.Bytes);
public long this[int i]=>Value[i];

public static A132014Inst Instance=new A132014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132015
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,3L,4L,4L,4L,4L,4L,5L,6L,6L,6L,6L,6L,6L,6L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,10L,11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,13L,14L,15L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,17L,18L,19L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,21L,22L,23L,24L,24L,24L,24L,24L };
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
public class A132015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132015Inst : IEnumerable<long>
{
public static readonly long[] Value=A132015.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132015.Bytes);
public long this[int i]=>Value[i];

public static A132015Inst Instance=new A132015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132016
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,51L,52L,53L,54L,55L,57L,58L,59L,60L,61L,63L,64L,65L,66L,67L,69L,70L,71L,72L,73L,75L,77L,78L,79L,80L,81L };
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
public class A132016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132016Inst : IEnumerable<long>
{
public static readonly long[] Value=A132016.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132016.Bytes);
public long this[int i]=>Value[i];

public static A132016Inst Instance=new A132016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132017
{
public static readonly long[] Value={ 1L,3L,7L,8L,13L,14L,21L,22L,31L,32L,33L,34L,43L,44L,45L,46L,57L,58L,59L,60L,73L,74L,75L,76L,91L,92L,93L,94L,111L,112L,113L,114L,115L,133L,134L,135L,136L,137L,157L,158L,159L,160L,161L,183L,184L,185L,186L,187L,211L,212L,213L,214L,215L,241L,242L,243L,244L,245L,273L,274L };
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
public class A132017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132017Inst : IEnumerable<long>
{
public static readonly long[] Value=A132017.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132017.Bytes);
public long this[int i]=>Value[i];

public static A132017Inst Instance=new A132017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132018
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,10L,11L,13L,14L,16L,18L,19L,21L,23L,25L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,47L,49L,51L,53L,55L,58L,60L,62L,65L,67L,70L,72L,74L,77L,79L,82L,84L,87L,90L,92L,95L,97L,100L,103L,105L,108L,111L,114L,116L,119L,122L,125L,128L,131L,134L,136L };
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
public class A132018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132018Inst : IEnumerable<long>
{
public static readonly long[] Value=A132018.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132018.Bytes);
public long this[int i]=>Value[i];

public static A132018Inst Instance=new A132018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132019
{
public static readonly long[] Value={ 3L,8L,2L,6L,6L,3L,1L,9L,6L,6L,7L,9L,0L,3L,3L,0L,2L,3L,2L,8L,8L,9L,5L,5L,0L,3L,3L,5L,3L,3L,1L,9L,1L,3L,2L,2L,7L,9L,5L,3L,7L,7L,1L,9L,7L,3L,1L,2L,7L,6L,7L,1L,1L,8L,0L,5L,5L,1L,4L,9L,5L,3L,5L,4L,6L,7L,8L,6L,8L,7L,5L,2L,4L,4L,0L,8L,2L,7L,5L,9L,9L,2L,7L,0L,3L,5L,3L,6L,4L,7L,1L,8L,8L,7L,4L,2L,5L,1L,6L,5L,6L,4L,6L };
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
public class A132019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132019Inst : IEnumerable<long>
{
public static readonly long[] Value=A132019.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132019.Bytes);
public long this[int i]=>Value[i];

public static A132019Inst Instance=new A132019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132020
{
public static readonly long[] Value={ 4L,1L,9L,4L,2L,2L,4L,4L,1L,7L,9L,5L,1L,0L,7L,5L,9L,7L,7L,0L,9L,9L,5L,6L,1L,0L,7L,7L,0L,2L,9L,7L,4L,2L,5L,2L,2L,3L,3L,9L,5L,3L,2L,3L,4L,3L,9L,2L,6L,6L,6L,7L,4L,9L,0L,8L,0L,4L,4L,9L,9L,1L,6L,6L,3L,1L,7L,7L,2L,0L,5L,0L,8L,7L,2L,7L,0L,9L,1L,9L,3L,9L,1L,0L,0L,2L,3L,2L,4L,5L,4L,7L,4L,2L,3L,8L,1L,9L,5L,5L,0L,2L,8L,5L,8L };
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
public class A132020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132020Inst : IEnumerable<long>
{
public static readonly long[] Value=A132020.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A132020.Bytes);
public long this[int i]=>Value[i];

public static A132020Inst Instance=new A132020Inst();

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