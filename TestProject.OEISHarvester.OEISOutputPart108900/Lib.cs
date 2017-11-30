using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A142077
{
public static readonly long[] Value={ 2L,37L,107L,317L,457L,877L,947L,1087L,1297L,1367L,1787L,1997L,2137L,2207L,2347L,2417L,2557L,2767L,2837L,3187L,3257L,3467L,3607L,3677L,4027L,4447L,4517L,4657L,4937L,5077L,5147L,5987L,6197L,6337L,6547L,6827L,6967L,7177L,7247L,7457L,7877L,8017L,8087L,8297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142077Inst : IEnumerable<long>
{
public static readonly long[] Value=A142077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142077.Bytes);
public long this[int i]=>Value[i];

public static A142077Inst Instance=new A142077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142078
{
public static readonly long[] Value={ 3L,73L,283L,353L,563L,773L,983L,1123L,1193L,1543L,1613L,1753L,1823L,2243L,2383L,2593L,2663L,2803L,3083L,3433L,3643L,3853L,3923L,4133L,4273L,4483L,4903L,4973L,5113L,5323L,5393L,5743L,5813L,5953L,6163L,6373L,6653L,6793L,6863L,7213L,7283L,7703L,8053L,8123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142078Inst : IEnumerable<long>
{
public static readonly long[] Value=A142078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142078.Bytes);
public long this[int i]=>Value[i];

public static A142078Inst Instance=new A142078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142079
{
public static readonly long[] Value={ 109L,179L,389L,599L,739L,809L,1019L,1229L,1439L,1579L,1789L,1999L,2069L,2699L,2909L,3049L,3119L,3259L,3329L,3469L,3539L,3889L,4099L,4519L,4729L,4799L,5009L,5569L,5639L,5779L,5849L,6199L,6269L,6619L,6689L,6829L,6899L,7039L,7109L,7459L,7529L,7669L,7879L,7949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142079Inst : IEnumerable<long>
{
public static readonly long[] Value=A142079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142079.Bytes);
public long this[int i]=>Value[i];

public static A142079Inst Instance=new A142079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142080
{
public static readonly long[] Value={ 41L,181L,251L,461L,601L,811L,881L,1021L,1091L,1231L,1301L,1511L,1721L,1861L,1931L,2141L,2281L,2351L,3121L,3191L,3331L,3541L,3821L,4241L,4451L,4591L,4801L,4871L,5011L,5081L,5431L,5501L,5641L,5711L,5851L,6131L,6271L,6481L,6551L,6691L,6761L,6971L,7321L,7741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142080Inst : IEnumerable<long>
{
public static readonly long[] Value=A142080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142080.Bytes);
public long this[int i]=>Value[i];

public static A142080Inst Instance=new A142080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142081
{
public static readonly long[] Value={ 43L,113L,463L,673L,743L,883L,953L,1093L,1163L,1303L,1373L,1583L,1723L,1933L,2003L,2143L,2213L,2423L,2633L,2843L,3613L,3823L,4243L,4523L,4663L,4733L,4943L,5153L,5503L,5573L,5783L,5923L,6133L,6203L,6343L,6553L,6763L,6833L,7043L,7253L,7393L,7603L,7673L,7883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142081Inst : IEnumerable<long>
{
public static readonly long[] Value=A142081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142081.Bytes);
public long this[int i]=>Value[i];

public static A142081Inst Instance=new A142081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142082
{
public static readonly long[] Value={ 79L,149L,359L,499L,569L,709L,919L,1129L,1409L,1549L,1619L,1759L,2039L,2179L,2389L,2459L,2879L,3019L,3089L,3229L,3299L,3719L,3929L,4139L,4349L,4909L,5119L,5189L,5399L,5749L,6029L,6379L,6449L,6659L,6869L,7079L,7219L,7499L,7639L,7919L,8059L,8269L,8689L,8969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142082Inst : IEnumerable<long>
{
public static readonly long[] Value=A142082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142082.Bytes);
public long this[int i]=>Value[i];

public static A142082Inst Instance=new A142082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142083
{
public static readonly long[] Value={ 11L,151L,431L,571L,641L,991L,1061L,1201L,1481L,1621L,1831L,1901L,2111L,2251L,2531L,2671L,2741L,3301L,3371L,3511L,3581L,3931L,4001L,4211L,4421L,4561L,5051L,5261L,5471L,5821L,6101L,6311L,6451L,6521L,6661L,6871L,7151L,8761L,8831L,8971L,9041L,9181L,9391L,9461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142083Inst : IEnumerable<long>
{
public static readonly long[] Value=A142083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142083.Bytes);
public long this[int i]=>Value[i];

public static A142083Inst Instance=new A142083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142084
{
public static readonly long[] Value={ 47L,257L,397L,467L,607L,677L,887L,1097L,1237L,1307L,1447L,1657L,1867L,2287L,2357L,2707L,2777L,2917L,3407L,3547L,3617L,3967L,4177L,4457L,4597L,4877L,5087L,5227L,5297L,5437L,5507L,5647L,5717L,5857L,5927L,6067L,6277L,6907L,6977L,7187L,7537L,7607L,7817L,8167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142084Inst : IEnumerable<long>
{
public static readonly long[] Value=A142084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142084.Bytes);
public long this[int i]=>Value[i];

public static A142084Inst Instance=new A142084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142085
{
public static readonly long[] Value={ 13L,83L,223L,293L,433L,503L,643L,853L,1063L,1483L,1553L,1693L,1973L,2113L,2393L,2953L,3023L,3163L,3373L,3583L,3793L,3863L,4003L,4073L,4283L,4423L,4493L,4703L,5333L,5683L,6173L,6733L,6803L,7013L,7433L,7573L,7643L,7853L,7993L,8273L,8623L,8693L,9043L,9323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142085Inst : IEnumerable<long>
{
public static readonly long[] Value=A142085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142085.Bytes);
public long this[int i]=>Value[i];

public static A142085Inst Instance=new A142085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142086
{
public static readonly long[] Value={ 191L,331L,401L,541L,751L,821L,1031L,1171L,1381L,1451L,1801L,1871L,2011L,2081L,2221L,2711L,2851L,3061L,3271L,3691L,3761L,4111L,4391L,4951L,5021L,5231L,5441L,5581L,5651L,5791L,5861L,6211L,6421L,6491L,6701L,6841L,6911L,7121L,7331L,7541L,7681L,8101L,8171L,8311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142086Inst : IEnumerable<long>
{
public static readonly long[] Value=A142086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142086.Bytes);
public long this[int i]=>Value[i];

public static A142086Inst Instance=new A142086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142087
{
public static readonly long[] Value={ 17L,157L,227L,367L,577L,647L,787L,857L,997L,1277L,1487L,1627L,1697L,1907L,2467L,2677L,2887L,2957L,3167L,3307L,3517L,3727L,3797L,4007L,4217L,4357L,4567L,4637L,4987L,5197L,5407L,5477L,5827L,5897L,6037L,6247L,6317L,6737L,6947L,7297L,7507L,7577L,7717L,7927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142087Inst : IEnumerable<long>
{
public static readonly long[] Value=A142087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142087.Bytes);
public long this[int i]=>Value[i];

public static A142087Inst Instance=new A142087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142104
{
public static readonly long[] Value={ 13L,157L,193L,229L,337L,373L,409L,661L,733L,769L,877L,1021L,1093L,1129L,1201L,1237L,1381L,1453L,1489L,1597L,1669L,1741L,1777L,1993L,2029L,2137L,2281L,2389L,2677L,2713L,2749L,2857L,3001L,3037L,3109L,3181L,3217L,3253L,3361L,3433L,3469L,3541L,3613L,3793L,4153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142104Inst : IEnumerable<long>
{
public static readonly long[] Value=A142104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142104.Bytes);
public long this[int i]=>Value[i];

public static A142104Inst Instance=new A142104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142105
{
public static readonly long[] Value={ 17L,53L,89L,197L,233L,269L,449L,521L,557L,593L,701L,773L,809L,881L,953L,1061L,1097L,1277L,1493L,1601L,1637L,1709L,1889L,1997L,2069L,2141L,2213L,2357L,2393L,2609L,2753L,2789L,2861L,2897L,2969L,3041L,3221L,3257L,3329L,3581L,3617L,3761L,3797L,3833L,4013L,4049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142105Inst : IEnumerable<long>
{
public static readonly long[] Value=A142105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142105.Bytes);
public long this[int i]=>Value[i];

public static A142105Inst Instance=new A142105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142106
{
public static readonly long[] Value={ 19L,127L,163L,199L,271L,307L,379L,487L,523L,631L,739L,811L,883L,919L,991L,1063L,1171L,1279L,1423L,1459L,1531L,1567L,1747L,1783L,1999L,2143L,2179L,2251L,2287L,2467L,2503L,2539L,2647L,2683L,2719L,2791L,2971L,3079L,3187L,3259L,3331L,3511L,3547L,3583L,3691L,3727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142106Inst : IEnumerable<long>
{
public static readonly long[] Value=A142106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142106.Bytes);
public long this[int i]=>Value[i];

public static A142106Inst Instance=new A142106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142107
{
public static readonly long[] Value={ 23L,59L,131L,167L,239L,311L,347L,383L,419L,491L,563L,599L,743L,887L,1031L,1103L,1283L,1319L,1427L,1499L,1571L,1607L,1787L,1823L,1931L,2003L,2039L,2111L,2399L,2543L,2579L,2687L,2903L,2939L,3011L,3083L,3119L,3191L,3299L,3371L,3407L,3623L,3659L,3767L,3803L,3911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142107Inst : IEnumerable<long>
{
public static readonly long[] Value=A142107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142107.Bytes);
public long this[int i]=>Value[i];

public static A142107Inst Instance=new A142107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142108
{
public static readonly long[] Value={ 61L,97L,241L,277L,313L,349L,421L,457L,601L,673L,709L,853L,997L,1033L,1069L,1213L,1249L,1321L,1429L,1609L,1753L,1789L,1861L,1933L,2113L,2221L,2293L,2437L,2473L,2617L,2689L,2797L,2833L,3049L,3121L,3229L,3301L,3373L,3517L,3697L,3733L,3769L,3877L,4021L,4057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142108Inst : IEnumerable<long>
{
public static readonly long[] Value=A142108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142108.Bytes);
public long this[int i]=>Value[i];

public static A142108Inst Instance=new A142108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142109
{
public static readonly long[] Value={ 29L,101L,137L,173L,281L,317L,353L,389L,461L,569L,641L,677L,821L,857L,929L,1109L,1181L,1217L,1289L,1361L,1433L,1613L,1721L,1901L,1973L,2081L,2153L,2297L,2333L,2441L,2477L,2549L,2621L,2657L,2693L,2729L,2801L,2837L,2909L,3089L,3413L,3449L,3557L,3593L,3701L,3881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142109Inst : IEnumerable<long>
{
public static readonly long[] Value=A142109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142109.Bytes);
public long this[int i]=>Value[i];

public static A142109Inst Instance=new A142109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142110
{
public static readonly long[] Value={ 31L,67L,103L,139L,211L,283L,463L,499L,571L,607L,643L,751L,787L,823L,859L,967L,1039L,1291L,1327L,1399L,1471L,1543L,1579L,1723L,1759L,1831L,1867L,2011L,2083L,2371L,2551L,2659L,2731L,2767L,2803L,3019L,3163L,3271L,3307L,3343L,3559L,3631L,3739L,3847L,3919L,4027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142110Inst : IEnumerable<long>
{
public static readonly long[] Value=A142110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142110.Bytes);
public long this[int i]=>Value[i];

public static A142110Inst Instance=new A142110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142111
{
public static readonly long[] Value={ 71L,107L,179L,251L,359L,431L,467L,503L,647L,683L,719L,827L,863L,971L,1151L,1187L,1223L,1259L,1367L,1439L,1511L,1583L,1619L,1871L,1907L,1979L,2087L,2267L,2339L,2411L,2447L,2591L,2663L,2699L,2843L,2879L,3023L,3167L,3203L,3347L,3491L,3527L,3671L,3779L,3851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142111Inst : IEnumerable<long>
{
public static readonly long[] Value=A142111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142111.Bytes);
public long this[int i]=>Value[i];

public static A142111Inst Instance=new A142111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142112
{
public static readonly long[] Value={ 2L,113L,409L,557L,631L,853L,1223L,1297L,1667L,1741L,1889L,2111L,2333L,2777L,2851L,2999L,3221L,3517L,3739L,5441L,5737L,6329L,6551L,7069L,7883L,8179L,8623L,9067L,9437L,9511L,9733L,10103L,10177L,10399L,11213L,11287L,11657L,11731L,11953L,12101L,12323L,12619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142112Inst : IEnumerable<long>
{
public static readonly long[] Value=A142112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142112.Bytes);
public long this[int i]=>Value[i];

public static A142112Inst Instance=new A142112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142113
{
public static readonly long[] Value={ 41L,263L,337L,929L,1151L,1373L,1447L,1669L,2039L,2113L,2557L,2927L,3001L,3371L,3593L,3889L,4111L,4259L,4481L,4703L,4999L,5147L,5443L,5591L,5813L,6257L,6553L,6701L,6997L,7219L,7589L,8329L,8699L,9439L,9587L,9661L,9883L,10253L,10771L,10993L,11437L,11807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142113Inst : IEnumerable<long>
{
public static readonly long[] Value=A142113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142113.Bytes);
public long this[int i]=>Value[i];

public static A142113Inst Instance=new A142113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142114
{
public static readonly long[] Value={ 5L,79L,227L,449L,523L,967L,1559L,2003L,2447L,2521L,3187L,3557L,3631L,3779L,3853L,4001L,4297L,4519L,4889L,5333L,5407L,5851L,6073L,6221L,6961L,7109L,7331L,8219L,8293L,8663L,8737L,9181L,9403L,9551L,10069L,10513L,10883L,10957L,11549L,12289L,12437L,12511L,12659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142114Inst : IEnumerable<long>
{
public static readonly long[] Value=A142114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142114.Bytes);
public long this[int i]=>Value[i];

public static A142114Inst Instance=new A142114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142115
{
public static readonly long[] Value={ 43L,191L,487L,709L,857L,1153L,1301L,1523L,1597L,2411L,2633L,2707L,3299L,3373L,4261L,4409L,4483L,5297L,5519L,5741L,6037L,6481L,6703L,7369L,7517L,7591L,8627L,8849L,8923L,9293L,9811L,10181L,10477L,10847L,11069L,11587L,12253L,12401L,12697L,12919L,13807L,14029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142115Inst : IEnumerable<long>
{
public static readonly long[] Value=A142115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142115.Bytes);
public long this[int i]=>Value[i];

public static A142115Inst Instance=new A142115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142116
{
public static readonly long[] Value={ 7L,229L,599L,673L,821L,1117L,1487L,1709L,1783L,1931L,2153L,2671L,2819L,3041L,3559L,3929L,4003L,4373L,4447L,4817L,5039L,5113L,5261L,5483L,5557L,5779L,5927L,7333L,7481L,7703L,8147L,8221L,8369L,8443L,8887L,9109L,9257L,9479L,9923L,10589L,10663L,11329L,11551L,11699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142116Inst : IEnumerable<long>
{
public static readonly long[] Value=A142116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142116.Bytes);
public long this[int i]=>Value[i];

public static A142116Inst Instance=new A142116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142117
{
public static readonly long[] Value={ 193L,563L,859L,1229L,1303L,1451L,1747L,2339L,2857L,3079L,3301L,3449L,3671L,3967L,4337L,5003L,5077L,5521L,5669L,5743L,6113L,6779L,7001L,7297L,7741L,7963L,8111L,8629L,8999L,9221L,9739L,9887L,10331L,10627L,11071L,11959L,12107L,12329L,13217L,13291L,13513L,13883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142117Inst : IEnumerable<long>
{
public static readonly long[] Value=A142117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142117.Bytes);
public long this[int i]=>Value[i];

public static A142117Inst Instance=new A142117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142118
{
public static readonly long[] Value={ 83L,157L,379L,601L,823L,971L,1193L,1489L,1637L,1933L,2081L,2377L,2969L,3191L,3413L,3709L,3931L,4079L,4153L,4523L,4597L,4967L,5189L,6151L,6299L,6373L,6521L,7039L,7187L,7853L,7927L,8297L,8741L,8963L,9629L,9851L,10369L,10739L,11257L,11701L,11923L,12071L,12589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142118Inst : IEnumerable<long>
{
public static readonly long[] Value=A142118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142118.Bytes);
public long this[int i]=>Value[i];

public static A142118Inst Instance=new A142118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142119
{
public static readonly long[] Value={ 47L,269L,491L,787L,1009L,1231L,1453L,1601L,1823L,2267L,2341L,2711L,3229L,3673L,3821L,4339L,4561L,4783L,4931L,5153L,5227L,5449L,6263L,6337L,6781L,7151L,7669L,7817L,8039L,8779L,9001L,9371L,10037L,10111L,10259L,10333L,11369L,11443L,11813L,11887L,12109L,12479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142119Inst : IEnumerable<long>
{
public static readonly long[] Value=A142119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142119.Bytes);
public long this[int i]=>Value[i];

public static A142119Inst Instance=new A142119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142168
{
public static readonly long[] Value={ 211L,367L,523L,601L,757L,991L,1069L,1303L,1381L,1459L,1693L,2083L,2161L,2239L,2473L,2551L,2707L,3019L,3253L,3331L,3643L,3877L,4111L,4423L,4657L,4813L,4969L,5281L,5437L,5749L,5827L,6217L,6373L,6451L,6529L,6607L,6763L,6841L,6997L,7309L,7621L,7699L,7933L,8011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142168Inst : IEnumerable<long>
{
public static readonly long[] Value=A142168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142168.Bytes);
public long this[int i]=>Value[i];

public static A142168Inst Instance=new A142168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142169
{
public static readonly long[] Value={ 17L,173L,251L,563L,641L,719L,797L,953L,1031L,1109L,1187L,1499L,1733L,1811L,1889L,2357L,2591L,2903L,3137L,3371L,3449L,3527L,3761L,3917L,4073L,4229L,4463L,4931L,5009L,5087L,5399L,5477L,5711L,5867L,6101L,6257L,6491L,6569L,6803L,6959L,7193L,7349L,7583L,7817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142169Inst : IEnumerable<long>
{
public static readonly long[] Value=A142169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142169.Bytes);
public long this[int i]=>Value[i];

public static A142169Inst Instance=new A142169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142170
{
public static readonly long[] Value={ 19L,97L,331L,409L,487L,643L,877L,1033L,1423L,1579L,1657L,2203L,2281L,2437L,2593L,2671L,2749L,3061L,3217L,3373L,3529L,3607L,3919L,4153L,4231L,4621L,4933L,5011L,5167L,5323L,5479L,5557L,5791L,5869L,6337L,6571L,6883L,6961L,7039L,7351L,7507L,7741L,8053L,8209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142170Inst : IEnumerable<long>
{
public static readonly long[] Value=A142170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142170.Bytes);
public long this[int i]=>Value[i];

public static A142170Inst Instance=new A142170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142171
{
public static readonly long[] Value={ 59L,137L,293L,449L,683L,761L,839L,1151L,1229L,1307L,1619L,1697L,1931L,2087L,2243L,2399L,2477L,2633L,2711L,2789L,3023L,3257L,3413L,3491L,3803L,3881L,4271L,4349L,4583L,4817L,4973L,5051L,5441L,5519L,5987L,6143L,6221L,6299L,6689L,7001L,7079L,7547L,7703L,7937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142171Inst : IEnumerable<long>
{
public static readonly long[] Value=A142171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142171.Bytes);
public long this[int i]=>Value[i];

public static A142171Inst Instance=new A142171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142172
{
public static readonly long[] Value={ 61L,139L,373L,607L,919L,997L,1153L,1231L,1543L,1621L,1699L,1777L,1933L,2011L,2089L,2557L,2713L,2791L,3181L,3259L,3571L,3727L,4273L,4507L,4663L,5209L,5443L,5521L,6067L,6301L,6379L,6691L,7159L,7237L,7393L,7549L,8017L,8329L,8563L,8641L,8719L,9109L,9187L,9343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142172Inst : IEnumerable<long>
{
public static readonly long[] Value=A142172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142172.Bytes);
public long this[int i]=>Value[i];

public static A142172Inst Instance=new A142172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142173
{
public static readonly long[] Value={ 23L,101L,179L,257L,491L,569L,647L,881L,1193L,1427L,1583L,1973L,2129L,2207L,2441L,2753L,2909L,3221L,3299L,3533L,3767L,3923L,4001L,4079L,4157L,4391L,4547L,4703L,4937L,5171L,5483L,5639L,5717L,6029L,6263L,6653L,7043L,7121L,7433L,7589L,7823L,7901L,8291L,8369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142173Inst : IEnumerable<long>
{
public static readonly long[] Value=A142173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142173.Bytes);
public long this[int i]=>Value[i];

public static A142173Inst Instance=new A142173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142174
{
public static readonly long[] Value={ 103L,181L,337L,571L,727L,883L,1039L,1117L,1429L,1663L,1741L,2053L,2131L,2287L,2521L,2677L,2833L,3067L,3301L,3457L,3613L,3691L,3769L,3847L,4003L,4159L,4549L,4783L,4861L,5407L,5563L,5641L,5953L,6343L,6421L,6577L,6733L,6967L,7591L,7669L,8059L,8293L,8527L,8761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142174Inst : IEnumerable<long>
{
public static readonly long[] Value=A142174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142174.Bytes);
public long this[int i]=>Value[i];

public static A142174Inst Instance=new A142174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142175
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,36L,36L,1L,1L,133L,420L,133L,1L,1L,449L,3334L,3334L,449L,1L,1L,1446L,21939L,49364L,21939L,1446L,1L,1L,4534L,130044L,560957L,560957L,130044L,4534L,1L,1L,13991L,724222L,5459561L,10284514L,5459561L,724222L,13991L,1L,1L,42747L,3880014L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142175Inst : IEnumerable<long>
{
public static readonly long[] Value=A142175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142175.Bytes);
public long this[int i]=>Value[i];

public static A142175Inst Instance=new A142175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142176
{
public static readonly long[] Value={ 29L,107L,263L,419L,653L,809L,887L,1277L,1433L,1511L,1667L,1823L,1901L,1979L,2213L,2447L,2837L,3461L,3539L,3617L,3851L,3929L,4007L,4241L,4397L,4787L,4943L,5021L,5099L,5333L,5801L,5879L,6113L,6269L,6581L,6659L,6737L,6971L,7127L,7283L,7517L,7673L,7829L,7907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142176Inst : IEnumerable<long>
{
public static readonly long[] Value=A142176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142176.Bytes);
public long this[int i]=>Value[i];

public static A142176Inst Instance=new A142176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142177
{
public static readonly long[] Value={ 31L,109L,421L,499L,577L,733L,811L,967L,1123L,1201L,1279L,1669L,1747L,2137L,2293L,2371L,2683L,2917L,3229L,3307L,3463L,3541L,3697L,3853L,3931L,4243L,4789L,5023L,5101L,5179L,5413L,5569L,5647L,5881L,6037L,6271L,6427L,6661L,7129L,7207L,7753L,8221L,8377L,8689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142177Inst : IEnumerable<long>
{
public static readonly long[] Value=A142177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142177.Bytes);
public long this[int i]=>Value[i];

public static A142177Inst Instance=new A142177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142178
{
public static readonly long[] Value={ 71L,149L,227L,383L,461L,617L,773L,929L,1163L,1319L,1553L,1709L,1787L,2099L,2333L,2411L,2801L,2879L,2957L,3191L,3347L,3581L,3659L,4049L,4127L,4283L,4517L,4673L,4751L,5297L,5531L,5843L,6311L,6389L,6701L,6779L,6857L,7013L,7247L,7481L,7559L,7793L,7949L,8573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142178Inst : IEnumerable<long>
{
public static readonly long[] Value=A142178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142178.Bytes);
public long this[int i]=>Value[i];

public static A142178Inst Instance=new A142178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142179
{
public static readonly long[] Value={ 73L,151L,229L,307L,463L,541L,619L,853L,1009L,1087L,1321L,1399L,1789L,1867L,2179L,2647L,2803L,3037L,3271L,3583L,3739L,4051L,4129L,4363L,4441L,4519L,4597L,4831L,4909L,4987L,5689L,5923L,6079L,6469L,6547L,6703L,6781L,7561L,7639L,7717L,7873L,7951L,8263L,8419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142179Inst : IEnumerable<long>
{
public static readonly long[] Value=A142179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142179.Bytes);
public long this[int i]=>Value[i];

public static A142179Inst Instance=new A142179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142180
{
public static readonly long[] Value={ 113L,191L,269L,347L,503L,659L,971L,1049L,1283L,1361L,1439L,1907L,2063L,2141L,2297L,2531L,2609L,2687L,2843L,2999L,3389L,3467L,3623L,3701L,3779L,4013L,4091L,4481L,4637L,4793L,4871L,5261L,5417L,5573L,5651L,5807L,6197L,6353L,6899L,6977L,7211L,7523L,7757L,8069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142180Inst : IEnumerable<long>
{
public static readonly long[] Value=A142180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142180.Bytes);
public long this[int i]=>Value[i];

public static A142180Inst Instance=new A142180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142181
{
public static readonly long[] Value={ 37L,193L,271L,349L,661L,739L,1051L,1129L,1597L,1753L,1831L,1987L,2143L,2221L,2377L,2689L,2767L,3001L,3079L,3313L,3391L,3469L,3547L,4093L,4327L,4483L,4561L,4639L,4951L,5107L,5419L,5653L,6043L,6121L,6199L,6277L,6823L,7057L,7213L,7369L,7603L,7681L,7759L,7993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142181Inst : IEnumerable<long>
{
public static readonly long[] Value=A142181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142181.Bytes);
public long this[int i]=>Value[i];

public static A142181Inst Instance=new A142181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142182
{
public static readonly long[] Value={ 233L,311L,389L,467L,701L,857L,1013L,1091L,1481L,1559L,1637L,1871L,1949L,2027L,2339L,2417L,2729L,2963L,3041L,3119L,3821L,4133L,4211L,4289L,4523L,4679L,5147L,5303L,5381L,5693L,5849L,5927L,6317L,6473L,6551L,6863L,7019L,7253L,7331L,7487L,7643L,7877L,8111L,8423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142182Inst : IEnumerable<long>
{
public static readonly long[] Value=A142182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142182.Bytes);
public long this[int i]=>Value[i];

public static A142182Inst Instance=new A142182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142183
{
public static readonly long[] Value={ 41L,241L,281L,401L,521L,601L,641L,761L,881L,1201L,1321L,1361L,1481L,1601L,1721L,1801L,2081L,2161L,2281L,2441L,2521L,2801L,3001L,3041L,3121L,3361L,3761L,3881L,4001L,4201L,4241L,4441L,4481L,4561L,4721L,4801L,5081L,5281L,5441L,5521L,5641L,5801L,5881L,6121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142183Inst : IEnumerable<long>
{
public static readonly long[] Value=A142183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142183.Bytes);
public long this[int i]=>Value[i];

public static A142183Inst Instance=new A142183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142312
{
public static readonly long[] Value={ 181L,271L,541L,631L,811L,991L,1171L,1531L,1621L,1801L,2161L,2251L,2341L,2521L,2791L,2971L,3061L,3331L,3511L,3691L,4051L,4231L,4591L,4861L,4951L,5581L,5851L,6121L,6211L,6301L,6481L,6571L,6661L,6841L,7561L,7741L,8011L,8101L,8191L,8461L,8641L,8731L,8821L,9001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142312Inst : IEnumerable<long>
{
public static readonly long[] Value=A142312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142312.Bytes);
public long this[int i]=>Value[i];

public static A142312Inst Instance=new A142312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142313
{
public static readonly long[] Value={ 2L,47L,137L,227L,317L,587L,677L,857L,947L,1217L,1307L,1487L,1667L,1847L,2027L,2207L,2297L,2477L,2657L,2837L,2927L,3467L,3557L,3917L,4007L,4457L,4547L,4637L,4817L,5087L,5717L,5807L,5897L,5987L,6257L,6977L,7247L,7517L,7607L,7877L,8147L,8237L,8597L,8867L,9137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142313Inst : IEnumerable<long>
{
public static readonly long[] Value=A142313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142313.Bytes);
public long this[int i]=>Value[i];

public static A142313Inst Instance=new A142313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142314
{
public static readonly long[] Value={ 139L,229L,409L,499L,769L,859L,1039L,1129L,1399L,1489L,1579L,1669L,1759L,2029L,2389L,2659L,2749L,3019L,3109L,3469L,3559L,3739L,3919L,4099L,4549L,4639L,4729L,4909L,4999L,5179L,5449L,6079L,6529L,6619L,6709L,7069L,7159L,7699L,7789L,7879L,8059L,8329L,8419L,8599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142314Inst : IEnumerable<long>
{
public static readonly long[] Value=A142314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142314.Bytes);
public long this[int i]=>Value[i];

public static A142314Inst Instance=new A142314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142315
{
public static readonly long[] Value={ 7L,97L,277L,367L,457L,547L,727L,907L,997L,1087L,1447L,1627L,1987L,2347L,2437L,2617L,2707L,2797L,2887L,3067L,3517L,3607L,3697L,3877L,3967L,4057L,4327L,4507L,4597L,4957L,5227L,5407L,5857L,6037L,6217L,6397L,6577L,7027L,7207L,7297L,7477L,7927L,8017L,8287L,8377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142315Inst : IEnumerable<long>
{
public static readonly long[] Value=A142315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142315.Bytes);
public long this[int i]=>Value[i];

public static A142315Inst Instance=new A142315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142316
{
public static readonly long[] Value={ 53L,233L,503L,593L,683L,773L,863L,953L,1223L,1493L,1583L,2213L,2393L,2663L,2753L,2843L,3023L,3203L,3833L,3923L,4013L,4283L,4373L,4463L,4643L,4733L,5003L,5273L,5813L,5903L,6173L,6263L,6353L,6803L,6983L,7253L,7433L,7523L,7703L,7793L,7883L,8243L,8423L,8513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142316Inst : IEnumerable<long>
{
public static readonly long[] Value=A142316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142316.Bytes);
public long this[int i]=>Value[i];

public static A142316Inst Instance=new A142316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142317
{
public static readonly long[] Value={ 11L,101L,191L,281L,461L,641L,821L,911L,1091L,1181L,1361L,1451L,1721L,1811L,1901L,2081L,2351L,2441L,2531L,2621L,2711L,2801L,3251L,3701L,3881L,4241L,4421L,4691L,4871L,5051L,5231L,5501L,5591L,5861L,6131L,6221L,6311L,6491L,6581L,6761L,7121L,7211L,7481L,7841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142317Inst : IEnumerable<long>
{
public static readonly long[] Value=A142317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142317.Bytes);
public long this[int i]=>Value[i];

public static A142317Inst Instance=new A142317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142318
{
public static readonly long[] Value={ 13L,103L,193L,283L,373L,463L,643L,733L,823L,1093L,1453L,1543L,1723L,1993L,2083L,2713L,2803L,3163L,3253L,3343L,3433L,3613L,3793L,4153L,4243L,4423L,4513L,4603L,4783L,5233L,5323L,5413L,5503L,5683L,5953L,6043L,6133L,6673L,6763L,7213L,7393L,7573L,7753L,7933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142318Inst : IEnumerable<long>
{
public static readonly long[] Value=A142318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142318.Bytes);
public long this[int i]=>Value[i];

public static A142318Inst Instance=new A142318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142319
{
public static readonly long[] Value={ 59L,149L,239L,419L,509L,599L,1049L,1229L,1319L,1409L,1499L,1949L,2039L,2129L,2309L,2399L,2579L,2939L,3119L,3209L,3299L,3389L,3659L,3929L,4019L,4289L,4649L,4919L,5009L,5099L,5189L,5279L,5639L,6089L,6269L,6359L,6449L,6719L,6899L,7079L,7349L,7529L,8069L,8429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142319Inst : IEnumerable<long>
{
public static readonly long[] Value=A142319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142319.Bytes);
public long this[int i]=>Value[i];

public static A142319Inst Instance=new A142319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142320
{
public static readonly long[] Value={ 61L,151L,241L,331L,421L,601L,691L,1051L,1231L,1321L,1861L,1951L,2131L,2221L,2311L,2671L,2851L,3121L,3301L,3391L,3571L,3931L,4021L,4111L,4201L,4561L,4651L,4831L,5011L,5101L,5281L,5641L,5821L,6091L,6271L,6361L,6451L,6991L,7351L,7621L,8161L,8431L,8521L,8971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142320Inst : IEnumerable<long>
{
public static readonly long[] Value=A142320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142320.Bytes);
public long this[int i]=>Value[i];

public static A142320Inst Instance=new A142320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142321
{
public static readonly long[] Value={ 17L,107L,197L,467L,557L,647L,827L,1097L,1187L,1277L,1367L,1637L,1907L,1997L,2087L,2267L,2357L,2447L,2897L,3167L,3257L,3347L,3527L,3617L,3797L,4157L,4337L,4517L,4787L,4877L,4967L,5147L,5237L,5417L,5507L,5867L,6047L,6317L,6857L,6947L,7127L,7307L,7487L,7577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142321Inst : IEnumerable<long>
{
public static readonly long[] Value=A142321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142321.Bytes);
public long this[int i]=>Value[i];

public static A142321Inst Instance=new A142321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142322
{
public static readonly long[] Value={ 19L,109L,199L,379L,739L,829L,919L,1009L,1279L,1459L,1549L,1999L,2089L,2179L,2269L,2539L,2719L,3079L,3169L,3259L,3529L,3709L,3889L,4159L,4339L,4519L,4789L,4969L,5059L,5419L,5689L,5779L,5869L,6229L,6679L,6949L,7039L,7129L,7219L,7309L,7489L,7669L,7759L,8209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142322Inst : IEnumerable<long>
{
public static readonly long[] Value=A142322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142322.Bytes);
public long this[int i]=>Value[i];

public static A142322Inst Instance=new A142322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142323
{
public static readonly long[] Value={ 67L,157L,337L,607L,787L,877L,967L,1237L,1327L,1597L,1777L,1867L,2137L,2677L,2767L,2857L,3037L,3217L,3307L,3847L,4027L,4297L,4567L,4657L,5107L,5197L,5557L,5647L,5737L,5827L,6007L,6277L,6367L,6547L,6637L,6907L,6997L,7177L,7537L,7717L,8167L,8527L,8707L,8887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142323Inst : IEnumerable<long>
{
public static readonly long[] Value=A142323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142323.Bytes);
public long this[int i]=>Value[i];

public static A142323Inst Instance=new A142323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142324
{
public static readonly long[] Value={ 23L,113L,293L,383L,563L,653L,743L,1013L,1103L,1193L,1283L,1373L,1553L,1733L,1823L,1913L,2003L,2273L,2543L,2633L,2903L,3083L,3533L,3623L,3803L,4073L,4253L,4523L,4703L,4793L,4973L,5153L,5333L,5693L,5783L,6053L,6143L,6323L,6863L,7043L,7583L,7673L,7853L,8123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142324Inst : IEnumerable<long>
{
public static readonly long[] Value=A142324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142324.Bytes);
public long this[int i]=>Value[i];

public static A142324Inst Instance=new A142324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142325
{
public static readonly long[] Value={ 71L,251L,431L,521L,701L,881L,971L,1061L,1151L,1511L,1601L,1871L,2141L,2411L,2591L,2861L,3041L,3221L,3491L,3581L,3671L,3761L,3851L,4211L,4391L,4481L,4751L,4931L,5021L,5381L,5471L,5651L,5741L,6011L,6101L,6551L,6911L,7001L,7451L,7541L,7901L,8081L,8171L,9161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142325Inst : IEnumerable<long>
{
public static readonly long[] Value=A142325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142325.Bytes);
public long this[int i]=>Value[i];

public static A142325Inst Instance=new A142325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142326
{
public static readonly long[] Value={ 73L,163L,433L,523L,613L,883L,1063L,1153L,1423L,1693L,1783L,1873L,2053L,2143L,2503L,2593L,2683L,2953L,3313L,3583L,3673L,3853L,3943L,4483L,4663L,4933L,5023L,5113L,5563L,5653L,5743L,5923L,6373L,6553L,6733L,6823L,7723L,7993L,8263L,8353L,8443L,8623L,8713L,8803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142326Inst : IEnumerable<long>
{
public static readonly long[] Value=A142326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142326.Bytes);
public long this[int i]=>Value[i];

public static A142326Inst Instance=new A142326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142327
{
public static readonly long[] Value={ 29L,389L,479L,569L,659L,839L,929L,1019L,1109L,1289L,1559L,2099L,2459L,2549L,2729L,2819L,2909L,2999L,3089L,3359L,3449L,3539L,3719L,3989L,4079L,4259L,4349L,4799L,4889L,5519L,5879L,6329L,6599L,6689L,6779L,6869L,6959L,7229L,7499L,7589L,7949L,8039L,8219L,8669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142327Inst : IEnumerable<long>
{
public static readonly long[] Value=A142327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142327.Bytes);
public long this[int i]=>Value[i];

public static A142327Inst Instance=new A142327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142360
{
public static readonly long[] Value={ 103L,197L,479L,761L,1231L,1607L,1889L,3299L,3581L,3769L,3863L,4051L,5179L,5273L,5743L,6871L,7247L,7529L,7717L,8093L,8563L,9127L,9221L,9973L,10067L,10631L,11383L,12041L,12323L,12511L,13451L,13921L,14767L,15331L,16553L,16741L,17117L,17681L,18433L,19373L,19843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142360Inst : IEnumerable<long>
{
public static readonly long[] Value=A142360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142360.Bytes);
public long this[int i]=>Value[i];

public static A142360Inst Instance=new A142360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142361
{
public static readonly long[] Value={ 151L,433L,809L,997L,1091L,1279L,1373L,2689L,2971L,3253L,3347L,3911L,4099L,4663L,5039L,5227L,5791L,6073L,6449L,6637L,7013L,7577L,8329L,8423L,8893L,9551L,9739L,9833L,10303L,10867L,11149L,11243L,11807L,12277L,12653L,12841L,13217L,13499L,13687L,13781L,14251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142361Inst : IEnumerable<long>
{
public static readonly long[] Value=A142361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142361.Bytes);
public long this[int i]=>Value[i];

public static A142361Inst Instance=new A142361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142362
{
public static readonly long[] Value={ 11L,199L,293L,857L,1327L,1609L,2267L,2549L,3019L,3301L,3583L,3677L,4241L,4523L,4993L,5087L,5557L,5651L,5839L,6121L,6779L,6967L,7907L,8377L,8753L,8941L,9787L,10069L,10163L,11197L,12043L,12889L,12983L,13171L,13829L,14957L,15427L,15803L,15991L,16273L,16649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142362Inst : IEnumerable<long>
{
public static readonly long[] Value=A142362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142362.Bytes);
public long this[int i]=>Value[i];

public static A142362Inst Instance=new A142362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142363
{
public static readonly long[] Value={ 59L,811L,1093L,1187L,1657L,2221L,2503L,2879L,3067L,3631L,4007L,4289L,4759L,5323L,5417L,5981L,6263L,6451L,6733L,6827L,7109L,7297L,7673L,8237L,8707L,9929L,10211L,10399L,11057L,11527L,11621L,11903L,12373L,13219L,13313L,13877L,14159L,14347L,14629L,14723L,15193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142363Inst : IEnumerable<long>
{
public static readonly long[] Value=A142363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142363.Bytes);
public long this[int i]=>Value[i];

public static A142363Inst Instance=new A142363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142364
{
public static readonly long[] Value={ 13L,107L,389L,577L,859L,953L,1423L,1987L,2081L,2269L,2551L,2833L,2927L,3209L,3491L,4243L,4337L,5653L,6029L,6217L,6311L,6781L,8191L,8849L,9319L,9413L,9601L,9883L,10259L,10729L,12421L,12703L,13267L,13831L,14207L,14489L,14771L,15053L,15241L,16087L,16369L,16651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142364Inst : IEnumerable<long>
{
public static readonly long[] Value=A142364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142364.Bytes);
public long this[int i]=>Value[i];

public static A142364Inst Instance=new A142364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142365
{
public static readonly long[] Value={ 61L,719L,907L,1283L,1471L,1753L,1847L,2129L,2411L,2693L,3163L,3257L,3539L,3727L,3821L,5231L,5419L,5701L,6359L,6547L,6829L,7393L,7487L,8521L,8803L,9461L,9649L,9743L,9931L,10589L,11059L,11717L,12281L,13033L,13127L,13597L,13691L,13879L,14537L,15101L,15289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142365Inst : IEnumerable<long>
{
public static readonly long[] Value=A142365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142365.Bytes);
public long this[int i]=>Value[i];

public static A142365Inst Instance=new A142365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142366
{
public static readonly long[] Value={ 109L,673L,1049L,1237L,1613L,1801L,2083L,2459L,2647L,2741L,3023L,4057L,4339L,4621L,4903L,5279L,5749L,5843L,6689L,6971L,7159L,7253L,7723L,7817L,8287L,8663L,9133L,9227L,9697L,9791L,11483L,11953L,12329L,12517L,12611L,12799L,12893L,13457L,14303L,14867L,15149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142366Inst : IEnumerable<long>
{
public static readonly long[] Value=A142366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142366.Bytes);
public long this[int i]=>Value[i];

public static A142366Inst Instance=new A142366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142367
{
public static readonly long[] Value={ 157L,251L,439L,1097L,1567L,2131L,2789L,3259L,3541L,3823L,3917L,4481L,4951L,5233L,6079L,6173L,6361L,6737L,7019L,7207L,7489L,7583L,8053L,8147L,8429L,9181L,9463L,9839L,11437L,11719L,11813L,12377L,12659L,12941L,13411L,13693L,14633L,14821L,15667L,15761L,16231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142367Inst : IEnumerable<long>
{
public static readonly long[] Value=A142367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142367.Bytes);
public long this[int i]=>Value[i];

public static A142367Inst Instance=new A142367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142368
{
public static readonly long[] Value={ 17L,487L,769L,863L,1051L,1427L,1709L,2179L,2273L,2837L,3119L,3307L,4153L,4999L,5281L,5563L,5657L,5939L,6221L,6691L,7349L,7537L,8101L,9041L,9323L,9511L,9887L,10169L,10357L,10639L,10733L,11579L,12049L,12143L,12613L,13177L,13553L,14869L,15527L,15809L,16091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142368Inst : IEnumerable<long>
{
public static readonly long[] Value=A142368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142368.Bytes);
public long this[int i]=>Value[i];

public static A142368Inst Instance=new A142368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142369
{
public static readonly long[] Value={ 347L,911L,1193L,1381L,1663L,2039L,2791L,3167L,3449L,3637L,3919L,4013L,4201L,4483L,5987L,6269L,6551L,6833L,7867L,8243L,8431L,8713L,8807L,9277L,9371L,10499L,10687L,10781L,11251L,11909L,12097L,12379L,12473L,13037L,13789L,13883L,14071L,14447L,15199L,16139L,16421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142369Inst : IEnumerable<long>
{
public static readonly long[] Value=A142369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142369.Bytes);
public long this[int i]=>Value[i];

public static A142369Inst Instance=new A142369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142370
{
public static readonly long[] Value={ 19L,113L,677L,1429L,1523L,1993L,2087L,2557L,3121L,3779L,3967L,4813L,5189L,5471L,5659L,6317L,6599L,7069L,7351L,7727L,8009L,8291L,8573L,8761L,9043L,9137L,9419L,10453L,11299L,11393L,11863L,12239L,13367L,13649L,13931L,14401L,14683L,16187L,16657L,17033L,17597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142370Inst : IEnumerable<long>
{
public static readonly long[] Value=A142370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142370.Bytes);
public long this[int i]=>Value[i];

public static A142370Inst Instance=new A142370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142371
{
public static readonly long[] Value={ 67L,349L,443L,631L,1289L,1571L,1759L,2417L,2699L,2887L,3169L,3733L,4297L,4391L,4673L,4861L,5237L,5519L,5801L,6271L,6553L,7211L,7681L,7963L,8527L,9091L,9467L,9749L,10313L,10501L,11159L,12569L,12757L,13697L,14449L,14543L,14731L,15013L,15107L,15671L,15859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142371Inst : IEnumerable<long>
{
public static readonly long[] Value=A142371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142371.Bytes);
public long this[int i]=>Value[i];

public static A142371Inst Instance=new A142371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142372
{
public static readonly long[] Value={ 397L,491L,773L,1619L,1901L,2089L,2371L,3217L,3499L,3593L,4157L,4721L,4909L,5003L,5849L,6037L,6131L,6883L,6977L,7541L,7823L,8011L,8293L,8387L,8669L,8951L,9421L,10079L,10267L,10831L,11113L,11489L,11677L,11959L,12241L,12899L,13463L,13933L,14591L,14779L,15061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142372Inst : IEnumerable<long>
{
public static readonly long[] Value=A142372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142372.Bytes);
public long this[int i]=>Value[i];

public static A142372Inst Instance=new A142372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142373
{
public static readonly long[] Value={ 163L,257L,727L,821L,1009L,1103L,1291L,1667L,1949L,2137L,3359L,3547L,3923L,4111L,4957L,5051L,5333L,5521L,5897L,6367L,7213L,7307L,7589L,8059L,8623L,8999L,9187L,9281L,10597L,10691L,10973L,11161L,11443L,12007L,12101L,12289L,12853L,13229L,13417L,14639L,14827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142373Inst : IEnumerable<long>
{
public static readonly long[] Value=A142373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142373.Bytes);
public long this[int i]=>Value[i];

public static A142373Inst Instance=new A142373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142374
{
public static readonly long[] Value={ 23L,211L,587L,1151L,1433L,1621L,1997L,2467L,2749L,2843L,3313L,3407L,3877L,4159L,4253L,4441L,4723L,4817L,5099L,5381L,5569L,5851L,6133L,6791L,7919L,8389L,10457L,10739L,11491L,11867L,12149L,12619L,12713L,13183L,13841L,14029L,14593L,14969L,15439L,16097L,16567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142374Inst : IEnumerable<long>
{
public static readonly long[] Value=A142374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142374.Bytes);
public long this[int i]=>Value[i];

public static A142374Inst Instance=new A142374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142375
{
public static readonly long[] Value={ 71L,353L,541L,823L,1481L,1669L,1951L,2609L,2797L,3079L,3361L,3643L,4019L,4583L,5147L,5711L,7027L,7121L,7309L,7591L,7873L,8719L,9001L,9283L,9377L,9941L,10223L,11069L,11257L,11351L,11633L,11821L,12197L,12479L,13043L,13513L,14923L,15017L,15299L,15581L,16333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142375Inst : IEnumerable<long>
{
public static readonly long[] Value=A142375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142375.Bytes);
public long this[int i]=>Value[i];

public static A142375Inst Instance=new A142375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142424
{
public static readonly long[] Value={ 61L,257L,1237L,1433L,1531L,2609L,2707L,2903L,3001L,3491L,4079L,4177L,4373L,5059L,5647L,5843L,6529L,6823L,7019L,7411L,7607L,7901L,8293L,8783L,9371L,10253L,10939L,11527L,11821L,12409L,12703L,12899L,13291L,13487L,13781L,13879L,14173L,14369L,14957L,15349L,15643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142424Inst : IEnumerable<long>
{
public static readonly long[] Value=A142424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142424.Bytes);
public long this[int i]=>Value[i];

public static A142424Inst Instance=new A142424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142425
{
public static readonly long[] Value={ 13L,307L,503L,601L,797L,1091L,1483L,1777L,1973L,2267L,2659L,2953L,3541L,4129L,4423L,5011L,5501L,6089L,6481L,6971L,7069L,7559L,7853L,7951L,8147L,8539L,9029L,9127L,9323L,9421L,10009L,10303L,10499L,10597L,10891L,11087L,11969L,12263L,13537L,13831L,14321L,14419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142425Inst : IEnumerable<long>
{
public static readonly long[] Value=A142425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142425.Bytes);
public long this[int i]=>Value[i];

public static A142425Inst Instance=new A142425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142426
{
public static readonly long[] Value={ 113L,211L,701L,1093L,1289L,1583L,1877L,2269L,2857L,3347L,3739L,4229L,4327L,4523L,4621L,4817L,5209L,5503L,6091L,6287L,6581L,6679L,7561L,7757L,8443L,8737L,8933L,9227L,9521L,9619L,10501L,11383L,11579L,11677L,11971L,12853L,13049L,13147L,13441L,13931L,14029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142426Inst : IEnumerable<long>
{
public static readonly long[] Value=A142426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142426.Bytes);
public long this[int i]=>Value[i];

public static A142426Inst Instance=new A142426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142427
{
public static readonly long[] Value={ 163L,359L,457L,653L,751L,947L,2221L,2417L,2711L,3299L,3593L,3691L,5651L,5749L,6043L,6337L,6827L,7121L,7219L,8101L,8297L,8689L,9277L,9473L,9767L,10061L,10159L,10453L,11923L,12119L,12413L,12511L,13001L,13099L,13687L,13883L,14177L,15451L,15647L,16333L,16529L,16823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142427Inst : IEnumerable<long>
{
public static readonly long[] Value=A142427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142427.Bytes);
public long this[int i]=>Value[i];

public static A142427Inst Instance=new A142427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142428
{
public static readonly long[] Value={ 17L,311L,409L,997L,1193L,1291L,1487L,1879L,2467L,2663L,2957L,3251L,3643L,4133L,4231L,4721L,5113L,5309L,5407L,5701L,5897L,6779L,7759L,8053L,8543L,8641L,8837L,9719L,9817L,10111L,10601L,10993L,11287L,11483L,11777L,12071L,12659L,12757L,12953L,13933L,14423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142428Inst : IEnumerable<long>
{
public static readonly long[] Value=A142428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142428.Bytes);
public long this[int i]=>Value[i];

public static A142428Inst Instance=new A142428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142429
{
public static readonly long[] Value={ 67L,263L,557L,1439L,1733L,1831L,2027L,2713L,2909L,3203L,3301L,3889L,4673L,4967L,5261L,5653L,5849L,6143L,6829L,7417L,7907L,8887L,9181L,9377L,9769L,10259L,10357L,10651L,10847L,11239L,11827L,12611L,13003L,13297L,13591L,14081L,14669L,14767L,15061L,15551L,15649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142429Inst : IEnumerable<long>
{
public static readonly long[] Value=A142429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142429.Bytes);
public long this[int i]=>Value[i];

public static A142429Inst Instance=new A142429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142430
{
public static readonly long[] Value={ 19L,313L,509L,607L,1097L,1489L,1783L,1979L,2273L,2371L,2861L,3253L,3449L,3547L,4723L,4919L,5507L,5801L,6389L,6781L,6977L,7369L,8447L,8741L,8839L,9133L,9623L,9721L,10211L,10799L,11093L,11681L,11779L,12073L,12269L,13151L,13249L,14033L,14327L,14621L,15013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142430Inst : IEnumerable<long>
{
public static readonly long[] Value=A142430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142430.Bytes);
public long this[int i]=>Value[i];

public static A142430Inst Instance=new A142430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142431
{
public static readonly long[] Value={ 167L,461L,853L,1049L,1637L,1931L,2029L,2617L,3499L,3793L,3989L,4283L,4871L,4969L,5557L,5851L,6047L,6733L,7027L,7321L,7517L,8693L,9281L,9967L,10163L,10457L,11437L,11633L,11731L,11927L,12613L,12809L,12907L,13103L,13397L,13691L,13789L,14083L,14867L,15161L,15259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142431Inst : IEnumerable<long>
{
public static readonly long[] Value=A142431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142431.Bytes);
public long this[int i]=>Value[i];

public static A142431Inst Instance=new A142431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142432
{
public static readonly long[] Value={ 71L,463L,659L,757L,953L,1051L,1933L,2129L,2423L,2521L,3011L,3109L,3697L,4481L,5167L,5657L,6343L,6637L,6833L,7127L,8009L,8597L,9283L,9479L,9871L,10067L,10459L,10753L,10949L,11047L,11243L,11831L,12517L,12713L,13007L,13399L,13693L,14281L,14771L,14869L,15359L,16339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142432Inst : IEnumerable<long>
{
public static readonly long[] Value=A142432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142432.Bytes);
public long this[int i]=>Value[i];

public static A142432Inst Instance=new A142432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142433
{
public static readonly long[] Value={ 23L,317L,709L,1297L,1493L,1787L,2081L,2179L,2473L,2767L,2963L,3061L,3257L,3943L,4139L,5021L,5119L,5413L,5903L,6197L,6491L,6883L,7079L,7177L,8059L,8353L,8647L,8941L,9137L,9431L,10313L,10607L,11489L,11587L,11783L,12763L,12959L,13841L,14723L,14821L,15017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142433Inst : IEnumerable<long>
{
public static readonly long[] Value=A142433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142433.Bytes);
public long this[int i]=>Value[i];

public static A142433Inst Instance=new A142433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142434
{
public static readonly long[] Value={ 73L,269L,367L,563L,661L,857L,1151L,1249L,1543L,2131L,2621L,2719L,3209L,3307L,3797L,4091L,4483L,4679L,4973L,5659L,5953L,6247L,6737L,7129L,7717L,8011L,8501L,8599L,8893L,9187L,9677L,10069L,10559L,10657L,10853L,11833L,12323L,12421L,12911L,13009L,13499L,13597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142434Inst : IEnumerable<long>
{
public static readonly long[] Value=A142434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142434.Bytes);
public long this[int i]=>Value[i];

public static A142434Inst Instance=new A142434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142435
{
public static readonly long[] Value={ 613L,809L,907L,1103L,1201L,1789L,2083L,2377L,2671L,3259L,3847L,4337L,4729L,5023L,5807L,6101L,6199L,6689L,6983L,7669L,7963L,8747L,9041L,9433L,9629L,9923L,10903L,11197L,11393L,11491L,11981L,12373L,12569L,13451L,14431L,14627L,15313L,15607L,15803L,15901L,16097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142435Inst : IEnumerable<long>
{
public static readonly long[] Value=A142435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142435.Bytes);
public long this[int i]=>Value[i];

public static A142435Inst Instance=new A142435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142436
{
public static readonly long[] Value={ 173L,271L,467L,761L,859L,1153L,1447L,1741L,2819L,2917L,3407L,3701L,4093L,4289L,4583L,4877L,5171L,5563L,5857L,6053L,6151L,7229L,7523L,7621L,7817L,8111L,8209L,8699L,9091L,9679L,9973L,10169L,10267L,10463L,11149L,11443L,11933L,12227L,12619L,13109L,13697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142436Inst : IEnumerable<long>
{
public static readonly long[] Value=A142436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142436.Bytes);
public long this[int i]=>Value[i];

public static A142436Inst Instance=new A142436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142437
{
public static readonly long[] Value={ 223L,419L,811L,1301L,1399L,1693L,1889L,1987L,2281L,2477L,3163L,3359L,3457L,3947L,4241L,4339L,5417L,5711L,6299L,6397L,6691L,7573L,7867L,8161L,9043L,9239L,9337L,9533L,9631L,10513L,10709L,11003L,11689L,12277L,12473L,13159L,13649L,14629L,14923L,15217L,15413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142437Inst : IEnumerable<long>
{
public static readonly long[] Value=A142437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142437.Bytes);
public long this[int i]=>Value[i];

public static A142437Inst Instance=new A142437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142438
{
public static readonly long[] Value={ 29L,127L,421L,617L,911L,1009L,1303L,1499L,1597L,2087L,2381L,2969L,3067L,3361L,3557L,3851L,4243L,4733L,4831L,5419L,6007L,6203L,6301L,6791L,7477L,7673L,8849L,9241L,9437L,9829L,10613L,10711L,11299L,11593L,11789L,11887L,12377L,12671L,13063L,13259L,13553L,14533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142438Inst : IEnumerable<long>
{
public static readonly long[] Value=A142438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142438.Bytes);
public long this[int i]=>Value[i];

public static A142438Inst Instance=new A142438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142439
{
public static readonly long[] Value={ 79L,373L,569L,863L,1451L,1549L,2039L,2137L,2333L,3019L,3313L,3607L,3803L,4391L,4783L,5077L,5273L,5861L,6449L,6547L,6841L,7331L,7723L,7919L,8017L,8311L,9781L,10271L,10369L,10663L,10859L,10957L,11251L,11447L,11839L,12329L,12721L,12917L,13309L,13799L,14387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142439Inst : IEnumerable<long>
{
public static readonly long[] Value=A142439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142439.Bytes);
public long this[int i]=>Value[i];

public static A142439Inst Instance=new A142439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142600
{
public static readonly long[] Value={ 3L,45L,6L,165L,63L,357L,30L,621L,195L,957L,72L,1365L,399L,1845L,132L,2397L,675L,3021L,210L,3717L,1023L,4485L,306L,5325L,1443L,6237L,420L,7221L,1935L,8277L,552L,9405L,2499L,10605L,702L,11877L,3135L,13221L,870L,14637L,3843L,16125L,1056L,17685L,4623L,19317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142600Inst : IEnumerable<long>
{
public static readonly long[] Value=A142600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142600.Bytes);
public long this[int i]=>Value[i];

public static A142600Inst Instance=new A142600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142601
{
public static readonly long[] Value={ 331L,661L,881L,991L,1321L,1871L,2311L,2531L,2861L,2971L,3191L,3301L,3631L,3851L,4621L,4951L,5171L,5281L,5501L,6271L,6491L,7151L,7481L,7591L,8581L,9241L,9461L,9791L,9901L,10781L,10891L,11551L,12101L,12211L,12541L,13421L,13751L,14081L,14411L,14741L,14851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142601Inst : IEnumerable<long>
{
public static readonly long[] Value=A142601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142601.Bytes);
public long this[int i]=>Value[i];

public static A142601Inst Instance=new A142601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142602
{
public static readonly long[] Value={ 2L,167L,277L,607L,827L,937L,1487L,1597L,2477L,2917L,3137L,3467L,3797L,3907L,4127L,4457L,4567L,4787L,5227L,5557L,6217L,6547L,7207L,7537L,7757L,7867L,8087L,8527L,8747L,9187L,10067L,10177L,10837L,11057L,11497L,11717L,11827L,12157L,12377L,12487L,13037L,13147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142602Inst : IEnumerable<long>
{
public static readonly long[] Value=A142602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142602.Bytes);
public long this[int i]=>Value[i];

public static A142602Inst Instance=new A142602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142603
{
public static readonly long[] Value={ 3L,113L,223L,443L,773L,883L,1103L,1213L,1433L,1543L,1873L,2203L,2423L,2753L,3083L,3413L,3853L,4073L,4513L,4733L,5393L,5503L,6053L,6163L,6823L,7043L,7703L,8363L,8693L,8803L,9133L,9463L,10343L,10453L,11003L,11113L,11443L,12323L,12433L,12653L,12763L,12983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142603Inst : IEnumerable<long>
{
public static readonly long[] Value=A142603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142603.Bytes);
public long this[int i]=>Value[i];

public static A142603Inst Instance=new A142603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142604
{
public static readonly long[] Value={ 59L,389L,499L,719L,829L,1049L,1489L,1709L,2039L,2699L,3359L,3469L,4019L,4129L,4349L,4679L,4789L,5009L,5119L,5449L,5669L,5779L,6329L,6659L,7649L,7759L,8089L,8419L,8969L,9629L,9739L,10069L,10289L,10399L,10729L,10949L,11059L,11279L,11719L,11939L,12049L,12269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142604Inst : IEnumerable<long>
{
public static readonly long[] Value=A142604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142604.Bytes);
public long this[int i]=>Value[i];

public static A142604Inst Instance=new A142604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142605
{
public static readonly long[] Value={ 61L,281L,941L,1051L,1381L,1601L,1931L,2371L,2591L,3251L,3361L,3581L,3691L,3911L,4021L,4241L,5011L,5231L,6221L,6551L,6661L,6991L,7211L,7321L,7541L,8311L,8641L,8861L,8971L,9521L,9631L,9851L,10181L,11171L,11831L,11941L,12161L,12491L,12601L,12821L,13151L,13591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142605Inst : IEnumerable<long>
{
public static readonly long[] Value=A142605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142605.Bytes);
public long this[int i]=>Value[i];

public static A142605Inst Instance=new A142605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142606
{
public static readonly long[] Value={ 7L,227L,337L,557L,887L,997L,1217L,1327L,1657L,1877L,1987L,2207L,2647L,3307L,3527L,3637L,3967L,4297L,4517L,4957L,5507L,6277L,6607L,6827L,7487L,7817L,7927L,8147L,8807L,9137L,9467L,9907L,10457L,10567L,11117L,11447L,11777L,11887L,12107L,12437L,12547L,13537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142606Inst : IEnumerable<long>
{
public static readonly long[] Value=A142606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142606.Bytes);
public long this[int i]=>Value[i];

public static A142606Inst Instance=new A142606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142607
{
public static readonly long[] Value={ 173L,283L,503L,613L,1163L,1493L,1823L,1933L,2153L,2593L,3253L,3583L,3803L,4133L,4243L,4463L,4793L,4903L,5233L,5563L,5783L,6113L,6553L,6883L,7103L,7213L,7433L,7873L,8093L,8423L,8753L,8863L,9413L,9743L,10513L,10733L,11173L,11393L,11503L,11833L,12163L,12713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142607Inst : IEnumerable<long>
{
public static readonly long[] Value=A142607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142607.Bytes);
public long this[int i]=>Value[i];

public static A142607Inst Instance=new A142607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142608
{
public static readonly long[] Value={ 229L,449L,1109L,1439L,1549L,1879L,2099L,2539L,3089L,3529L,4079L,4409L,4519L,5179L,5399L,5839L,6389L,6719L,6829L,7159L,7489L,8039L,8369L,8699L,9029L,9689L,10459L,10789L,11119L,11779L,12109L,12329L,12659L,13099L,13649L,13759L,14419L,14639L,14969L,15299L,15629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142608Inst : IEnumerable<long>
{
public static readonly long[] Value=A142608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142608.Bytes);
public long this[int i]=>Value[i];

public static A142608Inst Instance=new A142608Inst();

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