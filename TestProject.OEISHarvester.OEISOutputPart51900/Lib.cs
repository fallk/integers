using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A059445
{
public static readonly long[] Value={ 2L,15L,14L,1L,2L,3L,17L,1L,1L,5L,1L,30L,1L,3L,2L,1L,1L,1L,3L,3L,1L,4L,2L,9L,2L,1L,9L,1L,7L,1L,6L,1L,5L,1L,5L,3L,1L,1L,3L,1L,36L,4L,18L,2L,1L,2L,4L,1L,3L,366L,3L,1L,1L,16L,2L,1L,2L,2L,1L,3L,3L,1L,5L,2L,2L,34L,1L,2L,2L,1L,18L,1L,1L,16L,1L,1L,1L,3L,4L,7L,1L,21L,6L,5L,1L,2L,1L,11L,4L,1L,1L,14L,4L,17L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059445Inst : IEnumerable<long>
{
public static readonly long[] Value=A059445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059445.Bytes);
public long this[int i]=>Value[i];

public static A059445Inst Instance=new A059445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059446
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,2L,6L,10L,10L,6L,24L,42L,52L,42L,24L,120L,216L,300L,300L,216L,120L,720L,1320L,1968L,2268L,1968L,1320L,720L,5040L,9360L,14640L,18576L,18576L,14640L,9360L,5040L,40320L,75600L,122400L,166320L,184896L,166320L,122400L,75600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059446Inst : IEnumerable<long>
{
public static readonly long[] Value=A059446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059446.Bytes);
public long this[int i]=>Value[i];

public static A059446Inst Instance=new A059446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059447
{
public static readonly long[] Value={ 1L,2L,4L,9L,14L,16L,12L,34L,52L,90L,60L,66L,54L,42L,30L,126L,114L,102L,624L,760L,680L,580L,540L,748L,740L,520L,672L,408L,666L,360L,264L,546L,510L,330L,318L,2960L,2574L,1782L,1494L,3672L,3114L,2790L,1680L,1386L,1374L,930L,612L,594L,582L,378L,366L,180L,3570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059447Inst : IEnumerable<long>
{
public static readonly long[] Value=A059447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059447.Bytes);
public long this[int i]=>Value[i];

public static A059447Inst Instance=new A059447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059448
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059448Inst : IEnumerable<long>
{
public static readonly long[] Value=A059448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059448.Bytes);
public long this[int i]=>Value[i];

public static A059448Inst Instance=new A059448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059449
{
public static readonly long[] Value={ 1L,2L,8L,14L,89L,164L,18L,266L,304L,292L,2522L,557L,26438L,27045L,57134L,21936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059449Inst : IEnumerable<long>
{
public static readonly long[] Value=A059449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059449.Bytes);
public long this[int i]=>Value[i];

public static A059449Inst Instance=new A059449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059450
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,4L,8L,17L,29L,8L,20L,50L,107L,185L,16L,48L,136L,336L,721L,1257L,32L,112L,352L,968L,2370L,5091L,8925L,64L,256L,880L,2640L,7116L,17304L,37185L,65445L,128L,576L,2144L,6928L,20168L,53596L,129650L,278635L,491825L,256L,1280L,5120L,17664L,54880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059450Inst : IEnumerable<long>
{
public static readonly long[] Value=A059450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059450.Bytes);
public long this[int i]=>Value[i];

public static A059450Inst Instance=new A059450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059451
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,1L,2L,0L,2L,2L,1L,3L,2L,1L,3L,2L,2L,4L,3L,1L,4L,3L,3L,4L,4L,2L,4L,5L,3L,5L,5L,2L,5L,6L,3L,7L,6L,1L,7L,6L,4L,8L,6L,3L,7L,7L,5L,8L,7L,4L,9L,5L,6L,11L,6L,6L,9L,6L,7L,11L,8L,5L,10L,8L,7L,12L,8L,7L,11L,7L,9L,12L,10L,6L,12L,9L,7L,17L,9L,6L,13L,10L,9L,15L,12L,5L,14L,12L,9L,16L,11L,9L,14L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059451Inst : IEnumerable<long>
{
public static readonly long[] Value=A059451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059451.Bytes);
public long this[int i]=>Value[i];

public static A059451Inst Instance=new A059451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059452
{
public static readonly long[] Value={ 7L,47L,59L,107L,167L,227L,263L,347L,383L,467L,479L,503L,563L,587L,839L,863L,887L,983L,1187L,1283L,1307L,1319L,1367L,1487L,1523L,1619L,1823L,1907L,2027L,2099L,2207L,2447L,2579L,2879L,2999L,3119L,3167L,3203L,3467L,3947L,4007L,4079L,4127L,4139L,4259L,4283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059452Inst : IEnumerable<long>
{
public static readonly long[] Value=A059452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059452.Bytes);
public long this[int i]=>Value[i];

public static A059452Inst Instance=new A059452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059453
{
public static readonly long[] Value={ 2L,3L,29L,41L,53L,89L,113L,131L,173L,191L,233L,239L,251L,281L,293L,419L,431L,443L,491L,509L,593L,641L,653L,659L,683L,743L,761L,809L,911L,953L,1013L,1031L,1049L,1103L,1223L,1229L,1289L,1409L,1451L,1481L,1499L,1511L,1559L,1583L,1601L,1733L,1811L,1889L,1901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059453Inst : IEnumerable<long>
{
public static readonly long[] Value=A059453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059453.Bytes);
public long this[int i]=>Value[i];

public static A059453Inst Instance=new A059453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059454
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,9L,14L,39L,51L,73L,101L,155L,183L,286L,291L,310L,313L,335L,570L,951L,1011L,1183L,1930L,2586L,3423L,6486L,7791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059454Inst : IEnumerable<long>
{
public static readonly long[] Value=A059454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059454.Bytes);
public long this[int i]=>Value[i];

public static A059454Inst Instance=new A059454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059455
{
public static readonly long[] Value={ 5L,11L,23L,83L,179L,359L,719L,1019L,1439L,2039L,2063L,2459L,2819L,2903L,2963L,3023L,3623L,3779L,3803L,3863L,4919L,5399L,5639L,6899L,6983L,7079L,7643L,7823L,10163L,10799L,10883L,11699L,12203L,12263L,12899L,14159L,14303L,14699L,15803L,17939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059455Inst : IEnumerable<long>
{
public static readonly long[] Value=A059455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059455.Bytes);
public long this[int i]=>Value[i];

public static A059455Inst Instance=new A059455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059456
{
public static readonly long[] Value={ 2L,3L,13L,17L,19L,29L,31L,37L,41L,43L,53L,61L,67L,71L,73L,79L,89L,97L,101L,103L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,173L,181L,191L,193L,197L,199L,211L,223L,229L,233L,239L,241L,251L,257L,269L,271L,277L,281L,283L,293L,307L,311L,313L,317L,331L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059456Inst : IEnumerable<long>
{
public static readonly long[] Value=A059456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059456.Bytes);
public long this[int i]=>Value[i];

public static A059456Inst Instance=new A059456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059457
{
public static readonly long[] Value={ 1L,3L,25L,111L,1583L,5877L,118943L,1239213L,6500369L,6228669L,200696339L,3293919963L,125884243831L,122175729021L,5401896940303L,121054306890369L,868338554787383L,848589287072283L,867261322002923L,24637097377492167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059457Inst : IEnumerable<long>
{
public static readonly long[] Value=A059457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059457.Bytes);
public long this[int i]=>Value[i];

public static A059457Inst Instance=new A059457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059458
{
public static readonly long[] Value={ 10L,11L,111L,101L,1101L,11101L,11111L,10111L,10011L,10001L,10000000010001L,10000001010001L,10100001010001L,100001010001L,100001010011L,1010011L,1000011L,1000111L,1001111L,10001001111L,10000001111L,10000000111L,10000100111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059458Inst : IEnumerable<long>
{
public static readonly long[] Value=A059458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059458.Bytes);
public long this[int i]=>Value[i];

public static A059458Inst Instance=new A059458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059459
{
public static readonly long[] Value={ 2L,3L,7L,5L,13L,29L,31L,23L,19L,17L,8209L,8273L,10321L,2129L,2131L,83L,67L,71L,79L,1103L,1039L,1031L,1063L,1061L,1069L,263213L,263209L,263201L,265249L,265313L,264289L,280673L,280681L,280697L,280699L,280703L,280639L,280607L,280603L,280859L,280843L,281867L,265483L,265547L,265579L,265571L,266083L,266081L,266089L,266093L,266029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059459Inst : IEnumerable<long>
{
public static readonly long[] Value=A059459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059459.Bytes);
public long this[int i]=>Value[i];

public static A059459Inst Instance=new A059459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059460
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,12L,20L,30L,72L,90L,180L,300L,520L,756L,1120L,1584L,2040L,3888L,4148L,5580L,9600L,13416L,22176L,31680L,46800L,61880L,108864L,126880L,171864L,276480L,344232L,492480L,639600L,1039584L,1663200L,2306304L,3454080L,6390144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059460Inst : IEnumerable<long>
{
public static readonly long[] Value=A059460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059460.Bytes);
public long this[int i]=>Value[i];

public static A059460Inst Instance=new A059460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059461
{
public static readonly long[] Value={ 60L,280L,606L,612L,618L,1206L,1218L,1806L,1812L,2406L,2418L,2424L,3006L,3012L,3018L,3606L,4206L,4218L,4806L,4818L,4824L,4960L,5412L,6006L,6054L,6066L,6078L,6102L,6114L,6126L,6132L,6138L,6144L,6162L,6168L,6174L,6186L,6192L,6198L,6204L,6216L,6606L,6612L,6618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059461Inst : IEnumerable<long>
{
public static readonly long[] Value=A059461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059461.Bytes);
public long this[int i]=>Value[i];

public static A059461Inst Instance=new A059461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059462
{
public static readonly long[] Value={ 6940L,14660L,15460L,17260L,26540L,46940L,52660L,61580L,65420L,66140L,66940L,68140L,69220L,69260L,76940L,86540L,94660L,95660L,106940L,122660L,126580L,126740L,126860L,127180L,145660L,146180L,146344L,146620L,146660L,146980L,148660L,150460L,150740L,151460L,151660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059462Inst : IEnumerable<long>
{
public static readonly long[] Value=A059462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059462.Bytes);
public long this[int i]=>Value[i];

public static A059462Inst Instance=new A059462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059463
{
public static readonly long[] Value={ 168L,282L,1494L,2082L,2802L,2922L,3282L,3882L,5682L,7494L,8226L,8538L,8562L,8682L,8826L,8922L,10482L,11082L,12294L,12846L,12858L,12992L,14082L,14682L,14802L,14838L,14862L,14922L,15882L,16494L,20082L,20802L,21282L,23082L,23682L,24942L,26682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059463Inst : IEnumerable<long>
{
public static readonly long[] Value=A059463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059463.Bytes);
public long this[int i]=>Value[i];

public static A059463Inst Instance=new A059463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059464
{
public static readonly long[] Value={ 1506L,1518L,3012L,3036L,3156L,3174L,4506L,6312L,7512L,9012L,9174L,10518L,10524L,10536L,10554L,13506L,15006L,15018L,15102L,15126L,15144L,15156L,15186L,15192L,15306L,15516L,15906L,16518L,17106L,17124L,17142L,17148L,17718L,19506L,19518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059464Inst : IEnumerable<long>
{
public static readonly long[] Value=A059464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059464.Bytes);
public long this[int i]=>Value[i];

public static A059464Inst Instance=new A059464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059465
{
public static readonly long[] Value={ 528L,27340L,27380L,122780L,130420L,130564L,130580L,134740L,147380L,225932L,227380L,241340L,243220L,245380L,251380L,252380L,252820L,253180L,253420L,253780L,259340L,271340L,272380L,272980L,273140L,273380L,273580L,273820L,279340L,305380L,307220L,322540L,322780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059465Inst : IEnumerable<long>
{
public static readonly long[] Value=A059465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059465.Bytes);
public long this[int i]=>Value[i];

public static A059465Inst Instance=new A059465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059466
{
public static readonly long[] Value={ 2274L,3522L,4434L,4548L,4734L,5142L,5274L,7422L,9468L,10734L,11142L,11274L,13422L,14142L,14166L,14226L,14262L,14622L,14844L,14860L,14922L,16734L,17142L,17274L,18940L,21342L,21426L,21474L,21540L,22254L,22314L,22434L,22614L,22674L,22758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059466Inst : IEnumerable<long>
{
public static readonly long[] Value=A059466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059466.Bytes);
public long this[int i]=>Value[i];

public static A059466Inst Instance=new A059466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059467
{
public static readonly long[] Value={ 336L,1734L,4974L,5616L,7734L,16134L,16734L,16914L,17034L,17058L,17140L,17274L,17364L,17508L,17540L,23340L,25692L,25698L,25716L,25734L,26916L,29364L,34116L,35740L,36534L,37540L,40974L,41628L,46974L,49614L,49746L,49758L,49974L,50340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059467Inst : IEnumerable<long>
{
public static readonly long[] Value=A059467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059467.Bytes);
public long this[int i]=>Value[i];

public static A059467Inst Instance=new A059467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059468
{
public static readonly long[] Value={ 582L,1182L,1194L,2382L,2982L,2994L,3594L,4158L,4182L,4776L,4780L,4782L,5718L,5784L,5802L,5808L,5826L,5844L,5862L,5898L,5946L,5982L,6582L,7782L,8382L,8394L,8958L,8994L,9582L,10182L,10194L,10794L,11382L,11802L,11838L,11874L,11922L,11946L,11958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059468Inst : IEnumerable<long>
{
public static readonly long[] Value=A059468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059468.Bytes);
public long this[int i]=>Value[i];

public static A059468Inst Instance=new A059468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059469
{
public static readonly long[] Value={ 110L,125L,210L,250L,310L,360L,375L,410L,510L,520L,610L,710L,735L,810L,910L,1000L,1010L,1020L,1030L,1040L,1050L,1060L,1070L,1080L,1090L,1100L,1110L,1197L,1210L,1250L,1280L,1296L,1310L,1352L,1410L,1510L,1520L,1593L,1610L,1710L,1734L,1750L,1810L,1910L,2010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059469Inst : IEnumerable<long>
{
public static readonly long[] Value=A059469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059469.Bytes);
public long this[int i]=>Value[i];

public static A059469Inst Instance=new A059469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059470
{
public static readonly long[] Value={ 125L,375L,735L,1197L,1296L,1352L,1593L,1734L,2346L,3125L,4224L,4872L,5775L,8448L,9072L,11715L,12768L,13455L,14476L,14673L,15625L,16128L,17136L,17493L,18432L,21168L,22176L,23184L,23391L,27216L,27375L,27648L,27864L,32256L,34272L,34398L,36288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059470Inst : IEnumerable<long>
{
public static readonly long[] Value=A059470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059470.Bytes);
public long this[int i]=>Value[i];

public static A059470Inst Instance=new A059470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059471
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,11L,13L,19L,29L,23L,43L,41L,47L,37L,31L,61L,67L,97L,197L,191L,193L,199L,109L,101L,103L,107L,127L,137L,131L,139L,149L,179L,173L,113L,163L,167L,157L,151L,181L,281L,283L,223L,227L,229L,239L,233L,263L,269L,569L,563L,503L,509L,599L,593L,523L,521L,541L,547L,557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059471Inst : IEnumerable<long>
{
public static readonly long[] Value=A059471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059471.Bytes);
public long this[int i]=>Value[i];

public static A059471Inst Instance=new A059471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059472
{
public static readonly long[] Value={ 53L,59L,71L,73L,79L,83L,89L,293L,331L,337L,367L,397L,479L,761L,769L,797L,811L,907L,911L,919L,929L,937L,941L,947L,953L,967L,971L,977L,983L,991L,997L,1021L,1051L,1087L,1103L,1109L,1117L,1123L,1129L,1151L,1153L,1163L,1171L,1181L,1187L,1193L,1301L,1303L,1307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059472Inst : IEnumerable<long>
{
public static readonly long[] Value=A059472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059472.Bytes);
public long this[int i]=>Value[i];

public static A059472Inst Instance=new A059472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059473
{
public static readonly long[] Value={ 1L,2L,2L,4L,10L,4L,8L,32L,32L,8L,16L,88L,148L,88L,16L,32L,224L,536L,536L,224L,32L,64L,544L,1696L,2440L,1696L,544L,64L,128L,1280L,4928L,9344L,9344L,4928L,1280L,128L,256L,2944L,13504L,31936L,42256L,31936L,13504L,2944L,256L,512L,6656L,35456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059473Inst : IEnumerable<long>
{
public static readonly long[] Value=A059473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059473.Bytes);
public long this[int i]=>Value[i];

public static A059473Inst Instance=new A059473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059474
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,4L,8L,16L,16L,8L,16L,40L,52L,40L,16L,32L,96L,152L,152L,96L,32L,64L,224L,416L,504L,416L,224L,64L,128L,512L,1088L,1536L,1536L,1088L,512L,128L,256L,1152L,2752L,4416L,5136L,4416L,2752L,1152L,256L,512L,2560L,6784L,12160L,16032L,16032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059474Inst : IEnumerable<long>
{
public static readonly long[] Value=A059474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059474.Bytes);
public long this[int i]=>Value[i];

public static A059474Inst Instance=new A059474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059475
{
public static readonly BigInteger[] Value={ 1L,2L,10L,140L,5544L,622908L,198846076L,180473355920L,465904151957920L,3422048076740462480L,BigInteger.Parse("71525763221287897903500"),BigInteger.Parse("4254840960508487045451825000"),BigInteger.Parse("720428791920558617462950575000000"),BigInteger.Parse("347230535542092373572967034254050000000") };
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
public class A059475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059475Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059475.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059475.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059475Inst Instance=new A059475Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059476
{
public static readonly BigInteger[] Value={ 1L,2L,40L,6860L,9779616L,114640611228L,10995014015567296L,BigInteger.Parse("8604220484134405095680"),BigInteger.Parse("54849585336544518476372715520"),BigInteger.Parse("2845241019832977820277705514596768000"),BigInteger.Parse("1200139922362764777157943140382976769515000000") };
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
public class A059476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059476Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059476.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059476.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059476Inst Instance=new A059476Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059477
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,90L,2025L,102060L,11573604L,2946308904L,1687603650084L,2171945897658108L,6289412333143466241L,BigInteger.Parse("40940643700218614247324"),BigInteger.Parse("599627833263501883888374756"),BigInteger.Parse("19747212169938041691404746667280"),BigInteger.Parse("1463229065460461810019231236067824400") };
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
public class A059477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059477Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059477.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059477.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059477Inst Instance=new A059477Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059478
{
public static readonly long[] Value={ 1L,1L,3L,7L,7L,15L,15L,5L,31L,31L,31L,31L,31L,31L,63L,9L,21L,63L,63L,63L,63L,63L,21L,127L,127L,127L,127L,127L,127L,127L,127L,127L,127L,127L,127L,127L,127L,127L,127L,127L,127L,51L,255L,255L,255L,17L,85L,255L,255L,255L,255L,255L,255L,85L,85L,255L,85L,255L,51L,85L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059478Inst : IEnumerable<long>
{
public static readonly long[] Value=A059478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059478.Bytes);
public long this[int i]=>Value[i];

public static A059478Inst Instance=new A059478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059479
{
public static readonly long[] Value={ 1L,4L,9L,64L,25L,36L,49L,256L,729L,100L,121L,576L,169L,196L,225L,4096L,289L,2916L,361L,1600L,441L,484L,529L,2304L,15625L,676L,6561L,3136L,841L,900L,961L,16384L,1089L,1156L,1225L,46656L,1369L,1444L,1521L,6400L,1681L,1764L,1849L,7744L,18225L,2116L,2209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059479Inst : IEnumerable<long>
{
public static readonly long[] Value=A059479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059479.Bytes);
public long this[int i]=>Value[i];

public static A059479Inst Instance=new A059479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059480
{
public static readonly long[] Value={ 1L,1L,4L,8L,28L,76L,272L,880L,3328L,12128L,48736L,194272L,827840L,3547648L,15965248L,72727616L,344136832L,1653233920L,8191833728L,41256512128L,213285020416L,1120928287232L,6026483756800L,32928762650368L,183590856570368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059480Inst : IEnumerable<long>
{
public static readonly long[] Value=A059480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059480.Bytes);
public long this[int i]=>Value[i];

public static A059480Inst Instance=new A059480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059481
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,3L,6L,10L,1L,4L,10L,20L,35L,1L,5L,15L,35L,70L,126L,1L,6L,21L,56L,126L,252L,462L,1L,7L,28L,84L,210L,462L,924L,1716L,1L,8L,36L,120L,330L,792L,1716L,3432L,6435L,1L,9L,45L,165L,495L,1287L,3003L,6435L,12870L,24310L,1L,10L,55L,220L,715L,2002L,5005L,11440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059481Inst : IEnumerable<long>
{
public static readonly long[] Value=A059481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059481.Bytes);
public long this[int i]=>Value[i];

public static A059481Inst Instance=new A059481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059482
{
public static readonly long[] Value={ 1L,9L,89L,889L,8889L,88889L,888889L,8888889L,88888889L,888888889L,8888888889L,88888888889L,888888888889L,8888888888889L,88888888888889L,888888888888889L,8888888888888889L,88888888888888889L,888888888888888889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059482Inst : IEnumerable<long>
{
public static readonly long[] Value=A059482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059482.Bytes);
public long this[int i]=>Value[i];

public static A059482Inst Instance=new A059482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059483
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L,2L,6L,0L,0L,0L,0L,0L,0L,0L,0L,12L,1L,0L,0L,0L,0L,0L,0L,0L,0L,2L,18L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,16L,8L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059483Inst : IEnumerable<long>
{
public static readonly long[] Value=A059483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059483.Bytes);
public long this[int i]=>Value[i];

public static A059483Inst Instance=new A059483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059484
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,0L,1L,5L,0L,0L,0L,0L,0L,0L,0L,0L,7L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,13L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,9L,7L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,25L,1L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059484Inst : IEnumerable<long>
{
public static readonly long[] Value=A059484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059484.Bytes);
public long this[int i]=>Value[i];

public static A059484Inst Instance=new A059484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059485
{
public static readonly long[] Value={ 5L,7L,10L,11L,13L,14L,15L,17L,19L,20L,21L,22L,23L,25L,26L,28L,29L,30L,31L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,80L,82L,83L,84L,85L,86L,87L,88L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059485Inst : IEnumerable<long>
{
public static readonly long[] Value=A059485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059485.Bytes);
public long this[int i]=>Value[i];

public static A059485Inst Instance=new A059485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059486
{
public static readonly BigInteger[] Value={ 1L,1L,5L,126L,16038L,10320453L,33590259846L,553104735325740L,BigInteger.Parse("46084184498427053436"),BigInteger.Parse("19430969437346561065941390"),BigInteger.Parse("41463730793298298041665385308325"),BigInteger.Parse("447814224393522724673729884056814834500"),BigInteger.Parse("24479424309393636290695101063892553945412075000") };
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
public class A059486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059486Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059486.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059486.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059486Inst Instance=new A059486Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059487
{
public static readonly BigInteger[] Value={ 1L,2L,80L,53760L,590413824L,104981650735104L,BigInteger.Parse("300931721514121691136"),BigInteger.Parse("13874404129378738693891686400"),BigInteger.Parse("10274196157891080769280680484929536000"),BigInteger.Parse("122089077024940067215877965611538507917950976000"),BigInteger.Parse("23266604385482749027479729551862778584550130343015874560000") };
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
public class A059487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059487Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059487.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059487.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059487Inst Instance=new A059487Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059488
{
public static readonly BigInteger[] Value={ 1L,6L,140L,12936L,4756752L,6974908512L,40825196325056L,954410297723625600L,BigInteger.Parse("89149543741372647686400"),BigInteger.Parse("33280303224443643993143232000"),BigInteger.Parse("49660896290963321355372907102080000"),BigInteger.Parse("296248087478941460167300263349693113600000"),BigInteger.Parse("7065635944743752671502919147104799866118720000000") };
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
public class A059488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059488Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059488.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059488.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059488Inst Instance=new A059488Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059489
{
public static readonly BigInteger[] Value={ 1L,5L,66L,2431L,252586L,74327145L,62062015500L,147198472495020L,992340657705109416L,BigInteger.Parse("19023173201224270401428"),BigInteger.Parse("1037283901500845276138040124"),BigInteger.Parse("160915151663568862349180293275135"),BigInteger.Parse("71031251058324655345105192111798148156"),BigInteger.Parse("89229337105909072018801794323387547092631236") };
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
public class A059489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059489Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059489.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059489.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059489Inst Instance=new A059489Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059490
{
public static readonly BigInteger[] Value={ 1L,1L,5L,105L,9009L,3128697L,4379132901L,24645892667825L,556965289746386625L,BigInteger.Parse("50494858759761851228625"),BigInteger.Parse("18354114596951084500741513125"),BigInteger.Parse("26735929307256782047733105984465625"),BigInteger.Parse("156023842049488378026019378718492161640625"),BigInteger.Parse("3646806710157227756289546514549111188854996015625") };
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
public class A059490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059490Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059490.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059490.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059490Inst Instance=new A059490Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059491
{
public static readonly BigInteger[] Value={ 1L,1L,6L,189L,30618L,25332021L,106698472452L,2283997201168644L,BigInteger.Parse("248218139523497121576"),BigInteger.Parse("136861610819571430116630660"),BigInteger.Parse("382684747771430768732371981946100"),BigInteger.Parse("5424628155237728987530088501811168904125"),BigInteger.Parse("389729317367139375014273384868937660572301897500") };
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
public class A059491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059491Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059491.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059491.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059491Inst Instance=new A059491Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059492
{
public static readonly BigInteger[] Value={ 1L,1L,9L,676L,417316L,2105433225L,86576511622500L,BigInteger.Parse("28972583638980195600"),BigInteger.Parse("78831929114313969179740176"),BigInteger.Parse("1742936131827576565608759271801924"),BigInteger.Parse("312998895971128640129284150531179425539849"),BigInteger.Parse("456409483679643917229799018559460369930900420149904") };
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
public class A059492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059492Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059492.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059492.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059492Inst Instance=new A059492Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059493
{
public static readonly BigInteger[] Value={ 1L,36L,58800L,4350842496L,14616841474819584L,BigInteger.Parse("2232275367429083934397440"),BigInteger.Parse("15508029030753757178368051489382400"),BigInteger.Parse("4903022043055128535359103830176804216217600000"),BigInteger.Parse("70564996915837622037116996413540007182305594153356328960000") };
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
public class A059493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059493Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059493.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059493.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059493Inst Instance=new A059493Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059494
{
public static readonly BigInteger[] Value={ 2L,2L,10L,46L,362L,298L,46162L,1505304098L,17376907720394L,9286834445316902L,9328321181472828398UL,BigInteger.Parse("2107597973657165184339850860393713575649657317180489057212823189967494080057958"),BigInteger.Parse("22958222111004899714849436789827362390710508069726899926224050897274623732073762499062593658") };
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
public class A059494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059494Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059494.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059494.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059494Inst Instance=new A059494Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059495
{
public static readonly BigInteger[] Value={ 1L,3L,3L,45L,3L,381L,2349L,115329357L,10279641655875L,5033685952807971L,5263826472436016979L,BigInteger.Parse("898670952308059000662208200339860406351380028634597445743368513219427297854627"),BigInteger.Parse("1163046333059983884005407440923089001865672520479660324278034104804471332063117356524700189") };
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
public class A059495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059495Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059495.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059495.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059495Inst Instance=new A059495Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059496
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,11L,13L,19L,29L,23L,43L,41L,47L,37L,31L,61L,67L,97L,197L,191L,193L,199L,139L,131L,137L,127L,157L,151L,181L,281L,283L,223L,227L,229L,239L,233L,263L,269L,569L,563L,523L,521L,541L,547L,557L,577L,571L,271L,277L,257L,251L,211L,241L,641L,643L,647L,617L,613L,619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059496Inst : IEnumerable<long>
{
public static readonly long[] Value=A059496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059496.Bytes);
public long this[int i]=>Value[i];

public static A059496Inst Instance=new A059496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059497
{
public static readonly long[] Value={ 53L,59L,71L,73L,79L,83L,89L,101L,103L,107L,109L,113L,293L,307L,373L,379L,383L,389L,397L,401L,409L,421L,479L,491L,499L,503L,509L,593L,599L,601L,607L,631L,661L,683L,691L,701L,709L,797L,809L,811L,907L,911L,919L,929L,937L,941L,947L,953L,967L,971L,977L,983L,991L,997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059497Inst : IEnumerable<long>
{
public static readonly long[] Value=A059497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059497.Bytes);
public long this[int i]=>Value[i];

public static A059497Inst Instance=new A059497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059498
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,19L,29L,59L,79L,89L,389L,2389L,2399L,2699L,2999L,4999L,8999L,98999L,298999L,598999L,599999L,799999L,1799999L,4799999L,4999999L,904999999L,974999999L,60974999999L,68974999999L,68975999999L,3000068975999999L,3000568975999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059498Inst : IEnumerable<long>
{
public static readonly long[] Value=A059498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059498.Bytes);
public long this[int i]=>Value[i];

public static A059498Inst Instance=new A059498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059499
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,1L,4L,2L,5L,3L,16L,1L,5L,5L,8L,1L,24L,1L,38L,9L,11L,3L,68L,6L,5L,4L,54L,7L,79L,1L,16L,11L,5L,13L,462L,3L,5L,13L,140L,3L,123L,7L,110L,54L,11L,7L,664L,2L,114L,29L,118L,7L,124L,59L,188L,13L,55L,3L,4456L,1L,5L,82L,96L,5L,353L,3L,118L,11L,485L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059499Inst : IEnumerable<long>
{
public static readonly long[] Value=A059499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059499.Bytes);
public long this[int i]=>Value[i];

public static A059499Inst Instance=new A059499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059500
{
public static readonly long[] Value={ 13L,17L,19L,31L,37L,43L,61L,67L,71L,73L,79L,97L,101L,103L,109L,127L,137L,139L,149L,151L,157L,163L,181L,193L,197L,199L,211L,223L,229L,241L,257L,269L,271L,277L,283L,307L,311L,313L,317L,331L,337L,349L,353L,367L,373L,379L,389L,397L,401L,409L,421L,433L,439L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059500Inst : IEnumerable<long>
{
public static readonly long[] Value=A059500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059500.Bytes);
public long this[int i]=>Value[i];

public static A059500Inst Instance=new A059500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059501
{
public static readonly long[] Value={ 2L,4L,7L,24L,25L,47L,57L,60L,241L,391L,1252L,1391L,2340L,4062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059501Inst : IEnumerable<long>
{
public static readonly long[] Value=A059501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059501.Bytes);
public long this[int i]=>Value[i];

public static A059501Inst Instance=new A059501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059502
{
public static readonly long[] Value={ 0L,1L,3L,9L,27L,80L,234L,677L,1941L,5523L,15615L,43906L,122868L,342409L,950727L,2631165L,7260579L,19982612L,54865566L,150316973L,411015705L,1121818311L,3056773383L,8316416134L,22593883752L,61301547025L,166118284299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059502Inst : IEnumerable<long>
{
public static readonly long[] Value=A059502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059502.Bytes);
public long this[int i]=>Value[i];

public static A059502Inst Instance=new A059502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059503
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,9L,4L,7L,14L,27L,5L,9L,19L,40L,80L,6L,11L,24L,53L,114L,234L,7L,13L,29L,66L,148L,323L,677L,8L,15L,34L,79L,182L,412L,910L,1941L,9L,17L,39L,92L,216L,501L,1143L,2551L,5523L,10L,19L,44L,105L,250L,590L,1376L,3161L,7120L,15615L,11L,21L,49L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059503Inst : IEnumerable<long>
{
public static readonly long[] Value=A059503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059503.Bytes);
public long this[int i]=>Value[i];

public static A059503Inst Instance=new A059503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059504
{
public static readonly long[] Value={ 10L,12L,13L,14L,15L,16L,17L,18L,19L,22L,1012L,1013L,1014L,1015L,1016L,1017L,1018L,1019L,1021L,1022L,1210L,1213L,1214L,1215L,1216L,1217L,1218L,1219L,1310L,1312L,1314L,1315L,1316L,1317L,1318L,1319L,1321L,1322L,1410L,1412L,1413L,1415L,1416L,1417L,1418L,1419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059504Inst : IEnumerable<long>
{
public static readonly long[] Value=A059504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059504.Bytes);
public long this[int i]=>Value[i];

public static A059504Inst Instance=new A059504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059505
{
public static readonly long[] Value={ 2L,5L,14L,40L,114L,323L,910L,2551L,7120L,19796L,54852L,151525L,417434L,1147145L,3145394L,8606848L,23507190L,64093031L,174474790L,474261691L,1287398452L,3490267820L,9451319304L,25565098825L,69080289074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059505Inst : IEnumerable<long>
{
public static readonly long[] Value=A059505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059505.Bytes);
public long this[int i]=>Value[i];

public static A059505Inst Instance=new A059505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059506
{
public static readonly long[] Value={ 3L,7L,19L,53L,148L,412L,1143L,3161L,8717L,23977L,65798L,180182L,492459L,1343563L,3659623L,9953117L,27031768L,73320496L,198632607L,537507677L,1452978593L,3923762257L,10586222474L,28536313898L,76859031123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059506Inst : IEnumerable<long>
{
public static readonly long[] Value=A059506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059506.Bytes);
public long this[int i]=>Value[i];

public static A059506Inst Instance=new A059506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059507
{
public static readonly long[] Value={ 4L,9L,24L,66L,182L,501L,1376L,3771L,10314L,28158L,76744L,208839L,567484L,1539981L,4173852L,11299386L,30556346L,82547961L,222790424L,600753663L,1618558734L,4357256694L,11721125644L,31507528971L,84637773172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059507Inst : IEnumerable<long>
{
public static readonly long[] Value=A059507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059507.Bytes);
public long this[int i]=>Value[i];

public static A059507Inst Instance=new A059507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059508
{
public static readonly long[] Value={ 5L,11L,29L,79L,216L,590L,1609L,4381L,11911L,32339L,87690L,237496L,642509L,1736399L,4688081L,12645655L,34080924L,91775426L,246948241L,663999649L,1784138875L,4790751131L,12856028814L,34478744044L,92416515221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059508Inst : IEnumerable<long>
{
public static readonly long[] Value=A059508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059508.Bytes);
public long this[int i]=>Value[i];

public static A059508Inst Instance=new A059508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059509
{
public static readonly long[] Value={ 1L,5L,19L,66L,216L,679L,2075L,6211L,18299L,53244L,153366L,438095L,1242709L,3504161L,9830371L,27454614L,76375860L,211732471L,585157679L,1612689439L,4433421131L,12160156560L,33284285874L,90931830431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059509Inst : IEnumerable<long>
{
public static readonly long[] Value=A059509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059509.Bytes);
public long this[int i]=>Value[i];

public static A059509Inst Instance=new A059509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059510
{
public static readonly long[] Value={ 1L,1L,8L,152L,4493L,202066L,12841750L,1097043147L,121284672716L,16850062144162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059510Inst : IEnumerable<long>
{
public static readonly long[] Value=A059510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059510.Bytes);
public long this[int i]=>Value[i];

public static A059510Inst Instance=new A059510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059511
{
public static readonly long[] Value={ 1L,3L,26L,471L,13953L,627421L,39873948L,3406344237L,376591685322L,52319828460127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059511Inst : IEnumerable<long>
{
public static readonly long[] Value=A059511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059511.Bytes);
public long this[int i]=>Value[i];

public static A059511Inst Instance=new A059511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059512
{
public static readonly long[] Value={ 0L,1L,1L,3L,7L,18L,46L,119L,309L,805L,2101L,5490L,14356L,37557L,98281L,257231L,673323L,1762594L,4614226L,12079707L,31624285L,82792161L,216750601L,567457058L,1485616392L,3889385353L,10182528721L,26658183099L,69791991919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059512Inst : IEnumerable<long>
{
public static readonly long[] Value=A059512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059512.Bytes);
public long this[int i]=>Value[i];

public static A059512Inst Instance=new A059512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059513
{
public static readonly long[] Value={ 1L,2L,6L,23L,116L,736L,5659L,50796L,521040L,6006587L,76874524L,1081439062L,16586149365L,275442822510L,4924040788654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059513Inst : IEnumerable<long>
{
public static readonly long[] Value=A059513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059513.Bytes);
public long this[int i]=>Value[i];

public static A059513Inst Instance=new A059513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059514
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,11L,4L,28L,42L,7315L,208L,136L,2L,19L,10L,7L,11L,69L,4L,2310L,28L,3L,42L,319L,10L,189885850L,96L,11L,323323L,205530L,4L,37L,228L,28L,10L,123L,7L,559L,11L,5L,69L,517L,4L,152152L,10L,187L,28L,424L,6L,11L,154L,0L,77140L,2478L,10L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059514Inst : IEnumerable<long>
{
public static readonly long[] Value=A059514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059514.Bytes);
public long this[int i]=>Value[i];

public static A059514Inst Instance=new A059514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059515
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,7L,1L,0L,0L,0L,12L,25L,1L,0L,0L,0L,6L,138L,79L,1L,0L,0L,0L,0L,294L,1056L,241L,1L,0L,0L,0L,0L,270L,5298L,7050L,727L,1L,0L,0L,0L,0L,90L,12780L,70350L,44472L,2185L,1L,0L,0L,0L,0L,0L,16020L,334710L,817746L,273378L,6559L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059515Inst : IEnumerable<long>
{
public static readonly long[] Value=A059515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059515.Bytes);
public long this[int i]=>Value[i];

public static A059515Inst Instance=new A059515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059516
{
public static readonly BigInteger[] Value={ 1L,2L,26L,818L,47834L,4488722L,617364026L,117029670578L,29247820616474L,9318336983422802L,3686400233750527226L,BigInteger.Parse("1772940711343815069938"),BigInteger.Parse("1018732890334074636017114"),BigInteger.Parse("689260602916515788253448082") };
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
public class A059516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059516Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059516.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059516.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059516Inst Instance=new A059516Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059517
{
public static readonly long[] Value={ 0L,0L,12L,138L,1056L,7050L,44472L,273378L,1659936L,10018650L,60289032L,362265618L,2175188016L,13055911050L,78349815192L,470141937858L,2820980767296L,16926272024250L,101558794406952L,609356253226098L,3656147979709776L,21936919259318250L,131621609699088312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059517Inst : IEnumerable<long>
{
public static readonly long[] Value=A059517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059517.Bytes);
public long this[int i]=>Value[i];

public static A059517Inst Instance=new A059517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059518
{
public static readonly long[] Value={ 0L,1L,3L,8L,17L,29L,42L,69L,99L,135L,181L,228L,299L,371L,464L,560L,668L,788L,912L,1093L,1275L,1463L,1667L,1895L,2137L,2403L,2673L,2997L,3346L,3705L,4092L,4503L,4923L,5370L,5853L,6363L,6882L,7512L,8154L,8813L,9488L,10164L,10924L,11963L,12506L,13361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059518Inst : IEnumerable<long>
{
public static readonly long[] Value=A059518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059518.Bytes);
public long this[int i]=>Value[i];

public static A059518Inst Instance=new A059518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059519
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,11L,12L,14L,16L,17L,18L,19L,20L,21L,24L,26L,28L,32L,33L,34L,35L,36L,37L,38L,40L,41L,44L,48L,50L,52L,56L,64L,65L,66L,67L,68L,69L,70L,72L,73L,74L,80L,81L,84L,88L,96L,98L,100L,104L,112L,116L,128L,129L,130L,131L,132L,133L,134L,136L,137L,138L,139L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059519Inst : IEnumerable<long>
{
public static readonly long[] Value=A059519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059519.Bytes);
public long this[int i]=>Value[i];

public static A059519Inst Instance=new A059519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059520
{
public static readonly long[] Value={ 7L,13L,15L,22L,23L,25L,27L,29L,30L,31L,39L,42L,43L,45L,46L,47L,49L,51L,53L,54L,55L,57L,58L,59L,60L,61L,62L,63L,71L,75L,76L,77L,78L,79L,82L,83L,85L,86L,87L,89L,90L,91L,92L,93L,94L,95L,97L,99L,101L,102L,103L,105L,106L,107L,108L,109L,110L,111L,113L,114L,115L,117L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059520Inst : IEnumerable<long>
{
public static readonly long[] Value=A059520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059520.Bytes);
public long this[int i]=>Value[i];

public static A059520Inst Instance=new A059520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059521
{
public static readonly long[] Value={ 5L,1L,2L,5L,1L,8L,1L,2L,5L,1L,5L,1L,2L,1L,8L,1L,2L,5L,1L,1L,2L,5L,1L,8L,1L,5L,1L,2L,1L,8L,1L,2L,5L,1L,1L,8L,1L,2L,5L,1L,5L,1L,2L,1L,1L,2L,5L,1L,8L,1L,5L,1L,2L,1L,8L,1L,2L,5L,1L,1L,5L,1L,2L,1L,8L,1L,2L,5L,1L,1L,2L,5L,1L,8L,1L,1L,8L,1L,2L,5L,1L,5L,1L,2L,1L,1L,2L,5L,1L,8L,1L,5L,1L,2L,1L,8L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059521Inst : IEnumerable<long>
{
public static readonly long[] Value=A059521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059521.Bytes);
public long this[int i]=>Value[i];

public static A059521Inst Instance=new A059521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059522
{
public static readonly BigInteger[] Value={ 1L,2L,12L,168L,4680L,223920L,16470720L,1725655680L,244074902400L,44799999955200L,10353389902732800L,2941340482417075200L,BigInteger.Parse("1007483754568427136000"),BigInteger.Parse("409436080665631065446400"),BigInteger.Parse("194769597399609368328192000"),BigInteger.Parse("107210375103315036907081728000"),BigInteger.Parse("67610055415398119744255815680000") };
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
public class A059522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059522.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059522Inst Instance=new A059522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059523
{
public static readonly BigInteger[] Value={ 1L,2L,2L,36L,19020L,2010231696L,9219217412568364176L,BigInteger.Parse("170141181796805105960861096082778425120"),BigInteger.Parse("57896044618658097536026644159052312977171804852352892309392604715987334365792") };
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
public class A059523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059523.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059523Inst Instance=new A059523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059524
{
public static readonly long[] Value={ 0L,10L,108L,1126L,11506L,116166L,1168586L,11749134L,118127408L,1187692422L,11941503498L,120064335342L,1207171430452L,12137349489598L,122033415224922L,1226969238084836L,12336404001299200L,124034783402890620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059524Inst : IEnumerable<long>
{
public static readonly long[] Value=A059524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059524.Bytes);
public long this[int i]=>Value[i];

public static A059524Inst Instance=new A059524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059525
{
public static readonly BigInteger[] Value={ 0L,1L,13L,218L,11506L,2301877L,1732082741L,4872949974666L,51016818604894742L,BigInteger.Parse("1980555831431088025753"),BigInteger.Parse("284374318545830329487309785"),BigInteger.Parse("150730745416633777472365437495914"),BigInteger.Parse("294516896499779486414143877573183893666"),BigInteger.Parse("2119097214294718323017954923662829194285541981") };
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
public class A059525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059525.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059525Inst Instance=new A059525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059526
{
public static readonly long[] Value={ 3L,1L,8L,1L,3L,1L,5L,0L,5L,2L,0L,4L,7L,6L,4L,1L,3L,5L,3L,1L,2L,6L,5L,4L,2L,5L,1L,5L,8L,7L,6L,6L,4L,5L,1L,7L,2L,0L,3L,5L,1L,7L,6L,1L,3L,8L,7L,1L,3L,9L,9L,8L,6L,6L,9L,2L,2L,3L,7L,8L,6L,0L,6L,2L,2L,9L,4L,1L,3L,8L,7L,1L,5L,5L,7L,6L,2L,6L,9L,7L,9L,2L,3L,2L,4L,8L,6L,3L,8L,4L,8L,9L,8L,6L,3L,6L,1L,6L,3L,8L,4L,4L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059526Inst : IEnumerable<long>
{
public static readonly long[] Value=A059526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059526.Bytes);
public long this[int i]=>Value[i];

public static A059526Inst Instance=new A059526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059527
{
public static readonly long[] Value={ 1L,3L,3L,7L,2L,3L,5L,7L,0L,1L,4L,3L,0L,6L,8L,9L,4L,0L,8L,9L,0L,1L,1L,6L,2L,1L,4L,3L,1L,9L,3L,7L,1L,0L,6L,1L,2L,5L,3L,9L,5L,0L,2L,1L,3L,8L,4L,6L,0L,5L,1L,2L,4L,1L,8L,8L,7L,6L,3L,1L,2L,7L,8L,1L,9L,1L,4L,3L,5L,0L,5L,3L,1L,3L,6L,1L,2L,0L,4L,9L,8L,8L,4L,1L,8L,8L,8L,1L,3L,2L,3L,4L,3L,8L,7L,9L,4L,0L,1L,5L,6L,1L,0L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059527Inst : IEnumerable<long>
{
public static readonly long[] Value=A059527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059527.Bytes);
public long this[int i]=>Value[i];

public static A059527Inst Instance=new A059527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059528
{
public static readonly long[] Value={ 1L,3L,5L,15L,21L,27L,65L,191L,327L,371L,575L,1895L,2375L,2607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059528Inst : IEnumerable<long>
{
public static readonly long[] Value=A059528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059528.Bytes);
public long this[int i]=>Value[i];

public static A059528Inst Instance=new A059528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059529
{
public static readonly long[] Value={ 1L,1L,2L,5L,9L,16L,32L,68L,135L,256L,512L,1059L,2110L,4096L,8192L,16745L,33425L,65536L,131072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059529Inst : IEnumerable<long>
{
public static readonly long[] Value=A059529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059529.Bytes);
public long this[int i]=>Value[i];

public static A059529Inst Instance=new A059529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059530
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,3L,1L,0L,0L,0L,0L,1L,39L,89L,43L,3L,0L,0L,0L,0L,0L,252L,2192L,4090L,2435L,445L,12L,0L,0L,0L,0L,0L,1260L,37080L,179890L,289170L,188540L,50645L,4710L,70L,0L,0L,0L,0L,0L,5040L,536760L,6052730L,20660055L,29432319L,19826737L,6481160L,964495L,52430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059530Inst : IEnumerable<long>
{
public static readonly long[] Value=A059530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059530.Bytes);
public long this[int i]=>Value[i];

public static A059530Inst Instance=new A059530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059531
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,9L,10L,11L,13L,14L,15L,17L,18L,19L,21L,22L,23L,25L,26L,27L,29L,30L,31L,32L,34L,35L,36L,38L,39L,40L,42L,43L,44L,46L,47L,48L,50L,51L,52L,54L,55L,56L,58L,59L,60L,61L,63L,64L,65L,67L,68L,69L,71L,72L,73L,75L,76L,77L,79L,80L,81L,83L,84L,85L,87L,88L,89L,90L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059531Inst : IEnumerable<long>
{
public static readonly long[] Value=A059531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059531.Bytes);
public long this[int i]=>Value[i];

public static A059531Inst Instance=new A059531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059532
{
public static readonly long[] Value={ 4L,8L,12L,16L,20L,24L,28L,33L,37L,41L,45L,49L,53L,57L,62L,66L,70L,74L,78L,82L,86L,91L,95L,99L,103L,107L,111L,115L,120L,124L,128L,132L,136L,140L,144L,149L,153L,157L,161L,165L,169L,173L,178L,182L,186L,190L,194L,198L,202L,207L,211L,215L,219L,223L,227L,231L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059532Inst : IEnumerable<long>
{
public static readonly long[] Value=A059532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059532.Bytes);
public long this[int i]=>Value[i];

public static A059532Inst Instance=new A059532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059533
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,114L,116L,118L,120L,122L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059533Inst : IEnumerable<long>
{
public static readonly long[] Value=A059533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059533.Bytes);
public long this[int i]=>Value[i];

public static A059533Inst Instance=new A059533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059534
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,16L,18L,20L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,92L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,115L,117L,119L,121L,123L,125L,127L,129L,131L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059534Inst : IEnumerable<long>
{
public static readonly long[] Value=A059534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059534.Bytes);
public long this[int i]=>Value[i];

public static A059534Inst Instance=new A059534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059535
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,9L,11L,13L,14L,16L,18L,19L,21L,23L,24L,26L,27L,29L,31L,32L,34L,36L,37L,39L,41L,42L,44L,46L,47L,49L,50L,52L,54L,55L,57L,59L,60L,62L,64L,65L,67L,69L,70L,72L,74L,75L,77L,78L,80L,82L,83L,85L,87L,88L,90L,92L,93L,95L,97L,98L,100L,101L,103L,105L,106L,108L,110L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059535Inst : IEnumerable<long>
{
public static readonly long[] Value=A059535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059535.Bytes);
public long this[int i]=>Value[i];

public static A059535Inst Instance=new A059535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059536
{
public static readonly long[] Value={ 2L,5L,7L,10L,12L,15L,17L,20L,22L,25L,28L,30L,33L,35L,38L,40L,43L,45L,48L,51L,53L,56L,58L,61L,63L,66L,68L,71L,73L,76L,79L,81L,84L,86L,89L,91L,94L,96L,99L,102L,104L,107L,109L,112L,114L,117L,119L,122L,124L,127L,130L,132L,135L,137L,140L,142L,145L,147L,150L,153L,155L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059536Inst : IEnumerable<long>
{
public static readonly long[] Value=A059536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059536.Bytes);
public long this[int i]=>Value[i];

public static A059536Inst Instance=new A059536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059537
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,18L,19L,20L,21L,22L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,36L,37L,38L,39L,40L,42L,43L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,60L,61L,62L,63L,64L,66L,67L,68L,69L,70L,72L,73L,74L,75L,76L,78L,79L,80L,81L,82L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059537Inst : IEnumerable<long>
{
public static readonly long[] Value=A059537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059537.Bytes);
public long this[int i]=>Value[i];

public static A059537Inst Instance=new A059537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059538
{
public static readonly long[] Value={ 5L,11L,17L,23L,29L,35L,41L,47L,53L,59L,65L,71L,77L,83L,89L,95L,101L,107L,113L,118L,124L,130L,136L,142L,148L,154L,160L,166L,172L,178L,184L,190L,196L,202L,208L,214L,220L,226L,232L,237L,243L,249L,255L,261L,267L,273L,279L,285L,291L,297L,303L,309L,315L,321L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059538Inst : IEnumerable<long>
{
public static readonly long[] Value=A059538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059538.Bytes);
public long this[int i]=>Value[i];

public static A059538Inst Instance=new A059538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059539
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,11L,12L,14L,15L,17L,18L,20L,21L,23L,24L,25L,27L,28L,30L,31L,33L,34L,36L,37L,38L,40L,41L,43L,44L,46L,47L,49L,50L,51L,53L,54L,56L,57L,59L,60L,62L,63L,64L,66L,67L,69L,70L,72L,73L,74L,76L,77L,79L,80L,82L,83L,85L,86L,87L,89L,90L,92L,93L,95L,96L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059539Inst : IEnumerable<long>
{
public static readonly long[] Value=A059539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059539.Bytes);
public long this[int i]=>Value[i];

public static A059539Inst Instance=new A059539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059540
{
public static readonly long[] Value={ 3L,6L,9L,13L,16L,19L,22L,26L,29L,32L,35L,39L,42L,45L,48L,52L,55L,58L,61L,65L,68L,71L,75L,78L,81L,84L,88L,91L,94L,97L,101L,104L,107L,110L,114L,117L,120L,123L,127L,130L,133L,136L,140L,143L,146L,150L,153L,156L,159L,163L,166L,169L,172L,176L,179L,182L,185L,189L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059540Inst : IEnumerable<long>
{
public static readonly long[] Value=A059540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059540.Bytes);
public long this[int i]=>Value[i];

public static A059540Inst Instance=new A059540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059541
{
public static readonly long[] Value={ 1L,3L,5L,6L,8L,10L,11L,13L,15L,16L,18L,20L,22L,23L,25L,27L,28L,30L,32L,33L,35L,37L,38L,40L,42L,44L,45L,47L,49L,50L,52L,54L,55L,57L,59L,60L,62L,64L,66L,67L,69L,71L,72L,74L,76L,77L,79L,81L,82L,84L,86L,88L,89L,91L,93L,94L,96L,98L,99L,101L,103L,104L,106L,108L,110L,111L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059541Inst : IEnumerable<long>
{
public static readonly long[] Value=A059541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059541.Bytes);
public long this[int i]=>Value[i];

public static A059541Inst Instance=new A059541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059542
{
public static readonly long[] Value={ 2L,4L,7L,9L,12L,14L,17L,19L,21L,24L,26L,29L,31L,34L,36L,39L,41L,43L,46L,48L,51L,53L,56L,58L,61L,63L,65L,68L,70L,73L,75L,78L,80L,83L,85L,87L,90L,92L,95L,97L,100L,102L,105L,107L,109L,112L,114L,117L,119L,122L,124L,127L,129L,131L,134L,136L,139L,141L,144L,146L,149L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059542Inst : IEnumerable<long>
{
public static readonly long[] Value=A059542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059542.Bytes);
public long this[int i]=>Value[i];

public static A059542Inst Instance=new A059542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059543
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,78L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059543Inst : IEnumerable<long>
{
public static readonly long[] Value=A059543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059543.Bytes);
public long this[int i]=>Value[i];

public static A059543Inst Instance=new A059543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059544
{
public static readonly long[] Value={ 11L,22L,33L,44L,55L,66L,77L,89L,100L,111L,122L,133L,144L,155L,167L,178L,189L,200L,211L,222L,233L,245L,256L,267L,278L,289L,300L,311L,323L,334L,345L,356L,367L,378L,389L,401L,412L,423L,434L,445L,456L,467L,479L,490L,501L,512L,523L,534L,545L,557L,568L,579L,590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059544Inst : IEnumerable<long>
{
public static readonly long[] Value=A059544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059544.Bytes);
public long this[int i]=>Value[i];

public static A059544Inst Instance=new A059544Inst();

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