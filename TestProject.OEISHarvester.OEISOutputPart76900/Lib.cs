using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A285705
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,2L,4L,4L,2L,4L,4L,13L,13L,6L,2L,10L,12L,6L,4L,4L,2L,18L,4L,19L,10L,6L,24L,4L,6L,2L,22L,18L,6L,10L,4L,2L,37L,30L,6L,51L,4L,30L,16L,6L,20L,4L,24L,8L,44L,4L,2L,34L,4L,2L,16L,4L,36L,34L,36L,65L,10L,86L,14L,4L,4L,26L,76L,6L,2L,10L,48L,50L,55L,10L,2L,56L,36L,6L,16L,42L,6L,70L,4L,37L,46L,6L,98L,16L,6L,2L,4L,58L,76L,100L,10L,2L,52L,4L,2L,16L,60L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285705Inst : IEnumerable<long>
{
public static readonly long[] Value=A285705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285705.Bytes);
public long this[int i]=>Value[i];

public static A285705Inst Instance=new A285705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285706
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,2L,3L,1L,1L,1L,1L,3L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285706Inst : IEnumerable<long>
{
public static readonly long[] Value=A285706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285706.Bytes);
public long this[int i]=>Value[i];

public static A285706Inst Instance=new A285706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285707
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,4L,3L,2L,1L,3L,1L,2L,3L,8L,1L,2L,1L,4L,3L,2L,1L,6L,5L,2L,9L,4L,1L,3L,1L,16L,3L,2L,5L,4L,1L,2L,3L,8L,1L,6L,1L,4L,9L,2L,1L,12L,7L,10L,3L,4L,1L,6L,5L,7L,3L,2L,1L,6L,1L,2L,7L,32L,5L,2L,1L,4L,3L,2L,1L,8L,1L,2L,15L,4L,7L,6L,1L,16L,27L,2L,1L,3L,5L,2L,3L,8L,1L,9L,7L,4L,3L,2L,5L,3L,1L,2L,9L,20L,1L,6L,1L,8L,3L,2L,1L,12L,1L,10L,3L,14L,1L,6L,5L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285707Inst : IEnumerable<long>
{
public static readonly long[] Value=A285707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285707.Bytes);
public long this[int i]=>Value[i];

public static A285707Inst Instance=new A285707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285708
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,7L,2L,3L,5L,11L,4L,13L,7L,5L,2L,17L,9L,19L,5L,7L,11L,23L,4L,5L,13L,3L,7L,29L,10L,31L,2L,11L,17L,7L,9L,37L,19L,13L,5L,41L,7L,43L,11L,5L,23L,47L,4L,7L,5L,17L,13L,53L,9L,11L,8L,19L,29L,59L,10L,61L,31L,9L,2L,13L,33L,67L,17L,23L,35L,71L,9L,73L,37L,5L,19L,11L,13L,79L,5L,3L,41L,83L,28L,17L,43L,29L,11L,89L,10L,13L,23L,31L,47L,19L,32L,97L,49L,11L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285708Inst : IEnumerable<long>
{
public static readonly long[] Value=A285708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285708.Bytes);
public long this[int i]=>Value[i];

public static A285708Inst Instance=new A285708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285709
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,1L,0L,0L,2L,0L,0L,4L,0L,4L,0L,4L,0L,2L,0L,2L,0L,0L,0L,5L,0L,0L,14L,14L,14L,8L,0L,12L,12L,8L,0L,6L,0L,8L,6L,8L,0L,4L,0L,10L,8L,4L,0L,12L,10L,17L,6L,2L,0L,10L,0L,0L,22L,0L,8L,18L,0L,28L,2L,18L,0L,16L,0L,26L,10L,24L,32L,18L,0L,16L,0L,22L,0L,21L,4L,20L,50L,16L,0L,15L,30L,16L,48L,16L,2L,17L,0L,8L,42L,20L,0L,26L,0L,8L,24L,10L,0L,24L,0L,30L,42L,34L,0L,30L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285709Inst : IEnumerable<long>
{
public static readonly long[] Value=A285709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285709.Bytes);
public long this[int i]=>Value[i];

public static A285709Inst Instance=new A285709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285710
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,13L,14L,16L,17L,19L,21L,23L,25L,27L,28L,29L,31L,32L,37L,41L,43L,47L,49L,53L,59L,61L,62L,64L,67L,71L,73L,79L,81L,83L,89L,97L,101L,103L,107L,109L,113L,121L,124L,125L,127L,128L,131L,137L,139L,149L,151L,157L,163L,167L,169L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285710Inst : IEnumerable<long>
{
public static readonly long[] Value=A285710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285710.Bytes);
public long this[int i]=>Value[i];

public static A285710Inst Instance=new A285710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285711
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,4L,1L,4L,3L,2L,1L,1L,1L,8L,1L,8L,1L,4L,1L,4L,9L,4L,1L,2L,5L,2L,9L,16L,1L,1L,1L,16L,1L,2L,1L,8L,1L,4L,3L,8L,1L,6L,1L,8L,3L,8L,1L,4L,7L,10L,1L,4L,1L,12L,5L,1L,3L,2L,1L,2L,1L,32L,1L,32L,1L,2L,1L,4L,1L,2L,1L,16L,1L,2L,5L,8L,1L,18L,1L,16L,27L,2L,1L,3L,1L,4L,1L,16L,1L,3L,1L,16L,3L,16L,1L,1L,1L,8L,3L,20L,1L,2L,1L,8L,3L,2L,1L,24L,1L,10L,3L,2L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285711Inst : IEnumerable<long>
{
public static readonly long[] Value=A285711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285711.Bytes);
public long this[int i]=>Value[i];

public static A285711Inst Instance=new A285711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285712
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,4L,6L,3L,7L,9L,4L,10L,5L,5L,12L,15L,6L,8L,16L,7L,19L,21L,8L,22L,13L,9L,24L,11L,10L,27L,30L,11L,17L,31L,12L,34L,36L,13L,18L,37L,14L,40L,20L,15L,42L,28L,16L,26L,45L,17L,49L,51L,18L,52L,54L,19L,55L,29L,20L,33L,25L,21L,14L,57L,22L,64L,43L,23L,66L,69L,24L,39L,35L,25L,70L,75L,26L,44L,76L,27L,48L,79L,28L,82L,61L,29L,84L,23L,30L,87L,90L,31L,47L,46L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285712Inst : IEnumerable<long>
{
public static readonly long[] Value=A285712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285712.Bytes);
public long this[int i]=>Value[i];

public static A285712Inst Instance=new A285712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285713
{
public static readonly long[] Value={ 1L,2L,2L,2L,6L,2L,8L,4L,2L,12L,6L,4L,2L,12L,2L,6L,6L,2L,12L,12L,2L,6L,6L,2L,12L,24L,2L,6L,32L,12L,2L,2L,6L,6L,30L,2L,2L,210L,6L,60L,12L,2L,48L,24L,6L,6L,30L,6L,6L,30L,2L,120L,6L,2L,12L,72L,6L,30L,2L,6L,12L,6L,12L,4L,6L,6L,48L,60L,6L,60L,6L,2L,24L,192L,6L,6L,24L,768L,2L,6L,2L,6L,6L,6L,2L,30L,6L,210L,6L,6L,12L,48L,6L,12L,6L,6L,96L,12L,6L,30L,12L,12L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285713Inst : IEnumerable<long>
{
public static readonly long[] Value=A285713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285713.Bytes);
public long this[int i]=>Value[i];

public static A285713Inst Instance=new A285713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285714
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,4L,5L,3L,6L,7L,4L,8L,3L,3L,9L,10L,5L,4L,11L,6L,12L,13L,4L,14L,4L,7L,15L,5L,8L,16L,17L,5L,6L,18L,9L,19L,20L,4L,5L,21L,4L,22L,7L,10L,23L,6L,11L,8L,24L,6L,25L,26L,5L,27L,28L,12L,29L,9L,7L,7L,5L,13L,4L,30L,14L,31L,8L,5L,32L,33L,15L,6L,10L,5L,34L,35L,8L,11L,36L,16L,9L,37L,6L,38L,6L,9L,39L,5L,17L,40L,41L,18L,12L,7L,6L,42L,43L,7L,44L,45L,19L,10L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285714Inst : IEnumerable<long>
{
public static readonly long[] Value=A285714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285714.Bytes);
public long this[int i]=>Value[i];

public static A285714Inst Instance=new A285714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285715
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,4L,5L,2L,6L,7L,3L,8L,2L,1L,9L,10L,4L,3L,11L,5L,12L,13L,2L,14L,3L,6L,15L,4L,7L,16L,17L,3L,5L,18L,8L,19L,20L,2L,4L,21L,1L,22L,6L,9L,23L,5L,10L,7L,24L,4L,25L,26L,3L,27L,28L,11L,29L,8L,5L,6L,4L,12L,2L,30L,13L,31L,7L,2L,32L,33L,14L,5L,9L,3L,34L,35L,6L,10L,36L,15L,8L,37L,4L,38L,5L,7L,39L,3L,16L,40L,41L,17L,11L,6L,3L,42L,43L,5L,44L,45L,18L,9L,12L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285715Inst : IEnumerable<long>
{
public static readonly long[] Value=A285715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285715.Bytes);
public long this[int i]=>Value[i];

public static A285715Inst Instance=new A285715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285716
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,2L,0L,0L,1L,1L,0L,1L,0L,0L,2L,0L,1L,1L,0L,1L,1L,0L,0L,2L,1L,0L,1L,0L,0L,2L,1L,0L,3L,0L,1L,1L,0L,1L,1L,1L,0L,2L,0L,0L,2L,0L,0L,1L,0L,1L,2L,1L,1L,1L,2L,0L,1L,0L,1L,3L,0L,0L,1L,1L,1L,2L,0L,0L,2L,1L,0L,1L,1L,0L,2L,0L,1L,2L,0L,2L,1L,0L,0L,1L,1L,1L,3L,0L,0L,2L,0L,0L,1L,1L,1L,2L,1L,0L,1L,1L,1L,1L,1L,0L,3L,0L,0L,2L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285716Inst : IEnumerable<long>
{
public static readonly long[] Value=A285716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285716.Bytes);
public long this[int i]=>Value[i];

public static A285716Inst Instance=new A285716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285781
{
public static readonly BigInteger[] Value={ 1L,10L,10L,0L,1100L,0L,11000L,0L,11110000L,0L,1100000L,0L,100111000000L,0L,1100110000000L,0L,1111111100000000L,0L,100000011000000000L,1000000000000000L,1000011110000000000L,BigInteger.Parse("101110000000000000000"),11001100000000000L,BigInteger.Parse("10101000000000000000000"),111111000000000000L };
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
public class A285781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285781Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285781.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285781.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285781Inst Instance=new A285781Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285782
{
public static readonly long[] Value={ 1L,1L,2L,0L,6L,0L,12L,0L,30L,0L,48L,0L,114L,0L,204L,0L,510L,0L,770L,16L,1924L,58L,3264L,42L,8064L,96L,12432L,132L,31074L,336L,52762L,580L,129314L,2028L,198658L,2048L,496646L,5120L,844324L,640L,2077702L,3400L,3178642L,131400L,7979700L,405762L,13222580L,539914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285782Inst : IEnumerable<long>
{
public static readonly long[] Value=A285782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285782.Bytes);
public long this[int i]=>Value[i];

public static A285782Inst Instance=new A285782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285783
{
public static readonly long[] Value={ 1L,2L,2L,0L,12L,0L,24L,0L,240L,0L,96L,0L,2496L,0L,6528L,0L,65280L,0L,132608L,32768L,277504L,1507328L,104448L,5505024L,258048L,1572864L,4743168L,34603008L,148094976L,44040192L,741965824L,574619648L,2302607360L,3749707776L,8598716416L,16777216L,51627425792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285783Inst : IEnumerable<long>
{
public static readonly long[] Value=A285783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285783.Bytes);
public long this[int i]=>Value[i];

public static A285783Inst Instance=new A285783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285784
{
public static readonly long[] Value={ 1L,121L,143L,169L,187L,209L,221L,247L,289L,299L,323L,361L,377L,391L,403L,437L,481L,493L,527L,529L,533L,551L,559L,589L,611L,629L,667L,689L,697L,703L,713L,731L,767L,779L,793L,799L,817L,841L,851L,871L,893L,899L,901L,923L,943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285784Inst : IEnumerable<long>
{
public static readonly long[] Value=A285784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285784.Bytes);
public long this[int i]=>Value[i];

public static A285784Inst Instance=new A285784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285785
{
public static readonly long[] Value={ 1L,3L,5L,6L,11L,12L,15L,21L,23L,25L,30L,64L,71L,72L,409L,1491L,1555L,4469L,5289L,7002L,16174L,16485L,68133L,73853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285785Inst : IEnumerable<long>
{
public static readonly long[] Value=A285785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285785.Bytes);
public long this[int i]=>Value[i];

public static A285785Inst Instance=new A285785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285786
{
public static readonly long[] Value={ 1L,3L,3L,4L,4L,5L,5L,6L,6L,9L,7L,8L,7L,9L,10L,10L,9L,12L,10L,11L,13L,11L,14L,13L,14L,13L,14L,16L,16L,15L,15L,16L,17L,18L,19L,14L,22L,19L,18L,16L,22L,18L,24L,20L,22L,22L,20L,23L,24L,22L,23L,21L,25L,27L,24L,27L,26L,25L,27L,25L,23L,33L,28L,25L,29L,28L,31L,30L,33L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285786Inst : IEnumerable<long>
{
public static readonly long[] Value=A285786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285786.Bytes);
public long this[int i]=>Value[i];

public static A285786Inst Instance=new A285786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285787
{
public static readonly long[] Value={ 3L,2L,8L,17L,32L,97L,128L,257L,769L,2048L,4097L,6144L,8192L,40961L,73728L,65537L,131072L,524289L,524288L,3145728L,6291456L,8388608L,18874368L,50331648L,113246209L,167772161L,268435457L,805306368L,1610612737L,2147483649L,2147483648L,17179869184L,21474836480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285787Inst : IEnumerable<long>
{
public static readonly long[] Value=A285787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285787.Bytes);
public long this[int i]=>Value[i];

public static A285787Inst Instance=new A285787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285788
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,1L,1L,4L,6L,1L,1L,4L,8L,1L,9L,1L,4L,6L,8L,9L,10L,1L,1L,4L,6L,8L,9L,10L,12L,1L,9L,1L,4L,8L,14L,1L,9L,15L,1L,4L,6L,8L,9L,10L,12L,14L,15L,16L,1L,1L,4L,6L,8L,9L,10L,12L,14L,15L,16L,18L,1L,9L,1L,4L,8L,10L,16L,20L,1L,9L,15L,21L,1L,4L,6L,8L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285788Inst : IEnumerable<long>
{
public static readonly long[] Value=A285788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285788.Bytes);
public long this[int i]=>Value[i];

public static A285788Inst Instance=new A285788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285789
{
public static readonly long[] Value={ 2L,13L,23L,71L,211L,331L,853L,1163L,1427L,2381L,2753L,3433L,3877L,5923L,6113L,6701L,7741L,8627L,9323L,11311L,12377L,14653L,14951L,17443L,18427L,23003L,27271L,31033L,32341L,32783L,34127L,38321L,43777L,52361L,55201L,56941L,57527L,62323L,64171L,64793L,69877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285789Inst : IEnumerable<long>
{
public static readonly long[] Value=A285789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285789.Bytes);
public long this[int i]=>Value[i];

public static A285789Inst Instance=new A285789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285790
{
public static readonly long[] Value={ 2L,7L,29L,67L,191L,277L,379L,631L,947L,1129L,1327L,2017L,2557L,2851L,4561L,4951L,5779L,6217L,8647L,9181L,12721L,13367L,14029L,15401L,16111L,17579L,20707L,21529L,22367L,24091L,24977L,31627L,36857L,37951L,42487L,43661L,44851L,47279L,53629L,58997L,64621L,66067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285790Inst : IEnumerable<long>
{
public static readonly long[] Value=A285790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285790.Bytes);
public long this[int i]=>Value[i];

public static A285790Inst Instance=new A285790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285791
{
public static readonly long[] Value={ 2L,19L,113L,149L,541L,617L,971L,1289L,1783L,2357L,3011L,3187L,5689L,6427L,7481L,7757L,9829L,12497L,12853L,14327L,15881L,17099L,18793L,21023L,24851L,28463L,30637L,31193L,45361L,50909L,54539L,60607L,63761L,66179L,69473L,70309L,83449L,88079L,90917L,91873L,94771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285791Inst : IEnumerable<long>
{
public static readonly long[] Value=A285791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285791.Bytes);
public long this[int i]=>Value[i];

public static A285791Inst Instance=new A285791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285792
{
public static readonly long[] Value={ 2L,41L,97L,281L,409L,937L,1409L,2297L,4721L,5209L,6257L,8009L,8641L,12161L,14561L,18097L,21001L,23057L,24121L,26321L,27457L,37409L,42961L,50441L,52009L,55217L,56857L,60209L,70841L,76481L,90481L,139537L,147409L,152777L,161009L,169457L,172321L,227977L,238009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285792Inst : IEnumerable<long>
{
public static readonly long[] Value=A285792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285792.Bytes);
public long this[int i]=>Value[i];

public static A285792Inst Instance=new A285792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285793
{
public static readonly long[] Value={ 1L,4L,2L,18L,13L,5L,96L,83L,43L,18L,600L,582L,342L,192L,84L,4320L,4554L,2874L,1824L,1068L,480L,35280L,39672L,26232L,17832L,11784L,7080L,3240L,322560L,382248L,261288L,185688L,131256L,88920L,54360L,25200L,3265920L,4044240L,2834640L,2078640L,1534320L,1110960L,765360L,473760L,221760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285793Inst : IEnumerable<long>
{
public static readonly long[] Value=A285793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285793.Bytes);
public long this[int i]=>Value[i];

public static A285793Inst Instance=new A285793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285794
{
public static readonly long[] Value={ 1L,2L,3L,10L,22L,51L,125L,293L,696L,1657L,3928L,9330L,22157L,52601L,124905L,296578L,704191L,1672062L,3970178L,9426875L,22383417L,53147701L,126195160L,299640813L,711474236L,1689341342L,4011212253L,9524317645L,22614766177L,53697038226L,127499523515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285794Inst : IEnumerable<long>
{
public static readonly long[] Value=A285794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285794.Bytes);
public long this[int i]=>Value[i];

public static A285794Inst Instance=new A285794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285795
{
public static readonly BigInteger[] Value={ 0L,0L,2L,13L,83L,582L,4554L,39672L,382248L,4044240L,46663920L,583554240L,7865622720L,113711230080L,1755484617600L,28828769356800L,501858148377600L,9232213174732800L,178968924600883200L,3646603415927808000L,BigInteger.Parse("77916767838981120000"),BigInteger.Parse("1742147265551616000000") };
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
public class A285795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285795Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285795.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285795.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285795Inst Instance=new A285795Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285796
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,2L,1L,0L,0L,2L,4L,0L,0L,0L,3L,2L,2L,2L,2L,2L,0L,4L,3L,2L,1L,2L,4L,0L,2L,4L,8L,2L,0L,4L,6L,4L,1L,4L,5L,4L,0L,6L,8L,6L,2L,0L,7L,4L,4L,4L,8L,4L,2L,6L,8L,10L,0L,4L,4L,6L,5L,6L,9L,4L,5L,6L,14L,8L,2L,6L,5L,8L,5L,10L,8L,4L,0L,10L,12L,4L,6L,6L,10L,6L,8L,12L,13L,6L,4L,12L,14L,12L,4L,8L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285796Inst : IEnumerable<long>
{
public static readonly long[] Value=A285796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285796.Bytes);
public long this[int i]=>Value[i];

public static A285796Inst Instance=new A285796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285861
{
public static readonly BigInteger[] Value={ 1L,550L,71225L,5448300L,355885530L,17364367020L,748875613200L,31800834780000L,1237174959934485L,46053097166277630L,1673378033771898675L,BigInteger.Parse("61000413008705597700"),BigInteger.Parse("2201843172941618228220"),BigInteger.Parse("79401490178154061870920"),BigInteger.Parse("2850407051830237872094980") };
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
public class A285861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285861Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285861.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285861.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285861Inst Instance=new A285861Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285862
{
public static readonly BigInteger[] Value={ 1L,1L,19L,1005L,62601L,6061545L,868380535L,142349568361L,27564092244689L,6325532235438273L,1673378033771898675L,BigInteger.Parse("505141951803309946125"),BigInteger.Parse("170002056228253072537065"),BigInteger.Parse("63255335047795174479833625"),BigInteger.Parse("25805276337820748477042392695"),BigInteger.Parse("11427131417576257617280878155625") };
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
public class A285862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285862Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285862.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285862.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285862Inst Instance=new A285862Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285863
{
public static readonly BigInteger[] Value={ 1L,-3L,3L,0L,-27L,0L,243L,0L,-2187L,0L,98415L,0L,-122408577L,0L,11160261L,0L,-51899996619L,0L,5664991530321L,0L,-202943637014337L,0L,8938507796555139L,0L,BigInteger.Parse("-22252066887294301257"),0L,7246946747292751629L,0L,BigInteger.Parse("-181103830292539169071623") };
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
public class A285863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285863Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285863.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285863.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285863Inst Instance=new A285863Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285864
{
public static readonly long[] Value={ 1L,-1L,1L,2L,-2L,1L,0L,2L,-3L,1L,-8L,0L,4L,-4L,1L,0L,-8L,0L,20L,-5L,1L,32L,0L,-8L,0L,10L,-6L,1L,0L,32L,0L,-56L,0L,14L,-7L,1L,-128L,0L,128L,0L,-112L,0L,56L,-8L,1L,0L,-384L,0L,128L,0L,-336L,0L,24L,-9L,1L,2560L,0L,-384L,0L,320L,0L,-112L,0L,30L,-10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285864Inst : IEnumerable<long>
{
public static readonly long[] Value=A285864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285864.Bytes);
public long this[int i]=>Value[i];

public static A285864Inst Instance=new A285864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285865
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,15L,1L,1L,1L,1L,1L,3L,1L,3L,1L,1L,21L,1L,1L,1L,1L,1L,1L,1L,3L,1L,3L,1L,1L,1L,1L,15L,1L,3L,1L,3L,1L,3L,1L,1L,1L,5L,1L,1L,1L,5L,1L,1L,1L,1L,33L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285865Inst : IEnumerable<long>
{
public static readonly long[] Value=A285865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285865.Bytes);
public long this[int i]=>Value[i];

public static A285865Inst Instance=new A285865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285866
{
public static readonly BigInteger[] Value={ 1L,-2L,11L,-6L,127L,-10L,221L,-14L,367L,-18L,-1895L,-22L,1447237L,-26L,-57253L,-30L,118526399L,-34L,-5749677193L,-38L,91546283957L,-42L,-1792042789427L,-46L,1982765468376757L,-50L,-286994504449237L,-54L,3187598676787485443L,-58L,BigInteger.Parse("-4625594554880206360895"),-62L };
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
public class A285866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285866Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285866.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285866.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285866Inst Instance=new A285866Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285867
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,3L,0L,1L,7L,12L,0L,1L,15L,50L,60L,0L,1L,31L,180L,390L,360L,0L,1L,63L,602L,2100L,3360L,2520L,0L,1L,127L,1932L,10206L,25200L,31920L,20160L,0L,1L,255L,6050L,46620L,166824L,317520L,332640L,181440L,0L,1L,511L,18660L,204630L,1020600L,2739240L,4233600L,3780000L,1814400L,0L,1L,1023L,57002L,874500L,5921520L,21538440L,46070640L,59875200L,46569600L,19958400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285867Inst : IEnumerable<long>
{
public static readonly long[] Value=A285867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285867.Bytes);
public long this[int i]=>Value[i];

public static A285867Inst Instance=new A285867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285868
{
public static readonly long[] Value={ 1L,1L,4L,20L,126L,962L,8646L,89546L,1051350L,13811642L,200866326L,3205348346L,55704133590L,1047489675962L,21195507649686L,459258707587706L,10610386574074710L,260385846630175802L,6764666952807962646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285868Inst : IEnumerable<long>
{
public static readonly long[] Value=A285868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285868.Bytes);
public long this[int i]=>Value[i];

public static A285868Inst Instance=new A285868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285869
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,4L,3L,4L,5L,6L,5L,6L,7L,8L,7L,8L,9L,10L,9L,10L,11L,12L,11L,12L,13L,14L,13L,14L,15L,16L,15L,16L,17L,18L,17L,18L,19L,20L,19L,20L,21L,22L,21L,22L,23L,24L,23L,24L,25L,26L,25L,26L,27L,28L,27L,28L,29L,30L,29L,30L,31L,32L,31L,32L,33L,34L,33L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285869Inst : IEnumerable<long>
{
public static readonly long[] Value=A285869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285869.Bytes);
public long this[int i]=>Value[i];

public static A285869Inst Instance=new A285869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285870
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,2L,2L,3L,3L,4L,3L,4L,4L,5L,5L,6L,5L,6L,6L,7L,7L,8L,7L,8L,8L,9L,9L,10L,9L,10L,10L,11L,11L,12L,11L,12L,12L,13L,13L,14L,13L,14L,14L,15L,15L,16L,15L,16L,16L,17L,17L,18L,17L,18L,18L,19L,19L,20L,19L,20L,20L,21L,21L,22L,21L,22L,22L,23L,23L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285870Inst : IEnumerable<long>
{
public static readonly long[] Value=A285870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285870.Bytes);
public long this[int i]=>Value[i];

public static A285870Inst Instance=new A285870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285871
{
public static readonly long[] Value={ 1L,3L,0L,6L,5L,6L,2L,9L,6L,4L,8L,7L,6L,3L,7L,6L,5L,2L,7L,8L,5L,6L,6L,4L,3L,1L,7L,3L,4L,2L,7L,1L,8L,7L,1L,5L,3L,5L,8L,3L,7L,6L,1L,1L,8L,8L,3L,4L,9L,2L,6L,9L,5L,2L,7L,5L,4L,8L,8L,9L,8L,3L,6L,6L,9L,0L,8L,0L,8L,1L,0L,4L,1L,4L,6L,1L,1L,9L,2L,0L,5L,0L,9L,5L,1L,8L,5L,3L,7L,2L,0L,1L,9L,2L,6L,2L,8L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285871Inst : IEnumerable<long>
{
public static readonly long[] Value=A285871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285871.Bytes);
public long this[int i]=>Value[i];

public static A285871Inst Instance=new A285871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285872
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,3L,4L,5L,6L,7L,8L,7L,8L,9L,10L,11L,12L,11L,12L,13L,14L,15L,16L,15L,16L,17L,18L,19L,20L,19L,20L,21L,22L,23L,24L,23L,24L,25L,26L,27L,28L,27L,28L,29L,30L,31L,32L,31L,32L,33L,34L,35L,36L,35L,36L,37L,38L,39L,40L,39L,40L,41L,42L,43L,44L,43L,44L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285872Inst : IEnumerable<long>
{
public static readonly long[] Value=A285872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285872.Bytes);
public long this[int i]=>Value[i];

public static A285872Inst Instance=new A285872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285873
{
public static readonly long[] Value={ 1L,21L,441L,9872L,220447L,5247292L,124278971L,3113440755L,77520962327L,2024021927610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285873Inst : IEnumerable<long>
{
public static readonly long[] Value=A285873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285873.Bytes);
public long this[int i]=>Value[i];

public static A285873Inst Instance=new A285873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285874
{
public static readonly long[] Value={ 1L,20L,400L,8702L,188473L,4505624L,106770421L,2770746488L,71151220765L,1969755500063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285874Inst : IEnumerable<long>
{
public static readonly long[] Value=A285874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285874.Bytes);
public long this[int i]=>Value[i];

public static A285874Inst Instance=new A285874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285875
{
public static readonly long[] Value={ 1L,18L,324L,6572L,132640L,3030492L,68633066L,1733220521L,43321058602L,1182486223832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285875Inst : IEnumerable<long>
{
public static readonly long[] Value=A285875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285875.Bytes);
public long this[int i]=>Value[i];

public static A285875Inst Instance=new A285875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285876
{
public static readonly long[] Value={ 1L,22L,484L,11248L,260904L,6434922L,158069690L,4126252938L,107097735673L,2940365284820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285876Inst : IEnumerable<long>
{
public static readonly long[] Value=A285876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285876.Bytes);
public long this[int i]=>Value[i];

public static A285876Inst Instance=new A285876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285925
{
public static readonly BigInteger[] Value={ 1L,550L,69025L,4254250L,201371170L,7180042870L,196518086050L,4766802769300L,102889172957285L,2006511403380770L,36104901766271975L,597121503366547250L,9381072363234242330UL,BigInteger.Parse("140940747710164417070"),BigInteger.Parse("2033219852450765548790"),BigInteger.Parse("28025263737301449789500") };
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
public class A285925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285925Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285925.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285925.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285925Inst Instance=new A285925Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285926
{
public static readonly BigInteger[] Value={ 1L,1L,11L,420L,17129L,1049895L,97141022L,10742461730L,1370094506209L,207877406991111L,36104901766271975L,7033373902938469086L,BigInteger.Parse("1531762189401458287506"),BigInteger.Parse("368890302956243012167470"),BigInteger.Parse("97283928918541409263666020"),BigInteger.Parse("27895730515878936009534815250") };
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
public class A285926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285926Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285926.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285926.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285926Inst Instance=new A285926Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285927
{
public static readonly long[] Value={ 1L,3L,9L,19L,42L,81L,155L,276L,486L,821L,1368L,2214L,3541L,5544L,8586L,13082L,19740L,29403L,43414L,63423L,91935L,132075L,188418L,266733L,375232L,524331L,728514L,1006216L,1382604L,1889739L,2570719L,3480420L,4691682L,6297102L,8418252L,11209347L,14870970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285927Inst : IEnumerable<long>
{
public static readonly long[] Value=A285927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285927.Bytes);
public long this[int i]=>Value[i];

public static A285927Inst Instance=new A285927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285928
{
public static readonly long[] Value={ 1L,5L,20L,65L,190L,501L,1240L,2890L,6440L,13775L,28502L,57205L,111880L,213670L,399620L,733128L,1321850L,2345340L,4100700L,7072520L,12045005L,20272465L,33746060L,55595635L,90706390L,146638756L,235016940L,373580735L,589238640L,922537655L,1434232510L,2214817165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285928Inst : IEnumerable<long>
{
public static readonly long[] Value=A285928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285928.Bytes);
public long this[int i]=>Value[i];

public static A285928Inst Instance=new A285928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285929
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,7L,8L,13L,16L,17L,19L,31L,61L,89L,107L,127L,521L,607L,1279L,2203L,2281L,3217L,4253L,4423L,9689L,9941L,11213L,19937L,21701L,23209L,44497L,86243L,110503L,132049L,216091L,756839L,859433L,1257787L,1398269L,2976221L,3021377L,6972593L,13466917L,20996011L,24036583L,25964951L,30402457L,32582657L,37156667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285929Inst : IEnumerable<long>
{
public static readonly long[] Value=A285929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285929.Bytes);
public long this[int i]=>Value[i];

public static A285929Inst Instance=new A285929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285930
{
public static readonly long[] Value={ 2L,2L,1L,2L,2L,0L,2L,2L,1L,2L,2L,0L,2L,2L,1L,2L,1L,0L,2L,2L,1L,2L,2L,0L,2L,2L,1L,2L,2L,0L,2L,2L,1L,2L,0L,2L,2L,1L,2L,2L,0L,2L,2L,1L,2L,2L,0L,2L,2L,1L,0L,2L,2L,1L,2L,2L,0L,2L,2L,1L,2L,2L,0L,2L,2L,1L,2L,0L,2L,2L,1L,2L,2L,0L,2L,2L,1L,2L,2L,0L,2L,2L,1L,0L,2L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285930Inst : IEnumerable<long>
{
public static readonly long[] Value=A285930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285930.Bytes);
public long this[int i]=>Value[i];

public static A285930Inst Instance=new A285930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285931
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285931Inst : IEnumerable<long>
{
public static readonly long[] Value=A285931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285931.Bytes);
public long this[int i]=>Value[i];

public static A285931Inst Instance=new A285931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285932
{
public static readonly long[] Value={ 1L,-5L,5L,10L,-15L,-1L,-30L,50L,65L,-95L,-1L,-170L,220L,300L,-380L,0L,-635L,820L,1025L,-1310L,0L,-2045L,2525L,3140L,-3845L,2L,-5780L,7070L,8565L,-10405L,-1L,-15130L,18125L,21760L,-25960L,0L,-36820L,43780L,51785L,-61290L,0L,-85170L,100030L,117500L,-137550L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285932Inst : IEnumerable<long>
{
public static readonly long[] Value=A285932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285932.Bytes);
public long this[int i]=>Value[i];

public static A285932Inst Instance=new A285932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285933
{
public static readonly long[] Value={ 1L,1L,2L,3L,14L,1L,2L,10L,8L,3L,17L,28L,62L,8L,58L,20L,64L,1L,12L,75L,14L,6L,197L,41L,128L,63L,14L,65L,8L,58L,114L,98L,63L,45L,124L,36L,72L,516L,28L,45L,43L,183L,2L,25L,142L,68L,249L,30L,324L,155L,188L,200L,334L,56L,87L,178L,98L,110L,22L,25L,24L,70L,2L,271L,17L,498L,412L,750L,877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285933Inst : IEnumerable<long>
{
public static readonly long[] Value=A285933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285933.Bytes);
public long this[int i]=>Value[i];

public static A285933Inst Instance=new A285933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285934
{
public static readonly BigInteger[] Value={ 1L,6L,37L,750L,459829L,210067308558L,BigInteger.Parse("44127887746326310604917"),BigInteger.Parse("1947270476915296449559791701269341583074001038") };
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
public class A285934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285934Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285934.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285934.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285934Inst Instance=new A285934Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285935
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,10L,10L,4L,5L,18L,26L,18L,5L,6L,30L,58L,58L,30L,6L,7L,47L,116L,153L,116L,47L,7L,8L,70L,214L,354L,354L,214L,70L,8L,9L,100L,371L,746L,931L,746L,371L,100L,9L,10L,138L,612L,1464L,2204L,2204L,1464L,612L,138L,10L,11L,185L,969L,2714L,4816L,5794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285935Inst : IEnumerable<long>
{
public static readonly long[] Value=A285935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285935.Bytes);
public long this[int i]=>Value[i];

public static A285935Inst Instance=new A285935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285936
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285936Inst : IEnumerable<long>
{
public static readonly long[] Value=A285936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285936.Bytes);
public long this[int i]=>Value[i];

public static A285936Inst Instance=new A285936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285937
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,14L,15L,38L,60L,66L,95L,101L,206L,225L,1382L,1782L,2046L,2220L,2484L,2592L,4578L,11238L,13016L,18329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285937Inst : IEnumerable<long>
{
public static readonly long[] Value=A285937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285937.Bytes);
public long this[int i]=>Value[i];

public static A285937Inst Instance=new A285937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285938
{
public static readonly long[] Value={ 1L,2L,5L,7L,8L,11L,16L,29L,73L,169L,212L,227L,262L,547L,863L,1325L,2035L,4808L,8405L,13612L,16687L,19456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285938Inst : IEnumerable<long>
{
public static readonly long[] Value=A285938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285938.Bytes);
public long this[int i]=>Value[i];

public static A285938Inst Instance=new A285938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285939
{
public static readonly long[] Value={ 1L,2L,4L,10L,17L,33L,51L,63L,92L,441L,517L,578L,1252L,1456L,2261L,4857L,8420L,9872L,13444L,14175L,16316L,28978L,30865L,84409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285939Inst : IEnumerable<long>
{
public static readonly long[] Value=A285939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285939.Bytes);
public long this[int i]=>Value[i];

public static A285939Inst Instance=new A285939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285940
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,40L,43L,74L,98L,181L,186L,428L,532L,644L,1664L,2016L,2476L,2911L,2959L,3007L,5964L,7758L,22231L,92152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285940Inst : IEnumerable<long>
{
public static readonly long[] Value=A285940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285940.Bytes);
public long this[int i]=>Value[i];

public static A285940Inst Instance=new A285940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285989
{
public static readonly long[] Value={ 0L,1L,16L,82L,256L,626L,1312L,2402L,4096L,6643L,10016L,14642L,20992L,28562L,38432L,51332L,65536L,83522L,106288L,130322L,160256L,196964L,234272L,279842L,335872L,391251L,456992L,538084L,614912L,707282L,821312L,923522L,1048576L,1200644L,1336352L,1503652L,1700608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285989Inst : IEnumerable<long>
{
public static readonly long[] Value=A285989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285989.Bytes);
public long this[int i]=>Value[i];

public static A285989Inst Instance=new A285989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285990
{
public static readonly long[] Value={ 1L,-2L,-14L,-24L,78L,536L,1236L,-308L,-12322L,-45218L,-73680L,76144L,872868L,2833904L,4612952L,-2467592L,-42205746L,-147191388L,-285572658L,-127256088L,1376616024L,6138841704L,14949184532L,19201535108L,-18287313476L,-186761626394L,-604980766280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285990Inst : IEnumerable<long>
{
public static readonly long[] Value=A285990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285990.Bytes);
public long this[int i]=>Value[i];

public static A285990Inst Instance=new A285990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285991
{
public static readonly long[] Value={ 1L,-2L,-30L,-100L,262L,3672L,13836L,-80L,-264810L,-1421438L,-3019032L,7630764L,89648580L,358974280L,548677872L,-2390377936L,-20531491146L,-74635378020L,-110275527170L,425036176572L,3669041188152L,13597190512480L,23995331740700L,-45340748171760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285991Inst : IEnumerable<long>
{
public static readonly long[] Value=A285991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285991.Bytes);
public long this[int i]=>Value[i];

public static A285991Inst Instance=new A285991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285992
{
public static readonly BigInteger[] Value={ 11L,29L,199L,521L,3571L,9349L,3010349L,54018521L,370248451L,6643838879L,119218851371L,5600748293801L,688846502588399L,32361122672259149L,BigInteger.Parse("412670427844921037470771"),BigInteger.Parse("258899611203303418721656157249445530046830073044201152332257717521") };
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
public class A285992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285992Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285992.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285992.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285992Inst Instance=new A285992Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285993
{
public static readonly BigInteger[] Value={ 15015L,255255L,4849845L,111546435L,33426748355L,1236789689135L,50708377254535L,2180460221945005L,102481630431415235L,5431526412865007455L,BigInteger.Parse("320460058359035439845"),BigInteger.Parse("19548063559901161830545"),BigInteger.Parse("1309720258513377842646515"),BigInteger.Parse("1357656019974967471687377449"),BigInteger.Parse("107254825578022430263302818471") };
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
public class A285993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285993Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285993.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285993.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285993Inst Instance=new A285993Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285994
{
public static readonly long[] Value={ 0L,1L,1L,4L,6L,11L,26L,46L,84L,167L,313L,576L,1086L,2016L,3710L,6876L,12660L,23196L,42542L,77798L,141910L,258648L,470558L,854644L,1550588L,2809620L,5084588L,9192349L,16601714L,29953754L,53997062L,97257129L,175033355L,314771224L,565664138L,1015841191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285994Inst : IEnumerable<long>
{
public static readonly long[] Value=A285994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285994.Bytes);
public long this[int i]=>Value[i];

public static A285994Inst Instance=new A285994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285995
{
public static readonly long[] Value={ 0L,0L,1L,10L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285995Inst : IEnumerable<long>
{
public static readonly long[] Value=A285995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285995.Bytes);
public long this[int i]=>Value[i];

public static A285995Inst Instance=new A285995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285996
{
public static readonly long[] Value={ 1L,2L,1L,11L,2L,1L,156L,14L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285996Inst : IEnumerable<long>
{
public static readonly long[] Value=A285996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285996.Bytes);
public long this[int i]=>Value[i];

public static A285996Inst Instance=new A285996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285997
{
public static readonly long[] Value={ 1L,1L,1L,1L,81L,331776L,10754830178L,257119084477153L,5819786432246732561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285997Inst : IEnumerable<long>
{
public static readonly long[] Value=A285997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285997.Bytes);
public long this[int i]=>Value[i];

public static A285997Inst Instance=new A285997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285998
{
public static readonly long[] Value={ 1L,4L,7L,16L,22L,40L,50L,80L,95L,140L,161L,224L,252L,336L,372L,480L,525L,660L,715L,880L,946L,1144L,1222L,1456L,1547L,1820L,1925L,2240L,2360L,2720L,2856L,3264L,3417L,3876L,4047L,4560L,4750L,5320L,5530L,6160L,6391L,7084L,7337L,8096L,8372L,9200L,9500L,10400L,10725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285998Inst : IEnumerable<long>
{
public static readonly long[] Value=A285998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285998.Bytes);
public long this[int i]=>Value[i];

public static A285998Inst Instance=new A285998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285999
{
public static readonly long[] Value={ 0L,0L,2L,2L,4L,4L,6L,6L,8L,10L,12L,12L,14L,16L,18L,18L,20L,22L,24L,24L,28L,30L,32L,32L,34L,36L,40L,40L,42L,44L,46L,46L,50L,52L,54L,56L,58L,60L,64L,64L,66L,68L,70L,72L,76L,78L,80L,80L,82L,84L,88L,90L,92L,94L,98L,98L,102L,104L,106L,108L,110L,112L,116L,116L,120L,122L,124L,126L,130L,132L,134L,134L,136L,138L,144L,146L,148L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285999Inst : IEnumerable<long>
{
public static readonly long[] Value=A285999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285999.Bytes);
public long this[int i]=>Value[i];

public static A285999Inst Instance=new A285999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286002
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,8L,12L,12L,15L,16L,20L,18L,24L,24L,26L,27L,32L,30L,36L,34L,38L,40L,44L,40L,47L,48L,50L,50L,56L,52L,60L,58L,62L,64L,66L,63L,72L,72L,74L,72L,80L,76L,84L,82L,84L,88L,92L,86L,95L,94L,98L,98L,104L,100L,106L,104L,110L,112L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286002Inst : IEnumerable<long>
{
public static readonly long[] Value=A286002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286002.Bytes);
public long this[int i]=>Value[i];

public static A286002Inst Instance=new A286002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286003
{
public static readonly long[] Value={ 2L,5L,6L,9L,13L,14L,17L,21L,27L,28L,30L,36L,40L,44L,45L,48L,55L,58L,59L,61L,62L,68L,72L,75L,76L,80L,84L,90L,93L,99L,103L,106L,107L,108L,111L,114L,115L,121L,122L,123L,125L,126L,129L,136L,139L,140L,144L,147L,148L,151L,155L,156L,157L,163L,167L,170L,171L,175L,178L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286003Inst : IEnumerable<long>
{
public static readonly long[] Value=A286003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286003.Bytes);
public long this[int i]=>Value[i];

public static A286003Inst Instance=new A286003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286004
{
public static readonly long[] Value={ 12L,20L,24L,33L,37L,43L,51L,52L,65L,69L,77L,83L,87L,96L,100L,118L,124L,132L,133L,160L,164L,172L,199L,226L,230L,234L,238L,245L,249L,253L,267L,275L,298L,306L,307L,315L,320L,338L,346L,347L,351L,355L,361L,362L,363L,376L,380L,384L,388L,402L,411L,415L,433L,437L,442L,443L,451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286004Inst : IEnumerable<long>
{
public static readonly long[] Value=A286004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286004.Bytes);
public long this[int i]=>Value[i];

public static A286004Inst Instance=new A286004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286005
{
public static readonly long[] Value={ 29L,60L,91L,92L,141L,154L,185L,204L,217L,241L,254L,279L,285L,342L,403L,441L,473L,497L,510L,528L,541L,572L,603L,622L,666L,697L,715L,753L,771L,779L,780L,811L,841L,873L,922L,936L,954L,973L,1022L,1047L,1053L,1066L,1091L,1122L,1234L,1291L,1347L,1404L,1422L,1453L,1496L,1561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286005Inst : IEnumerable<long>
{
public static readonly long[] Value=A286005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286005.Bytes);
public long this[int i]=>Value[i];

public static A286005Inst Instance=new A286005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286006
{
public static readonly long[] Value={ 186L,447L,635L,765L,1035L,1092L,1378L,1435L,1540L,2015L,2553L,2740L,2808L,3027L,4154L,4465L,4497L,4603L,4766L,4816L,4897L,5084L,5166L,5265L,5403L,5590L,5666L,5747L,5828L,6245L,6515L,6572L,6759L,6809L,7029L,7559L,7690L,7991L,8459L,8810L,8859L,9202L,9234L,9340L,9821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286006Inst : IEnumerable<long>
{
public static readonly long[] Value=A286006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286006.Bytes);
public long this[int i]=>Value[i];

public static A286006Inst Instance=new A286006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286023
{
public static readonly ulong[] Value={ 1L,11L,100L,1111L,11000L,111111L,1100000L,11111111L,111100000L,1111111111L,11110000000L,111111111111L,1111000000000L,11111111111111L,111100000000000L,1111111111111111L,11111001000000000L,111111111111111111L,1111111100000000000L,11111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286023Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286023.Bytes);
public ulong this[int i]=>Value[i];

public static A286023Inst Instance=new A286023Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286024
{
public static readonly long[] Value={ 1L,3L,1L,15L,3L,63L,3L,255L,15L,1023L,15L,4095L,15L,16383L,15L,65535L,159L,262143L,255L,1048575L,255L,4194303L,255L,16777215L,255L,67108863L,255L,268435455L,255L,1073741823L,255L,4294967295L,36863L,17179869183L,65535L,68719476735L,65535L,274877906943L,65535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286024Inst : IEnumerable<long>
{
public static readonly long[] Value=A286024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286024.Bytes);
public long this[int i]=>Value[i];

public static A286024Inst Instance=new A286024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286025
{
public static readonly long[] Value={ 1L,3L,4L,15L,24L,63L,96L,255L,480L,1023L,1920L,4095L,7680L,16383L,30720L,65535L,127488L,262143L,522240L,1048575L,2088960L,4194303L,8355840L,16777215L,33423360L,67108863L,133693440L,268435455L,534773760L,1073741823L,2139095040L,4294967295L,8587968512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286025Inst : IEnumerable<long>
{
public static readonly long[] Value=A286025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286025.Bytes);
public long this[int i]=>Value[i];

public static A286025Inst Instance=new A286025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286026
{
public static readonly BigInteger[] Value={ 1L,10L,0L,1100L,1L,111000L,1L,11110000L,1L,1111100100L,11L,111111001100L,0L,11111110000000L,11100L,1111111100000001L,11000L,111111111001100000L,1L,11111111110010010000UL,0L,BigInteger.Parse("1111111111100000000011"),111110000L,BigInteger.Parse("111111111111000000000111"),1000000L };
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
public class A286026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286026Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286026.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286026.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286026Inst Instance=new A286026Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286027
{
public static readonly BigInteger[] Value={ 1L,1L,0L,11L,10000L,111L,1000000L,1111L,100000000L,10011111L,11000000000L,1100111111L,0L,1111111L,1110000000000L,1000000011111111L,11000000000000L,1100111111111L,1000000000000000000L,1001001111111111L,0L,BigInteger.Parse("1100000000011111111111"),1111100000000000000L };
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
public class A286027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286027Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286027.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286027.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286027Inst Instance=new A286027Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286028
{
public static readonly long[] Value={ 1L,2L,0L,12L,1L,56L,1L,240L,1L,996L,3L,4044L,0L,16256L,28L,65281L,24L,261728L,1L,1047696L,0L,4192259L,496L,16773127L,64L,67102265L,192L,268421177L,448L,1073709088L,4161L,4294901792L,1104L,17179768832L,1091L,68719247368L,67L,274877382688L,101443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286028Inst : IEnumerable<long>
{
public static readonly long[] Value=A286028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286028.Bytes);
public long this[int i]=>Value[i];

public static A286028Inst Instance=new A286028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286029
{
public static readonly long[] Value={ 1L,1L,0L,3L,16L,7L,64L,15L,256L,159L,1536L,831L,0L,127L,7168L,33023L,12288L,6655L,262144L,37887L,0L,3147775L,507904L,14684159L,262144L,41000959L,1572864L,163659775L,7340032L,16809983L,1090781184L,67174399L,339738624L,7995391L,26055016448L,4296278015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286029Inst : IEnumerable<long>
{
public static readonly long[] Value=A286029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286029.Bytes);
public long this[int i]=>Value[i];

public static A286029Inst Instance=new A286029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286030
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,2L,1L,8L,6L,12L,1L,10L,20L,20L,30L,1L,12L,30L,30L,20L,120L,30L,1L,14L,42L,42L,70L,210L,140L,210L,1L,16L,56L,56L,112L,336L,70L,560L,420L,560L,1L,18L,72L,72L,168L,504L,252L,1008L,756L,630L,2520L,560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286030Inst : IEnumerable<long>
{
public static readonly long[] Value=A286030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286030.Bytes);
public long this[int i]=>Value[i];

public static A286030Inst Instance=new A286030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286031
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,9L,11L,12L,13L,14L,16L,17L,20L,21L,23L,24L,26L,27L,30L,31L,33L,34L,36L,37L,40L,41L,43L,44L,45L,46L,48L,49L,52L,53L,55L,56L,58L,59L,62L,63L,66L,67L,70L,71L,73L,74L,76L,77L,80L,81L,83L,84L,85L,86L,88L,89L,92L,93L,95L,96L,98L,99L,102L,103L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286031Inst : IEnumerable<long>
{
public static readonly long[] Value=A286031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286031.Bytes);
public long this[int i]=>Value[i];

public static A286031Inst Instance=new A286031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286032
{
public static readonly long[] Value={ 1L,1L,-1L,-4L,0L,20L,20L,-120L,-280L,800L,3600L,-5200L,-48400L,19200L,696800L,408800L,-10740000L,-17689600L,175630400L,511732800L,-3000875200L,-13747264000L,52271990400L,368459062400L,-886068707200L,-10097545267200L,12940241120000L,285573963334400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286032Inst : IEnumerable<long>
{
public static readonly long[] Value=A286032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286032.Bytes);
public long this[int i]=>Value[i];

public static A286032Inst Instance=new A286032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286033
{
public static readonly long[] Value={ 0L,3L,5L,21L,69L,253L,923L,3433L,12869L,48621L,184755L,705433L,2704155L,10400601L,40116599L,155117521L,601080389L,2333606221L,9075135299L,35345263801L,137846528819L,538257874441L,2104098963719L,8233430727601L,32247603683099L,126410606437753L,495918532948103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286033Inst : IEnumerable<long>
{
public static readonly long[] Value=A286033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286033.Bytes);
public long this[int i]=>Value[i];

public static A286033Inst Instance=new A286033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286034
{
public static readonly long[] Value={ 1L,8L,3L,49L,8L,34L,3L,239L,124L,97L,8L,165L,30L,34L,34L,1051L,47L,1237L,17L,508L,21L,97L,8L,727L,565L,331L,74L,165L,122L,733L,3L,4403L,34L,502L,34L,7911L,192L,196L,72L,2302L,233L,526L,68L,508L,1237L,97L,8L,3051L,1774L,5368L,97L,1782L,380L,727L,97L,727L,51L,1231L,122L,3220L,498L,34L,288L,18019L,331L,733L,155L,2713L,34L,733L,47L,35317L,705L,1897L,873L,1047L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286034Inst : IEnumerable<long>
{
public static readonly long[] Value=A286034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286034.Bytes);
public long this[int i]=>Value[i];

public static A286034Inst Instance=new A286034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286035
{
public static readonly BigInteger[] Value={ 0L,18315L,210375L,17232775560L,197941645440L,16214284059063255L,186242898311223435L,BigInteger.Parse("15255987442587265956120"),BigInteger.Parse("175235570535035566127880"),BigInteger.Parse("14354328072739259079522561195"),BigInteger.Parse("164878797845087651200279041495"),BigInteger.Parse("13505958574968967401962031517525680"),BigInteger.Parse("155134131134672045268505114018663320") };
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
public class A286035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286035Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286035.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286035.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286035Inst Instance=new A286035Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286036
{
public static readonly BigInteger[] Value={ 0L,2478630L,96492000L,2262209634604920L,88065491686677120L,BigInteger.Parse("2064651070850763887750940"),BigInteger.Parse("80374740223699340246041830"),BigInteger.Parse("1884345278651963087653858708518360"),BigInteger.Parse("73355621393690297028946986338029560"),BigInteger.Parse("1719785575058362227821108881720941727234290"),BigInteger.Parse("66949481579385248741161156467886515267346140") };
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
public class A286036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286036Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286036.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286036.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286036Inst Instance=new A286036Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286037
{
public static readonly BigInteger[] Value={ 0L,37271025L,4917515625L,BigInteger.Parse("32996505944592590400"),BigInteger.Parse("4353432777721630310400"),BigInteger.Parse("29211445283110309395256454577225"),BigInteger.Parse("3854046352373857001854365165911025"),BigInteger.Parse("25860572538708927496411840821477504196161600"),BigInteger.Parse("3411945020082158343071838489442339152945921600"),BigInteger.Parse("22894081602203374655543296113789919615194083223613314225") };
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
public class A286037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286037Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286037.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286037.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286037Inst Instance=new A286037Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286038
{
public static readonly BigInteger[] Value={ 0L,12L,396L,21672L,1918920L,250696980L,45304472052L,10816917169296L,3296928965854032L,1248938916843586140L,BigInteger.Parse("575559130836761023260"),BigInteger.Parse("317049200473798671358392"),BigInteger.Parse("205722831410326997504441496"),BigInteger.Parse("155295648728262284680608862692"),BigInteger.Parse("134934407215203512994225979686660") };
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
public class A286038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286038Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286038.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286038.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286038Inst Instance=new A286038Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286055
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286055Inst : IEnumerable<long>
{
public static readonly long[] Value=A286055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286055.Bytes);
public long this[int i]=>Value[i];

public static A286055Inst Instance=new A286055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286056
{
public static readonly long[] Value={ 1L,5L,8L,16L,17L,21L,24L,28L,29L,37L,40L,48L,49L,57L,60L,64L,65L,69L,72L,80L,81L,85L,88L,92L,93L,101L,104L,108L,109L,113L,116L,124L,125L,133L,136L,144L,145L,149L,152L,156L,157L,165L,168L,176L,177L,185L,188L,192L,193L,197L,200L,208L,209L,217L,220L,228L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286056Inst : IEnumerable<long>
{
public static readonly long[] Value=A286056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286056.Bytes);
public long this[int i]=>Value[i];

public static A286056Inst Instance=new A286056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286057
{
public static readonly long[] Value={ 2L,3L,4L,6L,7L,9L,10L,11L,12L,13L,14L,15L,18L,19L,20L,22L,23L,25L,26L,27L,30L,31L,32L,33L,34L,35L,36L,38L,39L,41L,42L,43L,44L,45L,46L,47L,50L,51L,52L,53L,54L,55L,56L,58L,59L,61L,62L,63L,66L,67L,68L,70L,71L,73L,74L,75L,76L,77L,78L,79L,82L,83L,84L,86L,87L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286057Inst : IEnumerable<long>
{
public static readonly long[] Value=A286057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286057.Bytes);
public long this[int i]=>Value[i];

public static A286057Inst Instance=new A286057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286058
{
public static readonly long[] Value={ 3L,5L,9L,13L,16L,20L,23L,27L,29L,33L,36L,40L,42L,46L,49L,53L,57L,60L,64L,66L,70L,73L,77L,81L,84L,88L,90L,94L,97L,101L,104L,108L,110L,114L,117L,121L,125L,128L,132L,134L,138L,141L,145L,148L,152L,154L,158L,161L,165L,169L,172L,176L,178L,182L,185L,189L,191L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286058Inst : IEnumerable<long>
{
public static readonly long[] Value=A286058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286058.Bytes);
public long this[int i]=>Value[i];

public static A286058Inst Instance=new A286058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286059
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286059Inst : IEnumerable<long>
{
public static readonly long[] Value=A286059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286059.Bytes);
public long this[int i]=>Value[i];

public static A286059Inst Instance=new A286059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286060
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,11L,14L,15L,17L,20L,23L,24L,27L,30L,31L,33L,36L,37L,40L,43L,44L,47L,50L,51L,53L,56L,59L,60L,63L,66L,67L,69L,72L,73L,76L,79L,80L,82L,85L,88L,89L,92L,95L,96L,98L,101L,104L,105L,108L,111L,112L,114L,117L,118L,121L,124L,125L,128L,131L,132L,134L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286060Inst : IEnumerable<long>
{
public static readonly long[] Value=A286060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286060.Bytes);
public long this[int i]=>Value[i];

public static A286060Inst Instance=new A286060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286061
{
public static readonly long[] Value={ 3L,5L,6L,9L,10L,12L,13L,16L,18L,19L,21L,22L,25L,26L,28L,29L,32L,34L,35L,38L,39L,41L,42L,45L,46L,48L,49L,52L,54L,55L,57L,58L,61L,62L,64L,65L,68L,70L,71L,74L,75L,77L,78L,81L,83L,84L,86L,87L,90L,91L,93L,94L,97L,99L,100L,102L,103L,106L,107L,109L,110L,113L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286061Inst : IEnumerable<long>
{
public static readonly long[] Value=A286061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286061.Bytes);
public long this[int i]=>Value[i];

public static A286061Inst Instance=new A286061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286062
{
public static readonly long[] Value={ 2L,3L,6L,13L,29L,65L,146L,328L,737L,1656L,3721L,8361L,18787L,42214L,94854L,213135L,478910L,1076101L,2417977L,5433145L,12208166L,27431500L,61638021L,138499376L,311205273L,699271901L,1571249699L,3530566026L,7933109850L,17825536027L,40053615878L,89999657933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286062Inst : IEnumerable<long>
{
public static readonly long[] Value=A286062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286062.Bytes);
public long this[int i]=>Value[i];

public static A286062Inst Instance=new A286062Inst();

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