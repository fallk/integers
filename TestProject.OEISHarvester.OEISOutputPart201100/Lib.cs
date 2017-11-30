using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A274169
{
public static readonly long[] Value={ 1L,7L,9L,3L,7L,4L,0L,7L,8L,7L,3L,4L,0L,1L,7L,1L,8L,1L,9L,6L,1L,9L,8L,9L,5L,8L,7L,3L,1L,8L,3L,1L,6L,4L,9L,8L,4L,5L,9L,6L,8L,1L,6L,0L,1L,7L,5L,8L,9L,1L,5L,6L,1L,3L,1L,5L,7L,3L,7L,0L,4L,2L,1L,6L,0L,2L,4L,8L,3L,7L,6L,0L,8L,1L,1L,6L,4L,5L,7L,2L,8L,8L,0L,1L,3L,0L,9L,4L,1L,4L,1L,1L,2L,4L,3L,8L,0L,0L,4L,6L,0L,5L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274169Inst : IEnumerable<long>
{
public static readonly long[] Value=A274169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274169.Bytes);
public long this[int i]=>Value[i];

public static A274169Inst Instance=new A274169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274170
{
public static readonly long[] Value={ 2L,4L,6L,8L,14L,16L,20L,26L,30L,32L,62L,64L,72L,84L,106L,118L,126L,128L,164L,218L,254L,256L,272L,340L,426L,494L,510L,512L,584L,950L,1022L,1024L,1056L,1160L,1316L,1364L,1706L,1754L,1910L,2014L,2046L,2048L,2708L,3434L,4094L,4096L,4160L,4368L,4680L,5284L,5460L,6826L,7002L,7606L,7918L,8126L,8190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274170Inst : IEnumerable<long>
{
public static readonly long[] Value=A274170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274170.Bytes);
public long this[int i]=>Value[i];

public static A274170Inst Instance=new A274170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274171
{
public static readonly long[] Value={ 1L,0L,0L,2L,8L,128L,171200L,7447587840L,5056994653507584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274171Inst : IEnumerable<long>
{
public static readonly long[] Value=A274171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274171.Bytes);
public long this[int i]=>Value[i];

public static A274171Inst Instance=new A274171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274172
{
public static readonly long[] Value={ 77L,91L,119L,133L,143L,161L,187L,203L,209L,217L,221L,247L,253L,259L,287L,299L,301L,319L,323L,329L,341L,343L,371L,377L,391L,403L,407L,413L,427L,437L,451L,469L,473L,481L,493L,497L,511L,517L,527L,533L,539L,551L,553L,559L,581L,583L,589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274172Inst : IEnumerable<long>
{
public static readonly long[] Value=A274172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274172.Bytes);
public long this[int i]=>Value[i];

public static A274172Inst Instance=new A274172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274173
{
public static readonly long[] Value={ 609076L,9745216L,28998521L,36924641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274173Inst : IEnumerable<long>
{
public static readonly long[] Value=A274173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274173.Bytes);
public long this[int i]=>Value[i];

public static A274173Inst Instance=new A274173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274174
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,12L,22L,36L,60L,97L,162L,254L,406L,628L,974L,1514L,2305L,3492L,5254L,7842L,11598L,17292L,25294L,37090L,53866L,78113L,112224L,161092L,230788L,328352L,466040L,658846L,928132L,1302290L,1821770L,2537156L,3536445L,4897310L,6777806L,9341456L,12858960L,17625970L,24133832L,32910898L,44813228L,60922160L,82569722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274174Inst : IEnumerable<long>
{
public static readonly long[] Value=A274174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274174.Bytes);
public long this[int i]=>Value[i];

public static A274174Inst Instance=new A274174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274175
{
public static readonly long[] Value={ 133L,1065L,141373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274175Inst : IEnumerable<long>
{
public static readonly long[] Value=A274175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274175.Bytes);
public long this[int i]=>Value[i];

public static A274175Inst Instance=new A274175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274176
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,3L,4L,3L,6L,5L,6L,4L,4L,5L,7L,4L,8L,7L,8L,6L,6L,7L,9L,5L,7L,5L,10L,6L,10L,8L,11L,5L,10L,9L,10L,8L,8L,9L,11L,7L,9L,7L,12L,8L,12L,10L,13L,6L,11L,8L,10L,6L,10L,11L,9L,7L,11L,11L,12L,9L,14L,12L,16L,6L,12L,11L,12L,10L,10L,11L,13L,9L,11L,9L,14L,10L,14L,12L,15L,8L,13L,10L,12L,8L,12L,13L,11L,9L,13L,13L,14L,11L,16L,14L,18L,7L,16L,12L,14L,9L,12L,11L,11L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274176Inst : IEnumerable<long>
{
public static readonly long[] Value=A274176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274176.Bytes);
public long this[int i]=>Value[i];

public static A274176Inst Instance=new A274176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274177
{
public static readonly long[] Value={ 2L,0L,11L,21L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274177Inst : IEnumerable<long>
{
public static readonly long[] Value=A274177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274177.Bytes);
public long this[int i]=>Value[i];

public static A274177Inst Instance=new A274177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274178
{
public static readonly long[] Value={ 21L,25L,28L,32L,33L,37L,38L,42L,45L,51L,52L,53L,59L,60L,66L,69L,73L,77L,81L,83L,84L,89L,90L,91L,96L,98L,101L,105L,107L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274178Inst : IEnumerable<long>
{
public static readonly long[] Value=A274178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274178.Bytes);
public long this[int i]=>Value[i];

public static A274178Inst Instance=new A274178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274179
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274179Inst : IEnumerable<long>
{
public static readonly long[] Value=A274179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274179.Bytes);
public long this[int i]=>Value[i];

public static A274179Inst Instance=new A274179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274212
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,15L,17L,25L,27L,29L,33L,41L,45L,51L,55L,59L,71L,75L,81L,85L,87L,99L,101L,107L,121L,123L,125L,135L,137L,145L,149L,153L,165L,177L,179L,187L,191L,197L,205L,213L,225L,227L,239L,243L,255L,261L,269L,275L,281L,289L,295L,297L,303L,311L,319L,321L,347L,355L,363L,369L,375L,405L,411L,419L,425L,431L,435L,447L,451L,459L,461L,493L,495L,505L,521L,531L,535L,537L,561L,569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274212Inst : IEnumerable<long>
{
public static readonly long[] Value=A274212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274212.Bytes);
public long this[int i]=>Value[i];

public static A274212Inst Instance=new A274212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274213
{
public static readonly long[] Value={ 1L,2L,3L,6L,6L,6L,4L,5L,6L,9L,9L,9L,9L,9L,9L,7L,8L,9L,12L,12L,12L,12L,12L,12L,12L,12L,12L,10L,11L,12L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,13L,14L,15L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,16L,17L,18L,21L,21L,21L,21L,21L,21L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274213Inst : IEnumerable<long>
{
public static readonly long[] Value=A274213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274213.Bytes);
public long this[int i]=>Value[i];

public static A274213Inst Instance=new A274213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274214
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,9L,11L,14L,16L,26L,54L,74L,111L,130L,152L,253L,345L,607L,686L,1590L,2711L,5462L,7021L,8681L,11044L,18132L,24072L,25211L,44332L,52792L,85881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274214Inst : IEnumerable<long>
{
public static readonly long[] Value=A274214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274214.Bytes);
public long this[int i]=>Value[i];

public static A274214Inst Instance=new A274214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274215
{
public static readonly long[] Value={ 4L,6L,46L,58L,184L,336L,29274L,98928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274215Inst : IEnumerable<long>
{
public static readonly long[] Value=A274215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274215.Bytes);
public long this[int i]=>Value[i];

public static A274215Inst Instance=new A274215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274216
{
public static readonly BigInteger[] Value={ 1L,11L,1L,11L,1L,11L,10001L,110011L,1L,11L,10001L,110011L,100000001L,1100000011L,1000100010001L,11001100110011L,1L,11L,10001L,110011L,100000001L,1100000011L,1000100010001L,11001100110011L,10000000000000001L,110000000000000011L,BigInteger.Parse("100010000000000010001") };
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
public class A274216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274216Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274216.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274216.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274216Inst Instance=new A274216Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274217
{
public static readonly long[] Value={ 0L,4L,12L,30L,72L,166L,376L,837L,1844L,4025L,8723L,18789L,40263L,85892L,182515L,386488L,815890L,1717604L,3606854L,7556995L,15800562L,32974263L,68694801L,142882147L,296749381L,615468930L,1274878193L,2637637046L,5451035408L,11253593442L,23210232132L,47826554753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274217Inst : IEnumerable<long>
{
public static readonly long[] Value=A274217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274217.Bytes);
public long this[int i]=>Value[i];

public static A274217Inst Instance=new A274217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274218
{
public static readonly long[] Value={ 6L,33L,87L,249L,303L,519L,573L,681L,843L,951L,1059L,1329L,1383L,1923L,1977L,2463L,2733L,2787L,2949L,3057L,3273L,3327L,3543L,3651L,3867L,3921L,4083L,4353L,4677L,5163L,5433L,5703L,5919L,6081L,6243L,6297L,6621L,6891L,7053L,7323L,7377L,7647L,7971L,8079L,8133L,8187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274218Inst : IEnumerable<long>
{
public static readonly long[] Value=A274218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274218.Bytes);
public long this[int i]=>Value[i];

public static A274218Inst Instance=new A274218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274219
{
public static readonly long[] Value={ 1L,64L,729L,1000L,1728L,4096L,13456L,15625L,27000L,46656L,59319L,64000L,110592L,117649L,148877L,262144L,531441L,729000L,777924L,861184L,1000000L,1259712L,1537600L,1728000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274219Inst : IEnumerable<long>
{
public static readonly long[] Value=A274219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274219.Bytes);
public long this[int i]=>Value[i];

public static A274219Inst Instance=new A274219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274220
{
public static readonly long[] Value={ 3L,-4L,10L,-25L,66L,-179L,493L,-1369L,3818L,-10672L,29865L,-83626L,234237L,-656205L,1838483L,-5151080L,14432666L,-40438941L,113306686L,-317477255L,889550021L,-2492461633L,6983719214L,-19567941936L,54828148469L,-153625048854L,430447808073L,-1206087937261L,3379383275971L,-9468821484028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274220Inst : IEnumerable<long>
{
public static readonly long[] Value=A274220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274220.Bytes);
public long this[int i]=>Value[i];

public static A274220Inst Instance=new A274220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274221
{
public static readonly long[] Value={ 0L,0L,1L,4L,6L,12L,16L,25L,30L,42L,49L,64L,72L,90L,100L,121L,132L,156L,169L,196L,210L,240L,256L,289L,306L,342L,361L,400L,420L,462L,484L,529L,552L,600L,625L,676L,702L,756L,784L,841L,870L,930L,961L,1024L,1056L,1122L,1156L,1225L,1260L,1332L,1369L,1444L,1482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274221Inst : IEnumerable<long>
{
public static readonly long[] Value=A274221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274221.Bytes);
public long this[int i]=>Value[i];

public static A274221Inst Instance=new A274221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274222
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,12L,13L,16L,17L,19L,23L,25L,27L,29L,30L,31L,32L,36L,37L,41L,43L,47L,48L,49L,53L,56L,59L,61L,64L,67L,71L,73L,79L,80L,81L,83L,89L,97L,101L,103L,107L,108L,109L,113L,121L,125L,127L,128L,131L,137L,139L,144L,149L,151L,157L,163L,167L,169L,173L,179L,181L,191L,192L,193L,197L,199L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274222Inst : IEnumerable<long>
{
public static readonly long[] Value=A274222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274222.Bytes);
public long this[int i]=>Value[i];

public static A274222Inst Instance=new A274222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274223
{
public static readonly long[] Value={ 1L,2L,12L,32400L,71280L,5864400L,34574400L,203332046400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274223Inst : IEnumerable<long>
{
public static readonly long[] Value=A274223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274223.Bytes);
public long this[int i]=>Value[i];

public static A274223Inst Instance=new A274223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274224
{
public static readonly long[] Value={ 1L,3L,4L,12L,16L,48L,68L,204L,256L,768L,1088L,3264L,4112L,12336L,17476L,52428L,65536L,196608L,278528L,835584L,1052672L,3158016L,4473856L,13421568L,16777472L,50332416L,71304256L,213912768L,269488144L,808464432L,1145324612L,3435973836L,4294967296L,12884901888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274224Inst : IEnumerable<long>
{
public static readonly long[] Value=A274224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274224.Bytes);
public long this[int i]=>Value[i];

public static A274224Inst Instance=new A274224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274225
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,3L,1L,3L,2L,1L,2L,1L,3L,1L,3L,2L,1L,3L,2L,3L,2L,2L,1L,2L,1L,2L,7L,2L,3L,1L,5L,1L,1L,3L,2L,1L,3L,1L,5L,1L,2L,1L,1L,3L,2L,1L,2L,3L,1L,5L,1L,1L,3L,1L,3L,2L,1L,5L,7L,2L,1L,2L,7L,3L,5L,1L,2L,3L,4L,1L,3L,2L,3L,2L,1L,4L,5L,1L,5L,1L,3L,2L,3L,2L,2L,1L,1L,3L,2L,1L,2L,2L,1L,6L,1L,3L,3L,5L,1L,3L,1L,3L,5L,1L,3L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274225Inst : IEnumerable<long>
{
public static readonly long[] Value=A274225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274225.Bytes);
public long this[int i]=>Value[i];

public static A274225Inst Instance=new A274225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274226
{
public static readonly long[] Value={ 14L,21L,26L,29L,30L,35L,42L,45L,46L,49L,50L,53L,56L,61L,65L,70L,78L,84L,91L,93L,104L,106L,109L,115L,116L,120L,133L,140L,142L,145L,157L,168L,169L,180L,184L,190L,196L,200L,202L,205L,212L,224L,235L,244L,253L,260L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274226Inst : IEnumerable<long>
{
public static readonly long[] Value=A274226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274226.Bytes);
public long this[int i]=>Value[i];

public static A274226Inst Instance=new A274226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274227
{
public static readonly long[] Value={ 29L,53L,61L,109L,157L,277L,397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274227Inst : IEnumerable<long>
{
public static readonly long[] Value=A274227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274227.Bytes);
public long this[int i]=>Value[i];

public static A274227Inst Instance=new A274227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274260
{
public static readonly long[] Value={ 1L,1L,4L,3L,5L,1L,7L,9L,11L,25L,15L,33L,13L,21L,23L,31L,29L,52L,33L,35L,35L,39L,41L,58L,11L,13L,51L,53L,57L,29L,63L,65L,43L,69L,119L,75L,122L,81L,83L,112L,89L,4L,95L,94L,174L,99L,105L,111L,113L,123L,107L,119L,228L,125L,223L,131L,126L,135L,201L,29L,141L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274260Inst : IEnumerable<long>
{
public static readonly long[] Value=A274260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274260.Bytes);
public long this[int i]=>Value[i];

public static A274260Inst Instance=new A274260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274261
{
public static readonly long[] Value={ 1L,2L,4L,6L,11L,14L,19L,37L,38L,53L,50L,57L,80L,81L,99L,125L,131L,213L,156L,330L,161L,220L,173L,207L,244L,225L,312L,337L,234L,293L,462L,471L,434L,535L,349L,458L,470L,489L,477L,413L,527L,474L,619L,539L,554L,666L,743L,690L,1295L,740L,627L,617L,706L,911L,755L,867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274261Inst : IEnumerable<long>
{
public static readonly long[] Value=A274261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274261.Bytes);
public long this[int i]=>Value[i];

public static A274261Inst Instance=new A274261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274262
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,12L,18L,20L,24L,20L,44L,24L,36L,48L,54L,32L,76L,36L,88L,72L,60L,44L,156L,72L,72L,100L,132L,56L,208L,60L,162L,120L,96L,144L,316L,72L,108L,144L,312L,80L,312L,84L,220L,304L,132L,92L,540L,156L,280L,192L,264L,104L,460L,240L,468L,216L,168L,116L,116L,120L,180L,456L,486L,288L,520L,132L,352L,264L,624L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274262Inst : IEnumerable<long>
{
public static readonly long[] Value=A274262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274262.Bytes);
public long this[int i]=>Value[i];

public static A274262Inst Instance=new A274262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274263
{
public static readonly long[] Value={ 2L,1L,2L,0L,2L,0L,2L,1L,0L,3L,0L,0L,2L,1L,1L,0L,3L,0L,0L,3L,0L,1L,1L,0L,0L,2L,0L,2L,3L,0L,1L,0L,5L,0L,3L,1L,0L,1L,1L,0L,5L,0L,2L,0L,6L,1L,0L,0L,2L,1L,0L,5L,0L,1L,1L,0L,3L,0L,0L,5L,1L,0L,0L,2L,3L,0L,1L,0L,2L,1L,1L,0L,1L,0L,1L,1L,0L,2L,1L,0L,5L,0L,3L,0L,1L,1L,0L,0L,2L,3L,0L,0L,2L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274263Inst : IEnumerable<long>
{
public static readonly long[] Value=A274263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274263.Bytes);
public long this[int i]=>Value[i];

public static A274263Inst Instance=new A274263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274264
{
public static readonly long[] Value={ 3L,33L,308L,3050L,30405L,303979L,3039648L,30396356L,303963597L,3039635407L,30396354916L,303963551200L,3039635509025L,30396355093247L,303963550927371L,3039635509273730L,30396355092701463L,303963550927001730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274264Inst : IEnumerable<long>
{
public static readonly long[] Value=A274264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274264.Bytes);
public long this[int i]=>Value[i];

public static A274264Inst Instance=new A274264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274265
{
public static readonly BigInteger[] Value={ 1L,5L,64L,1331L,38416L,1419857L,64000000L,3404825447L,208827064576L,14507145975869L,1125899906842624L,96549157373046875L,9065737908494995456L,BigInteger.Parse("925103102315013629321"),BigInteger.Parse("101938319743841411792896"),BigInteger.Parse("12063348350820368238715343"),BigInteger.Parse("1525878906250000000000000000") };
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
public class A274265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274265Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274265.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274265.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274265Inst Instance=new A274265Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274266
{
public static readonly BigInteger[] Value={ 1L,5L,11L,6L,-6L,12L,-36L,144L,-720L,4320L,-30240L,241920L,-2177280L,21772800L,-239500800L,2874009600L,-37362124800L,523069747200L,-7846046208000L,125536739328000L,-2134124568576000L,38414242234368000L,-729870602452992000L,14597412049059840000UL };
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
public class A274266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274266Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274266.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274266.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274266Inst Instance=new A274266Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274267
{
public static readonly BigInteger[] Value={ 1L,7L,121L,3375L,130321L,6436343L,387420489L,27512614111L,2251875390625L,208728361158759L,21611482313284249L,2472159215084012303L,BigInteger.Parse("309629344375621415601"),BigInteger.Parse("42141982597572021484375"),BigInteger.Parse("6193386212891813387462761"),BigInteger.Parse("977480813971145474830595007"),BigInteger.Parse("164890958756244164895763202881") };
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
public class A274267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274267Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274267.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274267.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274267Inst Instance=new A274267Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274268
{
public static readonly BigInteger[] Value={ 1L,7L,26L,50L,24L,-24L,48L,-144L,576L,-2880L,17280L,-120960L,967680L,-8709120L,87091200L,-958003200L,11496038400L,-149448499200L,2092278988800L,-31384184832000L,502146957312000L,-8536498274304000L,153656968937472000L,-2919482409811968000L,BigInteger.Parse("58389648196239360000") };
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
public class A274268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274268Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274268.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274268.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274268Inst Instance=new A274268Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274269
{
public static readonly BigInteger[] Value={ 1L,9L,196L,6859L,331776L,20511149L,1544804416L,137231006679L,14048223625216L,1628413597910449L,210832519264920576L,BigInteger.Parse("30155888444737842659"),BigInteger.Parse("4722366482869645213696"),BigInteger.Parse("803596764671634487466709"),BigInteger.Parse("147653612273582215982104576"),BigInteger.Parse("29134419507545592909032289199") };
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
public class A274269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274269Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274269.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274269.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274269Inst Instance=new A274269Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274270
{
public static readonly BigInteger[] Value={ 1L,9L,47L,154L,274L,120L,-120L,240L,-720L,2880L,-14400L,86400L,-604800L,4838400L,-43545600L,435456000L,-4790016000L,57480192000L,-747242496000L,10461394944000L,-156920924160000L,2510734786560000L,-42682491371520000L,768284844687360000L,BigInteger.Parse("-14597412049059840000") };
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
public class A274270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274270.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274270Inst Instance=new A274270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274271
{
public static readonly BigInteger[] Value={ 1L,3L,18L,225L,4410L,105903L,2746098L,73140525L,1965803130L,52995903003L,1430162760978L,38607856205625L,1042353276205050L,28143008896575303L,759856474192364658L,BigInteger.Parse("20516081909157771525"),BigInteger.Parse("553933825501236490170"),BigInteger.Parse("14956209814120079146803"),BigInteger.Parse("403817633711525094117138") };
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
public class A274271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274271.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274271Inst Instance=new A274271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274272
{
public static readonly BigInteger[] Value={ 1L,6L,185L,15246L,1736385L,212946246L,26516391385L,3312004971246L,413937039016385L,51740540399346246L,6467527813385891385L,BigInteger.Parse("808439983261977471246"),BigInteger.Parse("101054973072475964016385"),BigInteger.Parse("12631871013177766274346246"),BigInteger.Parse("1578983861125177809948391385") };
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
public class A274272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274272Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274272.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274272.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274272Inst Instance=new A274272Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274273
{
public static readonly BigInteger[] Value={ 1L,2L,8L,50L,392L,3602L,37928L,451250L,5995592L,88073042L,1418137448L,24846302450L,470675213192L,9587626273682L,209000505036968L,4855088300025650L,119739457665173192L,3124793129198573522L,BigInteger.Parse("86030517992814720488"),BigInteger.Parse("2492084621605727380850"),BigInteger.Parse("75769449406015305475592") };
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
public class A274273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274273.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274273Inst Instance=new A274273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274274
{
public static readonly long[] Value={ 1L,2L,2L,1L,1L,2L,1L,0L,2L,3L,3L,1L,1L,2L,1L,0L,2L,3L,3L,1L,1L,2L,0L,0L,1L,3L,4L,2L,2L,2L,1L,1L,2L,3L,2L,2L,2L,4L,1L,0L,3L,2L,2L,1L,2L,3L,1L,1L,1L,2L,3L,2L,3L,4L,1L,0L,1L,1L,3L,2L,1L,3L,1L,1L,3L,4L,4L,1L,3L,3L,0L,0L,4L,5L,3L,1L,2L,3L,0L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274274Inst : IEnumerable<long>
{
public static readonly long[] Value=A274274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274274.Bytes);
public long this[int i]=>Value[i];

public static A274274Inst Instance=new A274274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274275
{
public static readonly BigInteger[] Value={ 1L,2L,6L,40L,400L,4656L,62944L,1046144L,20274048L,438238720L,10529132416L,280439144448L,8185848206848L,259202608222208L,8855252721592320L,324989707586830336L,12748521382531956736UL,BigInteger.Parse("532098814401540587520"),BigInteger.Parse("23547710868033300004864"),BigInteger.Parse("1101540715832518509854720"),BigInteger.Parse("54307901369414002580422656"),BigInteger.Parse("2814303585179538846791237632"),BigInteger.Parse("152935335939643406489642008576"),BigInteger.Parse("8696644113583584719506275041280"),BigInteger.Parse("516469893784923819203984490496000") };
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
public class A274275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274275Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274275.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274275.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274275Inst Instance=new A274275Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274308
{
public static readonly BigInteger[] Value={ 1L,3L,37L,997L,44121L,2882071L,260415373L,31088448777L,4737782756017L,897380763253291L,206773800208348341L,BigInteger.Parse("56951114596754707693"),BigInteger.Parse("18476855531112777659017"),BigInteger.Parse("6973886287904020598308287"),BigInteger.Parse("3029760395576715276955711261"),BigInteger.Parse("1501087423496953812426438796561") };
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
public class A274308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274308.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274308Inst Instance=new A274308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274309
{
public static readonly long[] Value={ 2L,1L,3L,3L,1L,1L,3L,5L,3L,1L,1L,3L,3L,1L,2L,3L,2L,1L,3L,3L,1L,1L,3L,5L,3L,1L,1L,3L,3L,1L,2L,3L,2L,1L,3L,3L,1L,1L,3L,5L,3L,1L,1L,3L,3L,1L,2L,3L,2L,1L,3L,3L,1L,1L,3L,5L,3L,1L,1L,3L,3L,1L,2L,3L,2L,1L,3L,3L,1L,1L,3L,5L,3L,1L,1L,3L,3L,1L,2L,3L,2L,1L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274309Inst : IEnumerable<long>
{
public static readonly long[] Value=A274309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274309.Bytes);
public long this[int i]=>Value[i];

public static A274309Inst Instance=new A274309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274310
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,6L,11L,6L,1L,1L,10L,28L,26L,9L,1L,1L,14L,61L,86L,50L,12L,1L,1L,22L,136L,276L,236L,92L,16L,1L,1L,30L,275L,770L,927L,530L,150L,20L,1L,1L,46L,580L,2200L,3551L,2782L,1130L,240L,25L,1L,1L,62L,1141L,5710L,12160L,12632L,6987L,2130L,355L,30L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274310Inst : IEnumerable<long>
{
public static readonly long[] Value=A274310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274310.Bytes);
public long this[int i]=>Value[i];

public static A274310Inst Instance=new A274310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274311
{
public static readonly long[] Value={ 0L,0L,9L,75L,331L,1055L,2745L,6209L,12670L,23886L,42285L,71115L,114609L,178165L,268541L,394065L,564860L,793084L,1093185L,1482171L,1979895L,2609355L,3397009L,4373105L,5572026L,7032650L,8798725L,10919259L,13448925L,16448481L,19985205L,24133345L,28974584L,34598520L,41103161L,48595435L,57191715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274311Inst : IEnumerable<long>
{
public static readonly long[] Value=A274311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274311.Bytes);
public long this[int i]=>Value[i];

public static A274311Inst Instance=new A274311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274312
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,6L,7L,10L,13L,18L,23L,31L,40L,54L,69L,91L,118L,155L,199L,260L,334L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274312Inst : IEnumerable<long>
{
public static readonly long[] Value=A274312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274312.Bytes);
public long this[int i]=>Value[i];

public static A274312Inst Instance=new A274312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274313
{
public static readonly long[] Value={ 1L,2L,4L,10L,22L,46L,96L,198L,406L,826L,1668L,3362L,6770L,13590L,27248L,54614L,109378L,218946L,438180L,876738L,1753998L,3508726L,7018368L,14038006L,28077846L,56157954L,112318900L,224642090L,449289666L,898586438L,1797182704L,3594378014L,7188772666L,14377567834L,28755164100L,57510365698L,115020782350L,230041628622L,460083340304L,920166792942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274313Inst : IEnumerable<long>
{
public static readonly long[] Value=A274313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274313.Bytes);
public long this[int i]=>Value[i];

public static A274313Inst Instance=new A274313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274314
{
public static readonly BigInteger[] Value={ 1L,1L,3L,126L,11340L,5940840L,12076523928L,95052257647200L,3153668941285723200L,BigInteger.Parse("406198470650573931200640"),BigInteger.Parse("215366179177149634500004545792"),BigInteger.Parse("447870507819487666185959047316144640"),BigInteger.Parse("3770394197251690930118967532374966498493440"),BigInteger.Parse("126205342254129164806148123600990735262978861434880"),BigInteger.Parse("16960349752279776751561660450391351891796348875427924676608") };
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
public class A274314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274314Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274314.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274314.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274314Inst Instance=new A274314Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274315
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,5L,10L,11L,13L,8L,14L,18L,7L,20L,19L,9L,12L,24L,26L,23L,25L,29L,16L,15L,35L,31L,38L,40L,37L,39L,41L,17L,43L,42L,47L,46L,45L,52L,27L,21L,22L,51L,58L,53L,60L,50L,56L,62L,64L,63L,67L,66L,68L,73L,72L,59L,74L,28L,77L,76L,70L,71L,30L,87L,32L,83L,84L,33L,34L,89L,88L,92L,91L,36L,98L,93L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274315Inst : IEnumerable<long>
{
public static readonly long[] Value=A274315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274315.Bytes);
public long this[int i]=>Value[i];

public static A274315Inst Instance=new A274315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274316
{
public static readonly long[] Value={ 2L,4L,5L,1L,8L,3L,6L,12L,14L,16L,7L,15L,17L,9L,22L,21L,11L,25L,10L,27L,28L,30L,32L,34L,13L,37L,39L,36L,18L,19L,43L,42L,38L,46L,40L,44L,51L,53L,23L,20L,56L,50L,49L,54L,59L,58L,52L,24L,55L,62L,26L,63L,72L,74L,71L,65L,73L,76L,78L,29L,31L,79L,86L,83L,84L,33L,35L,90L,88L,93L,91L,95L,99L,97L,100L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274316Inst : IEnumerable<long>
{
public static readonly long[] Value=A274316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274316.Bytes);
public long this[int i]=>Value[i];

public static A274316Inst Instance=new A274316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274317
{
public static readonly long[] Value={ 3L,1L,6L,2L,9L,7L,5L,4L,15L,17L,12L,19L,18L,21L,8L,10L,23L,22L,11L,14L,13L,31L,33L,35L,36L,16L,34L,41L,43L,42L,38L,40L,45L,47L,27L,20L,52L,49L,54L,50L,57L,46L,59L,58L,24L,55L,63L,56L,26L,65L,25L,71L,73L,67L,28L,70L,75L,29L,32L,30L,72L,85L,80L,82L,86L,91L,89L,87L,92L,90L,94L,93L,37L,95L,39L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274317Inst : IEnumerable<long>
{
public static readonly long[] Value=A274317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274317.Bytes);
public long this[int i]=>Value[i];

public static A274317Inst Instance=new A274317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274318
{
public static readonly long[] Value={ 1L,4L,6L,5L,2L,10L,8L,3L,7L,9L,16L,26L,29L,22L,20L,23L,28L,38L,12L,32L,46L,13L,14L,11L,15L,56L,35L,58L,47L,48L,24L,18L,21L,69L,17L,52L,41L,19L,82L,83L,70L,25L,30L,62L,93L,27L,65L,106L,78L,102L,37L,110L,112L,76L,116L,119L,92L,31L,34L,49L,39L,101L,33L,36L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274318Inst : IEnumerable<long>
{
public static readonly long[] Value=A274318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274318.Bytes);
public long this[int i]=>Value[i];

public static A274318Inst Instance=new A274318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274319
{
public static readonly long[] Value={ 0L,6L,15L,24L,33L,39L,42L,48L,51L,57L,60L,66L,75L,84L,93L,99L,105L,114L,123L,129L,132L,138L,141L,147L,150L,156L,165L,174L,183L,189L,192L,198L,204L,213L,219L,222L,228L,231L,237L,240L,246L,255L,264L,273L,279L,282L,288L,291L,297L,303L,309L,312L,318L,321L,327L,330L,336L,345L,354L,363L,369L,372L,378L,381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274319Inst : IEnumerable<long>
{
public static readonly long[] Value=A274319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274319.Bytes);
public long this[int i]=>Value[i];

public static A274319Inst Instance=new A274319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274320
{
public static readonly long[] Value={ 6L,15L,35L,95L,187L,259L,671L,903L,905L,1273L,1967L,2938L,3161L,4382L,6004L,6005L,9718L,11049L,12371L,14194L,16181L,17285L,20842L,27242L,27257L,31937L,35758L,35767L,50407L,54071L,56345L,59917L,59923L,75898L,86833L,86839L,106999L,116651L,116653L,134027L,134034L,134041L,156138L,171613L,173499L,188170L,194554L,194555L,228122L,253291L,253327L,260374L,302371L,302395L,302396L,346837L,368983L,376262L,376267L,376268L,376270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274320Inst : IEnumerable<long>
{
public static readonly long[] Value=A274320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274320.Bytes);
public long this[int i]=>Value[i];

public static A274320Inst Instance=new A274320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274321
{
public static readonly long[] Value={ 13L,17L,23L,29L,31L,37L,43L,47L,53L,59L,67L,71L,73L,79L,83L,97L,113L,131L,137L,139L,167L,173L,179L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,271L,277L,283L,293L,311L,313L,317L,331L,337L,347L,353L,359L,367L,373L,379L,383L,389L,397L,419L,431L,433L,439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274321Inst : IEnumerable<long>
{
public static readonly long[] Value=A274321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274321.Bytes);
public long this[int i]=>Value[i];

public static A274321Inst Instance=new A274321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274322
{
public static readonly long[] Value={ 1L,1L,5L,23L,101L,377L,1226L,3507L,9027L,21224L,46262L,94512L,182702L,336666L,595085L,1014091L,1673243L,2682685L,4192118L,6401314L,9572962L,14047457L,20260601L,28763703L,40247228L,55567352L,75776769L,102158957L,136267461L,179969238L,235493851L,305487369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274322Inst : IEnumerable<long>
{
public static readonly long[] Value=A274322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274322.Bytes);
public long this[int i]=>Value[i];

public static A274322Inst Instance=new A274322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274323
{
public static readonly long[] Value={ 1L,1L,9L,41L,129L,313L,649L,1201L,2049L,3281L,5001L,7321L,10369L,14281L,19209L,25313L,32769L,41761L,52489L,65161L,80001L,97241L,117129L,139921L,165889L,195313L,228489L,265721L,307329L,353641L,405001L,461761L,524289L,592961L,668169L,750313L,839809L,937081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274323Inst : IEnumerable<long>
{
public static readonly long[] Value=A274323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274323.Bytes);
public long this[int i]=>Value[i];

public static A274323Inst Instance=new A274323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274660
{
public static readonly long[] Value={ 1L,-1L,3L,1L,5L,-1L,7L,1L,-3L,9L,-1L,11L,1L,13L,-1L,3L,-5L,15L,1L,17L,-1L,19L,1L,-3L,-7L,21L,-1L,23L,1L,5L,25L,-1L,3L,-9L,27L,1L,29L,-1L,31L,1L,-3L,-11L,33L,-1L,-5L,7L,35L,1L,37L,-1L,3L,-13L,39L,1L,41L,-1L,43L,1L,-3L,5L,9L,-15L,45L,-1L,47L,1L,-7L,49L,-1L,3L,-17L,51L,1L,53L,-1L,-5L,11L,55L,1L,-3L,-19L,57L,-1L,59L,1L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274660Inst : IEnumerable<long>
{
public static readonly long[] Value=A274660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274660.Bytes);
public long this[int i]=>Value[i];

public static A274660Inst Instance=new A274660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274661
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,0L,1L,1L,-2L,0L,1L,2L,-1L,-2L,0L,1L,-2L,3L,0L,-2L,0L,1L,-4L,2L,3L,0L,-2L,0L,1L,4L,-5L,-1L,3L,0L,-2L,0L,1L,7L,-3L,-6L,0L,3L,0L,-2L,0L,1L,-7L,9L,2L,-6L,0L,3L,0L,-2L,0L,1L,-11L,5L,11L,-1L,-6L,0L,3L,0L,-2L,0L,1L,11L,-15L,-3L,11L,0L,-6L,0L,3L,0L,-2L,0L,1L,17L,-9L,-17L,2L,11L,0L,-6L,0L,3L,0L,-2L,0L,1L,-17L,23L,6L,-18L,-1L,11L,0L,-6L,0L,3L,0L,-2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274661Inst : IEnumerable<long>
{
public static readonly long[] Value=A274661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274661.Bytes);
public long this[int i]=>Value[i];

public static A274661Inst Instance=new A274661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274662
{
public static readonly long[] Value={ 1L,0L,1L,0L,-3L,1L,0L,4L,-5L,1L,0L,-3L,13L,-7L,1L,0L,6L,-25L,26L,-9L,1L,0L,-12L,43L,-70L,43L,-11L,1L,0L,8L,-70L,157L,-147L,64L,-13L,1L,0L,-3L,109L,-315L,408L,-264L,89L,-15L,1L,0L,13L,-155L,582L,-984L,872L,-429L,118L,-17L,1L,0L,-18L,201L,-1001L,2142L,-2464L,1641L,-650L,151L,-19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274662Inst : IEnumerable<long>
{
public static readonly long[] Value=A274662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274662.Bytes);
public long this[int i]=>Value[i];

public static A274662Inst Instance=new A274662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274663
{
public static readonly long[] Value={ 3L,-4L,38L,-193L,1186L,-6829L,40169L,-234609L,1373466L,-8034394L,47011093L,-275049240L,1609284589L,-9415668903L,55089756851L,-322322100748L,1885860059450L,-11033893589177L,64557712909910L,-377717821061137L,2209972232664381L,-12930227249420121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274663Inst : IEnumerable<long>
{
public static readonly long[] Value=A274663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274663.Bytes);
public long this[int i]=>Value[i];

public static A274663Inst Instance=new A274663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274664
{
public static readonly BigInteger[] Value={ 3L,-11L,129L,-1460L,165655L,-187926L,2131986L,-24186985L,274396853L,-3112981337L,35316195134L,-400655674969L,4545364223858L,-51566312967180L,585010243859443L,-6636832570098735L,75293632933556677L,-854192282305658944L,9690652804526376357UL,BigInteger.Parse("-109938656346079219026"),BigInteger.Parse("1247233638742671255770") };
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
public class A274664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274664.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274664Inst Instance=new A274664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274665
{
public static readonly BigInteger[] Value={ 1L,4L,30L,280L,2890L,31584L,358176L,4168560L,49455450L,595480600L,7254787540L,89234708160L,1106335812400L,13808393670400L,173332340911200L,2186551157230560L,27701981424940890L,352297514508697800L,4495418315974868700L,BigInteger.Parse("57535568476437651600"),BigInteger.Parse("738373616359119126540") };
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
public class A274665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274665Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274665.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274665.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274665Inst Instance=new A274665Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274666
{
public static readonly BigInteger[] Value={ 1L,5L,43L,461L,5491L,69395L,910855L,12274925L,168668035L,2352544535L,33204000853L,473179375355L,6797163712639L,98299113206663L,1429765398030943L,20899401842991341L,306819063154144675L,4521526749077118143L,BigInteger.Parse("66858281393757281641"),BigInteger.Parse("991598171159871109391") };
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
public class A274666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274666Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274666.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274666.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274666Inst Instance=new A274666Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274667
{
public static readonly BigInteger[] Value={ 1L,3L,31L,339L,4131L,53013L,705139L,9618003L,133672387L,1884947073L,26889061761L,387207732453L,5619687743151L,82101265925409L,1206262382507451L,17809706204128659L,264074421220475427L,3930338612143125849L,BigInteger.Parse("58692717332813782501"),BigInteger.Parse("879093138034007102289"),BigInteger.Parse("13202346737893575996541") };
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
public class A274667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274667Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274667.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274667.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274667Inst Instance=new A274667Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274668
{
public static readonly BigInteger[] Value={ 1L,7L,109L,2095L,44401L,995647L,23161909L,552919423L,13454515585L,332268466327L,8302478659069L,209447296631503L,5325782947464721L,136330694520639535L,3509805380065157989L,BigInteger.Parse("90806156097601965055"),BigInteger.Parse("2359490223343888886785"),BigInteger.Parse("61541525049445532797735"),BigInteger.Parse("1610570872210945422212365") };
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
public class A274668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274668Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274668.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274668.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274668Inst Instance=new A274668Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274669
{
public static readonly BigInteger[] Value={ 1L,8L,138L,2960L,70090L,1756608L,45678864L,1219013664L,33162009210L,915589703600L,25578044554348L,721420319128704L,20509529725235824L,586986330979489280L,16895932626393943680UL,BigInteger.Parse("488743896405192037440"),BigInteger.Parse("14198840150264907505050"),BigInteger.Parse("414069243091986225102480"),BigInteger.Parse("12115901803035178006468500") };
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
public class A274669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274669.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274669Inst Instance=new A274669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274670
{
public static readonly BigInteger[] Value={ 1L,7L,103L,1891L,38371L,824377L,18379579L,420563731L,9810403267L,232264240957L,5564072675833L,134574852764821L,3280845731941519L,80522277272406613L,1987608338377888483L,BigInteger.Parse("49305191067563987731"),BigInteger.Parse("1228368016027453079587"),BigInteger.Parse("30719511029184435338053"),BigInteger.Parse("770839386237255136597501") };
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
public class A274670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274670Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274670.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274670.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274670Inst Instance=new A274670Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274671
{
public static readonly BigInteger[] Value={ 1L,5L,49L,593L,7921L,111965L,1641865L,24705665L,378931585L,5898329045L,92893693729L,1477015762865L,23671209428881L,381902943661517L,6196712221450009L,101043805539177473L,1654726991239056385L,BigInteger.Parse("27201210101330189477"),BigInteger.Parse("448652354194417534609"),BigInteger.Parse("7422254208909904273553") };
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
public class A274671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274671Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274671.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274671.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274671Inst Instance=new A274671Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274672
{
public static readonly BigInteger[] Value={ 1L,9L,211L,6093L,194211L,6552759L,229425631L,8244126669L,302001325987L,11228376095379L,422418832551981L,16044756006730779L,614293828071090831L,BigInteger.Parse("23677157141279202843"),BigInteger.Parse("917844665558530089591"),BigInteger.Parse("35756691970868828784813"),BigInteger.Parse("1399009670335978828299747"),BigInteger.Parse("54945874078445147692928043") };
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
public class A274672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274672Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274672.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274672.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274672Inst Instance=new A274672Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274673
{
public static readonly BigInteger[] Value={ 1L,7L,127L,2851L,70651L,1853377L,50452459L,1409575699L,40147379587L,1160568048157L,33947097696337L,1002532535965429L,29843356238833879L,894349641410968477L,BigInteger.Parse("26955867982764111427"),BigInteger.Parse("816484373069154316051"),BigInteger.Parse("24838062486275592671587"),BigInteger.Parse("758470289246834941140037"),BigInteger.Parse("23239359305672548933204261") };
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
public class A274673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274673Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274673.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274673.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274673Inst Instance=new A274673Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274674
{
public static readonly long[] Value={ 1L,1L,7L,37L,211L,1351L,8611L,57037L,383587L,2615851L,18052057L,125693107L,882033439L,6229779739L,44246291467L,315774707437L,2263120500067L,16279948902259L,117498622706269L,850541100418807L,6173221388110861L,44912998208539561L,327476893004792197L,2392516335780421627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274674Inst : IEnumerable<long>
{
public static readonly long[] Value=A274674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274674.Bytes);
public long this[int i]=>Value[i];

public static A274674Inst Instance=new A274674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274675
{
public static readonly long[] Value={ 23L,71L,79L,113L,127L,137L,151L,191L,193L,233L,239L,263L,281L,337L,359L,401L,431L,449L,457L,463L,487L,569L,599L,617L,631L,641L,673L,743L,751L,809L,823L,863L,911L,919L,953L,967L,977L,991L,1009L,1031L,1033L,1087L,1103L,1129L,1201L,1289L,1297L,1303L,1327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274675Inst : IEnumerable<long>
{
public static readonly long[] Value=A274675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274675.Bytes);
public long this[int i]=>Value[i];

public static A274675Inst Instance=new A274675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274708
{
public static readonly long[] Value={ 1L,1L,2L,4L,2L,4L,2L,12L,15L,3L,10L,8L,2L,38L,68L,30L,4L,26L,30L,12L,2L,121L,272L,183L,49L,5L,70L,104L,60L,16L,2L,384L,1026L,912L,372L,72L,6L,192L,350L,260L,100L,20L,2L,1214L,3727L,4095L,2220L,650L,99L,7L,534L,1152L,1050L,520L,150L,24L,2L,3822L,13200L,17178L,11600L,4510L,1032L,130L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274708Inst : IEnumerable<long>
{
public static readonly long[] Value=A274708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274708.Bytes);
public long this[int i]=>Value[i];

public static A274708Inst Instance=new A274708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274709
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,2L,3L,1L,10L,15L,5L,5L,9L,5L,1L,35L,63L,35L,7L,14L,28L,20L,7L,1L,126L,252L,180L,63L,9L,42L,90L,75L,35L,9L,1L,462L,990L,825L,385L,99L,11L,132L,297L,275L,154L,54L,11L,1L,1716L,3861L,3575L,2002L,702L,143L,13L,429L,1001L,1001L,637L,273L,77L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274709Inst : IEnumerable<long>
{
public static readonly long[] Value=A274709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274709.Bytes);
public long this[int i]=>Value[i];

public static A274709Inst Instance=new A274709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274710
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,0L,6L,0L,2L,2L,2L,0L,0L,6L,12L,12L,0L,2L,4L,8L,4L,2L,0L,0L,6L,24L,52L,40L,18L,0L,2L,6L,18L,18L,18L,6L,2L,0L,0L,6L,36L,120L,180L,180L,84L,24L,0L,2L,8L,32L,48L,72L,48L,32L,8L,2L,0L,0L,6L,48L,216L,480L,744L,672L,432L,144L,30L,0L,2L,10L,50L,100L,200L,200L,200L,100L,50L,10L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274710Inst : IEnumerable<long>
{
public static readonly long[] Value=A274710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274710.Bytes);
public long this[int i]=>Value[i];

public static A274710Inst Instance=new A274710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274711
{
public static readonly long[] Value={ 0L,2L,6L,34L,282L,3662L,87206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274711Inst : IEnumerable<long>
{
public static readonly long[] Value=A274711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274711.Bytes);
public long this[int i]=>Value[i];

public static A274711Inst Instance=new A274711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274712
{
public static readonly BigInteger[] Value={ 1L,5L,161L,14575L,2671669L,833607138L,397984073059L,270609861663900L,248922595132336125L,BigInteger.Parse("298037055910658382175"),BigInteger.Parse("450755158919281716609746"),BigInteger.Parse("840770855566250627155136090"),BigInteger.Parse("1896671776639253430025972662743"),BigInteger.Parse("5091278095597325836977485757711800"),BigInteger.Parse("16040729445423172146341201903726496024"),BigInteger.Parse("58625927208516621021861960954787323034320"),BigInteger.Parse("246047331971247756894582227572712664877434765"),BigInteger.Parse("1175344062721738572130662103242054758238706829325") };
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
public class A274712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274712Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274712.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274712.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274712Inst Instance=new A274712Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274713
{
public static readonly BigInteger[] Value={ 1L,15L,966L,145750L,40075035L,17505749898L,11143554045652L,9741955019900400L,11201516780955125625UL,BigInteger.Parse("16392038075086211019625"),BigInteger.Parse("29749840488672593296243236"),BigInteger.Parse("65580126734167548918100615020"),BigInteger.Parse("172597131674172062132363512309613"),BigInteger.Parse("534584200037719212882636004559739000"),BigInteger.Parse("1924887533450780657560944228447179522880"),BigInteger.Parse("7973126100358260458973226689851075932667520"),BigInteger.Parse("37645241791600906804871080818625037726247519045") };
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
public class A274713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274713Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274713.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274713.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274713Inst Instance=new A274713Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274714
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,20L,141L,260L,1985L,3887L,124213L,63013L,2072737L,4308063L,72299423L,19110234L,1302089975L,2789327371L,192236392547L,13000018109L,3616336753079L,7889633483913L,138181586307115L,37935218826111L,2673839246416983L,5905195803386319L,209178924613512833L,58019641542960071L,4128415092111144721L,9197893555411205235L,BigInteger.Parse("164237433151443645047"),11474995858629174895UL,BigInteger.Parse("3289139509736729288671"),BigInteger.Parse("7376472520390786310211"),BigInteger.Parse("1060236793997777905833443"),BigInteger.Parse("74507380484700694744045"),BigInteger.Parse("21473133267770763414163167") };
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
public class A274714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274714Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274714.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274714.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274714Inst Instance=new A274714Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274715
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,0L,3L,0L,3L,2L,4L,0L,4L,3L,7L,1L,7L,6L,8L,4L,8L,7L,10L,6L,10L,9L,11L,5L,11L,10L,15L,9L,15L,14L,16L,12L,16L,15L,18L,14L,18L,17L,19L,14L,19L,18L,22L,17L,22L,21L,23L,19L,23L,22L,25L,21L,25L,24L,26L,19L,26L,25L,31L,24L,31L,30L,32L,28L,32L,31L,34L,30L,34L,33L,35L,30L,35L,34L,38L,33L,38L,37L,39L,35L,39L,38L,41L,37L,41L,40L,42L,36L,42L,41L,46L,40L,46L,45L,47L,43L,47L,46L,49L,45L,49L,48L,50L,45L,50L,49L,53L,48L,53L,52L,54L,50L,54L,53L,56L,52L,56L,55L,57L,49L,57L,56L,63L,55L,63L,62L,64L,60L,64L,63L,66L,62L,66L,65L,67L,62L,67L,66L,70L,65L,70L,69L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274715Inst : IEnumerable<long>
{
public static readonly long[] Value=A274715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274715.Bytes);
public long this[int i]=>Value[i];

public static A274715Inst Instance=new A274715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274716
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,1L,4L,0L,7L,3L,8L,1L,10L,4L,11L,0L,15L,7L,16L,3L,18L,8L,19L,1L,22L,10L,23L,4L,25L,11L,26L,0L,31L,15L,32L,7L,34L,16L,35L,3L,38L,18L,39L,8L,41L,19L,42L,1L,46L,22L,47L,10L,49L,23L,50L,4L,53L,25L,54L,11L,56L,26L,57L,0L,63L,31L,64L,15L,66L,32L,67L,7L,70L,34L,71L,16L,73L,35L,74L,3L,78L,38L,79L,18L,81L,39L,82L,8L,85L,41L,86L,19L,88L,42L,89L,1L,94L,46L,95L,22L,97L,47L,98L,10L,101L,49L,102L,23L,104L,50L,105L,4L,109L,53L,110L,25L,112L,54L,113L,11L,116L,56L,117L,26L,119L,57L,120L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274716Inst : IEnumerable<long>
{
public static readonly long[] Value=A274716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274716.Bytes);
public long this[int i]=>Value[i];

public static A274716Inst Instance=new A274716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274717
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,7L,1L,-21L,1L,71L,1L,5L,7L,1095L,1L,-15885L,-21L,18443L,1L,-55841L,71L,324945L,1L,-2649857L,5L,6109987L,7L,-18206579L,1095L,92290439L,1L,-3700779069L,-15885L,5957604211L,-21L,-29227819205L,18443L,88113645133L,1L,-917331711003L,-55841L,2134630503193L,71L,-9943308217037L,324945L,29285764343377L,1L,-616425445539209L,-2649857L,1440419971225759L,5L,-7198783835108021L,6109987L,19846350459729237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274717Inst : IEnumerable<long>
{
public static readonly long[] Value=A274717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274717.Bytes);
public long this[int i]=>Value[i];

public static A274717Inst Instance=new A274717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274718
{
public static readonly long[] Value={ -1L,0L,0L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,2L,2L,2L,0L,2L,0L,2L,1L,0L,0L,2L,1L,3L,2L,0L,0L,1L,0L,1L,3L,0L,1L,1L,0L,2L,3L,0L,0L,1L,0L,3L,0L,2L,0L,0L,3L,1L,3L,0L,0L,0L,3L,0L,1L,0L,0L,1L,0L,4L,0L,1L,3L,3L,0L,2L,4L,3L,0L,1L,0L,4L,0L,0L,3L,3L,0L,0L,1L,0L,0L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274718Inst : IEnumerable<long>
{
public static readonly long[] Value=A274718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274718.Bytes);
public long this[int i]=>Value[i];

public static A274718Inst Instance=new A274718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274719
{
public static readonly long[] Value={ 1L,0L,-1L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274719Inst : IEnumerable<long>
{
public static readonly long[] Value=A274719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274719.Bytes);
public long this[int i]=>Value[i];

public static A274719Inst Instance=new A274719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274720
{
public static readonly long[] Value={ 9L,21L,25L,27L,39L,45L,49L,55L,57L,63L,75L,81L,99L,105L,111L,117L,121L,125L,135L,147L,153L,155L,165L,169L,171L,175L,183L,189L,195L,201L,203L,205L,207L,219L,225L,231L,237L,243L,245L,253L,261L,273L,275L,279L,285L,289L,291L,297L,301L,305L,309L,315L,325L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274720Inst : IEnumerable<long>
{
public static readonly long[] Value=A274720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274720.Bytes);
public long this[int i]=>Value[i];

public static A274720Inst Instance=new A274720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274721
{
public static readonly long[] Value={ 1L,7L,57L,182L,2057L,1068L,32318L,110443L,280182L,3626068L,23157318L,120813568L,123327057L,1097376068L,11109655182L,49925501068L,407838170807L,355101282318L,3459595983307L,15613890344818L,365855836217682L,110981321985443L,2273204469030182L,9647724486047943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274721Inst : IEnumerable<long>
{
public static readonly long[] Value=A274721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274721.Bytes);
public long this[int i]=>Value[i];

public static A274721Inst Instance=new A274721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274722
{
public static readonly long[] Value={ 1L,6L,68L,1632L,84948L,8960464L,1980677448L,905233056800L,860544738080372L,1705630286322728068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274722Inst : IEnumerable<long>
{
public static readonly long[] Value=A274722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274722.Bytes);
public long this[int i]=>Value[i];

public static A274722Inst Instance=new A274722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274723
{
public static readonly long[] Value={ 5L,24L,68L,260L,1040L,4132L,16524L,66088L,264332L,1057316L,4229264L,16917028L,67668108L,270672424L,1082689676L,4330758692L,17323034768L,69292139044L,277168556172L,1108674224680L,4434696898700L,17738787594788L,70955150379152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274723Inst : IEnumerable<long>
{
public static readonly long[] Value=A274723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274723.Bytes);
public long this[int i]=>Value[i];

public static A274723Inst Instance=new A274723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274756
{
public static readonly BigInteger[] Value={ 0L,945L,13167L,35578242L,495540990L,1338951572595L,18649189618605L,50390103447476100L,701843601611053692L,BigInteger.Parse("1896381151803363988917"),BigInteger.Parse("26413182084381205040235"),BigInteger.Parse("71368408216577696911440390"),BigInteger.Parse("994033693861758668873164410"),BigInteger.Parse("2685878672926303893761783662455") };
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
public class A274756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274756Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274756.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274756.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274756Inst Instance=new A274756Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274757
{
public static readonly long[] Value={ 0L,9L,15L,42L,54L,99L,117L,180L,204L,285L,315L,414L,450L,567L,609L,744L,792L,945L,999L,1170L,1230L,1419L,1485L,1692L,1764L,1989L,2067L,2310L,2394L,2655L,2745L,3024L,3120L,3417L,3519L,3834L,3942L,4275L,4389L,4740L,4860L,5229L,5355L,5742L,5874L,6279L,6417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274757Inst : IEnumerable<long>
{
public static readonly long[] Value=A274757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274757.Bytes);
public long this[int i]=>Value[i];

public static A274757Inst Instance=new A274757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274758
{
public static readonly long[] Value={ 2L,4L,9L,34L,91L,66L,534L,121L,134L,716L,40391L,516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274758Inst : IEnumerable<long>
{
public static readonly long[] Value=A274758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274758.Bytes);
public long this[int i]=>Value[i];

public static A274758Inst Instance=new A274758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274759
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,2L,3L,4L,4L,6L,7L,8L,12L,14L,15L,23L,27L,29L,44L,52L,56L,85L,100L,108L,164L,193L,208L,316L,372L,401L,609L,717L,773L,1174L,1382L,1490L,2263L,2664L,2872L,4362L,5135L,5536L,8408L,9898L,10671L,16207L,19079L,20569L,31240L,36776L,39648L,60217L,70888L,76424L,116072L,136641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274759Inst : IEnumerable<long>
{
public static readonly long[] Value=A274759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274759.Bytes);
public long this[int i]=>Value[i];

public static A274759Inst Instance=new A274759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274760
{
public static readonly BigInteger[] Value={ 1L,1L,10L,478L,68248L,21809656L,13107532816L,13244650672240L,20818058883902848L,BigInteger.Parse("48069880140604832128"),BigInteger.Parse("156044927762422185270016"),BigInteger.Parse("687740710497308621254625536"),BigInteger.Parse("4000181720339888446834235653120"),BigInteger.Parse("29991260979682976913756629498334208") };
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
public class A274760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274760.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274760Inst Instance=new A274760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274761
{
public static readonly long[] Value={ 3L,2L,5L,10L,17L,32L,59L,108L,199L,366L,673L,1238L,2277L,4188L,7703L,14168L,26059L,47930L,88157L,162146L,298233L,548536L,1008915L,1855684L,3413135L,6277734L,11546553L,21237422L,39061709L,71845684L,132144815L,243052208L,447042707L,822239730L,1512334645L,2781617082L,5116191457L,9410143184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274761Inst : IEnumerable<long>
{
public static readonly long[] Value=A274761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274761.Bytes);
public long this[int i]=>Value[i];

public static A274761Inst Instance=new A274761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274762
{
public static readonly BigInteger[] Value={ 1L,2L,19L,5248L,191448941L,1856296498826906L,BigInteger.Parse("7843008902239185171370147"),BigInteger.Parse("21408941228439913825832318523364743824"),BigInteger.Parse("52400635808473472283994952631626957015306076632624953"),BigInteger.Parse("152306240915343870544748050434914720360496623911547121447677238156864610") };
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
public class A274762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274762Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274762.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274762.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274762Inst Instance=new A274762Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274763
{
public static readonly BigInteger[] Value={ 1L,10L,215L,7200L,328090L,18914190L,1318595475L,107813147200L,10112867995550L,1070215246700100L,126122386636230944L,16378717184245442560UL,BigInteger.Parse("2323753119238888095744"),BigInteger.Parse("357594668486650176208896"),BigInteger.Parse("59323244552378855471448064") };
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
public class A274763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274763Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274763.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274763.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274763Inst Instance=new A274763Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274764
{
public static readonly BigInteger[] Value={ 1L,20L,962L,75080L,8133732L,1127589120L,190416834360L,37902843124640L,8686847271179984L,2252403871470920960L,BigInteger.Parse("651771144516905730048"),BigInteger.Parse("208193858907016903262208"),BigInteger.Parse("72758882836839703611703296"),BigInteger.Parse("27613191886304138293279719424"),BigInteger.Parse("11308972154842887758316960743424"),BigInteger.Parse("4971172331379604809443266242019328") };
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
public class A274764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274764Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274764.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274764.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274764Inst Instance=new A274764Inst();

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