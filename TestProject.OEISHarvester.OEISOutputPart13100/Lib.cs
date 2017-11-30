using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A092076
{
public static readonly long[] Value={ 1L,1L,1L,7L,7L,7L,19L,19L,19L,37L,37L,37L,61L,61L,61L,91L,91L,91L,127L,127L,127L,169L,169L,169L,217L,217L,217L,271L,271L,271L,331L,331L,331L,397L,397L,397L,469L,469L,469L,547L,547L,547L,631L,631L,631L,721L,721L,721L,817L,817L,817L,919L,919L,919L,1027L,1027L,1027L,1141L,1141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092076Inst : IEnumerable<long>
{
public static readonly long[] Value=A092076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092076.Bytes);
public long this[int i]=>Value[i];

public static A092076Inst Instance=new A092076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092075
{
public static readonly long[] Value={ 2L,3L,4L,8L,13L,32L,41L,45L,59L,97L,107L,364L,421L,444L,1164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092075Inst : IEnumerable<long>
{
public static readonly long[] Value=A092075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092075.Bytes);
public long this[int i]=>Value[i];

public static A092075Inst Instance=new A092075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092074
{
public static readonly long[] Value={ 3L,37L,71L,139L,173L,241L,479L,547L,683L,751L,853L,887L,1091L,1193L,1499L,1567L,1601L,1669L,1873L,1907L,2111L,2179L,2213L,2281L,2383L,2417L,2621L,2689L,2791L,2927L,3301L,3539L,3607L,3709L,3947L,4049L,4219L,4253L,4423L,4457L,4729L,4831L,4933L,4967L,5171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092074Inst : IEnumerable<long>
{
public static readonly long[] Value=A092074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092074.Bytes);
public long this[int i]=>Value[i];

public static A092074Inst Instance=new A092074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092073
{
public static readonly long[] Value={ 1L,2L,4L,10L,30L,101L,395L,1769L,9020L,51674L,328936L,2303323L,17595765L,145622477L,1297884212L,12393874652L,126242962310L,1366268975165L,15656289178423L,189374961382141L,2411196896699700L,32235328003898918L,451476237890591144L,6610630095177242675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092073Inst : IEnumerable<long>
{
public static readonly long[] Value=A092073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092073.Bytes);
public long this[int i]=>Value[i];

public static A092073Inst Instance=new A092073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092072
{
public static readonly long[] Value={ 1L,1L,7L,42L,208L,894L,3146L,9371L,24621L,58396L,127338L,259253L,498222L,911351L,1598066L,2701014L,4419940L,7029349L,10898668L,16516900L,24522640L,35737692L,51207017L,72245749L,100491392L,137964064L,187136346L,251009565L,333200503L,438040309L,570681389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092072Inst : IEnumerable<long>
{
public static readonly long[] Value=A092072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092072.Bytes);
public long this[int i]=>Value[i];

public static A092072Inst Instance=new A092072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092071
{
public static readonly long[] Value={ 1L,1L,2L,8L,27L,71L,197L,482L,1060L,2241L,4429L,8241L,14788L,25473L,42288L,68302L,107329L,164450L,246870L,363341L,525037L,746901L,1046759L,1446661L,1974912L,2664696L,3556123L,4699051L,6151182L,7980924L,10271230L,13117013L,16629061L,20939082L,26196340L,32572742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092071Inst : IEnumerable<long>
{
public static readonly long[] Value=A092071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092071.Bytes);
public long this[int i]=>Value[i];

public static A092071Inst Instance=new A092071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092070
{
public static readonly long[] Value={ 1L,2L,13L,87L,472L,2099L,7651L,23632L,64007L,155869L,347888L,722562L,1412787L,2623960L,4663042L,7975064L,13188959L,21174366L,33109962L,50565794L,75601497L,110881127L,159807508L,226678408L,316865230L,437017617L,595296931L,801638887L,1068049576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092070Inst : IEnumerable<long>
{
public static readonly long[] Value=A092070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092070.Bytes);
public long this[int i]=>Value[i];

public static A092070Inst Instance=new A092070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092069
{
public static readonly long[] Value={ 1L,1L,1L,11L,35L,70L,278L,765L,1526L,3774L,8105L,14633L,28560L,51983L,85609L,145591L,237609L,364095L,565831L,855788L,1240383L,1808777L,2587237L,3590112L,4992854L,6844101L,9172450L,12296446L,16300139L,21235896L,27646466L,35669378L,45394358L,57699934L,72801345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092069Inst : IEnumerable<long>
{
public static readonly long[] Value=A092069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092069.Bytes);
public long this[int i]=>Value[i];

public static A092069Inst Instance=new A092069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092068
{
public static readonly long[] Value={ 18L,51L,53L,84L,95L,100L,104L,106L,143L,178L,180L,181L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092068Inst : IEnumerable<long>
{
public static readonly long[] Value=A092068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092068.Bytes);
public long this[int i]=>Value[i];

public static A092068Inst Instance=new A092068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092003
{
public static readonly long[] Value={ 1848L,3360L,4368L,7392L,16632L,19320L,26520L,28560L,32760L,34320L,36960L,38760L,44520L,52080L,54600L,57720L,62040L,65208L,68880L,69960L,73920L,75768L,78120L,79560L,82992L,83160L,86520L,89760L,95760L,106080L,108240L,108528L,115368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092003Inst : IEnumerable<long>
{
public static readonly long[] Value=A092003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092003.Bytes);
public long this[int i]=>Value[i];

public static A092003Inst Instance=new A092003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092002
{
public static readonly long[] Value={ 840L,1320L,1680L,2520L,3192L,3432L,4920L,5208L,5280L,5712L,6552L,6888L,9360L,11928L,16008L,19152L,19992L,25200L,29568L,31080L,35880L,38280L,38640L,40920L,41832L,45240L,47880L,48360L,48720L,51240L,51480L,53040L,56280L,57288L,61320L,63240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092002Inst : IEnumerable<long>
{
public static readonly long[] Value=A092002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092002.Bytes);
public long this[int i]=>Value[i];

public static A092002Inst Instance=new A092002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092001
{
public static readonly long[] Value={ 1560L,2640L,3120L,4200L,5928L,6072L,6840L,7560L,7800L,10080L,10560L,11400L,11760L,12240L,12600L,13440L,15288L,15600L,15840L,17808L,20592L,20832L,21120L,21528L,21912L,22848L,25680L,25872L,26208L,27840L,29232L,29400L,29640L,30192L,30240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092001Inst : IEnumerable<long>
{
public static readonly long[] Value=A092001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092001.Bytes);
public long this[int i]=>Value[i];

public static A092001Inst Instance=new A092001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092000
{
public static readonly long[] Value={ 240L,792L,912L,1248L,2040L,2280L,2760L,3528L,3720L,3960L,4080L,4440L,4680L,4872L,5160L,5520L,5880L,6600L,6720L,6960L,7080L,8520L,8568L,8760L,9072L,9120L,9672L,9912L,10248L,10440L,11088L,11592L,11832L,11880L,12408L,12480L,12720L,13200L,13560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092000Inst : IEnumerable<long>
{
public static readonly long[] Value=A092000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092000.Bytes);
public long this[int i]=>Value[i];

public static A092000Inst Instance=new A092000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091999
{
public static readonly long[] Value={ 2L,10L,14L,22L,26L,34L,38L,46L,50L,58L,62L,70L,74L,82L,86L,94L,98L,106L,110L,118L,122L,130L,134L,142L,146L,154L,158L,166L,170L,178L,182L,190L,194L,202L,206L,214L,218L,226L,230L,238L,242L,250L,254L,262L,266L,274L,278L,286L,290L,298L,302L,310L,314L,322L,326L,334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091999Inst : IEnumerable<long>
{
public static readonly long[] Value=A091999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091999.Bytes);
public long this[int i]=>Value[i];

public static A091999Inst Instance=new A091999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091998
{
public static readonly long[] Value={ 1L,11L,13L,23L,25L,35L,37L,47L,49L,59L,61L,71L,73L,83L,85L,95L,97L,107L,109L,119L,121L,131L,133L,143L,145L,155L,157L,167L,169L,179L,181L,191L,193L,203L,205L,215L,217L,227L,229L,239L,241L,251L,253L,263L,265L,275L,277L,287L,289L,299L,301L,311L,313L,323L,325L,335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091998Inst : IEnumerable<long>
{
public static readonly long[] Value=A091998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091998.Bytes);
public long this[int i]=>Value[i];

public static A091998Inst Instance=new A091998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091997
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,12L,19L,35L,39L,44L,56L,65L,77L,95L,104L,144L,207L,217L,307L,325L,392L,459L,471L,828L,1275L,3277L,4205L,5135L,7560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091997Inst : IEnumerable<long>
{
public static readonly long[] Value=A091997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091997.Bytes);
public long this[int i]=>Value[i];

public static A091997Inst Instance=new A091997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091996
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,11L,22L,32L,50L,55L,80L,106L,155L,172L,208L,235L,391L,436L,470L,776L,1558L,1675L,2795L,2908L,2947L,3970L,4004L,5774L,6248L,11278L,11824L,17824L,41708L,51530L,92500L,137930L,192122L,242488L,251947L,414355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091996Inst : IEnumerable<long>
{
public static readonly long[] Value=A091996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091996.Bytes);
public long this[int i]=>Value[i];

public static A091996Inst Instance=new A091996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091995
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,6L,8L,11L,9L,12L,16L,10L,13L,17L,22L,14L,18L,23L,29L,15L,19L,24L,30L,37L,20L,25L,31L,38L,46L,21L,26L,32L,39L,47L,56L,27L,33L,40L,48L,57L,67L,28L,34L,41L,49L,58L,68L,79L,35L,42L,50L,59L,69L,80L,92L,36L,43L,51L,60L,70L,81L,93L,106L,44L,52L,61L,71L,82L,94L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091995Inst : IEnumerable<long>
{
public static readonly long[] Value=A091995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091995.Bytes);
public long this[int i]=>Value[i];

public static A091995Inst Instance=new A091995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091994
{
public static readonly BigInteger[] Value={ 1L,29L,1403L,95115L,8298105L,885611805L,111797745795L,16298030927115L,2694941727973425L,498439798319375325L,BigInteger.Parse("101970858789466224075"),BigInteger.Parse("22865056868419298361675"),BigInteger.Parse("5576927510911134523293225") };
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
public class A091994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091994Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091994.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091994.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091994Inst Instance=new A091994Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091993
{
public static readonly BigInteger[] Value={ 1L,28L,1308L,85632L,7215504L,743895360L,90735698880L,12784048058880L,2043605420478720L,365523503117552640L,BigInteger.Parse("72341521311159475200"),BigInteger.Parse("15698552277109576089600"),BigInteger.Parse("3707121435080668435353600") };
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
public class A091993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091993Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091993.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091993.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091993Inst Instance=new A091993Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091992
{
public static readonly long[] Value={ 2L,4L,8L,10L,14L,20L,22L,32L,34L,46L,52L,56L,62L,70L,74L,92L,112L,118L,122L,130L,136L,146L,172L,176L,190L,196L,218L,220L,224L,238L,244L,256L,260L,274L,286L,290L,298L,322L,332L,350L,356L,374L,382L,398L,400L,428L,442L,448L,454L,458L,476L,484L,494L,532L,536L,538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091992Inst : IEnumerable<long>
{
public static readonly long[] Value=A091992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091992.Bytes);
public long this[int i]=>Value[i];

public static A091992Inst Instance=new A091992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091991
{
public static readonly long[] Value={ 1L,0L,0L,2L,0L,1L,0L,1L,1L,2L,0L,2L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,0L,2L,1L,1L,1L,4L,0L,1L,0L,2L,1L,2L,1L,1L,0L,2L,1L,2L,0L,2L,0L,1L,1L,3L,0L,1L,1L,1L,1L,2L,0L,1L,2L,1L,3L,3L,0L,3L,0L,2L,1L,3L,1L,2L,0L,1L,1L,2L,0L,2L,0L,1L,1L,2L,1L,1L,0L,2L,1L,2L,0L,3L,1L,1L,2L,2L,0L,1L,2L,2L,2L,2L,1L,1L,0L,1L,1L,2L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091991Inst : IEnumerable<long>
{
public static readonly long[] Value=A091991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091991.Bytes);
public long this[int i]=>Value[i];

public static A091991Inst Instance=new A091991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091990
{
public static readonly long[] Value={ 1L,2L,10L,140L,185L,28490L,3568L,4117006L,68166L,695025466L,1324149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091990Inst : IEnumerable<long>
{
public static readonly long[] Value=A091990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091990.Bytes);
public long this[int i]=>Value[i];

public static A091990Inst Instance=new A091990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091989
{
public static readonly long[] Value={ 12L,14L,17L,23L,26L,27L,32L,46L,47L,50L,53L,59L,60L,64L,70L,71L,72L,79L,81L,95L,96L,101L,105L,110L,112L,115L,117L,122L,123L,126L,135L,138L,142L,144L,153L,156L,163L,165L,168L,177L,180L,184L,191L,200L,203L,204L,205L,206L,208L,217L,218L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091989Inst : IEnumerable<long>
{
public static readonly long[] Value=A091989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091989.Bytes);
public long this[int i]=>Value[i];

public static A091989Inst Instance=new A091989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091988
{
public static readonly long[] Value={ 1L,2L,4L,5L,5L,6L,6L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,18L,18L,18L,18L,18L,19L,19L,19L,19L,19L,20L,20L,20L,20L,20L,20L,21L,21L,21L,21L,21L,22L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091988Inst : IEnumerable<long>
{
public static readonly long[] Value=A091988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091988.Bytes);
public long this[int i]=>Value[i];

public static A091988Inst Instance=new A091988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091971
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,2L,2L,1L,3L,4L,4L,5L,5L,6L,8L,9L,9L,10L,12L,13L,15L,16L,16L,19L,21L,22L,24L,25L,27L,30L,32L,33L,35L,38L,40L,43L,45L,46L,50L,53L,55L,58L,60L,63L,67L,70L,72L,75L,79L,82L,86L,89L,91L,96L,100L,103L,107L,110L,114L,119L,123L,126L,130L,135L,139L,144L,148L,151L,157L,162L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091971Inst : IEnumerable<long>
{
public static readonly long[] Value=A091971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091971.Bytes);
public long this[int i]=>Value[i];

public static A091971Inst Instance=new A091971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091970
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,1L,1L,2L,0L,0L,1L,0L,0L,1L,1L,1L,1L,2L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,2L,0L,0L,1L,0L,0L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,2L,0L,0L,1L,0L,0L,1L,1L,1L,1L,2L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,2L,0L,0L,1L,0L,0L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091970Inst : IEnumerable<long>
{
public static readonly long[] Value=A091970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091970.Bytes);
public long this[int i]=>Value[i];

public static A091970Inst Instance=new A091970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091969
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,28L,550L,28456L,4134861L,1781622569L,2407100396065L,10660643722901700L,BigInteger.Parse("159393017165624876022"),BigInteger.Parse("8189716815725538561261887") };
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
public class A091969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091969Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091969.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091969.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091969Inst Instance=new A091969Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091968
{
public static readonly long[] Value={ 3L,19L,67L,83L,131L,163L,179L,211L,227L,307L,419L,467L,499L,547L,563L,643L,659L,691L,739L,787L,883L,947L,1091L,1123L,1171L,1187L,1283L,1427L,1459L,1523L,1571L,1619L,1667L,1699L,1747L,1811L,1907L,1987L,2003L,2083L,2099L,2131L,2179L,2243L,2339L,2371L,2467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091968Inst : IEnumerable<long>
{
public static readonly long[] Value=A091968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091968.Bytes);
public long this[int i]=>Value[i];

public static A091968Inst Instance=new A091968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091967
{
public static readonly BigInteger[] Value={ 0L,2L,1L,0L,2L,3L,0L,6L,6L,4L,44L,1L,180L,42L,16L,1096L,7652L,13781L,8L,24000L,119779L,458561L,BigInteger.Parse("152116956851941670912"),1054535L,-53L,26L,27L,59L,4806078L,2L,35792568L,3010349L,BigInteger.Parse("2387010102192469724605148123694256128"),2L,0L,-53L,43L,0L,-4097L,173L,37338L,BigInteger.Parse("111111111111111111111111111111111111111111"),30402457L,413927966L };
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
public class A091967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091967Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091967.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091967.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091967Inst Instance=new A091967Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091966
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,9L,5L,27L,7L,30L,8L,25L,3L,3L,3L,3L,3L,6L,9L,27L,52L,43L,8L,19L,17L,97L,56L,24L,193L,131L,24L,27L,128L,87L,7L,10L,17L,118L,111L,116L,38L,26L,9L,104L,36L,61L,24L,13L,60L,17L,37L,10L,21L,140L,48L,48L,13L,19L,243L,8L,33L,25L,171L,25L,18L,20L,20L,5L,5L,5L,5L,90L,55L,47L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091966Inst : IEnumerable<long>
{
public static readonly long[] Value=A091966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091966.Bytes);
public long this[int i]=>Value[i];

public static A091966Inst Instance=new A091966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091965
{
public static readonly long[] Value={ 1L,3L,1L,10L,6L,1L,36L,29L,9L,1L,137L,132L,57L,12L,1L,543L,590L,315L,94L,15L,1L,2219L,2628L,1629L,612L,140L,18L,1L,9285L,11732L,8127L,3605L,1050L,195L,21L,1L,39587L,52608L,39718L,19992L,6950L,1656L,259L,24L,1L,171369L,237129L,191754L,106644L,42498L,12177L,2457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091965Inst : IEnumerable<long>
{
public static readonly long[] Value=A091965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091965.Bytes);
public long this[int i]=>Value[i];

public static A091965Inst Instance=new A091965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091964
{
public static readonly long[] Value={ 1L,2L,4L,9L,21L,50L,121L,296L,730L,1812L,4521L,11328L,28485L,71844L,181674L,460443L,1169283L,2974574L,7578937L,19337489L,49401526L,126350742L,323495259L,829033334L,2126454271L,5458711430L,14023219126L,36049991901L,92734505565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091964Inst : IEnumerable<long>
{
public static readonly long[] Value=A091964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091964.Bytes);
public long this[int i]=>Value[i];

public static A091964Inst Instance=new A091964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091963
{
public static readonly long[] Value={ 2L,3L,2L,5L,2L,7L,2L,3L,2L,11L,3L,13L,2L,3L,2L,17L,2L,19L,4L,3L,2L,23L,3L,5L,2L,3L,4L,29L,6L,31L,2L,3L,2L,5L,4L,37L,2L,3L,5L,41L,6L,43L,4L,3L,2L,47L,3L,7L,2L,3L,4L,53L,2L,5L,7L,3L,2L,59L,4L,61L,2L,7L,2L,5L,6L,67L,4L,3L,10L,71L,4L,73L,2L,3L,4L,7L,2L,79L,5L,3L,2L,83L,12L,5L,2L,3L,4L,89L,9L,7L,4L,3L,2L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091963Inst : IEnumerable<long>
{
public static readonly long[] Value=A091963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091963.Bytes);
public long this[int i]=>Value[i];

public static A091963Inst Instance=new A091963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091962
{
public static readonly long[] Value={ 0L,1L,42L,594L,4719L,26026L,111384L,395352L,1215126L,3331251L,8321170L,19240650L,41683005L,85408596L,166768096L,312203232L,563178924L,982981701L,1665911754L,2749500754L,4430505387L,6985558206L,10797503640L,16388608600L,24462014850L,35952994935L,52091785746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091962Inst : IEnumerable<long>
{
public static readonly long[] Value=A091962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091962.Bytes);
public long this[int i]=>Value[i];

public static A091962Inst Instance=new A091962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091961
{
public static readonly long[] Value={ 9L,37L,38L,43L,54L,68L,76L,80L,93L,100L,111L,121L,139L,141L,149L,162L,169L,170L,181L,196L,197L,212L,214L,224L,232L,246L,248L,257L,265L,267L,268L,299L,304L,305L,320L,330L,337L,348L,351L,356L,364L,368L,374L,375L,383L,406L,417L,433L,441L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091961Inst : IEnumerable<long>
{
public static readonly long[] Value=A091961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091961.Bytes);
public long this[int i]=>Value[i];

public static A091961Inst Instance=new A091961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091960
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,6L,7L,8L,8L,9L,10L,11L,11L,12L,13L,14L,14L,15L,15L,16L,17L,18L,18L,19L,20L,21L,22L,23L,23L,24L,25L,26L,26L,27L,27L,28L,29L,30L,31L,32L,32L,33L,34L,35L,35L,36L,36L,37L,38L,39L,39L,40L,41L,42L,42L,43L,44L,45L,46L,47L,47L,48L,49L,50L,50L,51L,51L,52L,53L,54L,55L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091960Inst : IEnumerable<long>
{
public static readonly long[] Value=A091960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091960.Bytes);
public long this[int i]=>Value[i];

public static A091960Inst Instance=new A091960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091959
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,0L,1L,0L,1L,0L,1L,1L,3L,0L,1L,1L,3L,0L,1L,1L,3L,0L,1L,0L,1L,0L,1L,1L,3L,0L,1L,0L,1L,0L,1L,1L,3L,0L,1L,0L,1L,0L,1L,1L,3L,0L,1L,1L,3L,0L,1L,1L,3L,0L,1L,0L,1L,0L,1L,1L,3L,0L,1L,1L,3L,0L,1L,1L,3L,0L,1L,0L,1L,0L,1L,1L,3L,0L,1L,1L,3L,0L,1L,1L,3L,0L,1L,0L,1L,0L,1L,1L,3L,0L,1L,0L,1L,0L,1L,1L,3L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091959Inst : IEnumerable<long>
{
public static readonly long[] Value=A091959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091959.Bytes);
public long this[int i]=>Value[i];

public static A091959Inst Instance=new A091959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091958
{
public static readonly long[] Value={ 1L,1L,2L,4L,1L,9L,5L,21L,21L,51L,78L,3L,127L,274L,28L,323L,927L,180L,835L,3061L,954L,12L,2188L,9933L,4510L,165L,5798L,31824L,19734L,1430L,15511L,100972L,81684L,9790L,55L,41835L,317942L,324246L,57876L,1001L,113634L,995088L,1245762L,309036L,10920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091958Inst : IEnumerable<long>
{
public static readonly long[] Value=A091958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091958.Bytes);
public long this[int i]=>Value[i];

public static A091958Inst Instance=new A091958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091957
{
public static readonly BigInteger[] Value={ 0L,1L,1L,2L,4L,13L,101L,5242L,13747054L,94490767454888L,BigInteger.Parse("4464252567107002358694986701"),BigInteger.Parse("9964775491460730298984873909049635615687553262572198767") };
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
public class A091957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091957Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091957.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091957.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091957Inst Instance=new A091957Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091956
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,14L,25L,40L,68L,105L,160L,245L,352L,508L,742L,1039L,1497L,2085L,2823L,3875L,5362L,7174L,9607L,12698L,16837L,25317L,38608L,56459L,79955L,111702L,159319L,232290L,326331L,460445L,651956L,897771L,1241982L,1699443L,2326219L,3130763L,4283977L,5671153L,7764404L,10359118L,13883187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091956Inst : IEnumerable<long>
{
public static readonly long[] Value=A091956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091956.Bytes);
public long this[int i]=>Value[i];

public static A091956Inst Instance=new A091956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091923
{
public static readonly long[] Value={ 11L,13L,17L,19L,23L,31L,37L,41L,47L,53L,59L,71L,73L,79L,83L,97L,101L,103L,107L,109L,113L,127L,131L,137L,149L,151L,157L,163L,167L,173L,179L,181L,191L,211L,223L,229L,233L,239L,241L,251L,257L,271L,277L,283L,293L,307L,311L,313L,317L,337L,347L,349L,359L,367L,383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091923Inst : IEnumerable<long>
{
public static readonly long[] Value=A091923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091923.Bytes);
public long this[int i]=>Value[i];

public static A091923Inst Instance=new A091923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091922
{
public static readonly long[] Value={ 5L,10L,19L,18L,3801L,6167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091922Inst : IEnumerable<long>
{
public static readonly long[] Value=A091922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091922.Bytes);
public long this[int i]=>Value[i];

public static A091922Inst Instance=new A091922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091921
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,3L,0L,0L,3L,5L,0L,3L,0L,7L,8L,0L,0L,3L,0L,5L,10L,11L,0L,3L,5L,13L,3L,7L,0L,8L,0L,0L,14L,17L,12L,3L,0L,19L,16L,5L,0L,10L,0L,11L,8L,23L,0L,3L,7L,5L,20L,13L,0L,3L,16L,7L,22L,29L,0L,8L,0L,31L,10L,0L,18L,14L,0L,17L,26L,12L,0L,3L,0L,37L,8L,19L,18L,16L,0L,5L,3L,41L,0L,10L,22L,43L,32L,11L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091921Inst : IEnumerable<long>
{
public static readonly long[] Value=A091921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091921.Bytes);
public long this[int i]=>Value[i];

public static A091921Inst Instance=new A091921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091920
{
public static readonly BigInteger[] Value={ 7L,11L,0L,1117L,11117L,0L,1111447L,11111117L,0L,1111111411L,11111111741L,0L,1111111111177L,11111111111411L,0L,1111111111111447L,11111111111111171L,0L,1111111111111111111L,11111111111111111447UL,0L,BigInteger.Parse("1111111111111111111711") };
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
public class A091920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091920Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091920.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091920.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091920Inst Instance=new A091920Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091919
{
public static readonly long[] Value={ 1L,2L,6L,12L,27L,54L,112L,224L,453L,906L,1818L,3636L,7279L,14558L,29124L,58248L,116505L,233010L,466030L,932060L,1864131L,3728262L,7456536L,14913072L,29826157L,59652314L,119304642L,238609284L,477218583L,954437166L,1908874348L,3817748696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091919Inst : IEnumerable<long>
{
public static readonly long[] Value=A091919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091919.Bytes);
public long this[int i]=>Value[i];

public static A091919Inst Instance=new A091919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091918
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,1L,8L,3L,3L,1L,16L,4L,6L,4L,1L,32L,5L,10L,10L,5L,1L,64L,6L,15L,20L,15L,6L,1L,128L,7L,21L,35L,35L,21L,7L,1L,256L,8L,28L,56L,70L,56L,28L,8L,1L,512L,9L,36L,84L,126L,126L,84L,36L,9L,1L,1024L,10L,45L,120L,210L,252L,210L,120L,45L,10L,1L,2048L,11L,55L,165L,330L,462L,462L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091918Inst : IEnumerable<long>
{
public static readonly long[] Value=A091918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091918.Bytes);
public long this[int i]=>Value[i];

public static A091918Inst Instance=new A091918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091917
{
public static readonly long[] Value={ 1L,-2L,1L,0L,-2L,1L,-2L,3L,-3L,1L,0L,-4L,6L,-4L,1L,-2L,5L,-10L,10L,-5L,1L,0L,-6L,15L,-20L,15L,-6L,1L,-2L,7L,-21L,35L,-35L,21L,-7L,1L,0L,-8L,28L,-56L,70L,-56L,28L,-8L,1L,-2L,9L,-36L,84L,-126L,126L,-84L,36L,-9L,1L,0L,-10L,45L,-120L,210L,-252L,210L,-120L,45L,-10L,1L,-2L,11L,-55L,165L,-330L,462L,-462L,330L,-165L,55L,-11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091917Inst : IEnumerable<long>
{
public static readonly long[] Value=A091917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091917.Bytes);
public long this[int i]=>Value[i];

public static A091917Inst Instance=new A091917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091916
{
public static readonly long[] Value={ 1L,1L,3L,3L,5L,9L,9L,15L,27L,27L,45L,81L,81L,135L,243L,243L,405L,729L,729L,1215L,2187L,2187L,3645L,6561L,6561L,10935L,19683L,19683L,32805L,59049L,59049L,98415L,177147L,177147L,295245L,531441L,531441L,885735L,1594323L,1594323L,2657205L,4782969L,4782969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091916Inst : IEnumerable<long>
{
public static readonly long[] Value=A091916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091916.Bytes);
public long this[int i]=>Value[i];

public static A091916Inst Instance=new A091916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091915
{
public static readonly long[] Value={ 0L,2L,2L,4L,6L,8L,12L,18L,24L,36L,54L,72L,108L,162L,216L,324L,486L,648L,972L,1458L,1944L,2916L,4374L,5832L,8748L,13122L,17496L,26244L,39366L,52488L,78732L,118098L,157464L,236196L,354294L,472392L,708588L,1062882L,1417176L,2125764L,3188646L,4251528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091915Inst : IEnumerable<long>
{
public static readonly long[] Value=A091915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091915.Bytes);
public long this[int i]=>Value[i];

public static A091915Inst Instance=new A091915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091914
{
public static readonly long[] Value={ 1L,2L,16L,56L,304L,1280L,6208L,27776L,130048L,593408L,2747392L,12615680L,58200064L,267788288L,1233977344L,5681414144L,26170556416L,120518082560L,555082842112L,2556382674944L,11773759455232L,54224111009792L,249733335482368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091914Inst : IEnumerable<long>
{
public static readonly long[] Value=A091914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091914.Bytes);
public long this[int i]=>Value[i];

public static A091914Inst Instance=new A091914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091913
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,9L,3L,15L,28L,18L,4L,31L,75L,70L,30L,5L,63L,186L,225L,140L,45L,6L,127L,441L,651L,525L,245L,63L,7L,255L,1016L,1764L,1736L,1050L,392L,84L,8L,511L,2295L,4572L,5292L,3906L,1890L,588L,108L,9L,1023L,5110L,11475L,15240L,13230L,7812L,3150L,840L,135L,10L,2047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091913Inst : IEnumerable<long>
{
public static readonly long[] Value=A091913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091913.Bytes);
public long this[int i]=>Value[i];

public static A091913Inst Instance=new A091913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091912
{
public static readonly BigInteger[] Value={ 1L,1L,1L,61L,277L,50521L,41581L,199360981L,228135437L,2404879675441L,14814847529501L,69348874393137901L,238685140977801337L,BigInteger.Parse("4087072509293123892361"),BigInteger.Parse("454540704683713199807"),BigInteger.Parse("441543893249023104553682821"),BigInteger.Parse("2088463430347521052196056349") };
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
public class A091912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091912Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091912.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091912.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091912Inst Instance=new A091912Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091911
{
public static readonly long[] Value={ 1L,6L,28L,0L,140L,270L,8128L,672L,1638L,6200L,2970L,0L,105664L,18620L,8190L,0L,27846L,0L,117800L,0L,55860L,0L,0L,30240L,173600L,242060L,167400L,0L,237510L,0L,2305843008139952128L,0L,0L,0L,2229500L,0L,4358600L,0L,726180L,0L,2290260L,1089270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091911Inst : IEnumerable<long>
{
public static readonly long[] Value=A091911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091911.Bytes);
public long this[int i]=>Value[i];

public static A091911Inst Instance=new A091911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091910
{
public static readonly long[] Value={ 1L,3L,4L,10L,11L,21L,20L,36L,36L,55L,56L,78L,79L,103L,103L,136L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091910Inst : IEnumerable<long>
{
public static readonly long[] Value=A091910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091910.Bytes);
public long this[int i]=>Value[i];

public static A091910Inst Instance=new A091910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091909
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,11L,12L,36L,95L,372L,842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091909Inst : IEnumerable<long>
{
public static readonly long[] Value=A091909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091909.Bytes);
public long this[int i]=>Value[i];

public static A091909Inst Instance=new A091909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091908
{
public static readonly long[] Value={ 0L,1L,12L,13L,48L,49L,108L,109L,192L,193L,300L,301L,432L,433L,576L,589L,768L,769L,972L,961L,1200L,1201L,1452L,1405L,1728L,1729L,2028L,2029L,2352L,2341L,2700L,2701L,3072L,3073L,3444L,3469L,3888L,3889L,4332L,4297L,4800L,4777L,5292L,5293L,5724L,5809L,6348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091908Inst : IEnumerable<long>
{
public static readonly long[] Value=A091908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091908.Bytes);
public long this[int i]=>Value[i];

public static A091908Inst Instance=new A091908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091891
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,2L,1L,10L,3L,2L,1L,5L,1L,2L,1L,36L,6L,12L,1L,11L,3L,2L,1L,24L,3L,3L,1L,5L,1L,2L,1L,202L,67L,55L,9L,93L,4L,5L,1L,112L,8L,13L,1L,10L,3L,2L,1L,304L,22L,18L,1L,20L,3L,3L,1L,34L,3L,3L,1L,5L,1L,2L,1L,1828L,1267L,1456L,71L,1629L,77L,100L,2L,2342L,99L,123L,9L,132L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091891Inst : IEnumerable<long>
{
public static readonly long[] Value=A091891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091891.Bytes);
public long this[int i]=>Value[i];

public static A091891Inst Instance=new A091891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091890
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,2L,0L,0L,0L,1L,1L,1L,3L,2L,0L,1L,3L,3L,2L,5L,2L,1L,1L,5L,6L,3L,9L,5L,4L,5L,10L,9L,8L,13L,8L,10L,8L,16L,17L,15L,22L,18L,18L,20L,25L,28L,27L,34L,31L,32L,33L,44L,49L,44L,64L,53L,56L,61L,71L,77L,77L,100L,88L,94L,99L,123L,125L,132L,162L,147L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091890Inst : IEnumerable<long>
{
public static readonly long[] Value=A091890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091890.Bytes);
public long this[int i]=>Value[i];

public static A091890Inst Instance=new A091890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091889
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,1L,3L,2L,2L,5L,2L,3L,8L,4L,6L,12L,6L,11L,16L,11L,16L,24L,17L,23L,34L,26L,35L,50L,35L,50L,67L,55L,72L,93L,76L,99L,126L,112L,135L,171L,150L,186L,229L,210L,249L,304L,280L,336L,398L,380L,443L,526L,499L,584L,680L,665L,759L,886L,858L,985L,1136L,1123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091889Inst : IEnumerable<long>
{
public static readonly long[] Value=A091889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091889.Bytes);
public long this[int i]=>Value[i];

public static A091889Inst Instance=new A091889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091888
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,2L,0L,0L,0L,2L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,2L,0L,0L,3L,0L,0L,0L,0L,1L,1L,2L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091888Inst : IEnumerable<long>
{
public static readonly long[] Value=A091888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091888.Bytes);
public long this[int i]=>Value[i];

public static A091888Inst Instance=new A091888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091887
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,2L,3L,1L,1L,2L,1L,1L,2L,1L,1L,1L,3L,1L,2L,3L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091887Inst : IEnumerable<long>
{
public static readonly long[] Value=A091887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091887.Bytes);
public long this[int i]=>Value[i];

public static A091887Inst Instance=new A091887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091886
{
public static readonly long[] Value={ 6L,9L,10L,12L,14L,15L,16L,18L,20L,21L,22L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,79L,80L,81L,82L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091886Inst : IEnumerable<long>
{
public static readonly long[] Value=A091886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091886.Bytes);
public long this[int i]=>Value[i];

public static A091886Inst Instance=new A091886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091885
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,9L,10L,1L,64L,20L,1L,225L,259L,35L,1L,2304L,784L,56L,1L,11025L,12916L,1974L,84L,1L,147456L,52480L,4368L,120L,1L,893025L,1057221L,172810L,8778L,165L,1L,14745600L,5395456L,489280L,16368L,220L,1L,108056025L,128816766L,21967231L,1234948L,28743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091885Inst : IEnumerable<long>
{
public static readonly long[] Value=A091885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091885.Bytes);
public long this[int i]=>Value[i];

public static A091885Inst Instance=new A091885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091884
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,3L,27L,19L,20L,20L,256L,175L,191L,190L,190L,3125L,2101L,2344L,2312L,2313L,2313L,46656L,31031L,35127L,34398L,34462L,34461L,34461L,823543L,543607L,621732L,605348L,607535L,607407L,607408L,607408L,16777216L,11012415L,12692031L,12301406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091884Inst : IEnumerable<long>
{
public static readonly long[] Value=A091884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091884.Bytes);
public long this[int i]=>Value[i];

public static A091884Inst Instance=new A091884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091883
{
public static readonly long[] Value={ 1L,0L,50L,250L,3750L,31250L,343750L,3281250L,33593750L,332031250L,3339843750L,33300781250L,333496093750L,3332519531250L,33337402343750L,333312988281250L,3333435058593750L,33332824707031250L,333335876464843750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091883Inst : IEnumerable<long>
{
public static readonly long[] Value=A091883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091883.Bytes);
public long this[int i]=>Value[i];

public static A091883Inst Instance=new A091883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091882
{
public static readonly long[] Value={ 1L,5L,75L,1125L,16875L,253125L,3796875L,56953125L,854296875L,12814453125L,192216796875L,2883251953125L,43248779296875L,648731689453125L,9730975341796875L,145964630126953125L,2189469451904296875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091882Inst : IEnumerable<long>
{
public static readonly long[] Value=A091882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091882.Bytes);
public long this[int i]=>Value[i];

public static A091882Inst Instance=new A091882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091881
{
public static readonly long[] Value={ 1L,6L,86L,1366L,21846L,349526L,5592406L,89478486L,1431655766L,22906492246L,366503875926L,5864062014806L,93824992236886L,1501199875790166L,24019198012642646L,384307168202282326L,6148914691236517206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091881Inst : IEnumerable<long>
{
public static readonly long[] Value=A091881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091881.Bytes);
public long this[int i]=>Value[i];

public static A091881Inst Instance=new A091881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091880
{
public static readonly long[] Value={ 1L,4L,9L,14L,15L,18L,21L,22L,25L,36L,39L,40L,48L,53L,59L,65L,67L,70L,72L,73L,74L,82L,85L,88L,99L,101L,110L,114L,122L,125L,127L,129L,130L,137L,143L,146L,147L,155L,158L,168L,174L,177L,180L,181L,188L,194L,198L,200L,202L,204L,213L,216L,219L,220L,224L,226L,229L,235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091880Inst : IEnumerable<long>
{
public static readonly long[] Value=A091880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091880.Bytes);
public long this[int i]=>Value[i];

public static A091880Inst Instance=new A091880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091879
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,3L,16L,1L,16L,3L,6L,12L,16L,3L,36L,27L,86L,35L,40L,81L,18L,9L,20L,118L,138L,146L,154L,67L,66L,32L,66L,57L,504L,33L,462L,38L,24L,12L,268L,57L,80L,18L,82L,3L,74L,253L,676L,65L,252L,72L,128L,171L,48L,95L,912L,246L,22L,423L,552L,48L,496L,99L,232L,108L,588L,27L,346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091879Inst : IEnumerable<long>
{
public static readonly long[] Value=A091879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091879.Bytes);
public long this[int i]=>Value[i];

public static A091879Inst Instance=new A091879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091878
{
public static readonly long[] Value={ 4920L,801528L,1484280L,5351640L,7257720L,7647360L,12168912L,12302472L,15540360L,17348520L,21623160L,25639320L,27285048L,27462840L,27470352L,34714680L,35684040L,38466288L,48449640L,49936152L,51272760L,54037368L,60948888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091878Inst : IEnumerable<long>
{
public static readonly long[] Value=A091878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091878.Bytes);
public long this[int i]=>Value[i];

public static A091878Inst Instance=new A091878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091877
{
public static readonly long[] Value={ 2L,7L,43L,136L,1336L,13336L,133336L,1333336L,13333336L,133333336L,1333333336L,13333333336L,133333333336L,1333333333336L,13333333333336L,133333333333336L,1333333333333336L,13333333333333336L,133333333333333336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091877Inst : IEnumerable<long>
{
public static readonly long[] Value=A091877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091877.Bytes);
public long this[int i]=>Value[i];

public static A091877Inst Instance=new A091877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091876
{
public static readonly long[] Value={ 6L,19L,181L,569L,5669L,56669L,566669L,5666669L,56666669L,566666669L,5666666669L,56666666669L,566666666669L,5666666666669L,56666666666669L,566666666666669L,5666666666666669L,56666666666666669L,566666666666666669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091876Inst : IEnumerable<long>
{
public static readonly long[] Value=A091876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091876.Bytes);
public long this[int i]=>Value[i];

public static A091876Inst Instance=new A091876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091843
{
public static readonly long[] Value={ 1L,3L,10L,42L,200L,983L,4892L,24434L,122141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091843Inst : IEnumerable<long>
{
public static readonly long[] Value=A091843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091843.Bytes);
public long this[int i]=>Value[i];

public static A091843Inst Instance=new A091843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091842
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,10L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,10L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,10L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,42L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,10L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091842Inst : IEnumerable<long>
{
public static readonly long[] Value=A091842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091842.Bytes);
public long this[int i]=>Value[i];

public static A091842Inst Instance=new A091842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091841
{
public static readonly long[] Value={ 1L,3L,9L,32L,119L,463L,1837L,7332L,29307L,117203L,468785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091841Inst : IEnumerable<long>
{
public static readonly long[] Value=A091841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091841.Bytes);
public long this[int i]=>Value[i];

public static A091841Inst Instance=new A091841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091840
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,3L,1L,1L,9L,1L,1L,3L,1L,1L,3L,1L,1L,9L,1L,1L,3L,1L,1L,3L,1L,1L,32L,1L,3L,1L,1L,3L,1L,1L,9L,1L,1L,3L,1L,1L,3L,1L,1L,9L,1L,1L,3L,1L,1L,3L,1L,1L,32L,1L,3L,1L,1L,3L,1L,1L,9L,1L,1L,3L,1L,1L,3L,1L,1L,9L,1L,1L,3L,1L,1L,3L,1L,1L,119L,1L,1L,3L,1L,1L,3L,1L,1L,9L,1L,1L,3L,1L,1L,3L,1L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091840Inst : IEnumerable<long>
{
public static readonly long[] Value=A091840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091840.Bytes);
public long this[int i]=>Value[i];

public static A091840Inst Instance=new A091840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091839
{
public static readonly long[] Value={ 1L,3L,1L,8L,1L,3L,1L,24L,1L,3L,1L,8L,1L,3L,1L,67L,1L,3L,1L,8L,1L,3L,1L,24L,1L,3L,1L,8L,1L,3L,1L,195L,1L,3L,1L,8L,1L,3L,1L,24L,1L,3L,1L,8L,1L,3L,1L,67L,1L,3L,1L,8L,1L,3L,1L,24L,1L,3L,1L,8L,1L,3L,1L,580L,1L,3L,1L,8L,1L,3L,1L,24L,1L,3L,1L,8L,1L,3L,1L,67L,1L,3L,1L,8L,1L,3L,1L,24L,1L,3L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091839Inst : IEnumerable<long>
{
public static readonly long[] Value=A091839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091839.Bytes);
public long this[int i]=>Value[i];

public static A091839Inst Instance=new A091839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091838
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,18L,29L,47L,76L,121L,199L,310L,521L,841L,1364L,2207L,3571L,5776L,9349L,15125L,24476L,39601L,64079L,103682L,167761L,271441L,439204L,710645L,1149851L,1860496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091838Inst : IEnumerable<long>
{
public static readonly long[] Value=A091838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091838.Bytes);
public long this[int i]=>Value[i];

public static A091838Inst Instance=new A091838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091837
{
public static readonly long[] Value={ 10L,10L,10L,10L,10L,10L,10L,10L,10L,21L,3L,21L,12L,13L,14L,15L,16L,17L,18L,19L,20L,3L,22L,21L,24L,21L,26L,21L,28L,21L,4L,21L,32L,21L,34L,21L,36L,21L,32L,21L,40L,32L,42L,43L,32L,45L,46L,23L,48L,24L,32L,25L,52L,26L,54L,27L,32L,28L,58L,29L,60L,4L,32L,31L,54L,32L,66L,33L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091837Inst : IEnumerable<long>
{
public static readonly long[] Value=A091837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091837.Bytes);
public long this[int i]=>Value[i];

public static A091837Inst Instance=new A091837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091836
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,3L,3L,1L,4L,6L,6L,4L,1L,9L,13L,13L,10L,5L,1L,21L,30L,30L,24L,15L,6L,1L,51L,72L,72L,59L,40L,21L,7L,1L,127L,178L,178L,148L,105L,62L,28L,8L,1L,323L,450L,450L,378L,276L,174L,91L,36L,9L,1L,835L,1158L,1158L,980L,730L,480L,273L,128L,45L,10L,1L,2188L,3023L,3023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091836Inst : IEnumerable<long>
{
public static readonly long[] Value=A091836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091836.Bytes);
public long this[int i]=>Value[i];

public static A091836Inst Instance=new A091836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091835
{
public static readonly BigInteger[] Value={ 2L,3L,15L,105L,10395L,135135L,34459425L,654729075L,316234143225L,6190283353629375L,191898783962510625L,BigInteger.Parse("8200794532637891559375"),BigInteger.Parse("13113070457687988603440625"),BigInteger.Parse("563862029680583509947946875"),BigInteger.Parse("1192568192774434123539907640625"),BigInteger.Parse("157952079428395476360490147277859375") };
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
public class A091835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091835Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091835.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091835.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091835Inst Instance=new A091835Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091834
{
public static readonly long[] Value={ 2L,3L,6L,4L,2L,4L,5L,15L,10L,10L,6L,3L,2L,6L,3L,7L,21L,21L,14L,14L,21L,8L,4L,8L,2L,8L,4L,8L,9L,18L,3L,9L,18L,6L,9L,18L,10L,5L,10L,15L,2L,10L,5L,10L,15L,11L,44L,44L,33L,33L,22L,22L,44L,44L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091834Inst : IEnumerable<long>
{
public static readonly long[] Value=A091834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091834.Bytes);
public long this[int i]=>Value[i];

public static A091834Inst Instance=new A091834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091833
{
public static readonly long[] Value={ 2L,4L,7L,22L,29L,51L,173L,210L,262L,417L,746L,12341L,207220L,498538L,1286415L,2351289L,3702952L,7664494L,54693034L,75971438L,269954954L,6674693008L,13449203581L,59799655308L,98912303039L,948887634688L,3557757020909L,5898230078743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091833Inst : IEnumerable<long>
{
public static readonly long[] Value=A091833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091833.Bytes);
public long this[int i]=>Value[i];

public static A091833Inst Instance=new A091833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091832
{
public static readonly long[] Value={ 18L,19L,136L,349L,357L,1354L,6996L,7135L,9531L,11558L,15996L,17432L,52118L,151048L,427802L,821834L,877819L,972918L,1046690L,1540789L,3653077L,8200738L,9628573L,164153335L,5607624822L,86457467082L,141885251873L,151882622551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091832Inst : IEnumerable<long>
{
public static readonly long[] Value=A091832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091832.Bytes);
public long this[int i]=>Value[i];

public static A091832Inst Instance=new A091832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091831
{
public static readonly BigInteger[] Value={ 1L,3L,8L,33L,35L,39201L,39203L,60245508192801L,60245508192803L,BigInteger.Parse("218662352649181293830957829984632156775201"),BigInteger.Parse("218662352649181293830957829984632156775203") };
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
public class A091831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091831Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091831.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091831.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091831Inst Instance=new A091831Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091830
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,1L,2L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,0L,1L,1L,2L,1L,2L,0L,1L,0L,1L,1L,2L,1L,2L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,1L,2L,0L,1L,0L,1L,1L,2L,0L,1L,1L,2L,1L,2L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,0L,1L,1L,2L,1L,2L,0L,1L,0L,1L,1L,2L,1L,2L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,0L,1L,1L,2L,1L,2L,0L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091830Inst : IEnumerable<long>
{
public static readonly long[] Value=A091830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091830.Bytes);
public long this[int i]=>Value[i];

public static A091830Inst Instance=new A091830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091829
{
public static readonly long[] Value={ 1L,2L,1L,3L,0L,2L,1L,4L,1L,1L,0L,3L,0L,2L,1L,5L,0L,2L,1L,2L,1L,1L,0L,4L,1L,1L,0L,3L,0L,2L,1L,6L,1L,1L,0L,3L,0L,2L,1L,3L,0L,2L,1L,2L,1L,1L,0L,5L,0L,2L,1L,2L,1L,1L,0L,4L,1L,1L,0L,3L,0L,2L,1L,7L,0L,2L,1L,2L,1L,1L,0L,4L,1L,1L,0L,3L,0L,2L,1L,4L,1L,1L,0L,3L,0L,2L,1L,3L,0L,2L,1L,2L,1L,1L,0L,6L,1L,1L,0L,3L,0L,2L,1L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091829Inst : IEnumerable<long>
{
public static readonly long[] Value=A091829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091829.Bytes);
public long this[int i]=>Value[i];

public static A091829Inst Instance=new A091829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091828
{
public static readonly long[] Value={ 1L,0L,3L,4L,5L,2L,1L,4L,5L,6L,7L,6L,7L,8L,7L,8L,9L,4L,5L,6L,3L,2L,5L,6L,7L,8L,7L,8L,9L,8L,9L,10L,9L,10L,11L,8L,9L,10L,9L,10L,11L,10L,11L,12L,9L,10L,11L,10L,11L,12L,11L,12L,13L,6L,7L,8L,7L,8L,9L,8L,9L,10L,5L,6L,7L,4L,5L,6L,7L,8L,9L,8L,9L,10L,9L,10L,11L,10L,11L,12L,9L,10L,11L,10L,11L,12L,11L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091828Inst : IEnumerable<long>
{
public static readonly long[] Value=A091828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091828.Bytes);
public long this[int i]=>Value[i];

public static A091828Inst Instance=new A091828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091795
{
public static readonly BigInteger[] Value={ 2L,9L,66L,2530L,60075L,1627941L,124324228L,1694579076L,446626220085L,73706596563655L,177223661334786L,171986625946535478L,3290057629552053451L,BigInteger.Parse("551042196782556679305"),BigInteger.Parse("71028805196838414285480") };
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
public class A091795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091795Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091795.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091795.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091795Inst Instance=new A091795Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091794
{
public static readonly BigInteger[] Value={ 2L,8L,64L,2527L,60071L,1627936L,124324222L,1694579069L,446626220077L,73706596563646L,177223661334776L,171986625946535467L,3290057629552053439L,BigInteger.Parse("551042196782556679292"),BigInteger.Parse("71028805196838414285466") };
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
public class A091794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091794Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091794.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091794.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091794Inst Instance=new A091794Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091793
{
public static readonly long[] Value={ 2L,8L,9L,64L,65L,66L,2527L,2528L,2529L,2530L,60071L,60072L,60073L,60074L,60075L,1627936L,1627937L,1627938L,1627939L,1627940L,1627941L,124324222L,124324223L,124324224L,124324225L,124324226L,124324227L,124324228L,1694579069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091793Inst : IEnumerable<long>
{
public static readonly long[] Value=A091793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091793.Bytes);
public long this[int i]=>Value[i];

public static A091793Inst Instance=new A091793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091792
{
public static readonly BigInteger[] Value={ 1L,4L,243L,17360L,1350225L,11047296L,934771207L,81013504612L,7148250406947L,6395802995689430L,578667890086186528L,BigInteger.Parse("52834894312217030820"),BigInteger.Parse("48608102767239668354413"),BigInteger.Parse("45007502562258952180012050") };
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
public class A091792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091792Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091792.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091792.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091792Inst Instance=new A091792Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091791
{
public static readonly long[] Value={ 1L,2L,15L,20L,25L,6L,91L,80L,99L,170L,88L,60L,325L,350L,225L,512L,646L,540L,114L,60L,672L,704L,460L,696L,675L,78L,135L,560L,493L,2010L,589L,992L,2145L,1768L,35L,900L,2072L,1900L,3159L,2680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091791Inst : IEnumerable<long>
{
public static readonly long[] Value=A091791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091791.Bytes);
public long this[int i]=>Value[i];

public static A091791Inst Instance=new A091791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091790
{
public static readonly BigInteger[] Value={ 1221L,221122L,2112222112L,1222211221122221L,BigInteger.Parse("22112211222211222211221122"),BigInteger.Parse("211222211222211221122221122112222112222112"),BigInteger.Parse("12222112211222211221122221122221122112222112222112211222211221122221") };
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
public class A091790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091790.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091790Inst Instance=new A091790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091789
{
public static readonly BigInteger[] Value={ 1L,2L,21L,122L,22112L,21122221L,1222211221122L,BigInteger.Parse("221122112222112222112"),BigInteger.Parse("2112222112222112211222211221122221"),BigInteger.Parse("1222211221122221122112222112222112211222211222211221122") };
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
public class A091789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091789Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091789.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091789.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091789Inst Instance=new A091789Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091788
{
public static readonly BigInteger[] Value={ 1L,2L,2L,4L,16L,96L,5184L,829440L,1911029760L,13002646487040L,10065920762063093760UL,BigInteger.Parse("9319918463639717615448883200"),BigInteger.Parse("137422208150223932126848386360776224407552000") };
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
public class A091788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091788Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091788.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091788.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091788Inst Instance=new A091788Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091787
{
public static readonly long[] Value={ 2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,3L,3L,3L,4L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,3L,3L,3L,4L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091787Inst : IEnumerable<long>
{
public static readonly long[] Value=A091787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091787.Bytes);
public long this[int i]=>Value[i];

public static A091787Inst Instance=new A091787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091786
{
public static readonly long[] Value={ 3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,6L,6L,6L,7L,7L,7L,7L,8L,8L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,12L,13L,15L,15L,15L,17L,20L,21L,21L,27L,31L,34L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091786Inst : IEnumerable<long>
{
public static readonly long[] Value=A091786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091786.Bytes);
public long this[int i]=>Value[i];

public static A091786Inst Instance=new A091786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091785
{
public static readonly long[] Value={ 3L,5L,9L,12L,15L,17L,20L,23L,27L,29L,33L,36L,39L,43L,45L,48L,51L,53L,57L,60L,63L,65L,68L,71L,75L,77L,80L,83L,85L,89L,92L,95L,99L,101L,105L,108L,111L,113L,116L,119L,123L,125L,129L,132L,135L,139L,141L,144L,147L,149L,153L,156L,159L,163L,165L,169L,172L,175L,177L,180L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091785Inst : IEnumerable<long>
{
public static readonly long[] Value=A091785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091785.Bytes);
public long this[int i]=>Value[i];

public static A091785Inst Instance=new A091785Inst();

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