using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A182805
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,22L,30L,32L,46L,57L,71L,85L,106L,121L,147L,165L,190L,242L,267L,302L,350L,400L,443L,511L,565L,638L,715L,774L,852L,964L,1038L,1135L,1253L,1372L,1482L,1650L,1785L,1878L,2098L,2234L,2411L,2625L,2819L,2963L,3249L,3393L,3600L,4004L,4181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182805Inst : IEnumerable<long>
{
public static readonly long[] Value=A182805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182805.Bytes);
public long this[int i]=>Value[i];

public static A182805Inst Instance=new A182805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182806
{
public static readonly long[] Value={ 1L,2L,4L,9L,17L,33L,60L,110L,191L,331L,556L,927L,1510L,2438L,3872L,6095L,9465L,14578L,22210L,33581L,50305L,74831L,110441L,161955L,235858L,341474L,491365L,703263L,1001014L,1417812L,1998184L,2803342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182806Inst : IEnumerable<long>
{
public static readonly long[] Value=A182806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182806.Bytes);
public long this[int i]=>Value[i];

public static A182806Inst Instance=new A182806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182807
{
public static readonly long[] Value={ 1L,2L,5L,10L,21L,39L,73L,130L,230L,391L,660L,1087L,1775L,2842L,4510L,7056L,10945L,16779L,25519L,38438L,57480L,85241L,125577L,183669L,267016L,385714L,554102L,791483L,1124831L,1590370L,2238095L,3134927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182807Inst : IEnumerable<long>
{
public static readonly long[] Value=A182807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182807.Bytes);
public long this[int i]=>Value[i];

public static A182807Inst Instance=new A182807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182808
{
public static readonly long[] Value={ 1L,3L,6L,13L,25L,49L,88L,158L,273L,468L,779L,1284L,2075L,3323L,5237L,8182L,12625L,19323L,29269L,44004L,65585L,97084L,142627L,208233L,302008L,435525L,624363L,890414L,1263105L,1783200L,2505329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182808Inst : IEnumerable<long>
{
public static readonly long[] Value=A182808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182808.Bytes);
public long this[int i]=>Value[i];

public static A182808Inst Instance=new A182808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182809
{
public static readonly long[] Value={ 0L,75025L,6557470319842L,14472334024676221L,99194853094755497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182809Inst : IEnumerable<long>
{
public static readonly long[] Value=A182809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182809.Bytes);
public long this[int i]=>Value[i];

public static A182809Inst Instance=new A182809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182810
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,5L,3L,1L,5L,11L,7L,3L,1L,7L,22L,15L,11L,5L,2L,11L,42L,30L,30L,15L,7L,1L,15L,77L,56L,77L,42L,22L,5L,1L,22L,135L,101L,176L,101L,56L,22L,7L,2L,30L,231L,176L,385L,231L,135L,77L,30L,11L,3L,42L,385L,297L,792L,490L,297L,231L,101L,42L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182810Inst : IEnumerable<long>
{
public static readonly long[] Value=A182810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182810.Bytes);
public long this[int i]=>Value[i];

public static A182810Inst Instance=new A182810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182811
{
public static readonly long[] Value={ 64079L,1860498L,4870847L,688846502588399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182811Inst : IEnumerable<long>
{
public static readonly long[] Value=A182811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182811.Bytes);
public long this[int i]=>Value[i];

public static A182811Inst Instance=new A182811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182812
{
public static readonly long[] Value={ 2L,4L,2L,6L,3L,3L,2L,2L,8L,4L,4L,5L,3L,2L,2L,2L,2L,10L,5L,5L,6L,4L,7L,3L,4L,3L,3L,2L,2L,2L,2L,2L,2L,2L,12L,6L,6L,7L,5L,8L,4L,4L,4L,4L,9L,3L,5L,4L,3L,6L,3L,3L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,14L,7L,7L,8L,6L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182812Inst : IEnumerable<long>
{
public static readonly long[] Value=A182812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182812.Bytes);
public long this[int i]=>Value[i];

public static A182812Inst Instance=new A182812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182813
{
public static readonly long[] Value={ 3L,5L,2L,7L,4L,3L,2L,2L,9L,5L,4L,6L,3L,3L,3L,3L,2L,2L,2L,2L,11L,6L,5L,7L,4L,8L,3L,4L,4L,3L,5L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,13L,7L,6L,8L,5L,9L,4L,5L,4L,4L,10L,3L,5L,5L,3L,6L,4L,3L,7L,3L,3L,4L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182813Inst : IEnumerable<long>
{
public static readonly long[] Value=A182813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182813.Bytes);
public long this[int i]=>Value[i];

public static A182813Inst Instance=new A182813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182814
{
public static readonly long[] Value={ 0L,2L,5L,9L,13L,17L,24L,29L,34L,39L,50L,56L,62L,68L,74L,90L,97L,104L,111L,118L,125L,147L,155L,163L,171L,179L,187L,195L,224L,233L,242L,251L,260L,269L,278L,287L,324L,334L,344L,354L,364L,374L,384L,394L,404L,450L,461L,472L,483L,494L,505L,516L,527L,538L,549L,605L,617L,629L,641L,653L,665L,677L,689L,701L,713L,725L,792L,805L,818L,831L,844L,857L,870L,883L,896L,909L,922L,935L,1014L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182814Inst : IEnumerable<long>
{
public static readonly long[] Value=A182814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182814.Bytes);
public long this[int i]=>Value[i];

public static A182814Inst Instance=new A182814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182815
{
public static readonly long[] Value={ 2L,4L,5L,6L,7L,8L,8L,9L,10L,11L,10L,11L,12L,13L,14L,12L,13L,14L,15L,16L,17L,14L,15L,16L,17L,18L,19L,20L,16L,17L,18L,19L,20L,21L,22L,23L,18L,19L,20L,21L,22L,23L,24L,25L,26L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182815Inst : IEnumerable<long>
{
public static readonly long[] Value=A182815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182815.Bytes);
public long this[int i]=>Value[i];

public static A182815Inst Instance=new A182815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182816
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,4L,7L,2L,3L,4L,11L,4L,13L,4L,9L,2L,17L,4L,19L,4L,9L,4L,23L,4L,5L,4L,3L,8L,29L,8L,31L,2L,9L,4L,9L,4L,37L,4L,9L,4L,41L,8L,43L,4L,15L,4L,47L,4L,7L,4L,9L,8L,53L,4L,9L,4L,9L,4L,59L,8L,61L,4L,9L,2L,25L,24L,67L,4L,9L,16L,71L,4L,73L,4L,9L,8L,9L,8L,79L,4L,3L,4L,83L,8L,25L,4L,9L,4L,89L,8L,49L,4L,9L,4L,9L,4L,97L,4L,9L,4L,101L,8L,103L,4L,45L,4L,107L,4L,109L,8L,9L,8L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182816Inst : IEnumerable<long>
{
public static readonly long[] Value=A182816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182816.Bytes);
public long this[int i]=>Value[i];

public static A182816Inst Instance=new A182816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182817
{
public static readonly long[] Value={ 1L,2L,4L,2L,3L,4L,4L,4L,9L,2L,4L,4L,9L,4L,4L,5L,4L,3L,8L,8L,2L,9L,4L,9L,4L,4L,9L,4L,8L,4L,15L,4L,4L,7L,4L,9L,8L,4L,9L,4L,9L,4L,8L,4L,9L,2L,25L,24L,4L,9L,16L,4L,4L,9L,8L,9L,8L,4L,3L,4L,8L,25L,4L,9L,4L,8L,49L,4L,9L,4L,9L,4L,4L,9L,4L,8L,4L,45L,4L,4L,8L,9L,8L,8L,9L,4L,15L,4L,9L,8L,11L,4L,9L,8L,5L,8L,2L,9L,16L,8L,49L,4L,9L,4L,8L,8L,9L,4L,9L,4L,25L,4L,9L,8L,8L,4L,27L,16L,9L,8L,4L,9L,4L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182817Inst : IEnumerable<long>
{
public static readonly long[] Value=A182817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182817.Bytes);
public long this[int i]=>Value[i];

public static A182817Inst Instance=new A182817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182818
{
public static readonly long[] Value={ 1L,3L,8L,19L,41L,83L,161L,299L,538L,942L,1610L,2694L,4427L,7153L,11387L,17884L,27741L,42543L,64565L,97034L,144519L,213432L,312720L,454803L,656835L,942364L,1343596L,1904354L,2684008L,3762667L,5248002L,7284132L,10063319L,13841107L,18956002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182818Inst : IEnumerable<long>
{
public static readonly long[] Value=A182818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182818.Bytes);
public long this[int i]=>Value[i];

public static A182818Inst Instance=new A182818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182819
{
public static readonly long[] Value={ 1L,4L,14L,39L,101L,238L,533L,1131L,2314L,4566L,8763L,16376L,29939L,53612L,94302L,163112L,277953L,467064L,774943L,1270528L,2060331L,3306771L,5256579L,8280649L,12934125L,20040761L,30817437L,47048638L,71339593L,107469716L,160898163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182819Inst : IEnumerable<long>
{
public static readonly long[] Value=A182819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182819.Bytes);
public long this[int i]=>Value[i];

public static A182819Inst Instance=new A182819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182820
{
public static readonly long[] Value={ 1L,7L,32L,119L,385L,1127L,3057L,7799L,18914L,43950L,98434L,213486L,450051L,925013L,1858355L,3657052L,7062245L,13404195L,25038741L,46086250L,83669927L,149970936L,265608168L,465149039L,806022315L,1382822644L,2350101516L,3958427938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182820Inst : IEnumerable<long>
{
public static readonly long[] Value=A182820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182820.Bytes);
public long this[int i]=>Value[i];

public static A182820Inst Instance=new A182820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182821
{
public static readonly long[] Value={ 1L,6L,27L,98L,315L,917L,2486L,6345L,15427L,35965L,80897L,176296L,373652L,772381L,1561130L,3091476L,6008896L,11480887L,21591830L,40016045L,73157052L,132052382L,235535752L,415433365L,725043875L,1252857043L,2144601961L,3638413830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182821Inst : IEnumerable<long>
{
public static readonly long[] Value=A182821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182821.Bytes);
public long this[int i]=>Value[i];

public static A182821Inst Instance=new A182821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182822
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,5L,12L,6L,1L,17L,53L,39L,10L,1L,70L,279L,260L,95L,15L,1L,349L,1668L,1914L,880L,195L,21L,1L,2017L,11341L,15330L,8554L,2380L,357L,28L,1L,13358L,86019L,134317L,87626L,29379L,5530L,602L,36L,1L,99377L,722664L,1277604L,954885L,372771L,84231L,11508L,954L,45L,1L,822041L,6655121L,13149441L,11061480L,4924515L,1292445L,211533L,22020L,1440L,55L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182822Inst : IEnumerable<long>
{
public static readonly long[] Value=A182822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182822.Bytes);
public long this[int i]=>Value[i];

public static A182822Inst Instance=new A182822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182823
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-3L,1L,1L,6L,-6L,1L,-13L,4L,21L,-10L,1L,49L,-129L,-5L,55L,-15L,1L,31L,723L,-624L,-85L,120L,-21L,1L,-1981L,-386L,5271L,-2009L,-385L,231L,-28L,1L,14329L,-34320L,-11978L,25508L,-4809L,-1204L,406L,-36L,1L,-2177L,347913L,-263862L,-112974L,93429L,-8757L,-3066L,666L,-45L,1L,-1138879L,-701387L,3956751L,-1200270L,-657735L,278523L,-10983L,-6810L,1035L,-55L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182823Inst : IEnumerable<long>
{
public static readonly long[] Value=A182823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182823.Bytes);
public long this[int i]=>Value[i];

public static A182823Inst Instance=new A182823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182824
{
public static readonly long[] Value={ 1L,1L,1L,5L,4L,1L,21L,33L,9L,1L,153L,264L,114L,16L,1L,1209L,2769L,1410L,290L,25L,1L,12285L,32076L,20259L,5040L,615L,36L,1L,140589L,432657L,314811L,94899L,14175L,1155L,49L,1L,1871217L,6475536L,5423076L,1886304L,337974L,33936L,1988L,64L,1L,27773361L,108067041L,101497860L,40257540L,8321670L,997542L,72324L,3204L,81L,1L,460041525L,1975940244L,2064827781L,915887520L,214906770L,29709288L,2565738L,141120L,4905L,100L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182824Inst : IEnumerable<long>
{
public static readonly long[] Value=A182824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182824.Bytes);
public long this[int i]=>Value[i];

public static A182824Inst Instance=new A182824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182825
{
public static readonly BigInteger[] Value={ 1L,1L,5L,21L,153L,1209L,12285L,140589L,1871217L,27773361L,460041525L,8363802501L,166064229513L,3570030632169L,82674532955565L,2051044762727709L,54279654050034657L,1526205561241263201L,BigInteger.Parse("45438086217150617445"),BigInteger.Parse("1427921718081647393781"),BigInteger.Parse("47235337785416646609273") };
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
public class A182825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182825Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182825.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A182825.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182825Inst Instance=new A182825Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182826
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,-4L,1L,21L,3L,-9L,1L,-111L,144L,30L,-16L,1L,-345L,-1599L,450L,110L,-25L,1L,14895L,2844L,-9549L,840L,285L,-36L,1L,-143955L,208179L,62181L,-36309L,735L,609L,-49L,1L,-760095L,-3824064L,1147068L,442176L,-103194L,-1344L,1148L,-64L,1L,49774095L,10955169L,-39242556L,2925180L,2008314L,-236250L,-8316L,1980L,-81L,1L,-699437025L,1080622620L,384913701L,-238086000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182826Inst : IEnumerable<long>
{
public static readonly long[] Value=A182826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182826.Bytes);
public long this[int i]=>Value[i];

public static A182826Inst Instance=new A182826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182827
{
public static readonly BigInteger[] Value={ 1L,-1L,-1L,21L,-111L,-345L,14895L,-143955L,-760095L,49774095L,-699437025L,-5221460475L,458621111025L,-8457966542025L,-81662774418225L,8999266227076125L,-205480756062957375L,-2434383666448358625L,BigInteger.Parse("322739182334471277375"),BigInteger.Parse("-8786388514658364484875") };
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
public class A182827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182827Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182827.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A182827.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182827Inst Instance=new A182827Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182828
{
public static readonly long[] Value={ 1L,3L,4L,9L,12L,7L,27L,36L,21L,10L,81L,108L,63L,30L,13L,243L,324L,189L,90L,39L,16L,729L,972L,567L,270L,117L,48L,19L,2187L,2916L,1701L,810L,351L,144L,57L,22L,6561L,8748L,5103L,2430L,1053L,432L,171L,66L,25L,19683L,26244L,15309L,7290L,3159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182828Inst : IEnumerable<long>
{
public static readonly long[] Value=A182828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182828.Bytes);
public long this[int i]=>Value[i];

public static A182828Inst Instance=new A182828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182829
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,9L,10L,12L,13L,15L,17L,18L,20L,22L,23L,24L,26L,27L,28L,30L,31L,33L,35L,36L,37L,39L,40L,42L,45L,47L,49L,50L,51L,53L,54L,56L,58L,59L,61L,63L,64L,65L,67L,68L,69L,71L,72L,74L,76L,77L,78L,80L,81L,82L,84L,85L,87L,89L,90L,91L,93L,94L,96L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182829Inst : IEnumerable<long>
{
public static readonly long[] Value=A182829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182829.Bytes);
public long this[int i]=>Value[i];

public static A182829Inst Instance=new A182829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182830
{
public static readonly long[] Value={ 2L,6L,5L,18L,15L,8L,54L,45L,24L,11L,162L,135L,72L,33L,14L,486L,405L,216L,99L,42L,17L,1458L,1215L,648L,297L,126L,51L,20L,4374L,3645L,1944L,891L,378L,153L,60L,23L,13122L,10935L,5832L,2673L,1134L,459L,180L,69L,26L,39366L,32805L,17496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182830Inst : IEnumerable<long>
{
public static readonly long[] Value=A182830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182830.Bytes);
public long this[int i]=>Value[i];

public static A182830Inst Instance=new A182830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182831
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,5L,11L,17L,22L,7L,14L,28L,45L,55L,9L,19L,37L,70L,112L,137L,10L,23L,48L,93L,171L,276L,334L,12L,26L,57L,118L,228L,417L,671L,812L,13L,31L,66L,141L,287L,556L,1010L,1627L,1965L,15L,34L,77L,164L,344L,697L,1347L,2444L,3934L,4751L,16L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182831Inst : IEnumerable<long>
{
public static readonly long[] Value=A182831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182831.Bytes);
public long this[int i]=>Value[i];

public static A182831Inst Instance=new A182831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182832
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,10L,5L,12L,21L,30L,6L,15L,34L,61L,85L,8L,19L,44L,95L,172L,237L,9L,24L,56L,125L,262L,476L,652L,11L,28L,68L,157L,347L,718L,1307L,1788L,13L,32L,80L,190L,435L,955L,1965L,3579L,4891L,14L,37L,91L,222L,524L,1196L,2618L,5373L,9786L,13371L,16L,41L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182832Inst : IEnumerable<long>
{
public static readonly long[] Value=A182832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182832.Bytes);
public long this[int i]=>Value[i];

public static A182832Inst Instance=new A182832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182833
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,10L,5L,12L,21L,30L,6L,15L,34L,61L,84L,8L,19L,44L,94L,170L,232L,9L,24L,55L,124L,257L,466L,635L,11L,28L,68L,155L,342L,702L,1272L,1731L,13L,32L,79L,188L,427L,935L,1912L,3465L,4711L,14L,37L,91L,219L,515L,1169L,2548L,5201L,9426L,12814L,16L,41L,103L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182833Inst : IEnumerable<long>
{
public static readonly long[] Value=A182833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182833.Bytes);
public long this[int i]=>Value[i];

public static A182833Inst Instance=new A182833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182834
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,9L,10L,11L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,48L,49L,51L,52L,53L,54L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,85L,86L,87L,88L,89L,90L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182834Inst : IEnumerable<long>
{
public static readonly long[] Value=A182834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182834.Bytes);
public long this[int i]=>Value[i];

public static A182834Inst Instance=new A182834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182835
{
public static readonly long[] Value={ 3L,4L,6L,7L,8L,9L,11L,12L,13L,14L,16L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,35L,36L,37L,39L,40L,41L,42L,43L,44L,45L,46L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182835Inst : IEnumerable<long>
{
public static readonly long[] Value=A182835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182835.Bytes);
public long this[int i]=>Value[i];

public static A182835Inst Instance=new A182835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182836
{
public static readonly long[] Value={ 0L,1L,3L,7L,15L,27L,39L,51L,71L,91L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182836Inst : IEnumerable<long>
{
public static readonly long[] Value=A182836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182836.Bytes);
public long this[int i]=>Value[i];

public static A182836Inst Instance=new A182836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182837
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,12L,12L,12L,20L,20L,16L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182837Inst : IEnumerable<long>
{
public static readonly long[] Value=A182837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182837.Bytes);
public long this[int i]=>Value[i];

public static A182837Inst Instance=new A182837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182838
{
public static readonly long[] Value={ 0L,1L,3L,7L,11L,15L,21L,31L,39L,43L,49L,61L,77L,91L,105L,127L,143L,147L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182838Inst : IEnumerable<long>
{
public static readonly long[] Value=A182838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182838.Bytes);
public long this[int i]=>Value[i];

public static A182838Inst Instance=new A182838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182839
{
public static readonly long[] Value={ 0L,1L,2L,4L,4L,4L,6L,10L,8L,4L,6L,12L,16L,14L,14L,22L,16L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182839Inst : IEnumerable<long>
{
public static readonly long[] Value=A182839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182839.Bytes);
public long this[int i]=>Value[i];

public static A182839Inst Instance=new A182839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182840
{
public static readonly long[] Value={ 0L,1L,5L,13L,27L,43L,57L,81L,119L,151L,165L,189L,235L,299L,353L,409L,495L,559L,573L,597L,643L,707L,769L,849L,975L,1119L,1205L,1261L,1371L,1539L,1697L,1841L,2039L,2167L,2181L,2205L,2251L,2315L,2377L,2457L,2583L,2727L,2821L,2901L,3043L,3267L,3505L,3729L,4015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182840Inst : IEnumerable<long>
{
public static readonly long[] Value=A182840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182840.Bytes);
public long this[int i]=>Value[i];

public static A182840Inst Instance=new A182840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182841
{
public static readonly long[] Value={ 0L,1L,4L,8L,14L,16L,14L,24L,38L,32L,14L,24L,46L,64L,54L,56L,86L,64L,14L,24L,46L,64L,62L,80L,126L,144L,86L,56L,110L,168L,158L,144L,198L,128L,14L,24L,46L,64L,62L,80L,126L,144L,94L,80L,142L,224L,238L,224L,286L,304L,150L,56L,110L,168L,182L,216L,326L,408L,302L,176L,262L,408L,414L,360L,438L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182841Inst : IEnumerable<long>
{
public static readonly long[] Value=A182841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182841.Bytes);
public long this[int i]=>Value[i];

public static A182841Inst Instance=new A182841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182842
{
public static readonly long[] Value={ 2L,4L,7L,8L,7L,12L,19L,16L,7L,12L,23L,32L,27L,28L,43L,32L,7L,12L,23L,32L,31L,40L,63L,72L,43L,28L,55L,84L,79L,72L,99L,64L,7L,12L,23L,32L,31L,40L,63L,72L,47L,40L,71L,112L,119L,112L,143L,152L,75L,28L,55L,84L,91L,108L,163L,204L,151L,88L,131L,204L,207L,180L,219L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182842Inst : IEnumerable<long>
{
public static readonly long[] Value=A182842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182842.Bytes);
public long this[int i]=>Value[i];

public static A182842Inst Instance=new A182842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182843
{
public static readonly long[] Value={ 0L,0L,1L,3L,3L,6L,6L,10L,10L,11L,11L,16L,16L,22L,22L,23L,23L,30L,30L,38L,38L,39L,39L,48L,48L,50L,50L,51L,51L,61L,61L,72L,72L,73L,73L,75L,75L,87L,87L,88L,88L,101L,101L,115L,115L,116L,116L,131L,131L,134L,134L,135L,135L,151L,151L,153L,153L,154L,154L,171L,171L,189L,189L,190L,190L,192L,192L,211L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182843Inst : IEnumerable<long>
{
public static readonly long[] Value=A182843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182843.Bytes);
public long this[int i]=>Value[i];

public static A182843Inst Instance=new A182843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182844
{
public static readonly long[] Value={ 0L,2L,4L,8L,15L,26L,45L,75L,121L,193L,302L,463L,703L,1052L,1555L,2277L,3301L,4740L,6754L,9548L,13398L,18678L,25873L,35620L,48771L,66418L,89988L,121345L,162878L,217666L,289685L,383994L,507059L,667131L,874656L,1142860L,1488484L,1932575L,2501599L,3228787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182844Inst : IEnumerable<long>
{
public static readonly long[] Value=A182844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182844.Bytes);
public long this[int i]=>Value[i];

public static A182844Inst Instance=new A182844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182845
{
public static readonly long[] Value={ 1L,3L,6L,11L,20L,35L,58L,96L,154L,242L,375L,573L,861L,1282L,1886L,2745L,3961L,5667L,8038L,11323L,15836L,22001L,30383L,41715L,56953L,77363L,104566L,140668L,188397L,251247L,333689L,441474L,581890L,764215L,1000233L,1304815L,1696717L,2199591L,2843073L,3664312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182845Inst : IEnumerable<long>
{
public static readonly long[] Value=A182845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182845.Bytes);
public long this[int i]=>Value[i];

public static A182845Inst Instance=new A182845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182846
{
public static readonly long[] Value={ 1L,3L,2L,5L,7L,4L,9L,13L,11L,6L,12L,19L,21L,17L,8L,16L,26L,32L,30L,23L,10L,20L,35L,44L,46L,39L,29L,14L,24L,42L,55L,61L,59L,50L,36L,15L,28L,51L,67L,77L,81L,75L,62L,41L,18L,33L,60L,82L,95L,102L,100L,90L,72L,49L,22L,38L,69L,93L,113L,125L,128L,120L,106L,84L,56L,25L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182846Inst : IEnumerable<long>
{
public static readonly long[] Value=A182846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182846.Bytes);
public long this[int i]=>Value[i];

public static A182846Inst Instance=new A182846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182847
{
public static readonly long[] Value={ 1L,3L,2L,6L,7L,4L,10L,13L,11L,5L,14L,20L,21L,16L,8L,18L,27L,32L,30L,22L,9L,24L,36L,42L,44L,38L,26L,12L,29L,46L,55L,61L,58L,49L,33L,15L,34L,54L,69L,77L,78L,72L,59L,40L,17L,39L,64L,84L,95L,100L,98L,87L,70L,47L,19L,45L,73L,97L,113L,123L,124L,117L,103L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182847Inst : IEnumerable<long>
{
public static readonly long[] Value=A182847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182847.Bytes);
public long this[int i]=>Value[i];

public static A182847Inst Instance=new A182847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182848
{
public static readonly long[] Value={ 1L,4L,2L,8L,7L,3L,12L,14L,11L,5L,17L,22L,21L,16L,6L,24L,30L,33L,29L,20L,9L,28L,40L,45L,44L,38L,26L,10L,35L,51L,59L,61L,57L,47L,32L,13L,41L,60L,73L,80L,77L,69L,56L,37L,15L,49L,71L,88L,97L,101L,94L,84L,66L,43L,18L,55L,82L,103L,115L,124L,123L,113L,99L,76L,50L,19L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182848Inst : IEnumerable<long>
{
public static readonly long[] Value=A182848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182848.Bytes);
public long this[int i]=>Value[i];

public static A182848Inst Instance=new A182848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182849
{
public static readonly long[] Value={ 1L,3L,2L,6L,7L,4L,9L,13L,11L,5L,14L,19L,21L,16L,8L,18L,27L,31L,30L,22L,10L,23L,36L,43L,45L,39L,28L,12L,26L,44L,56L,61L,57L,50L,34L,15L,32L,52L,68L,78L,79L,73L,60L,40L,17L,37L,63L,83L,94L,101L,98L,87L,70L,47L,20L,42L,72L,96L,113L,124L,126L,118L,104L,82L,54L,24L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182849Inst : IEnumerable<long>
{
public static readonly long[] Value=A182849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182849.Bytes);
public long this[int i]=>Value[i];

public static A182849Inst Instance=new A182849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182850
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,3L,1L,2L,2L,3L,1L,4L,1L,3L,3L,2L,1L,4L,1L,4L,3L,3L,1L,4L,2L,3L,2L,4L,1L,3L,1L,2L,3L,3L,3L,3L,1L,3L,3L,4L,1L,3L,1L,4L,4L,3L,1L,4L,2L,4L,3L,4L,1L,4L,3L,4L,3L,3L,1L,5L,1L,3L,4L,2L,3L,3L,1L,4L,3L,3L,1L,4L,1L,3L,4L,4L,3L,3L,1L,4L,2L,3L,1L,5L,3L,3L,3L,4L,1L,5L,3L,4L,3L,3L,3L,4L,1L,4L,4L,3L,1L,3L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182850Inst : IEnumerable<long>
{
public static readonly long[] Value=A182850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182850.Bytes);
public long this[int i]=>Value[i];

public static A182850Inst Instance=new A182850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182851
{
public static readonly long[] Value={ 3L,5L,6L,7L,10L,11L,13L,14L,15L,17L,19L,21L,22L,23L,26L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,46L,47L,51L,53L,55L,57L,58L,59L,60L,61L,62L,65L,66L,67L,69L,70L,71L,73L,74L,77L,78L,79L,82L,83L,84L,85L,86L,87L,89L,90L,91L,93L,94L,95L,97L,100L,101L,102L,103L,105L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182851Inst : IEnumerable<long>
{
public static readonly long[] Value=A182851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182851.Bytes);
public long this[int i]=>Value[i];

public static A182851Inst Instance=new A182851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182852
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,12L,16L,18L,20L,24L,25L,27L,28L,32L,40L,44L,45L,48L,49L,50L,52L,54L,56L,63L,64L,68L,72L,75L,76L,80L,81L,88L,92L,96L,98L,99L,104L,108L,112L,116L,117L,121L,124L,125L,128L,135L,136L,144L,147L,148L,152L,153L,160L,162L,164L,169L,171L,172L,175L,176L,184L,188L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182852Inst : IEnumerable<long>
{
public static readonly long[] Value=A182852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182852.Bytes);
public long this[int i]=>Value[i];

public static A182852Inst Instance=new A182852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182853
{
public static readonly long[] Value={ 6L,10L,14L,15L,21L,22L,26L,30L,33L,34L,35L,36L,38L,39L,42L,46L,51L,55L,57L,58L,62L,65L,66L,69L,70L,74L,77L,78L,82L,85L,86L,87L,91L,93L,94L,95L,100L,102L,105L,106L,110L,111L,114L,115L,118L,119L,122L,123L,129L,130L,133L,134L,138L,141L,142L,143L,145L,146L,154L,155L,158L,159L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182853Inst : IEnumerable<long>
{
public static readonly long[] Value=A182853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182853.Bytes);
public long this[int i]=>Value[i];

public static A182853Inst Instance=new A182853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182854
{
public static readonly long[] Value={ 12L,18L,20L,24L,28L,40L,44L,45L,48L,50L,52L,54L,56L,63L,68L,72L,75L,76L,80L,88L,92L,96L,98L,99L,104L,108L,112L,116L,117L,124L,135L,136L,144L,147L,148L,152L,153L,160L,162L,164L,171L,172L,175L,176L,184L,188L,189L,192L,200L,207L,208L,212L,224L,232L,236L,242L,244L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182854Inst : IEnumerable<long>
{
public static readonly long[] Value=A182854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182854.Bytes);
public long this[int i]=>Value[i];

public static A182854Inst Instance=new A182854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182855
{
public static readonly long[] Value={ 60L,84L,90L,120L,126L,132L,140L,150L,156L,168L,180L,198L,204L,220L,228L,234L,240L,252L,260L,264L,270L,276L,280L,294L,300L,306L,308L,312L,315L,336L,340L,342L,348L,350L,364L,372L,378L,380L,396L,408L,414L,420L,440L,444L,450L,456L,460L,468L,476L,480L,490L,492L,495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182855Inst : IEnumerable<long>
{
public static readonly long[] Value=A182855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182855.Bytes);
public long this[int i]=>Value[i];

public static A182855Inst Instance=new A182855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182856
{
public static readonly BigInteger[] Value={ 1L,2L,60L,1801800L,11657093261814000L,BigInteger.Parse("7167827541370578634694420017740000"),BigInteger.Parse("291943326350524088652207164949980988754136887856059678357800000") };
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
public class A182856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182856Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182856.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A182856.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182856Inst Instance=new A182856Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182857
{
public static readonly BigInteger[] Value={ 1L,3L,4L,6L,12L,60L,2520L,1286485200L,BigInteger.Parse("35933692027611398678865941374040400000") };
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
public class A182857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182857Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182857.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A182857.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182857Inst Instance=new A182857Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182858
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,2L,1L,2L,1L,1L,3L,2L,1L,1L,4L,3L,2L,2L,1L,1L,1L,7L,6L,5L,4L,4L,3L,3L,2L,2L,2L,1L,1L,1L,1L,14L,13L,12L,11L,10L,10L,9L,9L,8L,8L,7L,7L,7L,6L,6L,6L,5L,5L,5L,5L,4L,4L,4L,4L,3L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,42L,41L,40L,39L,38L,37L,36L,35L,35L,34L,34L,33L,33L,32L,32L,31L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182858Inst : IEnumerable<long>
{
public static readonly long[] Value=A182858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182858.Bytes);
public long this[int i]=>Value[i];

public static A182858Inst Instance=new A182858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182859
{
public static readonly long[] Value={ 1L,2L,4L,9L,12L,16L,18L,20L,24L,25L,28L,30L,32L,40L,42L,44L,45L,48L,49L,50L,52L,54L,56L,63L,64L,66L,68L,70L,75L,76L,78L,80L,81L,88L,92L,98L,99L,102L,104L,105L,110L,112L,114L,116L,117L,121L,124L,128L,130L,135L,136L,138L,144L,147L,148L,152L,153L,154L,162L,164L,165L,169L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182859Inst : IEnumerable<long>
{
public static readonly long[] Value=A182859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182859.Bytes);
public long this[int i]=>Value[i];

public static A182859Inst Instance=new A182859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182860
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,4L,2L,3L,3L,2L,2L,4L,2L,4L,3L,3L,2L,4L,2L,3L,2L,4L,2L,4L,2L,2L,3L,3L,3L,3L,2L,3L,3L,4L,2L,4L,2L,4L,4L,3L,2L,4L,2L,4L,3L,4L,2L,4L,3L,4L,3L,3L,2L,6L,2L,3L,4L,2L,3L,4L,2L,4L,3L,4L,2L,4L,2L,3L,4L,4L,3L,4L,2L,4L,2L,3L,2L,6L,3L,3L,3L,4L,2L,6L,3L,4L,3L,3L,3L,4L,2L,4L,4L,3L,2L,4L,2L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182860Inst : IEnumerable<long>
{
public static readonly long[] Value=A182860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182860.Bytes);
public long this[int i]=>Value[i];

public static A182860Inst Instance=new A182860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182861
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,2L,4L,4L,2L,3L,4L,6L,2L,4L,4L,6L,2L,4L,6L,4L,5L,3L,6L,2L,4L,8L,4L,8L,4L,6L,2L,4L,8L,4L,8L,4L,4L,6L,2L,6L,4L,9L,3L,8L,4L,8L,4L,6L,6L,2L,8L,4L,6L,12L,4L,8L,4L,8L,4L,6L,6L,2L,8L,4L,10L,12L,4L,6L,8L,4L,8L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182861Inst : IEnumerable<long>
{
public static readonly long[] Value=A182861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182861.Bytes);
public long this[int i]=>Value[i];

public static A182861Inst Instance=new A182861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182862
{
public static readonly long[] Value={ 1L,2L,6L,12L,60L,360L,1260L,2520L,27720L,138600L,360360L,831600L,10810800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182862Inst : IEnumerable<long>
{
public static readonly long[] Value=A182862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182862.Bytes);
public long this[int i]=>Value[i];

public static A182862Inst Instance=new A182862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182863
{
public static readonly long[] Value={ 1L,2L,6L,12L,30L,60L,210L,360L,420L,1260L,2310L,2520L,4620L,13860L,27720L,30030L,60060L,75600L,138600L,180180L,360360L,510510L,831600L,900900L,1021020L,1801800L,3063060L,6126120L,9699690L,10810800L,15315300L,19399380L,30630600L,37837800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182863Inst : IEnumerable<long>
{
public static readonly long[] Value=A182863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182863.Bytes);
public long this[int i]=>Value[i];

public static A182863Inst Instance=new A182863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182864
{
public static readonly long[] Value={ 0L,1L,3L,13L,123L,2903L,3373867L,895293820337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182864Inst : IEnumerable<long>
{
public static readonly long[] Value=A182864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182864.Bytes);
public long this[int i]=>Value[i];

public static A182864Inst Instance=new A182864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182865
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,2L,4L,5L,5L,3L,6L,7L,6L,3L,8L,8L,9L,5L,9L,11L,11L,6L,12L,13L,13L,7L,14L,15L,15L,7L,15L,17L,15L,8L,18L,19L,18L,10L,20L,21L,21L,11L,20L,23L,23L,9L,24L,24L,24L,13L,26L,26L,25L,14L,27L,29L,29L,15L,30L,31L,28L,15L,30L,33L,33L,17L,33L,35L,35L,16L,36L,37L,36L,19L,35L,39L,39L,15L,40L,41L,41L,21L,40L,43L,42L,22L,44L,40L,42L,23L,45L,47L,45L,21L,48L,48L,44L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182865Inst : IEnumerable<long>
{
public static readonly long[] Value=A182865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182865.Bytes);
public long this[int i]=>Value[i];

public static A182865Inst Instance=new A182865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182866
{
public static readonly long[] Value={ 0L,56L,810L,4992L,20000L,61560L,158466L,358400L,734832L,1395000L,2488970L,4219776L,6854640L,10737272L,16301250L,24084480L,34744736L,49076280L,68027562L,92720000L,124467840L,164799096L,215477570L,278525952L,356250000L,451263800L,566516106L,705317760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182866Inst : IEnumerable<long>
{
public static readonly long[] Value=A182866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182866.Bytes);
public long this[int i]=>Value[i];

public static A182866Inst Instance=new A182866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182867
{
public static readonly long[] Value={ 1L,1L,-4L,1L,-20L,64L,1L,-56L,784L,-2304L,1L,-120L,4368L,-52480L,147456L,1L,-220L,16368L,-489280L,5395456L,-14745600L,1L,-364L,48048L,-2846272L,75851776L,-791691264L,2123366400L,1L,-560L,119392L,-12263680L,633721088L,-15658639360L,157294854144L,-416179814400L,1L,-816L,262752L,-42828032L,3773223168L,-177891237888L,4165906530304L,-40683662475264L,106542032486400L,1L,-1140L,527136L,-127959680L,17649505536L,-1400415544320L,61802667606016L,-1390437378293760L,13288048674471936L,-34519618525593600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182867Inst : IEnumerable<long>
{
public static readonly long[] Value=A182867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182867.Bytes);
public long this[int i]=>Value[i];

public static A182867Inst Instance=new A182867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182868
{
public static readonly long[] Value={ -1L,4L,17L,38L,67L,104L,149L,202L,263L,332L,409L,494L,587L,688L,797L,914L,1039L,1172L,1313L,1462L,1619L,1784L,1957L,2138L,2327L,2524L,2729L,2942L,3163L,3392L,3629L,3874L,4127L,4388L,4657L,4934L,5219L,5512L,5813L,6122L,6439L,6764L,7097L,7438L,7787L,8144L,8509L,8882L,9263L,9652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182868Inst : IEnumerable<long>
{
public static readonly long[] Value=A182868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182868.Bytes);
public long this[int i]=>Value[i];

public static A182868Inst Instance=new A182868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182869
{
public static readonly long[] Value={ 1L,3L,2L,6L,7L,4L,10L,15L,14L,5L,18L,32L,42L,23L,8L,27L,68L,136L,86L,41L,9L,44L,152L,482L,392L,244L,53L,11L,70L,359L,1880L,2001L,1773L,360L,91L,12L,117L,893L,7771L,11211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182869Inst : IEnumerable<long>
{
public static readonly long[] Value=A182869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182869.Bytes);
public long this[int i]=>Value[i];

public static A182869Inst Instance=new A182869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182870
{
public static readonly long[] Value={ 1L,4L,2L,11L,10L,3L,26L,36L,18L,5L,61L,127L,78L,35L,6L,143L,471L,381L,234L,46L,7L,348L,1867L,1987L,1760L,349L,70L,8L,881L,7755L,11195L,14884L,3166L,686L,111L,9L,2279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182870Inst : IEnumerable<long>
{
public static readonly long[] Value=A182870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182870.Bytes);
public long this[int i]=>Value[i];

public static A182870Inst Instance=new A182870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182871
{
public static readonly long[] Value={ 1L,3L,2L,7L,11L,4L,16L,27L,20L,5L,26L,36L,32L,28L,6L,30L,49L,47L,42L,29L,8L,34L,59L,61L,60L,46L,31L,9L,41L,70L,75L,78L,64L,55L,33L,10L,52L,85L,89L,96L,86L,71L,57L,35L,12L,56L,94L,103L,114L,102L,92L,80L,58L,37L,13L,62L,106L,119L,129L,121L,113L,101L,84L,63L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182871Inst : IEnumerable<long>
{
public static readonly long[] Value=A182871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182871.Bytes);
public long this[int i]=>Value[i];

public static A182871Inst Instance=new A182871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182872
{
public static readonly long[] Value={ 1L,4L,2L,16L,20L,3L,25L,29L,24L,5L,31L,45L,33L,26L,6L,40L,55L,52L,43L,27L,7L,51L,71L,63L,59L,49L,28L,8L,57L,83L,79L,78L,65L,50L,30L,9L,66L,97L,92L,95L,84L,68L,53L,32L,10L,76L,111L,108L,113L,104L,87L,75L,54L,34L,11L,81L,123L,122L,131L,120L,105L,93L,77L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182872Inst : IEnumerable<long>
{
public static readonly long[] Value=A182872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182872.Bytes);
public long this[int i]=>Value[i];

public static A182872Inst Instance=new A182872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182873
{
public static readonly long[] Value={ 9L,6L,12L,12L,6L,12L,8L,4L,26L,4L,6L,20L,22L,2L,16L,12L,2L,46L,2L,4L,6L,2L,22L,6L,12L,26L,4L,36L,2L,18L,6L,28L,8L,10L,12L,2L,6L,22L,26L,4L,12L,66L,2L,16L,6L,6L,2L,6L,34L,2L,4L,6L,6L,18L,42L,8L,12L,12L,18L,40L,12L,2L,4L,26L,4L,24L,56L,4L,6L,20L,16L,26L,10L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182873Inst : IEnumerable<long>
{
public static readonly long[] Value=A182873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182873.Bytes);
public long this[int i]=>Value[i];

public static A182873Inst Instance=new A182873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182874
{
public static readonly long[] Value={ 149L,67L,11L,59L,409L,17L,1973L,151L,349L,107L,127L,857L,71L,373L,1187L,5657L,607L,311L,1823L,769L,677L,1733L,181L,1103L,1373L,23767L,1609L,881L,6703L,1913L,14081L,3697L,503L,4259L,3181L,4129L,33629L,28933L,3371L,9239L,5557L,10343L,2531L,6571L,2909L,9521L,20233L,13901L,31859L,3067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182874Inst : IEnumerable<long>
{
public static readonly long[] Value=A182874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182874.Bytes);
public long this[int i]=>Value[i];

public static A182874Inst Instance=new A182874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182875
{
public static readonly long[] Value={ 151L,71L,17L,67L,419L,29L,1987L,167L,367L,127L,149L,881L,97L,401L,1217L,5689L,641L,347L,1861L,809L,719L,1777L,227L,1151L,1423L,23819L,1663L,937L,6761L,1973L,14143L,3761L,569L,4327L,3251L,4201L,33703L,29009L,3449L,9319L,5639L,10427L,2617L,6659L,2999L,9613L,20327L,13997L,31957L,3167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182875Inst : IEnumerable<long>
{
public static readonly long[] Value=A182875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182875.Bytes);
public long this[int i]=>Value[i];

public static A182875Inst Instance=new A182875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182876
{
public static readonly long[] Value={ 2L,17L,71L,181L,503L,2531L,2909L,3067L,5273L,7001L,7741L,9887L,11587L,33911L,55339L,174917L,225961L,345041L,360289L,534883L,2492311L,5409337L,20099089L,31531063L,39706123L,49444063L,80925371L,141833603L,180881749L,197920843L,212583797L,658046911L,777899149L,1183597123L,1595746589L,2897211971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182876Inst : IEnumerable<long>
{
public static readonly long[] Value=A182876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182876.Bytes);
public long this[int i]=>Value[i];

public static A182876Inst Instance=new A182876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182877
{
public static readonly long[] Value={ 9L,12L,26L,46L,66L,86L,90L,100L,114L,120L,126L,174L,190L,212L,280L,386L,396L,410L,480L,598L,726L,916L,964L,1000L,1074L,1090L,1218L,1280L,1378L,1380L,1614L,1728L,1774L,1924L,1998L,2378L,2452L,2514L,2608L,2852L,2866L,2870L,3080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182877Inst : IEnumerable<long>
{
public static readonly long[] Value=A182877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182877.Bytes);
public long this[int i]=>Value[i];

public static A182877Inst Instance=new A182877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182878
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,0L,4L,1L,0L,0L,1L,9L,1L,0L,0L,0L,9L,16L,1L,0L,0L,0L,1L,36L,25L,1L,0L,0L,0L,0L,16L,100L,36L,1L,0L,0L,0L,0L,1L,100L,225L,49L,1L,0L,0L,0L,0L,0L,25L,400L,441L,64L,1L,0L,0L,0L,0L,0L,1L,225L,1225L,784L,81L,1L,0L,0L,0L,0L,0L,0L,36L,1225L,3136L,1296L,100L,1L,0L,0L,0L,0L,0L,0L,1L,441L,4900L,7056L,2025L,121L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182878Inst : IEnumerable<long>
{
public static readonly long[] Value=A182878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182878.Bytes);
public long this[int i]=>Value[i];

public static A182878Inst Instance=new A182878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182879
{
public static readonly long[] Value={ 0L,1L,3L,11L,33L,96L,278L,787L,2205L,6133L,16941L,46554L,127390L,347331L,944121L,2559607L,6923529L,18690138L,50364988L,135506485L,364063815L,976880631L,2618206923L,7009868646L,18749876418L,50107633501L,133800148323L,357012426677L,951936494055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182879Inst : IEnumerable<long>
{
public static readonly long[] Value=A182879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182879.Bytes);
public long this[int i]=>Value[i];

public static A182879Inst Instance=new A182879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182880
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,5L,6L,8L,18L,13L,44L,6L,21L,102L,30L,34L,222L,120L,55L,466L,390L,20L,89L,948L,1140L,140L,144L,1884L,3066L,700L,233L,3672L,7770L,2800L,70L,377L,7044L,18780L,9800L,630L,610L,13332L,43710L,31080L,3780L,987L,24946L,98610L,91560L,17850L,252L,1597L,46218L,216732L,254400L,72450L,2772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182880Inst : IEnumerable<long>
{
public static readonly long[] Value=A182880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182880.Bytes);
public long this[int i]=>Value[i];

public static A182880Inst Instance=new A182880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182881
{
public static readonly long[] Value={ 0L,0L,0L,2L,6L,18L,56L,162L,462L,1306L,3648L,10116L,27892L,76524L,209112L,569506L,1546542L,4189314L,11323480L,30548190L,82272330L,221240070L,594131160L,1593553452L,4269391596L,11426761548L,30554523096L,81631135502L,217918012002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182881Inst : IEnumerable<long>
{
public static readonly long[] Value=A182881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182881.Bytes);
public long this[int i]=>Value[i];

public static A182881Inst Instance=new A182881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182882
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,2L,2L,0L,1L,1L,6L,3L,0L,1L,6L,3L,12L,4L,0L,1L,7L,24L,6L,20L,5L,0L,1L,12L,34L,60L,10L,30L,6L,0L,1L,31L,60L,100L,120L,15L,42L,7L,0L,1L,40L,185L,180L,230L,210L,21L,56L,8L,0L,1L,91L,260L,645L,420L,455L,336L,28L,72L,9L,0L,1L,170L,636L,980L,1715L,840L,812L,504L,36L,90L,10L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182882Inst : IEnumerable<long>
{
public static readonly long[] Value=A182882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182882.Bytes);
public long this[int i]=>Value[i];

public static A182882Inst Instance=new A182882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182883
{
public static readonly long[] Value={ 1L,0L,1L,2L,1L,6L,7L,12L,31L,40L,91L,170L,281L,602L,1051L,1988L,3907L,7044L,13735L,25962L,48643L,94094L,177145L,338184L,647791L,1228812L,2356927L,4500678L,8595913L,16486966L,31521543L,60419872L,115870879L,222045160L,426275647L,818054654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182883Inst : IEnumerable<long>
{
public static readonly long[] Value=A182883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182883.Bytes);
public long this[int i]=>Value[i];

public static A182883Inst Instance=new A182883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182884
{
public static readonly long[] Value={ 0L,1L,2L,5L,16L,44L,122L,341L,940L,2581L,7064L,19258L,52348L,141935L,383962L,1036633L,2793812L,7517698L,20200330L,54209775L,145309380L,389091111L,1040853492L,2781908250L,7429184976L,19824925429L,52866176702L,140883978971L,375216491080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182884Inst : IEnumerable<long>
{
public static readonly long[] Value=A182884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182884.Bytes);
public long this[int i]=>Value[i];

public static A182884Inst Instance=new A182884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182885
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,7L,3L,1L,13L,10L,3L,27L,29L,6L,1L,61L,66L,22L,4L,133L,157L,75L,10L,1L,287L,398L,201L,40L,5L,633L,975L,538L,155L,15L,1L,1407L,2334L,1506L,476L,65L,6L,3121L,5631L,4077L,1414L,280L,21L,1L,6943L,13602L,10695L,4320L,966L,98L,7L,15517L,32623L,27966L,12765L,3150L,462L,28L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182885Inst : IEnumerable<long>
{
public static readonly long[] Value=A182885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182885.Bytes);
public long this[int i]=>Value[i];

public static A182885Inst Instance=new A182885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182886
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,2L,0L,2L,1L,0L,6L,1L,3L,1L,0L,6L,12L,3L,4L,1L,6L,0L,24L,21L,6L,5L,1L,0L,30L,12L,60L,34L,10L,6L,1L,0L,30L,90L,60L,121L,52L,15L,7L,1L,20L,0L,180L,215L,76L,21L,8L,1L,0L,140L,90L,630L,540L,421L,351L,107L,28L,9L,1L,0L,140L,560L,630L,1710L,1176L,846L,539L,146L,36L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182886Inst : IEnumerable<long>
{
public static readonly long[] Value=A182886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182886.Bytes);
public long this[int i]=>Value[i];

public static A182886Inst Instance=new A182886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182887
{
public static readonly long[] Value={ 0L,1L,3L,7L,21L,60L,166L,463L,1281L,3521L,9645L,26322L,71606L,194283L,525897L,1420595L,3830445L,10311510L,27718028L,74410105L,199519155L,534400491L,1429944603L,3822761742L,10211093226L,27254110405L,72691102131L,193750155673L,516100470051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182887Inst : IEnumerable<long>
{
public static readonly long[] Value=A182887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182887.Bytes);
public long this[int i]=>Value[i];

public static A182887Inst Instance=new A182887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182888
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,2L,2L,0L,1L,3L,4L,3L,0L,1L,8L,7L,6L,4L,0L,1L,17L,20L,12L,8L,5L,0L,1L,38L,44L,36L,18L,10L,6L,0L,1L,89L,104L,82L,56L,25L,12L,7L,0L,1L,206L,253L,204L,132L,80L,33L,14L,8L,0L,1L,485L,604L,513L,344L,195L,108L,42L,16L,9L,0L,1L,1152L,1466L,1262L,891L,530L,272L,140L,52L,18L,10L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182888Inst : IEnumerable<long>
{
public static readonly long[] Value=A182888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182888.Bytes);
public long this[int i]=>Value[i];

public static A182888Inst Instance=new A182888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182889
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,8L,17L,38L,89L,206L,485L,1152L,2751L,6614L,15983L,38798L,94569L,231342L,567771L,1397562L,3449285L,8533886L,21161001L,52579900L,130896887L,326440746L,815437967L,2040049514L,5111051473L,12822135138L,32207384995L,80995950182L,203917464635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182889Inst : IEnumerable<long>
{
public static readonly long[] Value=A182889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182889.Bytes);
public long this[int i]=>Value[i];

public static A182889Inst Instance=new A182889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182890
{
public static readonly long[] Value={ 0L,1L,2L,5L,14L,36L,94L,247L,646L,1691L,4428L,11592L,30348L,79453L,208010L,544577L,1425722L,3732588L,9772042L,25583539L,66978574L,175352183L,459077976L,1201881744L,3146567256L,8237820025L,21566892818L,56462858429L,147821682470L,387002188980L,1013184884470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182890Inst : IEnumerable<long>
{
public static readonly long[] Value=A182890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182890.Bytes);
public long this[int i]=>Value[i];

public static A182890Inst Instance=new A182890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182891
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,7L,3L,1L,15L,8L,3L,35L,21L,6L,1L,83L,50L,16L,4L,197L,123L,45L,10L,1L,473L,308L,117L,28L,5L,1145L,769L,304L,83L,15L,1L,2787L,1926L,798L,232L,45L,6L,6819L,4843L,2085L,636L,140L,21L,1L,16759L,12204L,5433L,1744L,416L,68L,7L,41345L,30813L,14154L,4749L,1200L,222L,28L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182891Inst : IEnumerable<long>
{
public static readonly long[] Value=A182891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182891.Bytes);
public long this[int i]=>Value[i];

public static A182891Inst Instance=new A182891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182892
{
public static readonly long[] Value={ 1L,1L,1L,3L,7L,15L,35L,83L,197L,473L,1145L,2787L,6819L,16759L,41345L,102341L,254075L,632437L,1577967L,3945517L,9884379L,24806201L,62355121L,156974319L,395712759L,998809135L,2524043569L,6385400005L,16170553755L,40990092629L,103997889735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182892Inst : IEnumerable<long>
{
public static readonly long[] Value=A182892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182892.Bytes);
public long this[int i]=>Value[i];

public static A182892Inst Instance=new A182892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182893
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,2L,0L,2L,1L,2L,4L,1L,3L,1L,4L,8L,6L,3L,4L,1L,12L,12L,18L,9L,6L,5L,1L,24L,36L,30L,32L,14L,10L,6L,1L,54L,84L,78L,64L,51L,22L,15L,7L,1L,130L,184L,204L,152L,120L,77L,34L,21L,8L,1L,300L,452L,462L,416L,280L,205L,113L,51L,28L,9L,1L,706L,1084L,1130L,1000L,770L,492L,328L,163L,74L,36L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182893Inst : IEnumerable<long>
{
public static readonly long[] Value=A182893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182893.Bytes);
public long this[int i]=>Value[i];

public static A182893Inst Instance=new A182893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182894
{
public static readonly long[] Value={ 1L,0L,0L,2L,2L,4L,12L,24L,54L,130L,300L,706L,1686L,4028L,9686L,23426L,56866L,138584L,338940L,831508L,2045736L,5046240L,12477290L,30919122L,76774382L,190995224L,475979602L,1188125394L,2970282794L,7436232760L,18641883396L,46792219972L,117590713254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182894Inst : IEnumerable<long>
{
public static readonly long[] Value=A182894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182894.Bytes);
public long this[int i]=>Value[i];

public static A182894Inst Instance=new A182894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182895
{
public static readonly long[] Value={ 0L,1L,3L,7L,19L,50L,130L,341L,893L,2337L,6119L,16020L,41940L,109801L,287463L,752587L,1970299L,5158310L,13504630L,35355581L,92562113L,242330757L,634430159L,1660959720L,4348449000L,11384387281L,29804712843L,78029751247L,204284540899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182895Inst : IEnumerable<long>
{
public static readonly long[] Value=A182895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182895.Bytes);
public long this[int i]=>Value[i];

public static A182895Inst Instance=new A182895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182896
{
public static readonly long[] Value={ 44500L,6398L,264L,1L,175502L,275925L,121247L,20350L,1134L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182896Inst : IEnumerable<long>
{
public static readonly long[] Value=A182896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182896.Bytes);
public long this[int i]=>Value[i];

public static A182896Inst Instance=new A182896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182897
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,9L,27L,76L,211L,580L,1578L,4267L,11484L,30789L,82301L,219465L,584060L,1551770L,4117061L,10910049L,28881387L,76387179L,201875129L,533145603L,1407161007L,3711981168L,9787157469L,25793933410L,67952779665L,178954077522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182897Inst : IEnumerable<long>
{
public static readonly long[] Value=A182897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182897.Bytes);
public long this[int i]=>Value[i];

public static A182897Inst Instance=new A182897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182898
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,5L,6L,8L,18L,13L,46L,4L,21L,112L,20L,34L,262L,80L,55L,600L,268L,8L,89L,1356L,816L,56L,144L,3046L,2324L,280L,233L,6832L,6320L,1144L,16L,377L,15354L,16620L,4136L,144L,610L,34658L,42652L,13728L,864L,987L,78706L,107520L,42816L,4144L,32L,1597L,180000L,267564L,127392L,17264L,352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182898Inst : IEnumerable<long>
{
public static readonly long[] Value=A182898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182898.Bytes);
public long this[int i]=>Value[i];

public static A182898Inst Instance=new A182898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182899
{
public static readonly long[] Value={ 0L,0L,0L,2L,6L,18L,54L,152L,422L,1160L,3156L,8534L,22968L,61578L,164602L,438930L,1168120L,3103540L,8234122L,21820098L,57762774L,152774358L,403750258L,1066291206L,2814322014L,7423962336L,19574314938L,51587866820L,135905559330L,357908155044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182899Inst : IEnumerable<long>
{
public static readonly long[] Value=A182899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182899.Bytes);
public long this[int i]=>Value[i];

public static A182899Inst Instance=new A182899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182900
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,17L,36L,1L,78L,4L,171L,14L,379L,43L,1L,848L,125L,5L,1912L,351L,20L,4341L,960L,71L,1L,9915L,2579L,235L,6L,22767L,6833L,745L,27L,52526L,17916L,2281L,108L,1L,121698L,46593L,6805L,399L,7L,283043L,120385L,19885L,1400L,35L,660579L,309416L,57141L,4712L,155L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182900Inst : IEnumerable<long>
{
public static readonly long[] Value=A182900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182900.Bytes);
public long this[int i]=>Value[i];

public static A182900Inst Instance=new A182900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182901
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,17L,36L,78L,171L,379L,848L,1912L,4341L,9915L,22767L,52526L,121698L,283043L,660579L,1546556L,3631261L,8548643L,20174093L,47716388L,113095740L,268575321L,638954183L,1522668500L,3634346039L,8687404327L,20794957839L,49841956726L,119610395745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182901Inst : IEnumerable<long>
{
public static readonly long[] Value=A182901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182901.Bytes);
public long this[int i]=>Value[i];

public static A182901Inst Instance=new A182901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182902
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,4L,14L,45L,135L,391L,1105L,3067L,8404L,22806L,61428L,164495L,438459L,1164363L,3082717L,8141422L,21457255L,56455195L,148323305L,389213825L,1020283146L,2672225692L,6993600748L,18291536552L,47814575243L,124929304664L,326280023426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182902Inst : IEnumerable<long>
{
public static readonly long[] Value=A182902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182902.Bytes);
public long this[int i]=>Value[i];

public static A182902Inst Instance=new A182902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182903
{
public static readonly long[] Value={ 1L,1L,2L,4L,1L,9L,2L,21L,5L,48L,14L,1L,112L,38L,3L,263L,104L,9L,623L,276L,31L,1L,1484L,730L,99L,4L,3550L,1921L,309L,14L,8525L,5034L,929L,56L,1L,20537L,13145L,2739L,205L,5L,49612L,34208L,7956L,716L,20L,120136L,88780L,22804L,2394L,90L,1L,291519L,229860L,64650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182903Inst : IEnumerable<long>
{
public static readonly long[] Value=A182903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182903.Bytes);
public long this[int i]=>Value[i];

public static A182903Inst Instance=new A182903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182904
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,48L,112L,263L,623L,1484L,3550L,8525L,20537L,49612L,120136L,291519L,708699L,1725714L,4208364L,10276173L,25122829L,61486180L,150632012L,369361757L,906462529L,2226297008L,5471757126L,13457326605L,33117622245L,81547372396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182904Inst : IEnumerable<long>
{
public static readonly long[] Value=A182904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182904.Bytes);
public long this[int i]=>Value[i];

public static A182904Inst Instance=new A182904Inst();

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