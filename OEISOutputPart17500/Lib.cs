using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A071671
{
public static readonly long[] Value={ 10L,1010L,1100L,101010L,110010L,110100L,101100L,11001010L,11010010L,111000L,10101010L,11001100L,1101001010L,11100010L,11010100L,10110010L,1100101010L,1101001100L,1110001010L,1101010010L,11100100L,10110100L,1100110010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071671Inst : IEnumerable<long>
{
public static readonly long[] Value=A071671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071671.Bytes);
public long this[int i]=>Value[i];

public static A071671Inst Instance=new A071671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071670
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,40L,35L,36L,37L,38L,39L,43L,41L,42L,47L,44L,45L,46L,48L,34L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071670Inst : IEnumerable<long>
{
public static readonly long[] Value=A071670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071670.Bytes);
public long this[int i]=>Value[i];

public static A071670Inst Instance=new A071670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071669
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,48L,35L,36L,37L,38L,39L,34L,41L,42L,40L,44L,45L,46L,43L,47L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071669Inst : IEnumerable<long>
{
public static readonly long[] Value=A071669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071669.Bytes);
public long this[int i]=>Value[i];

public static A071669Inst Instance=new A071669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071668
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,5L,6L,4L,22L,21L,18L,20L,17L,13L,12L,15L,19L,16L,10L,11L,14L,9L,64L,63L,59L,62L,58L,50L,49L,55L,61L,57L,46L,34L,54L,45L,36L,35L,32L,40L,31L,41L,43L,52L,60L,56L,47L,48L,53L,44L,27L,26L,29L,33L,30L,38L,39L,51L,42L,24L,25L,28L,37L,23L,196L,195L,190L,194L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071668Inst : IEnumerable<long>
{
public static readonly long[] Value=A071668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071668.Bytes);
public long this[int i]=>Value[i];

public static A071668Inst Instance=new A071668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071635
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,1L,1L,2L,0L,2L,2L,1L,2L,3L,0L,3L,2L,2L,3L,2L,1L,3L,2L,1L,4L,3L,2L,5L,3L,2L,5L,3L,2L,3L,4L,2L,5L,4L,1L,5L,3L,3L,4L,4L,1L,6L,4L,3L,6L,5L,2L,9L,3L,3L,4L,4L,2L,6L,4L,2L,8L,4L,4L,5L,4L,3L,8L,5L,2L,7L,7L,4L,9L,6L,3L,7L,6L,3L,6L,6L,2L,12L,5L,4L,8L,6L,5L,10L,4L,2L,10L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071635Inst : IEnumerable<long>
{
public static readonly long[] Value=A071635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071635.Bytes);
public long this[int i]=>Value[i];

public static A071635Inst Instance=new A071635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071634
{
public static readonly long[] Value={ 23L,112L,81L,64L,75L,48L,36L,28L,43L,68L,14L,80L,35L,50L,0L,43L,28L,28L,46L,52L,44L,32L,38L,49L,48L,37L,10L,34L,24L,47L,34L,65L,19L,28L,59L,20L,32L,82L,15L,30L,61L,32L,48L,62L,10L,32L,2L,26L,18L,16L,65L,77L,0L,46L,8L,0L,43L,18L,56L,60L,0L,38L,40L,13L,36L,26L,44L,46L,41L,12L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071634Inst : IEnumerable<long>
{
public static readonly long[] Value=A071634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071634.Bytes);
public long this[int i]=>Value[i];

public static A071634Inst Instance=new A071634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071633
{
public static readonly long[] Value={ 19L,82L,59L,46L,56L,34L,26L,20L,31L,52L,10L,56L,24L,34L,0L,30L,20L,20L,32L,37L,32L,24L,30L,37L,34L,24L,2L,26L,16L,35L,22L,46L,15L,20L,38L,14L,20L,58L,11L,22L,42L,24L,33L,46L,3L,20L,0L,18L,10L,12L,44L,56L,0L,29L,8L,0L,31L,14L,38L,44L,0L,30L,28L,9L,24L,18L,30L,34L,29L,8L,0L,50L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071633Inst : IEnumerable<long>
{
public static readonly long[] Value=A071633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071633.Bytes);
public long this[int i]=>Value[i];

public static A071633Inst Instance=new A071633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071632
{
public static readonly long[] Value={ 13L,43L,31L,24L,32L,16L,13L,8L,14L,27L,4L,24L,11L,16L,0L,18L,7L,8L,16L,19L,16L,12L,18L,19L,18L,12L,0L,14L,6L,18L,10L,23L,9L,10L,17L,8L,4L,28L,5L,11L,20L,12L,18L,22L,0L,10L,0L,6L,0L,6L,21L,32L,0L,11L,4L,0L,16L,8L,20L,19L,0L,18L,14L,3L,10L,5L,12L,16L,14L,2L,0L,26L,0L,16L,0L,0L,0L,14L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071632Inst : IEnumerable<long>
{
public static readonly long[] Value=A071632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071632.Bytes);
public long this[int i]=>Value[i];

public static A071632Inst Instance=new A071632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071631
{
public static readonly long[] Value={ 7L,11L,10L,6L,8L,4L,5L,0L,5L,8L,0L,6L,5L,4L,0L,5L,0L,2L,4L,3L,4L,4L,5L,5L,6L,3L,0L,3L,0L,5L,4L,8L,3L,4L,3L,2L,0L,6L,0L,5L,8L,2L,5L,6L,0L,4L,0L,0L,0L,0L,5L,8L,0L,5L,0L,0L,3L,2L,4L,5L,0L,5L,4L,0L,2L,0L,2L,2L,3L,0L,0L,5L,0L,4L,0L,0L,0L,2L,3L,4L,5L,2L,8L,4L,0L,5L,3L,0L,0L,0L,0L,3L,6L,8L,4L,0L,8L,0L,2L,0L,2L,3L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071631Inst : IEnumerable<long>
{
public static readonly long[] Value=A071631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071631.Bytes);
public long this[int i]=>Value[i];

public static A071631Inst Instance=new A071631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071630
{
public static readonly long[] Value={ 6L,10L,9L,3L,6L,3L,2L,0L,4L,6L,0L,3L,4L,3L,0L,4L,0L,0L,3L,2L,3L,3L,4L,4L,3L,2L,0L,2L,0L,4L,3L,6L,2L,3L,2L,0L,0L,3L,0L,4L,6L,0L,4L,3L,0L,3L,0L,0L,0L,0L,4L,6L,0L,4L,0L,0L,2L,0L,3L,4L,0L,4L,3L,0L,0L,0L,0L,0L,2L,0L,0L,4L,0L,3L,0L,0L,0L,0L,2L,3L,4L,0L,6L,3L,0L,4L,2L,0L,0L,0L,0L,2L,3L,6L,3L,0L,6L,0L,0L,0L,0L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071630Inst : IEnumerable<long>
{
public static readonly long[] Value=A071630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071630.Bytes);
public long this[int i]=>Value[i];

public static A071630Inst Instance=new A071630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071629
{
public static readonly long[] Value={ 5L,6L,5L,2L,3L,2L,0L,0L,3L,3L,0L,2L,3L,2L,0L,3L,0L,0L,2L,0L,2L,2L,3L,3L,2L,0L,0L,0L,0L,3L,2L,3L,0L,2L,0L,0L,0L,2L,0L,3L,3L,0L,3L,2L,0L,2L,0L,0L,0L,0L,3L,3L,0L,3L,0L,0L,0L,0L,2L,3L,0L,3L,2L,0L,0L,0L,0L,0L,0L,0L,0L,3L,0L,2L,0L,0L,0L,0L,0L,2L,3L,0L,3L,2L,0L,3L,0L,0L,0L,0L,0L,0L,2L,3L,2L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071629Inst : IEnumerable<long>
{
public static readonly long[] Value=A071629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071629.Bytes);
public long this[int i]=>Value[i];

public static A071629Inst Instance=new A071629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071628
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,3L,6L,1L,1L,2L,1L,1L,8L,1L,1L,2L,1L,1L,2L,2L,583L,2L,1L,1L,1L,2L,5L,4L,1L,1L,2L,1L,3L,2L,1L,3L,2L,1L,1L,4L,2L,1L,4L,2L,1L,2L,1L,3L,16L,1L,3L,6L,1L,1L,2L,2L,1L,4L,2L,1L,2L,3L,1L,4L,1L,3L,2L,1L,3L,2L,1L,3L,4L,1L,1L,8L,2L,3L,2L,1L,7L,2L,1L,1L,2L,2L,1L,4L,1L,3L,4L,1L,1L,2L,2L,15L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071628Inst : IEnumerable<long>
{
public static readonly long[] Value=A071628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071628.Bytes);
public long this[int i]=>Value[i];

public static A071628Inst Instance=new A071628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071627
{
public static readonly BigInteger[] Value={ 1L,1L,2L,15L,630L,242550L,1040539500L,66400727518125L,BigInteger.Parse("71562941411142431250"),BigInteger.Parse("1596518198505361496634018750"),BigInteger.Parse("938998452767448490315979899506187500"),BigInteger.Parse("15693832493195927010608457268015759163973281250") };
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
public class A071627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071627Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071627.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071627.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071627Inst Instance=new A071627Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071626
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,8L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071626Inst : IEnumerable<long>
{
public static readonly long[] Value=A071626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071626.Bytes);
public long this[int i]=>Value[i];

public static A071626Inst Instance=new A071626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071625
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,2L,1L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071625Inst : IEnumerable<long>
{
public static readonly long[] Value=A071625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071625.Bytes);
public long this[int i]=>Value[i];

public static A071625Inst Instance=new A071625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071624
{
public static readonly long[] Value={ 0L,378L,1524L,2385L,7749L,13788L,21555L,34599L,46398L,50715L,59925L,69903L,75180L,86310L,104445L,117495L,177375L,230349L,239850L,269505L,290235L,311733L,380835L,393024L,470190L,497448L,525474L,583830L,598899L,743160L,760149L,812268L,902973L,998478L,1018155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071624Inst : IEnumerable<long>
{
public static readonly long[] Value=A071624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071624.Bytes);
public long this[int i]=>Value[i];

public static A071624Inst Instance=new A071624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071623
{
public static readonly long[] Value={ 1L,4L,5L,6L,7L,8L,15L,18L,21L,22L,35L,64L,65L,130L,131L,160L,161L,170L,175L,186L,187L,190L,391L,392L,393L,508L,511L,514L,515L,516L,519L,530L,535L,536L,539L,540L,543L,552L,553L,566L,577L,584L,587L,588L,593L,594L,627L,630L,631L,636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071623Inst : IEnumerable<long>
{
public static readonly long[] Value=A071623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071623.Bytes);
public long this[int i]=>Value[i];

public static A071623Inst Instance=new A071623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071622
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,2L,3L,4L,5L,6L,7L,8L,7L,6L,5L,6L,7L,8L,7L,8L,7L,6L,7L,6L,5L,6L,5L,6L,7L,8L,7L,6L,7L,8L,7L,6L,5L,6L,7L,8L,9L,10L,11L,12L,11L,10L,9L,10L,11L,10L,9L,8L,7L,8L,7L,8L,7L,8L,9L,10L,9L,8L,9L,8L,9L,8L,7L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,14L,15L,14L,13L,12L,13L,12L,13L,12L,11L,10L,9L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071622Inst : IEnumerable<long>
{
public static readonly long[] Value=A071622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071622.Bytes);
public long this[int i]=>Value[i];

public static A071622Inst Instance=new A071622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071621
{
public static readonly long[] Value={ 13L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071621Inst : IEnumerable<long>
{
public static readonly long[] Value=A071621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071621.Bytes);
public long this[int i]=>Value[i];

public static A071621Inst Instance=new A071621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071620
{
public static readonly long[] Value={ 10L,14L,24L,235L,2804L,4347L,37735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071620Inst : IEnumerable<long>
{
public static readonly long[] Value=A071620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071620.Bytes);
public long this[int i]=>Value[i];

public static A071620Inst Instance=new A071620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071507
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,1L,1L,6L,6L,3L,2L,2L,1L,0L,6L,6L,8L,4L,4L,5L,10L,1L,7L,8L,3L,3L,2L,4L,1L,6L,6L,8L,8L,4L,10L,10L,12L,1L,8L,14L,5L,4L,4L,7L,1L,6L,9L,3L,3L,1L,12L,6L,7L,7L,4L,4L,5L,11L,10L,1L,1L,8L,14L,14L,4L,10L,7L,6L,8L,1L,14L,3L,11L,12L,13L,7L,14L,14L,3L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071507Inst : IEnumerable<long>
{
public static readonly long[] Value=A071507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071507.Bytes);
public long this[int i]=>Value[i];

public static A071507Inst Instance=new A071507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071506
{
public static readonly long[] Value={ 1L,1L,0L,2L,2L,3L,4L,4L,0L,1L,1L,3L,2L,2L,3L,4L,4L,5L,6L,6L,3L,2L,2L,3L,1L,1L,8L,7L,6L,3L,10L,10L,0L,1L,1L,8L,7L,6L,4L,4L,5L,8L,1L,1L,0L,2L,10L,11L,4L,5L,8L,8L,6L,3L,2L,10L,11L,4L,5L,5L,6L,6L,11L,1L,10L,3L,1L,8L,8L,7L,6L,11L,10L,16L,12L,1L,9L,8L,7L,6L,4L,4L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071506Inst : IEnumerable<long>
{
public static readonly long[] Value=A071506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071506.Bytes);
public long this[int i]=>Value[i];

public static A071506Inst Instance=new A071506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071505
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,1L,1L,5L,6L,3L,3L,2L,2L,1L,1L,0L,8L,7L,7L,2L,5L,5L,4L,0L,1L,1L,2L,2L,8L,8L,4L,5L,5L,6L,6L,7L,7L,2L,8L,1L,1L,11L,10L,7L,6L,6L,5L,5L,4L,4L,11L,11L,2L,2L,8L,8L,4L,5L,5L,2L,6L,7L,7L,8L,5L,1L,1L,2L,10L,7L,6L,8L,1L,1L,4L,14L,11L,11L,6L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071505Inst : IEnumerable<long>
{
public static readonly long[] Value=A071505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071505.Bytes);
public long this[int i]=>Value[i];

public static A071505Inst Instance=new A071505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071504
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,2L,4L,3L,5L,2L,4L,3L,5L,1L,4L,3L,2L,6L,4L,5L,8L,6L,7L,10L,8L,2L,7L,3L,6L,2L,7L,4L,6L,5L,3L,9L,2L,5L,3L,4L,2L,6L,14L,4L,5L,1L,8L,9L,15L,1L,13L,9L,12L,5L,13L,4L,16L,2L,9L,3L,8L,2L,4L,13L,5L,2L,3L,7L,5L,1L,3L,8L,16L,6L,13L,14L,16L,15L,7L,14L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071504Inst : IEnumerable<long>
{
public static readonly long[] Value=A071504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071504.Bytes);
public long this[int i]=>Value[i];

public static A071504Inst Instance=new A071504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071503
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,4L,3L,2L,1L,3L,4L,2L,7L,4L,8L,1L,4L,8L,1L,2L,4L,8L,1L,4L,3L,8L,1L,4L,8L,2L,1L,4L,8L,1L,4L,8L,1L,2L,4L,8L,1L,4L,7L,8L,1L,4L,8L,2L,1L,4L,8L,1L,7L,4L,1L,2L,4L,8L,1L,4L,7L,8L,1L,4L,8L,2L,1L,4L,8L,1L,7L,4L,1L,2L,4L,8L,1L,4L,7L,8L,1L,4L,8L,2L,1L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071503Inst : IEnumerable<long>
{
public static readonly long[] Value=A071503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071503.Bytes);
public long this[int i]=>Value[i];

public static A071503Inst Instance=new A071503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071502
{
public static readonly long[] Value={ 1L,2L,0L,1L,2L,4L,3L,1L,2L,3L,5L,2L,4L,3L,5L,1L,3L,5L,2L,4L,7L,2L,4L,7L,8L,6L,4L,7L,6L,2L,7L,8L,6L,9L,3L,6L,9L,7L,4L,2L,7L,4L,2L,5L,3L,4L,2L,9L,4L,2L,1L,3L,12L,1L,9L,4L,2L,1L,9L,8L,13L,9L,10L,8L,11L,10L,15L,11L,2L,4L,15L,2L,4L,3L,16L,2L,4L,11L,2L,17L,3L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071502Inst : IEnumerable<long>
{
public static readonly long[] Value=A071502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071502.Bytes);
public long this[int i]=>Value[i];

public static A071502Inst Instance=new A071502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071501
{
public static readonly long[] Value={ 1L,2L,3L,1L,0L,3L,2L,4L,0L,2L,3L,4L,0L,1L,2L,4L,1L,6L,3L,2L,0L,1L,2L,3L,4L,1L,3L,4L,2L,1L,0L,7L,3L,4L,1L,6L,2L,1L,8L,7L,2L,4L,1L,6L,8L,4L,0L,1L,3L,4L,1L,6L,7L,4L,5L,1L,6L,8L,4L,9L,6L,4L,10L,5L,0L,7L,5L,4L,10L,6L,8L,4L,11L,7L,13L,2L,5L,6L,12L,5L,4L,7L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071501Inst : IEnumerable<long>
{
public static readonly long[] Value=A071501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071501.Bytes);
public long this[int i]=>Value[i];

public static A071501Inst Instance=new A071501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071500
{
public static readonly long[] Value={ 1L,0L,2L,3L,4L,5L,1L,6L,2L,3L,4L,5L,7L,6L,8L,9L,1L,2L,7L,6L,8L,5L,4L,3L,2L,9L,1L,5L,11L,3L,2L,8L,4L,10L,11L,3L,6L,5L,9L,10L,2L,3L,12L,4L,5L,6L,10L,9L,12L,4L,5L,7L,16L,13L,1L,4L,3L,14L,6L,12L,11L,4L,10L,8L,9L,13L,16L,14L,6L,8L,9L,19L,10L,16L,17L,4L,9L,11L,10L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071500Inst : IEnumerable<long>
{
public static readonly long[] Value=A071500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071500.Bytes);
public long this[int i]=>Value[i];

public static A071500Inst Instance=new A071500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071499
{
public static readonly long[] Value={ 1L,0L,2L,1L,3L,2L,1L,3L,4L,5L,3L,4L,2L,3L,1L,2L,5L,1L,2L,5L,7L,4L,5L,7L,4L,8L,2L,9L,6L,2L,9L,6L,8L,7L,6L,4L,7L,2L,1L,10L,5L,8L,3L,5L,2L,4L,5L,2L,4L,8L,2L,12L,3L,11L,4L,14L,8L,2L,12L,5L,15L,11L,16L,15L,17L,2L,18L,17L,14L,1L,4L,2L,12L,4L,19L,12L,3L,13L,2L,11L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071499Inst : IEnumerable<long>
{
public static readonly long[] Value=A071499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071499.Bytes);
public long this[int i]=>Value[i];

public static A071499Inst Instance=new A071499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071498
{
public static readonly long[] Value={ 1L,0L,2L,3L,4L,1L,0L,2L,3L,4L,1L,5L,2L,3L,7L,1L,4L,2L,3L,7L,0L,1L,2L,3L,7L,5L,0L,1L,3L,2L,5L,4L,8L,6L,2L,5L,4L,8L,7L,2L,6L,1L,4L,8L,2L,6L,1L,4L,8L,2L,6L,1L,0L,8L,2L,3L,7L,4L,1L,8L,2L,10L,0L,1L,8L,2L,7L,5L,1L,8L,3L,6L,10L,1L,5L,2L,6L,10L,1L,5L,3L,2L,10L,1L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071498Inst : IEnumerable<long>
{
public static readonly long[] Value=A071498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071498.Bytes);
public long this[int i]=>Value[i];

public static A071498Inst Instance=new A071498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071497
{
public static readonly long[] Value={ 1L,2L,0L,2L,1L,2L,4L,5L,1L,6L,7L,5L,1L,2L,8L,2L,6L,2L,8L,1L,5L,11L,7L,9L,5L,8L,1L,2L,1L,2L,12L,2L,5L,8L,5L,6L,1L,8L,1L,2L,12L,2L,14L,2L,8L,11L,1L,6L,8L,5L,1L,2L,12L,2L,1L,2L,6L,8L,5L,8L,11L,16L,1L,16L,2L,12L,1L,8L,2L,6L,5L,8L,11L,16L,5L,15L,1L,2L,1L,8L,16L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071497Inst : IEnumerable<long>
{
public static readonly long[] Value=A071497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071497.Bytes);
public long this[int i]=>Value[i];

public static A071497Inst Instance=new A071497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071496
{
public static readonly long[] Value={ 1L,2L,0L,1L,2L,4L,3L,1L,2L,3L,5L,2L,4L,3L,5L,1L,3L,5L,2L,4L,7L,2L,4L,7L,8L,6L,4L,7L,6L,2L,7L,8L,6L,8L,3L,6L,12L,7L,4L,2L,7L,4L,2L,5L,3L,4L,2L,8L,4L,2L,1L,3L,12L,1L,8L,4L,2L,1L,11L,9L,1L,16L,17L,16L,1L,11L,13L,9L,2L,4L,16L,2L,8L,3L,1L,2L,4L,16L,2L,15L,3L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071496Inst : IEnumerable<long>
{
public static readonly long[] Value=A071496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071496.Bytes);
public long this[int i]=>Value[i];

public static A071496Inst Instance=new A071496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071495
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,2L,4L,5L,1L,6L,7L,2L,3L,2L,1L,5L,8L,6L,7L,6L,10L,5L,4L,8L,9L,2L,3L,10L,11L,4L,5L,8L,3L,2L,11L,10L,1L,5L,8L,9L,3L,6L,10L,5L,4L,1L,3L,6L,2L,10L,11L,4L,9L,8L,6L,14L,15L,10L,13L,12L,8L,7L,6L,7L,5L,4L,12L,3L,12L,7L,14L,15L,4L,5L,4L,9L,6L,11L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071495Inst : IEnumerable<long>
{
public static readonly long[] Value=A071495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071495.Bytes);
public long this[int i]=>Value[i];

public static A071495Inst Instance=new A071495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071494
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,2L,4L,5L,1L,4L,6L,2L,3L,2L,1L,4L,5L,8L,7L,6L,7L,10L,1L,4L,1L,2L,3L,2L,6L,4L,1L,4L,8L,2L,3L,2L,1L,10L,1L,8L,9L,6L,7L,10L,1L,11L,1L,8L,2L,3L,6L,4L,5L,1L,12L,8L,3L,14L,10L,1L,4L,5L,8L,6L,7L,10L,11L,1L,4L,8L,2L,3L,6L,11L,10L,5L,4L,8L,3L,7L,10L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071494Inst : IEnumerable<long>
{
public static readonly long[] Value=A071494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071494.Bytes);
public long this[int i]=>Value[i];

public static A071494Inst Instance=new A071494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071493
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,2L,0L,1L,0L,3L,2L,3L,4L,5L,0L,2L,3L,2L,5L,4L,0L,1L,0L,2L,3L,2L,1L,4L,5L,6L,7L,2L,0L,5L,4L,7L,6L,2L,3L,2L,0L,1L,7L,3L,6L,8L,4L,1L,0L,2L,6L,8L,5L,4L,1L,10L,3L,2L,0L,1L,0L,10L,11L,6L,7L,4L,0L,4L,10L,2L,6L,8L,0L,1L,0L,2L,3L,2L,8L,4L,5L,10L,6L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071493Inst : IEnumerable<long>
{
public static readonly long[] Value=A071493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071493.Bytes);
public long this[int i]=>Value[i];

public static A071493Inst Instance=new A071493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071492
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,2L,4L,0L,3L,1L,2L,0L,3L,4L,1L,2L,3L,6L,1L,2L,3L,0L,5L,1L,3L,0L,6L,4L,1L,3L,5L,2L,4L,6L,3L,0L,1L,4L,3L,0L,6L,1L,7L,0L,5L,1L,4L,6L,3L,1L,4L,0L,6L,8L,7L,2L,3L,6L,8L,2L,9L,3L,8L,2L,4L,0L,6L,8L,1L,3L,5L,6L,2L,4L,5L,0L,8L,1L,9L,0L,8L,1L,9L,10L,5L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071492Inst : IEnumerable<long>
{
public static readonly long[] Value=A071492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071492.Bytes);
public long this[int i]=>Value[i];

public static A071492Inst Instance=new A071492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071427
{
public static readonly long[] Value={ 1L,1L,2L,2L,0L,3L,1L,1L,2L,2L,3L,3L,4L,4L,0L,5L,3L,3L,4L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,4L,4L,5L,5L,2L,6L,4L,7L,5L,8L,1L,2L,2L,0L,3L,1L,1L,2L,2L,3L,3L,4L,8L,1L,5L,5L,3L,3L,10L,2L,1L,9L,3L,0L,2L,2L,5L,9L,4L,4L,8L,11L,2L,6L,4L,4L,8L,8L,6L,6L,2L,0L,3L,11L,6L,2L,2L,3L,3L,11L,5L,1L,9L,9L,7L,3L,10L,1L,1L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071427Inst : IEnumerable<long>
{
public static readonly long[] Value=A071427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071427.Bytes);
public long this[int i]=>Value[i];

public static A071427Inst Instance=new A071427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071426
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,0L,3L,3L,1L,1L,1L,0L,4L,3L,3L,3L,2L,2L,2L,4L,4L,0L,5L,5L,2L,2L,2L,3L,3L,0L,5L,0L,1L,1L,1L,3L,3L,3L,5L,6L,4L,4L,1L,0L,5L,5L,6L,6L,2L,7L,7L,7L,8L,0L,1L,9L,2L,7L,2L,3L,3L,3L,9L,0L,5L,4L,4L,8L,6L,6L,2L,7L,1L,1L,1L,0L,5L,5L,9L,3L,1L,8L,2L,8L,5L,0L,1L,1L,12L,2L,2L,7L,3L,3L,9L,4L,4L,0L,11L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071426Inst : IEnumerable<long>
{
public static readonly long[] Value=A071426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071426.Bytes);
public long this[int i]=>Value[i];

public static A071426Inst Instance=new A071426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071425
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,14L,20L,26L,32L,43L,50L,62L,74L,86L,104L,122L,144L,167L,184L,206L,231L,259L,290L,319L,349L,384L,422L,464L,504L,552L,594L,636L,682L,733L,789L,840L,898L,957L,1021L,1084L,1150L,1214L,1285L,1359L,1429L,1506L,1587L,1676L,1763L,1852L,1942L,2030L,2124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071425Inst : IEnumerable<long>
{
public static readonly long[] Value=A071425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071425.Bytes);
public long this[int i]=>Value[i];

public static A071425Inst Instance=new A071425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071424
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,11L,15L,20L,26L,33L,41L,50L,60L,71L,84L,98L,113L,129L,147L,166L,186L,208L,231L,255L,281L,308L,337L,367L,398L,431L,465L,501L,538L,577L,618L,660L,704L,749L,796L,844L,894L,946L,999L,1054L,1111L,1169L,1229L,1291L,1354L,1419L,1486L,1554L,1624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071424Inst : IEnumerable<long>
{
public static readonly long[] Value=A071424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071424.Bytes);
public long this[int i]=>Value[i];

public static A071424Inst Instance=new A071424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071423
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,12L,15L,18L,22L,26L,30L,34L,39L,44L,49L,55L,61L,67L,74L,81L,88L,95L,103L,111L,119L,128L,137L,146L,156L,166L,176L,186L,197L,208L,219L,231L,243L,255L,268L,281L,294L,307L,321L,335L,349L,364L,379L,394L,410L,426L,442L,458L,475L,492L,509L,527L,545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071423Inst : IEnumerable<long>
{
public static readonly long[] Value=A071423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071423.Bytes);
public long this[int i]=>Value[i];

public static A071423Inst Instance=new A071423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071422
{
public static readonly long[] Value={ 1L,4L,8L,15L,21L,24L,32L,38L,42L,51L,54L,64L,69L,75L,81L,85L,94L,106L,108L,114L,119L,128L,134L,140L,144L,150L,154L,165L,168L,177L,182L,191L,203L,212L,224L,234L,245L,251L,262L,271L,277L,292L,300L,312L,327L,336L,348L,355L,367L,379L,388L,405L,414L,417L,426L,429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071422Inst : IEnumerable<long>
{
public static readonly long[] Value=A071422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071422.Bytes);
public long this[int i]=>Value[i];

public static A071422Inst Instance=new A071422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071421
{
public static readonly long[] Value={ 1L,5L,14L,27L,38L,65L,90L,127L,172L,173L,214L,268L,326L,378L,477L,565L,663L,771L,898L,929L,1046L,1194L,1340L,1493L,1644L,1798L,1987L,2150L,2317L,2380L,2564L,2769L,2976L,3190L,3450L,3720L,3991L,4256L,4562L,4674L,4982L,5297L,5610L,5935L,6241L,6593L,6967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071421Inst : IEnumerable<long>
{
public static readonly long[] Value=A071421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071421.Bytes);
public long this[int i]=>Value[i];

public static A071421Inst Instance=new A071421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071420
{
public static readonly long[] Value={ 7L,8L,5L,5L,3L,4L,4L,6L,9L,7L,8L,8L,7L,8L,5L,5L,3L,4L,4L,6L,9L,7L,8L,8L,7L,8L,5L,5L,3L,4L,4L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071420Inst : IEnumerable<long>
{
public static readonly long[] Value=A071420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071420.Bytes);
public long this[int i]=>Value[i];

public static A071420Inst Instance=new A071420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071419
{
public static readonly long[] Value={ 1L,1L,5L,4L,4L,14L,10L,26L,17L,13L,35L,23L,53L,33L,71L,43L,89L,53L,107L,63L,125L,73L,143L,83L,161L,93L,179L,103L,197L,113L,215L,123L,233L,133L,251L,143L,269L,153L,287L,163L,305L,173L,323L,183L,341L,193L,359L,203L,377L,213L,395L,223L,413L,233L,431L,243L,449L,253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071419Inst : IEnumerable<long>
{
public static readonly long[] Value=A071419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071419.Bytes);
public long this[int i]=>Value[i];

public static A071419Inst Instance=new A071419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071418
{
public static readonly long[] Value={ 0L,2L,2L,8L,6L,17L,35L,21L,44L,80L,45L,28L,20L,50L,32L,71L,131L,74L,46L,98L,59L,40L,31L,27L,77L,51L,116L,215L,365L,197L,341L,186L,109L,71L,158L,290L,163L,100L,69L,54L,47L,44L,43L,43L,131L,88L,67L,57L,158L,311L,542L,890L,471L,262L,158L,320L,188L,368L,213L,136L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071418Inst : IEnumerable<long>
{
public static readonly long[] Value=A071418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071418.Bytes);
public long this[int i]=>Value[i];

public static A071418Inst Instance=new A071418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071417
{
public static readonly long[] Value={ 0L,1L,0L,3L,1L,0L,6L,3L,1L,0L,9L,5L,3L,1L,0L,12L,7L,4L,3L,1L,0L,15L,9L,6L,4L,3L,1L,0L,19L,12L,8L,6L,4L,3L,1L,0L,22L,14L,10L,8L,6L,4L,3L,1L,0L,26L,17L,12L,9L,7L,5L,4L,3L,1L,0L,30L,20L,15L,11L,9L,7L,5L,4L,3L,1L,0L,34L,23L,17L,14L,11L,9L,7L,5L,4L,3L,1L,0L,38L,26L,20L,16L,13L,10L,8L,7L,5L,4L,3L,1L,0L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071417Inst : IEnumerable<long>
{
public static readonly long[] Value=A071417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071417.Bytes);
public long this[int i]=>Value[i];

public static A071417Inst Instance=new A071417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071416
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,6L,1L,2L,1L,2L,1L,4L,1L,2L,15L,2L,1L,6L,1L,20L,3L,2L,1L,12L,1L,2L,1L,28L,1L,2L,1L,2L,3L,2L,7L,4L,1L,2L,1L,20L,1L,42L,1L,4L,45L,2L,1L,12L,1L,2L,3L,4L,1L,6L,1L,8L,3L,2L,1L,12L,1L,2L,3L,2L,5L,66L,1L,4L,3L,10L,1L,36L,1L,2L,15L,4L,77L,6L,1L,20L,1L,2L,1L,28L,5L,2L,3L,88L,1L,10L,91L,4L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071416Inst : IEnumerable<long>
{
public static readonly long[] Value=A071416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071416.Bytes);
public long this[int i]=>Value[i];

public static A071416Inst Instance=new A071416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071415
{
public static readonly long[] Value={ 1L,4L,7L,10L,17L,22L,32L,38L,51L,66L,75L,93L,113L,124L,147L,172L,199L,214L,244L,276L,310L,328L,365L,404L,445L,488L,511L,557L,605L,655L,707L,734L,789L,846L,905L,966L,1029L,1062L,1128L,1196L,1266L,1338L,1412L,1450L,1527L,1606L,1687L,1770L,1855L,1942L,1987L,2077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071415Inst : IEnumerable<long>
{
public static readonly long[] Value=A071415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071415.Bytes);
public long this[int i]=>Value[i];

public static A071415Inst Instance=new A071415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071414
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,1L,3L,1L,2L,4L,2L,2L,6L,2L,2L,7L,3L,4L,5L,3L,2L,6L,3L,3L,5L,4L,3L,8L,2L,5L,9L,5L,5L,6L,4L,3L,7L,5L,4L,10L,3L,5L,11L,6L,5L,9L,5L,7L,10L,5L,5L,5L,5L,6L,11L,3L,6L,15L,3L,6L,12L,4L,6L,11L,8L,4L,11L,9L,4L,10L,6L,6L,16L,6L,7L,16L,7L,8L,11L,6L,6L,15L,9L,8L,12L,8L,8L,13L,9L,5L,14L,7L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071414Inst : IEnumerable<long>
{
public static readonly long[] Value=A071414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071414.Bytes);
public long this[int i]=>Value[i];

public static A071414Inst Instance=new A071414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071413
{
public static readonly long[] Value={ 0L,-1L,1L,-4L,5L,-4L,2L,-11L,13L,-4L,6L,-15L,14L,-11L,3L,-26L,29L,-4L,14L,-23L,26L,-15L,7L,-38L,38L,-11L,15L,-38L,31L,-26L,4L,-57L,61L,-4L,30L,-39L,50L,-23L,15L,-62L,66L,-15L,27L,-58L,51L,-38L,8L,-85L,86L,-11L,39L,-62L,67L,-38L,16L,-93L,87L,-26L,32L,-85L,64L,-57L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071413Inst : IEnumerable<long>
{
public static readonly long[] Value=A071413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071413.Bytes);
public long this[int i]=>Value[i];

public static A071413Inst Instance=new A071413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071412
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,0L,2L,0L,1L,1L,0L,2L,2L,2L,0L,1L,1L,2L,1L,1L,0L,2L,2L,1L,2L,1L,2L,2L,0L,1L,1L,2L,1L,0L,2L,0L,1L,2L,1L,1L,0L,2L,2L,1L,2L,0L,1L,0L,2L,0L,1L,0L,2L,1L,2L,2L,0L,1L,1L,2L,1L,0L,2L,0L,1L,1L,0L,2L,2L,2L,0L,1L,1L,0L,2L,0L,1L,2L,1L,1L,0L,2L,2L,1L,2L,0L,1L,0L,2L,2L,0L,1L,1L,1L,0L,2L,2L,2L,0L,1L,1L,1L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071412Inst : IEnumerable<long>
{
public static readonly long[] Value=A071412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071412.Bytes);
public long this[int i]=>Value[i];

public static A071412Inst Instance=new A071412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071331
{
public static readonly long[] Value={ 1L,149L,331L,373L,509L,701L,757L,809L,877L,907L,959L,997L,1019L,1087L,1199L,1207L,1211L,1243L,1259L,1271L,1477L,1529L,1541L,1549L,1589L,1597L,1619L,1657L,1719L,1759L,1777L,1783L,1807L,1829L,1859L,1867L,1927L,1969L,1973L,2171L,2231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071331Inst : IEnumerable<long>
{
public static readonly long[] Value=A071331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071331.Bytes);
public long this[int i]=>Value[i];

public static A071331Inst Instance=new A071331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071330
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,2L,3L,3L,4L,3L,4L,3L,4L,3L,4L,3L,5L,3L,5L,4L,4L,2L,5L,3L,5L,4L,5L,3L,6L,3L,7L,5L,7L,4L,7L,2L,6L,4L,6L,3L,6L,3L,6L,5L,6L,2L,8L,3L,8L,4L,6L,2L,9L,3L,7L,4L,6L,2L,8L,3L,7L,4L,7L,3L,9L,2L,8L,5L,7L,2L,10L,3L,8L,6L,7L,3L,9L,2L,9L,4L,7L,4L,11L,3L,9L,4L,7L,3L,12L,4L,8L,3L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071330Inst : IEnumerable<long>
{
public static readonly long[] Value=A071330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071330.Bytes);
public long this[int i]=>Value[i];

public static A071330Inst Instance=new A071330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071329
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,19L,23L,23L,31L,37L,41L,47L,53L,53L,61L,67L,73L,79L,83L,89L,89L,101L,103L,113L,113L,127L,127L,131L,137L,139L,157L,163L,167L,173L,181L,181L,193L,199L,199L,211L,211L,223L,233L,233L,241L,241L,257L,271L,271L,277L,283L,283L,293L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071329Inst : IEnumerable<long>
{
public static readonly long[] Value=A071329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071329.Bytes);
public long this[int i]=>Value[i];

public static A071329Inst Instance=new A071329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071328
{
public static readonly long[] Value={ 3L,5L,11L,11L,17L,19L,29L,29L,37L,41L,43L,53L,59L,59L,67L,71L,79L,79L,89L,97L,97L,101L,107L,113L,127L,127L,131L,137L,139L,149L,163L,163L,173L,173L,191L,191L,197L,211L,211L,223L,223L,223L,239L,239L,251L,251L,263L,271L,277L,281L,293L,293L,307L,307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071328Inst : IEnumerable<long>
{
public static readonly long[] Value=A071328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071328.Bytes);
public long this[int i]=>Value[i];

public static A071328Inst Instance=new A071328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071327
{
public static readonly long[] Value={ 0L,0L,0L,4L,0L,0L,0L,4L,9L,0L,0L,4L,0L,0L,0L,4L,0L,9L,0L,4L,0L,0L,0L,4L,25L,0L,9L,4L,0L,0L,0L,4L,0L,0L,0L,13L,0L,0L,0L,4L,0L,0L,0L,4L,9L,0L,0L,4L,49L,25L,0L,4L,0L,9L,0L,4L,0L,0L,0L,4L,0L,0L,9L,4L,0L,0L,0L,4L,0L,0L,0L,13L,0L,0L,25L,4L,0L,0L,0L,4L,9L,0L,0L,4L,0L,0L,0L,4L,0L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071327Inst : IEnumerable<long>
{
public static readonly long[] Value=A071327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071327.Bytes);
public long this[int i]=>Value[i];

public static A071327Inst Instance=new A071327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071326
{
public static readonly long[] Value={ 0L,0L,0L,4L,0L,0L,0L,4L,9L,0L,0L,4L,0L,0L,0L,20L,0L,9L,0L,4L,0L,0L,0L,4L,25L,0L,9L,4L,0L,0L,0L,20L,0L,0L,0L,49L,0L,0L,0L,4L,0L,0L,0L,4L,9L,0L,0L,20L,49L,25L,0L,4L,0L,9L,0L,4L,0L,0L,0L,4L,0L,0L,9L,84L,0L,0L,0L,4L,0L,0L,0L,49L,0L,0L,25L,4L,0L,0L,0L,20L,90L,0L,0L,4L,0L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071326Inst : IEnumerable<long>
{
public static readonly long[] Value=A071326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071326.Bytes);
public long this[int i]=>Value[i];

public static A071326Inst Instance=new A071326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071325
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,2L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,2L,0L,0L,0L,3L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,2L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,3L,0L,0L,0L,1L,0L,0L,0L,3L,0L,0L,1L,1L,0L,0L,0L,2L,2L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071325Inst : IEnumerable<long>
{
public static readonly long[] Value=A071325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071325.Bytes);
public long this[int i]=>Value[i];

public static A071325Inst Instance=new A071325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071324
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,4L,6L,5L,7L,6L,10L,8L,12L,8L,12L,11L,16L,13L,18L,12L,16L,12L,22L,16L,21L,14L,20L,18L,28L,22L,30L,21L,24L,18L,32L,25L,36L,20L,28L,24L,40L,32L,42L,30L,36L,24L,46L,32L,43L,31L,36L,36L,52L,40L,48L,38L,40L,30L,58L,40L,60L,32L,46L,43L,56L,48L,66L,48L,48L,42L,70L,49L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071324Inst : IEnumerable<long>
{
public static readonly long[] Value=A071324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071324.Bytes);
public long this[int i]=>Value[i];

public static A071324Inst Instance=new A071324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071323
{
public static readonly long[] Value={ 1L,-1L,-2L,3L,-4L,-4L,-6L,-5L,7L,-6L,-10L,-8L,-12L,-8L,-12L,11L,-16L,-13L,-18L,-12L,-16L,-12L,-22L,-16L,21L,-14L,-20L,-18L,-28L,-22L,-30L,-21L,-24L,-18L,-32L,25L,-36L,-20L,-28L,-24L,-40L,-32L,-42L,-30L,-36L,-24L,-46L,-32L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071323Inst : IEnumerable<long>
{
public static readonly long[] Value=A071323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071323.Bytes);
public long this[int i]=>Value[i];

public static A071323Inst Instance=new A071323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071322
{
public static readonly long[] Value={ 0L,2L,3L,0L,5L,1L,7L,2L,0L,3L,11L,3L,13L,5L,2L,0L,17L,2L,19L,5L,4L,9L,23L,1L,0L,11L,3L,7L,29L,4L,31L,2L,8L,15L,2L,0L,37L,17L,10L,3L,41L,6L,43L,11L,5L,21L,47L,3L,0L,2L,14L,13L,53L,1L,6L,5L,16L,27L,59L,2L,61L,29L,7L,0L,8L,10L,67L,17L,20L,4L,71L,2L,73L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071322Inst : IEnumerable<long>
{
public static readonly long[] Value=A071322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071322.Bytes);
public long this[int i]=>Value[i];

public static A071322Inst Instance=new A071322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071321
{
public static readonly long[] Value={ 0L,2L,3L,0L,5L,-1L,7L,2L,0L,-3L,11L,3L,13L,-5L,-2L,0L,17L,2L,19L,5L,-4L,-9L,23L,-1L,0L,-11L,3L,7L,29L,4L,31L,2L,-8L,-15L,-2L,0L,37L,-17L,-10L,-3L,41L,6L,43L,11L,5L,-21L,47L,3L,0L,2L,-14L,13L,53L,-1L,-6L,-5L,-16L,-27L,59L,-2L,61L,-29L,7L,0L,-8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071321Inst : IEnumerable<long>
{
public static readonly long[] Value=A071321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071321.Bytes);
public long this[int i]=>Value[i];

public static A071321Inst Instance=new A071321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071320
{
public static readonly long[] Value={ 844L,1681L,8523L,8954L,10050L,10924L,11322L,17404L,19940L,22020L,23762L,24450L,25772L,27547L,30923L,30924L,33172L,34347L,38724L,39050L,39347L,40050L,47673L,47724L,47825L,49147L,54585L,55449L,57474L,58473L,58849L,58867L,59924L,62865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071320Inst : IEnumerable<long>
{
public static readonly long[] Value=A071320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071320.Bytes);
public long this[int i]=>Value[i];

public static A071320Inst Instance=new A071320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071319
{
public static readonly long[] Value={ 98L,475L,548L,603L,724L,844L,845L,1274L,1420L,1681L,1682L,1924L,2275L,2523L,2890L,3283L,3474L,3548L,3626L,3716L,4148L,4203L,4418L,4475L,4850L,4923L,4948L,5202L,5274L,5490L,5524L,5634L,5948L,6650L,6811L,6956L,7299L,7324L,7442L,7514L,7675L,8107L,8348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071319Inst : IEnumerable<long>
{
public static readonly long[] Value=A071319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071319.Bytes);
public long this[int i]=>Value[i];

public static A071319Inst Instance=new A071319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071318
{
public static readonly long[] Value={ 44L,49L,75L,98L,99L,116L,147L,171L,244L,260L,275L,315L,332L,363L,387L,475L,476L,507L,524L,531L,548L,549L,603L,604L,636L,692L,724L,725L,747L,764L,774L,819L,844L,845L,846L,867L,908L,924L,931L,963L,980L,1035L,1075L,1083L,1179L,1196L,1251L,1274L,1275L,1324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071318Inst : IEnumerable<long>
{
public static readonly long[] Value=A071318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071318.Bytes);
public long this[int i]=>Value[i];

public static A071318Inst Instance=new A071318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071317
{
public static readonly long[] Value={ 0L,1L,5L,14L,21L,28L,37L,50L,60L,69L,70L,74L,83L,99L,115L,124L,137L,156L,165L,175L,179L,188L,204L,220L,238L,251L,270L,288L,307L,320L,329L,345L,352L,370L,383L,393L,411L,430L,443L,452L,459L,475L,493L,515L,534L,543L,553L,566L,575L,582L,589L,598L,611L,630L,648L,658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071317Inst : IEnumerable<long>
{
public static readonly long[] Value=A071317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071317.Bytes);
public long this[int i]=>Value[i];

public static A071317Inst Instance=new A071317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071316
{
public static readonly long[] Value={ 2L,4L,5L,16L,10L,10L,17L,13L,20L,74L,113L,32L,25L,76L,55L,31L,44L,86L,74L,46L,42L,100L,402L,115L,63L,71L,104L,143L,489L,346L,96L,78L,68L,87L,167L,196L,116L,95L,76L,123L,109L,108L,141L,176L,141L,133L,260L,1038L,4748L,5731L,1162L,285L,189L,248L,478L,399L,163L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071316Inst : IEnumerable<long>
{
public static readonly long[] Value=A071316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071316.Bytes);
public long this[int i]=>Value[i];

public static A071316Inst Instance=new A071316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071219
{
public static readonly long[] Value={ 2L,3L,439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071219Inst : IEnumerable<long>
{
public static readonly long[] Value=A071219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071219.Bytes);
public long this[int i]=>Value[i];

public static A071219Inst Instance=new A071219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071218
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,10L,13L,14L,15L,16L,17L,18L,20L,21L,22L,25L,26L,27L,28L,30L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,52L,53L,55L,56L,57L,59L,60L,61L,62L,64L,65L,66L,68L,69L,70L,72L,73L,74L,78L,79L,80L,81L,82L,83L,85L,88L,89L,90L,91L,92L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071218Inst : IEnumerable<long>
{
public static readonly long[] Value=A071218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071218.Bytes);
public long this[int i]=>Value[i];

public static A071218Inst Instance=new A071218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071217
{
public static readonly long[] Value={ 1L,9L,11L,12L,19L,23L,24L,29L,31L,32L,51L,54L,58L,63L,67L,71L,75L,76L,77L,84L,86L,87L,93L,95L,97L,103L,108L,110L,124L,128L,136L,151L,158L,159L,164L,169L,188L,191L,192L,200L,202L,205L,208L,210L,211L,216L,227L,232L,241L,243L,245L,246L,247L,252L,265L,273L,278L,282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071217Inst : IEnumerable<long>
{
public static readonly long[] Value=A071217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071217.Bytes);
public long this[int i]=>Value[i];

public static A071217Inst Instance=new A071217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071216
{
public static readonly long[] Value={ 5L,2L,3L,3L,3L,5L,3L,7L,13L,5L,17L,13L,7L,5L,5L,7L,5L,2L,23L,3L,19L,3L,43L,31L,11L,17L,7L,3L,37L,5L,43L,67L,23L,3L,5L,11L,5L,11L,17L,11L,5L,31L,3L,13L,11L,41L,31L,5L,19L,11L,59L,5L,41L,127L,13L,19L,5L,137L,31L,47L,3L,5L,103L,13L,7L,3L,167L,19L,29L,13L,89L,11L,37L,47L,127L,193L,131L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071216Inst : IEnumerable<long>
{
public static readonly long[] Value=A071216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071216.Bytes);
public long this[int i]=>Value[i];

public static A071216Inst Instance=new A071216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071215
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,2L,3L,2L,3L,2L,3L,3L,3L,2L,2L,3L,1L,3L,2L,2L,2L,2L,3L,3L,3L,4L,2L,3L,3L,3L,2L,3L,2L,3L,3L,2L,4L,3L,2L,3L,3L,2L,4L,3L,3L,3L,3L,3L,4L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,4L,2L,2L,3L,3L,3L,2L,3L,3L,2L,3L,2L,3L,4L,3L,3L,4L,3L,2L,2L,3L,2L,3L,3L,4L,4L,3L,4L,3L,4L,3L,3L,3L,3L,3L,2L,3L,3L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071215Inst : IEnumerable<long>
{
public static readonly long[] Value=A071215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071215.Bytes);
public long this[int i]=>Value[i];

public static A071215Inst Instance=new A071215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071214
{
public static readonly BigInteger[] Value={ 1L,5L,46L,614L,10716L,230712L,5903472L,174942000L,5890370400L,222069752640L,9265980286080L,423888544154880L,21094789126924800L,1134492559101619200L,BigInteger.Parse("65567415318776985600"),BigInteger.Parse("4052502049455940147200"),BigInteger.Parse("266725354163752808755200") };
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
public class A071214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071214Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071214.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071214.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071214Inst Instance=new A071214Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071213
{
public static readonly BigInteger[] Value={ 1L,4L,34L,436L,7428L,157368L,3980688L,116949600L,3911421600L,146673662400L,6093249563520L,277729608280320L,13778539159795200L,739059210587980800L,BigInteger.Parse("42615627311477606400"),BigInteger.Parse("2628646012982829772800"),BigInteger.Parse("172704619437756321484800") };
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
public class A071213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071213Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071213.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071213.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071213Inst Instance=new A071213Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071212
{
public static readonly BigInteger[] Value={ 1L,4L,28L,286L,3848L,64198L,1277400L,29507784L,775826832L,22869156168L,746817076080L,26758697374176L,1043610018593088L,44007103062886416L,1994973101346054144L,BigInteger.Parse("96747604119630501120"),BigInteger.Parse("4997654990315699224320") };
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
public class A071212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071212Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071212.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071212.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071212Inst Instance=new A071212Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071211
{
public static readonly long[] Value={ 1L,3L,1L,16L,8L,3L,125L,75L,40L,16L,1296L,864L,540L,300L,125L,16807L,12005L,8232L,5292L,3024L,1296L,262144L,196608L,143360L,100352L,65856L,38416L,16807L,4782969L,3720087L,2834352L,2099520L,1492992L,995328L,589824L,262144L,100000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071211Inst : IEnumerable<long>
{
public static readonly long[] Value=A071211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071211.Bytes);
public long this[int i]=>Value[i];

public static A071211Inst Instance=new A071211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071210
{
public static readonly long[] Value={ 1L,3L,1L,18L,8L,1L,160L,80L,15L,1L,1875L,1000L,225L,24L,1L,27216L,15120L,3780L,504L,35L,1L,470596L,268912L,72030L,10976L,980L,48L,1L,9437184L,5505024L,1548288L,258048L,26880L,1728L,63L,1L,215233605L,127545840L,37200870L,6613488L,765450L,58320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071210Inst : IEnumerable<long>
{
public static readonly long[] Value=A071210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071210.Bytes);
public long this[int i]=>Value[i];

public static A071210Inst Instance=new A071210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071209
{
public static readonly long[] Value={ 0L,1L,1L,0L,3L,8L,3L,0L,16L,81L,32L,18L,0L,125L,1024L,405L,240L,160L,0L,1296L,15625L,6144L,3645L,2560L,1875L,0L,16807L,279936L,109375L,64512L,45360L,35000L,27216L,0L,262144L,5764801L,2239488L,1312500L,917504L,708750L,580608L,470596L,0L,4782969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071209Inst : IEnumerable<long>
{
public static readonly long[] Value=A071209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071209.Bytes);
public long this[int i]=>Value[i];

public static A071209Inst Instance=new A071209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071208
{
public static readonly long[] Value={ 1L,2L,2L,6L,15L,6L,24L,104L,104L,24L,120L,770L,1345L,770L,120L,720L,6264L,16344L,16344L,6264L,720L,5040L,56196L,200452L,300167L,200452L,56196L,5040L,40320L,554112L,2552192L,5241984L,5241984L,2552192L,554112L,40320L,362880L,5973264L,34138908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071208Inst : IEnumerable<long>
{
public static readonly long[] Value=A071208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071208.Bytes);
public long this[int i]=>Value[i];

public static A071208Inst Instance=new A071208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071207
{
public static readonly long[] Value={ 1L,1L,1L,4L,4L,1L,27L,27L,9L,1L,256L,256L,96L,16L,1L,3125L,3125L,1250L,250L,25L,1L,46656L,46656L,19440L,4320L,540L,36L,1L,823543L,823543L,352947L,84035L,12005L,1029L,49L,1L,16777216L,16777216L,7340032L,1835008L,286720L,28672L,1792L,64L,1L,387420489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071207Inst : IEnumerable<long>
{
public static readonly long[] Value=A071207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071207.Bytes);
public long this[int i]=>Value[i];

public static A071207Inst Instance=new A071207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071206
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,11L,6L,3L,10L,11L,6L,5L,10L,11L,7L,6L,10L,11L,9L,6L,10L,11L,10L,11L,10L,11L,10L,11L,10L,11L,100L,101L,51L,26L,21L,110L,111L,56L,23L,60L,61L,41L,31L,25L,21L,16L,44L,27L,35L,36L,29L,21L,30L,31L,26L,27L,21L,25L,23L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071206Inst : IEnumerable<long>
{
public static readonly long[] Value=A071206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071206.Bytes);
public long this[int i]=>Value[i];

public static A071206Inst Instance=new A071206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071205
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,1L,2L,5L,2L,2L,4L,5L,3L,3L,5L,6L,4L,4L,5L,8L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,1L,1L,2L,4L,5L,1L,1L,2L,5L,2L,2L,3L,4L,5L,6L,8L,3L,5L,4L,4L,5L,7L,5L,5L,6L,6L,8L,7L,8L,9L,9L,2L,2L,4L,5L,8L,2L,2L,3L,5L,6L,7L,2L,2L,4L,5L,3L,5L,4L,4L,5L,6L,8L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071205Inst : IEnumerable<long>
{
public static readonly long[] Value=A071205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071205.Bytes);
public long this[int i]=>Value[i];

public static A071205Inst Instance=new A071205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071204
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,15L,20L,22L,24L,25L,30L,33L,35L,36L,40L,44L,45L,48L,50L,55L,60L,66L,70L,77L,80L,88L,90L,99L,100L,101L,102L,104L,105L,110L,111L,112L,115L,120L,122L,123L,124L,125L,126L,128L,132L,135L,140L,144L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071204Inst : IEnumerable<long>
{
public static readonly long[] Value=A071204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071204.Bytes);
public long this[int i]=>Value[i];

public static A071204Inst Instance=new A071204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071155
{
public static readonly long[] Value={ 0L,1L,3L,5L,9L,15L,11L,17L,23L,33L,57L,39L,63L,87L,35L,59L,41L,65L,89L,47L,71L,95L,119L,153L,273L,177L,297L,417L,159L,279L,183L,303L,423L,207L,327L,447L,567L,155L,275L,179L,299L,419L,161L,281L,185L,305L,425L,209L,329L,449L,569L,167L,287L,191L,311L,431L,215L,335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071155Inst : IEnumerable<long>
{
public static readonly long[] Value=A071155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071155.Bytes);
public long this[int i]=>Value[i];

public static A071155Inst Instance=new A071155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071154
{
public static readonly long[] Value={ 1L,11L,20L,111L,120L,201L,210L,300L,1111L,1120L,1201L,1210L,1300L,2011L,2020L,2101L,2110L,2200L,3001L,3010L,3100L,4000L,11111L,11120L,11201L,11210L,11300L,12011L,12020L,12101L,12110L,12200L,13001L,13010L,13100L,14000L,20111L,20120L,20201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071154Inst : IEnumerable<long>
{
public static readonly long[] Value=A071154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071154.Bytes);
public long this[int i]=>Value[i];

public static A071154Inst Instance=new A071154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071153
{
public static readonly long[] Value={ 0L,1L,20L,11L,300L,201L,210L,120L,111L,4000L,3001L,3010L,2020L,2011L,3100L,2101L,2200L,1300L,1201L,2110L,1210L,1120L,1111L,50000L,40001L,40010L,30020L,30011L,40100L,30101L,30200L,20300L,20201L,30110L,20210L,20120L,20111L,41000L,31001L,31010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071153Inst : IEnumerable<long>
{
public static readonly long[] Value=A071153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071153.Bytes);
public long this[int i]=>Value[i];

public static A071153Inst Instance=new A071153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071152
{
public static readonly long[] Value={ 0L,20L,2020L,2200L,202020L,202200L,220020L,220200L,222000L,20202020L,20202200L,20220020L,20220200L,20222000L,22002020L,22002200L,22020020L,22020200L,22022000L,22200020L,22200200L,22202000L,22220000L,2020202020L,2020202200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071152Inst : IEnumerable<long>
{
public static readonly long[] Value=A071152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071152.Bytes);
public long this[int i]=>Value[i];

public static A071152Inst Instance=new A071152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071151
{
public static readonly long[] Value={ 3L,127L,379L,499L,6079L,6599L,8273L,9521L,11597L,13099L,22037L,33623L,34913L,49279L,52517L,54167L,64613L,92951L,101999L,116531L,182107L,222269L,225829L,240379L,255443L,283079L,356387L,360977L,448867L,535669L,541339L,552751L,611953L,624209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071151Inst : IEnumerable<long>
{
public static readonly long[] Value=A071151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071151.Bytes);
public long this[int i]=>Value[i];

public static A071151Inst Instance=new A071151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071150
{
public static readonly long[] Value={ 3L,29L,53L,61L,251L,263L,293L,317L,359L,383L,503L,641L,647L,787L,821L,827L,911L,1097L,1163L,1249L,1583L,1759L,1783L,1861L,1907L,2017L,2287L,2297L,2593L,2819L,2837L,2861L,3041L,3079L,3181L,3461L,3541L,3557L,3643L,3779L,4259L,4409L,4457L,4597L,4691L,4729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071150Inst : IEnumerable<long>
{
public static readonly long[] Value=A071150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071150.Bytes);
public long this[int i]=>Value[i];

public static A071150Inst Instance=new A071150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071149
{
public static readonly long[] Value={ 1L,9L,15L,17L,53L,55L,61L,65L,71L,75L,95L,115L,117L,137L,141L,143L,155L,183L,191L,203L,249L,273L,275L,283L,291L,305L,339L,341L,377L,409L,411L,415L,435L,439L,449L,483L,495L,497L,509L,525L,583L,599L,605L,621L,633L,637L,643L,645L,671L,675L,709L,713L,715L,727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071149Inst : IEnumerable<long>
{
public static readonly long[] Value=A071149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071149.Bytes);
public long this[int i]=>Value[i];

public static A071149Inst Instance=new A071149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071148
{
public static readonly long[] Value={ 3L,8L,15L,26L,39L,56L,75L,98L,127L,158L,195L,236L,279L,326L,379L,438L,499L,566L,637L,710L,789L,872L,961L,1058L,1159L,1262L,1369L,1478L,1591L,1718L,1849L,1986L,2125L,2274L,2425L,2582L,2745L,2912L,3085L,3264L,3445L,3636L,3829L,4026L,4225L,4436L,4659L,4886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071148Inst : IEnumerable<long>
{
public static readonly long[] Value=A071148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071148.Bytes);
public long this[int i]=>Value[i];

public static A071148Inst Instance=new A071148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071147
{
public static readonly BigInteger[] Value={ 1L,2L,0L,30L,3135L,3570L,72930L,1231230L,14804790L,497668710L,14908423530L,278196808890L,12192694624110L,550939666387110L,21275256232500270L,1458502323630662310L,BigInteger.Parse("87988283090327810190"),BigInteger.Parse("3254611619240885033130"),BigInteger.Parse("261462818462495728868790"),BigInteger.Parse("9965666894849284108299810"),BigInteger.Parse("557940830126698960967415390"),BigInteger.Parse("90544636506979071680577724410") };
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
public class A071147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071147.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071147Inst Instance=new A071147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071146
{
public static readonly long[] Value={ 1231230L,2062830L,2181270L,3327870L,3594990L,4224990L,4320030L,4671030L,5162430L,5411406L,5414430L,6767670L,7052430L,7432230L,7870830L,7947030L,8150142L,8273265L,8287230L,8569470L,8804334L,9378390L,10630830L,10705695L,10757838L,10776990L,10900230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071146Inst : IEnumerable<long>
{
public static readonly long[] Value=A071146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071146.Bytes);
public long this[int i]=>Value[i];

public static A071146Inst Instance=new A071146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071145
{
public static readonly long[] Value={ 72930L,106590L,190190L,222870L,335478L,397670L,620310L,836418L,844305L,884442L,1008678L,1195670L,1218945L,1247290L,1704794L,1761110L,1799798L,2086238L,2206022L,2328410L,2485830L,2496585L,2517258L,2863718L,2903538L,3024021L,3157665L,3172785L,3291890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071145Inst : IEnumerable<long>
{
public static readonly long[] Value=A071145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071145.Bytes);
public long this[int i]=>Value[i];

public static A071145Inst Instance=new A071145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071144
{
public static readonly long[] Value={ 3570L,8970L,10626L,15015L,16530L,20706L,24738L,24882L,36890L,38130L,44330L,49938L,51051L,52170L,54834L,55986L,59570L,62985L,68370L,73554L,74613L,77330L,79458L,81770L,87290L,91266L,96162L,96866L,103730L,106314L,116466L,123234L,128570L,129426L,129930L,138890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071144Inst : IEnumerable<long>
{
public static readonly long[] Value=A071144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071144.Bytes);
public long this[int i]=>Value[i];

public static A071144Inst Instance=new A071144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071143
{
public static readonly long[] Value={ 3135L,6279L,8855L,10695L,11571L,16095L,17255L,17391L,20615L,20735L,26691L,28083L,31031L,36519L,41151L,41615L,45695L,46655L,47859L,48495L,50439L,54131L,56823L,57239L,59295L,61295L,66215L,72611L,76055L,76479L,80135L,84135L,88595L,89999L,90951L,93651L,94611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071143Inst : IEnumerable<long>
{
public static readonly long[] Value=A071143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071143.Bytes);
public long this[int i]=>Value[i];

public static A071143Inst Instance=new A071143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071142
{
public static readonly long[] Value={ 30L,70L,286L,646L,1798L,3526L,7198L,10366L,20806L,23326L,38086L,44998L,64798L,73726L,78406L,103966L,115198L,145798L,159046L,194686L,242206L,352798L,373246L,426886L,544966L,649798L,719998L,763846L,824326L,871198L,1312198L,1351366L,1371166L,1472326L,1555846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071142Inst : IEnumerable<long>
{
public static readonly long[] Value=A071142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071142.Bytes);
public long this[int i]=>Value[i];

public static A071142Inst Instance=new A071142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071141
{
public static readonly long[] Value={ 30L,70L,286L,646L,1798L,3135L,3526L,3570L,6279L,7198L,8855L,8970L,10366L,10626L,10695L,11571L,15015L,16095L,16530L,17255L,17391L,20615L,20706L,20735L,20806L,23326L,24738L,24882L,26691L,28083L,31031L,36519L,36890L,38086L,38130L,41151L,41615L,44330L,44998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071141Inst : IEnumerable<long>
{
public static readonly long[] Value=A071141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071141.Bytes);
public long this[int i]=>Value[i];

public static A071141Inst Instance=new A071141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071140
{
public static readonly long[] Value={ 30L,60L,70L,90L,120L,140L,150L,180L,240L,270L,280L,286L,300L,350L,360L,450L,480L,490L,540L,560L,572L,600L,646L,700L,720L,750L,810L,900L,960L,980L,1080L,1120L,1144L,1200L,1292L,1350L,1400L,1440L,1500L,1620L,1750L,1798L,1800L,1920L,1960L,2160L,2240L,2250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071140Inst : IEnumerable<long>
{
public static readonly long[] Value=A071140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071140.Bytes);
public long this[int i]=>Value[i];

public static A071140Inst Instance=new A071140Inst();

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