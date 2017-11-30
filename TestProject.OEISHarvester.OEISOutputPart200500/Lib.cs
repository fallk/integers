using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A270865
{
public static readonly long[] Value={ 5L,19L,29L,31L,37L,47L,53L,79L,397L,409L,599L,787L,1229L,1381L,1439L,1993L,2087L,2767L,4003L,4159L,4931L,5791L,5981L,8117L,9293L,9349L,9833L,10939L,10979L,11213L,12553L,12907L,14557L,16361L,18047L,21089L,21557L,21577L,25903L,26339L,28439L,33547L,56813L,57667L };
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
public class A270865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270865Inst : IEnumerable<long>
{
public static readonly long[] Value=A270865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270865.Bytes);
public long this[int i]=>Value[i];

public static A270865Inst Instance=new A270865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270866
{
public static readonly long[] Value={ 5808L,9911L,34317L,113147L,750735L,1600573L,5546909L,9380741L,23316851L,71271069L,98488755L,233043067L,384847485L,485930975L,751588475L,1356370173L,2299880351L,2710679045L,4306310927L,5734323819L,6578172579L,9721485395L,12413061671L,17537591045L,26866372821L };
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
public class A270866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270866Inst : IEnumerable<long>
{
public static readonly long[] Value=A270866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270866.Bytes);
public long this[int i]=>Value[i];

public static A270866Inst Instance=new A270866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270867
{
public static readonly long[] Value={ 1L,8L,25L,58L,113L,196L,313L,470L,673L,928L,1241L,1618L,2065L,2588L,3193L,3886L,4673L,5560L,6553L,7658L,8881L,10228L,11705L,13318L,15073L,16976L,19033L,21250L,23633L,26188L,28921L,31838L,34945L,38248L,41753L,45466L,49393L,53540L,57913L,62518L,67361L,72448L };
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
public class A270867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270867Inst : IEnumerable<long>
{
public static readonly long[] Value=A270867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270867.Bytes);
public long this[int i]=>Value[i];

public static A270867Inst Instance=new A270867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270916
{
public static readonly BigInteger[] Value={ 1L,2L,3L,5L,65L,6529L,136091233L,41625259047416909L,BigInteger.Parse("2189507051227161558033650829868135"),BigInteger.Parse("75931290362065676573711484986356332365619562746656079489987281066955") };
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
public class A270916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270916Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270916.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270916.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270916Inst Instance=new A270916Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270917
{
public static readonly BigInteger[] Value={ 1L,1L,4L,35L,457L,12421L,678101L,69540142L,13730026114L,5551573311817L,4379029522335786L,6705866900012021577L,BigInteger.Parse("21038900445652125741759"),BigInteger.Parse("131183458646068931932668114"),BigInteger.Parse("1603688863449847489871671547959"),BigInteger.Parse("40294004792352613617780682256221711") };
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
public class A270917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270917Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270917.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270917.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270917Inst Instance=new A270917Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270918
{
public static readonly BigInteger[] Value={ 1L,2L,19L,580L,38165L,4395456L,786588243L,202384723528L,70886845397481L,32458256583753952L,BigInteger.Parse("18832730699014127291"),BigInteger.Parse("13507852690353224821652"),BigInteger.Parse("11738630472138500287398379"),BigInteger.Parse("12155701820213424461220851360"),BigInteger.Parse("14790850878997102285050287114419") };
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
public class A270918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270918Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270918.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270918.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270918Inst Instance=new A270918Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270919
{
public static readonly long[] Value={ 1L,2L,12L,80L,552L,3912L,28224L,206208L,1520784L,11297546L,84413912L,633713808L,4776117216L,36115518376L,273868321536L,2081866609920L,15859616674336L,121046064563376L,925411686479820L,7085465166635440L,54323193841192752L,416993869451825424L,3204447137019290944L };
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
public class A270919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270919Inst : IEnumerable<long>
{
public static readonly long[] Value=A270919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270919.Bytes);
public long this[int i]=>Value[i];

public static A270919Inst Instance=new A270919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270920
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,4L,2L,2L,5L,5L,3L,2L,3L,4L,4L,3L,4L,6L,3L,2L,4L,3L,3L,5L,5L,3L,3L,4L,5L,6L,7L,2L,2L,4L,6L,9L,9L,7L,6L,3L,5L,4L,4L,7L,8L,6L,3L,5L,7L,8L,7L,7L,6L,6L,5L,4L,5L,7L,7L,5L,5L,6L,9L,5L,3L,5L,4L,9L,11L,10L,6L,2L,6L,4L,3L,6L,7L,5L,5L };
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
public class A270920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270920Inst : IEnumerable<long>
{
public static readonly long[] Value=A270920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270920.Bytes);
public long this[int i]=>Value[i];

public static A270920Inst Instance=new A270920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270921
{
public static readonly long[] Value={ 1L,2L,3L,3L,2L,1L,1L,3L,3L,3L,4L,3L,1L,1L,1L,2L,5L,3L,3L,3L,3L,4L,3L,4L,6L,3L,6L,4L,3L,4L,2L,3L,3L,2L,2L,3L,2L,2L,4L,3L,3L,5L,9L,6L,3L,4L,2L,2L,2L,6L,3L,3L,2L,2L,3L,2L,2L,4L,5L,4L,5L,3L,2L,2L,6L,7L,4L,4L,2L,2L,4L,3L,3L,3L,2L,3L,4L,4L,4L,2L,5L };
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
public class A270921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270921Inst : IEnumerable<long>
{
public static readonly long[] Value=A270921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270921.Bytes);
public long this[int i]=>Value[i];

public static A270921Inst Instance=new A270921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270922
{
public static readonly long[] Value={ 1L,1L,5L,28L,141L,751L,4064L,22198L,122381L,679375L,3792155L,21263331L,119679000L,675763232L,3826165838L,21715370653L,123502583565L,703694143160L,4016079632039L,22953901314649L,131366012754691L,752709483123304L,4317601694413683L,24790635783551008L };
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
public class A270922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270922Inst : IEnumerable<long>
{
public static readonly long[] Value=A270922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270922.Bytes);
public long this[int i]=>Value[i];

public static A270922Inst Instance=new A270922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270923
{
public static readonly BigInteger[] Value={ 1L,2L,10L,88L,1414L,46648L,3026028L,373615284L,92794268694L,46265940243794L,44694344296430280L,BigInteger.Parse("86689242777435107120"),BigInteger.Parse("340600515192402995860548"),BigInteger.Parse("2624923513793602103874986688"),BigInteger.Parse("40749869155795866122979193705136"),BigInteger.Parse("1290021269710020392957588463834452744") };
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
public class A270923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270923Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270923.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270923.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270923Inst Instance=new A270923Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270924
{
public static readonly ulong[] Value={ 1L,2L,16L,128L,1056L,8952L,77200L,673948L,5937792L,52689170L,470210016L,4215834328L,37945215552L,342650763392L,3102866408560L,28166168335128L,256220106742272L,2335126111557564L,21317113277158336L,194890649121580880L,1784158030393621056L,16353089279998330456UL };
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
public class A270924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270924Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A270924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270924.Bytes);
public ulong this[int i]=>Value[i];

public static A270924Inst Instance=new A270924Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270925
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,4L,6L,10L,16L,26L,43L,69L,112L,181L,294L,475L,768L,1243L,2012L,3255L,5267L,8523L,13790L,22313L,36103L,58416L,94519L,152934L,247453L,400387L,647841L,1048228L,1696069L,2744297L,4440365L,7184662L,11625027L,18809689L,30434716L,49244405L,79679122L,128923527L,208602649L,337526177L };
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
public class A270925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270925Inst : IEnumerable<long>
{
public static readonly long[] Value=A270925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270925.Bytes);
public long this[int i]=>Value[i];

public static A270925Inst Instance=new A270925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270926
{
public static readonly long[] Value={ 5L,10L,15L,16L,18L,20L,25L,30L,37L,40L,50L,51L,52L,55L,58L,60L,61L,70L,73L,78L,80L,81L,85L,87L,89L,90L,98L,100L,101L,104L,106L,109L,110L,111L,122L,125L,128L,145L,146L,148L,149L,150L,159L,160L,162L,164L,165L,168L,169L,174L,176L,180L,181L,192L,195L,198L,200L,202L,208L,212L,220L,221L,222L };
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
public class A270926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270926Inst : IEnumerable<long>
{
public static readonly long[] Value=A270926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270926.Bytes);
public long this[int i]=>Value[i];

public static A270926Inst Instance=new A270926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270927
{
public static readonly long[] Value={ 1L,1L,2L,1L,18L,1L,6L,3L,6L,7L,46L,5L,10L,3L,8L,1L,16L,2L,28L,1L,2L,7L,16L,1L,24L,12L,10L,1L,10L,2L,6L,7L,26L,1L,12L,3L,6L,3L,8L,16L,10L,3L,22L,16L,2L,1L,6L,1L,36L,3L,6L,3L,16L,1L,18L,1L,8L,12L,16L,10L,12L,31L,2L,10L,22L,2L,36L,21L,40L,6L,12L,18L,6L,1L,6L,7L,10L,2L,18L,1L,2L,1L,22L,2L,12L,18L,6L,1L,18L,1L,58L,3L,12L,7L,24L,2L,16L,3L,16L,6L,6L,7L,46L,25L,2L,1L,12L,7L,18L,12L,46L,3L,12L,5L,10L,3L,48L,1L,16L,2L };
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
public class A270927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270927Inst : IEnumerable<long>
{
public static readonly long[] Value=A270927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270927.Bytes);
public long this[int i]=>Value[i];

public static A270927Inst Instance=new A270927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270928
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,2L,1L,2L,2L,1L,2L,2L,1L,1L,3L,2L,1L,2L,1L,3L,3L,2L,2L,2L,2L,2L,2L,1L,3L,4L,2L,2L,2L,2L,1L,4L,2L,3L,2L,2L,3L,2L,2L,2L,4L,2L,3L,3L,1L,2L,5L,1L,2L,3L,3L,4L,3L,3L,1L,5L,1L,3L,2L,3L,3L,5L,2L,2L,4L };
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
public class A270928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270928Inst : IEnumerable<long>
{
public static readonly long[] Value=A270928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270928.Bytes);
public long this[int i]=>Value[i];

public static A270928Inst Instance=new A270928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270929
{
public static readonly long[] Value={ 1L,2L,3L,4L,15L,20L,24L,32L,38L,40L,63L,93L,104L,194L,208L,514L,535L,600L,928L,1300L,1485L,1780L,2058L,3060L,3356L,3721L,6662L,11552L,15482L,23000L,27375L,34748L,57219L,61251L,85221L,99656L };
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
public class A270929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270929Inst : IEnumerable<long>
{
public static readonly long[] Value=A270929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270929.Bytes);
public long this[int i]=>Value[i];

public static A270929Inst Instance=new A270929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270930
{
public static readonly long[] Value={ 1L,5L,5L,37L,8L,97L,25L,185L,33L,329L,48L,461L,64L,641L,117L,817L,109L,1133L,157L,1365L,161L,1641L,225L,1881L,256L,2357L,333L,2753L,421L,3189L,445L,3473L,497L,4049L,505L,4641L,541L,5097L,684L,5661L,716L,6385L,776L,6937L,964L,7621L,976L,8217L,1072L,8901L,1096L };
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
public class A270930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270930Inst : IEnumerable<long>
{
public static readonly long[] Value=A270930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270930.Bytes);
public long this[int i]=>Value[i];

public static A270930Inst Instance=new A270930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270931
{
public static readonly long[] Value={ 1L,5L,37L,185L,817L,3473L,14437L,59629L,239405L,962201L,3852577L,15427713L,61743929L,247013121L,988192245L,3952817017L };
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
public class A270931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270931Inst : IEnumerable<long>
{
public static readonly long[] Value=A270931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270931.Bytes);
public long this[int i]=>Value[i];

public static A270931Inst Instance=new A270931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270996
{
public static readonly long[] Value={ 2L,1L,3L,10L,17L,7L,101L,149L,151L,47L,246L,51L,26L,97L,8474L,1685L,8479L,727L,1861L,241L,843L,22026L,849L,3178L,2526L,10826L,30247L,22019L,217077L,190453L,813251L,55779L,183553L,5045L,580847L,826823L };
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
public class A270996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270996Inst : IEnumerable<long>
{
public static readonly long[] Value=A270996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270996.Bytes);
public long this[int i]=>Value[i];

public static A270996Inst Instance=new A270996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270997
{
public static readonly long[] Value={ 1L,3L,10L,17L,23L,29L,33L,43L,53L,61L,79L,101L,103L,107L,113L,127L,131L,139L,157L,173L,179L,181L,191L,199L,211L,233L,251L,257L,263L,269L,277L,283L,311L,313L,337L,347L,367L,373L,385L,389L,419L,433L,439L,443L,467L,491L,503L,521L,523L,547L,561L,563L,569L,571L,599L,601L,607L,641L,647L,649L,653L,659L };
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
public class A270997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270997Inst : IEnumerable<long>
{
public static readonly long[] Value=A270997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270997.Bytes);
public long this[int i]=>Value[i];

public static A270997Inst Instance=new A270997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270998
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,11L,13L,17L,19L,23L,101L,103L,107L,109L,113L,1481L,1483L,1487L,1489L,1493L,16061L,16063L,16067L,16069L,16073L,19421L,19423L,19427L,19429L,19433L,21011L,21013L,21017L,21019L,21023L,22271L,22273L,22277L,22279L,22283L,43781L,43783L,43787L,43789L,43793L };
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
public class A270998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270998Inst : IEnumerable<long>
{
public static readonly long[] Value=A270998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270998.Bytes);
public long this[int i]=>Value[i];

public static A270998Inst Instance=new A270998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270999
{
public static readonly long[] Value={ 7L,11L,13L,17L,19L,97L,101L,103L,107L,109L,1867L,1871L,1873L,1877L,1879L,3457L,3461L,3463L,3467L,3469L,5647L,5651L,5653L,5657L,5659L,15727L,15731L,15733L,15737L,15739L,16057L,16061L,16063L,16067L,16069L,19417L,19421L,19423L,19427L,19429L,43777L,43781L,43783L,43787L,43789L };
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
public class A270999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270999Inst : IEnumerable<long>
{
public static readonly long[] Value=A270999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270999.Bytes);
public long this[int i]=>Value[i];

public static A270999Inst Instance=new A270999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271000
{
public static readonly long[] Value={ 7L,11L,13L,17L,19L,23L,97L,101L,103L,107L,109L,113L,16057L,16061L,16063L,16067L,16069L,16073L,19417L,19421L,19423L,19427L,19429L,19433L,43777L,43781L,43783L,43787L,43789L,43793L,1091257L,1091261L,1091263L,1091267L,1091269L,1091273L,1615837L,1615841L,1615843L,1615847L,1615849L,1615853L };
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
public class A271000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271000Inst : IEnumerable<long>
{
public static readonly long[] Value=A271000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271000.Bytes);
public long this[int i]=>Value[i];

public static A271000Inst Instance=new A271000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271001
{
public static readonly long[] Value={ 1L,5L,41L,185L,829L,3465L,14277L,58641L,237081L,954237L,3823321L,15327541L,61324345L,245348113L,981538261L,3926445273L };
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
public class A271001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271001Inst : IEnumerable<long>
{
public static readonly long[] Value=A271001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271001.Bytes);
public long this[int i]=>Value[i];

public static A271001Inst Instance=new A271001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271002
{
public static readonly long[] Value={ 1L,6L,15L,56L,77L,178L,227L,412L,473L,782L,879L,1328L,1453L,2086L,2287L,3116L,3293L,4410L,4615L,6060L,6241L,7922L,8307L,10232L,10669L,13006L,13471L,16188L,16709L,19850L,20615L,24080L,24809L,28926L,29599L,34296L,35057L,40174L,41187L,46800L,47733L,54070L,55203L };
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
public class A271002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271002Inst : IEnumerable<long>
{
public static readonly long[] Value=A271002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271002.Bytes);
public long this[int i]=>Value[i];

public static A271002Inst Instance=new A271002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271003
{
public static readonly long[] Value={ 4L,4L,32L,-20L,80L,-52L,136L,-124L,248L,-212L,352L,-324L,508L,-432L,628L,-652L,940L,-912L,1240L,-1264L,1500L,-1296L,1540L,-1488L,1900L,-1872L,2252L,-2196L,2620L,-2376L,2700L,-2736L,3388L,-3444L,4024L,-3936L,4356L,-4104L,4600L,-4680L,5404L,-5204L,5664L,-5452L };
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
public class A271003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271003Inst : IEnumerable<long>
{
public static readonly long[] Value=A271003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271003.Bytes);
public long this[int i]=>Value[i];

public static A271003Inst Instance=new A271003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271004
{
public static readonly long[] Value={ 1L,8L,4L,44L,13L,112L,25L,208L,37L,340L,49L,504L,61L,700L,73L,928L,85L,1188L,97L,1480L,109L,1804L,121L,2160L,133L,2548L,145L,2968L,157L,3420L,169L,3904L,181L,4420L,193L,4968L,205L,5548L,217L,6160L,229L,6804L,241L,7480L,253L,8188L,265L,8928L,277L,9700L,289L };
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
public class A271004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271004Inst : IEnumerable<long>
{
public static readonly long[] Value=A271004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271004.Bytes);
public long this[int i]=>Value[i];

public static A271004Inst Instance=new A271004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271005
{
public static readonly long[] Value={ 1L,8L,44L,208L,928L,3904L,16000L,64768L,260608L,1045504L,4188160L,16764928L,67084288L,268386304L,1073643520L,4294770688L };
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
public class A271005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271005Inst : IEnumerable<long>
{
public static readonly long[] Value=A271005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271005.Bytes);
public long this[int i]=>Value[i];

public static A271005Inst Instance=new A271005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271006
{
public static readonly long[] Value={ 1L,9L,13L,57L,70L,182L,207L,415L,452L,792L,841L,1345L,1406L,2106L,2179L,3107L,3192L,4380L,4477L,5957L,6066L,7870L,7991L,10151L,10284L,12832L,12977L,15945L,16102L,19522L,19691L,23595L,23776L,28196L,28389L,33357L,33562L,39110L,39327L,45487L,45716L,52520L,52761L };
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
public class A271006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271006Inst : IEnumerable<long>
{
public static readonly long[] Value=A271006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271006.Bytes);
public long this[int i]=>Value[i];

public static A271006Inst Instance=new A271006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271007
{
public static readonly long[] Value={ 7L,-4L,40L,-31L,99L,-87L,183L,-171L,303L,-291L,455L,-443L,639L,-627L,855L,-843L,1103L,-1091L,1383L,-1371L,1695L,-1683L,2039L,-2027L,2415L,-2403L,2823L,-2811L,3263L,-3251L,3735L,-3723L,4239L,-4227L,4775L,-4763L,5343L,-5331L,5943L,-5931L,6575L,-6563L,7239L };
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
public class A271007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271007Inst : IEnumerable<long>
{
public static readonly long[] Value=A271007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271007.Bytes);
public long this[int i]=>Value[i];

public static A271007Inst Instance=new A271007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271008
{
public static readonly long[] Value={ 1L,5L,8L,24L,28L,48L,36L,108L,68L,132L,136L,224L,172L,276L,276L,344L,308L,496L,408L,548L,560L,652L,604L,860L,688L,1032L,824L,1144L,972L,1256L,1224L,1432L,1356L,1696L,1392L,1836L,1716L,2016L,1828L,2144L,2152L,2496L,2080L,2632L,2556L,2948L,2708L,3248L,3088L };
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
public class A271008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271008Inst : IEnumerable<long>
{
public static readonly long[] Value=A271008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271008.Bytes);
public long this[int i]=>Value[i];

public static A271008Inst Instance=new A271008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271009
{
public static readonly long[] Value={ 1L,5L,24L,108L,344L,1432L,5732L,21764L,86908L,349544L,1391832L,5524304L,22125204L,88465688L,353818732L,1415067460L };
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
public class A271009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271009Inst : IEnumerable<long>
{
public static readonly long[] Value=A271009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271009.Bytes);
public long this[int i]=>Value[i];

public static A271009Inst Instance=new A271009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271010
{
public static readonly long[] Value={ 1L,6L,14L,38L,66L,114L,150L,258L,326L,458L,594L,818L,990L,1266L,1542L,1886L,2194L,2690L,3098L,3646L,4206L,4858L,5462L,6322L,7010L,8042L,8866L,10010L,10982L,12238L,13462L,14894L,16250L,17946L,19338L,21174L,22890L,24906L,26734L,28878L,31030L,33526L,35606L };
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
public class A271010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271010Inst : IEnumerable<long>
{
public static readonly long[] Value=A271010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271010.Bytes);
public long this[int i]=>Value[i];

public static A271010Inst Instance=new A271010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271011
{
public static readonly long[] Value={ 4L,3L,16L,4L,20L,-12L,72L,-40L,64L,4L,88L,-52L,104L,0L,68L,-36L,188L,-88L,140L,12L,92L,-48L,256L,-172L,344L,-208L,320L,-172L,284L,-32L,208L,-76L,340L,-304L,444L,-120L,300L,-188L,316L,8L,344L,-416L,552L,-76L,392L,-240L,540L,-160L,328L,-64L,244L,-28L,304L,-52L };
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
public class A271011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271011Inst : IEnumerable<long>
{
public static readonly long[] Value=A271011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271011.Bytes);
public long this[int i]=>Value[i];

public static A271011Inst Instance=new A271011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271268
{
public static readonly long[] Value={ 8L,88L,1664L,17144L,17112L,1214L,88L,1664L,17144L,17112L,1214L,88L,1664L,17144L,17112L,1214L,88L,1664L,17144L,17112L,1214L,88L,1664L,17144L,17112L,1214L,88L,1664L,17144L,17112L,1214L,88L,1664L,17144L,17112L,1214L,88L,1664L,17144L,17112L,1214L,88L,1664L,17144L };
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
public class A271268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271268Inst : IEnumerable<long>
{
public static readonly long[] Value=A271268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271268.Bytes);
public long this[int i]=>Value[i];

public static A271268Inst Instance=new A271268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271269
{
public static readonly long[] Value={ 1L,2L,3L,8L,24L,49L,57L,74L,104L,131L,144L,162L,182L,246L,302L,352L,557L,581L,589L,704L,939L,1181L,1937L,2157L,4463L,6013L,7266L,8504L,8691L,16129L,20108L,40677L,74234L };
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
public class A271269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271269Inst : IEnumerable<long>
{
public static readonly long[] Value=A271269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271269.Bytes);
public long this[int i]=>Value[i];

public static A271269Inst Instance=new A271269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271270
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,43L,145L,536L,2157L,9371L,43630L,216397L,1137703L,6313675L,36848992L,225464838L,1442216870L,9620746697L,66781675113L,481413175433L,3597627996006L,27825925290597L,222422033403527L,1834910286704787L,15603508329713182L,136616625732498989L };
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
public class A271270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271270Inst : IEnumerable<long>
{
public static readonly long[] Value=A271270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271270.Bytes);
public long this[int i]=>Value[i];

public static A271270Inst Instance=new A271270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271271
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,9L,58L,341L,1983L,11776L,72345L,462173L,3075894L,21330762L,154050330L,1157493707L,9037925277L,73244123107L,615295131046L,5351329029624L,48126530239366L,447043890866154L,4284293705043796L,42317095568379559L,430355360965092107L,4501973706497500364L };
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
public class A271271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271271Inst : IEnumerable<long>
{
public static readonly long[] Value=A271271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271271.Bytes);
public long this[int i]=>Value[i];

public static A271271Inst Instance=new A271271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271272
{
public static readonly long[] Value={ 1L,1L,2L,5L,13L,36L,110L,374L,1404L,5750L,25419L,120325L,606210L,3234618L,18202851L,107647893L,666903189L,4316424771L,29116689197L,204259773724L,1487336089532L,11221857590608L,87591879539120L,706286859093554L,5875489876724901L,50364717424939105L,444367708336858660L };
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
public class A271272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271272Inst : IEnumerable<long>
{
public static readonly long[] Value=A271272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271272.Bytes);
public long this[int i]=>Value[i];

public static A271272Inst Instance=new A271272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271273
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,16L,93L,503L,2736L,15397L,90556L,558245L,3607387L,24409819L,172696471L,1275310652L,9813238958L,78548445033L,652960116962L,5628482431333L,50236822145840L,463647958566143L,4419123858908203L,43445718995990792L,440083379418080388L,4588225614805060248L };
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
public class A271273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271273Inst : IEnumerable<long>
{
public static readonly long[] Value=A271273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271273.Bytes);
public long this[int i]=>Value[i];

public static A271273Inst Instance=new A271273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271274
{
public static readonly long[] Value={ 1L,4L,40L,200L,856L,3568L,14716L,59624L,239688L,962852L,3852204L,15419816L,61667416L,246662736L,986584576L,3946302560L };
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
public class A271274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271274Inst : IEnumerable<long>
{
public static readonly long[] Value=A271274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271274.Bytes);
public long this[int i]=>Value[i];

public static A271274Inst Instance=new A271274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271275
{
public static readonly long[] Value={ 1L,5L,10L,50L,59L,159L,164L,364L,381L,701L,738L,1210L,1227L,1903L,1964L,2820L,2869L,4017L,4094L,5466L,5535L,7219L,7320L,9336L,9461L,11817L,11958L,14674L,14843L,17963L,18156L,21724L,21925L,26057L,26258L,30882L,31115L,36267L,36524L,42252L,42533L,48861L,49134L };
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
public class A271275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271275Inst : IEnumerable<long>
{
public static readonly long[] Value=A271275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271275.Bytes);
public long this[int i]=>Value[i];

public static A271275Inst Instance=new A271275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271276
{
public static readonly long[] Value={ 3L,1L,35L,-31L,91L,-95L,195L,-183L,303L,-283L,435L,-455L,659L,-615L,795L,-807L,1099L,-1071L,1295L,-1303L,1615L,-1583L,1915L,-1891L,2231L,-2215L,2575L,-2547L,2951L,-2927L,3375L,-3367L,3931L,-3931L,4423L,-4391L,4919L,-4895L,5471L,-5447L,6047L,-6055L,6711L };
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
public class A271276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271276Inst : IEnumerable<long>
{
public static readonly long[] Value=A271276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271276.Bytes);
public long this[int i]=>Value[i];

public static A271276Inst Instance=new A271276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271277
{
public static readonly long[] Value={ 1L,5L,5L,40L,13L,100L,21L,193L,28L,325L,16L,493L,44L,661L,80L,841L,80L,1157L,44L,1421L,92L,1673L,120L,2021L,148L,2397L,88L,2833L,224L,3177L,232L,3681L,152L,4173L,380L,4521L,448L,5109L,292L,5905L,236L,6425L,480L,6877L,540L,7737L,304L,8473L,316L,9193L,521L };
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
public class A271277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271277Inst : IEnumerable<long>
{
public static readonly long[] Value=A271277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271277.Bytes);
public long this[int i]=>Value[i];

public static A271277Inst Instance=new A271277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271278
{
public static readonly long[] Value={ 1L,5L,40L,193L,841L,3681L,14973L,60789L,243436L,973641L,3881340L,15520816L,62025368L,248008489L,991871680L,3967177220L };
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
public class A271278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271278Inst : IEnumerable<long>
{
public static readonly long[] Value=A271278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271278.Bytes);
public long this[int i]=>Value[i];

public static A271278Inst Instance=new A271278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271279
{
public static readonly long[] Value={ 1L,6L,11L,51L,64L,164L,185L,378L,406L,731L,747L,1240L,1284L,1945L,2025L,2866L,2946L,4103L,4147L,5568L,5660L,7333L,7453L,9474L,9622L,12019L,12107L,14940L,15164L,18341L,18573L,22254L,22406L,26579L,26959L,31480L,31928L,37037L,37329L,43234L,43470L,49895L,50375L };
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
public class A271279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271279Inst : IEnumerable<long>
{
public static readonly long[] Value=A271279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271279.Bytes);
public long this[int i]=>Value[i];

public static A271279Inst Instance=new A271279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271280
{
public static readonly long[] Value={ 4L,0L,35L,-27L,87L,-79L,172L,-165L,297L,-309L,477L,-449L,617L,-581L,761L,-761L,1077L,-1113L,1377L,-1329L,1581L,-1553L,1901L,-1873L,2249L,-2309L,2745L,-2609L,2953L,-2945L,3449L,-3529L,4021L,-3793L,4141L,-4073L,4661L,-4817L,5613L,-5669L,6189L,-5945L,6397L };
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
public class A271280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271280Inst : IEnumerable<long>
{
public static readonly long[] Value=A271280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271280.Bytes);
public long this[int i]=>Value[i];

public static A271280Inst Instance=new A271280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271281
{
public static readonly long[] Value={ 1L,5L,8L,21L,20L,32L,44L,69L,60L,104L,72L,104L,121L,160L,181L,177L,232L,249L,288L,248L,309L,368L,400L,476L,500L,500L,644L,552L,668L,833L,776L,964L,892L,864L,1073L,816L,980L,980L,1132L,1148L,1196L,1333L,1392L,1408L,1444L,1684L,1885L,1720L,2100L,1836L,2380L };
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
public class A271281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271281Inst : IEnumerable<long>
{
public static readonly long[] Value=A271281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271281.Bytes);
public long this[int i]=>Value[i];

public static A271281Inst Instance=new A271281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271282
{
public static readonly long[] Value={ 1L,5L,21L,69L,177L,964L,3249L,13801L,56505L,228913L,905649L,3647572L,14560636L,58313644L,233143837L,932944592L };
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
public class A271282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271282Inst : IEnumerable<long>
{
public static readonly long[] Value=A271282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271282.Bytes);
public long this[int i]=>Value[i];

public static A271282Inst Instance=new A271282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271283
{
public static readonly long[] Value={ 1L,6L,14L,35L,55L,87L,131L,200L,260L,364L,436L,540L,661L,821L,1002L,1179L,1411L,1660L,1948L,2196L,2505L,2873L,3273L,3749L,4249L,4749L,5393L,5945L,6613L,7446L,8222L,9186L,10078L,10942L,12015L,12831L,13811L,14791L,15923L,17071L,18267L,19600L,20992L,22400L };
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
public class A271283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271283Inst : IEnumerable<long>
{
public static readonly long[] Value=A271283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271283.Bytes);
public long this[int i]=>Value[i];

public static A271283Inst Instance=new A271283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271316
{
public static readonly long[] Value={ 1L,2L,1L,8L,8L,1L,24L,36L,14L,1L,64L,128L,88L,24L,1L,160L,400L,400L,200L,42L,1L,384L,1152L,1520L,1120L,444L,76L,1L,896L,3136L,5152L,5040L,2968L,980L,142L,1L,2048L,8192L,16128L,19712L,15456L,7616L,2160L,272L,1L,4608L,20736L,47616L,69888L,68544L,45024L,19104L,4752L,530L,1L,10240L,51200L,134400L,230400L,271488L,223104L,126240L,47040L,10420L,1044L,1L };
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
public class A271316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271316Inst : IEnumerable<long>
{
public static readonly long[] Value=A271316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271316.Bytes);
public long this[int i]=>Value[i];

public static A271316Inst Instance=new A271316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271317
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,10L,14L,16L,20L };
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
public class A271317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271317Inst : IEnumerable<long>
{
public static readonly long[] Value=A271317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271317.Bytes);
public long this[int i]=>Value[i];

public static A271317Inst Instance=new A271317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271318
{
public static readonly long[] Value={ 1L,1L,2L,5L,9L,16L,33L,67L,126L,239L,477L,946L,1809L,3471L,6858L,13515L,26001L,50100L,98577L,193705L,373734L,721691L,1416933L,2779780L,5372001L,10386841L,20366802L,39915887L,77216409L,149422384L,292749633L,573363693L,1109898126L };
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
public class A271318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271318Inst : IEnumerable<long>
{
public static readonly long[] Value=A271318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271318.Bytes);
public long this[int i]=>Value[i];

public static A271318Inst Instance=new A271318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271319
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,2L,2L,2L,3L,3L,3L,2L,3L,4L,2L,2L,3L,4L,3L,3L,3L,3L,3L,2L,4L,3L,3L,2L,5L,3L,2L,4L,3L,4L,3L,2L,4L,4L,4L,3L,4L,3L,3L,3L,3L,4L,3L,2L,4L,4L,4L,2L,4L,4L,3L,4L,3L,3L,4L,4L,3L,5L,2L,3L,4L,4L,4L,4L,4L,3L,4L,2L,4L,5L,3L,3L,4L,3L,4L,3L,4L,4L,5L,4L,3L,4L };
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
public class A271319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271319Inst : IEnumerable<long>
{
public static readonly long[] Value=A271319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271319.Bytes);
public long this[int i]=>Value[i];

public static A271319Inst Instance=new A271319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271320
{
public static readonly long[] Value={ 1L,2L,4L,2L,3L,5L,5L,3L,3L,3L,7L,2L,3L,5L,6L,3L,4L,4L,6L,3L,3L,5L,6L,3L,4L,5L,9L,2L,5L,4L,7L,4L,4L,4L,7L,2L,4L,9L,7L,3L,4L,3L,7L,4L,3L,5L,7L,3L,5L,4L,7L,2L,6L,6L,6L,4L,3L,3L,9L,4L,3L,7L,8L,3L,4L,4L,7L,4L,4L,6L,8L,2L,4L,6L,7L,3L,4L,4L,8L,6L,4L,4L,8L,4L,3L,6L };
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
public class A271320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271320Inst : IEnumerable<long>
{
public static readonly long[] Value=A271320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271320.Bytes);
public long this[int i]=>Value[i];

public static A271320Inst Instance=new A271320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271321
{
public static readonly long[] Value={ 2L,2L,2L,5L,2L,2L,2L,3L,2L,2L,2L,13L,2L,2L,2L,11L,2L,2L,2L,3L,2L,2L,2L,5L,2L,2L,2L,29L,2L,2L,2L,3L,2L,2L,2L,37L,2L,2L,2L,11L,2L,2L,2L,3L,2L,2L,2L,7L,2L,2L,2L,53L,2L,2L,2L,3L,2L,2L,2L,7L,2L,2L,2L,5L,2L,2L,2L,3L,2L,2L,2L,73L,2L,2L,2L,7L,2L,2L,2L,3L,2L,2L,2L,5L };
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
public class A271321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271321Inst : IEnumerable<long>
{
public static readonly long[] Value=A271321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271321.Bytes);
public long this[int i]=>Value[i];

public static A271321Inst Instance=new A271321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271322
{
public static readonly long[] Value={ 2L,3L,2L,7L,11L,7L,11L,29L,37L,23L,7L,67L,79L,23L,53L,17L,137L,19L,43L,191L,211L,29L,127L,277L,43L,163L,11L,379L,37L,109L,233L,71L,23L,281L,149L,631L,29L,13L,53L,71L,821L,431L,113L,947L,991L,47L,541L,1129L,107L,613L,29L,1327L,197L,179L,743L,67L,1597L,827L };
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
public class A271322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271322Inst : IEnumerable<long>
{
public static readonly long[] Value=A271322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271322.Bytes);
public long this[int i]=>Value[i];

public static A271322Inst Instance=new A271322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271323
{
public static readonly long[] Value={ 383220L,1269642L,1528938L,2590770L,3014700L,3158298L,3697362L,3946338L,4017312L,4045050L,4545642L,4711740L,4851618L,4871568L,5141178L,5194602L,5925042L,5972958L,5990820L,6075030L,6179862L,6212202L,6350760L,6442938L,6549312L,6910638L,6912132L };
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
public class A271323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271323Inst : IEnumerable<long>
{
public static readonly long[] Value=A271323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271323.Bytes);
public long this[int i]=>Value[i];

public static A271323Inst Instance=new A271323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271324
{
public static readonly long[] Value={ 0L,2L,4L,6L,5L,7L,9L,11L,10L,12L,14L,16L,15L,17L,19L,21L,20L,22L,24L,26L,25L,27L,29L,31L,30L,32L,34L,36L,35L,37L,39L,41L,40L,42L,44L,46L,45L,47L,49L,51L,50L,52L,54L,56L,55L,57L,59L,61L,60L,62L,64L,66L,65L,67L,69L,71L,70L,72L,74L,76L,75L,77L,79L,81L,80L,82L,84L,86L,85L,87L,89L };
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
public class A271324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271324Inst : IEnumerable<long>
{
public static readonly long[] Value=A271324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271324.Bytes);
public long this[int i]=>Value[i];

public static A271324Inst Instance=new A271324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271325
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,2L,4L,1L,2L,2L,2L,2L,1L,4L,1L,2L,2L,1L,2L,1L,4L,3L,3L,2L,2L,5L,3L,3L,2L,3L,3L,3L,4L,2L,3L,5L,2L,2L,1L,3L,3L,5L,2L,1L,3L,2L,4L,3L,6L,1L,3L,5L,2L,1L,3L,6L,2L,2L,3L,3L,3L,6L,4L,4L,2L };
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
public class A271325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271325Inst : IEnumerable<long>
{
public static readonly long[] Value=A271325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271325.Bytes);
public long this[int i]=>Value[i];

public static A271325Inst Instance=new A271325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271326
{
public static readonly long[] Value={ 3L,15L,30L,51L,84L,111L,150L,195L,246L,318L,366L,435L,510L,591L,684L,771L,882L,975L,1086L,1218L,1326L,1455L,1590L,1731L,1884L,2031L,2190L,2370L,2526L,2718L,2886L,3075L,3270L,3483L,3684L,3891L,4128L,4335L,4566L,4818L,5046L,5295L,5550L,5811L,6084L };
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
public class A271326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271326Inst : IEnumerable<long>
{
public static readonly long[] Value=A271326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271326.Bytes);
public long this[int i]=>Value[i];

public static A271326Inst Instance=new A271326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271327
{
public static readonly long[] Value={ 18L,24L,29L,30L,46L,47L,51L,60L,63L,71L,82L,89L,98L,100L,102L,121L,123L,127L,135L,136L,139L,145L,149L,152L,156L,157L,162L,163L,165L,169L,180L,181L,184L,185L,221L,225L,235L,251L,252L,313L,316L,326L,327L,329L,331L,337L,359L,362L,369L,399L,401L,405L,428L,431L,434L,436L,440L,445L,448L,463L };
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
public class A271327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271327Inst : IEnumerable<long>
{
public static readonly long[] Value=A271327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271327.Bytes);
public long this[int i]=>Value[i];

public static A271327Inst Instance=new A271327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271328
{
public static readonly long[] Value={ 1L,5L,10L,17L,28L,37L,50L,65L,82L,106L,122L,145L,170L,197L,228L,257L,294L,325L,362L,406L,442L,485L,530L,577L,628L,677L,730L,790L,842L,906L,962L,1025L,1090L,1161L,1228L,1297L,1376L,1445L,1522L,1606L,1682L,1765L,1850L,1937L,2028L,2117L,2210L };
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
public class A271328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271328Inst : IEnumerable<long>
{
public static readonly long[] Value=A271328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271328.Bytes);
public long this[int i]=>Value[i];

public static A271328Inst Instance=new A271328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271329
{
public static readonly long[] Value={ 72L,96L,144L,144L,168L,216L,192L,216L,240L,252L,288L,288L,288L,324L,360L,336L,384L,360L,336L,456L,432L,384L,432L,504L,432L,528L,480L,448L,576L,480L,504L,540L,576L,648L,576L,576L,720L,576L,744L,684L,648L,576L,640L,816L,720L,756L,720L,864L,672L,792L,768L,720L };
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
public class A271329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271329Inst : IEnumerable<long>
{
public static readonly long[] Value=A271329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271329.Bytes);
public long this[int i]=>Value[i];

public static A271329Inst Instance=new A271329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271330
{
public static readonly BigInteger[] Value={ 2L,3L,14L,915L,54718634L,BigInteger.Parse("179054255520688074387"),BigInteger.Parse("104910436622395373760090792140594526518830577847960206") };
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
public class A271330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271330Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271330.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271330.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271330Inst Instance=new A271330Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271331
{
public static readonly BigInteger[] Value={ 2L,3L,41L,22974L,6794579902621097L,BigInteger.Parse("13653726962325414829845747247532682721242051") };
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
public class A271331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271331Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271331.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271331.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271331Inst Instance=new A271331Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271380
{
public static readonly long[] Value={ 1L,5L,25L,125L,136L,28L,140L,48L,77L,59L,132L,8L,40L,37L,22L,110L,61L,142L,58L,127L,146L,78L,64L,157L,133L,13L,65L,162L,158L,138L,38L,27L,135L,23L,115L,86L,104L,31L,155L,123L,126L,141L,53L,102L,21L,105L,36L,17L,85L,99L,6L,30L,150L,98L,1L,5L,25L,125L,136L,28L };
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
public class A271380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271380Inst : IEnumerable<long>
{
public static readonly long[] Value=A271380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271380.Bytes);
public long this[int i]=>Value[i];

public static A271380Inst Instance=new A271380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271381
{
public static readonly long[] Value={ 1L,2L,2L,1L,1L,2L,2L,1L,2L,4L,3L,1L,1L,3L,2L,1L,3L,5L,3L,1L,2L,3L,2L,0L,2L,5L,3L,3L,3L,4L,1L,2L,4L,5L,3L,2L,5L,4L,3L,2L,4L,6L,2L,3L,4L,5L,2L,2L,4L,3L,2L,2L,5L,6L,4L,3L,2L,3L,2L,2L,4L,4L,3L,3L,5L,7L,4L,5L,5L,6L,4L,2L,6L,9L,6L,2L,4L,5L,1L,3L,8L };
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
public class A271381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271381Inst : IEnumerable<long>
{
public static readonly long[] Value=A271381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271381.Bytes);
public long this[int i]=>Value[i];

public static A271381Inst Instance=new A271381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271382
{
public static readonly long[] Value={ 2L,14L,10L,26L,44L,45L,126L,68L,99L,104L,162L,117L,98L,124L,232L,164L,148L,200L,260L,333L,231L,244L,248L,297L,273L,284L,315L,406L,332L,345L,385L,430L,344L,399L,388L,436L,429L,488L,465L,495L,472L,525L,561L,555L,621L,556L,632L,604L,652L,712L,536L,693L,735L,675L };
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
public class A271382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271382Inst : IEnumerable<long>
{
public static readonly long[] Value=A271382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271382.Bytes);
public long this[int i]=>Value[i];

public static A271382Inst Instance=new A271382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271383
{
public static readonly long[] Value={ 2L,8L,13L,21L,32L,38L,46L,60L,85L,74L,102L,111L };
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
public class A271383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271383Inst : IEnumerable<long>
{
public static readonly long[] Value=A271383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271383.Bytes);
public long this[int i]=>Value[i];

public static A271383Inst Instance=new A271383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271384
{
public static readonly long[] Value={ 3L,14L,20L,28L,44L,92L,112L,224L,266L,260L,404L,380L,476L,552L,558L,696L,860L,984L,846L,1062L,1388L,1128L,1278L,1752L,1494L,1422L,2034L,1926L,1704L,1992L,2358L,2466L,2712L,2424L,2718L,3222L,3006L,3258L,4924L,3288L,3582L,4296L,3798L,4008L,4518L,5688L,5094L,5352L };
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
public class A271384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271384Inst : IEnumerable<long>
{
public static readonly long[] Value=A271384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271384.Bytes);
public long this[int i]=>Value[i];

public static A271384Inst Instance=new A271384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271385
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,1024L,84375L,47775744L,69486440625L,801543976648704L,BigInteger.Parse("26920470805806965625"),BigInteger.Parse("8015439766487040000000000"),BigInteger.Parse("7680724499239438722449399746875"),BigInteger.Parse("71466466094944065310414602240000000000"),BigInteger.Parse("2326300251412874049290421829657963142035959375") };
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
public class A271385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271385Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271385.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271385.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271385Inst Instance=new A271385Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271386
{
public static readonly BigInteger[] Value={ 1L,1L,36L,291600L,1851776640000L,BigInteger.Parse("23813032808678400000000"),BigInteger.Parse("1333916640950593574375424000000000000"),BigInteger.Parse("618764594221522786972353235328676003840000000000000000") };
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
public class A271386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271386Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271386.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271386.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271386Inst Instance=new A271386Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271387
{
public static readonly BigInteger[] Value={ 1L,2L,3L,5L,35L,77L,1001L,2431L,46189L,1062347L,30808063L,86822723L,3212440751L,10131543907L,435656388001L,20475850236047L,1085220062510491L,3766351981654057L,229747470880897477L,810162134158954261L,BigInteger.Parse("57521511525285752531"),BigInteger.Parse("4199070341345859934763"),BigInteger.Parse("331726556966322934846277") };
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
public class A271387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271387Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271387.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271387.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271387Inst Instance=new A271387Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271388
{
public static readonly long[] Value={ 0L,1L,2L,6L,22L,89L,372L,1570L,6644L,28137L,119182L,504854L,2138586L,9059185L,38375312L,162560418L,688616968L,2917028273L,12356730042L,52343948422L,221732523710L,939274043241L,3978828696652L,16854588829826L,71397184015932L,302443324893529L,1281170483590022L,5427125259253590L,22989671520604354L };
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
public class A271388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271388Inst : IEnumerable<long>
{
public static readonly long[] Value=A271388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271388.Bytes);
public long this[int i]=>Value[i];

public static A271388Inst Instance=new A271388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271389
{
public static readonly long[] Value={ 0L,1L,6L,22L,66L,179L,460L,1148L,2820L,6869L,16658L,40306L,97414L,235303L,568216L,1371960L,3312392L,7997033L,19306782L,46610958L,112529098L,271669595L,655868772L,1583407668L,3822684684L,9228777661L,22280240682L,53789259754L,129858760974L,313506782543L,756872326960L,1827251437424L };
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
public class A271389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271389Inst : IEnumerable<long>
{
public static readonly long[] Value=A271389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271389.Bytes);
public long this[int i]=>Value[i];

public static A271389Inst Instance=new A271389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271390
{
public static readonly BigInteger[] Value={ 1L,3L,5L,343L,729L,161051L,371293L,170859375L,410338673L,322687697779L,794280046581L,952809757913927L,2384185791015625L,4052555153018976267L,10260628712958602189UL,BigInteger.Parse("23465261991844685929951"),BigInteger.Parse("59938945498865420543457"),BigInteger.Parse("177482997121587371826171875"),BigInteger.Parse("456487940826035155404146917") };
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
public class A271390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271390Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271390.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271390.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271390Inst Instance=new A271390Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271391
{
public static readonly long[] Value={ 1L,1L,5L,9L,13L,25L,25L,49L,41L,81L,61L,121L,85L,169L,113L,225L,145L,289L,181L,361L,221L,441L,265L,529L,313L,625L,365L,729L,421L,841L,481L,961L,545L,1089L,613L,1225L,685L,1369L,761L,1521L,841L,1681L,925L,1849L,1013L,2025L,1105L,2209L,1201L,2401L,1301L,2601L,1405L,2809L,1513L };
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
public class A271391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271391Inst : IEnumerable<long>
{
public static readonly long[] Value=A271391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271391.Bytes);
public long this[int i]=>Value[i];

public static A271391Inst Instance=new A271391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271392
{
public static readonly long[] Value={ 2L,4L,5L,8L,9L,15L,16L,23L,27L,32L,34L,35L,38L,40L,46L,54L,57L,83L,87L,97L,162L,165L,223L,235L,282L,488L,503L,575L,673L,823L,857L,885L,965L,1112L,1401L,2288L,2569L,2788L,3133L,3539L,4070L,4654L,5020L,5613L,6720L,7773L };
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
public class A271392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271392Inst : IEnumerable<long>
{
public static readonly long[] Value=A271392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271392.Bytes);
public long this[int i]=>Value[i];

public static A271392Inst Instance=new A271392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271393
{
public static readonly long[] Value={ 3L,13L,797161L };
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
public class A271393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271393Inst : IEnumerable<long>
{
public static readonly long[] Value=A271393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271393.Bytes);
public long this[int i]=>Value[i];

public static A271393Inst Instance=new A271393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271394
{
public static readonly BigInteger[] Value={ 1L,2L,3L,8L,9L,25L,32L,512L,6561L,BigInteger.Parse("36703368217294125441230211032033660188801") };
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
public class A271394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271394Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271394.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271394.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271394Inst Instance=new A271394Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271395
{
public static readonly long[] Value={ 17L,137L,13313L,912251L,18035627L,148257477253L,1204244328631L };
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
public class A271395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271395Inst : IEnumerable<long>
{
public static readonly long[] Value=A271395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271395.Bytes);
public long this[int i]=>Value[i];

public static A271395Inst Instance=new A271395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271460
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,-2L,1L,-7L,-3L,-3L,1L,-30L,-10L,-3L,-4L,1L,-143L,-42L,-10L,-2L,-5L,1L,-728L,-198L,-42L,-8L,0L,-6L,1L,-3876L,-1001L,-198L,-35L,-5L,3L,-7L,1L,-21318L,-5304L,-1001L,-168L,-25L,-2L,7L,-8L,1L,-120175L,-29070L,-5304L,-858L,-126L,-15L,0L,12L,-9L,1L };
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
public class A271460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271460Inst : IEnumerable<long>
{
public static readonly long[] Value=A271460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271460.Bytes);
public long this[int i]=>Value[i];

public static A271460Inst Instance=new A271460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271461
{
public static readonly long[] Value={ 1L,4L,9L,32L,17L,104L,29L,180L,61L,312L,73L,460L,121L,652L,137L,860L,169L,1076L,261L,1308L,293L,1648L,341L,1980L,349L,2300L,513L,2604L,561L,3088L,565L,3592L,661L,3896L,873L,4412L,809L,4944L,905L,5548L,965L,6112L,1101L,6664L,1265L,7292L,1373L,8128L,1285L,8728L };
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
public class A271461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271461Inst : IEnumerable<long>
{
public static readonly long[] Value=A271461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271461.Bytes);
public long this[int i]=>Value[i];

public static A271461Inst Instance=new A271461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271462
{
public static readonly long[] Value={ 1L,4L,32L,180L,860L,3592L,14240L,57944L,233588L,933828L,3735024L,14951628L,59810772L,239229464L,957076300L,3828589256L };
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
public class A271462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271462Inst : IEnumerable<long>
{
public static readonly long[] Value=A271462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271462.Bytes);
public long this[int i]=>Value[i];

public static A271462Inst Instance=new A271462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271463
{
public static readonly long[] Value={ 1L,5L,14L,46L,63L,167L,196L,376L,437L,749L,822L,1282L,1403L,2055L,2192L,3052L,3221L,4297L,4558L,5866L,6159L,7807L,8148L,10128L,10477L,12777L,13290L,15894L,16455L,19543L,20108L,23700L,24361L,28257L,29130L,33542L,34351L,39295L,40200L,45748L,46713L,52825L,53926L };
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
public class A271463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271463Inst : IEnumerable<long>
{
public static readonly long[] Value=A271463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271463.Bytes);
public long this[int i]=>Value[i];

public static A271463Inst Instance=new A271463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271464
{
public static readonly long[] Value={ 3L,5L,23L,-15L,87L,-75L,151L,-119L,251L,-239L,387L,-339L,531L,-515L,723L,-691L,907L,-815L,1047L,-1015L,1355L,-1307L,1639L,-1631L,1951L,-1787L,2091L,-2043L,2527L,-2523L,3027L,-2931L,3235L,-3023L,3539L,-3603L,4135L,-4039L,4643L,-4583L,5147L,-5011L,5563L,-5399L };
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
public class A271464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271464Inst : IEnumerable<long>
{
public static readonly long[] Value=A271464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271464.Bytes);
public long this[int i]=>Value[i];

public static A271464Inst Instance=new A271464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271465
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,4L,1L,1L,4L,11L,8L,1L,1L,5L,28L,38L,16L,1L,1L,6L,69L,178L,126L,32L,1L,1L,7L,168L,844L,1008L,415L,64L,1L,1L,8L,407L,4012L,8590L,5493L,1369L,128L,1L,1L,9L,984L,19072L,74148L,81445L,29879L,4521L,256L,1L };
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
public class A271465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271465Inst : IEnumerable<long>
{
public static readonly long[] Value=A271465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271465.Bytes);
public long this[int i]=>Value[i];

public static A271465Inst Instance=new A271465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271466
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,4L,0L,1L,4L,10L,0L,1L,6L,15L,30L,0L,1L,10L,29L,59L,104L,0L,1L,18L,63L,139L,250L,406L,0L,1L,34L,149L,365L,692L,1145L,1754L,0L,1L,66L,375L,1039L,2110L,3627L,5649L,8280L,0L,1L,130L,989L,3149L,6932L,12521L,20085L,29874L,42294L,0L,1L,258L,2703L,10039L,24190L,46299L,77133L,117488L,168509L,231950L };
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
public class A271466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271466Inst : IEnumerable<long>
{
public static readonly long[] Value=A271466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271466.Bytes);
public long this[int i]=>Value[i];

public static A271466Inst Instance=new A271466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271467
{
public static readonly BigInteger[] Value={ 0L,1L,10L,149L,3149L,88772L,3195161L,142084077L,7611839904L,481614364251L,35417157810681L,2987457716884346L,285867917955683723L,BigInteger.Parse("30741794345071162069"),BigInteger.Parse("3685435185993122202106"),BigInteger.Parse("489101076818110701758097"),BigInteger.Parse("71414666988339306082779537"),BigInteger.Parse("11410190978037926887950636172") };
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
public class A271467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271467Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271467.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271467.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271467Inst Instance=new A271467Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271468
{
public static readonly long[] Value={ 1L,5L,10L,15L,17L,20L,25L,28L,30L,34L,35L,37L,40L,45L,50L,51L,55L,56L,60L,65L,68L,70L,74L,75L,80L,82L,84L,85L,90L,95L,100L,102L,105L,106L,110L,111L,112L,115L,119L,120L,122L,125L,130L,135L,136L,140L,145L,148L,150L,153L,155L,160L,164L,165L,168L,170L,175L,180L };
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
public class A271468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271468Inst : IEnumerable<long>
{
public static readonly long[] Value=A271468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271468.Bytes);
public long this[int i]=>Value[i];

public static A271468Inst Instance=new A271468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271469
{
public static readonly BigInteger[] Value={ 1L,1L,4L,23L,155L,1142L,8910L,72350L,605056L,5175866L,45077560L,398348733L,3562916317L,32192775763L,293410452560L,2694283228653L,24902681767987L,231496130358758L,2162985033344112L,20301976721356134L,191336242071696514L,1809916398759630481L,17178063381786563194UL,BigInteger.Parse("163536967014934201972"),BigInteger.Parse("1561247114394683682834"),BigInteger.Parse("14943175106109268856975") };
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
public class A271469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271469Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271469.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271469.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271469Inst Instance=new A271469Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271470
{
public static readonly BigInteger[] Value={ 1L,2241L,18395521L,22005481L,180674890281L,1483422094617961L,1774530705782041L,14569695060825930201UL,BigInteger.Parse("119623748111985974353561"),BigInteger.Parse("143098862377484625247441"),BigInteger.Parse("1174906008443637039413730321"),BigInteger.Parse("9646506658002296058866816899921"),BigInteger.Parse("11539549215467584644303744700081") };
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
public class A271470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271470Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271470.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271470.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271470Inst Instance=new A271470Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271471
{
public static readonly long[] Value={ 5L,17L,28L,37L,82L,106L,122L,197L,228L,257L,294L,362L,406L,577L,628L,677L,842L,906L,1161L,1228L,1297L,1376L,1522L,1606L,1682L,1937L,2028L,2117L,2402L,2513L,2606L,2917L,3028L,3142L,3482L,3606L,3722L,4236L,4357L,4629L,4762L,4906L,5042L,5483L,5777L,6242L,6406L };
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
public class A271471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271471Inst : IEnumerable<long>
{
public static readonly long[] Value=A271471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271471.Bytes);
public long this[int i]=>Value[i];

public static A271471Inst Instance=new A271471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271472
{
public static readonly long[] Value={ 0L,1L,1100L,1101L,111010000L,111010001L,111011100L,111011101L,111000000L,111000001L,111001100L,111001101L,100010000L,100010001L,100011100L,100011101L,100000000L,100000001L,100001100L,100001101L,110011010000L,110011010001L,110011011100L,110011011101L,110011000000L,110011000001L };
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
public class A271472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271472Inst : IEnumerable<long>
{
public static readonly long[] Value=A271472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271472.Bytes);
public long this[int i]=>Value[i];

public static A271472Inst Instance=new A271472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271473
{
public static readonly long[] Value={ 0L,1L,23L,3L,17L,26L,141L,7L,166L,22L,127L,32L,58L,148L,344L,15L,105L,175L,256L,32L,73L,138L,314L,44L,325L,71L,50699L,162L,218L,359L,50532L,31L,416L,122L,268L,193L,264L,275L,1166L,52L,50645L,94L,664L,160L,246L,337L,50470L,68L,399L,350L,561L,97L,198L,50726L,51137L,190L,821L,247L,1088L,389L };
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
public class A271473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271473Inst : IEnumerable<long>
{
public static readonly long[] Value=A271473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271473.Bytes);
public long this[int i]=>Value[i];

public static A271473Inst Instance=new A271473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271474
{
public static readonly long[] Value={ 0L,1L,3L,4L,8L,12L,15L,21L,27L,35L,42L,50L };
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
public class A271474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271474Inst : IEnumerable<long>
{
public static readonly long[] Value=A271474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271474.Bytes);
public long this[int i]=>Value[i];

public static A271474Inst Instance=new A271474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271475
{
public static readonly BigInteger[] Value={ 0L,2L,13L,79L,523L,3883L,32323L,299443L,3061363L,34269043L,417107443L,5486541043L,77576281843L,1173531942643L,18914314201843L,323602441945843L,5857680367321843L,111852533939929843L,2247044164800217843L,BigInteger.Parse("47377376416476889843"),BigInteger.Parse("1046083650772987609843") };
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
public class A271475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271475Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271475.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271475.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271475Inst Instance=new A271475Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271556
{
public static readonly BigInteger[] Value={ 9L,81L,1023L,9842L,140743L,2471826L,50333399L,1162263921L,30000003325L,855935016215L,26748301350411L,908625319783885L,33336020476682897L,1313681671142588955L,BigInteger.Parse("55340232221128667935"),BigInteger.Parse("2481720785659010308168"),BigInteger.Parse("118039224225889612744771"),BigInteger.Parse("5935258966980940767393628") };
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
public class A271556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271556Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271556.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271556.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271556Inst Instance=new A271556Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}