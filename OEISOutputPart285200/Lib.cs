using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

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

public static class A142136
{
public static readonly long[] Value={ 101L,397L,619L,1063L,1433L,1877L,1951L,2099L,2543L,2617L,3061L,3209L,3727L,5059L,5281L,5503L,5651L,6317L,6761L,6983L,7057L,7649L,7723L,8093L,8167L,8389L,8537L,9203L,9277L,9721L,10091L,10313L,10831L,10979L,11423L,11497L,11719L,11867L,11941L,12163L,12829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142136Inst : IEnumerable<long>
{
public static readonly long[] Value=A142136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142136.Bytes);
public long this[int i]=>Value[i];

public static A142136Inst Instance=new A142136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142137
{
public static readonly long[] Value={ 139L,509L,953L,1249L,1471L,1619L,1693L,2063L,2137L,2729L,2803L,3469L,3617L,3691L,4283L,4357L,4801L,5023L,5171L,5393L,5689L,6133L,6577L,6947L,7243L,7687L,8353L,8501L,9241L,9463L,9833L,9907L,10499L,11239L,11831L,12497L,12941L,13163L,13681L,13829L,13903L,14051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142137Inst : IEnumerable<long>
{
public static readonly long[] Value=A142137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142137.Bytes);
public long this[int i]=>Value[i];

public static A142137Inst Instance=new A142137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142138
{
public static readonly long[] Value={ 29L,103L,251L,547L,769L,991L,1213L,1361L,1583L,1657L,1879L,2027L,2693L,2767L,3137L,3359L,3433L,3581L,3803L,3877L,4099L,4691L,4987L,5209L,5431L,5653L,5801L,6689L,6763L,6911L,7207L,7577L,7873L,8243L,8317L,8539L,8761L,9649L,9871L,10093L,10463L,11351L,12239L,12757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142138Inst : IEnumerable<long>
{
public static readonly long[] Value=A142138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142138.Bytes);
public long this[int i]=>Value[i];

public static A142138Inst Instance=new A142138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142139
{
public static readonly long[] Value={ 67L,659L,733L,881L,1103L,1399L,1621L,2213L,2287L,2657L,2731L,2879L,2953L,3323L,3767L,3989L,4211L,4507L,4729L,4877L,4951L,5099L,5839L,5987L,6653L,6949L,7393L,7541L,8059L,8429L,9391L,9539L,9613L,10427L,10501L,10723L,11093L,11833L,11981L,12203L,12277L,12647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142139Inst : IEnumerable<long>
{
public static readonly long[] Value=A142139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142139.Bytes);
public long this[int i]=>Value[i];

public static A142139Inst Instance=new A142139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142140
{
public static readonly long[] Value={ 31L,179L,401L,919L,1289L,1511L,1733L,2029L,2251L,2399L,2473L,2621L,2843L,2917L,3361L,3583L,4027L,4397L,5507L,5581L,6173L,6247L,6469L,6691L,7283L,7727L,7949L,8171L,8467L,8689L,8837L,9059L,9133L,9281L,10169L,10243L,10391L,10613L,10687L,10909L,11057L,11131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142140Inst : IEnumerable<long>
{
public static readonly long[] Value=A142140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142140.Bytes);
public long this[int i]=>Value[i];

public static A142140Inst Instance=new A142140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142141
{
public static readonly long[] Value={ 439L,587L,661L,809L,883L,1031L,1327L,1549L,1697L,1993L,2141L,2437L,2659L,3251L,3547L,3769L,3917L,4139L,4583L,4657L,5101L,5323L,5471L,5693L,6211L,6359L,6581L,6803L,7247L,7321L,7691L,8209L,8431L,9319L,9467L,9689L,10133L,10429L,10651L,10799L,11243L,11317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142141Inst : IEnumerable<long>
{
public static readonly long[] Value=A142141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142141.Bytes);
public long this[int i]=>Value[i];

public static A142141Inst Instance=new A142141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142142
{
public static readonly long[] Value={ 107L,181L,773L,1069L,1217L,1291L,1439L,2179L,2549L,3067L,3511L,3659L,3733L,3881L,4177L,4547L,4621L,5657L,5879L,5953L,6101L,6323L,6397L,6619L,6841L,7211L,7433L,7507L,7877L,7951L,8543L,8839L,9209L,9283L,9431L,9949L,10837L,11059L,11503L,12391L,12539L,12613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142142Inst : IEnumerable<long>
{
public static readonly long[] Value=A142142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142142.Bytes);
public long this[int i]=>Value[i];

public static A142142Inst Instance=new A142142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142143
{
public static readonly long[] Value={ 71L,293L,367L,811L,1033L,1181L,1699L,1847L,2069L,2143L,2957L,3253L,3623L,3697L,3919L,4289L,4363L,4733L,5399L,5843L,6287L,6361L,7027L,7841L,8581L,8803L,8951L,9173L,9839L,10061L,10357L,10949L,11171L,11393L,11467L,11689L,12281L,12503L,12577L,12799L,13613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142143Inst : IEnumerable<long>
{
public static readonly long[] Value=A142143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142143.Bytes);
public long this[int i]=>Value[i];

public static A142143Inst Instance=new A142143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142144
{
public static readonly long[] Value={ 109L,257L,331L,479L,701L,997L,1367L,1663L,1811L,2477L,2551L,2699L,3217L,4253L,4327L,4549L,4919L,4993L,5437L,5659L,5807L,5881L,6029L,6473L,6547L,6917L,6991L,7213L,7583L,7879L,8101L,8693L,9137L,9433L,9803L,10099L,10247L,10321L,10691L,10987L,11579L,11801L,12097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142144Inst : IEnumerable<long>
{
public static readonly long[] Value=A142144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142144.Bytes);
public long this[int i]=>Value[i];

public static A142144Inst Instance=new A142144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142145
{
public static readonly long[] Value={ 73L,443L,739L,887L,1109L,1553L,1627L,1997L,2293L,2441L,2663L,3181L,3329L,3847L,4217L,4513L,4957L,5179L,5623L,6067L,6659L,6733L,7103L,7177L,7547L,7621L,8287L,8731L,9323L,9397L,9619L,9767L,10211L,10433L,10729L,11173L,11321L,11617L,11839L,11987L,12653L,13171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142145Inst : IEnumerable<long>
{
public static readonly long[] Value=A142145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142145.Bytes);
public long this[int i]=>Value[i];

public static A142145Inst Instance=new A142145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142146
{
public static readonly long[] Value={ 1L,2L,4L,1L,6L,24L,22L,8L,1L,24L,144L,260L,176L,62L,12L,1L,120L,960L,2640L,3120L,1846L,616L,126L,16L,1L,720L,7200L,26760L,47040L,43352L,23376L,7772L,1632L,222L,20L,1L,5040L,60480L,283920L,672000L,882336L,692160L,347152L,115680L,25806L,3800L,366L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142146Inst : IEnumerable<long>
{
public static readonly long[] Value=A142146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142146.Bytes);
public long this[int i]=>Value[i];

public static A142146Inst Instance=new A142146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142147
{
public static readonly long[] Value={ 1L,1L,-1L,1L,1L,-4L,2L,1L,7L,-12L,-4L,12L,-4L,1L,21L,0L,-102L,100L,4L,-32L,8L,1L,51L,160L,-532L,-24L,904L,-672L,48L,80L,-16L,1L,113L,980L,-1094L,-5128L,8760L,-736L,-6224L,3920L,-432L,-192L,32L,1L,239L,4284L,5276L,-43964L,19764L,90272L,-114080L,19824L,36304L,-20800L,2496L,448L,-64L,1L,493L,16184L,73930L,-198388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142147Inst : IEnumerable<long>
{
public static readonly long[] Value=A142147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142147.Bytes);
public long this[int i]=>Value[i];

public static A142147Inst Instance=new A142147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142148
{
public static readonly long[] Value={ 1L,-1L,1L,2L,-5L,2L,-6L,41L,-31L,6L,24L,-602L,633L,-217L,24L,-120L,14554L,-18551L,8534L,-1681L,120L,720L,-519444L,752260L,-417755L,111620L,-14401L,720L,-5040L,25409628L,-40466224L,25725825L,-8391895L,1486827L,-136081L,5040L,40320L,-1625771664L,2792773340L,-1970053624L,742859705L,-162288511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142148Inst : IEnumerable<long>
{
public static readonly long[] Value=A142148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142148.Bytes);
public long this[int i]=>Value[i];

public static A142148Inst Instance=new A142148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142149
{
public static readonly long[] Value={ 0L,1L,3L,3L,6L,5L,5L,7L,12L,9L,15L,11L,10L,13L,9L,15L,24L,17L,27L,19L,30L,21L,29L,23L,20L,25L,23L,27L,18L,29L,17L,31L,48L,33L,51L,35L,54L,37L,53L,39L,60L,41L,63L,43L,58L,45L,57L,47L,40L,49L,43L,51L,46L,53L,45L,55L,36L,57L,39L,59L,34L,61L,33L,63L,96L,65L,99L,67L,102L,69L,101L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142149Inst : IEnumerable<long>
{
public static readonly long[] Value=A142149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142149.Bytes);
public long this[int i]=>Value[i];

public static A142149Inst Instance=new A142149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142150
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,3L,0L,4L,0L,5L,0L,6L,0L,7L,0L,8L,0L,9L,0L,10L,0L,11L,0L,12L,0L,13L,0L,14L,0L,15L,0L,16L,0L,17L,0L,18L,0L,19L,0L,20L,0L,21L,0L,22L,0L,23L,0L,24L,0L,25L,0L,26L,0L,27L,0L,28L,0L,29L,0L,30L,0L,31L,0L,32L,0L,33L,0L,34L,0L,35L,0L,36L,0L,37L,0L,38L,0L,39L,0L,40L,0L,41L,0L,42L,0L,43L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142150Inst : IEnumerable<long>
{
public static readonly long[] Value=A142150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142150.Bytes);
public long this[int i]=>Value[i];

public static A142150Inst Instance=new A142150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142151
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,5L,6L,7L,14L,13L,14L,11L,14L,13L,14L,15L,30L,29L,30L,27L,30L,29L,30L,23L,30L,29L,30L,27L,30L,29L,30L,31L,62L,61L,62L,59L,62L,61L,62L,55L,62L,61L,62L,59L,62L,61L,62L,47L,62L,61L,62L,59L,62L,61L,62L,55L,62L,61L,62L,59L,62L,61L,62L,63L,126L,125L,126L,123L,126L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142151Inst : IEnumerable<long>
{
public static readonly long[] Value=A142151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142151.Bytes);
public long this[int i]=>Value[i];

public static A142151Inst Instance=new A142151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142184
{
public static readonly long[] Value={ 3L,43L,83L,163L,283L,443L,523L,563L,643L,683L,883L,1123L,1163L,1283L,1483L,1523L,1723L,2003L,2083L,2203L,2243L,2683L,2803L,2843L,2963L,3083L,3163L,3203L,3323L,3643L,3803L,3923L,4003L,4243L,4283L,4363L,4483L,4523L,4603L,4643L,4723L,5003L,5323L,5443L,5483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142184Inst : IEnumerable<long>
{
public static readonly long[] Value=A142184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142184.Bytes);
public long this[int i]=>Value[i];

public static A142184Inst Instance=new A142184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142185
{
public static readonly long[] Value={ 7L,47L,127L,167L,367L,487L,607L,647L,727L,887L,967L,1087L,1327L,1367L,1447L,1487L,1567L,1607L,1847L,2087L,2207L,2287L,2447L,2647L,2687L,2767L,2887L,2927L,3167L,3407L,3527L,3607L,3727L,3767L,3847L,3967L,4007L,4127L,4327L,4447L,4567L,4967L,5087L,5167L,5407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142185Inst : IEnumerable<long>
{
public static readonly long[] Value=A142185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142185.Bytes);
public long this[int i]=>Value[i];

public static A142185Inst Instance=new A142185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142186
{
public static readonly long[] Value={ 89L,409L,449L,569L,769L,809L,929L,1009L,1049L,1129L,1249L,1289L,1409L,1489L,1609L,1889L,2089L,2129L,2609L,2689L,2729L,2969L,3049L,3089L,3169L,3209L,3329L,3449L,3529L,3769L,3889L,3929L,4049L,4129L,4289L,4409L,4649L,4729L,4889L,4969L,5009L,5209L,5449L,5569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142186Inst : IEnumerable<long>
{
public static readonly long[] Value=A142186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142186.Bytes);
public long this[int i]=>Value[i];

public static A142186Inst Instance=new A142186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142187
{
public static readonly long[] Value={ 11L,131L,211L,251L,331L,491L,571L,691L,811L,971L,1051L,1091L,1171L,1291L,1451L,1531L,1571L,1811L,1931L,2011L,2131L,2251L,2371L,2411L,2531L,2731L,2851L,2971L,3011L,3251L,3331L,3371L,3491L,3571L,3691L,3851L,3931L,4051L,4091L,4211L,4451L,4651L,4691L,4931L,5011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142187Inst : IEnumerable<long>
{
public static readonly long[] Value=A142187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142187.Bytes);
public long this[int i]=>Value[i];

public static A142187Inst Instance=new A142187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142188
{
public static readonly long[] Value={ 13L,53L,173L,293L,373L,613L,653L,733L,773L,853L,1013L,1093L,1213L,1373L,1453L,1493L,1613L,1693L,1733L,1933L,1973L,2053L,2213L,2293L,2333L,2693L,3253L,3373L,3413L,3533L,3613L,3733L,3853L,4013L,4093L,4133L,4253L,4373L,4493L,4733L,4813L,4933L,4973L,5333L,5413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142188Inst : IEnumerable<long>
{
public static readonly long[] Value=A142188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142188.Bytes);
public long this[int i]=>Value[i];

public static A142188Inst Instance=new A142188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142189
{
public static readonly long[] Value={ 17L,97L,137L,257L,337L,457L,577L,617L,857L,937L,977L,1097L,1217L,1297L,1657L,1697L,1777L,2017L,2137L,2297L,2377L,2417L,2617L,2657L,2777L,2857L,2897L,3137L,3217L,3257L,3457L,3617L,3697L,4057L,4177L,4217L,4297L,4337L,4457L,4657L,4817L,4937L,5297L,5417L,5657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142189Inst : IEnumerable<long>
{
public static readonly long[] Value=A142189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142189.Bytes);
public long this[int i]=>Value[i];

public static A142189Inst Instance=new A142189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142190
{
public static readonly long[] Value={ 19L,59L,139L,179L,379L,419L,499L,619L,659L,739L,859L,1019L,1259L,1459L,1499L,1579L,1619L,1699L,1979L,2099L,2179L,2339L,2459L,2539L,2579L,2659L,2699L,2819L,2939L,3019L,3259L,3299L,3499L,3539L,3659L,3739L,3779L,4019L,4099L,4139L,4219L,4259L,4339L,5059L,5099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142190Inst : IEnumerable<long>
{
public static readonly long[] Value=A142190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142190.Bytes);
public long this[int i]=>Value[i];

public static A142190Inst Instance=new A142190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142191
{
public static readonly long[] Value={ 61L,101L,181L,421L,461L,541L,661L,701L,821L,941L,1021L,1061L,1181L,1301L,1381L,1621L,1741L,1861L,1901L,2141L,2221L,2341L,2381L,2621L,2741L,2861L,3061L,3181L,3221L,3301L,3461L,3541L,3581L,3701L,3821L,4021L,4261L,4421L,4621L,4861L,5021L,5101L,5261L,5381L,5501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142191Inst : IEnumerable<long>
{
public static readonly long[] Value=A142191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142191.Bytes);
public long this[int i]=>Value[i];

public static A142191Inst Instance=new A142191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142192
{
public static readonly long[] Value={ 23L,103L,223L,263L,383L,463L,503L,743L,823L,863L,983L,1063L,1103L,1223L,1303L,1423L,1543L,1583L,1663L,1783L,1823L,2063L,2143L,2383L,2423L,2503L,2543L,2663L,2903L,3023L,3343L,3463L,3583L,3623L,3823L,3863L,3943L,4423L,4463L,4583L,4663L,4703L,4783L,4903L,4943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142192Inst : IEnumerable<long>
{
public static readonly long[] Value=A142192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142192.Bytes);
public long this[int i]=>Value[i];

public static A142192Inst Instance=new A142192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142193
{
public static readonly long[] Value={ 67L,107L,227L,307L,347L,467L,547L,587L,787L,827L,907L,947L,1187L,1307L,1427L,1627L,1667L,1747L,1787L,1867L,1907L,1987L,2027L,2267L,2347L,2467L,2707L,3067L,3187L,3307L,3347L,3467L,3547L,3907L,3947L,4027L,4507L,4547L,4787L,4987L,5107L,5147L,5227L,5347L,5387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142193Inst : IEnumerable<long>
{
public static readonly long[] Value=A142193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142193.Bytes);
public long this[int i]=>Value[i];

public static A142193Inst Instance=new A142193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142194
{
public static readonly long[] Value={ 29L,109L,149L,229L,269L,349L,389L,509L,709L,829L,1069L,1109L,1229L,1429L,1549L,1669L,1709L,1789L,1949L,2029L,2069L,2269L,2309L,2389L,2549L,2749L,2789L,2909L,3109L,3229L,3389L,3469L,3709L,3989L,4229L,4349L,4549L,4789L,4909L,5189L,5309L,5669L,5749L,5869L,6029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142194Inst : IEnumerable<long>
{
public static readonly long[] Value=A142194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142194.Bytes);
public long this[int i]=>Value[i];

public static A142194Inst Instance=new A142194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142195
{
public static readonly long[] Value={ 31L,71L,151L,191L,271L,311L,431L,631L,751L,911L,991L,1031L,1151L,1231L,1471L,1511L,1831L,1871L,1951L,2111L,2311L,2351L,2551L,2591L,2671L,2711L,2791L,3191L,3271L,3391L,3511L,3631L,3671L,3911L,4111L,4231L,4271L,4391L,4591L,4751L,4831L,4871L,4951L,5231L,5351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142195Inst : IEnumerable<long>
{
public static readonly long[] Value=A142195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142195.Bytes);
public long this[int i]=>Value[i];

public static A142195Inst Instance=new A142195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142196
{
public static readonly long[] Value={ 73L,113L,193L,233L,313L,353L,433L,593L,673L,953L,1033L,1153L,1193L,1433L,1553L,1753L,1873L,1913L,1993L,2113L,2153L,2273L,2393L,2473L,2593L,2633L,2713L,2753L,2833L,2953L,3313L,3433L,3593L,3673L,3793L,3833L,4073L,4153L,4273L,4513L,4673L,4793L,4993L,5113L,5153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142196Inst : IEnumerable<long>
{
public static readonly long[] Value=A142196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142196.Bytes);
public long this[int i]=>Value[i];

public static A142196Inst Instance=new A142196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142197
{
public static readonly long[] Value={ 37L,157L,197L,277L,317L,397L,557L,677L,757L,797L,877L,997L,1117L,1237L,1277L,1597L,1637L,1877L,1997L,2237L,2357L,2437L,2477L,2557L,2677L,2797L,2837L,2917L,2957L,3037L,3517L,3557L,3637L,3677L,3797L,3877L,3917L,4157L,4357L,4397L,4517L,4597L,4637L,4877L,4957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142197Inst : IEnumerable<long>
{
public static readonly long[] Value=A142197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142197.Bytes);
public long this[int i]=>Value[i];

public static A142197Inst Instance=new A142197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142198
{
public static readonly long[] Value={ 79L,199L,239L,359L,439L,479L,599L,719L,839L,919L,1039L,1279L,1319L,1399L,1439L,1559L,1759L,1879L,1999L,2039L,2239L,2399L,2719L,2879L,2999L,3079L,3119L,3319L,3359L,3559L,3719L,3919L,4079L,4159L,4519L,4639L,4679L,4759L,4799L,4919L,4999L,5039L,5119L,5279L,5399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142198Inst : IEnumerable<long>
{
public static readonly long[] Value=A142198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142198.Bytes);
public long this[int i]=>Value[i];

public static A142198Inst Instance=new A142198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142199
{
public static readonly long[] Value={ 2L,43L,617L,863L,1109L,1601L,1847L,2011L,2339L,2503L,2749L,3323L,3733L,4799L,5209L,5701L,5783L,6029L,6521L,7013L,7177L,7669L,8161L,8243L,9227L,9391L,9473L,9719L,9883L,10211L,10457L,10867L,10949L,11113L,11933L,12097L,12343L,12589L,12671L,12917L,13163L,13327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142199Inst : IEnumerable<long>
{
public static readonly long[] Value=A142199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142199.Bytes);
public long this[int i]=>Value[i];

public static A142199Inst Instance=new A142199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142264
{
public static readonly long[] Value={ 101L,359L,617L,1907L,1993L,2251L,2423L,2767L,2939L,3541L,4057L,4229L,4831L,5003L,5261L,5347L,5519L,6121L,6379L,6551L,6637L,7411L,7583L,7669L,7841L,7927L,8443L,9733L,10163L,10937L,11969L,12227L,12743L,12829L,13001L,13259L,14033L,14549L,15581L,15667L,16097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142264Inst : IEnumerable<long>
{
public static readonly long[] Value=A142264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142264.Bytes);
public long this[int i]=>Value[i];

public static A142264Inst Instance=new A142264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142265
{
public static readonly long[] Value={ 59L,317L,661L,919L,1091L,1607L,1693L,1951L,2381L,2467L,2897L,3413L,3499L,3671L,3929L,4273L,4703L,4789L,5477L,5563L,5821L,6079L,6337L,7283L,7369L,7541L,8573L,8831L,9433L,9949L,10723L,11239L,11411L,11497L,11927L,12959L,13217L,14249L,14593L,14851L,15797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142265Inst : IEnumerable<long>
{
public static readonly long[] Value=A142265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142265.Bytes);
public long this[int i]=>Value[i];

public static A142265Inst Instance=new A142265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142266
{
public static readonly long[] Value={ 17L,103L,619L,877L,1049L,1307L,1823L,2081L,2339L,2683L,3371L,3457L,4231L,4919L,5521L,5693L,5779L,6037L,6553L,6983L,7069L,7499L,7757L,8101L,8273L,9133L,9391L,9649L,9907L,10079L,10337L,10853L,10939L,11197L,11369L,11971L,12143L,12401L,12487L,12659L,12917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142266Inst : IEnumerable<long>
{
public static readonly long[] Value=A142266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142266.Bytes);
public long this[int i]=>Value[i];

public static A142266Inst Instance=new A142266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142267
{
public static readonly long[] Value={ 61L,233L,491L,577L,1093L,1523L,1609L,1867L,2039L,2297L,2383L,3329L,3673L,3931L,4447L,4877L,5393L,5479L,5651L,5737L,7027L,7457L,8059L,8231L,8317L,8747L,9091L,9349L,9521L,10037L,10639L,11069L,12101L,12703L,13219L,13477L,13649L,13907L,14251L,14423L,14767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142267Inst : IEnumerable<long>
{
public static readonly long[] Value=A142267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142267.Bytes);
public long this[int i]=>Value[i];

public static A142267Inst Instance=new A142267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142268
{
public static readonly long[] Value={ 19L,191L,277L,449L,1051L,1223L,1481L,1567L,1997L,2083L,2341L,2857L,3373L,3631L,3803L,3889L,4663L,5179L,5351L,5437L,5867L,5953L,6211L,6469L,6899L,7243L,7673L,7759L,8017L,8447L,8963L,9049L,9221L,9479L,10253L,10597L,11027L,11113L,11801L,11887L,12919L,13177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142268Inst : IEnumerable<long>
{
public static readonly long[] Value=A142268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142268.Bytes);
public long this[int i]=>Value[i];

public static A142268Inst Instance=new A142268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142269
{
public static readonly long[] Value={ 149L,751L,1009L,1181L,1439L,1697L,1783L,2213L,2557L,2729L,3331L,3761L,3847L,4019L,4363L,4621L,4793L,5051L,5309L,5653L,6427L,6599L,6857L,7459L,7717L,8147L,8233L,8663L,9007L,9437L,9781L,10039L,10211L,11071L,11243L,11329L,11587L,12619L,12791L,13049L,14081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142269Inst : IEnumerable<long>
{
public static readonly long[] Value=A142269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142269.Bytes);
public long this[int i]=>Value[i];

public static A142269Inst Instance=new A142269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142270
{
public static readonly long[] Value={ 107L,193L,709L,881L,967L,1483L,1741L,1913L,1999L,2687L,3203L,3461L,3547L,3719L,4493L,4751L,5009L,5783L,5869L,6299L,7159L,7331L,7417L,7589L,7933L,8191L,8363L,8707L,9137L,9739L,10169L,10427L,10513L,10771L,11287L,11717L,12491L,12577L,13007L,13093L,13523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142270Inst : IEnumerable<long>
{
public static readonly long[] Value=A142270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142270.Bytes);
public long this[int i]=>Value[i];

public static A142270Inst Instance=new A142270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142271
{
public static readonly long[] Value={ 151L,409L,839L,1097L,1613L,1699L,1871L,2129L,2473L,2731L,2903L,3677L,4021L,4451L,4967L,5483L,5569L,5741L,5827L,6257L,6343L,7547L,8837L,8923L,9181L,9439L,9697L,10729L,10987L,11159L,11503L,11933L,12277L,13309L,13567L,13997L,14083L,14341L,14771L,15287L,15373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142271Inst : IEnumerable<long>
{
public static readonly long[] Value=A142271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142271.Bytes);
public long this[int i]=>Value[i];

public static A142271Inst Instance=new A142271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142272
{
public static readonly long[] Value={ 23L,109L,281L,367L,797L,883L,1399L,1571L,1657L,2087L,2689L,2861L,3119L,3463L,4409L,5011L,5441L,5527L,6043L,6301L,6473L,7247L,7333L,7591L,8537L,8623L,9311L,9397L,10343L,10429L,10601L,10687L,10859L,11117L,11633L,11719L,12149L,12923L,13009L,13267L,13697L,14557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142272Inst : IEnumerable<long>
{
public static readonly long[] Value=A142272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142272.Bytes);
public long this[int i]=>Value[i];

public static A142272Inst Instance=new A142272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142273
{
public static readonly long[] Value={ 67L,239L,1013L,1787L,1873L,2131L,2389L,2647L,2819L,3163L,3593L,3851L,4969L,5227L,5399L,5657L,5743L,6173L,6689L,6947L,7549L,8237L,8581L,8753L,8839L,9011L,9613L,9871L,10301L,10559L,10903L,11161L,11677L,12107L,12451L,12967L,13397L,13913L,13999L,15031L,15289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142273Inst : IEnumerable<long>
{
public static readonly long[] Value=A142273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142273.Bytes);
public long this[int i]=>Value[i];

public static A142273Inst Instance=new A142273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142274
{
public static readonly long[] Value={ 197L,283L,541L,971L,1229L,1487L,1831L,2003L,2089L,2347L,2777L,3121L,3637L,4153L,4583L,5099L,5443L,5701L,6131L,6217L,6389L,6733L,6991L,7507L,7937L,8539L,8969L,9227L,9743L,9829L,10259L,10861L,11119L,11549L,11807L,12323L,12409L,13183L,13441L,13613L,14387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142274Inst : IEnumerable<long>
{
public static readonly long[] Value=A142274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142274.Bytes);
public long this[int i]=>Value[i];

public static A142274Inst Instance=new A142274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142275
{
public static readonly long[] Value={ 241L,499L,757L,929L,1187L,1531L,1789L,2477L,3079L,3251L,3767L,3853L,4111L,4283L,4799L,5573L,5659L,6089L,6691L,6863L,6949L,7121L,7207L,7723L,8669L,9013L,9787L,10303L,10733L,11593L,12109L,12281L,12539L,13313L,13399L,13829L,14087L,14173L,14431L,14947L,15377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142275Inst : IEnumerable<long>
{
public static readonly long[] Value=A142275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142275.Bytes);
public long this[int i]=>Value[i];

public static A142275Inst Instance=new A142275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142276
{
public static readonly long[] Value={ 113L,199L,457L,887L,1231L,1489L,1747L,2521L,2693L,3037L,3209L,3467L,4241L,4327L,5101L,5273L,5531L,6047L,6133L,6563L,6907L,7079L,7681L,7853L,8111L,8369L,8627L,8713L,8971L,10433L,10691L,10949L,11551L,11981L,12239L,12497L,12583L,12841L,13099L,13873L,14303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142276Inst : IEnumerable<long>
{
public static readonly long[] Value=A142276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142276.Bytes);
public long this[int i]=>Value[i];

public static A142276Inst Instance=new A142276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142277
{
public static readonly long[] Value={ 71L,157L,587L,673L,1103L,1361L,1447L,1619L,1877L,2221L,2393L,2909L,3167L,3253L,3511L,3769L,4027L,4457L,4801L,4973L,5059L,5231L,6091L,6263L,6521L,6607L,6779L,7639L,8069L,8929L,9187L,10133L,10391L,10477L,10993L,11251L,11423L,11681L,11939L,12197L,12541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142277Inst : IEnumerable<long>
{
public static readonly long[] Value=A142277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142277.Bytes);
public long this[int i]=>Value[i];

public static A142277Inst Instance=new A142277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142278
{
public static readonly long[] Value={ 29L,373L,631L,1061L,1319L,1663L,2179L,2351L,2437L,2609L,2953L,3469L,3727L,4157L,4243L,4673L,4759L,4931L,5189L,5791L,6221L,6737L,6823L,7253L,8543L,8629L,8887L,9059L,9403L,9661L,9833L,10091L,10177L,10607L,11467L,11897L,12241L,12413L,12671L,12757L,13187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142278Inst : IEnumerable<long>
{
public static readonly long[] Value=A142278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142278.Bytes);
public long this[int i]=>Value[i];

public static A142278Inst Instance=new A142278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142279
{
public static readonly long[] Value={ 73L,331L,503L,761L,1019L,1277L,1621L,1879L,2137L,2309L,3083L,3169L,3943L,4201L,4373L,4889L,5147L,5233L,5749L,6007L,6781L,7039L,7211L,7297L,7727L,8243L,8329L,8501L,9103L,9533L,9619L,9791L,10651L,10909L,11597L,11941L,12113L,12457L,12973L,14177L,14779L,14951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142279Inst : IEnumerable<long>
{
public static readonly long[] Value=A142279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142279.Bytes);
public long this[int i]=>Value[i];

public static A142279Inst Instance=new A142279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142328
{
public static readonly long[] Value={ 31L,211L,571L,661L,751L,1021L,1201L,1291L,1381L,1471L,1741L,1831L,2011L,2281L,2371L,2551L,2731L,3001L,3181L,3271L,3361L,3541L,3631L,4261L,4441L,4621L,4801L,5431L,5521L,5701L,5791L,5881L,6151L,6421L,6691L,6781L,6871L,6961L,7321L,7411L,7591L,7681L,7951L,8221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142328Inst : IEnumerable<long>
{
public static readonly long[] Value=A142328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142328.Bytes);
public long this[int i]=>Value[i];

public static A142328Inst Instance=new A142328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142329
{
public static readonly long[] Value={ 167L,257L,347L,617L,797L,887L,977L,1427L,1607L,1697L,1787L,1877L,2237L,2417L,2687L,2777L,2957L,3137L,3407L,3677L,3767L,3947L,4127L,4217L,4397L,4937L,5297L,5387L,5477L,5657L,5927L,6197L,6287L,6737L,6827L,6917L,7187L,7457L,7547L,7727L,7817L,7907L,8087L,8447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142329Inst : IEnumerable<long>
{
public static readonly long[] Value=A142329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142329.Bytes);
public long this[int i]=>Value[i];

public static A142329Inst Instance=new A142329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142330
{
public static readonly long[] Value={ 79L,349L,439L,619L,709L,1069L,1249L,1429L,1609L,1699L,1789L,1879L,2239L,2689L,3049L,3229L,3319L,3499L,3769L,4129L,4219L,4759L,5119L,5209L,5479L,5569L,5659L,5749L,5839L,6199L,6379L,6469L,6829L,7369L,7459L,7549L,7639L,8089L,8179L,8269L,8539L,8629L,8719L,9349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142330Inst : IEnumerable<long>
{
public static readonly long[] Value=A142330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142330.Bytes);
public long this[int i]=>Value[i];

public static A142330Inst Instance=new A142330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142331
{
public static readonly long[] Value={ 37L,127L,307L,397L,487L,577L,757L,937L,1117L,1297L,1567L,1657L,1747L,2017L,2287L,2377L,2467L,2557L,2647L,2917L,3187L,3457L,3547L,3637L,3727L,3907L,4177L,4357L,4447L,4987L,5077L,5167L,5347L,5437L,5527L,6067L,6247L,6337L,6427L,6607L,6967L,7057L,7237L,7417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142331Inst : IEnumerable<long>
{
public static readonly long[] Value=A142331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142331.Bytes);
public long this[int i]=>Value[i];

public static A142331Inst Instance=new A142331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142332
{
public static readonly long[] Value={ 83L,173L,263L,353L,443L,983L,1163L,1433L,1523L,1613L,1973L,2063L,2153L,2243L,2333L,2423L,2693L,2963L,3323L,3413L,3593L,3863L,4133L,4493L,4583L,4673L,4943L,5303L,5393L,5483L,5573L,5843L,6113L,6203L,6473L,6563L,6653L,6833L,7013L,7103L,7193L,7283L,7643L,7823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142332Inst : IEnumerable<long>
{
public static readonly long[] Value=A142332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142332.Bytes);
public long this[int i]=>Value[i];

public static A142332Inst Instance=new A142332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142333
{
public static readonly long[] Value={ 41L,131L,311L,401L,491L,761L,941L,1031L,1301L,1481L,1571L,1931L,2111L,2381L,2741L,3011L,3191L,3371L,3461L,3821L,3911L,4001L,4091L,4271L,4451L,4721L,5081L,5171L,5261L,5351L,5441L,5531L,5711L,5801L,5981L,6521L,6701L,6791L,6971L,7151L,7331L,7691L,8231L,8501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142333Inst : IEnumerable<long>
{
public static readonly long[] Value=A142333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142333.Bytes);
public long this[int i]=>Value[i];

public static A142333Inst Instance=new A142333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142334
{
public static readonly long[] Value={ 43L,223L,313L,673L,853L,1033L,1123L,1213L,1303L,1483L,1663L,1753L,1933L,2113L,2203L,2293L,2383L,2473L,2833L,3373L,3463L,3643L,3733L,3823L,4003L,4093L,4273L,4363L,4723L,4813L,4903L,4993L,5443L,5623L,6073L,6163L,6343L,6703L,6793L,6883L,7243L,7333L,7603L,7873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142334Inst : IEnumerable<long>
{
public static readonly long[] Value=A142334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142334.Bytes);
public long this[int i]=>Value[i];

public static A142334Inst Instance=new A142334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142335
{
public static readonly long[] Value={ 89L,179L,269L,359L,449L,719L,809L,1259L,1439L,1619L,1709L,1889L,1979L,2069L,2339L,2609L,2699L,2789L,2879L,2969L,3329L,3779L,4049L,4139L,4229L,4409L,4679L,5039L,5309L,5399L,5669L,5849L,5939L,6029L,6299L,6389L,6569L,6659L,7019L,7109L,7559L,7649L,7829L,7919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142335Inst : IEnumerable<long>
{
public static readonly long[] Value=A142335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142335.Bytes);
public long this[int i]=>Value[i];

public static A142335Inst Instance=new A142335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142336
{
public static readonly long[] Value={ -1L,1L,-2L,-1L,8L,-6L,1L,-24L,57L,-24L,-1L,64L,-361L,424L,-120L,1L,-160L,1890L,-4720L,3415L,-720L,-1L,384L,-8828L,41642L,-59543L,30036L,-5040L,1L,-896L,38199L,-317072L,803383L,-757120L,288449L,-40320L,-1L,2048L,-156483L,2177996L,-9156523L,14586084L,-9908113L,3015440L,-362880L,1L,-4608L,615288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142336Inst : IEnumerable<long>
{
public static readonly long[] Value=A142336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142336.Bytes);
public long this[int i]=>Value[i];

public static A142336Inst Instance=new A142336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142337
{
public static readonly long[] Value={ 7L,12L,18L,23L,24L,32L,49L,66L,84L,87L,90L,92L,111L,112L,113L,114L,129L,130L,132L,133L,137L,138L,199L,238L,239L,271L,275L,278L,283L,285L,307L,313L,314L,317L,319L,322L,340L,342L,352L,357L,392L,394L,397L,399L,442L,443L,491L,492L,494L,499L,500L,619L,622L,648L,649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142337Inst : IEnumerable<long>
{
public static readonly long[] Value=A142337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142337.Bytes);
public long this[int i]=>Value[i];

public static A142337Inst Instance=new A142337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142338
{
public static readonly long[] Value={ 1L,6L,12L,15L,16L,20L,24L,27L,33L,39L,42L,45L,45L,50L,52L,54L,55L,63L,63L,66L,70L,70L,70L,78L,81L,84L,86L,102L,105L,108L,110L,115L,117L,117L,118L,121L,121L,132L,133L,138L,141L,146L,148L,150L,156L,158L,165L,168L,168L,171L,180L,180L,182L,198L,203L,205L,205L,210L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142338Inst : IEnumerable<long>
{
public static readonly long[] Value=A142338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142338.Bytes);
public long this[int i]=>Value[i];

public static A142338Inst Instance=new A142338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142339
{
public static readonly long[] Value={ 2L,13L,17L,19L,67L,83L,197L,257L,311L,409L,419L,557L,571L,587L,659L,677L,677L,733L,773L,827L,853L,877L,881L,971L,983L,1087L,1123L,1171L,1171L,1229L,1259L,1279L,1283L,1367L,1423L,1429L,1499L,1543L,1657L,1733L,1741L,1759L,1759L,1777L,1871L,1871L,1877L,1907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142339Inst : IEnumerable<long>
{
public static readonly long[] Value=A142339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142339.Bytes);
public long this[int i]=>Value[i];

public static A142339Inst Instance=new A142339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142340
{
public static readonly long[] Value={ 3L,5L,7L,7L,23L,23L,43L,67L,71L,73L,127L,127L,151L,163L,173L,181L,199L,199L,229L,239L,257L,271L,293L,353L,383L,419L,419L,457L,463L,479L,487L,523L,571L,599L,601L,617L,631L,643L,643L,673L,733L,739L,739L,761L,821L,827L,827L,863L,881L,881L,887L,907L,937L,967L,1033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142340Inst : IEnumerable<long>
{
public static readonly long[] Value=A142340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142340.Bytes);
public long this[int i]=>Value[i];

public static A142340Inst Instance=new A142340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142341
{
public static readonly long[] Value={ 2L,5L,7L,17L,23L,59L,61L,83L,131L,137L,157L,241L,257L,293L,367L,467L,479L,557L,569L,571L,587L,787L,823L,853L,859L,971L,1093L,1217L,1499L,1523L,1553L,1559L,1571L,1579L,1699L,1733L,1789L,1831L,1847L,1907L,1999L,2011L,2081L,2113L,2129L,2239L,2293L,2393L,2423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142341Inst : IEnumerable<long>
{
public static readonly long[] Value=A142341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142341.Bytes);
public long this[int i]=>Value[i];

public static A142341Inst Instance=new A142341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142342
{
public static readonly long[] Value={ 20L,30L,50L,70L,110L,130L,170L,190L,230L,290L,310L,370L,410L,430L,470L,530L,590L,610L,670L,710L,730L,790L,830L,890L,970L,1010L,1030L,1070L,1090L,1130L,1270L,1310L,1370L,1390L,1490L,1510L,1570L,1630L,1670L,1730L,1790L,1810L,1910L,1930L,1970L,1990L,2110L,2230L,2270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142342Inst : IEnumerable<long>
{
public static readonly long[] Value=A142342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142342.Bytes);
public long this[int i]=>Value[i];

public static A142342Inst Instance=new A142342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142343
{
public static readonly long[] Value={ 11L,31L,43L,47L,73L,103L,109L,113L,127L,211L,239L,269L,353L,443L,509L,631L,733L,743L,823L,839L,881L,887L,1051L,1213L,1277L,1283L,1303L,1307L,1321L,1571L,1583L,1597L,1709L,1747L,1783L,1801L,1997L,2003L,2017L,2087L,2111L,2239L,2267L,2441L,2503L,2591L,2609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142343Inst : IEnumerable<long>
{
public static readonly long[] Value=A142343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142343.Bytes);
public long this[int i]=>Value[i];

public static A142343Inst Instance=new A142343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142376
{
public static readonly long[] Value={ 307L,401L,683L,1153L,1811L,1999L,2281L,2657L,2939L,3221L,3691L,4349L,5101L,5477L,6229L,6323L,6793L,7451L,7639L,8297L,8861L,9049L,9613L,10177L,10271L,10459L,11117L,11399L,11587L,11681L,12433L,12527L,12809L,14407L,14783L,15629L,15817L,16193L,16381L,17321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142376Inst : IEnumerable<long>
{
public static readonly long[] Value=A142376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142376.Bytes);
public long this[int i]=>Value[i];

public static A142376Inst Instance=new A142376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142377
{
public static readonly long[] Value={ 73L,167L,449L,919L,1013L,1201L,1483L,2141L,2423L,3457L,3739L,3833L,4021L,4397L,4679L,5431L,5807L,6089L,6277L,6653L,6841L,7499L,7687L,8627L,9473L,9661L,10037L,10601L,10789L,10883L,11071L,11353L,11447L,12011L,12763L,13327L,13421L,14173L,14549L,14737L,14831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142377Inst : IEnumerable<long>
{
public static readonly long[] Value=A142377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142377.Bytes);
public long this[int i]=>Value[i];

public static A142377Inst Instance=new A142377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142378
{
public static readonly long[] Value={ 967L,1061L,1249L,1531L,1907L,2377L,2659L,2753L,3881L,5009L,5197L,5479L,5573L,6043L,6607L,6701L,6983L,7547L,7829L,8017L,8111L,8581L,8863L,9239L,9521L,9803L,10273L,10837L,11119L,11213L,11777L,13093L,13187L,13469L,13751L,14033L,14221L,14503L,14879L,15161L,15349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142378Inst : IEnumerable<long>
{
public static readonly long[] Value=A142378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142378.Bytes);
public long this[int i]=>Value[i];

public static A142378Inst Instance=new A142378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142379
{
public static readonly long[] Value={ 263L,733L,827L,1109L,1297L,1579L,1861L,2143L,2237L,2707L,2801L,3083L,3271L,3929L,4211L,4493L,5527L,5903L,6091L,6373L,7219L,7877L,8629L,9851L,10039L,10133L,10321L,10979L,11261L,11731L,12107L,12577L,12671L,12953L,13799L,14081L,14551L,15679L,15773L,16619L,16901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142379Inst : IEnumerable<long>
{
public static readonly long[] Value=A142379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142379.Bytes);
public long this[int i]=>Value[i];

public static A142379Inst Instance=new A142379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142380
{
public static readonly long[] Value={ 29L,311L,499L,593L,1063L,1439L,1627L,1721L,2003L,2473L,3037L,3319L,3413L,4259L,4447L,4729L,5011L,5387L,5669L,5857L,6421L,6703L,7079L,7549L,7643L,8677L,9241L,10181L,10369L,10463L,10651L,11027L,11497L,11779L,12343L,12437L,12907L,13001L,14411L,15727L,16103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142380Inst : IEnumerable<long>
{
public static readonly long[] Value=A142380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142380.Bytes);
public long this[int i]=>Value[i];

public static A142380Inst Instance=new A142380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142381
{
public static readonly long[] Value={ 359L,547L,641L,829L,1487L,2239L,2333L,2521L,2803L,2897L,3461L,3931L,4871L,5059L,5153L,5623L,5717L,6469L,6563L,7127L,7691L,7879L,8161L,8443L,8537L,8819L,9007L,11827L,12109L,12203L,12391L,13049L,13331L,13613L,14083L,14177L,14741L,14929L,15493L,16057L,16339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142381Inst : IEnumerable<long>
{
public static readonly long[] Value=A142381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142381.Bytes);
public long this[int i]=>Value[i];

public static A142381Inst Instance=new A142381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142382
{
public static readonly long[] Value={ 31L,313L,877L,971L,1723L,2099L,2287L,2381L,2663L,2851L,3697L,4073L,4261L,4637L,4919L,5107L,5483L,5953L,6047L,6329L,7457L,7927L,8209L,8867L,9337L,9431L,9619L,9901L,10559L,11311L,11593L,11969L,12157L,12251L,12721L,13003L,13567L,15259L,15541L,15823L,16481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142382Inst : IEnumerable<long>
{
public static readonly long[] Value=A142382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142382.Bytes);
public long this[int i]=>Value[i];

public static A142382Inst Instance=new A142382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142383
{
public static readonly long[] Value={ 79L,173L,643L,1019L,1301L,1489L,1583L,2053L,2617L,2711L,3181L,3463L,3557L,4027L,4591L,4967L,5437L,5531L,5813L,6659L,7129L,7411L,8069L,8539L,8821L,9103L,9479L,9949L,10513L,10607L,10889L,11171L,11923L,12487L,13709L,14461L,15307L,15401L,15683L,16529L,16811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142383Inst : IEnumerable<long>
{
public static readonly long[] Value=A142383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142383.Bytes);
public long this[int i]=>Value[i];

public static A142383Inst Instance=new A142383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142384
{
public static readonly long[] Value={ 127L,409L,503L,691L,1913L,2383L,2477L,3041L,3229L,3323L,3511L,3793L,4357L,4451L,4639L,4733L,5297L,5861L,6143L,7177L,7459L,7741L,8117L,8681L,8963L,9151L,9433L,10091L,10937L,11689L,11783L,11971L,12253L,12347L,12911L,13099L,13381L,13757L,14321L,15073L,15731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142384Inst : IEnumerable<long>
{
public static readonly long[] Value=A142384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142384.Bytes);
public long this[int i]=>Value[i];

public static A142384Inst Instance=new A142384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142385
{
public static readonly long[] Value={ 269L,457L,739L,1021L,1303L,1867L,2243L,2713L,3089L,3371L,3559L,4217L,4969L,6379L,6473L,6661L,7507L,7789L,7883L,8353L,8447L,9011L,9199L,9293L,9857L,10139L,10891L,11173L,11549L,11831L,12113L,12301L,12583L,12959L,13147L,13241L,13523L,13711L,14087L,14369L,14557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142385Inst : IEnumerable<long>
{
public static readonly long[] Value=A142385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142385.Bytes);
public long this[int i]=>Value[i];

public static A142385Inst Instance=new A142385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142386
{
public static readonly long[] Value={ 223L,317L,599L,787L,881L,1069L,1163L,3137L,3607L,3701L,3889L,4547L,5393L,5581L,6427L,6521L,6709L,6803L,6991L,7649L,9059L,9341L,9623L,9811L,10093L,10657L,10939L,11503L,11597L,12161L,13007L,13477L,13759L,14323L,14699L,14887L,15263L,15451L,15733L,16673L,17519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142386Inst : IEnumerable<long>
{
public static readonly long[] Value=A142386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142386.Bytes);
public long this[int i]=>Value[i];

public static A142386Inst Instance=new A142386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142387
{
public static readonly long[] Value={ 83L,271L,647L,929L,1117L,1399L,1493L,2339L,2621L,2903L,3373L,3467L,4219L,4783L,4877L,5347L,5441L,6287L,6569L,7039L,7321L,7603L,8167L,8543L,8731L,9013L,9859L,10141L,10799L,10987L,11551L,11833L,11927L,12491L,13337L,13619L,13807L,13901L,14653L,14747L,15217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142387Inst : IEnumerable<long>
{
public static readonly long[] Value=A142387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142387.Bytes);
public long this[int i]=>Value[i];

public static A142387Inst Instance=new A142387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142388
{
public static readonly long[] Value={ 37L,131L,601L,883L,977L,1259L,1447L,1823L,2011L,2293L,2857L,3797L,4079L,4549L,4643L,4831L,5113L,6053L,6899L,7369L,7933L,8779L,9343L,9437L,9719L,9907L,10753L,10847L,11317L,11411L,12163L,12539L,12821L,13009L,13103L,13291L,14419L,14983L,15077L,15359L,15641L,15923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142388Inst : IEnumerable<long>
{
public static readonly long[] Value=A142388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142388.Bytes);
public long this[int i]=>Value[i];

public static A142388Inst Instance=new A142388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142389
{
public static readonly long[] Value={ 179L,367L,461L,743L,1213L,1307L,1777L,1871L,2153L,2341L,2999L,3187L,3469L,4127L,4409L,4597L,4691L,4973L,5443L,6007L,6101L,6571L,6947L,7229L,7417L,7699L,7793L,8263L,9109L,9203L,9391L,9767L,10331L,10613L,11083L,11177L,12211L,13151L,13339L,13903L,13997L,14561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142389Inst : IEnumerable<long>
{
public static readonly long[] Value=A142389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142389.Bytes);
public long this[int i]=>Value[i];

public static A142389Inst Instance=new A142389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142390
{
public static readonly long[] Value={ 227L,509L,1543L,1637L,2389L,2671L,2953L,3329L,3517L,4363L,4457L,5021L,5209L,5303L,5867L,6337L,6619L,7559L,7841L,8123L,8311L,8969L,9157L,9439L,9533L,9721L,10567L,11131L,11789L,12071L,12541L,12823L,12917L,13669L,13763L,14327L,14797L,14891L,15173L,15361L,15643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142390Inst : IEnumerable<long>
{
public static readonly long[] Value=A142390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142390.Bytes);
public long this[int i]=>Value[i];

public static A142390Inst Instance=new A142390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142391
{
public static readonly long[] Value={ 181L,463L,557L,839L,1873L,2437L,2531L,2719L,3001L,3659L,3847L,4129L,4787L,5351L,5821L,6197L,6761L,6949L,7043L,7607L,8171L,8641L,8923L,9769L,10333L,10427L,10709L,11273L,11743L,12119L,12401L,12589L,13999L,14281L,14563L,14657L,14939L,15973L,16067L,16349L,16631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142391Inst : IEnumerable<long>
{
public static readonly long[] Value=A142391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142391.Bytes);
public long this[int i]=>Value[i];

public static A142391Inst Instance=new A142391Inst();

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

}