using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A111741
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,10L,4L,2L,4L,2L,2L,4L,4L,2L,8L,2L,10L,8L,4L,2L,2L,8L,4L,8L,4L,2L,2L,4L,2L,2L,8L,2L,4L,8L,20L,2L,10L,4L,8L,2L,2L,8L,2L,4L,4L,10L,2L,4L,10L,2L,2L,2L,10L,8L,20L,4L,2L,2L,10L,2L,2L,10L,4L,2L,2L,4L,20L,4L,14L,22L,4L,20L,4L,2L,2L,2L,10L,8L,4L,10L,8L,4L,2L,10L,16L,2L,8L,14L,4L,10L,8L,16L,8L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111741Inst : IEnumerable<long>
{
public static readonly long[] Value=A111741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111741.Bytes);
public long this[int i]=>Value[i];

public static A111741Inst Instance=new A111741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111742
{
public static readonly long[] Value={ 3L,1L,3L,1L,3L,1L,3L,1L,3L,3L,1L,3L,9L,1L,9L,11L,3L,3L,3L,9L,3L,7L,9L,17L,1L,3L,1L,17L,1L,21L,7L,9L,3L,9L,3L,1L,1L,7L,23L,3L,11L,1L,3L,1L,3L,3L,1L,7L,3L,3L,3L,3L,1L,11L,9L,3L,3L,1L,7L,9L,3L,9L,9L,9L,7L,11L,3L,1L,21L,1L,3L,3L,1L,3L,3L,3L,17L,19L,3L,1L,11L,1L,17L,7L,1L,11L,3L,13L,11L,7L,3L,3L,1L,9L,3L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111742Inst : IEnumerable<long>
{
public static readonly long[] Value=A111742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111742.Bytes);
public long this[int i]=>Value[i];

public static A111742Inst Instance=new A111742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111743
{
public static readonly long[] Value={ 14L,24L,40L,56L,101L,103L,107L,109L,113L,127L,129L,130L,131L,134L,137L,139L,141L,142L,146L,149L,151L,157L,158L,159L,163L,166L,167L,170L,173L,177L,178L,179L,181L,183L,190L,191L,193L,194L,197L,199L,201L,202L,206L,211L,213L,214L,218L,219L,223L,226L,227L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111743Inst : IEnumerable<long>
{
public static readonly long[] Value=A111743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111743.Bytes);
public long this[int i]=>Value[i];

public static A111743Inst Instance=new A111743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111744
{
public static readonly long[] Value={ 5L,3L,13L,7L,17L,11L,29L,19L,37L,23L,41L,31L,53L,43L,61L,47L,73L,59L,89L,67L,97L,71L,101L,79L,109L,83L,113L,103L,137L,107L,149L,127L,157L,131L,173L,139L,181L,151L,193L,163L,197L,167L,229L,179L,233L,191L,241L,199L,257L,211L,269L,223L,277L,227L,281L,239L,293L,251L,313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111744Inst : IEnumerable<long>
{
public static readonly long[] Value=A111744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111744.Bytes);
public long this[int i]=>Value[i];

public static A111744Inst Instance=new A111744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111745
{
public static readonly long[] Value={ 3L,5L,7L,13L,11L,17L,19L,29L,23L,37L,31L,41L,43L,53L,47L,61L,59L,73L,67L,89L,71L,97L,79L,101L,83L,109L,103L,113L,107L,137L,127L,149L,131L,157L,139L,173L,151L,181L,163L,193L,167L,197L,179L,229L,191L,233L,199L,241L,211L,257L,223L,269L,227L,277L,239L,281L,251L,293L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111745Inst : IEnumerable<long>
{
public static readonly long[] Value=A111745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111745.Bytes);
public long this[int i]=>Value[i];

public static A111745Inst Instance=new A111745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111746
{
public static readonly long[] Value={ 0L,5L,17L,42L,82L,143L,227L,340L,484L,665L,885L,1150L,1462L,1827L,2247L,2728L,3272L,3885L,4569L,5330L,6170L,7095L,8107L,9212L,10412L,11713L,13117L,14630L,16254L,17995L,19855L,21840L,23952L,26197L,28577L,31098L,33762L,36575L,39539L,42660L,45940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111746Inst : IEnumerable<long>
{
public static readonly long[] Value=A111746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111746.Bytes);
public long this[int i]=>Value[i];

public static A111746Inst Instance=new A111746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111747
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,27L,81L,243L,512L,2401L,4913L,19683L,59049L,177147L,390625L,1594323L,43046721L,129140163L,1977326743L,10460353203L,27512614111L,68719476736L,271818611107L,1174711139837L,7625597484987L,617673396283947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111747Inst : IEnumerable<long>
{
public static readonly long[] Value=A111747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111747.Bytes);
public long this[int i]=>Value[i];

public static A111747Inst Instance=new A111747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111748
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111748Inst : IEnumerable<long>
{
public static readonly long[] Value=A111748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111748.Bytes);
public long this[int i]=>Value[i];

public static A111748Inst Instance=new A111748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111749
{
public static readonly long[] Value={ 1L,3L,10L,39L,121L,405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111749Inst : IEnumerable<long>
{
public static readonly long[] Value=A111749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111749.Bytes);
public long this[int i]=>Value[i];

public static A111749Inst Instance=new A111749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111750
{
public static readonly long[] Value={ 280103L,1297573L,1319273L,1473443L,1589663L,1726603L,1798003L,1807063L,2048953L,2082793L,2126303L,2342393L,2434123L,2459273L,2770843L,2784563L,2824583L,2897053L,2952613L,2897053L,2952613L,2965043L,3036983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111750Inst : IEnumerable<long>
{
public static readonly long[] Value=A111750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111750.Bytes);
public long this[int i]=>Value[i];

public static A111750Inst Instance=new A111750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111751
{
public static readonly long[] Value={ 2L,22L,25L,28L,37L,40L,60L,73L,78L,80L,129L,135L,158L,162L,215L,220L,228L,238L,269L,285L,315L,332L,344L,347L,355L,365L,366L,390L,397L,402L,439L,443L,470L,477L,533L,549L,653L,694L,710L,715L,716L,745L,765L,782L,822L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111751Inst : IEnumerable<long>
{
public static readonly long[] Value=A111751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111751.Bytes);
public long this[int i]=>Value[i];

public static A111751Inst Instance=new A111751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111752
{
public static readonly BigInteger[] Value={ 1L,0L,3L,6L,49L,300L,2491L,22890L,239457L,2782584L,35595091L,496577070L,7499663953L,121855323876L,2118793593099L,39245026343250L,771255810671041L,16025261292247920L,350956070419872547L,8078570913162379734L,BigInteger.Parse("194969375055353840241"),BigInteger.Parse("4922311437793379501340") };
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
public class A111752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111752.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111752Inst Instance=new A111752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111753
{
public static readonly BigInteger[] Value={ 0L,1L,0L,7L,24L,201L,1560L,14743L,154896L,1813969L,23346000L,327496071L,4970498280L,81121077337L,1416223931304L,26328776843671L,519178407998880L,10821355158998433L,237677397895531296L,5485802780426178439L,BigInteger.Parse("132728552830731814200"),BigInteger.Parse("3358841601972480225001") };
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
public class A111753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111753.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111753Inst Instance=new A111753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111754
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,6L,2L,0L,3L,4L,4L,4L,3L,9L,3L,5L,5L,7L,3L,9L,8L,4L,0L,4L,4L,1L,6L,9L,7L,5L,4L,7L,8L,2L,8L,8L,4L,6L,4L,6L,0L,1L,6L,8L,1L,1L,9L,5L,1L,1L,9L,3L,9L,1L,1L,7L,2L,2L,3L,7L,8L,2L,2L,0L,0L,4L,8L,6L,6L,9L,1L,8L,6L,0L,9L,3L,0L,7L,1L,8L,9L,6L,5L,9L,0L,9L,2L,5L,4L,2L,3L,1L,6L,8L,2L,8L,0L,3L,1L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111754Inst : IEnumerable<long>
{
public static readonly long[] Value=A111754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111754.Bytes);
public long this[int i]=>Value[i];

public static A111754Inst Instance=new A111754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111755
{
public static readonly long[] Value={ 0L,1L,2L,0L,0L,1L,2L,3L,0L,0L,1L,2L,0L,0L,1L,0L,0L,1L,2L,0L,0L,1L,2L,3L,0L,0L,1L,2L,0L,0L,1L,2L,3L,0L,0L,0L,0L,1L,2L,0L,0L,1L,2L,3L,0L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,3L,0L,0L,1L,2L,0L,0L,0L,0L,1L,2L,0L,0L,1L,2L,3L,0L,0L,1L,2L,0L,0L,1L,0L,0L,0L,1L,2L,0L,0L,1L,2L,3L,0L,0L,1L,2L,0L,0L,1L,0L,0L,1L,0L,0L,1L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111755Inst : IEnumerable<long>
{
public static readonly long[] Value=A111755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111755.Bytes);
public long this[int i]=>Value[i];

public static A111755Inst Instance=new A111755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111756
{
public static readonly long[] Value={ 3L,3L,3L,3L,5L,5L,5L,5L,5L,3L,7L,7L,7L,7L,5L,5L,9L,9L,3L,3L,11L,11L,11L,11L,5L,5L,13L,13L,13L,13L,3L,3L,17L,17L,17L,17L,5L,3L,19L,19L,19L,19L,5L,7L,7L,21L,3L,3L,23L,23L,23L,23L,5L,5L,3L,27L,3L,11L,7L,7L,13L,3L,29L,29L,29L,29L,5L,3L,31L,31L,31L,31L,5L,5L,3L,9L,3L,3L,37L,37L,37L,37L,5L,11L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111756Inst : IEnumerable<long>
{
public static readonly long[] Value=A111756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111756.Bytes);
public long this[int i]=>Value[i];

public static A111756Inst Instance=new A111756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111757
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,2L,0L,4L,0L,13L,0L,48L,0L,238L,0L,1325L,0L,8297L,0L,54519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111757Inst : IEnumerable<long>
{
public static readonly long[] Value=A111757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111757.Bytes);
public long this[int i]=>Value[i];

public static A111757Inst Instance=new A111757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111758
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,12L,24L,74L,193L,635L,1990L,6933L,24144L,88203L,326053L,1234735L,4732762L,18403211L,72282202L,286705378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111758Inst : IEnumerable<long>
{
public static readonly long[] Value=A111758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111758.Bytes);
public long this[int i]=>Value[i];

public static A111758Inst Instance=new A111758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111759
{
public static readonly long[] Value={ 1L,2L,3L,7L,12L,29L,61L,162L,412L,1221L,3665L,12031L,40514L,143244L,518247L,1926638L,7285835L,28013935L,109058879L,429366751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111759Inst : IEnumerable<long>
{
public static readonly long[] Value=A111759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111759.Bytes);
public long this[int i]=>Value[i];

public static A111759Inst Instance=new A111759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111760
{
public static readonly long[] Value={ 1L,3L,2L,1L,1L,7L,6L,1L,7L,7L,8L,1L,3L,4L,5L,0L,6L,5L,2L,6L,3L,4L,3L,4L,1L,1L,1L,9L,2L,5L,4L,6L,6L,0L,5L,1L,3L,3L,4L,6L,3L,3L,7L,5L,8L,3L,5L,4L,9L,1L,6L,4L,4L,0L,5L,3L,0L,9L,8L,4L,7L,5L,5L,2L,3L,9L,1L,5L,7L,7L,7L,9L,4L,6L,0L,3L,6L,8L,0L,3L,2L,1L,7L,6L,9L,1L,0L,1L,2L,8L,6L,9L,8L,8L,0L,0L,6L,9L,7L,5L,2L,4L,1L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111760Inst : IEnumerable<long>
{
public static readonly long[] Value=A111760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111760.Bytes);
public long this[int i]=>Value[i];

public static A111760Inst Instance=new A111760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111761
{
public static readonly long[] Value={ 2L,5L,9L,4L,0L,2L,3L,0L,0L,2L,4L,9L,7L,5L,0L,9L,7L,9L,7L,4L,8L,6L,8L,6L,7L,7L,7L,9L,1L,1L,0L,5L,0L,1L,2L,0L,6L,0L,9L,0L,4L,7L,9L,6L,8L,2L,9L,6L,5L,1L,2L,1L,8L,8L,8L,6L,5L,9L,7L,6L,7L,9L,3L,3L,9L,9L,6L,5L,5L,5L,9L,9L,1L,2L,9L,8L,2L,3L,2L,0L,1L,1L,8L,0L,6L,3L,0L,4L,1L,9L,2L,9L,8L,5L,6L,1L,1L,9L,9L,6L,1L,3L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111761Inst : IEnumerable<long>
{
public static readonly long[] Value=A111761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111761.Bytes);
public long this[int i]=>Value[i];

public static A111761Inst Instance=new A111761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111762
{
public static readonly long[] Value={ 3L,6L,3L,4L,7L,9L,8L,7L,2L,5L,9L,4L,5L,4L,2L,7L,9L,8L,9L,3L,3L,7L,9L,2L,0L,9L,2L,0L,1L,6L,3L,6L,1L,3L,9L,0L,4L,1L,4L,6L,3L,0L,9L,3L,9L,4L,1L,2L,8L,6L,1L,8L,8L,3L,1L,0L,9L,0L,6L,0L,2L,3L,5L,8L,8L,0L,0L,1L,5L,2L,2L,0L,7L,9L,4L,1L,5L,5L,3L,9L,2L,3L,8L,8L,8L,7L,8L,5L,3L,2L,9L,6L,5L,2L,0L,9L,3L,1L,4L,1L,2L,9L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111762Inst : IEnumerable<long>
{
public static readonly long[] Value=A111762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111762.Bytes);
public long this[int i]=>Value[i];

public static A111762Inst Instance=new A111762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111763
{
public static readonly long[] Value={ 4L,4L,5L,0L,2L,4L,8L,8L,2L,0L,1L,5L,8L,8L,4L,5L,2L,9L,5L,9L,2L,8L,8L,5L,0L,1L,8L,7L,2L,8L,4L,1L,2L,5L,5L,6L,3L,3L,1L,4L,6L,4L,2L,4L,5L,6L,7L,4L,2L,9L,1L,4L,0L,9L,4L,1L,1L,9L,4L,2L,0L,0L,7L,0L,7L,2L,9L,1L,2L,5L,6L,0L,3L,6L,8L,8L,3L,3L,9L,9L,1L,3L,5L,5L,8L,1L,3L,1L,0L,7L,2L,0L,9L,8L,2L,1L,5L,2L,3L,9L,8L,1L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111763Inst : IEnumerable<long>
{
public static readonly long[] Value=A111763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111763.Bytes);
public long this[int i]=>Value[i];

public static A111763Inst Instance=new A111763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111764
{
public static readonly long[] Value={ 1L,0L,1L,7L,6L,0L,8L,2L,9L,4L,8L,2L,1L,6L,1L,4L,9L,3L,1L,3L,1L,9L,6L,3L,9L,2L,5L,3L,6L,5L,5L,2L,3L,7L,1L,0L,9L,1L,2L,3L,8L,5L,8L,7L,3L,4L,7L,2L,6L,3L,5L,1L,6L,7L,6L,4L,4L,8L,5L,1L,9L,4L,4L,9L,5L,3L,2L,2L,3L,6L,1L,7L,1L,2L,3L,8L,0L,3L,6L,5L,7L,7L,6L,2L,9L,9L,2L,0L,9L,5L,2L,2L,3L,3L,8L,9L,6L,2L,9L,6L,8L,6L,5L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111764Inst : IEnumerable<long>
{
public static readonly long[] Value=A111764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111764.Bytes);
public long this[int i]=>Value[i];

public static A111764Inst Instance=new A111764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111765
{
public static readonly long[] Value={ 9L,8L,2L,6L,9L,6L,3L,9L,2L,2L,0L,5L,9L,0L,1L,1L,5L,5L,1L,3L,5L,1L,3L,2L,2L,2L,5L,3L,0L,4L,4L,0L,5L,4L,2L,0L,3L,0L,0L,1L,3L,5L,0L,2L,4L,9L,0L,4L,0L,6L,4L,5L,2L,6L,1L,3L,3L,7L,0L,6L,1L,5L,1L,4L,3L,5L,1L,1L,6L,3L,4L,1L,0L,9L,1L,9L,0L,0L,9L,1L,1L,2L,2L,2L,2L,0L,4L,6L,7L,8L,6L,1L,0L,7L,8L,2L,4L,4L,1L,6L,4L,7L,8L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111765Inst : IEnumerable<long>
{
public static readonly long[] Value=A111765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111765.Bytes);
public long this[int i]=>Value[i];

public static A111765Inst Instance=new A111765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111766
{
public static readonly long[] Value={ 0L,5L,24L,145L,840L,4901L,28560L,166465L,970224L,5654885L,32959080L,192099601L,1119638520L,6525731525L,38034750624L,221682772225L,1292061882720L,7530688524101L,43892069261880L,255821727047185L,1491038293021224L,8690408031080165L,50651409893459760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111766Inst : IEnumerable<long>
{
public static readonly long[] Value=A111766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111766.Bytes);
public long this[int i]=>Value[i];

public static A111766Inst Instance=new A111766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111767
{
public static readonly long[] Value={ 4L,0L,4L,8L,1L,2L,5L,4L,1L,8L,6L,8L,3L,1L,2L,5L,2L,2L,2L,3L,5L,0L,7L,5L,5L,2L,9L,7L,0L,8L,7L,3L,8L,9L,0L,0L,7L,4L,5L,2L,0L,4L,9L,6L,7L,2L,5L,0L,7L,1L,2L,4L,6L,1L,4L,3L,3L,5L,1L,0L,5L,9L,3L,5L,4L,6L,9L,1L,9L,0L,3L,4L,5L,4L,4L,5L,4L,4L,8L,3L,8L,7L,1L,8L,8L,4L,0L,3L,5L,4L,6L,2L,0L,4L,1L,5L,9L,7L,3L,4L,7L,7L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111767Inst : IEnumerable<long>
{
public static readonly long[] Value=A111767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111767.Bytes);
public long this[int i]=>Value[i];

public static A111767Inst Instance=new A111767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111768
{
public static readonly long[] Value={ 2L,4L,7L,0L,2L,7L,9L,1L,9L,4L,8L,7L,0L,6L,5L,9L,0L,1L,3L,6L,9L,1L,5L,4L,0L,7L,9L,0L,8L,6L,8L,8L,4L,9L,2L,6L,9L,3L,8L,6L,2L,8L,8L,3L,2L,4L,6L,7L,4L,7L,7L,3L,6L,6L,1L,7L,0L,4L,4L,6L,2L,9L,6L,0L,4L,4L,5L,0L,3L,4L,3L,5L,2L,4L,4L,4L,0L,1L,2L,8L,4L,1L,5L,0L,4L,2L,9L,6L,1L,9L,9L,9L,6L,8L,2L,1L,1L,1L,0L,4L,4L,6L,7L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111768Inst : IEnumerable<long>
{
public static readonly long[] Value=A111768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111768.Bytes);
public long this[int i]=>Value[i];

public static A111768Inst Instance=new A111768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111769
{
public static readonly long[] Value={ 1L,7L,5L,8L,0L,7L,8L,5L,3L,1L,3L,8L,6L,3L,7L,2L,2L,5L,4L,8L,8L,5L,3L,5L,5L,1L,9L,0L,3L,7L,0L,6L,4L,2L,0L,2L,0L,9L,7L,8L,4L,4L,7L,9L,8L,6L,4L,5L,0L,8L,7L,0L,7L,4L,6L,4L,2L,1L,5L,9L,3L,7L,5L,0L,6L,6L,5L,9L,8L,3L,3L,0L,4L,2L,4L,0L,6L,7L,0L,5L,4L,9L,2L,5L,5L,9L,9L,0L,5L,4L,7L,9L,0L,9L,9L,8L,6L,5L,6L,7L,7L,5L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111769Inst : IEnumerable<long>
{
public static readonly long[] Value=A111769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111769.Bytes);
public long this[int i]=>Value[i];

public static A111769Inst Instance=new A111769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111770
{
public static readonly long[] Value={ 5L,6L,8L,8L,0L,2L,8L,0L,4L,9L,6L,4L,2L,5L,1L,2L,6L,8L,5L,1L,2L,2L,1L,8L,3L,1L,5L,8L,5L,5L,2L,5L,1L,8L,2L,4L,6L,7L,0L,2L,7L,4L,7L,9L,6L,3L,0L,5L,5L,6L,7L,6L,6L,9L,9L,1L,1L,4L,3L,4L,2L,0L,3L,6L,4L,4L,4L,2L,4L,0L,3L,9L,7L,5L,4L,8L,9L,7L,8L,0L,0L,8L,4L,6L,5L,8L,5L,6L,4L,9L,9L,4L,7L,1L,6L,5L,5L,9L,1L,2L,3L,7L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111770Inst : IEnumerable<long>
{
public static readonly long[] Value=A111770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111770.Bytes);
public long this[int i]=>Value[i];

public static A111770Inst Instance=new A111770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111771
{
public static readonly long[] Value={ 2L,22L,29L,99L,94L,44L,47L,77L,76L,66L,65L,55L,58L,88L,83L,33L,40L,110L,101L,11L,12L,12L,19L,109L,104L,34L,37L,87L,86L,56L,55L,65L,68L,78L,73L,43L,50L,100L,91L,21L,22L,2L,9L,9L,4L,24L,27L,97L,96L,46L,45L,75L,78L,68L,63L,53L,60L,90L,81L,31L,32L,102L,109L,19L,14L,14L,17L,107L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111771Inst : IEnumerable<long>
{
public static readonly long[] Value=A111771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111771.Bytes);
public long this[int i]=>Value[i];

public static A111771Inst Instance=new A111771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111772
{
public static readonly long[] Value={ 1L,1L,3L,7L,22L,77L,314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111772Inst : IEnumerable<long>
{
public static readonly long[] Value=A111772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111772.Bytes);
public long this[int i]=>Value[i];

public static A111772Inst Instance=new A111772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111773
{
public static readonly long[] Value={ 1L,2L,10L,92L,1321L,27882L,819330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111773Inst : IEnumerable<long>
{
public static readonly long[] Value=A111773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111773.Bytes);
public long this[int i]=>Value[i];

public static A111773Inst Instance=new A111773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111774
{
public static readonly long[] Value={ 6L,9L,10L,12L,14L,15L,18L,20L,21L,22L,24L,25L,26L,27L,28L,30L,33L,34L,35L,36L,38L,39L,40L,42L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,60L,62L,63L,65L,66L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,81L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L,100L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111774Inst : IEnumerable<long>
{
public static readonly long[] Value=A111774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111774.Bytes);
public long this[int i]=>Value[i];

public static A111774Inst Instance=new A111774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111775
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,2L,0L,0L,2L,0L,1L,2L,1L,0L,1L,1L,1L,2L,1L,0L,3L,0L,0L,2L,1L,2L,2L,0L,1L,2L,1L,0L,3L,0L,1L,4L,1L,0L,1L,1L,2L,2L,1L,0L,3L,2L,1L,2L,1L,0L,3L,0L,1L,4L,0L,2L,3L,0L,1L,2L,3L,0L,2L,0L,1L,4L,1L,2L,3L,0L,1L,3L,1L,0L,3L,2L,1L,2L,1L,0L,5L,2L,1L,2L,1L,2L,1L,0L,2L,4L,2L,0L,3L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111775Inst : IEnumerable<long>
{
public static readonly long[] Value=A111775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111775.Bytes);
public long this[int i]=>Value[i];

public static A111775Inst Instance=new A111775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111776
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,4L,6L,10L,1L,8L,12L,20L,35L,1L,16L,24L,40L,70L,125L,1L,32L,48L,80L,140L,250L,450L,1L,64L,96L,160L,280L,500L,900L,1625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111776Inst : IEnumerable<long>
{
public static readonly long[] Value=A111776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111776.Bytes);
public long this[int i]=>Value[i];

public static A111776Inst Instance=new A111776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111777
{
public static readonly long[] Value={ 1L,12L,130L,1380L,15435L,182280L,2302020L,30958200L,444230325L,6771510900L,109568809350L,1874844071100L,33875023557375L,644264598978000L,12877256933541000L,269789087886318000L,5915648230774907625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111777Inst : IEnumerable<long>
{
public static readonly long[] Value=A111777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111777.Bytes);
public long this[int i]=>Value[i];

public static A111777Inst Instance=new A111777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111778
{
public static readonly BigInteger[] Value={ 1L,20L,315L,4620L,67830L,1020600L,15961050L,260706600L,4461170175L,80002622700L,1503527550525L,29583578524500L,608837350621500L,13088359506222000L,293538127312930500L,6858722586405690000L,BigInteger.Parse("166752692881988338125") };
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
public class A111778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111778Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111778.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111778.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111778Inst Instance=new A111778Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111779
{
public static readonly BigInteger[] Value={ 1L,30L,651L,12600L,235494L,4396140L,83471850L,1627358040L,32754696975L,682573101210L,14749179169725L,330654317994000L,7691170398011100L,185559161386599000L,4641068950134516900L,BigInteger.Parse("120256269348313098000") };
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
public class A111779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111779Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111779.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111779.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111779Inst Instance=new A111779Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111780
{
public static readonly BigInteger[] Value={ 1L,42L,1204L,29736L,689850L,15647940L,354718980L,8137289160L,190349674515L,4561677870750L,112317990384600L,2846259737521200L,74306186469414900L,1999421553976446600L,BigInteger.Parse("55458660913310655000"),BigInteger.Parse("1585528821898619598000") };
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
public class A111780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111780Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111780.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111780.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111780Inst Instance=new A111780Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111781
{
public static readonly BigInteger[] Value={ 1L,56L,2052L,63000L,1777050L,48149640L,1284709140L,34260506280L,921799753875L,25175488338000L,700755564108600L,19932553764723600L,580406741946731700L,17320767850295910000UL,BigInteger.Parse("530112107596146075000"),BigInteger.Parse("16645556950225160958000") };
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
public class A111781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111781Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111781.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111781.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111781Inst Instance=new A111781Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111782
{
public static readonly BigInteger[] Value={ 1L,72L,3285L,122760L,4138695L,132046200L,4096887795L,125691766200L,3854667766950L,119027264756400L,3719190784859550L,118004440103550000L,3811105656937829250L,BigInteger.Parse("125500234402721178000"),BigInteger.Parse("4218813452749267622250") };
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
public class A111782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111782Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111782.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111782.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111782Inst Instance=new A111782Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111783
{
public static readonly BigInteger[] Value={ 1L,90L,5005L,223740L,8886735L,329819490L,11775438675L,411859047600L,14282642924550L,495142102154700L,17259324931198350L,607418587742967000L,BigInteger.Parse("21648370208790575250"),BigInteger.Parse("783042495355599979500"),BigInteger.Parse("28791389550204705674250") };
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
public class A111783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111783Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111783.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111783.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111783Inst Instance=new A111783Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111784
{
public static readonly BigInteger[] Value={ 1L,110L,7326L,386100L,17846829L,762431670L,31039608600L,1227833727120L,47809764352350L,1849155516788580L,71501760198168300L,2777115998421765000L,BigInteger.Parse("108722966424618095550"),BigInteger.Parse("4301625967084096150500"),BigInteger.Parse("172338358130509601230200") };
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
public class A111784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111784Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111784.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111784.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111784Inst Instance=new A111784Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111785
{
public static readonly long[] Value={ 1L,-1L,-1L,2L,-1L,5L,-5L,-1L,6L,3L,-21L,14L,-1L,7L,7L,-28L,-28L,84L,-42L,-1L,8L,8L,4L,-36L,-72L,-12L,120L,180L,-330L,132L,-1L,9L,9L,9L,-45L,-90L,-45L,-45L,165L,495L,165L,-495L,-990L,1287L,-429L,-1L,10L,10L,10L,5L,-55L,-110L,-110L,-55L,-55L,220L,660L,330L,660L,55L,-715L,-2860L,-1430L,2002L,5005L,-5005L,1430L,-1L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111785Inst : IEnumerable<long>
{
public static readonly long[] Value=A111785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111785.Bytes);
public long this[int i]=>Value[i];

public static A111785Inst Instance=new A111785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111786
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-2L,1L,-1L,2L,1L,-3L,1L,1L,-2L,-2L,3L,3L,-4L,1L,-1L,2L,2L,1L,-3L,-6L,-1L,4L,6L,-5L,1L,1L,-2L,-2L,-2L,3L,6L,3L,3L,-4L,-12L,-4L,5L,10L,-6L,1L,-1L,2L,2L,2L,1L,-3L,-6L,-6L,-3L,-3L,4L,12L,6L,12L,1L,-5L,-20L,-10L,6L,15L,-7L,1L,1L,-2L,-2L,-2L,-2L,3L,6L,6L,3L,3L,6L,1L,-4L,-12L,-12L,-12L,-12L,-4L,5L,20L,10L,30L,5L,-6L,-30L,-20L,7L,21L,-8L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111786Inst : IEnumerable<long>
{
public static readonly long[] Value=A111786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111786.Bytes);
public long this[int i]=>Value[i];

public static A111786Inst Instance=new A111786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111787
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,3L,0L,0L,3L,4L,0L,3L,0L,4L,3L,0L,0L,3L,0L,5L,3L,4L,0L,3L,5L,4L,3L,7L,0L,3L,0L,0L,3L,4L,5L,3L,0L,4L,3L,5L,0L,3L,0L,8L,3L,4L,0L,3L,7L,5L,3L,8L,0L,3L,5L,7L,3L,4L,0L,3L,0L,4L,3L,0L,5L,3L,0L,8L,3L,5L,0L,3L,0L,4L,3L,8L,7L,3L,0L,5L,3L,4L,0L,3L,5L,4L,3L,11L,0L,3L,7L,8L,3L,4L,5L,3L,0L,7L,3L,5L,0L,3L,0L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111787Inst : IEnumerable<long>
{
public static readonly long[] Value=A111787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111787.Bytes);
public long this[int i]=>Value[i];

public static A111787Inst Instance=new A111787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111788
{
public static readonly long[] Value={ 2L,3L,10L,120549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111788Inst : IEnumerable<long>
{
public static readonly long[] Value=A111788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111788.Bytes);
public long this[int i]=>Value[i];

public static A111788Inst Instance=new A111788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111789
{
public static readonly long[] Value={ 2L,1L,7L,120539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111789Inst : IEnumerable<long>
{
public static readonly long[] Value=A111789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111789.Bytes);
public long this[int i]=>Value[i];

public static A111789Inst Instance=new A111789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111790
{
public static readonly long[] Value={ 2L,5L,15L,120564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111790Inst : IEnumerable<long>
{
public static readonly long[] Value=A111790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111790.Bytes);
public long this[int i]=>Value[i];

public static A111790Inst Instance=new A111790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111791
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,12L,18L,36L,5L,7L,8L,10L,13L,14L,15L,16L,20L,21L,23L,24L,25L,26L,27L,28L,30L,35L,37L,39L,40L,42L,45L,46L,48L,49L,50L,52L,54L,56L,60L,61L,63L,64L,65L,69L,70L,72L,74L,75L,78L,80L,81L,84L,90L,91L,92L,98L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111791Inst : IEnumerable<long>
{
public static readonly long[] Value=A111791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111791.Bytes);
public long this[int i]=>Value[i];

public static A111791Inst Instance=new A111791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111792
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,5L,7L,8L,16L,12L,18L,10L,13L,14L,23L,25L,27L,49L,64L,81L,512L,11L,17L,19L,32L,53L,128L,256L,65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111792Inst : IEnumerable<long>
{
public static readonly long[] Value=A111792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111792.Bytes);
public long this[int i]=>Value[i];

public static A111792Inst Instance=new A111792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111793
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,10L,8L,1L,24L,32L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111793Inst : IEnumerable<long>
{
public static readonly long[] Value=A111793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111793.Bytes);
public long this[int i]=>Value[i];

public static A111793Inst Instance=new A111793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111794
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,16L,11L,17L,19L,32L,53L,128L,256L,65536L,31L,59L,67L,131L,241L,719L,1619L,2048L,131072L,524288L,821641L,4294967296L,9007199254740992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111794Inst : IEnumerable<long>
{
public static readonly long[] Value=A111794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111794.Bytes);
public long this[int i]=>Value[i];

public static A111794Inst Instance=new A111794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111795
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,11L,16L,17L,19L,31L,32L,53L,59L,67L,127L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111795Inst : IEnumerable<long>
{
public static readonly long[] Value=A111795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111795.Bytes);
public long this[int i]=>Value[i];

public static A111795Inst Instance=new A111795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111796
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,16L,6L,11L,13L,17L,19L,23L,25L,27L,32L,49L,53L,64L,81L,128L,256L,512L,65536L,10L,12L,14L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111796Inst : IEnumerable<long>
{
public static readonly long[] Value=A111796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111796.Bytes);
public long this[int i]=>Value[i];

public static A111796Inst Instance=new A111796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111797
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,16L,4L,56L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111797Inst : IEnumerable<long>
{
public static readonly long[] Value=A111797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111797.Bytes);
public long this[int i]=>Value[i];

public static A111797Inst Instance=new A111797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111798
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,6L,12L,18L,36L,5L,7L,8L,13L,16L,23L,25L,27L,37L,49L,61L,64L,81L,125L,151L,169L,343L,512L,529L,625L,729L,1369L,2197L,2401L,3721L,4096L,12167L,15625L,19683L,22801L,28561L,50653L,117649L,226981L,262144L,279841L,531441L,1874161L,1953125L,3442951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111798Inst : IEnumerable<long>
{
public static readonly long[] Value=A111798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111798.Bytes);
public long this[int i]=>Value[i];

public static A111798Inst Instance=new A111798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111799
{
public static readonly long[] Value={ 1L,1L,3L,4L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111799Inst : IEnumerable<long>
{
public static readonly long[] Value=A111799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111799.Bytes);
public long this[int i]=>Value[i];

public static A111799Inst Instance=new A111799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111800
{
public static readonly long[] Value={ 1L,3L,5L,5L,7L,7L,7L,7L,7L,9L,9L,9L,9L,9L,11L,7L,9L,9L,9L,11L,11L,11L,9L,11L,9L,11L,9L,11L,11L,13L,11L,9L,13L,11L,13L,11L,11L,11L,13L,13L,11L,13L,11L,13L,13L,11L,13L,11L,9L,11L,13L,13L,9L,11L,15L,13L,13L,13L,11L,15L,11L,13L,13L,9L,15L,15L,11L,13L,13L,15L,13L,13L,13L,13L,13L,13L,15L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111800Inst : IEnumerable<long>
{
public static readonly long[] Value=A111800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111800.Bytes);
public long this[int i]=>Value[i];

public static A111800Inst Instance=new A111800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111801
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,8L,11L,13L,15L,16L,17L,19L,20L,21L,23L,24L,25L,27L,28L,29L,31L,32L,33L,35L,37L,39L,41L,43L,44L,47L,48L,49L,51L,52L,53L,55L,56L,57L,59L,61L,63L,64L,65L,67L,68L,69L,71L,73L,75L,76L,77L,79L,80L,81L,83L,85L,87L,88L,89L,91L,92L,93L,95L,96L,97L,100L,101L,103L,104L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111801Inst : IEnumerable<long>
{
public static readonly long[] Value=A111801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111801.Bytes);
public long this[int i]=>Value[i];

public static A111801Inst Instance=new A111801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111802
{
public static readonly long[] Value={ 1L,2L,3L,11L,19L,29L,41L,55L,71L,89L,109L,131L,155L,181L,209L,239L,271L,305L,341L,379L,419L,461L,505L,551L,599L,649L,701L,755L,811L,869L,929L,991L,1055L,1121L,1189L,1259L,1331L,1405L,1481L,1559L,1639L,1721L,1805L,1891L,1979L,2069L,2161L,2255L,2351L,2449L,2549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111802Inst : IEnumerable<long>
{
public static readonly long[] Value=A111802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111802.Bytes);
public long this[int i]=>Value[i];

public static A111802Inst Instance=new A111802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111803
{
public static readonly long[] Value={ 1L,1L,24L,6L,7L,1L,16L,4L,9L,17L,65L,21L,36L,196L,571L,62L,278L,92L,105L,24L,138L,143L,489L,547L,221L,1111L,254L,242L,316L,1287L,195L,789L,758L,627L,756L,226L,547L,583L,154L,533L,2016L,65L,1500L,4377L,835L,814L,61L,1547L,2771L,3177L,898L,191L,3221L,7410L,1361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111803Inst : IEnumerable<long>
{
public static readonly long[] Value=A111803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111803.Bytes);
public long this[int i]=>Value[i];

public static A111803Inst Instance=new A111803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111804
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,4L,5L,15L,10L,10L,6L,3L,7L,21L,21L,14L,14L,21L,8L,8L,8L,8L,9L,18L,9L,18L,9L,18L,10L,10L,5L,15L,11L,44L,44L,33L,33L,22L,22L,44L,44L,33L,12L,6L,4L,6L,13L,65L,39L,39L,52L,52L,26L,26L,39L,39L,52L,65L,14L,14L,21L,7L,21L,21L,15L,20L,10L,10L,5L,15L,6L,10L,16L,16L,16L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111804Inst : IEnumerable<long>
{
public static readonly long[] Value=A111804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111804.Bytes);
public long this[int i]=>Value[i];

public static A111804Inst Instance=new A111804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111805
{
public static readonly long[] Value={ 1L,1L,1L,1L,15L,1L,1L,70L,45L,1L,1L,210L,495L,91L,1L,1L,495L,3003L,1820L,153L,1L,1L,1001L,12870L,18564L,4845L,231L,1L,1L,1820L,43758L,125970L,74613L,10626L,325L,1L,1L,3060L,125970L,646646L,735471L,230230L,20475L,435L,1L,1L,4845L,319770L,2704156L,5311735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111805Inst : IEnumerable<long>
{
public static readonly long[] Value=A111805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111805.Bytes);
public long this[int i]=>Value[i];

public static A111805Inst Instance=new A111805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111806
{
public static readonly long[] Value={ 1L,-3L,1L,7L,-6L,1L,-15L,23L,-9L,1L,31L,-72L,48L,-12L,1L,-63L,201L,-198L,82L,-15L,1L,127L,-522L,699L,-420L,125L,-18L,1L,-255L,1291L,-2223L,1795L,-765L,177L,-21L,1L,511L,-3084L,6562L,-6768L,3840L,-1260L,238L,-24L,1L,-1023L,7181L,-18324L,23276L,-16758L,7266L,-1932L,308L,-27L,1L,2047L,-16398L,49029L,-74616L,65870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111806Inst : IEnumerable<long>
{
public static readonly long[] Value=A111806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111806.Bytes);
public long this[int i]=>Value[i];

public static A111806Inst Instance=new A111806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111807
{
public static readonly long[] Value={ 1L,2L,6L,4L,15L,6L,21L,8L,18L,15L,44L,12L,65L,21L,20L,16L,85L,18L,114L,20L,35L,44L,138L,24L,75L,65L,54L,28L,174L,30L,186L,32L,66L,85L,42L,36L,296L,114L,65L,40L,287L,42L,301L,44L,45L,138L,376L,48L,147L,75L,102L,65L,371L,54L,88L,56L,114L,174L,413L,60L,488L,186L,72L,64L,117L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111807Inst : IEnumerable<long>
{
public static readonly long[] Value=A111807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111807.Bytes);
public long this[int i]=>Value[i];

public static A111807Inst Instance=new A111807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111808
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,3L,6L,7L,1L,4L,10L,16L,19L,1L,5L,15L,30L,45L,51L,1L,6L,21L,50L,90L,126L,141L,1L,7L,28L,77L,161L,266L,357L,393L,1L,8L,36L,112L,266L,504L,784L,1016L,1107L,1L,9L,45L,156L,414L,882L,1554L,2304L,2907L,3139L,1L,10L,55L,210L,615L,1452L,2850L,4740L,6765L,8350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111808Inst : IEnumerable<long>
{
public static readonly long[] Value=A111808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111808.Bytes);
public long this[int i]=>Value[i];

public static A111808Inst Instance=new A111808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111809
{
public static readonly long[] Value={ 1L,2L,3L,8L,4L,6L,5L,18L,12L,17L,6L,5L,7L,32L,39L,16L,23L,36L,8L,12L,10L,14L,9L,24L,12L,20L,17L,23L,10L,15L,7L,20L,11L,72L,48L,36L,47L,24L,35L,95L,72L,60L,12L,10L,7L,12L,13L,98L,71L,82L,95L,101L,28L,41L,47L,58L,71L,96L,14L,21L,34L,9L,34L,41L,15L,32L,16L,21L,8L,23L,13L,15L,16L,24L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111809Inst : IEnumerable<long>
{
public static readonly long[] Value=A111809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111809.Bytes);
public long this[int i]=>Value[i];

public static A111809Inst Instance=new A111809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111810
{
public static readonly long[] Value={ 0L,1L,0L,2L,2L,0L,10L,4L,4L,0L,88L,20L,8L,8L,0L,1096L,176L,40L,16L,16L,0L,11856L,2192L,352L,80L,32L,32L,0L,-402480L,23712L,4384L,704L,160L,64L,64L,0L,-1891968L,-804960L,47424L,8768L,1408L,320L,128L,128L,0L,36024603264L,-3783936L,-1609920L,94848L,17536L,2816L,640L,256L,256L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111810Inst : IEnumerable<long>
{
public static readonly long[] Value=A111810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111810.Bytes);
public long this[int i]=>Value[i];

public static A111810Inst Instance=new A111810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111811
{
public static readonly BigInteger[] Value={ 0L,1L,2L,10L,88L,1096L,11856L,-402480L,-1891968L,36024603264L,359905478400L,-53686393014816000L,-644141701131494400L,BigInteger.Parse("1790653231402788752593920"),BigInteger.Parse("25068910772059830672353280"),BigInteger.Parse("-1280832036591718248285105113241600") };
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
public class A111811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111811Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111811.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111811.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111811Inst Instance=new A111811Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111812
{
public static readonly BigInteger[] Value={ 1L,8L,72L,888L,16392L,479736L,23196168L,1909718520L,273790460424L,69532461669880L,31699923943776776L,BigInteger.Parse("26220200137673186808"),BigInteger.Parse("39689067731528646091272"),BigInteger.Parse("110732781183212424923225592") };
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
public class A111812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111812Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111812.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111812.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111812Inst Instance=new A111812Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111813
{
public static readonly long[] Value={ 0L,1L,0L,0L,2L,0L,-2L,0L,4L,0L,0L,-4L,0L,8L,0L,216L,0L,-8L,0L,16L,0L,0L,432L,0L,-16L,0L,32L,0L,-568464L,0L,864L,0L,-32L,0L,64L,0L,0L,-1136928L,0L,1728L,0L,-64L,0L,128L,0L,36058658688L,0L,-2273856L,0L,3456L,0L,-128L,0L,256L,0L,0L,72117317376L,0L,-4547712L,0L,6912L,0L,-256L,0L,512L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111813Inst : IEnumerable<long>
{
public static readonly long[] Value=A111813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111813.Bytes);
public long this[int i]=>Value[i];

public static A111813Inst Instance=new A111813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111814
{
public static readonly BigInteger[] Value={ 0L,1L,0L,-2L,0L,216L,0L,-568464L,0L,36058658688L,0L,-53694310935340800L,0L,BigInteger.Parse("1790669979087018171448320"),0L,BigInteger.Parse("-1280832788659041410080025283840000"),0L,BigInteger.Parse("18961468161294510864200732026858464699187200"),0L };
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
public class A111814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111814Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111814.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111814.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111814Inst Instance=new A111814Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111815
{
public static readonly long[] Value={ 0L,1L,0L,-1L,3L,0L,-3L,-3L,9L,0L,150L,-9L,-9L,27L,0L,1236L,450L,-27L,-27L,81L,0L,-2555748L,3708L,1350L,-81L,-81L,243L,0L,-64342116L,-7667244L,11124L,4050L,-243L,-243L,729L,0L,5885700899760L,-193026348L,-23001732L,33372L,12150L,-729L,-729L,2187L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111815Inst : IEnumerable<long>
{
public static readonly long[] Value=A111815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111815.Bytes);
public long this[int i]=>Value[i];

public static A111815Inst Instance=new A111815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111816
{
public static readonly BigInteger[] Value={ 0L,1L,-1L,-3L,150L,1236L,-2555748L,-64342116L,5885700899760L,442646611978752L,BigInteger.Parse("-1737387344860364226240"),BigInteger.Parse("-367706581563500487774720"),BigInteger.Parse("60788555325888838346137808787840"),BigInteger.Parse("34626906551623392401873575206240000"),BigInteger.Parse("-237458311254822429335982538087618909465992960") };
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
public class A111816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111816Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111816.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111816.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111816Inst Instance=new A111816Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111817
{
public static readonly BigInteger[] Value={ 1L,4L,28L,524L,29804L,5423660L,3276048300L,6744720496300L,48290009081437356L,BigInteger.Parse("1221415413140406958252"),BigInteger.Parse("110523986015743458745929900"),BigInteger.Parse("36150734459755630877180158951596") };
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
public class A111817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111817Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111817.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111817.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111817Inst Instance=new A111817Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111818
{
public static readonly long[] Value={ 0L,1L,0L,-2L,4L,0L,2L,-8L,16L,0L,840L,8L,-32L,64L,0L,-76056L,3360L,32L,-128L,256L,0L,-158761104L,-304224L,13440L,128L,-512L,1024L,0L,390564896784L,-635044416L,-1216896L,53760L,512L,-2048L,4096L,0L,14713376473366656L,1562259587136L,-2540177664L,-4867584L,215040L,2048L,-8192L,16384L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111818Inst : IEnumerable<long>
{
public static readonly long[] Value=A111818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111818.Bytes);
public long this[int i]=>Value[i];

public static A111818Inst Instance=new A111818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111819
{
public static readonly BigInteger[] Value={ 0L,1L,-2L,2L,840L,-76056L,-158761104L,390564896784L,14713376473366656L,BigInteger.Parse("-783793232940393380736"),BigInteger.Parse("-571732910947761663424746240"),BigInteger.Parse("603368029500890443054004423520000"),BigInteger.Parse("8390120127886533420753746115877557580800") };
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
public class A111819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111819Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111819.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111819.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111819Inst Instance=new A111819Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111820
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,55L,25L,1L,1L,2055L,1525L,125L,1L,1L,291430L,311525L,38875L,625L,1L,1L,165397680L,239305275L,40338875L,975625L,3125L,1L,1L,390075741430L,735920617775L,157056792000L,5077475625L,24409375L,15625L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111820Inst : IEnumerable<long>
{
public static readonly long[] Value=A111820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111820.Bytes);
public long this[int i]=>Value[i];

public static A111820Inst Instance=new A111820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111821
{
public static readonly BigInteger[] Value={ 1L,5L,55L,2055L,291430L,165397680L,390075741430L,3927972221522680L,BigInteger.Parse("172358768282285194555"),BigInteger.Parse("33479766506261422878944555"),BigInteger.Parse("29150234311482124092454001991430") };
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
public class A111821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111821Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111821.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111821.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111821Inst Instance=new A111821Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111822
{
public static readonly BigInteger[] Value={ 1L,2L,7L,82L,3707L,642457L,446020582L,1288155051832L,15905066118254957L,BigInteger.Parse("856874264098480364332"),BigInteger.Parse("204616369654716156089739332"),BigInteger.Parse("219286214391142987407272329973707"),BigInteger.Parse("1065403165201779499307991460987124895582"),BigInteger.Parse("23663347632778954225192551079067428619449114332") };
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
public class A111822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111822Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111822.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111822.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111822Inst Instance=new A111822Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111823
{
public static readonly long[] Value={ 0L,1L,0L,-3L,5L,0L,16L,-15L,25L,0L,2814L,80L,-75L,125L,0L,-1092180L,14070L,400L,-375L,625L,0L,-3603928080L,-5460900L,70350L,2000L,-1875L,3125L,0L,58978973128440L,-18019640400L,-27304500L,351750L,10000L,-9375L,15625L,0L,5974833380453777520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111823Inst : IEnumerable<long>
{
public static readonly long[] Value=A111823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111823.Bytes);
public long this[int i]=>Value[i];

public static A111823Inst Instance=new A111823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111824
{
public static readonly BigInteger[] Value={ 0L,1L,-3L,16L,2814L,-1092180L,-3603928080L,58978973128440L,5974833380453777520L,BigInteger.Parse("-3294186866481455009752320"),BigInteger.Parse("-10279982482873484428390722523200"),BigInteger.Parse("175129088125361734252730927280177244800") };
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
public class A111824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111824Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111824.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111824.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111824Inst Instance=new A111824Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111825
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,96L,36L,1L,1L,6306L,3816L,216L,1L,1L,1883076L,1625436L,139536L,1296L,1L,1L,2700393702L,3121837776L,360839016L,5036256L,7776L,1L,1L,19324893252552L,28794284803908L,4200503990976L,78293629296L,181382976L,46656L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111825Inst : IEnumerable<long>
{
public static readonly long[] Value=A111825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111825.Bytes);
public long this[int i]=>Value[i];

public static A111825Inst Instance=new A111825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111826
{
public static readonly BigInteger[] Value={ 1L,6L,96L,6306L,1883076L,2700393702L,19324893252552L,709398600017820522L,BigInteger.Parse("136347641698786289641932"),BigInteger.Parse("139389318443495655514432423662"),BigInteger.Parse("767442745549858935398537400096197328") };
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
public class A111826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111826Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111826.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111826.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111826Inst Instance=new A111826Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111827
{
public static readonly BigInteger[] Value={ 1L,2L,8L,134L,10340L,3649346L,6188114528L,52398157106366L,2277627698797283420L,BigInteger.Parse("518758596372421679994170"),BigInteger.Parse("628925760908337480420110203736"),BigInteger.Parse("4109478867142143642923124190955500214") };
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
public class A111827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111827Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111827.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111827.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111827Inst Instance=new A111827Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111828
{
public static readonly BigInteger[] Value={ 0L,1L,0L,-4L,6L,0L,42L,-24L,36L,0L,7296L,252L,-144L,216L,0L,-7931976L,43776L,1512L,-864L,1296L,0L,-45557382240L,-47591856L,262656L,9072L,-5184L,7776L,0L,3064554175021200L,-273344293440L,-285551136L,1575936L,54432L,-31104L,46656L,0L,BigInteger.Parse("801993619807364206080") };
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
public class A111828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111828Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111828.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111828.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111828Inst Instance=new A111828Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111829
{
public static readonly BigInteger[] Value={ 0L,1L,-4L,42L,7296L,-7931976L,-45557382240L,3064554175021200L,BigInteger.Parse("801993619807364206080"),BigInteger.Parse("-2618439032548254776387771520"),BigInteger.Parse("-30580166025709706974876961026475520"),BigInteger.Parse("4440597519115996836838709580481861376121600") };
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
public class A111829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111829Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111829.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111829.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111829Inst Instance=new A111829Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111830
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,154L,49L,1L,1L,16275L,8281L,343L,1L,1L,9106461L,6558209L,410914L,2401L,1L,1L,28543862991L,27307109501L,2298650515L,20170801L,16807L,1L,1L,521136519414483L,636922972420469L,67522139062441L,790856748801L,988621354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111830Inst : IEnumerable<long>
{
public static readonly long[] Value=A111830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111830.Bytes);
public long this[int i]=>Value[i];

public static A111830Inst Instance=new A111830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111831
{
public static readonly BigInteger[] Value={ 1L,7L,154L,16275L,9106461L,28543862991L,521136519414483L,BigInteger.Parse("56980036448207052005"),BigInteger.Parse("38084892600214854893482284"),BigInteger.Parse("158081960770204032330986210466109"),BigInteger.Parse("4125860571927530263431055188002578191656") };
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
public class A111831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111831Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111831.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111831.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111831Inst Instance=new A111831Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111832
{
public static readonly BigInteger[] Value={ 1L,2L,9L,205L,24901L,16077987L,58169810617L,1226373476385199L,BigInteger.Parse("154912862345527456431"),BigInteger.Parse("119679779055077323244243580"),BigInteger.Parse("574461679441277269788798742908435"),BigInteger.Parse("17346328772332966415272910459727649244337"),BigInteger.Parse("3328366331331467859745524303574824288197338547909") };
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
public class A111832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111832Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111832.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111832.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111832Inst Instance=new A111832Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111833
{
public static readonly long[] Value={ 0L,1L,0L,-5L,7L,0L,83L,-35L,49L,0L,16110L,581L,-245L,343L,0L,-40097784L,112770L,4067L,-1715L,2401L,0L,-388036363380L,-280684488L,789390L,28469L,-12005L,16807L,0L,82804198261002036L,-2716254543660L,-1964791416L,5525730L,199283L,-84035L,117649L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111833Inst : IEnumerable<long>
{
public static readonly long[] Value=A111833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111833.Bytes);
public long this[int i]=>Value[i];

public static A111833Inst Instance=new A111833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111834
{
public static readonly BigInteger[] Value={ 0L,1L,-5L,83L,16110L,-40097784L,-388036363380L,82804198261002036L,BigInteger.Parse("50475967918183333160880"),BigInteger.Parse("-711988160501968313699728393632"),BigInteger.Parse("-26438313284970847487368499812182785280"),BigInteger.Parse("22571673265500745067336177578868612107537514880") };
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
public class A111834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111834Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111834.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111834.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111834Inst Instance=new A111834Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111835
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,232L,64L,1L,1L,36968L,16192L,512L,1L,1L,35593832L,21928768L,1047040L,4096L,1L,1L,219379963496L,178379459392L,11424946688L,67096576L,32768L,1L,1L,9003699178010216L,9288403489672000L,748093366229504L,5862250172416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111835Inst : IEnumerable<long>
{
public static readonly long[] Value=A111835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111835.Bytes);
public long this[int i]=>Value[i];

public static A111835Inst Instance=new A111835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111836
{
public static readonly BigInteger[] Value={ 1L,8L,232L,36968L,35593832L,219379963496L,9003699178010216L,BigInteger.Parse("2530260913162860295784"),BigInteger.Parse("4970141819535151534947497576"),BigInteger.Parse("69322146154435681317709098939119208") };
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
public class A111836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111836.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111836Inst Instance=new A111836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111837
{
public static readonly BigInteger[] Value={ 1L,2L,10L,298L,53674L,58573738L,409251498922L,19046062579215274L,BigInteger.Parse("6071277235712979102634"),BigInteger.Parse("13531779463193107731083553706"),BigInteger.Parse("214224474679766323250278564215516074"),BigInteger.Parse("24390479071277895100812271376578637910371242"),BigInteger.Parse("20173309182842708837666031701435147789403500172143530") };
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
public class A111837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111837Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111837.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111837.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111837Inst Instance=new A111837Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111838
{
public static readonly long[] Value={ 0L,1L,0L,-6L,8L,0L,142L,-48L,64L,0L,31800L,1136L,-384L,512L,0L,-159468264L,254400L,9088L,-3072L,4096L,0L,-2481298801008L,-1275746112L,2035200L,72704L,-24576L,32768L,0L,1414130111428687344L,-19850390408064L,-10205968896L,16281600L,581632L,-196608L,262144L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111838Inst : IEnumerable<long>
{
public static readonly long[] Value=A111838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111838.Bytes);
public long this[int i]=>Value[i];

public static A111838Inst Instance=new A111838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111839
{
public static readonly BigInteger[] Value={ 0L,1L,-6L,142L,31800L,-159468264L,-2481298801008L,1414130111428687344L,BigInteger.Parse("1827317023092830201950080"),BigInteger.Parse("-89946874545119714361987192509568"),BigInteger.Parse("-9262235489215916508714844705185660161280") };
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
public class A111839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111839Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111839.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111839.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111839Inst Instance=new A111839Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111840
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,1L,18L,18L,9L,1L,216L,216L,135L,27L,1L,5589L,5589L,4050L,1134L,81L,1L,336555L,336555L,269730L,95256L,9963L,243L,1L,49768101L,49768101L,42724503L,17926839L,2450898L,88938L,729L,1L,18707873562L,18707873562L,16835895603L,8074043145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111840Inst : IEnumerable<long>
{
public static readonly long[] Value=A111840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111840.Bytes);
public long this[int i]=>Value[i];

public static A111840Inst Instance=new A111840Inst();

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