using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A070784
{
public static readonly long[] Value={ 2L,4L,5L,4L,5L,8L,4L,8L,10L,10L,6L,5L,8L,9L,12L,15L,5L,8L,10L,13L,13L,5L,8L,13L,16L,17L,10L,16L,8L,9L,10L,10L,13L,13L,16L,17L,17L,17L,18L,20L,20L,12L,15L,8L,13L,13L,16L,17L,17L,20L,20L,25L,10L,10L,16L,18L,20L,20L,20L,26L,24L,14L,9L,13L,16L,20L,20L,20L,25L,25L,29L,12L,24L,30L,30L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070784Inst : IEnumerable<long>
{
public static readonly long[] Value=A070784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070784.Bytes);
public long this[int i]=>Value[i];

public static A070784Inst Instance=new A070784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070783
{
public static readonly long[] Value={ 4L,5L,5L,8L,8L,9L,10L,10L,10L,10L,12L,13L,13L,13L,15L,15L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,18L,18L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,24L,24L,25L,25L,25L,25L,25L,25L,25L,25L,25L,26L,26L,26L,26L,26L,26L,26L,26L,27L,28L,29L,29L,29L,29L,29L,29L,29L,29L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070783Inst : IEnumerable<long>
{
public static readonly long[] Value=A070783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070783.Bytes);
public long this[int i]=>Value[i];

public static A070783Inst Instance=new A070783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070782
{
public static readonly BigInteger[] Value={ 1L,2L,254L,6008L,215766L,6643782L,215492564L,6863694378L,219993856006L,7035859329512L,225191238869774L,7205634556190798L,230585685502492596L,7378682274243863442L,BigInteger.Parse("236118494435702913134"),BigInteger.Parse("7555784484021765207768") };
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
public class A070782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070782Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070782.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070782.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070782Inst Instance=new A070782Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070781
{
public static readonly BigInteger[] Value={ 1L,4L,126L,11440L,2042975L,600805296L,262596783764L,159518999862720L,128447994798305325L,BigInteger.Parse("132341572939212267400"),BigInteger.Parse("169758547725351091518726"),BigInteger.Parse("265242021590899282966358400"),BigInteger.Parse("495874093230232452749553398586"),BigInteger.Parse("1092844289151775603486607296657120") };
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
public class A070781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070781Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070781.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070781.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070781Inst Instance=new A070781Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070780
{
public static readonly BigInteger[] Value={ 1L,4L,36L,560L,12650L,376992L,13983816L,621216192L,32164253550L,1902231808400L,126524771308936L,9349109217266832L,759825846558448488L,BigInteger.Parse("67362990324409227840"),BigInteger.Parse("6469590128756692755600"),BigInteger.Parse("669128737063722082963200"),BigInteger.Parse("74148585178960981066746390"),BigInteger.Parse("8764445804610791475090220464"),BigInteger.Parse("1100718583140907766992803808200") };
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
public class A070780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070780Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070780.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070780.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070780Inst Instance=new A070780Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070779
{
public static readonly long[] Value={ 1L,5L,28L,185L,1426L,12607L,125882L,1401409L,17209234L,231033431L,3365440882L,52855452817L,890097287834L,15996379554079L,305519496498106L,6178746162639617L,131885301216119842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070779Inst : IEnumerable<long>
{
public static readonly long[] Value=A070779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070779.Bytes);
public long this[int i]=>Value[i];

public static A070779Inst Instance=new A070779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070778
{
public static readonly long[] Value={ 1L,2L,11L,41L,176L,721L,3003L,12439L,51623L,214103L,888173L,3684174L,15282475L,63393324L,262962987L,1090800411L,4524765831L,18769248040L,77856998326L,322959774150L,1339674254489L,5557122741105L,23051583675890L,95620617831960L,396645310086831L,1645330322871807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070778Inst : IEnumerable<long>
{
public static readonly long[] Value=A070778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070778.Bytes);
public long this[int i]=>Value[i];

public static A070778Inst Instance=new A070778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070777
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,6L,1L,2L,4L,10L,2L,12L,6L,4L,1L,16L,2L,18L,4L,6L,10L,22L,2L,4L,12L,2L,6L,28L,4L,30L,1L,10L,16L,6L,2L,36L,18L,12L,4L,40L,6L,42L,10L,4L,22L,46L,2L,6L,4L,16L,12L,52L,2L,10L,6L,18L,28L,58L,4L,60L,30L,6L,1L,12L,10L,66L,16L,22L,6L,70L,2L,72L,36L,4L,18L,10L,12L,78L,4L,2L,40L,82L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070777Inst : IEnumerable<long>
{
public static readonly long[] Value=A070777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070777.Bytes);
public long this[int i]=>Value[i];

public static A070777Inst Instance=new A070777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070776
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,16L,17L,18L,19L,20L,22L,23L,24L,25L,26L,27L,28L,29L,31L,32L,34L,36L,37L,38L,40L,41L,43L,44L,46L,47L,48L,49L,50L,52L,53L,54L,56L,58L,59L,61L,62L,64L,67L,68L,71L,72L,73L,74L,76L,79L,80L,81L,82L,83L,86L,88L,89L,92L,94L,96L,97L,98L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070776Inst : IEnumerable<long>
{
public static readonly long[] Value=A070776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070776.Bytes);
public long this[int i]=>Value[i];

public static A070776Inst Instance=new A070776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070775
{
public static readonly long[] Value={ 1L,2L,72L,992L,16512L,261632L,4196352L,67100672L,1073774592L,17179738112L,274878431232L,4398044413952L,70368752566272L,1125899873288192L,18014398643699712L,288230375614840832L,4611686020574871552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070775Inst : IEnumerable<long>
{
public static readonly long[] Value=A070775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070775.Bytes);
public long this[int i]=>Value[i];

public static A070775Inst Instance=new A070775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070774
{
public static readonly long[] Value={ 23L,27L,41L,47L,65L,73L,75L,77L,79L,85L,89L,101L,103L,113L,119L,125L,155L,159L,161L,165L,169L,175L,179L,183L,215L,217L,221L,233L,249L,253L,257L,263L,265L,275L,289L,291L,297L,299L,311L,329L,339L,341L,345L,347L,349L,353L,359L,363L,367L,375L,377L,379L,385L,395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070774Inst : IEnumerable<long>
{
public static readonly long[] Value=A070774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070774.Bytes);
public long this[int i]=>Value[i];

public static A070774Inst Instance=new A070774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070773
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,1L,2L,2L,0L,1L,0L,2L,1L,1L,3L,1L,1L,0L,1L,2L,0L,2L,1L,1L,1L,3L,2L,1L,3L,0L,1L,2L,2L,0L,0L,0L,0L,2L,1L,0L,3L,0L,3L,2L,3L,3L,1L,0L,0L,2L,2L,3L,2L,0L,3L,1L,0L,1L,1L,0L,1L,1L,1L,1L,7L,1L,2L,2L,1L,1L,1L,1L,2L,1L,0L,2L,0L,0L,2L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,2L,2L,3L,3L,2L,1L,2L,1L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070773Inst : IEnumerable<long>
{
public static readonly long[] Value=A070773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070773.Bytes);
public long this[int i]=>Value[i];

public static A070773Inst Instance=new A070773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070772
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,2L,3L,4L,5L,6L,4L,5L,6L,7L,6L,7L,8L,8L,9L,10L,3L,4L,5L,6L,7L,5L,6L,7L,8L,7L,8L,9L,9L,10L,11L,6L,7L,8L,9L,8L,9L,10L,10L,11L,12L,9L,10L,11L,11L,12L,13L,12L,13L,14L,15L,4L,5L,6L,7L,8L,6L,7L,8L,9L,8L,9L,10L,10L,11L,12L,7L,8L,9L,10L,9L,10L,11L,11L,12L,13L,10L,11L,12L,12L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070772Inst : IEnumerable<long>
{
public static readonly long[] Value=A070772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070772.Bytes);
public long this[int i]=>Value[i];

public static A070772Inst Instance=new A070772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070723
{
public static readonly long[] Value={ 0L,1L,42L,37L,1L,37L,6L,7L,42L,36L,6L,1L,37L,36L,36L,36L,1L,36L,7L,37L,37L,1L,42L,6L,6L,36L,7L,42L,7L,7L,7L,6L,42L,37L,7L,1L,36L,37L,6L,42L,6L,1L,42L,0L,1L,42L,37L,1L,37L,6L,7L,42L,36L,6L,1L,37L,36L,36L,36L,1L,36L,7L,37L,37L,1L,42L,6L,6L,36L,7L,42L,7L,7L,7L,6L,42L,37L,7L,1L,36L,37L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070723Inst : IEnumerable<long>
{
public static readonly long[] Value=A070723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070723.Bytes);
public long this[int i]=>Value[i];

public static A070723Inst Instance=new A070723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070722
{
public static readonly long[] Value={ 0L,1L,5L,14L,25L,20L,29L,17L,2L,32L,18L,35L,22L,26L,3L,34L,10L,13L,37L,30L,8L,33L,11L,4L,28L,31L,7L,38L,15L,19L,6L,23L,9L,39L,24L,12L,21L,16L,27L,36L,40L,0L,1L,5L,14L,25L,20L,29L,17L,2L,32L,18L,35L,22L,26L,3L,34L,10L,13L,37L,30L,8L,33L,11L,4L,28L,31L,7L,38L,15L,19L,6L,23L,9L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070722Inst : IEnumerable<long>
{
public static readonly long[] Value=A070722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070722.Bytes);
public long this[int i]=>Value[i];

public static A070722Inst Instance=new A070722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070721
{
public static readonly long[] Value={ 0L,1L,8L,27L,24L,5L,16L,23L,32L,9L,0L,11L,8L,37L,24L,15L,16L,33L,32L,19L,0L,21L,8L,7L,24L,25L,16L,3L,32L,29L,0L,31L,8L,17L,24L,35L,16L,13L,32L,39L,0L,1L,8L,27L,24L,5L,16L,23L,32L,9L,0L,11L,8L,37L,24L,15L,16L,33L,32L,19L,0L,21L,8L,7L,24L,25L,16L,3L,32L,29L,0L,31L,8L,17L,24L,35L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070721Inst : IEnumerable<long>
{
public static readonly long[] Value=A070721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070721.Bytes);
public long this[int i]=>Value[i];

public static A070721Inst Instance=new A070721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070720
{
public static readonly long[] Value={ 0L,1L,11L,3L,4L,8L,33L,19L,5L,9L,10L,2L,12L,13L,14L,24L,16L,17L,21L,7L,32L,18L,22L,23L,15L,25L,26L,27L,37L,29L,30L,34L,20L,6L,31L,35L,36L,28L,38L,0L,1L,11L,3L,4L,8L,33L,19L,5L,9L,10L,2L,12L,13L,14L,24L,16L,17L,21L,7L,32L,18L,22L,23L,15L,25L,26L,27L,37L,29L,30L,34L,20L,6L,31L,35L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070720Inst : IEnumerable<long>
{
public static readonly long[] Value=A070720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070720.Bytes);
public long this[int i]=>Value[i];

public static A070720Inst Instance=new A070720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070719
{
public static readonly long[] Value={ 0L,1L,14L,21L,6L,35L,28L,7L,8L,23L,34L,11L,12L,29L,22L,13L,36L,5L,18L,19L,20L,33L,2L,25L,16L,9L,26L,27L,4L,15L,30L,31L,10L,3L,32L,17L,24L,37L,0L,1L,14L,21L,6L,35L,28L,7L,8L,23L,34L,11L,12L,29L,22L,13L,36L,5L,18L,19L,20L,33L,2L,25L,16L,9L,26L,27L,4L,15L,30L,31L,10L,3L,32L,17L,24L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070719Inst : IEnumerable<long>
{
public static readonly long[] Value=A070719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070719.Bytes);
public long this[int i]=>Value[i];

public static A070719Inst Instance=new A070719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070718
{
public static readonly long[] Value={ 0L,1L,17L,4L,30L,18L,31L,34L,29L,16L,10L,11L,9L,32L,23L,35L,12L,15L,13L,24L,22L,25L,2L,14L,5L,28L,26L,27L,21L,8L,3L,6L,19L,7L,33L,20L,36L,0L,1L,17L,4L,30L,18L,31L,34L,29L,16L,10L,11L,9L,32L,23L,35L,12L,15L,13L,24L,22L,25L,2L,14L,5L,28L,26L,27L,21L,8L,3L,6L,19L,7L,33L,20L,36L,0L,1L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070718Inst : IEnumerable<long>
{
public static readonly long[] Value=A070718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070718.Bytes);
public long this[int i]=>Value[i];

public static A070718Inst Instance=new A070718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070717
{
public static readonly long[] Value={ 0L,1L,20L,27L,4L,5L,0L,7L,8L,9L,28L,11L,0L,13L,32L,27L,16L,17L,0L,19L,20L,9L,4L,23L,0L,25L,8L,27L,28L,29L,0L,31L,32L,9L,16L,35L,0L,1L,20L,27L,4L,5L,0L,7L,8L,9L,28L,11L,0L,13L,32L,27L,16L,17L,0L,19L,20L,9L,4L,23L,0L,25L,8L,27L,28L,29L,0L,31L,32L,9L,16L,35L,0L,1L,20L,27L,4L,5L,0L,7L,8L,9L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070717Inst : IEnumerable<long>
{
public static readonly long[] Value=A070717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070717.Bytes);
public long this[int i]=>Value[i];

public static A070717Inst Instance=new A070717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070716
{
public static readonly long[] Value={ 0L,1L,23L,17L,4L,5L,6L,28L,22L,9L,10L,11L,33L,27L,14L,15L,16L,3L,32L,19L,20L,21L,8L,2L,24L,25L,26L,13L,7L,29L,30L,31L,18L,12L,34L,0L,1L,23L,17L,4L,5L,6L,28L,22L,9L,10L,11L,33L,27L,14L,15L,16L,3L,32L,19L,20L,21L,8L,2L,24L,25L,26L,13L,7L,29L,30L,31L,18L,12L,34L,0L,1L,23L,17L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070716Inst : IEnumerable<long>
{
public static readonly long[] Value=A070716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070716.Bytes);
public long this[int i]=>Value[i];

public static A070716Inst Instance=new A070716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070715
{
public static readonly long[] Value={ 0L,1L,26L,11L,30L,27L,14L,29L,32L,19L,22L,3L,24L,21L,6L,25L,16L,17L,18L,9L,28L,13L,10L,31L,12L,15L,2L,5L,20L,7L,4L,23L,8L,33L,0L,1L,26L,11L,30L,27L,14L,29L,32L,19L,22L,3L,24L,21L,6L,25L,16L,17L,18L,9L,28L,13L,10L,31L,12L,15L,2L,5L,20L,7L,4L,23L,8L,33L,0L,1L,26L,11L,30L,27L,14L,29L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070715Inst : IEnumerable<long>
{
public static readonly long[] Value=A070715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070715.Bytes);
public long this[int i]=>Value[i];

public static A070715Inst Instance=new A070715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070714
{
public static readonly long[] Value={ 0L,1L,29L,9L,16L,14L,30L,28L,2L,15L,10L,11L,12L,7L,20L,27L,25L,8L,6L,13L,26L,21L,22L,23L,18L,31L,5L,3L,19L,17L,24L,4L,32L,0L,1L,29L,9L,16L,14L,30L,28L,2L,15L,10L,11L,12L,7L,20L,27L,25L,8L,6L,13L,26L,21L,22L,23L,18L,31L,5L,3L,19L,17L,24L,4L,32L,0L,1L,29L,9L,16L,14L,30L,28L,2L,15L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070714Inst : IEnumerable<long>
{
public static readonly long[] Value=A070714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070714.Bytes);
public long this[int i]=>Value[i];

public static A070714Inst Instance=new A070714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070713
{
public static readonly long[] Value={ 1L,4L,9L,22L,88L,144L,414L,441L,466L,646L,664L,889L,898L,988L,1111L,1177L,1224L,1242L,1339L,1393L,1422L,1717L,1771L,1933L,2124L,2142L,2214L,2241L,2266L,2338L,2383L,2412L,2421L,2626L,2662L,2833L,3139L,3193L,3238L,3283L,3319L,3328L,3355L,3382L,3391L,3535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070713Inst : IEnumerable<long>
{
public static readonly long[] Value=A070713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070713.Bytes);
public long this[int i]=>Value[i];

public static A070713Inst Instance=new A070713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070712
{
public static readonly long[] Value={ 0L,1L,4L,17L,16L,5L,6L,28L,2L,10L,20L,13L,24L,22L,19L,23L,8L,12L,9L,7L,18L,11L,21L,29L,3L,25L,26L,15L,14L,27L,30L,0L,1L,4L,17L,16L,5L,6L,28L,2L,10L,20L,13L,24L,22L,19L,23L,8L,12L,9L,7L,18L,11L,21L,29L,3L,25L,26L,15L,14L,27L,30L,0L,1L,4L,17L,16L,5L,6L,28L,2L,10L,20L,13L,24L,22L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070712Inst : IEnumerable<long>
{
public static readonly long[] Value=A070712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070712.Bytes);
public long this[int i]=>Value[i];

public static A070712Inst Instance=new A070712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070711
{
public static readonly long[] Value={ 0L,1L,8L,27L,4L,5L,6L,13L,2L,9L,10L,11L,18L,7L,14L,15L,16L,23L,12L,19L,20L,21L,28L,17L,24L,25L,26L,3L,22L,29L,0L,1L,8L,27L,4L,5L,6L,13L,2L,9L,10L,11L,18L,7L,14L,15L,16L,23L,12L,19L,20L,21L,28L,17L,24L,25L,26L,3L,22L,29L,0L,1L,8L,27L,4L,5L,6L,13L,2L,9L,10L,11L,18L,7L,14L,15L,16L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070711Inst : IEnumerable<long>
{
public static readonly long[] Value=A070711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070711.Bytes);
public long this[int i]=>Value[i];

public static A070711Inst Instance=new A070711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070710
{
public static readonly long[] Value={ 0L,1L,12L,12L,28L,28L,28L,1L,17L,28L,17L,12L,17L,28L,12L,17L,1L,12L,17L,12L,1L,12L,28L,1L,1L,1L,17L,17L,28L,0L,1L,12L,12L,28L,28L,28L,1L,17L,28L,17L,12L,17L,28L,12L,17L,1L,12L,17L,12L,1L,12L,28L,1L,1L,1L,17L,17L,28L,0L,1L,12L,12L,28L,28L,28L,1L,17L,28L,17L,12L,17L,28L,12L,17L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070710Inst : IEnumerable<long>
{
public static readonly long[] Value=A070710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070710.Bytes);
public long this[int i]=>Value[i];

public static A070710Inst Instance=new A070710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070709
{
public static readonly long[] Value={ 0L,1L,16L,3L,4L,5L,20L,7L,8L,9L,24L,11L,12L,13L,0L,15L,16L,17L,4L,19L,20L,21L,8L,23L,24L,25L,12L,27L,0L,1L,16L,3L,4L,5L,20L,7L,8L,9L,24L,11L,12L,13L,0L,15L,16L,17L,4L,19L,20L,21L,8L,23L,24L,25L,12L,27L,0L,1L,16L,3L,4L,5L,20L,7L,8L,9L,24L,11L,12L,13L,0L,15L,16L,17L,4L,19L,20L,21L,8L,23L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070709Inst : IEnumerable<long>
{
public static readonly long[] Value=A070709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070709.Bytes);
public long this[int i]=>Value[i];

public static A070709Inst Instance=new A070709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070708
{
public static readonly long[] Value={ 0L,1L,20L,0L,22L,14L,0L,16L,8L,0L,10L,2L,0L,4L,23L,0L,25L,17L,0L,19L,11L,0L,13L,5L,0L,7L,26L,0L,1L,20L,0L,22L,14L,0L,16L,8L,0L,10L,2L,0L,4L,23L,0L,25L,17L,0L,19L,11L,0L,13L,5L,0L,7L,26L,0L,1L,20L,0L,22L,14L,0L,16L,8L,0L,10L,2L,0L,4L,23L,0L,25L,17L,0L,19L,11L,0L,13L,5L,0L,7L,26L,0L,1L,20L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070708Inst : IEnumerable<long>
{
public static readonly long[] Value=A070708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070708.Bytes);
public long this[int i]=>Value[i];

public static A070708Inst Instance=new A070708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070707
{
public static readonly long[] Value={ 0L,1L,24L,3L,4L,21L,20L,19L,18L,9L,10L,15L,12L,13L,14L,11L,16L,17L,8L,7L,6L,5L,22L,23L,2L,25L,0L,1L,24L,3L,4L,21L,20L,19L,18L,9L,10L,15L,12L,13L,14L,11L,16L,17L,8L,7L,6L,5L,22L,23L,2L,25L,0L,1L,24L,3L,4L,21L,20L,19L,18L,9L,10L,15L,12L,13L,14L,11L,16L,17L,8L,7L,6L,5L,22L,23L,2L,25L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070707Inst : IEnumerable<long>
{
public static readonly long[] Value=A070707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070707.Bytes);
public long this[int i]=>Value[i];

public static A070707Inst Instance=new A070707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070706
{
public static readonly long[] Value={ 0L,1L,3L,12L,9L,0L,11L,18L,2L,19L,0L,21L,8L,17L,4L,0L,6L,23L,7L,14L,0L,16L,13L,22L,24L,0L,1L,3L,12L,9L,0L,11L,18L,2L,19L,0L,21L,8L,17L,4L,0L,6L,23L,7L,14L,0L,16L,13L,22L,24L,0L,1L,3L,12L,9L,0L,11L,18L,2L,19L,0L,21L,8L,17L,4L,0L,6L,23L,7L,14L,0L,16L,13L,22L,24L,0L,1L,3L,12L,9L,0L,11L,18L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070706Inst : IEnumerable<long>
{
public static readonly long[] Value=A070706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070706.Bytes);
public long this[int i]=>Value[i];

public static A070706Inst Instance=new A070706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070705
{
public static readonly long[] Value={ 2L,2L,2L,4L,4L,3L,1L,4L,8L,5L,14L,15L,5L,18L,1L,20L,16L,2L,15L,15L,8L,21L,29L,21L,16L,32L,29L,23L,22L,30L,54L,71L,37L,7L,37L,43L,45L,30L,36L,77L,100L,72L,64L,7L,56L,33L,42L,54L,132L,18L,90L,156L,91L,29L,86L,149L,139L,111L,112L,96L,62L,5L,204L,103L,41L,197L,81L,218L,128L,238L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070705Inst : IEnumerable<long>
{
public static readonly long[] Value=A070705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070705.Bytes);
public long this[int i]=>Value[i];

public static A070705Inst Instance=new A070705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070704
{
public static readonly long[] Value={ 0L,1L,13L,2L,8L,17L,3L,5L,12L,4L,14L,7L,16L,9L,19L,11L,18L,20L,6L,15L,21L,10L,22L,0L,1L,13L,2L,8L,17L,3L,5L,12L,4L,14L,7L,16L,9L,19L,11L,18L,20L,6L,15L,21L,10L,22L,0L,1L,13L,2L,8L,17L,3L,5L,12L,4L,14L,7L,16L,9L,19L,11L,18L,20L,6L,15L,21L,10L,22L,0L,1L,13L,2L,8L,17L,3L,5L,12L,4L,14L,7L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070704Inst : IEnumerable<long>
{
public static readonly long[] Value=A070704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070704.Bytes);
public long this[int i]=>Value[i];

public static A070704Inst Instance=new A070704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070703
{
public static readonly long[] Value={ 0L,1L,18L,9L,16L,3L,8L,17L,2L,15L,10L,11L,12L,7L,20L,5L,14L,19L,6L,13L,4L,21L,0L,1L,18L,9L,16L,3L,8L,17L,2L,15L,10L,11L,12L,7L,20L,5L,14L,19L,6L,13L,4L,21L,0L,1L,18L,9L,16L,3L,8L,17L,2L,15L,10L,11L,12L,7L,20L,5L,14L,19L,6L,13L,4L,21L,0L,1L,18L,9L,16L,3L,8L,17L,2L,15L,10L,11L,12L,7L,20L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070703Inst : IEnumerable<long>
{
public static readonly long[] Value=A070703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070703.Bytes);
public long this[int i]=>Value[i];

public static A070703Inst Instance=new A070703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070702
{
public static readonly long[] Value={ 0L,1L,8L,7L,4L,5L,16L,3L,12L,9L,0L,11L,8L,17L,4L,15L,16L,13L,12L,19L,0L,1L,8L,7L,4L,5L,16L,3L,12L,9L,0L,11L,8L,17L,4L,15L,16L,13L,12L,19L,0L,1L,8L,7L,4L,5L,16L,3L,12L,9L,0L,11L,8L,17L,4L,15L,16L,13L,12L,19L,0L,1L,8L,7L,4L,5L,16L,3L,12L,9L,0L,11L,8L,17L,4L,15L,16L,13L,12L,19L,0L,1L,8L,7L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070702Inst : IEnumerable<long>
{
public static readonly long[] Value=A070702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070702.Bytes);
public long this[int i]=>Value[i];

public static A070702Inst Instance=new A070702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070701
{
public static readonly long[] Value={ 0L,1L,14L,2L,6L,16L,9L,7L,8L,4L,15L,11L,12L,10L,3L,13L,17L,5L,18L,0L,1L,14L,2L,6L,16L,9L,7L,8L,4L,15L,11L,12L,10L,3L,13L,17L,5L,18L,0L,1L,14L,2L,6L,16L,9L,7L,8L,4L,15L,11L,12L,10L,3L,13L,17L,5L,18L,0L,1L,14L,2L,6L,16L,9L,7L,8L,4L,15L,11L,12L,10L,3L,13L,17L,5L,18L,0L,1L,14L,2L,6L,16L,9L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070701Inst : IEnumerable<long>
{
public static readonly long[] Value=A070701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070701.Bytes);
public long this[int i]=>Value[i];

public static A070701Inst Instance=new A070701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070700
{
public static readonly long[] Value={ 0L,1L,2L,9L,4L,5L,0L,7L,8L,9L,10L,11L,0L,13L,14L,9L,16L,17L,0L,1L,2L,9L,4L,5L,0L,7L,8L,9L,10L,11L,0L,13L,14L,9L,16L,17L,0L,1L,2L,9L,4L,5L,0L,7L,8L,9L,10L,11L,0L,13L,14L,9L,16L,17L,0L,1L,2L,9L,4L,5L,0L,7L,8L,9L,10L,11L,0L,13L,14L,9L,16L,17L,0L,1L,2L,9L,4L,5L,0L,7L,8L,9L,10L,11L,0L,13L,14L,9L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070700Inst : IEnumerable<long>
{
public static readonly long[] Value=A070700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070700.Bytes);
public long this[int i]=>Value[i];

public static A070700Inst Instance=new A070700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070699
{
public static readonly long[] Value={ 0L,1L,9L,11L,13L,10L,14L,12L,15L,2L,5L,3L,7L,4L,6L,8L,16L,0L,1L,9L,11L,13L,10L,14L,12L,15L,2L,5L,3L,7L,4L,6L,8L,16L,0L,1L,9L,11L,13L,10L,14L,12L,15L,2L,5L,3L,7L,4L,6L,8L,16L,0L,1L,9L,11L,13L,10L,14L,12L,15L,2L,5L,3L,7L,4L,6L,8L,16L,0L,1L,9L,11L,13L,10L,14L,12L,15L,2L,5L,3L,7L,4L,6L,8L,16L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070699Inst : IEnumerable<long>
{
public static readonly long[] Value=A070699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070699.Bytes);
public long this[int i]=>Value[i];

public static A070699Inst Instance=new A070699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070698
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,29L,39L,49L,59L,69L,79L,89L,99L,101L,102L,103L,104L,105L,106L,107L,108L,109L,119L,129L,139L,149L,159L,169L,179L,189L,199L,299L,399L,499L,599L,699L,799L,899L,999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070698Inst : IEnumerable<long>
{
public static readonly long[] Value=A070698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070698.Bytes);
public long this[int i]=>Value[i];

public static A070698Inst Instance=new A070698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070697
{
public static readonly long[] Value={ 0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070697Inst : IEnumerable<long>
{
public static readonly long[] Value=A070697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070697.Bytes);
public long this[int i]=>Value[i];

public static A070697Inst Instance=new A070697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070696
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,0L,1L,2L,3L,4L,5L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070696Inst : IEnumerable<long>
{
public static readonly long[] Value=A070696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070696.Bytes);
public long this[int i]=>Value[i];

public static A070696Inst Instance=new A070696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070695
{
public static readonly long[] Value={ 0L,1L,11L,3L,4L,8L,7L,6L,5L,9L,10L,2L,12L,0L,1L,11L,3L,4L,8L,7L,6L,5L,9L,10L,2L,12L,0L,1L,11L,3L,4L,8L,7L,6L,5L,9L,10L,2L,12L,0L,1L,11L,3L,4L,8L,7L,6L,5L,9L,10L,2L,12L,0L,1L,11L,3L,4L,8L,7L,6L,5L,9L,10L,2L,12L,0L,1L,11L,3L,4L,8L,7L,6L,5L,9L,10L,2L,12L,0L,1L,11L,3L,4L,8L,7L,6L,5L,9L,10L,2L,12L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070695Inst : IEnumerable<long>
{
public static readonly long[] Value=A070695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070695.Bytes);
public long this[int i]=>Value[i];

public static A070695Inst Instance=new A070695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070694
{
public static readonly long[] Value={ 1L,2L,337536L,585106L,602056L,2071960L,11861410L,20706120L,54020170L,72696726L,87584646L,89445636L,95895930L,98583340L,98595070L,112204200L,205739220L,279448296L,292582836L,337969690L,349672456L,432972780L,437874186L,474186576L,479631880L,483333426L,621777466L,643697776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070694Inst : IEnumerable<long>
{
public static readonly long[] Value=A070694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070694.Bytes);
public long this[int i]=>Value[i];

public static A070694Inst Instance=new A070694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070693
{
public static readonly long[] Value={ 0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L,0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L,0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L,0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L,0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L,0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L,0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L,0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L,0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070693Inst : IEnumerable<long>
{
public static readonly long[] Value=A070693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070693.Bytes);
public long this[int i]=>Value[i];

public static A070693Inst Instance=new A070693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070692
{
public static readonly long[] Value={ 0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070692Inst : IEnumerable<long>
{
public static readonly long[] Value=A070692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070692.Bytes);
public long this[int i]=>Value[i];

public static A070692Inst Instance=new A070692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070691
{
public static readonly ulong[] Value={ 1L,4L,27L,256L,3125L,46656L,823543L,16777216L,387420489L,1L,2048L,531441L,67108864L,6103515625L,470184984576L,33232930569601L,2251799813685248L,150094635296999121L,10000000000000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070691Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A070691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070691.Bytes);
public ulong this[int i]=>Value[i];

public static A070691Inst Instance=new A070691Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070690
{
public static readonly long[] Value={ 0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070690Inst : IEnumerable<long>
{
public static readonly long[] Value=A070690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070690.Bytes);
public long this[int i]=>Value[i];

public static A070690Inst Instance=new A070690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070689
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,16L,36L,40L,66L,126L,130L,150L,156L,180L,210L,240L,250L,256L,270L,280L,306L,396L,400L,420L,430L,466L,490L,556L,570L,576L,646L,690L,700L,750L,760L,826L,906L,910L,936L,946L,966L,1060L,1096L,1150L,1276L,1290L,1306L,1320L,1366L,1566L,1570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070689Inst : IEnumerable<long>
{
public static readonly long[] Value=A070689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070689.Bytes);
public long this[int i]=>Value[i];

public static A070689Inst Instance=new A070689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070688
{
public static readonly long[] Value={ 0L,1L,16L,9L,16L,25L,0L,1L,16L,33L,16L,25L,0L,25L,16L,33L,16L,1L,0L,25L,16L,9L,16L,1L,0L,1L,16L,9L,16L,25L,0L,1L,16L,33L,16L,25L,0L,25L,16L,33L,16L,1L,0L,25L,16L,9L,16L,1L,0L,1L,16L,9L,16L,25L,0L,1L,16L,33L,16L,25L,0L,25L,16L,33L,16L,1L,0L,25L,16L,9L,16L,1L,0L,1L,16L,9L,16L,25L,0L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070688Inst : IEnumerable<long>
{
public static readonly long[] Value=A070688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070688.Bytes);
public long this[int i]=>Value[i];

public static A070688Inst Instance=new A070688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070687
{
public static readonly long[] Value={ 0L,1L,17L,24L,7L,21L,32L,8L,25L,12L,28L,37L,27L,3L,42L,34L,2L,14L,16L,9L,6L,4L,18L,36L,36L,18L,4L,6L,9L,16L,14L,2L,34L,42L,3L,27L,37L,28L,12L,25L,8L,32L,21L,7L,24L,17L,1L,0L,1L,17L,24L,7L,21L,32L,8L,25L,12L,28L,37L,27L,3L,42L,34L,2L,14L,16L,9L,6L,4L,18L,36L,36L,18L,4L,6L,9L,16L,14L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070687Inst : IEnumerable<long>
{
public static readonly long[] Value=A070687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070687.Bytes);
public long this[int i]=>Value[i];

public static A070687Inst Instance=new A070687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070686
{
public static readonly long[] Value={ 0L,1L,18L,39L,2L,31L,12L,27L,36L,3L,6L,9L,32L,29L,26L,13L,4L,35L,8L,25L,16L,41L,24L,23L,24L,41L,16L,25L,8L,35L,4L,13L,26L,29L,32L,9L,6L,3L,36L,27L,12L,31L,2L,39L,18L,1L,0L,1L,18L,39L,2L,31L,12L,27L,36L,3L,6L,9L,32L,29L,26L,13L,4L,35L,8L,25L,16L,41L,24L,23L,24L,41L,16L,25L,8L,35L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070686Inst : IEnumerable<long>
{
public static readonly long[] Value=A070686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070686.Bytes);
public long this[int i]=>Value[i];

public static A070686Inst Instance=new A070686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070685
{
public static readonly long[] Value={ 0L,1L,19L,9L,1L,10L,36L,19L,19L,36L,10L,1L,9L,19L,1L,0L,1L,19L,9L,1L,10L,36L,19L,19L,36L,10L,1L,9L,19L,1L,0L,1L,19L,9L,1L,10L,36L,19L,19L,36L,10L,1L,9L,19L,1L,0L,1L,19L,9L,1L,10L,36L,19L,19L,36L,10L,1L,9L,19L,1L,0L,1L,19L,9L,1L,10L,36L,19L,19L,36L,10L,1L,9L,19L,1L,0L,1L,19L,9L,1L,10L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070685Inst : IEnumerable<long>
{
public static readonly long[] Value=A070685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070685.Bytes);
public long this[int i]=>Value[i];

public static A070685Inst Instance=new A070685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070684
{
public static readonly long[] Value={ 0L,1L,20L,25L,4L,5L,16L,37L,36L,9L,12L,33L,12L,9L,36L,37L,16L,5L,4L,25L,20L,1L,0L,1L,20L,25L,4L,5L,16L,37L,36L,9L,12L,33L,12L,9L,36L,37L,16L,5L,4L,25L,20L,1L,0L,1L,20L,25L,4L,5L,16L,37L,36L,9L,12L,33L,12L,9L,36L,37L,16L,5L,4L,25L,20L,1L,0L,1L,20L,25L,4L,5L,16L,37L,36L,9L,12L,33L,12L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070684Inst : IEnumerable<long>
{
public static readonly long[] Value=A070684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070684.Bytes);
public long this[int i]=>Value[i];

public static A070684Inst Instance=new A070684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070683
{
public static readonly long[] Value={ 0L,0L,4L,6L,0L,1L,2L,0L,16L,6L,0L,11L,20L,0L,4L,30L,0L,12L,9L,0L,40L,42L,0L,23L,42L,0L,52L,4L,0L,29L,15L,0L,4L,66L,0L,35L,36L,0L,6L,26L,0L,41L,16L,0L,8L,6L,0L,12L,16L,0L,100L,102L,0L,53L,54L,0L,112L,44L,0L,48L,11L,0L,100L,126L,0L,65L,6L,0L,136L,138L,0L,2L,4L,0L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070683Inst : IEnumerable<long>
{
public static readonly long[] Value=A070683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070683.Bytes);
public long this[int i]=>Value[i];

public static A070683Inst Instance=new A070683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070682
{
public static readonly long[] Value={ 0L,1L,0L,6L,1L,2L,6L,0L,16L,18L,6L,22L,0L,3L,28L,15L,2L,0L,3L,6L,5L,21L,0L,46L,42L,16L,13L,0L,18L,58L,60L,6L,0L,33L,22L,35L,8L,0L,6L,13L,9L,41L,0L,28L,44L,6L,15L,0L,96L,2L,4L,34L,0L,53L,108L,3L,112L,0L,6L,48L,22L,5L,0L,42L,21L,130L,18L,0L,8L,46L,46L,6L,0L,42L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070682Inst : IEnumerable<long>
{
public static readonly long[] Value=A070682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070682.Bytes);
public long this[int i]=>Value[i];

public static A070682Inst Instance=new A070682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070681
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,10L,12L,0L,16L,9L,0L,11L,5L,0L,14L,6L,0L,2L,4L,0L,40L,3L,0L,23L,14L,0L,26L,10L,0L,58L,60L,0L,12L,33L,0L,35L,36L,0L,10L,78L,0L,82L,16L,0L,88L,12L,0L,9L,12L,0L,10L,102L,0L,106L,108L,0L,112L,11L,0L,16L,110L,0L,25L,126L,0L,130L,18L,0L,136L,23L,0L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070681Inst : IEnumerable<long>
{
public static readonly long[] Value=A070681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070681.Bytes);
public long this[int i]=>Value[i];

public static A070681Inst Instance=new A070681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070680
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,2L,3L,2L,6L,1L,0L,2L,12L,3L,2L,4L,16L,6L,3L,2L,6L,0L,22L,2L,5L,12L,18L,6L,28L,2L,30L,8L,0L,16L,3L,6L,6L,3L,12L,2L,40L,6L,7L,0L,6L,22L,46L,4L,21L,5L,16L,12L,26L,18L,0L,6L,6L,28L,58L,2L,4L,30L,6L,16L,12L,0L,66L,16L,22L,3L,70L,6L,72L,6L,10L,6L,0L,12L,39L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070680Inst : IEnumerable<long>
{
public static readonly long[] Value=A070680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070680.Bytes);
public long this[int i]=>Value[i];

public static A070680Inst Instance=new A070680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070679
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,0L,3L,1L,0L,2L,5L,0L,3L,3L,0L,2L,8L,0L,9L,2L,0L,5L,11L,0L,10L,3L,0L,3L,14L,0L,15L,4L,0L,8L,6L,0L,9L,9L,0L,2L,4L,0L,21L,5L,0L,11L,23L,0L,21L,10L,0L,3L,26L,0L,10L,3L,0L,14L,29L,0L,5L,15L,0L,8L,6L,0L,11L,8L,0L,6L,35L,0L,6L,9L,0L,9L,15L,0L,39L,2L,0L,4L,41L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070679Inst : IEnumerable<long>
{
public static readonly long[] Value=A070679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070679.Bytes);
public long this[int i]=>Value[i];

public static A070679Inst Instance=new A070679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070678
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,1L,0L,2L,3L,4L,10L,2L,12L,0L,4L,2L,16L,3L,3L,4L,0L,10L,22L,2L,4L,12L,9L,0L,7L,4L,15L,4L,10L,16L,0L,6L,9L,3L,12L,4L,40L,0L,6L,10L,12L,22L,23L,2L,0L,4L,16L,12L,26L,9L,20L,0L,3L,7L,29L,4L,60L,15L,0L,8L,12L,10L,66L,16L,22L,0L,70L,6L,24L,9L,4L,6L,0L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070678Inst : IEnumerable<long>
{
public static readonly long[] Value=A070678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070678.Bytes);
public long this[int i]=>Value[i];

public static A070678Inst Instance=new A070678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070677
{
public static readonly long[] Value={ 0L,1L,2L,1L,0L,2L,6L,2L,6L,0L,5L,2L,4L,6L,0L,4L,16L,6L,9L,0L,6L,5L,22L,2L,0L,4L,18L,6L,14L,0L,3L,8L,10L,16L,0L,6L,36L,9L,4L,0L,20L,6L,42L,5L,0L,22L,46L,4L,42L,0L,16L,4L,52L,18L,0L,6L,18L,14L,29L,0L,30L,3L,6L,16L,0L,10L,22L,16L,22L,0L,5L,6L,72L,36L,0L,9L,30L,4L,39L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070677Inst : IEnumerable<long>
{
public static readonly long[] Value=A070677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070677.Bytes);
public long this[int i]=>Value[i];

public static A070677Inst Instance=new A070677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070676
{
public static readonly long[] Value={ 0L,1L,0L,2L,4L,0L,6L,2L,0L,4L,5L,0L,3L,6L,0L,4L,16L,0L,18L,4L,0L,5L,11L,0L,20L,3L,0L,6L,28L,0L,30L,8L,0L,16L,12L,0L,18L,18L,0L,4L,8L,0L,42L,10L,0L,11L,23L,0L,42L,20L,0L,6L,52L,0L,20L,6L,0L,28L,29L,0L,10L,30L,0L,16L,12L,0L,22L,16L,0L,12L,35L,0L,12L,18L,0L,18L,30L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070676Inst : IEnumerable<long>
{
public static readonly long[] Value=A070676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070676.Bytes);
public long this[int i]=>Value[i];

public static A070676Inst Instance=new A070676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070675
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,6L,3L,8L,9L,2L,5L,12L,13L,4L,7L,16L,17L,18L,9L,8L,3L,22L,5L,4L,25L,26L,13L,28L,11L,2L,15L,2L,33L,6L,17L,36L,37L,14L,9L,4L,13L,42L,3L,19L,45L,46L,7L,48L,9L,16L,25L,52L,53L,4L,13L,20L,57L,58L,11L,3L,15L,8L,31L,14L,5L,66L,33L,22L,29L,5L,17L,72L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070675Inst : IEnumerable<long>
{
public static readonly long[] Value=A070675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070675.Bytes);
public long this[int i]=>Value[i];

public static A070675Inst Instance=new A070675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070674
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,1L,3L,9L,1L,1L,1L,7L,4L,1L,4L,1L,1L,1L,1L,3L,4L,9L,1L,1L,5L,1L,1L,1L,11L,13L,7L,5L,16L,1L,1L,25L,6L,1L,16L,1L,1L,1L,18L,1L,1L,9L,1L,7L,1L,9L,4L,1L,1L,1L,13L,5L,4L,1L,16L,1L,29L,1L,1L,11L,1L,25L,2L,7L,1L,5L,23L,55L,23L,1L,10L,1L,1L,25L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070674Inst : IEnumerable<long>
{
public static readonly long[] Value=A070674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070674.Bytes);
public long this[int i]=>Value[i];

public static A070674Inst Instance=new A070674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070673
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,5L,6L,3L,8L,3L,10L,5L,5L,13L,2L,3L,2L,17L,18L,3L,8L,21L,22L,5L,7L,5L,26L,13L,12L,7L,30L,3L,10L,9L,6L,17L,6L,37L,5L,3L,3L,13L,42L,21L,8L,45L,46L,5L,48L,7L,2L,5L,23L,53L,12L,13L,20L,17L,58L,7L,11L,61L,8L,7L,8L,23L,66L,9L,22L,13L,70L,17L,10L,31L,7L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070673Inst : IEnumerable<long>
{
public static readonly long[] Value=A070673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070673.Bytes);
public long this[int i]=>Value[i];

public static A070673Inst Instance=new A070673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070672
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,20L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,11L,7L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070672Inst : IEnumerable<long>
{
public static readonly long[] Value=A070672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070672.Bytes);
public long this[int i]=>Value[i];

public static A070672Inst Instance=new A070672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070671
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,2L,3L,2L,9L,10L,5L,3L,3L,4L,7L,16L,5L,7L,9L,2L,21L,22L,5L,24L,3L,8L,3L,28L,11L,5L,15L,10L,33L,4L,5L,10L,7L,4L,9L,40L,5L,6L,21L,4L,45L,46L,7L,18L,49L,16L,3L,52L,17L,21L,3L,7L,57L,58L,11L,13L,5L,2L,31L,4L,23L,29L,33L,22L,9L,70L,5L,8L,11L,26L,7L,10L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070671Inst : IEnumerable<long>
{
public static readonly long[] Value=A070671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070671.Bytes);
public long this[int i]=>Value[i];

public static A070671Inst Instance=new A070671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070670
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,6L,1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,1L,1L,1L,1L,1L,10L,1L,1L,5L,1L,1L,1L,1L,1L,11L,1L,1L,1L,1L,16L,1L,1L,1L,1L,1L,9L,33L,1L,1L,1L,25L,1L,1L,1L,1L,5L,1L,1L,1L,16L,1L,15L,1L,1L,1L,1L,37L,1L,1L,1L,1L,1L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070670Inst : IEnumerable<long>
{
public static readonly long[] Value=A070670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070670.Bytes);
public long this[int i]=>Value[i];

public static A070670Inst Instance=new A070670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070669
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,5L,6L,3L,8L,3L,10L,5L,5L,13L,2L,3L,4L,17L,18L,3L,8L,21L,22L,5L,7L,5L,26L,13L,12L,7L,30L,7L,10L,13L,6L,17L,6L,37L,5L,3L,9L,13L,42L,21L,8L,45L,46L,5L,48L,7L,4L,5L,23L,53L,12L,13L,20L,17L,58L,7L,11L,61L,8L,15L,8L,23L,66L,13L,22L,13L,70L,17L,27L,31L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070669Inst : IEnumerable<long>
{
public static readonly long[] Value=A070669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070669.Bytes);
public long this[int i]=>Value[i];

public static A070669Inst Instance=new A070669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070668
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,1L,3L,9L,1L,1L,1L,7L,7L,1L,4L,1L,1L,1L,1L,3L,10L,9L,1L,1L,5L,1L,1L,1L,11L,13L,10L,7L,16L,1L,1L,25L,6L,1L,16L,1L,1L,1L,18L,1L,1L,9L,1L,19L,1L,9L,7L,1L,1L,1L,13L,5L,4L,1L,16L,1L,29L,1L,1L,11L,1L,25L,8L,47L,1L,45L,23L,55L,23L,1L,28L,1L,1L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070668Inst : IEnumerable<long>
{
public static readonly long[] Value=A070668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070668.Bytes);
public long this[int i]=>Value[i];

public static A070668Inst Instance=new A070668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070667
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,6L,3L,8L,9L,10L,5L,12L,13L,4L,7L,16L,17L,18L,9L,8L,21L,22L,5L,24L,25L,26L,13L,28L,11L,30L,15L,10L,33L,6L,17L,36L,37L,14L,9L,40L,13L,42L,21L,19L,45L,46L,7L,48L,49L,16L,25L,52L,53L,21L,13L,20L,57L,58L,11L,60L,61L,8L,31L,14L,23L,66L,33L,22L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070667Inst : IEnumerable<long>
{
public static readonly long[] Value=A070667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070667.Bytes);
public long this[int i]=>Value[i];

public static A070667Inst Instance=new A070667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070666
{
public static readonly long[] Value={ 0L,1L,21L,41L,11L,16L,1L,1L,16L,4L,35L,4L,21L,16L,21L,11L,35L,35L,41L,11L,4L,41L,41L,4L,11L,41L,35L,35L,11L,21L,16L,21L,4L,35L,4L,16L,1L,1L,16L,11L,41L,21L,1L,0L,1L,21L,41L,11L,16L,1L,1L,16L,4L,35L,4L,21L,16L,21L,11L,35L,35L,41L,11L,4L,41L,41L,4L,11L,41L,35L,35L,11L,21L,16L,21L,4L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070666Inst : IEnumerable<long>
{
public static readonly long[] Value=A070666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070666.Bytes);
public long this[int i]=>Value[i];

public static A070666Inst Instance=new A070666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070665
{
public static readonly long[] Value={ 0L,1L,22L,15L,22L,1L,36L,7L,22L,15L,22L,1L,36L,1L,28L,15L,22L,1L,36L,1L,22L,21L,22L,1L,36L,1L,22L,15L,28L,1L,36L,1L,22L,15L,22L,7L,36L,1L,22L,15L,22L,1L,0L,1L,22L,15L,22L,1L,36L,7L,22L,15L,22L,1L,36L,1L,28L,15L,22L,1L,36L,1L,22L,21L,22L,1L,36L,1L,22L,15L,28L,1L,36L,1L,22L,15L,22L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070665Inst : IEnumerable<long>
{
public static readonly long[] Value=A070665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070665.Bytes);
public long this[int i]=>Value[i];

public static A070665Inst Instance=new A070665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070664
{
public static readonly long[] Value={ 0L,1L,23L,32L,37L,4L,39L,20L,31L,40L,10L,33L,36L,2L,9L,5L,16L,8L,18L,21L,25L,25L,21L,18L,8L,16L,5L,9L,2L,36L,33L,10L,40L,31L,20L,39L,4L,37L,32L,23L,1L,0L,1L,23L,32L,37L,4L,39L,20L,31L,40L,10L,33L,36L,2L,9L,5L,16L,8L,18L,21L,25L,25L,21L,18L,8L,16L,5L,9L,2L,36L,33L,10L,40L,31L,20L,39L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070664Inst : IEnumerable<long>
{
public static readonly long[] Value=A070664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070664.Bytes);
public long this[int i]=>Value[i];

public static A070664Inst Instance=new A070664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070663
{
public static readonly long[] Value={ 0L,1L,24L,9L,16L,25L,16L,9L,24L,1L,0L,1L,24L,9L,16L,25L,16L,9L,24L,1L,0L,1L,24L,9L,16L,25L,16L,9L,24L,1L,0L,1L,24L,9L,16L,25L,16L,9L,24L,1L,0L,1L,24L,9L,16L,25L,16L,9L,24L,1L,0L,1L,24L,9L,16L,25L,16L,9L,24L,1L,0L,1L,24L,9L,16L,25L,16L,9L,24L,1L,0L,1L,24L,9L,16L,25L,16L,9L,24L,1L,0L,1L,24L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070663Inst : IEnumerable<long>
{
public static readonly long[] Value=A070663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070663.Bytes);
public long this[int i]=>Value[i];

public static A070663Inst Instance=new A070663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070662
{
public static readonly long[] Value={ 0L,1L,25L,27L,1L,25L,12L,25L,25L,27L,1L,25L,27L,13L,1L,12L,1L,1L,12L,25L,25L,12L,1L,1L,12L,1L,13L,27L,25L,1L,27L,25L,25L,12L,25L,1L,27L,25L,1L,0L,1L,25L,27L,1L,25L,12L,25L,25L,27L,1L,25L,27L,13L,1L,12L,1L,1L,12L,25L,25L,12L,1L,1L,12L,1L,13L,27L,25L,1L,27L,25L,25L,12L,25L,1L,27L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070662Inst : IEnumerable<long>
{
public static readonly long[] Value=A070662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070662.Bytes);
public long this[int i]=>Value[i];

public static A070662Inst Instance=new A070662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070661
{
public static readonly long[] Value={ 0L,1L,26L,7L,30L,7L,30L,1L,20L,11L,30L,1L,20L,11L,26L,11L,26L,7L,20L,19L,20L,7L,26L,11L,26L,11L,20L,1L,30L,11L,20L,1L,30L,7L,30L,7L,26L,1L,0L,1L,26L,7L,30L,7L,30L,1L,20L,11L,30L,1L,20L,11L,26L,11L,26L,7L,20L,19L,20L,7L,26L,11L,26L,11L,20L,1L,30L,11L,20L,1L,30L,7L,30L,7L,26L,1L,0L,1L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070661Inst : IEnumerable<long>
{
public static readonly long[] Value=A070661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070661.Bytes);
public long this[int i]=>Value[i];

public static A070661Inst Instance=new A070661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070660
{
public static readonly long[] Value={ 0L,1L,27L,26L,26L,11L,36L,26L,36L,10L,1L,1L,10L,11L,36L,27L,10L,27L,11L,11L,27L,10L,27L,36L,11L,10L,1L,1L,10L,36L,26L,36L,11L,26L,26L,27L,1L,0L,1L,27L,26L,26L,11L,36L,26L,36L,10L,1L,1L,10L,11L,36L,27L,10L,27L,11L,11L,27L,10L,27L,36L,11L,10L,1L,1L,10L,36L,26L,36L,11L,26L,26L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070660Inst : IEnumerable<long>
{
public static readonly long[] Value=A070660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070660.Bytes);
public long this[int i]=>Value[i];

public static A070660Inst Instance=new A070660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070643
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070643Inst : IEnumerable<long>
{
public static readonly long[] Value=A070643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070643.Bytes);
public long this[int i]=>Value[i];

public static A070643Inst Instance=new A070643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070642
{
public static readonly long[] Value={ 0L,1L,7L,7L,11L,7L,11L,1L,1L,11L,11L,1L,1L,11L,7L,11L,7L,7L,1L,0L,1L,7L,7L,11L,7L,11L,1L,1L,11L,11L,1L,1L,11L,7L,11L,7L,7L,1L,0L,1L,7L,7L,11L,7L,11L,1L,1L,11L,11L,1L,1L,11L,7L,11L,7L,7L,1L,0L,1L,7L,7L,11L,7L,11L,1L,1L,11L,11L,1L,1L,11L,7L,11L,7L,7L,1L,0L,1L,7L,7L,11L,7L,11L,1L,1L,11L,11L,1L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070642Inst : IEnumerable<long>
{
public static readonly long[] Value=A070642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070642.Bytes);
public long this[int i]=>Value[i];

public static A070642Inst Instance=new A070642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070641
{
public static readonly long[] Value={ 0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070641Inst : IEnumerable<long>
{
public static readonly long[] Value=A070641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070641.Bytes);
public long this[int i]=>Value[i];

public static A070641Inst Instance=new A070641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070640
{
public static readonly long[] Value={ 0L,1L,13L,15L,16L,2L,8L,9L,4L,4L,9L,8L,2L,16L,15L,13L,1L,0L,1L,13L,15L,16L,2L,8L,9L,4L,4L,9L,8L,2L,16L,15L,13L,1L,0L,1L,13L,15L,16L,2L,8L,9L,4L,4L,9L,8L,2L,16L,15L,13L,1L,0L,1L,13L,15L,16L,2L,8L,9L,4L,4L,9L,8L,2L,16L,15L,13L,1L,0L,1L,13L,15L,16L,2L,8L,9L,4L,4L,9L,8L,2L,16L,15L,13L,1L,0L,1L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070640Inst : IEnumerable<long>
{
public static readonly long[] Value=A070640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070640.Bytes);
public long this[int i]=>Value[i];

public static A070640Inst Instance=new A070640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070639
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,20L,19L,31L,33L,48L,43L,73L,59L,90L,88L,111L,97L,159L,121L,182L,165L,208L,173L,277L,211L,290L,263L,338L,271L,445L,309L,435L,396L,490L,414L,608L,433L,610L,544L,695L,531L,844L,585L,818L,745L,880L,697L,1080L,773L,1085L,918L,1126L,883L,1364L,995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070639Inst : IEnumerable<long>
{
public static readonly long[] Value=A070639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070639.Bytes);
public long this[int i]=>Value[i];

public static A070639Inst Instance=new A070639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070638
{
public static readonly long[] Value={ 0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070638Inst : IEnumerable<long>
{
public static readonly long[] Value=A070638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070638.Bytes);
public long this[int i]=>Value[i];

public static A070638Inst Instance=new A070638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070637
{
public static readonly long[] Value={ 0L,1L,8L,1L,8L,1L,8L,7L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,7L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,7L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,7L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,7L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,7L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,7L,8L,1L,8L,1L,8L,1L,0L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070637Inst : IEnumerable<long>
{
public static readonly long[] Value=A070637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070637.Bytes);
public long this[int i]=>Value[i];

public static A070637Inst Instance=new A070637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070636
{
public static readonly long[] Value={ 0L,1L,12L,1L,1L,12L,12L,12L,12L,1L,1L,12L,1L,0L,1L,12L,1L,1L,12L,12L,12L,12L,1L,1L,12L,1L,0L,1L,12L,1L,1L,12L,12L,12L,12L,1L,1L,12L,1L,0L,1L,12L,1L,1L,12L,12L,12L,12L,1L,1L,12L,1L,0L,1L,12L,1L,1L,12L,12L,12L,12L,1L,1L,12L,1L,0L,1L,12L,1L,1L,12L,12L,12L,12L,1L,1L,12L,1L,0L,1L,12L,1L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070636Inst : IEnumerable<long>
{
public static readonly long[] Value=A070636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070636.Bytes);
public long this[int i]=>Value[i];

public static A070636Inst Instance=new A070636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070635
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,4L,3L,2L,1L,0L,9L,0L,0L,2L,3L,0L,4L,2L,0L,8L,7L,0L,3L,2L,3L,6L,3L,0L,7L,5L,3L,0L,1L,0L,1L,4L,0L,6L,3L,0L,10L,0L,3L,3L,5L,0L,5L,1L,9L,6L,3L,0L,5L,6L,0L,4L,10L,6L,2L,12L,9L,0L,7L,0L,3L,8L,3L,11L,7L,3L,15L,0L,0L,2L,6L,0L,7L,2L,12L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070635Inst : IEnumerable<long>
{
public static readonly long[] Value=A070635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070635.Bytes);
public long this[int i]=>Value[i];

public static A070635Inst Instance=new A070635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070634
{
public static readonly long[] Value={ 0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070634Inst : IEnumerable<long>
{
public static readonly long[] Value=A070634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070634.Bytes);
public long this[int i]=>Value[i];

public static A070634Inst Instance=new A070634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070633
{
public static readonly long[] Value={ 2L,5L,2L,9L,2L,9L,2L,14L,2L,7L,2L,19L,2L,5L,2L,20L,2L,13L,2L,16L,2L,7L,2L,34L,2L,5L,2L,11L,2L,13L,2L,27L,2L,5L,2L,31L,2L,5L,2L,30L,2L,13L,2L,14L,2L,7L,2L,51L,2L,7L,2L,11L,2L,15L,2L,19L,2L,7L,2L,37L,2L,5L,2L,35L,2L,13L,2L,9L,2L,9L,2L,63L,2L,5L,2L,9L,2L,11L,2L,46L,2L,7L,2L,31L,2L,5L,2L,25L,2L,17L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070633Inst : IEnumerable<long>
{
public static readonly long[] Value=A070633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070633.Bytes);
public long this[int i]=>Value[i];

public static A070633Inst Instance=new A070633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070632
{
public static readonly BigInteger[] Value={ 1L,19L,1657009L,BigInteger.Parse("9950006745799417075771"),BigInteger.Parse("19389268200585836264288587113776883575610248525384021488302948711030121") };
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
public class A070632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070632Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070632.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A070632.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070632Inst Instance=new A070632Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070631
{
public static readonly long[] Value={ 0L,1L,32L,3L,16L,5L,0L,7L,32L,9L,16L,11L,0L,13L,32L,15L,16L,17L,0L,19L,32L,21L,16L,23L,0L,25L,32L,27L,16L,29L,0L,31L,32L,33L,16L,35L,0L,37L,32L,39L,16L,41L,0L,43L,32L,45L,16L,47L,0L,1L,32L,3L,16L,5L,0L,7L,32L,9L,16L,11L,0L,13L,32L,15L,16L,17L,0L,19L,32L,21L,16L,23L,0L,25L,32L,27L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070631Inst : IEnumerable<long>
{
public static readonly long[] Value=A070631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070631.Bytes);
public long this[int i]=>Value[i];

public static A070631Inst Instance=new A070631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070630
{
public static readonly long[] Value={ 0L,1L,32L,8L,37L,23L,21L,28L,9L,17L,31L,29L,14L,40L,3L,43L,6L,34L,27L,45L,5L,36L,35L,22L,25L,12L,11L,42L,2L,20L,13L,41L,4L,44L,7L,33L,18L,16L,30L,38L,19L,26L,24L,10L,39L,15L,46L,0L,1L,32L,8L,37L,23L,21L,28L,9L,17L,31L,29L,14L,40L,3L,43L,6L,34L,27L,45L,5L,36L,35L,22L,25L,12L,11L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070630Inst : IEnumerable<long>
{
public static readonly long[] Value=A070630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070630.Bytes);
public long this[int i]=>Value[i];

public static A070630Inst Instance=new A070630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070629
{
public static readonly long[] Value={ 0L,1L,32L,13L,12L,43L,2L,17L,16L,31L,42L,5L,18L,27L,38L,7L,6L,21L,26L,11L,10L,37L,22L,23L,24L,9L,36L,35L,20L,25L,40L,39L,8L,19L,28L,41L,4L,15L,30L,29L,44L,3L,34L,33L,14L,45L,0L,1L,32L,13L,12L,43L,2L,17L,16L,31L,42L,5L,18L,27L,38L,7L,6L,21L,26L,11L,10L,37L,22L,23L,24L,9L,36L,35L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070629Inst : IEnumerable<long>
{
public static readonly long[] Value=A070629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070629.Bytes);
public long this[int i]=>Value[i];

public static A070629Inst Instance=new A070629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070628
{
public static readonly long[] Value={ 0L,1L,32L,18L,34L,20L,36L,22L,8L,9L,10L,41L,27L,43L,29L,0L,31L,17L,18L,19L,5L,36L,7L,38L,9L,40L,26L,27L,28L,14L,0L,16L,2L,18L,4L,35L,36L,37L,23L,9L,25L,11L,27L,13L,44L,0L,1L,32L,18L,34L,20L,36L,22L,8L,9L,10L,41L,27L,43L,29L,0L,31L,17L,18L,19L,5L,36L,7L,38L,9L,40L,26L,27L,28L,14L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070628Inst : IEnumerable<long>
{
public static readonly long[] Value=A070628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070628.Bytes);
public long this[int i]=>Value[i];

public static A070628Inst Instance=new A070628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070627
{
public static readonly long[] Value={ 0L,1L,32L,23L,12L,1L,32L,43L,32L,1L,32L,11L,12L,21L,12L,23L,12L,21L,32L,43L,12L,21L,0L,23L,32L,1L,12L,23L,32L,21L,32L,23L,32L,33L,12L,43L,12L,1L,12L,43L,32L,21L,12L,43L,0L,1L,32L,23L,12L,1L,32L,43L,32L,1L,32L,11L,12L,21L,12L,23L,12L,21L,32L,43L,12L,21L,0L,23L,32L,1L,12L,23L,32L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070627Inst : IEnumerable<long>
{
public static readonly long[] Value=A070627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070627.Bytes);
public long this[int i]=>Value[i];

public static A070627Inst Instance=new A070627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070626
{
public static readonly long[] Value={ 0L,1L,32L,28L,35L,29L,36L,37L,2L,10L,25L,16L,34L,31L,23L,38L,21L,40L,19L,30L,26L,4L,39L,17L,13L,24L,3L,22L,5L,20L,12L,9L,27L,18L,33L,41L,6L,7L,14L,8L,15L,11L,42L,0L,1L,32L,28L,35L,29L,36L,37L,2L,10L,25L,16L,34L,31L,23L,38L,21L,40L,19L,30L,26L,4L,39L,17L,13L,24L,3L,22L,5L,20L,12L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070626Inst : IEnumerable<long>
{
public static readonly long[] Value=A070626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070626.Bytes);
public long this[int i]=>Value[i];

public static A070626Inst Instance=new A070626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070625
{
public static readonly long[] Value={ 0L,1L,32L,33L,16L,17L,6L,7L,8L,39L,40L,23L,24L,13L,14L,15L,4L,5L,30L,31L,20L,21L,22L,11L,12L,37L,38L,27L,28L,29L,18L,19L,2L,3L,34L,35L,36L,25L,26L,9L,10L,41L,0L,1L,32L,33L,16L,17L,6L,7L,8L,39L,40L,23L,24L,13L,14L,15L,4L,5L,30L,31L,20L,21L,22L,11L,12L,37L,38L,27L,28L,29L,18L,19L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070625Inst : IEnumerable<long>
{
public static readonly long[] Value=A070625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070625.Bytes);
public long this[int i]=>Value[i];

public static A070625Inst Instance=new A070625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070624
{
public static readonly long[] Value={ 0L,1L,32L,38L,40L,9L,27L,38L,9L,9L,1L,3L,3L,38L,27L,14L,1L,27L,1L,27L,32L,9L,14L,40L,14L,40L,27L,14L,3L,38L,38L,40L,32L,32L,3L,14L,32L,1L,3L,9L,40L,0L,1L,32L,38L,40L,9L,27L,38L,9L,9L,1L,3L,3L,38L,27L,14L,1L,27L,1L,27L,32L,9L,14L,40L,14L,40L,27L,14L,3L,38L,38L,40L,32L,32L,3L,14L,32L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070624Inst : IEnumerable<long>
{
public static readonly long[] Value=A070624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070624.Bytes);
public long this[int i]=>Value[i];

public static A070624Inst Instance=new A070624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070623
{
public static readonly long[] Value={ 0L,1L,32L,3L,24L,5L,16L,7L,8L,9L,0L,11L,32L,13L,24L,15L,16L,17L,8L,19L,0L,21L,32L,23L,24L,25L,16L,27L,8L,29L,0L,31L,32L,33L,24L,35L,16L,37L,8L,39L,0L,1L,32L,3L,24L,5L,16L,7L,8L,9L,0L,11L,32L,13L,24L,15L,16L,17L,8L,19L,0L,21L,32L,23L,24L,25L,16L,27L,8L,29L,0L,31L,32L,33L,24L,35L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070623Inst : IEnumerable<long>
{
public static readonly long[] Value=A070623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070623.Bytes);
public long this[int i]=>Value[i];

public static A070623Inst Instance=new A070623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070622
{
public static readonly long[] Value={ 0L,1L,32L,9L,10L,5L,15L,37L,8L,3L,4L,20L,12L,13L,14L,6L,22L,23L,18L,28L,11L,21L,16L,17L,33L,25L,26L,27L,19L,35L,36L,31L,2L,24L,34L,29L,30L,7L,38L,0L,1L,32L,9L,10L,5L,15L,37L,8L,3L,4L,20L,12L,13L,14L,6L,22L,23L,18L,28L,11L,21L,16L,17L,33L,25L,26L,27L,19L,35L,36L,31L,2L,24L,34L,29L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070622Inst : IEnumerable<long>
{
public static readonly long[] Value=A070622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070622.Bytes);
public long this[int i]=>Value[i];

public static A070622Inst Instance=new A070622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070621
{
public static readonly long[] Value={ 0L,1L,32L,15L,36L,9L,24L,11L,12L,35L,22L,7L,8L,33L,10L,21L,4L,25L,18L,19L,20L,13L,34L,17L,28L,5L,30L,31L,16L,3L,26L,27L,14L,29L,2L,23L,6L,37L,0L,1L,32L,15L,36L,9L,24L,11L,12L,35L,22L,7L,8L,33L,10L,21L,4L,25L,18L,19L,20L,13L,34L,17L,28L,5L,30L,31L,16L,3L,26L,27L,14L,29L,2L,23L,6L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070621Inst : IEnumerable<long>
{
public static readonly long[] Value=A070621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070621.Bytes);
public long this[int i]=>Value[i];

public static A070621Inst Instance=new A070621Inst();

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