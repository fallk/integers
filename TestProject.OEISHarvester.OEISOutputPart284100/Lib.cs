using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A141907
{
public static readonly long[] Value={ 1L,11L,141L,1111L,16661L,172271L,1016101L,17399371L,128404821L,1302442031L,16784848761L,131546645131L,1860584850681L,19465322356491L,129218121812921L,1955997557995591L,14000280008200041L,154002080080200451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141907Inst : IEnumerable<long>
{
public static readonly long[] Value=A141907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141907.Bytes);
public long this[int i]=>Value[i];

public static A141907Inst Instance=new A141907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141908
{
public static readonly long[] Value={ 2L,71L,163L,347L,439L,577L,761L,853L,991L,1129L,1451L,1543L,2003L,2141L,2371L,2417L,2647L,2693L,2969L,3061L,3613L,3659L,3797L,3889L,4027L,4073L,4211L,4349L,4441L,4993L,5039L,5407L,5591L,5683L,5821L,5867L,6143L,6373L,6833L,6971L,7109L,7247L,7477L,7523L,7753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141908Inst : IEnumerable<long>
{
public static readonly long[] Value=A141908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141908.Bytes);
public long this[int i]=>Value[i];

public static A141908Inst Instance=new A141908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141909
{
public static readonly long[] Value={ 73L,211L,257L,349L,487L,809L,947L,1039L,1223L,1361L,1453L,1499L,1637L,1867L,1913L,2143L,2281L,2557L,2741L,2833L,2879L,2971L,3109L,4259L,4397L,4673L,4903L,5087L,5179L,5501L,5639L,5869L,6007L,6053L,6329L,6421L,7019L,7433L,8123L,8353L,8537L,8629L,8951L,9043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141909Inst : IEnumerable<long>
{
public static readonly long[] Value=A141909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141909.Bytes);
public long this[int i]=>Value[i];

public static A141909Inst Instance=new A141909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141910
{
public static readonly long[] Value={ 29L,167L,397L,443L,673L,719L,811L,857L,1087L,1409L,1777L,1823L,2053L,2099L,2237L,2467L,2789L,2927L,3019L,3203L,3433L,3571L,3617L,3709L,3847L,4261L,4583L,4721L,4813L,4951L,5227L,5273L,5503L,5641L,5779L,6101L,6469L,6607L,6653L,6791L,6883L,7159L,7297L,7481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141910Inst : IEnumerable<long>
{
public static readonly long[] Value=A141910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141910.Bytes);
public long this[int i]=>Value[i];

public static A141910Inst Instance=new A141910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141911
{
public static readonly long[] Value={ 7L,53L,191L,283L,421L,467L,743L,881L,1019L,1249L,1433L,1571L,1663L,1709L,1801L,1847L,2399L,2767L,3089L,3181L,3319L,3457L,3733L,3779L,3917L,4423L,4561L,5021L,5113L,5297L,5527L,5573L,5711L,5849L,5987L,6079L,6217L,6263L,6907L,7229L,7321L,7459L,7643L,7873L,7919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141911Inst : IEnumerable<long>
{
public static readonly long[] Value=A141911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141911.Bytes);
public long this[int i]=>Value[i];

public static A141911Inst Instance=new A141911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141944
{
public static readonly long[] Value={ 47L,97L,197L,347L,397L,547L,647L,797L,947L,997L,1097L,1297L,1447L,1597L,1697L,1747L,1847L,1997L,2297L,2347L,2447L,2647L,2797L,2897L,3347L,3547L,3697L,3797L,3847L,3947L,4297L,4397L,4447L,4547L,4597L,5147L,5197L,5297L,5347L,5647L,5897L,6047L,6197L,6247L,6397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141944Inst : IEnumerable<long>
{
public static readonly long[] Value=A141944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141944.Bytes);
public long this[int i]=>Value[i];

public static A141944Inst Instance=new A141944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141945
{
public static readonly long[] Value={ 23L,73L,173L,223L,373L,523L,673L,773L,823L,1123L,1223L,1373L,1423L,1523L,1723L,1823L,1873L,1973L,2273L,2423L,2473L,3023L,3323L,3373L,3623L,3673L,3823L,3923L,4073L,4273L,4373L,4423L,4523L,4673L,4723L,4973L,5023L,5273L,5323L,5573L,5623L,5923L,6073L,6173L,6323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141945Inst : IEnumerable<long>
{
public static readonly long[] Value=A141945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141945.Bytes);
public long this[int i]=>Value[i];

public static A141945Inst Instance=new A141945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141946
{
public static readonly long[] Value={ 149L,199L,349L,449L,499L,599L,1049L,1249L,1399L,1499L,1549L,1699L,1949L,1999L,2099L,2399L,2549L,2699L,2749L,2999L,3049L,3299L,3449L,3499L,4049L,4099L,4349L,4549L,4649L,4799L,4999L,5099L,5399L,5449L,5749L,5849L,6199L,6299L,6449L,6599L,6899L,6949L,7349L,7499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141946Inst : IEnumerable<long>
{
public static readonly long[] Value=A141946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141946.Bytes);
public long this[int i]=>Value[i];

public static A141946Inst Instance=new A141946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141947
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,3L,3L,0L,1L,7L,7L,1L,0L,4L,15L,15L,4L,0L,1L,11L,31L,31L,11L,1L,0L,5L,26L,63L,63L,26L,5L,0L,1L,16L,57L,127L,127L,57L,16L,1L,0L,6L,42L,120L,255L,255L,120L,42L,6L,0L,1L,22L,99L,247L,511L,511L,247L,99L,22L,1L,0L,7L,64L,219L,502L,1023L,1023L,502L,219L,64L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141947Inst : IEnumerable<long>
{
public static readonly long[] Value=A141947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141947.Bytes);
public long this[int i]=>Value[i];

public static A141947Inst Instance=new A141947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141948
{
public static readonly long[] Value={ 109L,163L,271L,379L,433L,487L,541L,757L,811L,919L,1297L,1459L,1567L,1621L,1783L,1999L,2053L,2161L,2269L,2377L,2539L,2593L,2647L,2917L,2971L,3079L,3187L,3457L,3511L,3673L,3727L,3889L,3943L,4051L,4159L,4483L,4591L,4861L,4969L,5023L,5077L,5347L,5563L,5779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141948Inst : IEnumerable<long>
{
public static readonly long[] Value=A141948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141948.Bytes);
public long this[int i]=>Value[i];

public static A141948Inst Instance=new A141948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141949
{
public static readonly long[] Value={ 2L,29L,83L,137L,191L,353L,461L,569L,677L,839L,947L,1109L,1163L,1217L,1433L,1487L,1811L,1973L,2027L,2081L,2243L,2297L,2351L,2459L,2621L,2729L,2837L,2999L,3323L,3539L,3593L,3701L,3863L,3917L,4079L,4133L,4241L,4349L,4457L,4673L,4889L,4943L,5051L,5483L,5591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141949Inst : IEnumerable<long>
{
public static readonly long[] Value=A141949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141949.Bytes);
public long this[int i]=>Value[i];

public static A141949Inst Instance=new A141949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141950
{
public static readonly long[] Value={ 31L,139L,193L,409L,463L,571L,733L,787L,1327L,1381L,1489L,1543L,1597L,1759L,1867L,2029L,2083L,2137L,2677L,2731L,3001L,3109L,3163L,3217L,3271L,3433L,3541L,3919L,4027L,4243L,4297L,4513L,4567L,4621L,4729L,4783L,4999L,5107L,5323L,5431L,5647L,5701L,6079L,6133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141950Inst : IEnumerable<long>
{
public static readonly long[] Value=A141950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141950.Bytes);
public long this[int i]=>Value[i];

public static A141950Inst Instance=new A141950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141951
{
public static readonly long[] Value={ 5L,59L,113L,167L,383L,491L,599L,653L,761L,977L,1031L,1193L,1301L,1409L,1571L,1733L,1787L,1949L,2003L,2111L,2273L,2381L,2543L,3083L,3137L,3191L,3299L,3407L,3461L,3623L,3677L,3947L,4001L,4217L,4271L,4649L,4703L,4919L,4973L,5081L,5189L,5297L,5351L,5783L,6053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141951Inst : IEnumerable<long>
{
public static readonly long[] Value=A141951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141951.Bytes);
public long this[int i]=>Value[i];

public static A141951Inst Instance=new A141951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141952
{
public static readonly long[] Value={ 7L,61L,223L,277L,331L,439L,547L,601L,709L,1033L,1087L,1249L,1303L,1627L,1789L,1951L,2113L,2221L,2383L,2437L,2707L,3301L,3463L,3517L,3571L,3733L,4003L,4057L,4111L,4219L,4273L,4327L,4597L,4651L,4759L,4813L,5407L,5569L,5623L,5839L,6163L,6217L,6271L,6379L,6703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141952Inst : IEnumerable<long>
{
public static readonly long[] Value=A141952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141952.Bytes);
public long this[int i]=>Value[i];

public static A141952Inst Instance=new A141952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141953
{
public static readonly long[] Value={ 89L,197L,251L,359L,467L,521L,683L,953L,1061L,1223L,1277L,1439L,1493L,1601L,1709L,1871L,1979L,2087L,2141L,2357L,2411L,2789L,2843L,2897L,3167L,3221L,3329L,3491L,3761L,3923L,4139L,4409L,4463L,4517L,4679L,4733L,4787L,5003L,5273L,5381L,5651L,5813L,5867L,6029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141953Inst : IEnumerable<long>
{
public static readonly long[] Value=A141953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141953.Bytes);
public long this[int i]=>Value[i];

public static A141953Inst Instance=new A141953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141954
{
public static readonly long[] Value={ 37L,199L,307L,523L,577L,631L,739L,1009L,1063L,1117L,1171L,1279L,1549L,1657L,1873L,2089L,2143L,2251L,2467L,2521L,2683L,2791L,2953L,3061L,3169L,3331L,3547L,3709L,4357L,4519L,4789L,4951L,5059L,5113L,5167L,5437L,5653L,5869L,5923L,6247L,6301L,6571L,6679L,6733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141954Inst : IEnumerable<long>
{
public static readonly long[] Value=A141954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141954.Bytes);
public long this[int i]=>Value[i];

public static A141954Inst Instance=new A141954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141955
{
public static readonly long[] Value={ 11L,173L,227L,281L,389L,443L,659L,821L,929L,983L,1091L,1307L,1361L,1523L,1847L,1901L,2063L,2333L,2441L,2549L,2657L,2711L,2819L,2927L,3089L,3251L,3359L,3413L,3467L,4007L,4493L,4547L,4817L,4871L,5087L,5303L,5519L,5573L,5843L,5897L,6113L,6221L,6329L,6491L,6599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141955Inst : IEnumerable<long>
{
public static readonly long[] Value=A141955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141955.Bytes);
public long this[int i]=>Value[i];

public static A141955Inst Instance=new A141955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141956
{
public static readonly long[] Value={ 13L,67L,229L,283L,337L,499L,607L,661L,769L,823L,877L,1039L,1093L,1201L,1471L,1579L,1741L,2011L,2281L,2389L,2551L,2659L,2713L,2767L,3037L,3253L,3307L,3361L,3469L,3631L,3739L,3793L,3847L,4441L,4549L,4603L,4657L,5197L,5413L,5521L,5683L,5737L,5791L,5953L,6007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141956Inst : IEnumerable<long>
{
public static readonly long[] Value=A141956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141956.Bytes);
public long this[int i]=>Value[i];

public static A141956Inst Instance=new A141956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141957
{
public static readonly long[] Value={ 41L,149L,257L,311L,419L,743L,797L,1013L,1229L,1283L,1499L,1553L,1607L,1823L,1877L,1931L,2039L,2309L,2417L,2579L,2633L,2687L,2741L,2903L,2957L,3011L,3119L,3389L,3659L,3767L,3821L,3929L,4091L,4253L,4523L,4793L,5009L,5171L,5279L,5333L,5387L,5441L,5657L,5711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141957Inst : IEnumerable<long>
{
public static readonly long[] Value=A141957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141957.Bytes);
public long this[int i]=>Value[i];

public static A141957Inst Instance=new A141957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141958
{
public static readonly long[] Value={ 43L,97L,151L,313L,367L,421L,691L,853L,907L,1069L,1123L,1231L,1447L,1609L,1663L,1879L,1933L,1987L,2203L,2311L,2473L,2689L,2797L,2851L,3067L,3121L,3229L,3391L,3499L,3607L,3769L,3823L,3877L,3931L,4093L,4201L,4363L,4903L,4957L,5011L,5119L,5227L,5281L,5443L,5659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141958Inst : IEnumerable<long>
{
public static readonly long[] Value=A141958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141958.Bytes);
public long this[int i]=>Value[i];

public static A141958Inst Instance=new A141958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141959
{
public static readonly long[] Value={ 17L,71L,179L,233L,449L,503L,557L,719L,773L,827L,881L,1097L,1151L,1259L,1367L,1583L,1637L,1907L,2069L,2339L,2393L,2447L,2609L,2663L,2879L,3041L,3203L,3257L,3527L,3581L,3797L,3851L,4013L,4229L,4283L,4337L,4391L,4877L,4931L,5039L,5147L,5309L,5417L,5471L,5741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141959Inst : IEnumerable<long>
{
public static readonly long[] Value=A141959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141959.Bytes);
public long this[int i]=>Value[i];

public static A141959Inst Instance=new A141959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141992
{
public static readonly long[] Value={ 103L,277L,509L,683L,857L,1031L,1321L,1553L,1669L,1901L,2017L,2423L,2539L,2713L,2887L,3061L,3119L,3467L,3583L,3931L,3989L,4337L,4801L,5323L,5381L,5903L,6367L,6599L,6947L,7121L,7237L,7411L,7643L,7759L,7817L,7933L,8513L,8629L,8803L,8861L,9151L,9209L,10079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141992Inst : IEnumerable<long>
{
public static readonly long[] Value=A141992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141992.Bytes);
public long this[int i]=>Value[i];

public static A141992Inst Instance=new A141992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141993
{
public static readonly long[] Value={ 17L,191L,307L,829L,887L,1061L,1409L,1583L,1699L,1873L,1931L,2221L,2801L,2917L,3323L,3613L,3671L,4019L,4483L,4657L,4831L,4889L,5179L,5237L,5527L,5701L,6397L,6571L,6803L,6977L,7151L,7499L,7673L,7789L,7963L,8311L,8369L,8543L,9007L,9181L,9239L,9413L,9587L,10399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141993Inst : IEnumerable<long>
{
public static readonly long[] Value=A141993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141993.Bytes);
public long this[int i]=>Value[i];

public static A141993Inst Instance=new A141993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141994
{
public static readonly long[] Value={ 47L,163L,337L,569L,743L,859L,1033L,1091L,1381L,1439L,1613L,1787L,2251L,2309L,2657L,3121L,3469L,3527L,3643L,3701L,4049L,4339L,4397L,4513L,4861L,4919L,5209L,5441L,5557L,6079L,6311L,6427L,6659L,6833L,6949L,7297L,7529L,7703L,7877L,7993L,8167L,8573L,8689L,8747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141994Inst : IEnumerable<long>
{
public static readonly long[] Value=A141994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141994.Bytes);
public long this[int i]=>Value[i];

public static A141994Inst Instance=new A141994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141995
{
public static readonly long[] Value={ 19L,193L,251L,367L,541L,599L,773L,947L,1063L,1237L,1759L,1933L,2281L,2339L,2687L,2803L,2861L,3209L,3499L,3557L,3673L,3847L,4021L,4079L,4253L,5297L,5413L,5471L,6689L,6863L,7211L,7559L,7907L,8081L,8429L,8719L,8893L,8951L,9067L,9241L,9473L,10111L,10169L,10343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141995Inst : IEnumerable<long>
{
public static readonly long[] Value=A141995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141995.Bytes);
public long this[int i]=>Value[i];

public static A141995Inst Instance=new A141995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141996
{
public static readonly long[] Value={ 107L,223L,281L,397L,571L,919L,977L,1093L,1151L,1499L,1789L,1847L,2137L,2311L,2543L,2659L,2833L,3181L,3413L,3529L,3761L,3877L,4051L,4283L,4457L,5153L,5443L,5501L,5791L,5849L,6197L,6661L,6719L,7589L,7879L,7937L,8053L,8111L,8807L,8923L,9619L,9677L,9851L,9967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141996Inst : IEnumerable<long>
{
public static readonly long[] Value=A141996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141996.Bytes);
public long this[int i]=>Value[i];

public static A141996Inst Instance=new A141996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141997
{
public static readonly long[] Value={ 79L,137L,311L,601L,659L,1123L,1181L,1297L,1471L,1877L,1993L,2341L,2399L,2689L,3037L,3559L,3617L,3733L,3907L,4139L,4603L,4951L,5009L,5531L,5647L,5821L,5879L,6053L,6343L,6691L,7039L,7213L,7561L,7793L,8431L,8663L,8779L,8837L,9011L,9127L,9533L,9649L,10867L,11273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141997Inst : IEnumerable<long>
{
public static readonly long[] Value=A141997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141997.Bytes);
public long this[int i]=>Value[i];

public static A141997Inst Instance=new A141997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141998
{
public static readonly long[] Value={ 109L,167L,283L,457L,631L,863L,1153L,1327L,1559L,1733L,1907L,2081L,2371L,2719L,2777L,3067L,3299L,3821L,4111L,4517L,4691L,5039L,5387L,5503L,5851L,6199L,6257L,6373L,6547L,6779L,7069L,7127L,7243L,7417L,7591L,7649L,7823L,8171L,8287L,8461L,8693L,8867L,9041L,9157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141998Inst : IEnumerable<long>
{
public static readonly long[] Value=A141998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141998.Bytes);
public long this[int i]=>Value[i];

public static A141998Inst Instance=new A141998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141999
{
public static readonly long[] Value={ 23L,139L,197L,313L,487L,661L,719L,1009L,1531L,1879L,2053L,2111L,2459L,2633L,2749L,3271L,3329L,3677L,3793L,3851L,3967L,4373L,4547L,4663L,4721L,5011L,5417L,5591L,5881L,5939L,6113L,6229L,6287L,6577L,6983L,7331L,7621L,7853L,8317L,8839L,9013L,9187L,9419L,9767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141999Inst : IEnumerable<long>
{
public static readonly long[] Value=A141999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141999.Bytes);
public long this[int i]=>Value[i];

public static A141999Inst Instance=new A141999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142000
{
public static readonly long[] Value={ 53L,227L,401L,691L,1039L,1097L,1213L,1619L,2083L,2141L,2663L,2837L,2953L,3011L,3301L,3359L,3533L,3823L,3881L,4229L,4519L,4751L,5099L,5273L,5563L,5737L,6143L,6317L,6491L,6607L,6781L,7013L,7129L,7187L,7477L,7883L,8231L,8521L,8753L,9043L,9391L,9623L,9739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142000Inst : IEnumerable<long>
{
public static readonly long[] Value=A142000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142000.Bytes);
public long this[int i]=>Value[i];

public static A142000Inst Instance=new A142000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142001
{
public static readonly long[] Value={ 83L,199L,257L,373L,431L,547L,953L,1069L,1301L,1823L,1997L,2113L,2287L,2693L,3041L,3331L,3389L,3853L,3911L,4027L,4201L,4259L,4549L,4723L,5303L,5419L,5477L,5651L,6173L,6521L,6637L,6869L,7043L,7159L,7333L,7507L,7681L,8087L,8377L,8609L,8783L,9421L,9479L,9769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142001Inst : IEnumerable<long>
{
public static readonly long[] Value=A142001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142001.Bytes);
public long this[int i]=>Value[i];

public static A142001Inst Instance=new A142001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142002
{
public static readonly long[] Value={ 113L,229L,461L,577L,751L,809L,983L,1447L,1621L,2027L,2143L,2549L,2897L,3187L,3361L,3593L,3709L,3767L,4057L,4231L,4289L,4463L,4637L,5101L,5333L,5449L,5507L,5623L,6029L,6203L,6551L,6841L,6899L,7247L,7537L,8059L,8117L,8233L,8291L,8581L,8929L,9103L,9161L,9277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142002Inst : IEnumerable<long>
{
public static readonly long[] Value=A142002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142002.Bytes);
public long this[int i]=>Value[i];

public static A142002Inst Instance=new A142002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142003
{
public static readonly long[] Value={ 317L,433L,491L,607L,839L,1013L,1129L,1187L,1303L,1361L,1709L,1999L,2347L,2521L,2579L,2753L,2927L,3217L,3391L,3449L,3623L,3739L,3797L,4261L,4493L,4783L,4957L,5189L,5479L,5653L,5711L,5827L,6581L,6871L,7103L,7219L,7393L,7451L,7741L,8089L,8147L,8263L,8669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142003Inst : IEnumerable<long>
{
public static readonly long[] Value=A142003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142003.Bytes);
public long this[int i]=>Value[i];

public static A142003Inst Instance=new A142003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142004
{
public static readonly long[] Value={ 173L,347L,463L,521L,811L,1217L,1913L,2029L,2087L,2203L,2377L,2551L,2609L,2957L,3769L,3943L,4001L,4349L,4523L,4639L,4813L,4871L,4987L,5393L,5683L,5741L,5857L,6089L,6263L,6379L,6553L,6959L,7307L,7481L,7829L,8293L,8467L,8641L,8699L,9221L,9337L,9511L,9743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142004Inst : IEnumerable<long>
{
public static readonly long[] Value=A142004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142004.Bytes);
public long this[int i]=>Value[i];

public static A142004Inst Instance=new A142004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142005
{
public static readonly long[] Value={ 311L,373L,683L,1117L,1303L,1427L,1489L,1613L,1861L,2357L,2543L,2729L,2791L,3163L,3659L,3907L,4093L,4217L,4651L,5023L,5147L,5209L,5333L,5519L,5581L,5953L,6263L,6449L,6883L,7069L,7193L,7937L,8123L,8681L,8867L,8929L,9239L,9859L,10169L,10789L,11161L,11471L,11657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142005Inst : IEnumerable<long>
{
public static readonly long[] Value=A142005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142005.Bytes);
public long this[int i]=>Value[i];

public static A142005Inst Instance=new A142005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142006
{
public static readonly long[] Value={ 2L,157L,281L,467L,653L,839L,1087L,1459L,1583L,1831L,2017L,2141L,2203L,2389L,2699L,3257L,3319L,3691L,3877L,4001L,4373L,4621L,4931L,4993L,5179L,5303L,5737L,5861L,5923L,6047L,6481L,6791L,6977L,7039L,7349L,7411L,7907L,8093L,8527L,8713L,8837L,9209L,9643L,9767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142006Inst : IEnumerable<long>
{
public static readonly long[] Value=A142006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142006.Bytes);
public long this[int i]=>Value[i];

public static A142006Inst Instance=new A142006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142007
{
public static readonly long[] Value={ 3L,127L,251L,313L,499L,809L,1181L,1367L,1429L,1553L,1801L,1987L,2111L,2297L,2731L,2917L,3041L,3413L,3847L,4157L,4219L,4591L,5087L,5273L,5521L,6079L,6203L,6389L,6451L,6637L,6761L,6823L,6947L,7691L,7753L,7877L,8311L,8807L,9241L,9551L,9613L,9923L,10357L,10667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142007Inst : IEnumerable<long>
{
public static readonly long[] Value=A142007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142007.Bytes);
public long this[int i]=>Value[i];

public static A142007Inst Instance=new A142007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142040
{
public static readonly long[] Value={ 13L,109L,173L,269L,397L,461L,557L,653L,877L,941L,1069L,1229L,1453L,1549L,1613L,1709L,1741L,1901L,1933L,1997L,2029L,2221L,2381L,2477L,2797L,2861L,2957L,3181L,3373L,3469L,3533L,3821L,3853L,3917L,4013L,4397L,4493L,4621L,4813L,4877L,4909L,4973L,5101L,5197L,5261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142040Inst : IEnumerable<long>
{
public static readonly long[] Value=A142040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142040.Bytes);
public long this[int i]=>Value[i];

public static A142040Inst Instance=new A142040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142041
{
public static readonly long[] Value={ 47L,79L,239L,271L,367L,431L,463L,719L,751L,911L,1039L,1103L,1231L,1327L,1423L,1487L,1583L,1871L,1999L,2063L,2287L,2351L,2383L,2447L,2543L,2671L,2767L,2927L,3023L,3119L,3343L,3407L,3631L,3727L,3823L,3919L,4079L,4111L,4271L,4463L,4591L,4751L,4783L,4943L,5039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142041Inst : IEnumerable<long>
{
public static readonly long[] Value=A142041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142041.Bytes);
public long this[int i]=>Value[i];

public static A142041Inst Instance=new A142041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142042
{
public static readonly long[] Value={ 19L,83L,179L,211L,307L,467L,499L,563L,659L,691L,787L,883L,947L,1171L,1427L,1459L,1523L,1619L,1747L,1811L,1907L,2003L,2099L,2131L,2579L,2707L,2803L,2963L,3187L,3251L,3347L,3539L,3571L,3923L,4019L,4051L,4211L,4243L,4339L,4691L,4723L,4787L,5011L,5107L,5171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142042Inst : IEnumerable<long>
{
public static readonly long[] Value=A142042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142042.Bytes);
public long this[int i]=>Value[i];

public static A142042Inst Instance=new A142042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142043
{
public static readonly long[] Value={ 53L,149L,181L,277L,373L,661L,757L,821L,853L,1013L,1109L,1237L,1301L,1429L,1493L,1621L,1877L,1973L,2069L,2293L,2357L,2389L,2549L,2677L,2741L,2837L,3061L,3221L,3253L,3413L,3541L,3637L,3701L,3733L,3797L,3989L,4021L,4373L,4597L,4789L,5077L,5237L,5333L,5557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142043Inst : IEnumerable<long>
{
public static readonly long[] Value=A142043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142043.Bytes);
public long this[int i]=>Value[i];

public static A142043Inst Instance=new A142043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142044
{
public static readonly long[] Value={ 23L,151L,311L,439L,503L,599L,631L,727L,823L,887L,919L,983L,1303L,1367L,1399L,1559L,1783L,1847L,1879L,2039L,2423L,2551L,2647L,2711L,2903L,2999L,3191L,3319L,3511L,3607L,3671L,3767L,3863L,4567L,4663L,4759L,4919L,4951L,5303L,5399L,5431L,5527L,5591L,5623L,5783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142044Inst : IEnumerable<long>
{
public static readonly long[] Value=A142044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142044.Bytes);
public long this[int i]=>Value[i];

public static A142044Inst Instance=new A142044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142045
{
public static readonly long[] Value={ 89L,281L,313L,409L,569L,601L,761L,857L,953L,1049L,1433L,1657L,1721L,1753L,1913L,2137L,2297L,2393L,2521L,2617L,2713L,2777L,2969L,3001L,3257L,3449L,3673L,3769L,3833L,3929L,4057L,4153L,4217L,4409L,4441L,4729L,4793L,4889L,5081L,5113L,5209L,5273L,5657L,5689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142045Inst : IEnumerable<long>
{
public static readonly long[] Value=A142045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142045.Bytes);
public long this[int i]=>Value[i];

public static A142045Inst Instance=new A142045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142046
{
public static readonly long[] Value={ 59L,251L,283L,347L,379L,443L,571L,827L,859L,1019L,1051L,1307L,1499L,1531L,1627L,1723L,1787L,1979L,2011L,2203L,2267L,2459L,2683L,2843L,2939L,2971L,3067L,3163L,3259L,3323L,3547L,3643L,3739L,3803L,3931L,4027L,4091L,4219L,4283L,4507L,4603L,4987L,5051L,5147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142046Inst : IEnumerable<long>
{
public static readonly long[] Value=A142046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142046.Bytes);
public long this[int i]=>Value[i];

public static A142046Inst Instance=new A142046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142047
{
public static readonly long[] Value={ 29L,61L,157L,317L,349L,509L,541L,701L,733L,797L,829L,1021L,1117L,1181L,1213L,1277L,1373L,1597L,1693L,1789L,1949L,2141L,2237L,2269L,2333L,2557L,2621L,2749L,2909L,3037L,3229L,3389L,3517L,3581L,3613L,3677L,3709L,4093L,4157L,4253L,4349L,4637L,4733L,4861L,4957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142047Inst : IEnumerable<long>
{
public static readonly long[] Value=A142047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142047.Bytes);
public long this[int i]=>Value[i];

public static A142047Inst Instance=new A142047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142048
{
public static readonly long[] Value={ 1L,3L,1L,5L,3L,1L,7L,45L,1L,1L,9L,105L,15L,3L,1L,11L,1575L,945L,15L,3L,1L,13L,10395L,175L,945L,9L,1L,1L,15L,315315L,17325L,14175L,189L,15L,3L,1L,17L,45045L,23648625L,7425L,2835L,189L,15L,3L,1L,19L,6891885L,1576575L,23648625L,93555L,945L,135L,45L,1L,1L,21L,72747675L,7309575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142048Inst : IEnumerable<long>
{
public static readonly long[] Value=A142048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142048.Bytes);
public long this[int i]=>Value[i];

public static A142048Inst Instance=new A142048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142049
{
public static readonly long[] Value={ 67L,199L,331L,397L,463L,661L,727L,859L,991L,1123L,1321L,1453L,1783L,2113L,2179L,2311L,2377L,2707L,2971L,3037L,3169L,3301L,3433L,3499L,3631L,3697L,4027L,4093L,4159L,4357L,4423L,4621L,4951L,5281L,5347L,5413L,5479L,5743L,6007L,6073L,6271L,6337L,6469L,6733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142049Inst : IEnumerable<long>
{
public static readonly long[] Value=A142049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142049.Bytes);
public long this[int i]=>Value[i];

public static A142049Inst Instance=new A142049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142050
{
public static readonly long[] Value={ 2L,101L,167L,233L,431L,563L,761L,827L,1091L,1223L,1289L,1487L,1553L,1619L,1949L,2081L,2213L,2411L,2477L,2543L,2609L,2741L,2939L,3137L,3203L,3467L,3533L,3797L,3863L,3929L,4127L,4259L,4391L,4457L,4523L,4721L,4787L,4919L,5051L,5381L,5711L,5843L,6173L,6569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142050Inst : IEnumerable<long>
{
public static readonly long[] Value=A142050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142050.Bytes);
public long this[int i]=>Value[i];

public static A142050Inst Instance=new A142050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142051
{
public static readonly long[] Value={ 37L,103L,367L,433L,499L,631L,829L,1093L,1291L,1423L,1489L,1621L,1753L,1951L,2017L,2083L,2281L,2347L,2677L,3271L,3469L,3733L,3931L,4129L,4261L,4327L,4591L,4657L,4723L,4789L,4987L,5119L,5449L,5581L,5647L,5779L,6043L,6373L,6571L,6637L,6703L,6967L,7297L,7561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142051Inst : IEnumerable<long>
{
public static readonly long[] Value=A142051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142051.Bytes);
public long this[int i]=>Value[i];

public static A142051Inst Instance=new A142051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142052
{
public static readonly long[] Value={ 5L,71L,137L,269L,401L,467L,599L,797L,863L,929L,1061L,1193L,1259L,1523L,1721L,1787L,2381L,2447L,2579L,2711L,2777L,2843L,2909L,3041L,3371L,3701L,3767L,3833L,4229L,4493L,4691L,4889L,5021L,5087L,5153L,5351L,5417L,5483L,5813L,5879L,6011L,6143L,6473L,6737L,6803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142052Inst : IEnumerable<long>
{
public static readonly long[] Value=A142052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142052.Bytes);
public long this[int i]=>Value[i];

public static A142052Inst Instance=new A142052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142053
{
public static readonly long[] Value={ 7L,73L,139L,271L,337L,601L,733L,997L,1063L,1129L,1327L,1459L,1657L,1723L,1789L,1987L,2053L,2251L,2383L,2647L,2713L,3109L,3307L,3373L,3571L,3637L,3769L,3967L,4099L,4231L,4297L,4363L,4561L,4759L,4957L,5023L,5419L,5683L,5749L,5881L,6079L,6211L,6277L,6343L,6607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142053Inst : IEnumerable<long>
{
public static readonly long[] Value=A142053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142053.Bytes);
public long this[int i]=>Value[i];

public static A142053Inst Instance=new A142053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142054
{
public static readonly long[] Value={ 41L,107L,173L,239L,503L,569L,701L,1031L,1097L,1163L,1229L,1361L,1427L,1493L,1559L,1823L,1889L,2087L,2153L,2351L,2417L,2549L,2879L,3011L,3209L,3407L,3539L,3671L,3803L,4001L,4133L,4397L,4463L,4793L,5189L,5387L,5519L,5651L,5717L,5783L,5849L,5981L,6047L,6113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142054Inst : IEnumerable<long>
{
public static readonly long[] Value=A142054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142054.Bytes);
public long this[int i]=>Value[i];

public static A142054Inst Instance=new A142054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142055
{
public static readonly long[] Value={ 43L,109L,241L,307L,373L,439L,571L,769L,967L,1033L,1231L,1297L,1429L,1627L,1693L,1759L,2089L,2221L,2287L,2551L,2617L,2683L,2749L,3079L,3343L,3541L,3607L,3673L,3739L,4003L,4201L,4597L,4663L,4729L,4861L,4993L,5059L,5323L,5521L,5653L,5851L,6247L,6379L,6577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142055Inst : IEnumerable<long>
{
public static readonly long[] Value=A142055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142055.Bytes);
public long this[int i]=>Value[i];

public static A142055Inst Instance=new A142055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142120
{
public static readonly long[] Value={ 11L,233L,307L,677L,751L,1787L,1861L,2083L,2749L,2897L,2971L,3119L,3637L,4007L,4229L,4451L,4673L,4969L,5413L,5783L,5857L,6079L,6301L,6449L,6967L,7411L,7559L,8447L,8521L,8669L,9187L,9631L,10223L,10667L,10889L,11777L,12073L,12517L,12739L,13109L,13183L,13331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142120Inst : IEnumerable<long>
{
public static readonly long[] Value=A142120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142120.Bytes);
public long this[int i]=>Value[i];

public static A142120Inst Instance=new A142120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142121
{
public static readonly long[] Value={ 197L,271L,419L,641L,863L,937L,1307L,1381L,1973L,2269L,2417L,2713L,2861L,3083L,3527L,3823L,4637L,4933L,5081L,5303L,5821L,6043L,6709L,6857L,7079L,7523L,8263L,8707L,8929L,9151L,9521L,9743L,9817L,10039L,10631L,10853L,11149L,11519L,11593L,12037L,12703L,13147L,13591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142121Inst : IEnumerable<long>
{
public static readonly long[] Value=A142121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142121.Bytes);
public long this[int i]=>Value[i];

public static A142121Inst Instance=new A142121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142122
{
public static readonly long[] Value={ 13L,383L,457L,827L,1049L,1123L,1493L,1567L,1789L,2011L,2381L,2677L,3121L,3343L,3491L,4157L,4231L,5119L,5563L,5711L,6007L,6229L,6451L,6599L,6673L,7043L,7487L,7561L,8597L,8819L,8893L,9041L,9337L,9781L,9929L,10151L,10891L,11113L,11261L,11483L,11779L,11927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142122Inst : IEnumerable<long>
{
public static readonly long[] Value=A142122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142122.Bytes);
public long this[int i]=>Value[i];

public static A142122Inst Instance=new A142122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142123
{
public static readonly long[] Value={ 199L,347L,421L,569L,643L,1013L,1087L,1531L,1753L,1901L,2789L,3011L,3307L,3529L,3677L,4639L,4787L,4861L,5009L,5231L,5527L,5749L,5897L,6563L,6637L,7229L,7451L,7673L,8117L,8191L,8783L,9227L,9967L,10337L,10559L,10781L,11003L,11299L,11447L,11743L,12113L,12409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142123Inst : IEnumerable<long>
{
public static readonly long[] Value=A142123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142123.Bytes);
public long this[int i]=>Value[i];

public static A142123Inst Instance=new A142123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142124
{
public static readonly long[] Value={ 89L,163L,311L,607L,829L,977L,1051L,2087L,2161L,2309L,2383L,2531L,2753L,3049L,3271L,3863L,4159L,4603L,4751L,4973L,5417L,5639L,5861L,6379L,6823L,6971L,7193L,7489L,7933L,8081L,8377L,8599L,8747L,8821L,8969L,9043L,9413L,9857L,9931L,10079L,10301L,10597L,11411L,11633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142124Inst : IEnumerable<long>
{
public static readonly long[] Value=A142124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142124.Bytes);
public long this[int i]=>Value[i];

public static A142124Inst Instance=new A142124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142125
{
public static readonly long[] Value={ 53L,127L,349L,571L,719L,941L,1163L,1237L,1459L,1607L,2273L,2347L,2791L,2939L,3457L,4049L,4271L,4493L,4567L,4789L,4937L,5011L,5233L,5381L,6047L,6121L,6269L,6343L,6491L,7823L,8563L,8933L,9007L,9377L,10487L,10709L,11597L,12041L,12263L,12781L,13003L,13151L,13669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142125Inst : IEnumerable<long>
{
public static readonly long[] Value=A142125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142125.Bytes);
public long this[int i]=>Value[i];

public static A142125Inst Instance=new A142125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142126
{
public static readonly long[] Value={ 17L,239L,313L,461L,683L,757L,1201L,1423L,1571L,1867L,2089L,2237L,2311L,2459L,2903L,3347L,3643L,4013L,4457L,4679L,5197L,5419L,5641L,6011L,6529L,6899L,7121L,7417L,7639L,8009L,8231L,8527L,8971L,9341L,9859L,10007L,10303L,11117L,11783L,12227L,12301L,12671L,12893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142126Inst : IEnumerable<long>
{
public static readonly long[] Value=A142126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142126.Bytes);
public long this[int i]=>Value[i];

public static A142126Inst Instance=new A142126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142127
{
public static readonly long[] Value={ 277L,499L,647L,1091L,1609L,1831L,1979L,2053L,2423L,2719L,3089L,3163L,3533L,3607L,4051L,4273L,4421L,4643L,5087L,5309L,5531L,5827L,6197L,6271L,6863L,7159L,7307L,7529L,7603L,8269L,8713L,8861L,9157L,9601L,9749L,10193L,10267L,10711L,10859L,11821L,11969L,12043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142127Inst : IEnumerable<long>
{
public static readonly long[] Value=A142127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142127.Bytes);
public long this[int i]=>Value[i];

public static A142127Inst Instance=new A142127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142128
{
public static readonly long[] Value={ 19L,167L,241L,389L,463L,907L,1129L,1277L,1499L,1721L,2017L,2239L,2609L,2683L,3571L,3719L,3793L,4903L,5051L,5273L,5347L,5569L,5717L,5791L,5939L,6679L,6827L,7789L,7937L,8011L,8233L,8677L,9343L,9491L,9787L,10009L,10453L,10601L,11119L,11489L,11933L,12007L,12377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142128Inst : IEnumerable<long>
{
public static readonly long[] Value=A142128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142128.Bytes);
public long this[int i]=>Value[i];

public static A142128Inst Instance=new A142128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142129
{
public static readonly long[] Value={ 131L,353L,797L,1019L,1093L,1759L,1907L,2129L,2203L,2351L,2647L,3313L,3461L,4127L,4201L,4349L,4423L,4793L,5237L,5903L,6199L,6421L,6569L,6791L,7013L,7309L,7457L,7753L,7901L,8123L,8419L,8641L,8863L,9011L,9677L,9973L,10343L,10639L,10861L,11083L,11527L,11897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142129Inst : IEnumerable<long>
{
public static readonly long[] Value=A142129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142129.Bytes);
public long this[int i]=>Value[i];

public static A142129Inst Instance=new A142129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142130
{
public static readonly long[] Value={ 317L,613L,761L,983L,1279L,1427L,1723L,1871L,2389L,2833L,3203L,3499L,3943L,4091L,4831L,5867L,6089L,6163L,6311L,6607L,6829L,6977L,7643L,7717L,8087L,8161L,8753L,9049L,9419L,10159L,10529L,10973L,11047L,11491L,12157L,12379L,12527L,12601L,12823L,13267L,13711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142130Inst : IEnumerable<long>
{
public static readonly long[] Value=A142130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142130.Bytes);
public long this[int i]=>Value[i];

public static A142130Inst Instance=new A142130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142131
{
public static readonly long[] Value={ 59L,281L,503L,577L,947L,1021L,1613L,2131L,2797L,3019L,3167L,3389L,3463L,3833L,3907L,4129L,4721L,4943L,5387L,5683L,6053L,6571L,6719L,6793L,7237L,7459L,7607L,7681L,7829L,8273L,9013L,9161L,9679L,9901L,10271L,10567L,10789L,10937L,11159L,11677L,12269L,12343L,12491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142131Inst : IEnumerable<long>
{
public static readonly long[] Value=A142131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142131.Bytes);
public long this[int i]=>Value[i];

public static A142131Inst Instance=new A142131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142132
{
public static readonly long[] Value={ 23L,97L,467L,541L,911L,1429L,1873L,2243L,2539L,2687L,2909L,3797L,4019L,4093L,4241L,4463L,4759L,5351L,5573L,5647L,5869L,6091L,7127L,7349L,7793L,7867L,8089L,8237L,8311L,8681L,9199L,9421L,9643L,9791L,10457L,10531L,10753L,11197L,11789L,11863L,12011L,12899L,12973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142132Inst : IEnumerable<long>
{
public static readonly long[] Value=A142132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142132.Bytes);
public long this[int i]=>Value[i];

public static A142132Inst Instance=new A142132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142133
{
public static readonly long[] Value={ 61L,283L,431L,653L,727L,1097L,1171L,1319L,2207L,2281L,2503L,3169L,3391L,3539L,3613L,3761L,4057L,4649L,4723L,4871L,5167L,5981L,6203L,6277L,6869L,7757L,8053L,8423L,8719L,8867L,8941L,9311L,9533L,9829L,10273L,10939L,11087L,11161L,11383L,11827L,12049L,12197L,12641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142133Inst : IEnumerable<long>
{
public static readonly long[] Value=A142133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142133.Bytes);
public long this[int i]=>Value[i];

public static A142133Inst Instance=new A142133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142134
{
public static readonly long[] Value={ 173L,617L,691L,839L,1061L,1283L,1579L,1801L,1949L,2393L,2467L,2689L,2837L,3947L,4021L,4243L,4391L,4909L,5279L,5501L,6389L,6833L,6907L,7129L,7351L,7499L,7573L,8017L,8387L,8461L,8609L,8831L,9127L,9349L,9497L,9719L,9941L,10163L,10459L,10607L,10903L,11273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142134Inst : IEnumerable<long>
{
public static readonly long[] Value=A142134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142134.Bytes);
public long this[int i]=>Value[i];

public static A142134Inst Instance=new A142134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142135
{
public static readonly long[] Value={ 137L,211L,359L,433L,877L,1321L,1543L,1913L,1987L,2357L,2579L,2801L,3023L,3319L,3467L,3541L,3911L,4133L,4651L,4799L,5021L,6131L,6353L,6427L,6871L,7019L,7537L,7759L,7907L,8573L,8647L,9091L,9239L,9461L,10867L,11311L,11681L,11903L,12347L,12421L,12569L,12791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142135Inst : IEnumerable<long>
{
public static readonly long[] Value=A142135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142135.Bytes);
public long this[int i]=>Value[i];

public static A142135Inst Instance=new A142135Inst();

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

public static class A142200
{
public static readonly long[] Value={ 3L,167L,331L,577L,659L,823L,1069L,1151L,1889L,2053L,2381L,2791L,3037L,3119L,3529L,4021L,4349L,4513L,4759L,5087L,5333L,5743L,6317L,6481L,6563L,7219L,7547L,7793L,8039L,8941L,9187L,9433L,9679L,10007L,10253L,10499L,10663L,10909L,11483L,12713L,12959L,13451L,13697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142200Inst : IEnumerable<long>
{
public static readonly long[] Value=A142200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142200.Bytes);
public long this[int i]=>Value[i];

public static A142200Inst Instance=new A142200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142201
{
public static readonly long[] Value={ 127L,373L,619L,701L,947L,1193L,1439L,1931L,2341L,2423L,2833L,3079L,3407L,3571L,4391L,4637L,4801L,5867L,6113L,6277L,6359L,7507L,7589L,7753L,8081L,8573L,8737L,8819L,9311L,9721L,9803L,9967L,10459L,11197L,11279L,11443L,11689L,12263L,12919L,13001L,13411L,13903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142201Inst : IEnumerable<long>
{
public static readonly long[] Value=A142201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142201.Bytes);
public long this[int i]=>Value[i];

public static A142201Inst Instance=new A142201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142202
{
public static readonly long[] Value={ 5L,251L,661L,743L,907L,1153L,1399L,1481L,1973L,2137L,2383L,2711L,2957L,3121L,3203L,3449L,3613L,4597L,4679L,5171L,5417L,5581L,5827L,6073L,7057L,7549L,7877L,8123L,8287L,8369L,8779L,8861L,10009L,10091L,10337L,10501L,10993L,11239L,11321L,11731L,11813L,13043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142202Inst : IEnumerable<long>
{
public static readonly long[] Value=A142202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142202.Bytes);
public long this[int i]=>Value[i];

public static A142202Inst Instance=new A142202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142203
{
public static readonly long[] Value={ 47L,211L,293L,457L,1031L,1277L,1523L,1933L,2179L,2671L,2753L,2917L,2999L,3163L,3491L,4229L,4639L,4721L,4967L,5623L,5869L,6197L,6361L,6607L,6689L,7591L,7673L,7919L,8329L,8821L,9067L,9887L,10133L,10789L,11117L,11527L,12101L,12347L,12511L,12757L,13003L,13249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142203Inst : IEnumerable<long>
{
public static readonly long[] Value=A142203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142203.Bytes);
public long this[int i]=>Value[i];

public static A142203Inst Instance=new A142203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142204
{
public static readonly long[] Value={ 7L,89L,499L,827L,991L,1237L,1319L,1483L,1811L,2221L,2467L,2549L,2713L,3041L,3533L,3697L,3779L,3943L,4271L,4517L,5009L,5419L,5501L,6977L,7879L,8699L,8863L,9109L,9437L,9601L,9929L,10093L,10667L,10831L,11159L,11897L,12143L,12553L,12799L,13127L,13291L,13537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142204Inst : IEnumerable<long>
{
public static readonly long[] Value=A142204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142204.Bytes);
public long this[int i]=>Value[i];

public static A142204Inst Instance=new A142204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142205
{
public static readonly long[] Value={ 131L,541L,787L,1033L,1279L,1361L,1607L,2017L,2099L,2591L,2837L,3001L,3083L,3329L,3739L,3821L,4231L,4723L,4969L,5051L,5297L,5953L,6199L,6691L,7019L,7757L,8167L,8741L,9151L,9397L,9479L,9643L,10463L,10627L,10709L,11119L,11447L,11939L,12841L,12923L,13907L,14071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142205Inst : IEnumerable<long>
{
public static readonly long[] Value=A142205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142205.Bytes);
public long this[int i]=>Value[i];

public static A142205Inst Instance=new A142205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142206
{
public static readonly long[] Value={ 173L,337L,419L,829L,911L,1321L,1567L,2141L,2551L,2633L,2797L,2879L,3371L,3617L,3863L,4027L,4273L,4519L,5011L,5503L,5749L,6323L,6569L,6733L,7307L,7717L,7963L,8209L,8291L,8537L,8783L,9029L,9439L,9521L,9767L,9931L,10177L,10259L,11161L,11243L,11489L,11981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142206Inst : IEnumerable<long>
{
public static readonly long[] Value=A142206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142206.Bytes);
public long this[int i]=>Value[i];

public static A142206Inst Instance=new A142206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142207
{
public static readonly long[] Value={ 379L,461L,953L,1117L,1609L,2347L,2593L,3167L,3331L,3413L,3659L,3823L,4397L,4561L,4643L,4889L,5381L,5791L,6037L,6529L,6857L,7103L,7349L,7759L,7841L,8087L,9973L,10301L,10711L,10957L,11777L,11941L,12269L,12433L,13007L,13171L,13417L,13499L,14401L,15139L,15467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142207Inst : IEnumerable<long>
{
public static readonly long[] Value=A142207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142207.Bytes);
public long this[int i]=>Value[i];

public static A142207Inst Instance=new A142207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142208
{
public static readonly long[] Value={ 11L,257L,421L,503L,1487L,1733L,1979L,2143L,2389L,2963L,3209L,3373L,3701L,3947L,4111L,4357L,4603L,4931L,5669L,6079L,6571L,6653L,6899L,7309L,7883L,8293L,8539L,8867L,9277L,9769L,9851L,10343L,10589L,10753L,11491L,12721L,12967L,13049L,14033L,14197L,14771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142208Inst : IEnumerable<long>
{
public static readonly long[] Value=A142208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142208.Bytes);
public long this[int i]=>Value[i];

public static A142208Inst Instance=new A142208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142209
{
public static readonly long[] Value={ 53L,463L,709L,1201L,1283L,1447L,1693L,2267L,2677L,3169L,3251L,3907L,3989L,4153L,4481L,4973L,5711L,6121L,6203L,6367L,6449L,7187L,7351L,7433L,8089L,8171L,8581L,8663L,9319L,9811L,10139L,10303L,10631L,11287L,11369L,11779L,12107L,12517L,12763L,13009L,13337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142209Inst : IEnumerable<long>
{
public static readonly long[] Value=A142209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142209.Bytes);
public long this[int i]=>Value[i];

public static A142209Inst Instance=new A142209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142210
{
public static readonly long[] Value={ 13L,587L,751L,997L,1489L,1571L,2063L,2309L,2473L,2719L,2801L,3457L,3539L,4441L,4523L,4933L,5179L,5261L,5507L,6163L,6491L,6737L,6983L,7229L,7393L,7639L,8377L,8623L,8951L,9689L,10099L,10181L,10427L,10837L,11083L,11329L,11411L,11657L,11821L,11903L,12149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142210Inst : IEnumerable<long>
{
public static readonly long[] Value=A142210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142210.Bytes);
public long this[int i]=>Value[i];

public static A142210Inst Instance=new A142210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142211
{
public static readonly long[] Value={ 137L,383L,547L,1039L,1367L,1531L,1613L,1777L,2269L,2351L,2843L,3089L,3253L,3499L,3581L,4073L,4483L,4729L,5303L,6287L,6451L,6779L,7517L,7681L,7927L,8009L,8419L,8501L,8747L,9157L,9239L,9403L,9649L,10141L,10223L,11617L,11699L,11863L,12109L,12437L,12601L,13093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142211Inst : IEnumerable<long>
{
public static readonly long[] Value=A142211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142211.Bytes);
public long this[int i]=>Value[i];

public static A142211Inst Instance=new A142211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142212
{
public static readonly long[] Value={ 97L,179L,1163L,1327L,1409L,1901L,2311L,2393L,2557L,2803L,3049L,3541L,3623L,5099L,5591L,6247L,6329L,7477L,7559L,7723L,8297L,8461L,8543L,8707L,9199L,9281L,10429L,11003L,11987L,12479L,12889L,13217L,13381L,13463L,13627L,13709L,13873L,14447L,14939L,15349L,15923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142212Inst : IEnumerable<long>
{
public static readonly long[] Value=A142212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142212.Bytes);
public long this[int i]=>Value[i];

public static A142212Inst Instance=new A142212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142213
{
public static readonly long[] Value={ 139L,467L,631L,877L,1123L,1451L,1697L,1861L,2927L,3583L,3911L,4157L,4567L,4649L,4813L,5059L,5387L,5879L,6043L,6781L,6863L,7027L,7109L,8011L,8093L,8831L,9241L,9323L,9733L,10061L,10799L,11701L,11783L,13177L,13259L,13669L,13751L,13997L,14243L,14407L,14489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142213Inst : IEnumerable<long>
{
public static readonly long[] Value=A142213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142213.Bytes);
public long this[int i]=>Value[i];

public static A142213Inst Instance=new A142213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142214
{
public static readonly long[] Value={ 17L,181L,263L,509L,673L,919L,1493L,1657L,2477L,2887L,2969L,3461L,4363L,4691L,4937L,5101L,5347L,5839L,6577L,6659L,6823L,7069L,7151L,7561L,7643L,8053L,8627L,9283L,9857L,10103L,10267L,10513L,11087L,11251L,11497L,11579L,11743L,12071L,12809L,12973L,13219L,13711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142214Inst : IEnumerable<long>
{
public static readonly long[] Value=A142214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142214.Bytes);
public long this[int i]=>Value[i];

public static A142214Inst Instance=new A142214Inst();

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