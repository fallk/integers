using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A169764
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,16L,0L,176L,0L,1536L,0L,15424L,0L,147728L,0L,1448416L,0L,14060048L,0L,136947616L,0L,1332257856L,0L,12965578752L,0L,126169362176L,0L,1227776129152L,0L,11947846468608L,0L,116266505653888L,0L,1131418872918784L,0L,11010065269439104L,0L,107141489725900544L };
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
public class A169764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169764Inst : IEnumerable<long>
{
public static readonly long[] Value=A169764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169764.Bytes);
public long this[int i]=>Value[i];

public static A169764Inst Instance=new A169764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169765
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,24L,0L,0L,0L,276L,0L,0L,0L,2604L,0L,0L,0L,25736L,0L,0L,0L,248816L,0L,0L,0L,2424608L,0L,0L,0L,23581056L,0L,0L,0L,229513584L,0L,0L,0L,2233386048L,0L,0L,0L,21733496960L,0L,0L,0L,211495383968L,0L,0L,0L,2058092298080L };
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
public class A169765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169765Inst : IEnumerable<long>
{
public static readonly long[] Value=A169765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169765.Bytes);
public long this[int i]=>Value[i];

public static A169765Inst Instance=new A169765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169766
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,8L,0L,48L,0L,152L,0L,352L,0L,1200L,0L,3752L,0L,12912L,0L,34768L,0L,122120L,0L,346128L,0L,1202240L,0L,3337424L,0L,11650864L,0L,32634960L,0L,113539392L,0L,316870592L,0L,1104442752L,0L,3086894528L,0L,10748713792L,0L,30023935744L,0L };
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
public class A169766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169766Inst : IEnumerable<long>
{
public static readonly long[] Value=A169766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169766.Bytes);
public long this[int i]=>Value[i];

public static A169766Inst Instance=new A169766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169767
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,16L,0L,0L,0L,124L,0L,0L,0L,1404L,0L,0L,0L,12824L,0L,0L,0L,126696L,0L,0L,0L,1222368L,0L,0L,0L,11930192L,0L,0L,0L,115974192L,0L,0L,0L,1128943296L,0L,0L,0L,10984783168L,0L,0L,0L,106897187552L,0L,0L,0L,1040241749856L };
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
public class A169767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169767Inst : IEnumerable<long>
{
public static readonly long[] Value=A169767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169767.Bytes);
public long this[int i]=>Value[i];

public static A169767Inst Instance=new A169767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169768
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,24L,0L,24L,0L,276L,0L,176L,0L,2604L,0L,1876L,0L,25736L,0L,17384L,0L,248816L,0L,173064L,0L,2424608L,0L,1668712L,0L,23581056L,0L,16317480L,0L,229513584L,0L,158435296L,0L,2233386048L,0L,1543447264L,0L,21733496960L };
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
public class A169768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169768Inst : IEnumerable<long>
{
public static readonly long[] Value=A169768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169768.Bytes);
public long this[int i]=>Value[i];

public static A169768Inst Instance=new A169768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169769
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,6L,0L,44L,0L,396L,0L,3868L,0L,37070L,0L,362192L,0L,3516314L,0L,34237842L,0L,333077332L,0L,3241403380L,0L,31542464952L,0L,306944118820L,0L,2986962829456L,0L,29066627247828L,0L,282854730020224L,0L,2752516325518516L,0L };
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
public class A169769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169769Inst : IEnumerable<long>
{
public static readonly long[] Value=A169769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169769.Bytes);
public long this[int i]=>Value[i];

public static A169769Inst Instance=new A169769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169770
{
public static readonly long[] Value={ 4L,0L,0L,0L,80L,40L,368L,352L,5296L,3744L,48656L,40208L,523808L,415488L,5270976L,4333504L,54215264L,44497728L,551297184L,458337984L,5613555008L,4691821600L,56981627840L,47988689152L,577641089664L,489273948160L,5845628996352L };
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
public class A169770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169770Inst : IEnumerable<long>
{
public static readonly long[] Value=A169770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169770.Bytes);
public long this[int i]=>Value[i];

public static A169770Inst Instance=new A169770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169771
{
public static readonly long[] Value={ 2L,0L,0L,52L,224L,520L,1616L,10320L,37024L,125120L,441200L,1798576L,6327472L,22985504L,81178008L,301420176L,1057619944L,3818476576L,13412523392L,48285742208L,168992600680L,602349395456L,2106360581920L,7471875943776L,26073917403304L,92017860990176L,320713651212384L };
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
public class A169771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169771Inst : IEnumerable<long>
{
public static readonly long[] Value=A169771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169771.Bytes);
public long this[int i]=>Value[i];

public static A169771Inst Instance=new A169771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169772
{
public static readonly long[] Value={ 2L,0L,0L,0L,92L,0L,1064L,0L,14928L,0L,156416L,0L,1785600L,0L,19416704L,0L,211014544L,0L,2261999424L,0L,24067157192L,0L,254242274472L,0L,2669251156032L,0L,27880294589248L };
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
public class A169772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169772Inst : IEnumerable<long>
{
public static readonly long[] Value=A169772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169772.Bytes);
public long this[int i]=>Value[i];

public static A169772Inst Instance=new A169772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169773
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,4L,0L,0L,0L,16L,0L,0L,0L,264L,0L,0L,0L,2144L,0L,0L,0L,22408L,0L,0L,0L,211808L,0L,0L,0L,2087344L,0L,0L,0L,20207664L,0L,0L,0L,197082624L,0L,0L,0L,1916054112L,0L,0L,0L,18652927040L,0L,0L,0L,181485750208L,0L,0L,0L,1766199186560L,0L,0L,0L };
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
public class A169773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169773Inst : IEnumerable<long>
{
public static readonly long[] Value=A169773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169773.Bytes);
public long this[int i]=>Value[i];

public static A169773Inst Instance=new A169773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169774
{
public static readonly long[] Value={ 2L,0L,0L,4L,12L,20L,28L,120L,104L,304L,384L,1304L,1680L,4936L,5908L,18304L,21412L,63440L,76920L,233248L,281284L,833720L,990104L,2993016L,3523740L,10485472L,12432392L,37485424L,44184884L,131430320L,154630088L,465106072L,544994604L,1622783328L,1904647128L };
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
public class A169774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169774Inst : IEnumerable<long>
{
public static readonly long[] Value=A169774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169774.Bytes);
public long this[int i]=>Value[i];

public static A169774Inst Instance=new A169774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169775
{
public static readonly long[] Value={ 2L,0L,0L,0L,8L,0L,16L,0L,48L,0L,200L,0L,616L,0L,1832L,0L,6008L,0L,19304L,0L,62180L,0L,189580L,0L,615792L,0L,1895952L,0L,6136708L,0L,18699436L,0L,60490008L,0L,184450888L,0L,595959276L,0L,1811054676L,0L,5847417040L,0L,17754996288L,0L,57292227492L };
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
public class A169775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169775Inst : IEnumerable<long>
{
public static readonly long[] Value=A169775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169775.Bytes);
public long this[int i]=>Value[i];

public static A169775Inst Instance=new A169775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169776
{
public static readonly long[] Value={ 2L,0L,0L,2L,10L,12L,22L,60L,76L,160L,292L,652L,1148L,2600L,3870L,9152L,13710L,32792L,48112L,116624L,171732L,428064L,589842L,1496508L,2069766L,5348640L,7164172L,18742712L,25160796L,66758832L,86664762L,232553036L,302742306L,821495496L,1044549008L };
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
public class A169776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169776Inst : IEnumerable<long>
{
public static readonly long[] Value=A169776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169776.Bytes);
public long this[int i]=>Value[i];

public static A169776Inst Instance=new A169776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169777
{
public static readonly long[] Value={ 3L,0L,0L,14L,104L,146L,773L,2698L,14350L,32296L,161714L,460022L,2159794L,5851548L,26468357L,76442996L,330719293L,965759972L,4056479056L,12186078360L,49668414086L,151760518296L,604396415979L,1879966906486L,7330203447133L,23126786408904L,88609897281582L };
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
public class A169777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169777Inst : IEnumerable<long>
{
public static readonly long[] Value=A169777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169777.Bytes);
public long this[int i]=>Value[i];

public static A169777Inst Instance=new A169777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169778
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,3L,4L,1L,2L,3L,5L,5L,4L,7L,8L,1L,2L,3L,5L,5L,5L,9L,13L,9L,4L,7L,12L,14L,10L,16L,16L,1L,2L,3L,5L,5L,5L,9L,13L,9L,5L,9L,15L,19L,17L,21L,29L,17L,4L,7L,12L,14L,14L,22L,34L,30L,14L,16L,28L,35L,25L,35L,32L,1L,2L,3L,5L,5L,5L,9L,13L,9L,5L,9L,15L,19L,17L,21L };
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
public class A169778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169778Inst : IEnumerable<long>
{
public static readonly long[] Value=A169778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169778.Bytes);
public long this[int i]=>Value[i];

public static A169778Inst Instance=new A169778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169779
{
public static readonly long[] Value={ 1L,2L,5L,6L,9L,14L,21L,22L,25L,30L,39L,48L,55L,68L,83L,84L,87L,92L,101L,110L,119L,136L,161L,178L,185L,198L,221L,248L,267L,298L,329L,330L,333L,338L,347L,356L,365L,382L,407L,424L,433L,450L,479L,516L,549L,590L,647L,680L,687L,700L,723L,750L,777L,820L,887L,946L,973L,1004L,1059L };
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
public class A169779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169779Inst : IEnumerable<long>
{
public static readonly long[] Value=A169779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169779.Bytes);
public long this[int i]=>Value[i];

public static A169779Inst Instance=new A169779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169780
{
public static readonly long[] Value={ 0L,1L,3L,5L,9L,11L,15L,21L,29L,31L,35L,41L,51L,61L,69L,83L,99L,101L,105L,111L,121L,131L,141L,159L,185L,203L,211L,225L,249L,277L,297L,329L,361L,363L,367L,373L,383L,393L,403L,421L,447L,465L,475L,493L,523L,561L,595L,637L,695L,729L,737L,751L,775L,803L,831L,875L,943L,1003L,1031L };
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
public class A169780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169780Inst : IEnumerable<long>
{
public static readonly long[] Value=A169780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169780.Bytes);
public long this[int i]=>Value[i];

public static A169780Inst Instance=new A169780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169781
{
public static readonly long[] Value={ 1L,3L,9L,29L,99L,361L,1373L,5349L,21109L,83859L,334275L };
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
public class A169781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169781Inst : IEnumerable<long>
{
public static readonly long[] Value=A169781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169781.Bytes);
public long this[int i]=>Value[i];

public static A169781Inst Instance=new A169781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169782
{
public static readonly long[] Value={ 1L,1L,3L,4L,1L,3L,5L,7L,8L,1L,3L,5L,9L,10L,12L,13L,1L,3L,5L,9L,11L,13L,16L,19L,20L,1L,3L,5L,9L,11L,15L,20L,24L,25L,27L,28L,1L,3L,5L,9L,11L,15L,21L,27L,28L,30L,33L,36L,37L,1L,3L,5L,9L,11L,15L,21L,29L,30L,32L,35L,40L,43L,46L,47L,1L,3L,5L,9L,11L,15L,21L,29L,31L,33L,36L,41L,46L,49L,54L,58L,59L,1L };
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
public class A169782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169782Inst : IEnumerable<long>
{
public static readonly long[] Value=A169782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169782.Bytes);
public long this[int i]=>Value[i];

public static A169782Inst Instance=new A169782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169783
{
public static readonly long[] Value={ 1L,4L,4L,0L,6L,16L,8L,0L,12L,20L,8L,0L,8L,16L,16L,0L,6L,32L,12L,0L,24L,32L,8L,0L,24L,20L,24L,0L,0L,48L,16L,0L,12L,32L,16L,0L,30L,16L,24L,0L,24L,64L,16L,0L,24L,48L,16L,0L,8L,36L,28L,0L,24L,48L,32L,0L,48L,32L,8L,0L,0L,48L,32L,0L,6L,64L,32L,0L,48L,64L,16L,0L,36L,32L,40L,0L,24L,64L,16L,0L,24L,68L };
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
public class A169783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169783Inst : IEnumerable<long>
{
public static readonly long[] Value=A169783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169783.Bytes);
public long this[int i]=>Value[i];

public static A169783Inst Instance=new A169783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169784
{
public static readonly long[] Value={ 1L,4L,4L,0L,4L,10L,8L,8L,4L,12L,24L,0L,0L,16L,8L,16L,4L,8L,20L,0L,10L,16L,24L,8L,8L,44L,8L,0L,8L,16L,40L,16L,4L,16L,24L,0L,12L,32L,8L,16L,24L,16L,16L,0L,0L,50L,40L,8L,0L,28L,44L,0L,16L,16L,32L,40L,8L,32L,40L,0L,16L,32L,16L,24L,4L,48L,16L,0L,8L,16L,80L,16L,20L,40L,24L,0L,0L,16L,32L,32L,10L,36L };
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
public class A169784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169784Inst : IEnumerable<long>
{
public static readonly long[] Value=A169784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169784.Bytes);
public long this[int i]=>Value[i];

public static A169784Inst Instance=new A169784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169785
{
public static readonly long[] Value={ 1L,7L,31L,127L,499L,1975L,7855L,31327L,125119L,500083L,1999507L };
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
public class A169785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169785Inst : IEnumerable<long>
{
public static readonly long[] Value=A169785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169785.Bytes);
public long this[int i]=>Value[i];

public static A169785Inst Instance=new A169785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169786
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,3L,5L,3L,3L,1L,1L,2L,3L,5L,5L,5L,9L,13L,7L,3L,5L,8L,6L,4L,1L,1L,2L,3L,5L,5L,5L,9L,13L,9L,5L,9L,15L,19L,17L,21L,29L,15L,3L,5L,8L,10L,10L,14L,22L,18L,8L,8L,13L,10L,5L,1L,1L,2L,3L,5L,5L,5L,9L,13L,9L,5L,9L,15L,19L,17L,21L,29L,17L,5L,9L,15L,19L,19L,27L,43L,43L,25L,21L,37L,51L,47L,51L,63L };
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
public class A169786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169786Inst : IEnumerable<long>
{
public static readonly long[] Value=A169786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169786.Bytes);
public long this[int i]=>Value[i];

public static A169786Inst Instance=new A169786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169787
{
public static readonly long[] Value={ 1L,2L,3L,5L,5L,5L,9L,13L,9L,5L,9L,15L,19L,17L,21L,29L,17L,5L,9L,15L,19L,19L,27L,43L,43L,25L,21L,37L,51L,47L,51L,63L,33L,5L,9L,15L,19L,19L,27L,43L,43L,27L,27L,47L,67L,71L,75L,99L,91L,41L,21L,37L,51L,55L,71L,111L,127L,87L,59L,87L,125L,119L,119L,133L,65L,5L,9L,15L,19L,19L };
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
public class A169787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169787Inst : IEnumerable<long>
{
public static readonly long[] Value=A169787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169787.Bytes);
public long this[int i]=>Value[i];

public static A169787Inst Instance=new A169787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169788
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,4L,6L,7L,7L,14L,20L,25L,27L,30L,36L,37L,37L,52L,66L,79L,89L,100L,112L,117L,115L,122L,140L,153L,157L,158L,168L,167L,167L,198L,228L,257L,283L,310L,338L,359L,373L,396L,428L,453L,467L,474L,486L,491L,481L,496L,538L,575L,603L,628L,654L,665L,653L,650L,680L,707L,711L };
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
public class A169788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169788Inst : IEnumerable<long>
{
public static readonly long[] Value=A169788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169788.Bytes);
public long this[int i]=>Value[i];

public static A169788Inst Instance=new A169788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169789
{
public static readonly long[] Value={ 0L,0L,1L,7L,37L,167L,707L,2907L,11787L,47469L,190525L };
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
public class A169789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169789Inst : IEnumerable<long>
{
public static readonly long[] Value=A169789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169789.Bytes);
public long this[int i]=>Value[i];

public static A169789Inst Instance=new A169789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169790
{
public static readonly long[] Value={ 3L,4L,10L,24L,74L,444L,1614L,15684L,29400L,50124L,259224L,5332128L,11110428L,50395440L,451174728L,1296895890L };
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
public class A169790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169790Inst : IEnumerable<long>
{
public static readonly long[] Value=A169790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169790.Bytes);
public long this[int i]=>Value[i];

public static A169790Inst Instance=new A169790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169791
{
public static readonly long[] Value={ 9L,3L,4L,8L,24L,74L,444L,1614L,15684L,29400L,50124L,556274L,5332128L,11110428L,50395440L,509562294L,1296895890L };
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
public class A169791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169791Inst : IEnumerable<long>
{
public static readonly long[] Value=A169791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169791.Bytes);
public long this[int i]=>Value[i];

public static A169791Inst Instance=new A169791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169792
{
public static readonly long[] Value={ 1L,5L,20L,70L,225L,681L,1970L,5500L,14920L,39520L,102592L,261760L,657920L,1632000L,4001280L,9708544L,23336960L,55623680L,131563520L,309002240L,721092608L,1672806400L,3859415040L,8859156480L,20240138240L,46038777856L,104291368960L,235342397440L,529153392640L };
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
public class A169792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169792Inst : IEnumerable<long>
{
public static readonly long[] Value=A169792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169792.Bytes);
public long this[int i]=>Value[i];

public static A169792Inst Instance=new A169792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169793
{
public static readonly long[] Value={ 1L,6L,27L,104L,363L,1182L,3653L,10836L,31092L,86784L,236640L,632448L,1661056L,4296192L,10961664L,27630592L,68889600L,170065920L,416071680L,1009582080L,2431254528L,5814222848L,13815054336L,32629850112L,76640681984L,179080003584L,416412598272L,963876225024L };
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
public class A169793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169793Inst : IEnumerable<long>
{
public static readonly long[] Value=A169793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169793.Bytes);
public long this[int i]=>Value[i];

public static A169793Inst Instance=new A169793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169794
{
public static readonly long[] Value={ 1L,7L,35L,147L,553L,1925L,6321L,19825L,59906L,175504L,500864L,1397536L,3823680L,10282496L,27230464L,71129856L,183518720L,468213760L,1182433280L,2958376960L,7338426368L,18059821056L,44120473600L,107055742976L,258122317824L,618683957248L,1474700509184L };
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
public class A169794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169794Inst : IEnumerable<long>
{
public static readonly long[] Value=A169794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169794.Bytes);
public long this[int i]=>Value[i];

public static A169794Inst Instance=new A169794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169795
{
public static readonly long[] Value={ 1L,8L,44L,200L,806L,2984L,10364L,34232L,108545L,332688L,990736L,2878144L,8182432L,22823680L,62595328L,169090048L,450568960L,1185832960L,3085885440L,7947714560L,20275478528L,51272351744L,128605356032L,320145981440L,791358537728L,1943278714880L,4742573981696L };
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
public class A169795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169795Inst : IEnumerable<long>
{
public static readonly long[] Value=A169795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169795.Bytes);
public long this[int i]=>Value[i];

public static A169795Inst Instance=new A169795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169796
{
public static readonly long[] Value={ 1L,9L,54L,264L,1134L,4446L,16272L,56412L,187137L,598417L,1854882L,5597172L,16498632L,47638512L,135048672L,376592064L,1034663040L,2804590080L,7509232640L,19880294400L,52088352768L,135173578752L,347680161792L,886900948992L,2245014454272L,5641949085696L };
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
public class A169796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169796Inst : IEnumerable<long>
{
public static readonly long[] Value=A169796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169796.Bytes);
public long this[int i]=>Value[i];

public static A169796Inst Instance=new A169796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169797
{
public static readonly long[] Value={ 1L,10L,65L,340L,1550L,6412L,24650L,89440L,309605L,1030490L,3317445L,10377180L,31655820L,94451520L,276313200L,794169792L,2246410560L,6262748160L,17230138880L,46831339520L,125870737408L,334826700800L,882159984640L,2303540756480L,5965195018240L,15327324667904L };
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
public class A169797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169797Inst : IEnumerable<long>
{
public static readonly long[] Value=A169797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169797.Bytes);
public long this[int i]=>Value[i];

public static A169797Inst Instance=new A169797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169798
{
public static readonly long[] Value={ 41L,61L,83L,89L,101L,127L,149L,151L,163L,181L,1201L,1213L,1223L,1249L,1259L,2267L,2273L,2281L,2309L,3203L,3301L,3343L,3359L,3361L,3389L,3391L,3407L,4201L,4409L,4451L,4463L,4481L,4493L,4507L,4513L,4523L,4547L,5501L,5563L,5573L,5581L,6007L,6203L,6263L,6421L };
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
public class A169798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169798Inst : IEnumerable<long>
{
public static readonly long[] Value=A169798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169798.Bytes);
public long this[int i]=>Value[i];

public static A169798Inst Instance=new A169798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169799
{
public static readonly long[] Value={ 1L,3L,6L,7L,12L,15L,23L,24L,26L,31L,32L,35L,36L,37L,41L,42L,49L,51L,52L,53L,55L,56L,59L,60L,64L,65L,69L,70L,72L,75L,76L,79L,80L,82L,85L,86L,93L,94L,97L,99L,102L,106L,109L,110L,112L,122L,123L,125L,126L,128L,130L,133L,137L,141L,143L,145L,150L,153L,154L,157L,166L,168L,172L,173L,174L,178L,185L,188L,193L,195L,199L,200L };
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
public class A169799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169799Inst : IEnumerable<long>
{
public static readonly long[] Value=A169799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169799.Bytes);
public long this[int i]=>Value[i];

public static A169799Inst Instance=new A169799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169800
{
public static readonly long[] Value={ 2L,2L,6L,9L,1L,8L,5L,3L,1L,4L,2L,1L,3L,0L,2L,1L,9L,6L,8L,1L,1L,4L,4L,9L,0L,8L,1L,0L,3L,0L,6L,5L,7L,2L,4L,7L,5L,7L,2L,5L,9L,8L,1L,5L,8L,5L,5L,0L,4L,0L,0L,1L,3L,5L,0L,0L,5L,0L,6L,5L,8L,2L,2L,2L,3L,6L,0L,2L,7L,8L,6L,5L,5L,7L,9L,3L,7L,6L,8L,8L,2L,0L,7L,6L,5L,4L,4L,3L,5L,4L,9L,1L,0L,1L,2L,5L,1L,8L,9L };
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
public class A169800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169800Inst : IEnumerable<long>
{
public static readonly long[] Value=A169800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169800.Bytes);
public long this[int i]=>Value[i];

public static A169800Inst Instance=new A169800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169801
{
public static readonly long[] Value={ 0L,0L,4L,64L,400L,1600L,4900L,12544L,28224L,57600L,108900L,193600L,327184L,529984L,828100L,1254400L,1849600L,2663424L,3755844L,5198400L,7075600L,9486400L,12545764L,16386304L,21160000L,27040000L,34222500L,42928704L,53406864L,65934400L,80820100L,98406400L };
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
public class A169801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169801Inst : IEnumerable<long>
{
public static readonly long[] Value=A169801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169801.Bytes);
public long this[int i]=>Value[i];

public static A169801Inst Instance=new A169801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169802
{
public static readonly long[] Value={ 2L,3L,5L,7L,10L,11L,13L,17L,19L,23L,29L,31L,37L,39L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,155L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L };
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
public class A169802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169802Inst : IEnumerable<long>
{
public static readonly long[] Value=A169802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169802.Bytes);
public long this[int i]=>Value[i];

public static A169802Inst Instance=new A169802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169803
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,0L,1L,3L,1L,0L,1L,4L,3L,0L,0L,1L,5L,6L,1L,0L,0L,1L,6L,10L,4L,0L,0L,0L,1L,7L,15L,10L,1L,0L,0L,0L,1L,8L,21L,20L,5L,0L,0L,0L,0L,1L,9L,28L,35L,15L,1L,0L,0L,0L,0L,1L,10L,36L,56L,35L,6L,0L,0L,0L,0L,0L,1L,11L,45L,84L,70L,21L,1L,0L,0L,0L,0L,0L,1L,12L,55L,120L,126L,56L,7L,0L,0L,0L };
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
public class A169803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169803Inst : IEnumerable<long>
{
public static readonly long[] Value=A169803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169803.Bytes);
public long this[int i]=>Value[i];

public static A169803Inst Instance=new A169803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169804
{
public static readonly long[] Value={ 14L,22L,26L,34L,38L,46L,51L,57L,58L,62L,69L,74L,76L,82L,86L,87L,92L,93L,94L,106L,111L,116L,118L,122L,123L,124L,129L,134L,141L,142L,146L,148L,158L,159L,164L,166L,172L,177L,178L,183L,185L,188L,194L,201L,202L,205L,206L,212L,213L,214L,215L,218L,219L,226L,235L,236L,237L,244L,249L };
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
public class A169804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169804Inst : IEnumerable<long>
{
public static readonly long[] Value=A169804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169804.Bytes);
public long this[int i]=>Value[i];

public static A169804Inst Instance=new A169804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169805
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,2L,4L,6L,8L,10L,12L,14L,16L,18L,20L,4L,6L,8L,10L,12L,14L,16L,18L,20L,22L,6L,8L,10L,12L,14L,16L,18L,20L,22L,24L,8L,10L,12L,14L,16L,18L,20L,22L,24L,26L,10L,12L,14L,16L,18L,20L,22L,24L,26L,28L,12L,14L,16L,18L,20L,22L,24L,26L,28L,30L,14L,16L,18L,20L,22L,24L,26L };
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
public class A169805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169805Inst : IEnumerable<long>
{
public static readonly long[] Value=A169805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169805.Bytes);
public long this[int i]=>Value[i];

public static A169805Inst Instance=new A169805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169806
{
public static readonly long[] Value={ 354253L,385863L,398573L,534235L,653936L,676356L,682566L,695276L,853638L,35369253L,35639453L,45469254L,45636454L,45839454L,53369235L,53639435L,54469245L,54636445L,54839445L,55769255L,56814665L,56941765L,59236195L };
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
public class A169806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169806Inst : IEnumerable<long>
{
public static readonly long[] Value=A169806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169806.Bytes);
public long this[int i]=>Value[i];

public static A169806Inst Instance=new A169806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169807
{
public static readonly long[] Value={ 1L,2L,4L,12L,33L,102L,312L,1006L };
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
public class A169807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169807Inst : IEnumerable<long>
{
public static readonly long[] Value=A169807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169807.Bytes);
public long this[int i]=>Value[i];

public static A169807Inst Instance=new A169807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169808
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,4L,5L,4L,4L,11L,14L,18L,16L,12L,28L,53L,69L,88L,78L,27L,91L,178L,295L,396L,489L,457L,82L,311L,685L,1196L,1867L,2503L,3071L,2938L };
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
public class A169808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169808Inst : IEnumerable<long>
{
public static readonly long[] Value=A169808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169808.Bytes);
public long this[int i]=>Value[i];

public static A169808Inst Instance=new A169808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169809
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,3L,4L,3L,2L,6L,7L,10L,8L,5L,8L,18L,19L,29L,23L,5L,18L,26L,52L,57L,86L,68L,14L,23L,68L,82L,166L,176L,266L,215L };
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
public class A169809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169809Inst : IEnumerable<long>
{
public static readonly long[] Value=A169809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169809.Bytes);
public long this[int i]=>Value[i];

public static A169809Inst Instance=new A169809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169810
{
public static readonly long[] Value={ 0L,0L,6L,10L,20L,28L,34L,54L,72L,88L,110L,114L,156L,164L,202L,238L,272L,304L,342L,378L,388L,428L,498L,518L,600L,616L,702L,706L,780L,852L,922L,990L,1056L,1120L,1190L,1258L,1332L,1404L,1410L,1494L,1640L,1720L,1742L,1810L,1980L,1988L,2154L,2190L,2352L,2384L,2550L,2586L };
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
public class A169810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169810Inst : IEnumerable<long>
{
public static readonly long[] Value=A169810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169810.Bytes);
public long this[int i]=>Value[i];

public static A169810Inst Instance=new A169810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169811
{
public static readonly long[] Value={ 0L,0L,1L,5L,14L,10L,19L,27L,44L,36L,61L,73L,66L,86L,103L,119L,152L,136L,185L,173L,198L,242L,235L,259L,308L,348L,325L,353L,394L,430L,463L,495L,560L,528L,625L,597L,702L,666L,707L,811L,796L,884L,941L,921L,1010L,1062L,1047L,1095L,1192L,1272L,1225L,1309L,1366L,1442L,1531L };
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
public class A169811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169811Inst : IEnumerable<long>
{
public static readonly long[] Value=A169811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169811.Bytes);
public long this[int i]=>Value[i];

public static A169811Inst Instance=new A169811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169812
{
public static readonly long[] Value={ 0L,0L,1L,7L,7L,2L,5L,12L,10L,14L,9L,10L,15L,10L,11L,21L,19L,20L,17L,18L,17L,18L,21L,16L,26L,30L,31L,26L,31L,22L,29L,38L,37L,38L,39L,45L,39L,34L,35L,32L,43L,34L,41L,42L,43L,42L,45L,58L,50L,52L,55L,50L,55L,62L,51L,48L,61L,62L,57L,48L,63L,58L,57L,71L,69L,74L,65L,66L,65L,78L,69L,68L,75L,78L };
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
public class A169812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169812Inst : IEnumerable<long>
{
public static readonly long[] Value=A169812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169812.Bytes);
public long this[int i]=>Value[i];

public static A169812Inst Instance=new A169812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169813
{
public static readonly long[] Value={ 0L,1L,7L,3L,3L,10L,15L,7L,4L,24L,7L,16L,3L,22L,23L,15L,3L,53L,7L,62L,53L,50L,15L,36L,6L,48L,51L,36L,3L,86L,63L,31L,17L,20L,19L,127L,3L,26L,31L,114L,3L,74L,7L,120L,99L,102L,31L,76L,8L,111L,123L,86L,3L,78L,127L,64L,105L,96L,7L,148L,3L,94L,87L,63L,21L,210L,7L,58L,37L,214L,15L,139L,3L,56L };
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
public class A169813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169813Inst : IEnumerable<long>
{
public static readonly long[] Value=A169813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169813.Bytes);
public long this[int i]=>Value[i];

public static A169813Inst Instance=new A169813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169814
{
public static readonly long[] Value={ 0L,3L,1L,6L,1L,4L,1L,12L,15L,14L,1L,8L,1L,8L,7L,24L,1L,20L,1L,28L,25L,28L,1L,16L,13L,22L,9L,16L,1L,22L,1L,48L,53L,50L,59L,40L,1L,52L,63L,56L,1L,38L,1L,56L,53L,56L,1L,32L,27L,38L,19L,44L,1L,36L,31L,32L,29L,38L,1L,44L,1L,32L,27L,96L,113L,86L,1L,100L,105L,94L,1L,80L,1L,110L,99L,104L,113L,86L };
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
public class A169814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169814Inst : IEnumerable<long>
{
public static readonly long[] Value=A169814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169814.Bytes);
public long this[int i]=>Value[i];

public static A169814Inst Instance=new A169814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169815
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,4500L,9000L,1512630000L,1452124800000L,111152892816000000L,3112280998848000000L,BigInteger.Parse("1849326140334157445511936000000"),BigInteger.Parse("388358489470173063557506560000000") };
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
public class A169815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169815Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A169815.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A169815.Bytes);
public BigInteger this[int i]=>Value[i];

public static A169815Inst Instance=new A169815Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169816
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,3L,12L,1L,11L,39L,11L,11L,116L,133L,12L,45L,449L,722L,169L,45L,996L,3857L,2832L,206L };
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
public class A169816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169816Inst : IEnumerable<long>
{
public static readonly long[] Value=A169816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169816.Bytes);
public long this[int i]=>Value[i];

public static A169816Inst Instance=new A169816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169817
{
public static readonly long[] Value={ 8L,9L,16L,19L,54L,77L,72L,71L,82L,72L,64L,66L,74L,79L,64L,63L,72L,77L,78L,93L,86L,88L,95L,102L,209L,218L,246L,245L,240L,258L,281L,278L,285L,304L,323L,238L,182L,187L,162L,142L,155L,136L,135L,124L,130L,139L,142L,138L,142L,134L,148L,166L,167L,174L,176L,168L,177L,174L };
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
public class A169817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169817Inst : IEnumerable<long>
{
public static readonly long[] Value=A169817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169817.Bytes);
public long this[int i]=>Value[i];

public static A169817Inst Instance=new A169817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169818
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,3L,2L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,2L,2L,2L,1L,3L,2L,2L,3L,2L,3L,2L,2L,2L,3L,3L,3L,2L,3L,2L,3L,2L,3L,2L,2L,2L,3L,3L,2L,2L,2L,2L,2L,2L,3L,3L,2L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,3L,3L };
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
public class A169818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169818Inst : IEnumerable<long>
{
public static readonly long[] Value=A169818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169818.Bytes);
public long this[int i]=>Value[i];

public static A169818Inst Instance=new A169818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169819
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,2L,4L,3L,5L,2L,6L,3L,5L,4L,7L,3L,8L,4L,7L,5L,4L,4L,8L,4L,6L,6L,7L,5L,9L,3L,7L,4L,6L,5L,9L,4L,7L,5L,9L,4L,9L,5L,6L,8L,7L,5L,10L,7L,7L,5L,7L,4L,10L,4L,11L,6L,7L,5L,13L,5L,6L,8L,9L,7L,8L,6L,9L,7L,9L,3L,13L,4L,6L,7L,9L,4L,11L,5L,11L,8L,6L,6L,13L,7L,8L,8L,8L,7L,13L,6L,8L,5L,7L,6L,13L,5L,10L,6L };
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
public class A169819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169819Inst : IEnumerable<long>
{
public static readonly long[] Value=A169819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169819.Bytes);
public long this[int i]=>Value[i];

public static A169819Inst Instance=new A169819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169820
{
public static readonly long[] Value={ 1L,2L,3L,1L,5L,3L,8L,1L,2L,5L,1L,3L,1L,1L,4L,1L,7L,2L,1L,1L,2L,1L,3L,1L,4L,1L,4L,1L,2L,3L,1L,3L,1L,2L,3L,1L,7L,1L,3L,2L,3L,4L,3L,1L,2L,10L,1L,2L,1L,2L,2L,3L,4L,4L,2L,2L,5L,3L,1L,3L,9L,2L,4L,1L,1L,4L,7L,3L,5L,2L,4L,1L,2L,1L,3L,7L,5L,8L,1L,1L,1L,2L,2L,3L,1L,5L,1L,3L,3L,8L,9L,3L,5L,3L,2L,2L,18L,2L,8L,4L };
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
public class A169820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169820Inst : IEnumerable<long>
{
public static readonly long[] Value=A169820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169820.Bytes);
public long this[int i]=>Value[i];

public static A169820Inst Instance=new A169820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169821
{
public static readonly long[] Value={ 0L,1L,4L,0L,7L,7L,0L,4L,1L,0L,100L,121L,144L,160L,187L,117L,130L,154L,171L,100L,400L,441L,484L,430L,477L,427L,460L,414L,451L,400L,0L,61L,34L,0L,67L,37L,0L,64L,31L,0L,700L,781L,774L,760L,757L,747L,730L,724L,711L,700L,700L,711L,724L,730L,747L,757L,760L,774L,781L,700L,0L,31L,64L };
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
public class A169821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169821Inst : IEnumerable<long>
{
public static readonly long[] Value=A169821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169821.Bytes);
public long this[int i]=>Value[i];

public static A169821Inst Instance=new A169821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169822
{
public static readonly long[] Value={ 1432L,1487L,1849L,2742L,5380L,5434L,6474L,6786L,9752L,10674L,12311L,14115L,14557L,15237L,17266L,17558L,18987L,19138L,19761L,20110L,20259L,20343L,20967L,20997L,22262L,22735L,24342L,25650L,26003L,26471L,27122L,27721L,28914L,28968L,29741L };
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
public class A169822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169822Inst : IEnumerable<long>
{
public static readonly long[] Value=A169822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169822.Bytes);
public long this[int i]=>Value[i];

public static A169822Inst Instance=new A169822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169823
{
public static readonly long[] Value={ 0L,60L,120L,180L,240L,300L,360L,420L,480L,540L,600L,660L,720L,780L,840L,900L,960L,1020L,1080L,1140L,1200L,1260L,1320L,1380L,1440L,1500L,1560L,1620L,1680L,1740L,1800L,1860L,1920L,1980L,2040L,2100L,2160L,2220L,2280L,2340L,2400L,2460L,2520L,2580L,2640L,2700L };
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
public class A169823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169823Inst : IEnumerable<long>
{
public static readonly long[] Value=A169823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169823.Bytes);
public long this[int i]=>Value[i];

public static A169823Inst Instance=new A169823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169824
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,20L,22L,30L,33L,40L,44L,50L,55L,60L,66L,70L,77L,80L,88L,90L,99L,100L,101L,110L,111L,121L,131L,141L,151L,161L,171L,181L,191L,200L,202L,212L,220L,222L,232L,242L,252L,262L,272L,282L,292L,300L,303L,313L,323L,330L,333L,343L,353L,363L,373L,383L,393L };
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
public class A169824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169824Inst : IEnumerable<long>
{
public static readonly long[] Value=A169824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169824.Bytes);
public long this[int i]=>Value[i];

public static A169824Inst Instance=new A169824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169825
{
public static readonly long[] Value={ 0L,420L,840L,1260L,1680L,2100L,2520L,2940L,3360L,3780L,4200L,4620L,5040L,5460L,5880L,6300L,6720L,7140L,7560L,7980L,8400L,8820L,9240L,9660L,10080L,10500L,10920L,11340L,11760L,12180L,12600L,13020L,13440L,13860L,14280L,14700L,15120L,15540L,15960L,16380L,16800L };
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
public class A169825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169825Inst : IEnumerable<long>
{
public static readonly long[] Value=A169825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169825.Bytes);
public long this[int i]=>Value[i];

public static A169825Inst Instance=new A169825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169826
{
public static readonly long[] Value={ 1L,2L,5L,8L,16L,27L,45L,69L,109L,171L,268L,404L,597L,860L,1215L };
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
public class A169826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169826Inst : IEnumerable<long>
{
public static readonly long[] Value=A169826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169826.Bytes);
public long this[int i]=>Value[i];

public static A169826Inst Instance=new A169826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169827
{
public static readonly long[] Value={ 0L,840L,1680L,2520L,3360L,4200L,5040L,5880L,6720L,7560L,8400L,9240L,10080L,10920L,11760L,12600L,13440L,14280L,15120L,15960L,16800L,17640L,18480L,19320L,20160L,21000L,21840L,22680L,23520L,24360L,25200L,26040L,26880L,27720L,28560L,29400L,30240L,31080L,31920L };
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
public class A169827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169827Inst : IEnumerable<long>
{
public static readonly long[] Value=A169827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169827.Bytes);
public long this[int i]=>Value[i];

public static A169827Inst Instance=new A169827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169828
{
public static readonly BigInteger[] Value={ 0L,1L,1002L,1003L,16495194L,16495195L,988496761674L,988496761675L,26688254956950L,26688254956951L,34018805387982L,34018805387983L,18069028755380465688UL,18069028755380465689UL,BigInteger.Parse("38281545036919307556"),BigInteger.Parse("38281545036919307557"),BigInteger.Parse("329813598438369669888"),BigInteger.Parse("329813598438369669889"),BigInteger.Parse("475572782847745049214"),BigInteger.Parse("475572782847745049215") };
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
public class A169828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169828Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A169828.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A169828.Bytes);
public BigInteger this[int i]=>Value[i];

public static A169828Inst Instance=new A169828Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169829
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,11L,77L,101L,131L,151L,181L,191L,313L,323L,353L,373L,383L,727L,757L,787L,797L,919L,929L,1001L,5005L,10301L,10501L,10601L,11311L,11411L,12421L,12721L,12821L,13331L,13831L,13931L,14341L,14741L,15451L,15551L,16061L,16361L,16561L,16661L };
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
public class A169829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169829Inst : IEnumerable<long>
{
public static readonly long[] Value=A169829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169829.Bytes);
public long this[int i]=>Value[i];

public static A169829Inst Instance=new A169829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169830
{
public static readonly BigInteger[] Value={ 1L,73L,793L,7993L,79993L,799993L,7999993L,79999993L,799999993L,7999999993L,79999999993L,799999999993L,7999999999993L,79999999999993L,799999999999993L,7999999999999993L,79999999999999993L,799999999999999993L,7999999999999999993L,BigInteger.Parse("79999999999999999993") };
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
public class A169830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169830Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A169830.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A169830.Bytes);
public BigInteger this[int i]=>Value[i];

public static A169830Inst Instance=new A169830Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169831
{
public static readonly long[] Value={ 1L,8L,25L,62L,139L,296L,613L,1250L,2527L,5084L,10201L,20438L,40915L,81872L,163789L,327626L,655303L,1310660L,2621377L,5242814L,10485691L,20971448L,41942965L,83886002L,167772079L,335544236L,671088553L,1342177190L,2684354467L,5368709024L,10737418141L,21474836378L };
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
public class A169831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169831Inst : IEnumerable<long>
{
public static readonly long[] Value=A169831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169831.Bytes);
public long this[int i]=>Value[i];

public static A169831Inst Instance=new A169831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169832
{
public static readonly long[] Value={ 0L,3L,26L,99L,282L,695L,1578L,3411L,7154L,14727L,29970L,60563L,121866L,244599L,490202L,981555L,1964418L,3930311L,7862274L,15726387L,31454810L,62911863L,125826186L,251655059L,503313042L,1006629255L,2013261938L,4026527571L,8053059114L,16106122487L,32212249530L };
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
public class A169832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169832Inst : IEnumerable<long>
{
public static readonly long[] Value=A169832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169832.Bytes);
public long this[int i]=>Value[i];

public static A169832Inst Instance=new A169832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169833
{
public static readonly long[] Value={ 2L,32L,170L,596L,1690L,4232L,9802L,21580L,45946L,95680L,196362L,399172L,806490L,1623096L,3258570L,6532092L,13082042L,26185200L,52395146L,104819060L,209671322L,419380712L,838804810L,1677658796L,3355373050L,6710808352L,13421686282L,26843450020L,53686985946L };
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
public class A169833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169833Inst : IEnumerable<long>
{
public static readonly long[] Value=A169833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169833.Bytes);
public long this[int i]=>Value[i];

public static A169833Inst Instance=new A169833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169834
{
public static readonly long[] Value={ 34L,86L,94L,142L,202L,214L,218L,231L,243L,244L,302L,375L,394L,446L,604L,634L,664L,698L,903L,922L,1042L,1106L,1138L,1262L,1275L,1310L,1335L,1346L,1402L,1642L,1762L,1833L,1838L,1886L,1894L,1925L,1942L,1982L,2014L,2055L,2102L,2134L,2182L,2218L,2265L,2306L,2344L,2362L };
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
public class A169834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169834Inst : IEnumerable<long>
{
public static readonly long[] Value=A169834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169834.Bytes);
public long this[int i]=>Value[i];

public static A169834Inst Instance=new A169834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169835
{
public static readonly long[] Value={ 1L,9L,36L,100L,225L,441L,784L,900L,1225L,1296L,2025L,3025L,4356L,6084L,7056L,8281L,11025L,14400L,18496L,23409L,29241L,32400L,36100L,41616L,44100L,53361L,64009L,76176L,88209L,90000L,105625L,108900L,123201L,142884L,164836L,189225L,216225L };
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
public class A169835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169835Inst : IEnumerable<long>
{
public static readonly long[] Value=A169835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169835.Bytes);
public long this[int i]=>Value[i];

public static A169835Inst Instance=new A169835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169836
{
public static readonly long[] Value={ 0L,36L,900L,1225L,7056L,32400L,41616L,44100L,88209L,108900L,298116L,705600L,1368900L,1413721L,1498176L,2924100L,5336100L,8643600L,8820900L,9217296L,10432900L,15210000L,24147396L,37088100L,48024900L,50893956L,50979600L,52490025L,55353600L,80568576L };
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
public class A169836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169836Inst : IEnumerable<long>
{
public static readonly long[] Value=A169836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169836.Bytes);
public long this[int i]=>Value[i];

public static A169836Inst Instance=new A169836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169837
{
public static readonly long[] Value={ 3L,6L,2L,4L,8L,10L,5L,15L,9L,12L,14L,7L,21L,18L,16L,20L,22L,11L,33L,24L,26L,13L,39L,27L,30L,25L,35L,28L,32L,34L,17L,51L,36L,38L,19L,57L,42L,40L,44L,46L,23L,69L,45L,48L,50L,52L,54L,56L,49L,63L,60L,55L,65L,70L,58L,29L,87L,66L,62L,31L,93L,72L,64L,68L,74L,37L,111L,75L,78L,76L,80L,82L,41L };
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
public class A169837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169837Inst : IEnumerable<long>
{
public static readonly long[] Value=A169837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169837.Bytes);
public long this[int i]=>Value[i];

public static A169837Inst Instance=new A169837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169838
{
public static readonly long[] Value={ 3L,1L,4L,7L,2L,12L,5L,9L,6L,18L,10L,22L,11L,8L,15L,31L,14L,35L,16L,13L,17L,41L,20L,26L,21L,24L,28L,56L,25L,60L,29L,19L,30L,27L,33L,66L,34L,23L,38L,73L,37L,80L,39L,43L,40L,88L,44L,49L,45L,32L,46L,99L,47L,52L,48L,36L,55L,106L,51L,114L,59L,50L,63L,53L,58L,127L,64L,42L,54L,133L,62L,137L,65L };
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
public class A169838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169838Inst : IEnumerable<long>
{
public static readonly long[] Value=A169838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169838.Bytes);
public long this[int i]=>Value[i];

public static A169838Inst Instance=new A169838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169839
{
public static readonly long[] Value={ 4L,2L,6L,3L,9L,12L,8L,10L,5L,15L,18L,14L,7L,21L,24L,16L,20L,22L,11L,33L,27L,30L,25L,35L,28L,26L,13L,39L,36L,32L,34L,17L,51L,42L,38L,19L,57L,45L,40L,44L,46L,23L,69L,48L,50L,52L,54L,56L,49L,63L,60L,55L,65L,70L,58L,29L,87L,66L,62L,31L,93L,72L,64L,68L,74L,37L,111L,75L,78L,76L,80L,82L,41L };
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
public class A169839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169839Inst : IEnumerable<long>
{
public static readonly long[] Value=A169839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169839.Bytes);
public long this[int i]=>Value[i];

public static A169839Inst Instance=new A169839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169840
{
public static readonly long[] Value={ 2L,4L,1L,9L,3L,13L,7L,5L,8L,19L,6L,27L,12L,10L,16L,32L,11L,36L,17L,14L,18L,42L,15L,23L,26L,21L,25L,56L,22L,60L,30L,20L,31L,24L,29L,66L,35L,28L,39L,73L,34L,80L,40L,38L,41L,88L,44L,49L,45L,33L,46L,99L,47L,52L,48L,37L,55L,106L,51L,114L,59L,50L,63L,53L,58L,127L,64L,43L,54L,133L,62L,137L,65L };
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
public class A169840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169840Inst : IEnumerable<long>
{
public static readonly long[] Value=A169840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169840.Bytes);
public long this[int i]=>Value[i];

public static A169840Inst Instance=new A169840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169841
{
public static readonly long[] Value={ 5L,10L,2L,4L,6L,3L,9L,12L,8L,14L,7L,21L,15L,18L,16L,20L,22L,11L,33L,24L,26L,13L,39L,27L,30L,25L,35L,28L,32L,34L,17L,51L,36L,38L,19L,57L,42L,40L,44L,46L,23L,69L,45L,48L,50L,52L,54L,56L,49L,63L,60L,55L,65L,70L,58L,29L,87L,66L,62L,31L,93L,72L,64L,68L,74L,37L,111L,75L,78L,76L,80L,82L,41L };
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
public class A169841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169841Inst : IEnumerable<long>
{
public static readonly long[] Value=A169841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169841.Bytes);
public long this[int i]=>Value[i];

public static A169841Inst Instance=new A169841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169842
{
public static readonly long[] Value={ 3L,6L,4L,1L,5L,11L,9L,7L,2L,18L,8L,22L,10L,13L,15L,31L,14L,35L,16L,12L,17L,41L,20L,26L,21L,24L,28L,56L,25L,60L,29L,19L,30L,27L,33L,66L,34L,23L,38L,73L,37L,80L,39L,43L,40L,88L,44L,49L,45L,32L,46L,99L,47L,52L,48L,36L,55L,106L,51L,114L,59L,50L,63L,53L,58L,127L,64L,42L,54L,133L,62L,137L,65L };
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
public class A169842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169842Inst : IEnumerable<long>
{
public static readonly long[] Value=A169842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169842.Bytes);
public long this[int i]=>Value[i];

public static A169842Inst Instance=new A169842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169843
{
public static readonly long[] Value={ 6L,2L,4L,8L,10L,5L,15L,3L,9L,12L,14L,7L,21L,18L,16L,20L,22L,11L,33L,24L,26L,13L,39L,27L,30L,25L,35L,28L,32L,34L,17L,51L,36L,38L,19L,57L,42L,40L,44L,46L,23L,69L,45L,48L,50L,52L,54L,56L,49L,63L,60L,55L,65L,70L,58L,29L,87L,66L,62L,31L,93L,72L,64L,68L,74L,37L,111L,75L,78L,76L,80L,82L,41L };
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
public class A169843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169843Inst : IEnumerable<long>
{
public static readonly long[] Value=A169843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169843.Bytes);
public long this[int i]=>Value[i];

public static A169843Inst Instance=new A169843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169844
{
public static readonly long[] Value={ 2L,8L,3L,6L,1L,12L,4L,9L,5L,18L,10L,22L,11L,7L,15L,31L,14L,35L,16L,13L,17L,41L,20L,26L,21L,24L,28L,56L,25L,60L,29L,19L,30L,27L,33L,66L,34L,23L,38L,73L,37L,80L,39L,43L,40L,88L,44L,49L,45L,32L,46L,99L,47L,52L,48L,36L,55L,106L,51L,114L,59L,50L,63L,53L,58L,127L,64L,42L,54L,133L,62L,137L,65L };
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
public class A169844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169844Inst : IEnumerable<long>
{
public static readonly long[] Value=A169844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169844.Bytes);
public long this[int i]=>Value[i];

public static A169844Inst Instance=new A169844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169845
{
public static readonly long[] Value={ 7L,14L,2L,4L,6L,3L,9L,12L,8L,10L,5L,15L,18L,16L,20L,22L,11L,33L,21L,24L,26L,13L,39L,27L,30L,25L,35L,28L,32L,34L,17L,51L,36L,38L,19L,57L,42L,40L,44L,46L,23L,69L,45L,48L,50L,52L,54L,56L,49L,63L,60L,55L,65L,70L,58L,29L,87L,66L,62L,31L,93L,72L,64L,68L,74L,37L,111L,75L,78L,76L,80L,82L,41L };
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
public class A169845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169845Inst : IEnumerable<long>
{
public static readonly long[] Value=A169845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169845.Bytes);
public long this[int i]=>Value[i];

public static A169845Inst Instance=new A169845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169846
{
public static readonly long[] Value={ 3L,6L,4L,11L,5L,1L,9L,7L,10L,17L,8L,22L,2L,12L,14L,31L,13L,35L,15L,19L,16L,41L,20L,26L,21L,24L,28L,56L,25L,60L,29L,18L,30L,27L,33L,66L,34L,23L,38L,73L,37L,80L,39L,43L,40L,88L,44L,49L,45L,32L,46L,99L,47L,52L,48L,36L,55L,106L,51L,114L,59L,50L,63L,53L,58L,127L,64L,42L,54L,133L,62L,137L,65L };
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
public class A169846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169846Inst : IEnumerable<long>
{
public static readonly long[] Value=A169846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169846.Bytes);
public long this[int i]=>Value[i];

public static A169846Inst Instance=new A169846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169847
{
public static readonly long[] Value={ 8L,2L,4L,6L,3L,9L,12L,10L,5L,15L,18L,14L,7L,21L,24L,16L,20L,22L,11L,33L,27L,30L,25L,35L,28L,26L,13L,39L,36L,32L,34L,17L,51L,42L,38L,19L,57L,45L,40L,44L,46L,23L,69L,48L,50L,52L,54L,56L,49L,63L,60L,55L,65L,70L,58L,29L,87L,66L,62L,31L,93L,72L,64L,68L,74L,37L,111L,75L,78L,76L,80L,82L,41L };
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
public class A169847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169847Inst : IEnumerable<long>
{
public static readonly long[] Value=A169847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169847.Bytes);
public long this[int i]=>Value[i];

public static A169847Inst Instance=new A169847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169848
{
public static readonly long[] Value={ 2L,5L,3L,9L,4L,13L,1L,6L,8L,19L,7L,27L,12L,10L,16L,32L,11L,36L,17L,14L,18L,42L,15L,23L,26L,21L,25L,56L,22L,60L,30L,20L,31L,24L,29L,66L,35L,28L,39L,73L,34L,80L,40L,38L,41L,88L,44L,49L,45L,33L,46L,99L,47L,52L,48L,37L,55L,106L,51L,114L,59L,50L,63L,53L,58L,127L,64L,43L,54L,133L,62L,137L,65L };
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
public class A169848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169848Inst : IEnumerable<long>
{
public static readonly long[] Value=A169848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169848.Bytes);
public long this[int i]=>Value[i];

public static A169848Inst Instance=new A169848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169849
{
public static readonly long[] Value={ 9L,3L,6L,2L,4L,8L,10L,5L,15L,12L,14L,7L,21L,18L,16L,20L,22L,11L,33L,24L,26L,13L,39L,27L,30L,25L,35L,28L,32L,34L,17L,51L,36L,38L,19L,57L,42L,40L,44L,46L,23L,69L,45L,48L,50L,52L,54L,56L,49L,63L,60L,55L,65L,70L,58L,29L,87L,66L,62L,31L,93L,72L,64L,68L,74L,37L,111L,75L,78L,76L,80L,82L,41L };
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
public class A169849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169849Inst : IEnumerable<long>
{
public static readonly long[] Value=A169849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169849.Bytes);
public long this[int i]=>Value[i];

public static A169849Inst Instance=new A169849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169850
{
public static readonly long[] Value={ 4L,2L,5L,8L,3L,12L,6L,1L,7L,18L,10L,22L,11L,9L,15L,31L,14L,35L,16L,13L,17L,41L,20L,26L,21L,24L,28L,56L,25L,60L,29L,19L,30L,27L,33L,66L,34L,23L,38L,73L,37L,80L,39L,43L,40L,88L,44L,49L,45L,32L,46L,99L,47L,52L,48L,36L,55L,106L,51L,114L,59L,50L,63L,53L,58L,127L,64L,42L,54L,133L,62L,137L,65L };
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
public class A169850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169850Inst : IEnumerable<long>
{
public static readonly long[] Value=A169850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169850.Bytes);
public long this[int i]=>Value[i];

public static A169850Inst Instance=new A169850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169851
{
public static readonly long[] Value={ 10L,2L,4L,6L,3L,9L,12L,8L,14L,7L,21L,15L,5L,20L,16L,18L,22L,11L,33L,24L,26L,13L,39L,27L,30L,25L,35L,28L,32L,34L,17L,51L,36L,38L,19L,57L,42L,40L,44L,46L,23L,69L,45L,48L,50L,52L,54L,56L,49L,63L,60L,55L,65L,70L,58L,29L,87L,66L,62L,31L,93L,72L,64L,68L,74L,37L,111L,75L,78L,76L,80L,82L,41L };
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
public class A169851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169851Inst : IEnumerable<long>
{
public static readonly long[] Value=A169851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169851.Bytes);
public long this[int i]=>Value[i];

public static A169851Inst Instance=new A169851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169852
{
public static readonly long[] Value={ 2L,5L,3L,13L,4L,10L,8L,6L,1L,18L,7L,22L,9L,12L,15L,31L,16L,35L,14L,11L,17L,41L,20L,26L,21L,24L,28L,56L,25L,60L,29L,19L,30L,27L,33L,66L,34L,23L,38L,73L,37L,80L,39L,43L,40L,88L,44L,49L,45L,32L,46L,99L,47L,52L,48L,36L,55L,106L,51L,114L,59L,50L,63L,53L,58L,127L,64L,42L,54L,133L,62L,137L,65L };
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
public class A169852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169852Inst : IEnumerable<long>
{
public static readonly long[] Value=A169852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169852.Bytes);
public long this[int i]=>Value[i];

public static A169852Inst Instance=new A169852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169853
{
public static readonly long[] Value={ 11L,22L,2L,4L,6L,3L,9L,12L,8L,10L,5L,15L,18L,14L,7L,21L,24L,16L,20L,25L,30L,26L,13L,39L,27L,33L,36L,28L,32L,34L,17L,51L,42L,35L,40L,38L,19L,57L,45L,48L,44L,46L,23L,69L,54L,50L,52L,56L,49L,63L,60L,55L,65L,70L,58L,29L,87L,66L,62L,31L,93L,72L,64L,68L,74L,37L,111L,75L,78L,76L,80L,82L,41L };
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
public class A169853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169853Inst : IEnumerable<long>
{
public static readonly long[] Value=A169853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169853.Bytes);
public long this[int i]=>Value[i];

public static A169853Inst Instance=new A169853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169854
{
public static readonly long[] Value={ 3L,6L,4L,11L,5L,15L,9L,7L,10L,1L,8L,23L,14L,12L,18L,31L,13L,37L,19L,16L,2L,43L,17L,20L,22L,25L,28L,56L,21L,60L,29L,26L,30L,34L,27L,66L,36L,24L,35L,73L,33L,80L,41L,39L,42L,88L,40L,49L,46L,32L,47L,99L,45L,52L,48L,38L,55L,106L,51L,114L,59L,50L,63L,53L,58L,127L,64L,44L,54L,133L,62L,137L,65L };
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
public class A169854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169854Inst : IEnumerable<long>
{
public static readonly long[] Value=A169854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169854.Bytes);
public long this[int i]=>Value[i];

public static A169854Inst Instance=new A169854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169855
{
public static readonly long[] Value={ 12L,2L,4L,6L,3L,9L,15L,5L,10L,8L,14L,7L,21L,18L,16L,20L,22L,11L,33L,24L,26L,13L,39L,27L,30L,25L,35L,28L,32L,34L,17L,51L,36L,38L,19L,57L,42L,40L,44L,46L,23L,69L,45L,48L,50L,52L,54L,56L,49L,63L,60L,55L,65L,70L,58L,29L,87L,66L,62L,31L,93L,72L,64L,68L,74L,37L,111L,75L,78L,76L,80L,82L,41L };
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
public class A169855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169855Inst : IEnumerable<long>
{
public static readonly long[] Value=A169855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169855.Bytes);
public long this[int i]=>Value[i];

public static A169855Inst Instance=new A169855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169856
{
public static readonly long[] Value={ 2L,5L,3L,8L,4L,12L,10L,6L,9L,18L,1L,22L,11L,7L,15L,31L,14L,35L,16L,13L,17L,41L,20L,26L,21L,24L,28L,56L,25L,60L,29L,19L,30L,27L,33L,66L,34L,23L,38L,73L,37L,80L,39L,43L,40L,88L,44L,49L,45L,32L,46L,99L,47L,52L,48L,36L,55L,106L,51L,114L,59L,50L,63L,53L,58L,127L,64L,42L,54L,133L,62L,137L,65L };
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
public class A169856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169856Inst : IEnumerable<long>
{
public static readonly long[] Value=A169856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169856.Bytes);
public long this[int i]=>Value[i];

public static A169856Inst Instance=new A169856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169857
{
public static readonly long[] Value={ 0L,44L,3L,44L,44L,44L,8L,44L,44L,48L,44L,44L,44L,18L,17L,58L,18L,51L,18L,44L,48L,62L,48L,44L,47L,44L,48L,82L,48L,90L,31L,48L,65L,44L,48L,101L,71L,47L,48L,116L,48L,129L,41L,39L,87L,135L,48L,65L,46L,65L,47L,148L,48L,104L,58L,71L,105L,168L,104L,187L,121L,69L,64L,69L };
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
public class A169857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169857Inst : IEnumerable<long>
{
public static readonly long[] Value=A169857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169857.Bytes);
public long this[int i]=>Value[i];

public static A169857Inst Instance=new A169857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169858
{
public static readonly long[] Value={ 1L,2L,6L,12L,45L,60L,245L,245L,504L,504L,5049L,5049L,10296L,11760L,11760L,11760L,56160L,56160L,198016L,198016L,1008159L,1323008L,2340849L,6240366L,13442580L,13442580L,37536408L,37536408L,75432065L,75432065L,180092645L,319800096L,319800096L,800640126L,2201169600L,2201169600L,3780487275L,5250966084L,5250966084L,6832425609L,36960308625L,36960308625L,62244072512L,62244072512L,62244072512L,62244072512L,372960042489L,372960042489L };
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
public class A169858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169858Inst : IEnumerable<long>
{
public static readonly long[] Value=A169858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169858.Bytes);
public long this[int i]=>Value[i];

public static A169858Inst Instance=new A169858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169859
{
public static readonly long[] Value={ 1L,144L,1444L,1666681L,111112681L,3333330225L,132922222225L,1433333333961L,2582708888888881L,28777777777780164L,88888888888905609L,2222222222222640225L,2222222222222640225L };
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
public class A169859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169859Inst : IEnumerable<long>
{
public static readonly long[] Value=A169859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169859.Bytes);
public long this[int i]=>Value[i];

public static A169859Inst Instance=new A169859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169860
{
public static readonly long[] Value={ 0L,25L,50L,76L,101L,127L,152L,177L,203L,228L,254L,279L,304L,330L,355L,381L,406L,431L,457L,482L,508L,533L,558L,584L,609L,635L,660L,685L,711L,736L,762L,787L,812L,838L,863L,889L,914L,939L,965L,990L,1016L,1041L,1066L,1092L,1117L,1143L,1168L,1193L,1219L,1244L };
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
public class A169860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169860Inst : IEnumerable<long>
{
public static readonly long[] Value=A169860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169860.Bytes);
public long this[int i]=>Value[i];

public static A169860Inst Instance=new A169860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169861
{
public static readonly long[] Value={ 0L,26L,51L,77L,102L,127L,153L,178L,204L,229L,254L,280L,305L,331L,356L,381L,407L,432L,458L,483L,534L,559L,585L,610L,635L,661L,686L,712L,737L,762L,788L,813L,839L,864L,889L,915L,940L,966L,1016L,1042L,1067L,1093L,1118L,1143L,1169L,1194L,1220L,1245L };
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
public class A169861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169861Inst : IEnumerable<long>
{
public static readonly long[] Value=A169861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169861.Bytes);
public long this[int i]=>Value[i];

public static A169861Inst Instance=new A169861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169862
{
public static readonly long[] Value={ 3L,2L,9L,3L,1L,6L,6L,2L,8L,7L,4L,1L,1L,8L,6L,1L,0L,3L,1L,5L,0L,8L,0L,2L,8L,2L,9L,1L,2L,5L,0L,8L,0L,5L,8L,6L,4L,3L,7L,2L,2L,5L,7L,2L,9L,0L,3L,2L,7L,1L,2L,1L,2L,4L,8L,5L,3L,7L,7L,1L,0L,3L,9L,6L,1L,6L,8L,5L,0L,6L,4L,8L,8L,0L,0L,9L,1L,5L,7L,7L,4L,3L,6L,2L,9L,0L,4L,2L,0L,1L,3L,8L,0L,4L,8L,2L,8L,2L,5L,6L,6L,1L };
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
public class A169862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169862Inst : IEnumerable<long>
{
public static readonly long[] Value=A169862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169862.Bytes);
public long this[int i]=>Value[i];

public static A169862Inst Instance=new A169862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A169863
{
public static readonly long[] Value={ 3L,6L,8L,10L,13L,15L,17L,19L,22L,24L,26L,28L,30L,32L,35L,37L,39L,41L,43L,45L,47L,49L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,116L,118L,120L,123L };
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
public class A169863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A169863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A169863Inst : IEnumerable<long>
{
public static readonly long[] Value=A169863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A169863.Bytes);
public long this[int i]=>Value[i];

public static A169863Inst Instance=new A169863Inst();

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