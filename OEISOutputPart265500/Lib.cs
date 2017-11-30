using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A283897
{
public static readonly long[] Value={ 93L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L,184L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283897Inst : IEnumerable<long>
{
public static readonly long[] Value=A283897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283897.Bytes);
public long this[int i]=>Value[i];

public static A283897Inst Instance=new A283897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283898
{
public static readonly long[] Value={ 624L,4L,312L,8L,624L,4L,312L,12L,624L,4L,312L,16L,624L,4L,312L,20L,624L,4L,312L,24L,624L,4L,312L,28L,624L,4L,312L,32L,624L,4L,312L,36L,624L,4L,312L,40L,624L,4L,312L,44L,624L,4L,312L,48L,624L,4L,312L,52L,624L,4L,312L,56L,624L,4L,312L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283898Inst : IEnumerable<long>
{
public static readonly long[] Value=A283898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283898.Bytes);
public long this[int i]=>Value[i];

public static A283898Inst Instance=new A283898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283899
{
public static readonly long[] Value={ 800L,4L,400L,8L,800L,4L,400L,12L,800L,4L,400L,16L,800L,4L,400L,20L,800L,4L,400L,24L,800L,4L,400L,28L,800L,4L,400L,32L,800L,4L,400L,36L,800L,4L,400L,40L,800L,4L,400L,44L,800L,4L,400L,48L,800L,4L,400L,52L,800L,4L,400L,56L,800L,4L,400L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283899Inst : IEnumerable<long>
{
public static readonly long[] Value=A283899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283899.Bytes);
public long this[int i]=>Value[i];

public static A283899Inst Instance=new A283899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283900
{
public static readonly long[] Value={ 1540L,4L,770L,8L,1540L,4L,770L,12L,1540L,4L,770L,16L,1540L,4L,770L,20L,1540L,4L,770L,24L,1540L,4L,770L,28L,1540L,4L,770L,32L,1540L,4L,770L,36L,1540L,4L,770L,40L,1540L,4L,770L,44L,1540L,4L,770L,48L,1540L,4L,770L,52L,1540L,4L,770L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283900Inst : IEnumerable<long>
{
public static readonly long[] Value=A283900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283900.Bytes);
public long this[int i]=>Value[i];

public static A283900Inst Instance=new A283900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283901
{
public static readonly long[] Value={ 315L,4L,311L,315L,8L,315L,315L,622L,4L,315L,319L,622L,4L,315L,323L,622L,4L,315L,327L,622L,4L,315L,331L,622L,4L,315L,335L,622L,4L,315L,339L,622L,4L,315L,343L,622L,4L,315L,347L,622L,4L,315L,351L,622L,4L,315L,355L,622L,4L,315L,359L,622L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283901Inst : IEnumerable<long>
{
public static readonly long[] Value=A283901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283901.Bytes);
public long this[int i]=>Value[i];

public static A283901Inst Instance=new A283901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283902
{
public static readonly long[] Value={ 8L,1404L,4L,702L,12L,1404L,4L,702L,16L,1404L,4L,702L,20L,1404L,4L,702L,24L,1404L,4L,702L,28L,1404L,4L,702L,32L,1404L,4L,702L,36L,1404L,4L,702L,40L,1404L,4L,702L,44L,1404L,4L,702L,48L,1404L,4L,702L,52L,1404L,4L,702L,56L,1404L,4L,702L,60L,1404L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283902Inst : IEnumerable<long>
{
public static readonly long[] Value=A283902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283902.Bytes);
public long this[int i]=>Value[i];

public static A283902Inst Instance=new A283902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283903
{
public static readonly long[] Value={ 11L,20L,6L,6L,6L,20L,11L,20L,6L,6L,6L,20L,11L,6L,12L,12L,12L,20L,11L,6L,18L,18L,12L,40L,11L,12L,24L,18L,12L,40L,11L,18L,30L,18L,18L,40L,11L,24L,30L,18L,18L,80L,11L,30L,30L,24L,24L,80L,11L,30L,36L,30L,24L,80L,11L,30L,48L,24L,24L,80L,11L,36L,54L,24L,24L,160L,11L,48L,42L,36L,30L,120L,11L,54L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283903Inst : IEnumerable<long>
{
public static readonly long[] Value=A283903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283903.Bytes);
public long this[int i]=>Value[i];

public static A283903Inst Instance=new A283903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283904
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,3L,1L,4L,4L,2L,2L,7L,2L,2L,6L,3L,3L,11L,2L,3L,12L,2L,2L,14L,2L,2L,14L,3L,2L,14L,4L,14L,15L,1L,15L,18L,1L,18L,20L,1L,20L,22L,1L,22L,23L,1L,23L,25L,1L,25L,26L,1L,26L,28L,1L,28L,29L,1L,29L,31L,1L,31L,32L,1L,32L,34L,1L,34L,35L,1L,35L,37L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283904Inst : IEnumerable<long>
{
public static readonly long[] Value=A283904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283904.Bytes);
public long this[int i]=>Value[i];

public static A283904Inst Instance=new A283904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283905
{
public static readonly long[] Value={ 1L,3L,5L,11L,21L,43L,93L,179L,381L,763L,1533L,3059L,6141L,12283L,24573L,49139L,98301L,196603L,393213L,786419L,1572861L,3145723L,6291453L,12582899L,25165821L,50331643L,100663293L,201326579L,402653181L,805306363L,1610612733L,3221225459L,6442450941L,12884901883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283905Inst : IEnumerable<long>
{
public static readonly long[] Value=A283905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283905.Bytes);
public long this[int i]=>Value[i];

public static A283905Inst Instance=new A283905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283970
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,11L,12L,13L,15L,17L,19L,23L,25L,29L,30L,31L,35L,36L,37L,40L,41L,43L,47L,48L,49L,50L,53L,59L,60L,61L,65L,67L,71L,73L,76L,79L,83L,89L,97L,101L,103L,107L,109L,113L,120L,121L,127L,130L,131L,132L,136L,137L,139L,140L,149L,150L,151L,157L,163L,167L,169L,173L,175L,179L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283970Inst : IEnumerable<long>
{
public static readonly long[] Value=A283970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283970.Bytes);
public long this[int i]=>Value[i];

public static A283970Inst Instance=new A283970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283971
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,5L,3L,7L,8L,9L,5L,11L,12L,13L,7L,15L,16L,17L,9L,19L,20L,21L,11L,23L,24L,25L,13L,27L,28L,29L,15L,31L,32L,33L,17L,35L,36L,37L,19L,39L,40L,41L,21L,43L,44L,45L,23L,47L,48L,49L,25L,51L,52L,53L,27L,55L,56L,57L,29L,59L,60L,61L,31L,63L,64L,65L,33L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283971Inst : IEnumerable<long>
{
public static readonly long[] Value=A283971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283971.Bytes);
public long this[int i]=>Value[i];

public static A283971Inst Instance=new A283971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283972
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,4L,4L,7L,8L,9L,9L,10L,11L,11L,11L,15L,16L,17L,17L,19L,20L,20L,20L,22L,23L,24L,23L,25L,26L,26L,26L,31L,32L,33L,33L,35L,36L,36L,36L,39L,40L,41L,41L,42L,43L,43L,43L,46L,47L,48L,47L,50L,51L,50L,49L,53L,54L,55L,53L,56L,57L,57L,57L,63L,64L,65L,65L,67L,68L,68L,68L,71L,72L,73L,73L,74L,75L,75L,75L,79L,80L,81L,81L,83L,84L,84L,84L,86L,87L,88L,87L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283972Inst : IEnumerable<long>
{
public static readonly long[] Value=A283972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283972.Bytes);
public long this[int i]=>Value[i];

public static A283972Inst Instance=new A283972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283973
{
public static readonly long[] Value={ 1L,3L,4L,9L,10L,12L,13L,15L,16L,21L,22L,27L,28L,33L,36L,37L,48L,49L,60L,61L,64L,78L,84L,85L,87L,88L,90L,91L,93L,94L,99L,100L,102L,103L,105L,106L,108L,109L,115L,129L,130L,133L,135L,136L,141L,144L,145L,153L,159L,160L,162L,171L,172L,189L,190L,192L,193L,195L,196L,213L,214L,223L,225L,226L,232L,240L,241L,244L,249L,250L,252L,255L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283973Inst : IEnumerable<long>
{
public static readonly long[] Value=A283973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283973.Bytes);
public long this[int i]=>Value[i];

public static A283973Inst Instance=new A283973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283974
{
public static readonly long[] Value={ 2L,5L,6L,7L,8L,11L,14L,17L,18L,19L,20L,23L,24L,25L,26L,29L,30L,31L,32L,34L,35L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,79L,80L,81L,82L,83L,86L,89L,92L,95L,96L,97L,98L,101L,104L,107L,110L,111L,112L,113L,114L,116L,117L,118L,119L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283974Inst : IEnumerable<long>
{
public static readonly long[] Value=A283974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283974.Bytes);
public long this[int i]=>Value[i];

public static A283974Inst Instance=new A283974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283975
{
public static readonly long[] Value={ 1L,3L,1L,7L,5L,7L,1L,15L,13L,7L,5L,11L,13L,15L,1L,31L,29L,7L,13L,3L,1L,11L,5L,19L,21L,15L,13L,19L,29L,31L,1L,63L,61L,7L,29L,19L,25L,3L,13L,11L,9L,11L,1L,23L,25L,19L,5L,35L,37L,15L,21L,11L,9L,19L,13L,43L,37L,31L,29L,35L,61L,63L,1L,127L,125L,7L,61L,51L,41L,19L,29L,59L,49L,3L,25L,31L,17L,11L,13L,27L,25L,11L,9L,31L,21L,23L,1L,47L,33L,19L,25L,63L,41L,35L,5L,67L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283975Inst : IEnumerable<long>
{
public static readonly long[] Value=A283975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283975.Bytes);
public long this[int i]=>Value[i];

public static A283975Inst Instance=new A283975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283976
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,3L,2L,3L,1L,3L,3L,3L,2L,3L,3L,3L,1L,5L,4L,7L,3L,7L,5L,7L,2L,7L,5L,7L,3L,7L,4L,5L,1L,5L,5L,5L,4L,7L,7L,7L,3L,11L,8L,13L,5L,7L,7L,7L,2L,7L,7L,7L,5L,13L,8L,11L,3L,7L,7L,7L,4L,5L,5L,5L,1L,7L,6L,7L,5L,13L,9L,13L,4L,15L,11L,15L,7L,15L,10L,11L,3L,11L,11L,11L,8L,13L,13L,13L,5L,13L,12L,15L,7L,15L,9L,11L,2L,11L,9L,15L,7L,15L,12L,13L,5L,13L,13L,13L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283976Inst : IEnumerable<long>
{
public static readonly long[] Value=A283976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283976.Bytes);
public long this[int i]=>Value[i];

public static A283976Inst Instance=new A283976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283977
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,3L,2L,3L,1L,2L,3L,1L,2L,1L,3L,2L,1L,5L,4L,7L,3L,6L,5L,7L,2L,7L,5L,6L,3L,7L,4L,5L,1L,4L,5L,1L,4L,3L,7L,4L,3L,11L,8L,13L,5L,2L,7L,5L,2L,5L,7L,2L,5L,13L,8L,11L,3L,4L,7L,3L,4L,1L,5L,4L,1L,7L,6L,3L,5L,12L,9L,13L,4L,15L,11L,12L,7L,13L,10L,9L,3L,8L,11L,3L,8L,5L,13L,8L,5L,9L,12L,11L,7L,14L,9L,11L,2L,11L,9L,14L,7L,11L,12L,9L,5L,8L,13L,5L,8L,3L,11L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283977Inst : IEnumerable<long>
{
public static readonly long[] Value=A283977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283977.Bytes);
public long this[int i]=>Value[i];

public static A283977Inst Instance=new A283977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283978
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,2L,0L,2L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,4L,0L,4L,0L,3L,0L,0L,0L,0L,0L,5L,0L,2L,0L,2L,0L,5L,0L,0L,0L,0L,0L,3L,0L,4L,0L,4L,0L,1L,0L,0L,0L,4L,0L,1L,0L,0L,0L,0L,0L,3L,0L,2L,0L,2L,0L,3L,0L,8L,0L,8L,0L,5L,0L,4L,0L,4L,0L,1L,0L,0L,0L,0L,0L,1L,0L,4L,0L,4L,0L,5L,0L,8L,0L,8L,0L,3L,0L,2L,0L,2L,0L,3L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283978Inst : IEnumerable<long>
{
public static readonly long[] Value=A283978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283978.Bytes);
public long this[int i]=>Value[i];

public static A283978Inst Instance=new A283978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283979
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,3L,2L,3L,0L,3L,0L,0L,0L,7L,6L,5L,4L,4L,6L,7L,0L,5L,6L,5L,0L,7L,0L,0L,0L,15L,14L,9L,12L,10L,10L,9L,8L,10L,8L,8L,12L,10L,14L,15L,0L,9L,10L,15L,12L,14L,10L,9L,0L,9L,14L,9L,0L,15L,0L,0L,0L,31L,30L,17L,28L,22L,18L,21L,24L,20L,20L,18L,20L,16L,18L,17L,16L,22L,20L,22L,16L,21L,16L,16L,24L,16L,20L,18L,28L,22L,30L,31L,0L,17L,18L,27L,20L,28L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283979Inst : IEnumerable<long>
{
public static readonly long[] Value=A283979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283979.Bytes);
public long this[int i]=>Value[i];

public static A283979Inst Instance=new A283979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283980
{
public static readonly long[] Value={ 1L,6L,5L,36L,7L,30L,11L,216L,25L,42L,13L,180L,17L,66L,35L,1296L,19L,150L,23L,252L,55L,78L,29L,1080L,49L,102L,125L,396L,31L,210L,37L,7776L,65L,114L,77L,900L,41L,138L,85L,1512L,43L,330L,47L,468L,175L,174L,53L,6480L,121L,294L,95L,612L,59L,750L,91L,2376L,115L,186L,61L,1260L,67L,222L,275L,46656L,119L,390L,71L,684L,145L,462L,73L,5400L,79L,246L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283980Inst : IEnumerable<long>
{
public static readonly long[] Value=A283980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283980.Bytes);
public long this[int i]=>Value[i];

public static A283980Inst Instance=new A283980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283981
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,3L,3L,3L,0L,4L,4L,4L,4L,4L,6L,7L,0L,5L,5L,5L,5L,5L,7L,8L,5L,5L,8L,9L,8L,9L,11L,11L,0L,6L,6L,6L,6L,6L,8L,9L,6L,6L,9L,10L,9L,10L,12L,12L,6L,6L,10L,11L,10L,11L,13L,13L,10L,11L,14L,14L,14L,14L,14L,17L,0L,7L,7L,7L,7L,7L,9L,10L,7L,7L,10L,11L,10L,11L,13L,13L,7L,7L,11L,12L,11L,12L,14L,14L,11L,12L,15L,15L,15L,15L,15L,18L,7L,7L,12L,13L,12L,13L,15L,15L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283981Inst : IEnumerable<long>
{
public static readonly long[] Value=A283981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283981.Bytes);
public long this[int i]=>Value[i];

public static A283981Inst Instance=new A283981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283982
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,1L,0L,0L,3L,2L,1L,1L,0L,1L,1L,0L,4L,3L,2L,2L,1L,2L,2L,1L,0L,2L,2L,1L,1L,2L,1L,0L,5L,4L,3L,3L,2L,3L,3L,2L,1L,3L,3L,2L,2L,3L,2L,1L,0L,3L,3L,2L,2L,3L,2L,1L,1L,3L,2L,2L,1L,0L,2L,0L,6L,5L,4L,4L,3L,4L,4L,3L,2L,4L,4L,3L,3L,4L,3L,2L,1L,4L,4L,3L,3L,4L,3L,2L,2L,4L,3L,3L,2L,1L,3L,1L,0L,4L,4L,3L,3L,4L,3L,2L,2L,4L,3L,3L,2L,1L,3L,1L,1L,4L,3L,3L,2L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283982Inst : IEnumerable<long>
{
public static readonly long[] Value=A283982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283982.Bytes);
public long this[int i]=>Value[i];

public static A283982Inst Instance=new A283982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283983
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,5L,3L,1L,15L,1L,1L,1L,3L,5L,15L,7L,45L,5L,15L,1L,15L,35L,15L,1L,105L,1L,1L,1L,3L,5L,105L,7L,225L,35L,525L,11L,1575L,175L,1125L,7L,1575L,35L,105L,1L,105L,35L,525L,77L,1575L,35L,525L,1L,105L,385L,105L,1L,1155L,1L,1L,1L,3L,5L,1155L,7L,1575L,385L,3675L,11L,7875L,1225L,275625L,77L,55125L,2695L,5775L,13L,17325L,13475L,275625L,539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283983Inst : IEnumerable<long>
{
public static readonly long[] Value=A283983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283983.Bytes);
public long this[int i]=>Value[i];

public static A283983Inst Instance=new A283983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283984
{
public static readonly long[] Value={ 0L,1L,3L,4L,9L,10L,12L,13L,33L,34L,36L,37L,42L,43L,45L,46L,153L,154L,156L,157L,162L,163L,165L,166L,186L,187L,189L,190L,195L,196L,198L,199L,873L,874L,876L,877L,882L,883L,885L,886L,906L,907L,909L,910L,915L,916L,918L,919L,1026L,1027L,1029L,1030L,1035L,1036L,1038L,1039L,1059L,1060L,1062L,1063L,1068L,1069L,1071L,1072L,5913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283984Inst : IEnumerable<long>
{
public static readonly long[] Value=A283984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283984.Bytes);
public long this[int i]=>Value[i];

public static A283984Inst Instance=new A283984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283985
{
public static readonly long[] Value={ 0L,1L,3L,4L,9L,10L,12L,13L,39L,40L,42L,43L,48L,49L,51L,52L,249L,250L,252L,253L,258L,259L,261L,262L,288L,289L,291L,292L,297L,298L,300L,301L,2559L,2560L,2562L,2563L,2568L,2569L,2571L,2572L,2598L,2599L,2601L,2602L,2607L,2608L,2610L,2611L,2808L,2809L,2811L,2812L,2817L,2818L,2820L,2821L,2847L,2848L,2850L,2851L,2856L,2857L,2859L,2860L,32589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283985Inst : IEnumerable<long>
{
public static readonly long[] Value=A283985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283985.Bytes);
public long this[int i]=>Value[i];

public static A283985Inst Instance=new A283985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284163
{
public static readonly BigInteger[] Value={ 19L,467L,21790L,1142173L,63520018L,3648835932L,213897742464L,12712253739523L,762954434250117L,46132889929802552L,2805893251846100894L,BigInteger.Parse("171472537110465965686"),BigInteger.Parse("10520216685129431413147"),BigInteger.Parse("647576935194197811151494") };
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
public class A284163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284163Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284163.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A284163.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284163Inst Instance=new A284163Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284164
{
public static readonly BigInteger[] Value={ 33L,1689L,154108L,16699997L,1852406216L,213897742464L,25064817057781L,2981736353245523L,357844048109256955L,BigInteger.Parse("43278292532056389680"),BigInteger.Parse("5263990195553603263431"),BigInteger.Parse("643350359729498071977340") };
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
public class A284164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284164Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284164.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A284164.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284164Inst Instance=new A284164Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284165
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,3L,6L,13L,13L,6L,10L,42L,62L,42L,10L,19L,134L,461L,461L,134L,19L,33L,467L,2872L,5888L,2872L,467L,33L,62L,1689L,21790L,80072L,80072L,21790L,1689L,62L,112L,6210L,154108L,1142173L,2179255L,1142173L,154108L,6210L,112L,212L,23178L,1174235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284165Inst : IEnumerable<long>
{
public static readonly long[] Value=A284165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284165.Bytes);
public long this[int i]=>Value[i];

public static A284165Inst Instance=new A284165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284166
{
public static readonly long[] Value={ 710100L,1722776L,3204765L,3346228L,3389380L,3517236L,3775287L,3794572L,4313727L,4657555L,4722613L,5466169L,7820866L,8209165L,9325203L,10519242L,12469058L,13310436L,14233532L,14593770L,15256174L,17893953L,18216168L,18696860L,19175682L,19715001L,19921876L,20202676L,22931745L,22931746L,23189751L,23724968L,24658601L,24658602L,24658603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284166Inst : IEnumerable<long>
{
public static readonly long[] Value=A284166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284166.Bytes);
public long this[int i]=>Value[i];

public static A284166Inst Instance=new A284166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284167
{
public static readonly long[] Value={ 2L,5L,7L,10L,8L,15L,8L,18L,16L,18L,10L,29L,8L,19L,25L,28L,10L,33L,10L,35L,26L,20L,12L,50L,18L,20L,31L,36L,12L,51L,10L,42L,27L,23L,33L,62L,8L,22L,30L,60L,12L,53L,10L,40L,52L,22L,14L,78L,20L,41L,28L,38L,12L,63L,36L,63L,30L,24L,16L,95L,8L,23L,59L,60L,32L,54L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284167Inst : IEnumerable<long>
{
public static readonly long[] Value=A284167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284167.Bytes);
public long this[int i]=>Value[i];

public static A284167Inst Instance=new A284167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284168
{
public static readonly long[] Value={ 3L,6L,15L,25L,27L,30L,35L,40L,48L,50L,54L,60L,63L,66L,78L,80L,100L,108L,112L,118L,120L,123L,124L,126L,140L,144L,158L,175L,192L,198L,200L,207L,216L,220L,224L,225L,232L,238L,243L,247L,304L,310L,316L,319L,341L,345L,348L,358L,364L,368L,375L,385L,391L,408L,416L,425L,432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284168Inst : IEnumerable<long>
{
public static readonly long[] Value=A284168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284168.Bytes);
public long this[int i]=>Value[i];

public static A284168Inst Instance=new A284168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284169
{
public static readonly long[] Value={ 1L,2L,5L,5L,9L,3L,17L,13L,21L,10L,18L,6L,28L,32L,33L,26L,20L,27L,28L,19L,12L,41L,34L,42L,54L,25L,5L,28L,84L,22L,40L,5L,54L,44L,56L,25L,29L,86L,81L,89L,88L,134L,10L,71L,148L,69L,87L,27L,91L,92L,18L,128L,23L,51L,52L,153L,108L,202L,112L,138L,58L,201L,141L,162L,176L,77L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284169Inst : IEnumerable<long>
{
public static readonly long[] Value=A284169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284169.Bytes);
public long this[int i]=>Value[i];

public static A284169Inst Instance=new A284169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284170
{
public static readonly long[] Value={ 5L,43L,43L,5L,43L,5L,7L,43L,43L,43L,43L,41L,131L,43L,43L,13L,43L,43L,43L,41L,13L,17L,43L,41L,43L,131L,43L,137L,43L,43L,131L,43L,43L,43L,43L,43L,23L,43L,137L,43L,131L,43L,41L,67L,151L,29L,43L,131L,43L,41L,131L,137L,131L,43L,29L,137L,41L,137L,41L,151L,43L,131L,43L,137L,73L,43L,37L,43L,43L,131L,43L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284170Inst : IEnumerable<long>
{
public static readonly long[] Value=A284170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284170.Bytes);
public long this[int i]=>Value[i];

public static A284170Inst Instance=new A284170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284171
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,3L,2L,1L,2L,3L,2L,1L,2L,3L,3L,2L,4L,5L,3L,2L,4L,5L,3L,2L,4L,6L,4L,2L,4L,7L,5L,2L,5L,8L,5L,2L,5L,8L,6L,3L,5L,10L,8L,4L,6L,10L,8L,4L,6L,10L,9L,5L,7L,11L,10L,6L,8L,12L,10L,6L,8L,13L,11L,7L,9L,15L,13L,7L,10L,16L,14L,8L,10L,16L,15L,9L,10L,17L,16L,9L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284171Inst : IEnumerable<long>
{
public static readonly long[] Value=A284171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284171.Bytes);
public long this[int i]=>Value[i];

public static A284171Inst Instance=new A284171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284172
{
public static readonly long[] Value={ 2L,3L,5L,8L,7L,11L,16L,14L,11L,17L,24L,20L,15L,9L,2L,10L,2L,11L,21L,12L,2L,13L,25L,14L,2L,15L,2L,16L,2L,17L,33L,18L,2L,19L,37L,56L,39L,21L,2L,22L,2L,23L,45L,24L,2L,25L,2L,26L,2L,27L,2L,28L,2L,29L,57L,30L,2L,31L,61L,92L,63L,33L,2L,34L,2L,35L,2L,36L,2L,37L,73L,110L,75L,39L,2L,40L,2L,41L,81L,42L,2L,43L,85L,44L,2L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284172Inst : IEnumerable<long>
{
public static readonly long[] Value=A284172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284172.Bytes);
public long this[int i]=>Value[i];

public static A284172Inst Instance=new A284172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284173
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,3L,5L,7L,9L,1L,2L,4L,7L,9L,12L,15L,0L,3L,6L,9L,12L,17L,20L,0L,4L,8L,12L,16L,22L,26L,31L,4L,9L,14L,20L,26L,31L,37L,3L,8L,14L,20L,26L,32L,38L,1L,4L,11L,18L,23L,30L,39L,46L,53L,6L,12L,20L,28L,36L,44L,56L,1L,9L,21L,28L,36L,46L,57L,68L,9L,20L,30L,39L,48L,60L,69L,2L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284173Inst : IEnumerable<long>
{
public static readonly long[] Value=A284173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284173.Bytes);
public long this[int i]=>Value[i];

public static A284173Inst Instance=new A284173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284174
{
public static readonly long[] Value={ 24L,30L,36L,60L,84L,90L,100L,112L,120L,128L,144L,152L,162L,198L,204L,210L,216L,240L,276L,288L,300L,320L,330L,340L,352L,360L,372L,384L,390L,396L,410L,450L,456L,462L,472L,480L,492L,520L,540L,558L,564L,576L,600L,624L,630L,648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284174Inst : IEnumerable<long>
{
public static readonly long[] Value=A284174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284174.Bytes);
public long this[int i]=>Value[i];

public static A284174Inst Instance=new A284174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284175
{
public static readonly BigInteger[] Value={ 1L,0L,1L,0L,101L,0L,10101L,1000L,1001001L,1000L,101001001L,10001000L,10010001001L,10101000L,1010010101001L,100010101000L,100100010101001L,101010101000L,10100100010101001L,1000101010101000L,1001000100010101001L,1010101010101000L,BigInteger.Parse("101001010100010101001") };
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
public class A284175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A284175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284175Inst Instance=new A284175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284176
{
public static readonly BigInteger[] Value={ 1L,0L,100L,0L,10100L,0L,1010100L,10000L,100100100L,1000000L,10010010100L,100010000L,1001000100100L,10101000000L,100101010010100L,1010100010000L,10010101000100100L,101010101000000L,1001010100010010100L,10101010100010000L,BigInteger.Parse("100101010001000100100") };
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
public class A284176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284176Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284176.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A284176.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284176Inst Instance=new A284176Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284177
{
public static readonly long[] Value={ 1L,0L,1L,0L,5L,0L,21L,8L,73L,8L,329L,136L,1161L,168L,5289L,2216L,18601L,2728L,84137L,35496L,297129L,43688L,1353897L,567976L,4761769L,699048L,21538985L,9087656L,76064937L,11184808L,346597545L,145402536L,1219012777L,178956968L,5513980073L,2326440616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284177Inst : IEnumerable<long>
{
public static readonly long[] Value=A284177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284177.Bytes);
public long this[int i]=>Value[i];

public static A284177Inst Instance=new A284177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284178
{
public static readonly long[] Value={ 1L,0L,4L,0L,20L,0L,84L,16L,292L,64L,1172L,272L,4644L,1344L,19092L,5392L,76324L,21824L,305300L,87312L,1221156L,349504L,4885140L,1398032L,19540516L,5592384L,78162068L,22369552L,312648228L,89478464L,1250593428L,357913872L,5002373668L,1431655744L,20009494676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284178Inst : IEnumerable<long>
{
public static readonly long[] Value=A284178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284178.Bytes);
public long this[int i]=>Value[i];

public static A284178Inst Instance=new A284178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284259
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284259Inst : IEnumerable<long>
{
public static readonly long[] Value=A284259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284259.Bytes);
public long this[int i]=>Value[i];

public static A284259Inst Instance=new A284259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284260
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,7L,2L,3L,2L,11L,3L,13L,2L,5L,2L,17L,3L,19L,2L,7L,2L,23L,3L,5L,2L,3L,2L,29L,3L,31L,2L,3L,2L,7L,3L,37L,2L,3L,2L,41L,3L,43L,2L,5L,2L,47L,3L,7L,2L,3L,2L,53L,3L,11L,2L,3L,2L,59L,3L,61L,2L,7L,2L,13L,3L,67L,2L,3L,2L,71L,3L,73L,2L,5L,2L,11L,3L,79L,2L,3L,2L,83L,3L,17L,2L,3L,2L,89L,3L,13L,2L,3L,2L,19L,3L,97L,2L,3L,2L,101L,3L,103L,2L,7L,2L,107L,3L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284260Inst : IEnumerable<long>
{
public static readonly long[] Value=A284260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284260.Bytes);
public long this[int i]=>Value[i];

public static A284260Inst Instance=new A284260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284261
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284261Inst : IEnumerable<long>
{
public static readonly long[] Value=A284261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284261.Bytes);
public long this[int i]=>Value[i];

public static A284261Inst Instance=new A284261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284262
{
public static readonly BigInteger[] Value={ 1L,2L,6L,105L,5005L,85085L,1616615L,37182145L,6685349671L,247357937827L,10141675450907L,436092044389001L,20496326086283047L,9156001667401012567L,BigInteger.Parse("558516101711461766587"),BigInteger.Parse("37420578814667938361329"),BigInteger.Parse("2656861095841423623654359"),BigInteger.Parse("193950859996423924526768207"),BigInteger.Parse("15322117939717490037614688353"),BigInteger.Parse("1271735788996551673122019133299") };
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
public class A284262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284262Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284262.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A284262.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284262Inst Instance=new A284262Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284263
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284263Inst : IEnumerable<long>
{
public static readonly long[] Value=A284263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284263.Bytes);
public long this[int i]=>Value[i];

public static A284263Inst Instance=new A284263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284264
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,2L,0L,0L,0L,1L,1L,2L,1L,3L,1L,2L,0L,2L,2L,2L,0L,3L,0L,0L,0L,1L,1L,3L,1L,4L,2L,4L,1L,5L,3L,5L,1L,5L,2L,3L,0L,3L,2L,4L,2L,5L,2L,4L,0L,3L,3L,3L,0L,4L,0L,0L,0L,1L,1L,4L,1L,5L,3L,5L,1L,6L,4L,8L,2L,7L,4L,5L,1L,6L,5L,8L,3L,10L,5L,7L,1L,7L,5L,8L,2L,7L,3L,4L,0L,4L,3L,6L,2L,8L,4L,7L,2L,8L,5L,9L,2L,8L,4L,5L,0L,5L,3L,6L,3L,7L,3L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284264Inst : IEnumerable<long>
{
public static readonly long[] Value=A284264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284264.Bytes);
public long this[int i]=>Value[i];

public static A284264Inst Instance=new A284264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284265
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,2L,0L,1L,2L,3L,2L,2L,2L,3L,0L,1L,3L,4L,4L,5L,5L,5L,3L,3L,4L,5L,4L,3L,3L,4L,0L,1L,4L,5L,5L,6L,8L,7L,5L,6L,8L,10L,7L,7L,8L,7L,4L,4L,6L,8L,7L,8L,9L,8L,5L,5L,6L,7L,6L,4L,4L,5L,0L,1L,5L,6L,6L,8L,10L,9L,6L,8L,12L,13L,10L,11L,12L,10L,6L,7L,11L,14L,11L,13L,15L,15L,9L,10L,13L,14L,10L,10L,11L,9L,5L,5L,8L,11L,9L,12L,14L,13L,10L,11L,14L,16L,12L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284265Inst : IEnumerable<long>
{
public static readonly long[] Value=A284265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284265.Bytes);
public long this[int i]=>Value[i];

public static A284265Inst Instance=new A284265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284266
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,3L,1L,4L,3L,3L,2L,3L,3L,4L,1L,5L,4L,3L,3L,2L,1L,3L,2L,3L,3L,4L,3L,3L,4L,5L,1L,6L,5L,3L,4L,3L,3L,2L,3L,3L,2L,3L,1L,4L,3L,3L,2L,3L,3L,4L,3L,3L,2L,3L,3L,4L,3L,5L,4L,3L,5L,6L,1L,7L,6L,3L,5L,4L,3L,3L,4L,5L,3L,2L,3L,5L,2L,3L,3L,4L,3L,3L,2L,5L,3L,4L,1L,5L,2L,3L,3L,6L,3L,3L,2L,3L,3L,4L,3L,5L,2L,3L,3L,2L,1L,3L,2L,5L,3L,4L,3L,5L,4L,5L,3L,4L,3L,3L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284266Inst : IEnumerable<long>
{
public static readonly long[] Value=A284266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284266.Bytes);
public long this[int i]=>Value[i];

public static A284266Inst Instance=new A284266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284267
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,2L,1L,4L,3L,1L,1L,2L,2L,2L,1L,5L,4L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,2L,2L,1L,6L,5L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,2L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,2L,2L,1L,7L,6L,1L,2L,2L,2L,1L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,2L,1L,2L,1L,1L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284267Inst : IEnumerable<long>
{
public static readonly long[] Value=A284267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284267.Bytes);
public long this[int i]=>Value[i];

public static A284267Inst Instance=new A284267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284268
{
public static readonly long[] Value={ 0L,0L,2L,0L,2L,3L,4L,0L,2L,6L,7L,5L,5L,6L,6L,0L,2L,8L,9L,9L,10L,11L,11L,7L,7L,11L,12L,9L,8L,9L,8L,0L,2L,10L,12L,11L,13L,17L,16L,12L,13L,18L,20L,16L,15L,17L,15L,9L,9L,15L,17L,16L,17L,19L,18L,12L,11L,16L,17L,13L,11L,12L,10L,0L,2L,12L,15L,14L,17L,22L,21L,15L,17L,25L,27L,24L,23L,26L,22L,15L,16L,24L,29L,26L,28L,32L,30L,21L,20L,28L,30L,24L,21L,23L,19L,11L,11L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284268Inst : IEnumerable<long>
{
public static readonly long[] Value=A284268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284268.Bytes);
public long this[int i]=>Value[i];

public static A284268Inst Instance=new A284268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284269
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,3L,0L,0L,0L,0L,2L,1L,0L,1L,0L,0L,4L,4L,3L,0L,0L,0L,0L,0L,1L,0L,2L,0L,0L,0L,0L,7L,0L,1L,2L,2L,0L,0L,0L,0L,6L,5L,0L,2L,0L,1L,0L,2L,0L,0L,9L,2L,7L,0L,4L,0L,0L,0L,0L,0L,0L,4L,7L,6L,1L,0L,2L,0L,4L,0L,0L,0L,0L,8L,8L,0L,4L,8L,0L,0L,4L,1L,0L,1L,0L,0L,8L,3L,0L,3L,4L,5L,0L,4L,0L,4L,0L,0L,0L,0L,4L,2L,11L,4L,0L,2L,7L,0L,6L,0L,2L,0L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284269Inst : IEnumerable<long>
{
public static readonly long[] Value=A284269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284269.Bytes);
public long this[int i]=>Value[i];

public static A284269Inst Instance=new A284269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284270
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,0L,3L,0L,0L,1L,0L,1L,2L,0L,0L,0L,0L,3L,4L,4L,0L,0L,0L,0L,2L,0L,1L,0L,0L,0L,0L,0L,2L,2L,1L,0L,7L,0L,0L,2L,0L,1L,0L,2L,0L,5L,6L,0L,0L,0L,0L,0L,0L,4L,0L,7L,2L,9L,0L,0L,0L,0L,4L,0L,2L,0L,1L,6L,7L,4L,0L,0L,1L,0L,1L,4L,0L,0L,8L,4L,0L,8L,8L,0L,0L,0L,0L,4L,0L,4L,0L,5L,4L,3L,0L,3L,8L,0L,0L,2L,0L,2L,0L,6L,0L,7L,2L,0L,4L,11L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284270Inst : IEnumerable<long>
{
public static readonly long[] Value=A284270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284270.Bytes);
public long this[int i]=>Value[i];

public static A284270Inst Instance=new A284270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284271
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,2L,3L,1L,2L,1L,2L,2L,1L,3L,4L,1L,3L,2L,1L,1L,1L,2L,2L,2L,2L,1L,2L,3L,1L,4L,5L,1L,4L,3L,1L,2L,2L,1L,1L,1L,1L,1L,2L,2L,1L,2L,2L,2L,2L,2L,1L,1L,1L,2L,2L,3L,2L,1L,2L,4L,1L,5L,6L,1L,5L,4L,1L,3L,2L,1L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,1L,1L,1L,1L,1L,2L,2L,1L,2L,2L,3L,2L,2L,1L,1L,1L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284271Inst : IEnumerable<long>
{
public static readonly long[] Value=A284271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284271.Bytes);
public long this[int i]=>Value[i];

public static A284271Inst Instance=new A284271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284272
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,0L,0L,0L,2L,2L,3L,0L,4L,0L,0L,0L,2L,2L,6L,2L,7L,3L,5L,0L,5L,4L,6L,0L,6L,0L,0L,0L,2L,2L,8L,2L,9L,6L,9L,2L,10L,7L,11L,3L,11L,5L,7L,0L,7L,5L,11L,4L,12L,6L,9L,0L,8L,6L,9L,0L,8L,0L,0L,0L,2L,2L,10L,2L,12L,8L,11L,2L,13L,9L,17L,6L,16L,9L,12L,2L,13L,10L,18L,7L,20L,11L,16L,3L,15L,11L,17L,5L,15L,7L,9L,0L,9L,7L,15L,5L,17L,11L,16L,4L,17L,12L,19L,6L,18L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284272Inst : IEnumerable<long>
{
public static readonly long[] Value=A284272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284272.Bytes);
public long this[int i]=>Value[i];

public static A284272Inst Instance=new A284272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284273
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,0L,2L,8L,8L,0L,12L,0L,0L,0L,2L,8L,11L,12L,16L,10L,3L,0L,9L,22L,18L,0L,12L,0L,0L,0L,2L,8L,30L,32L,11L,6L,26L,8L,19L,22L,0L,40L,1L,12L,37L,0L,17L,36L,18L,36L,7L,18L,16L,0L,27L,48L,13L,0L,12L,0L,0L,0L,2L,8L,30L,32L,53L,50L,40L,56L,32L,44L,2L,24L,73L,26L,61L,32L,14L,76L,28L,4L,34L,0L,64L,72L,86L,4L,73L,48L,16L,54L,11L,0L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284273Inst : IEnumerable<long>
{
public static readonly long[] Value=A284273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284273.Bytes);
public long this[int i]=>Value[i];

public static A284273Inst Instance=new A284273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284274
{
public static readonly ulong[] Value={ 1L,11L,111L,1101L,11001L,111111L,1110101L,11001011L,110111011L,1111110011L,11101111111L,110011010111L,1101101001111L,11111111110101L,111011011110111L,1100111111011011L,11011001111111001L,111111111001110111L,1110110011111100101L,11001111101110111001UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284274Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284274.Bytes);
public ulong this[int i]=>Value[i];

public static A284274Inst Instance=new A284274Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284323
{
public static readonly long[] Value={ 1L,4L,11L,14L,22L,28L,41L,44L,82L,88L,111L,114L,122L,128L,141L,144L,182L,188L,212L,218L,221L,224L,242L,248L,281L,284L,411L,414L,422L,428L,441L,444L,482L,488L,812L,818L,821L,824L,842L,848L,881L,884L,1111L,1114L,1122L,1128L,1141L,1144L,1182L,1188L,1212L,1218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284323Inst : IEnumerable<long>
{
public static readonly long[] Value=A284323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284323.Bytes);
public long this[int i]=>Value[i];

public static A284323Inst Instance=new A284323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284324
{
public static readonly long[] Value={ 1L,8L,11L,18L,24L,42L,81L,88L,111L,118L,124L,142L,181L,188L,214L,222L,241L,248L,284L,412L,421L,428L,444L,482L,811L,818L,824L,842L,881L,888L,1111L,1118L,1124L,1142L,1181L,1188L,1214L,1222L,1241L,1248L,1284L,1412L,1421L,1428L,1444L,1482L,1811L,1818L,1824L,1842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284324Inst : IEnumerable<long>
{
public static readonly long[] Value=A284324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284324.Bytes);
public long this[int i]=>Value[i];

public static A284324Inst Instance=new A284324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284325
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,5L,8L,8L,3L,3L,1L,1L,5L,9L,5L,12L,2L,7L,3L,12L,9L,9L,9L,14L,1L,14L,2L,18L,35L,56L,19L,38L,38L,26L,3L,13L,74L,12L,25L,12L,11L,8L,37L,79L,2L,43L,68L,3L,12L,46L,54L,7L,9L,9L,34L,4L,14L,49L,83L,3L,39L,87L,4L,10L,116L,128L,53L,13L,1L,32L,57L,92L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284325Inst : IEnumerable<long>
{
public static readonly long[] Value=A284325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284325.Bytes);
public long this[int i]=>Value[i];

public static A284325Inst Instance=new A284325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284326
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,6L,8L,15L,13L,18L,12L,10L,14L,24L,24L,31L,18L,15L,20L,42L,32L,36L,24L,18L,31L,42L,40L,56L,30L,36L,32L,63L,48L,54L,48L,19L,38L,60L,56L,90L,42L,48L,44L,84L,78L,72L,48L,34L,57L,93L,72L,98L,54L,42L,72L,120L,80L,90L,60L,60L,62L,96L,104L,127L,84L,72L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284326Inst : IEnumerable<long>
{
public static readonly long[] Value=A284326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284326.Bytes);
public long this[int i]=>Value[i];

public static A284326Inst Instance=new A284326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284327
{
public static readonly long[] Value={ 1L,1L,10L,1L,4L,1L,10L,5L,16L,1L,6L,25L,10L,1L,4L,1L,10L,7L,16L,1L,46L,15L,20L,1L,6L,1L,22L,15L,6L,13L,6L,5L,190L,11L,18L,1L,30L,15L,46L,1L,46L,25L,10L,21L,16L,21L,10L,37L,6L,19L,16L,5L,12L,1L,6L,1L,52L,5L,26L,31L,26L,45L,40L,11L,4L,1L,20L,7L,196L,19L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284327Inst : IEnumerable<long>
{
public static readonly long[] Value=A284327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284327.Bytes);
public long this[int i]=>Value[i];

public static A284327Inst Instance=new A284327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284328
{
public static readonly long[] Value={ 1L,4L,49L,5130L,1792007L,3063494246L,20513380740103L,582475612060753356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284328Inst : IEnumerable<long>
{
public static readonly long[] Value=A284328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284328.Bytes);
public long this[int i]=>Value[i];

public static A284328Inst Instance=new A284328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284329
{
public static readonly long[] Value={ 3L,13L,49L,415L,2243L,19385L,122495L,1021999L,7013557L,56860451L,409700413L,3264497171L,24241023451L,191315053703L,1447951944431L,11372354830403L,87138438742684L,682980793270605L,5276292595391119L,41334416149705333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284329Inst : IEnumerable<long>
{
public static readonly long[] Value=A284329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284329.Bytes);
public long this[int i]=>Value[i];

public static A284329Inst Instance=new A284329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284330
{
public static readonly ulong[] Value={ 6L,34L,373L,5130L,70039L,1000935L,14581112L,215806808L,3229703988L,48741017873L,740325265021L,11303036259207L,173296776954307L,2666236456702222L,41141752932262310L,636440516858225998L,9866818127969621217UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284330Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284330.Bytes);
public ulong this[int i]=>Value[i];

public static A284330Inst Instance=new A284330Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284331
{
public static readonly BigInteger[] Value={ 10L,118L,2259L,68458L,1792007L,53977741L,1544903012L,46769835006L,1390664014686L,42363464831441L,1283893093528916L,39356428019998389L,1205870610270117562L,BigInteger.Parse("37167608852928420540"),BigInteger.Parse("1146797011149724787289"),BigInteger.Parse("35507304286797019507210") };
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
public class A284331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284331Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284331.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A284331.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284331Inst Instance=new A284331Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284332
{
public static readonly BigInteger[] Value={ 19L,419L,18114L,966889L,53435287L,3063494246L,179138039472L,10629901713799L,637390912071364L,38521588005900251L,2342438993189208497L,BigInteger.Parse("143142503770615128210"),BigInteger.Parse("8782493512066047546985"),BigInteger.Parse("540663386186525386713156") };
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
public class A284332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284332Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284332.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A284332.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284332Inst Instance=new A284332Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284333
{
public static readonly BigInteger[] Value={ 33L,1481L,120058L,13941789L,1495300322L,177476886878L,20513380740103L,2467754689139967L,294625135884008616L,BigInteger.Parse("35796621202795670294"),BigInteger.Parse("4346160057088704088179"),BigInteger.Parse("532218134572276626959066") };
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
public class A284333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284333Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284333.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A284333.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284333Inst Instance=new A284333Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284334
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,6L,13L,13L,8L,10L,34L,49L,42L,16L,19L,118L,373L,415L,134L,32L,33L,419L,2259L,5130L,2243L,467L,64L,62L,1481L,18114L,68458L,70039L,19385L,1689L,128L,112L,5394L,120058L,966889L,1792007L,1000935L,122495L,6210L,256L,212L,19848L,959041L,13941789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284334Inst : IEnumerable<long>
{
public static readonly long[] Value=A284334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284334.Bytes);
public long this[int i]=>Value[i];

public static A284334Inst Instance=new A284334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284335
{
public static readonly long[] Value={ 2L,4L,13L,34L,118L,419L,1481L,5394L,19848L,73880L,277222L,1047495L,3977615L,15169751L,58074521L,223081286L,859450114L,3319751314L,12852496680L,49860496892L,193783946748L,754379484650L,2941051327294L,11481400024511L,44875877924939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284335Inst : IEnumerable<long>
{
public static readonly long[] Value=A284335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284335.Bytes);
public long this[int i]=>Value[i];

public static A284335Inst Instance=new A284335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284336
{
public static readonly long[] Value={ 4L,13L,49L,373L,2259L,18114L,120058L,959041L,6725380L,53524100L,389145239L,3078502323L,22909373317L,180462930528L,1364622501692L,10722180215723L,81993405397067L,643447267719348L,4960055945696896L,38910411283028492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284336Inst : IEnumerable<long>
{
public static readonly long[] Value=A284336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284336.Bytes);
public long this[int i]=>Value[i];

public static A284336Inst Instance=new A284336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284337
{
public static readonly long[] Value={ 8L,42L,415L,5130L,68458L,966889L,13941789L,204883324L,3047634270L,45762072338L,692220227870L,10532157295267L,161005503857341L,2470999756894057L,38049394554096755L,587563040419449964L,9095438545580032870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284337Inst : IEnumerable<long>
{
public static readonly long[] Value=A284337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284337.Bytes);
public long this[int i]=>Value[i];

public static A284337Inst Instance=new A284337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284338
{
public static readonly BigInteger[] Value={ 16L,134L,2243L,70039L,1792007L,53435287L,1495300322L,45518653024L,1328555331356L,40798892221235L,1220007716469208L,37635151585010843L,1142550719106245636L,BigInteger.Parse("35365628106723989270"),BigInteger.Parse("1084498116514868629899"),BigInteger.Parse("33665846562146310363380") };
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
public class A284338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284338Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284338.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A284338.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284338Inst Instance=new A284338Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284387
{
public static readonly long[] Value={ 2L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,2L,1L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284387Inst : IEnumerable<long>
{
public static readonly long[] Value=A284387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284387.Bytes);
public long this[int i]=>Value[i];

public static A284387Inst Instance=new A284387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284388
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284388Inst : IEnumerable<long>
{
public static readonly long[] Value=A284388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284388.Bytes);
public long this[int i]=>Value[i];

public static A284388Inst Instance=new A284388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284389
{
public static readonly long[] Value={ 1L,2L,4L,5L,9L,10L,12L,13L,15L,16L,20L,21L,25L,26L,30L,31L,33L,34L,36L,37L,41L,42L,44L,45L,47L,48L,52L,53L,55L,56L,58L,59L,63L,64L,68L,69L,73L,74L,76L,77L,79L,80L,84L,85L,89L,90L,94L,95L,97L,98L,100L,101L,105L,106L,110L,111L,115L,116L,118L,119L,121L,122L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284389Inst : IEnumerable<long>
{
public static readonly long[] Value=A284389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284389.Bytes);
public long this[int i]=>Value[i];

public static A284389Inst Instance=new A284389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284390
{
public static readonly long[] Value={ 3L,6L,7L,8L,11L,14L,17L,18L,19L,22L,23L,24L,27L,28L,29L,32L,35L,38L,39L,40L,43L,46L,49L,50L,51L,54L,57L,60L,61L,62L,65L,66L,67L,70L,71L,72L,75L,78L,81L,82L,83L,86L,87L,88L,91L,92L,93L,96L,99L,102L,103L,104L,107L,108L,109L,112L,113L,114L,117L,120L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284390Inst : IEnumerable<long>
{
public static readonly long[] Value=A284390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284390.Bytes);
public long this[int i]=>Value[i];

public static A284390Inst Instance=new A284390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284391
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284391Inst : IEnumerable<long>
{
public static readonly long[] Value=A284391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284391.Bytes);
public long this[int i]=>Value[i];

public static A284391Inst Instance=new A284391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284392
{
public static readonly long[] Value={ 3L,4L,8L,9L,11L,12L,14L,15L,19L,20L,24L,25L,29L,30L,32L,33L,35L,36L,40L,41L,43L,44L,46L,47L,51L,52L,54L,55L,57L,58L,62L,63L,67L,68L,72L,73L,75L,76L,78L,79L,83L,84L,88L,89L,93L,94L,96L,97L,99L,100L,104L,105L,109L,110L,114L,115L,117L,118L,120L,121L,125L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284392Inst : IEnumerable<long>
{
public static readonly long[] Value=A284392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284392.Bytes);
public long this[int i]=>Value[i];

public static A284392Inst Instance=new A284392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284393
{
public static readonly long[] Value={ 1L,2L,5L,6L,7L,10L,13L,16L,17L,18L,21L,22L,23L,26L,27L,28L,31L,34L,37L,38L,39L,42L,45L,48L,49L,50L,53L,56L,59L,60L,61L,64L,65L,66L,69L,70L,71L,74L,77L,80L,81L,82L,85L,86L,87L,90L,91L,92L,95L,98L,101L,102L,103L,106L,107L,108L,111L,112L,113L,116L,119L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284393Inst : IEnumerable<long>
{
public static readonly long[] Value=A284393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284393.Bytes);
public long this[int i]=>Value[i];

public static A284393Inst Instance=new A284393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284394
{
public static readonly long[] Value={ 0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284394Inst : IEnumerable<long>
{
public static readonly long[] Value=A284394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284394.Bytes);
public long this[int i]=>Value[i];

public static A284394Inst Instance=new A284394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284395
{
public static readonly long[] Value={ 2L,8L,17L,23L,32L,41L,47L,56L,62L,71L,80L,86L,95L,104L,110L,119L,125L,134L,143L,149L,158L,164L,173L,182L,188L,197L,206L,212L,221L,227L,236L,245L,251L,260L,269L,275L,284L,290L,299L,308L,314L,323L,329L,338L,347L,353L,362L,371L,377L,386L,392L,401L,410L,416L,425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284395Inst : IEnumerable<long>
{
public static readonly long[] Value=A284395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284395.Bytes);
public long this[int i]=>Value[i];

public static A284395Inst Instance=new A284395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284396
{
public static readonly long[] Value={ 5L,11L,14L,20L,26L,29L,35L,38L,44L,50L,53L,59L,65L,68L,74L,77L,83L,89L,92L,98L,101L,107L,113L,116L,122L,128L,131L,137L,140L,146L,152L,155L,161L,167L,170L,176L,179L,185L,191L,194L,200L,203L,209L,215L,218L,224L,230L,233L,239L,242L,248L,254L,257L,263L,266L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284396Inst : IEnumerable<long>
{
public static readonly long[] Value=A284396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284396.Bytes);
public long this[int i]=>Value[i];

public static A284396Inst Instance=new A284396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284397
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,5L,5L,5L,5L,5L,5L,7L,7L,7L,7L,7L,7L,7L,7L,11L,11L,7L,7L,11L,11L,11L,11L,11L,11L,11L,11L,13L,17L,17L,13L,13L,13L,17L,17L,13L,13L,17L,17L,17L,17L,17L,17L,17L,17L,19L,23L,19L,17L,23L,19L,19L,19L,23L,23L,19L,19L,23L,23L,19L,19L,23L,23L,23L,23L,23L,23L,23L,23L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284397Inst : IEnumerable<long>
{
public static readonly long[] Value=A284397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284397.Bytes);
public long this[int i]=>Value[i];

public static A284397Inst Instance=new A284397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284398
{
public static readonly long[] Value={ 1L,4L,2L,2L,0L,21L,2L,30L,2L,16L,1L,10L,1L,2L,0L,5L,0L,143L,7L,260L,1L,94L,1L,170L,7L,20L,0L,92L,0L,5L,4L,47L,0L,17L,0L,11L,1L,0L,0L,16L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1061L,14L,2316L,1L,654L,0L,1934L,24L,128L,1L,943L,1L,36L,11L,753L,0L,142L,0L,146L,4L,3L,0L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284398Inst : IEnumerable<long>
{
public static readonly long[] Value=A284398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284398.Bytes);
public long this[int i]=>Value[i];

public static A284398Inst Instance=new A284398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284399
{
public static readonly ulong[] Value={ 1L,11L,111L,1101L,11101L,110101L,1110001L,11011011L,111011111L,1101010111L,11100010111L,110110110111L,1110111110111L,11010101110111L,111000101110111L,1101101111110111L,11101111011110111L,110101011011110111L,1110001011111110111L,11011011110101010111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284399Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284399.Bytes);
public ulong this[int i]=>Value[i];

public static A284399Inst Instance=new A284399Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284400
{
public static readonly ulong[] Value={ 1L,11L,111L,1011L,10111L,101011L,1000111L,11011011L,111110111L,1110101011L,11101000111L,111011011011L,1110111110111L,11101110101011L,111011101000111L,1110111111011011L,11101111011110111L,111011110110101011L,1110111111101000111L,11101010101111011011UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284400Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284400.Bytes);
public ulong this[int i]=>Value[i];

public static A284400Inst Instance=new A284400Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284401
{
public static readonly long[] Value={ 1L,3L,7L,13L,29L,53L,113L,219L,479L,855L,1815L,3511L,7671L,13687L,29047L,56311L,122615L,218871L,464887L,900439L,1961223L,3501455L,7433611L,14380939L,31423115L,55924875L,118840715L,230520715L,502101643L,896368267L,1902996363L,3681381259L,8044510923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284401Inst : IEnumerable<long>
{
public static readonly long[] Value=A284401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284401.Bytes);
public long this[int i]=>Value[i];

public static A284401Inst Instance=new A284401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284402
{
public static readonly long[] Value={ 1L,3L,7L,11L,23L,43L,71L,219L,503L,939L,1863L,3803L,7671L,15275L,30535L,61403L,122615L,245163L,491335L,961499L,1840887L,3960235L,6871879L,13760219L,27442679L,54815403L,109958471L,220130267L,439211767L,878685611L,1760254791L,3520509659L,7096598007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284402Inst : IEnumerable<long>
{
public static readonly long[] Value=A284402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284402.Bytes);
public long this[int i]=>Value[i];

public static A284402Inst Instance=new A284402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284483
{
public static readonly ulong[] Value={ 1L,0L,111L,1101L,11110L,111101L,1111110L,11111101L,111111110L,1111111101L,11111111110L,111111111101L,1111111111110L,11111111111101L,111111111111110L,1111111111111101L,11111111111111110L,111111111111111101L,1111111111111111110L,11111111111111111101UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284483Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284483.Bytes);
public ulong this[int i]=>Value[i];

public static A284483Inst Instance=new A284483Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284484
{
public static readonly ulong[] Value={ 1L,0L,111L,1011L,1111L,101111L,111111L,10111111L,11111111L,1011111111L,1111111111L,101111111111L,111111111111L,10111111111111L,11111111111111L,1011111111111111L,1111111111111111L,101111111111111111L,111111111111111111L,10111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284484Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284484.Bytes);
public ulong this[int i]=>Value[i];

public static A284484Inst Instance=new A284484Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284485
{
public static readonly long[] Value={ 1L,0L,7L,11L,15L,47L,63L,191L,255L,767L,1023L,3071L,4095L,12287L,16383L,49151L,65535L,196607L,262143L,786431L,1048575L,3145727L,4194303L,12582911L,16777215L,50331647L,67108863L,201326591L,268435455L,805306367L,1073741823L,3221225471L,4294967295L,12884901887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284485Inst : IEnumerable<long>
{
public static readonly long[] Value=A284485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284485.Bytes);
public long this[int i]=>Value[i];

public static A284485Inst Instance=new A284485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284486
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,2L,3L,3L,3L,2L,3L,2L,4L,3L,4L,1L,1L,2L,3L,4L,3L,1L,3L,1L,4L,5L,4L,4L,2L,2L,3L,3L,5L,5L,5L,3L,5L,4L,2L,4L,6L,6L,7L,6L,5L,5L,6L,4L,7L,7L,4L,8L,2L,7L,5L,4L,5L,3L,6L,6L,7L,4L,8L,8L,6L,6L,8L,4L,7L,7L,8L,5L,5L,9L,3L,9L,8L,6L,6L,1L,8L,1L,9L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284486Inst : IEnumerable<long>
{
public static readonly long[] Value=A284486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284486.Bytes);
public long this[int i]=>Value[i];

public static A284486Inst Instance=new A284486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284487
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284487Inst : IEnumerable<long>
{
public static readonly long[] Value=A284487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284487.Bytes);
public long this[int i]=>Value[i];

public static A284487Inst Instance=new A284487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284488
{
public static readonly long[] Value={ 1L,2L,5L,6L,11L,12L,15L,16L,21L,22L,25L,26L,29L,30L,33L,34L,39L,40L,43L,44L,49L,50L,53L,54L,59L,60L,63L,64L,69L,70L,73L,74L,77L,78L,81L,82L,87L,88L,91L,92L,97L,98L,101L,102L,105L,106L,109L,110L,115L,116L,119L,120L,125L,126L,129L,130L,135L,136L,139L,140L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284488Inst : IEnumerable<long>
{
public static readonly long[] Value=A284488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284488.Bytes);
public long this[int i]=>Value[i];

public static A284488Inst Instance=new A284488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284489
{
public static readonly long[] Value={ 3L,4L,7L,8L,9L,10L,13L,14L,17L,18L,19L,20L,23L,24L,27L,28L,31L,32L,35L,36L,37L,38L,41L,42L,45L,46L,47L,48L,51L,52L,55L,56L,57L,58L,61L,62L,65L,66L,67L,68L,71L,72L,75L,76L,79L,80L,83L,84L,85L,86L,89L,90L,93L,94L,95L,96L,99L,100L,103L,104L,107L,108L,111L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284489Inst : IEnumerable<long>
{
public static readonly long[] Value=A284489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284489.Bytes);
public long this[int i]=>Value[i];

public static A284489Inst Instance=new A284489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284490
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284490Inst : IEnumerable<long>
{
public static readonly long[] Value=A284490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284490.Bytes);
public long this[int i]=>Value[i];

public static A284490Inst Instance=new A284490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284491
{
public static readonly long[] Value={ 3L,4L,7L,8L,13L,14L,17L,18L,21L,22L,25L,26L,31L,32L,35L,36L,41L,42L,45L,46L,49L,50L,53L,54L,59L,60L,63L,64L,69L,70L,73L,74L,79L,80L,83L,84L,89L,90L,93L,94L,97L,98L,101L,102L,107L,108L,111L,112L,117L,118L,121L,122L,125L,126L,129L,130L,135L,136L,139L,140L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284491Inst : IEnumerable<long>
{
public static readonly long[] Value=A284491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284491.Bytes);
public long this[int i]=>Value[i];

public static A284491Inst Instance=new A284491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284492
{
public static readonly long[] Value={ 1L,2L,5L,6L,9L,10L,11L,12L,15L,16L,19L,20L,23L,24L,27L,28L,29L,30L,33L,34L,37L,38L,39L,40L,43L,44L,47L,48L,51L,52L,55L,56L,57L,58L,61L,62L,65L,66L,67L,68L,71L,72L,75L,76L,77L,78L,81L,82L,85L,86L,87L,88L,91L,92L,95L,96L,99L,100L,103L,104L,105L,106L,109L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284492Inst : IEnumerable<long>
{
public static readonly long[] Value=A284492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284492.Bytes);
public long this[int i]=>Value[i];

public static A284492Inst Instance=new A284492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284493
{
public static readonly long[] Value={ 18L,26L,40L,93L,95L,122L,227L,5640L,8910L,15481L,56028L,117056L,282103L,394608L,2059983L,3775282L,3804607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284493Inst : IEnumerable<long>
{
public static readonly long[] Value=A284493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284493.Bytes);
public long this[int i]=>Value[i];

public static A284493Inst Instance=new A284493Inst();

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