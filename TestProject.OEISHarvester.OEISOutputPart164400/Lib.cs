using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A194857
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,10L,9L,8L,7L,14L,13L,12L,11L,15L,20L,18L,17L,16L,21L,19L,27L,25L,23L,22L,28L,26L,24L,35L,33L,31L,29L,36L,34L,32L,30L,43L,41L,39L,37L,44L,42L,40L,38L,45L,53L,50L,48L,46L,54L,51L,49L,47L,55L,52L,64L,61L,58L,56L,65L,62L,59L,57L,66L,63L,60L,76L,73L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194857Inst : IEnumerable<long>
{
public static readonly long[] Value=A194857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194857.Bytes);
public long this[int i]=>Value[i];

public static A194857Inst Instance=new A194857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194858
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,10L,9L,8L,7L,14L,13L,12L,11L,15L,19L,18L,17L,21L,16L,20L,25L,24L,28L,23L,27L,22L,26L,32L,36L,31L,35L,30L,34L,29L,33L,40L,44L,39L,43L,38L,42L,37L,41L,45L,49L,53L,48L,52L,47L,51L,55L,46L,50L,54L,59L,63L,58L,62L,66L,57L,61L,65L,56L,60L,64L,70L,74L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194858Inst : IEnumerable<long>
{
public static readonly long[] Value=A194858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194858.Bytes);
public long this[int i]=>Value[i];

public static A194858Inst Instance=new A194858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194859
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,3L,2L,1L,4L,3L,2L,5L,1L,4L,3L,6L,2L,5L,1L,4L,7L,3L,6L,2L,5L,1L,4L,7L,3L,6L,2L,5L,1L,8L,4L,7L,3L,6L,2L,9L,5L,1L,8L,4L,7L,3L,10L,6L,2L,9L,5L,1L,8L,4L,7L,3L,10L,6L,2L,9L,5L,1L,8L,4L,11L,7L,3L,10L,6L,2L,9L,5L,12L,1L,8L,4L,11L,7L,3L,10L,6L,13L,2L,9L,5L,12L,1L,8L,4L,11L,7L,14L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194859Inst : IEnumerable<long>
{
public static readonly long[] Value=A194859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194859.Bytes);
public long this[int i]=>Value[i];

public static A194859Inst Instance=new A194859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194860
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,9L,8L,7L,10L,14L,12L,11L,15L,13L,20L,18L,16L,21L,19L,17L,27L,25L,23L,28L,26L,24L,22L,34L,32L,30L,36L,33L,31L,29L,35L,43L,40L,38L,45L,42L,39L,37L,44L,41L,53L,50L,47L,55L,52L,49L,46L,54L,51L,48L,63L,60L,57L,65L,62L,59L,56L,64L,61L,58L,66L,75L,71L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194860Inst : IEnumerable<long>
{
public static readonly long[] Value=A194860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194860.Bytes);
public long this[int i]=>Value[i];

public static A194860Inst Instance=new A194860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194861
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,9L,8L,7L,10L,13L,12L,15L,11L,14L,18L,21L,17L,20L,16L,19L,28L,24L,27L,23L,26L,22L,25L,35L,31L,34L,30L,33L,29L,36L,32L,43L,39L,42L,38L,45L,41L,37L,44L,40L,52L,48L,55L,51L,47L,54L,50L,46L,53L,49L,62L,58L,65L,61L,57L,64L,60L,56L,63L,59L,66L,73L,69L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194861Inst : IEnumerable<long>
{
public static readonly long[] Value=A194861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194861.Bytes);
public long this[int i]=>Value[i];

public static A194861Inst Instance=new A194861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194862
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,2L,3L,1L,4L,2L,3L,1L,4L,2L,5L,3L,6L,1L,4L,2L,5L,3L,6L,1L,4L,7L,2L,5L,3L,6L,1L,4L,7L,2L,5L,8L,3L,6L,9L,1L,4L,7L,2L,5L,8L,3L,6L,9L,1L,4L,7L,10L,2L,5L,8L,11L,3L,6L,9L,1L,4L,7L,10L,2L,5L,8L,11L,3L,6L,9L,1L,12L,4L,7L,10L,2L,5L,8L,11L,3L,6L,9L,1L,12L,4L,7L,10L,2L,13L,5L,8L,11L,3L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194862Inst : IEnumerable<long>
{
public static readonly long[] Value=A194862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194862.Bytes);
public long this[int i]=>Value[i];

public static A194862Inst Instance=new A194862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194863
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,4L,8L,10L,7L,9L,12L,14L,11L,13L,15L,18L,20L,16L,19L,21L,17L,24L,27L,22L,25L,28L,23L,26L,31L,34L,29L,32L,35L,30L,33L,36L,40L,43L,37L,41L,44L,38L,42L,45L,39L,49L,53L,46L,50L,54L,47L,51L,55L,48L,52L,60L,64L,57L,61L,65L,58L,62L,66L,59L,63L,56L,71L,76L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194863Inst : IEnumerable<long>
{
public static readonly long[] Value=A194863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194863.Bytes);
public long this[int i]=>Value[i];

public static A194863Inst Instance=new A194863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194864
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,10L,7L,8L,9L,14L,11L,15L,12L,13L,19L,16L,20L,17L,21L,18L,25L,22L,26L,23L,27L,24L,28L,32L,36L,29L,33L,30L,34L,31L,35L,40L,44L,37L,41L,45L,38L,42L,39L,43L,49L,53L,46L,50L,54L,47L,51L,55L,48L,52L,66L,59L,63L,56L,60L,64L,57L,61L,65L,58L,62L,77L,70L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194864Inst : IEnumerable<long>
{
public static readonly long[] Value=A194864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194864.Bytes);
public long this[int i]=>Value[i];

public static A194864Inst Instance=new A194864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194865
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,4L,1L,2L,3L,4L,1L,5L,2L,3L,4L,1L,5L,2L,6L,3L,4L,1L,5L,2L,6L,3L,7L,4L,8L,1L,5L,2L,6L,3L,7L,4L,8L,1L,5L,9L,2L,6L,3L,7L,4L,8L,1L,5L,9L,2L,6L,10L,3L,7L,11L,4L,8L,1L,5L,9L,2L,6L,10L,3L,7L,11L,4L,8L,1L,12L,5L,9L,2L,6L,10L,3L,7L,11L,4L,8L,1L,12L,5L,9L,2L,13L,6L,10L,3L,7L,11L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194865Inst : IEnumerable<long>
{
public static readonly long[] Value=A194865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194865.Bytes);
public long this[int i]=>Value[i];

public static A194865Inst Instance=new A194865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194866
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,7L,12L,14L,15L,11L,13L,17L,19L,21L,16L,18L,20L,23L,25L,27L,22L,24L,26L,28L,31L,33L,35L,29L,32L,34L,36L,30L,39L,42L,44L,37L,40L,43L,45L,38L,41L,48L,51L,54L,46L,49L,52L,55L,47L,50L,53L,59L,62L,65L,57L,60L,63L,66L,58L,61L,64L,56L,70L,74L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194866Inst : IEnumerable<long>
{
public static readonly long[] Value=A194866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194866.Bytes);
public long this[int i]=>Value[i];

public static A194866Inst Instance=new A194866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194867
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,5L,9L,7L,10L,8L,13L,11L,14L,12L,15L,18L,21L,16L,19L,17L,20L,24L,27L,22L,25L,28L,23L,26L,31L,34L,29L,32L,35L,30L,33L,36L,39L,42L,45L,37L,40L,43L,38L,41L,44L,48L,51L,54L,46L,49L,52L,55L,47L,50L,53L,66L,58L,61L,64L,56L,59L,62L,65L,57L,60L,63L,77L,69L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194867Inst : IEnumerable<long>
{
public static readonly long[] Value=A194867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194867.Bytes);
public long this[int i]=>Value[i];

public static A194867Inst Instance=new A194867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194868
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,2L,4L,1L,3L,5L,2L,4L,1L,3L,5L,2L,4L,1L,6L,3L,5L,2L,7L,4L,1L,6L,3L,8L,5L,2L,7L,4L,1L,6L,3L,8L,5L,2L,7L,4L,1L,9L,6L,3L,8L,5L,2L,10L,7L,4L,1L,9L,6L,3L,8L,5L,2L,10L,7L,4L,1L,9L,6L,3L,11L,8L,5L,2L,10L,7L,4L,12L,1L,9L,6L,3L,11L,8L,5L,13L,2L,10L,7L,4L,12L,1L,9L,6L,3L,11L,8L,5L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194868Inst : IEnumerable<long>
{
public static readonly long[] Value=A194868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194868.Bytes);
public long this[int i]=>Value[i];

public static A194868Inst Instance=new A194868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194869
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,6L,9L,7L,10L,8L,14L,12L,15L,13L,11L,19L,17L,21L,18L,16L,20L,26L,23L,28L,25L,22L,27L,24L,34L,31L,36L,33L,30L,35L,32L,29L,42L,39L,45L,41L,38L,44L,40L,37L,43L,52L,48L,55L,51L,47L,54L,50L,46L,53L,49L,62L,58L,65L,61L,57L,64L,60L,56L,63L,59L,66L,74L,69L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194869Inst : IEnumerable<long>
{
public static readonly long[] Value=A194869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194869.Bytes);
public long this[int i]=>Value[i];

public static A194869Inst Instance=new A194869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194870
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,6L,8L,10L,7L,9L,15L,12L,14L,11L,13L,20L,17L,19L,16L,21L,18L,26L,23L,28L,25L,22L,27L,24L,36L,33L,30L,35L,32L,29L,34L,31L,44L,41L,38L,43L,40L,37L,45L,42L,39L,53L,50L,47L,55L,52L,49L,46L,54L,51L,48L,63L,60L,57L,65L,62L,59L,56L,64L,61L,58L,66L,74L,71L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194870Inst : IEnumerable<long>
{
public static readonly long[] Value=A194870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194870.Bytes);
public long this[int i]=>Value[i];

public static A194870Inst Instance=new A194870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194871
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,2L,3L,1L,4L,2L,5L,3L,1L,4L,2L,5L,3L,1L,6L,4L,2L,7L,5L,3L,1L,6L,4L,2L,7L,5L,3L,1L,8L,6L,4L,2L,9L,7L,5L,3L,1L,8L,6L,4L,2L,9L,7L,5L,3L,1L,10L,8L,6L,4L,2L,9L,7L,5L,3L,1L,10L,8L,6L,4L,2L,11L,9L,7L,5L,3L,12L,1L,10L,8L,6L,4L,2L,11L,9L,7L,5L,3L,12L,1L,10L,8L,6L,4L,13L,2L,11L,9L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194871Inst : IEnumerable<long>
{
public static readonly long[] Value=A194871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194871.Bytes);
public long this[int i]=>Value[i];

public static A194871Inst Instance=new A194871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194872
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,4L,8L,10L,7L,9L,13L,15L,12L,14L,11L,18L,21L,17L,20L,16L,19L,25L,28L,24L,27L,23L,26L,22L,32L,36L,31L,35L,30L,34L,29L,33L,41L,45L,40L,44L,39L,43L,38L,42L,37L,50L,55L,49L,54L,48L,53L,47L,52L,46L,51L,60L,65L,59L,64L,58L,63L,57L,62L,56L,61L,66L,72L,77L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194872Inst : IEnumerable<long>
{
public static readonly long[] Value=A194872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194872.Bytes);
public long this[int i]=>Value[i];

public static A194872Inst Instance=new A194872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194873
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,5L,9L,7L,10L,8L,15L,13L,11L,14L,12L,20L,18L,16L,21L,19L,17L,28L,26L,24L,22L,27L,25L,23L,35L,33L,31L,29L,36L,34L,32L,30L,45L,43L,41L,39L,37L,44L,42L,40L,38L,54L,52L,50L,48L,46L,55L,53L,51L,49L,47L,64L,62L,60L,58L,56L,65L,63L,61L,59L,57L,66L,75L,73L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194873Inst : IEnumerable<long>
{
public static readonly long[] Value=A194873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194873.Bytes);
public long this[int i]=>Value[i];

public static A194873Inst Instance=new A194873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194874
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,2L,4L,1L,3L,2L,4L,1L,3L,5L,2L,4L,6L,1L,3L,5L,2L,4L,6L,1L,3L,5L,7L,2L,4L,6L,8L,1L,3L,5L,7L,2L,4L,6L,8L,1L,3L,5L,7L,9L,2L,4L,6L,8L,10L,1L,3L,5L,7L,9L,11L,2L,4L,6L,8L,10L,1L,3L,5L,7L,9L,11L,2L,4L,6L,8L,10L,1L,12L,3L,5L,7L,9L,11L,2L,13L,4L,6L,8L,10L,1L,12L,3L,5L,7L,9L,11L,2L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194874Inst : IEnumerable<long>
{
public static readonly long[] Value=A194874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194874.Bytes);
public long this[int i]=>Value[i];

public static A194874Inst Instance=new A194874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194875
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,6L,9L,7L,10L,8L,13L,11L,14L,12L,15L,19L,16L,20L,17L,21L,18L,25L,22L,26L,23L,27L,24L,28L,33L,29L,34L,30L,35L,31L,36L,32L,41L,37L,42L,38L,43L,39L,44L,40L,45L,51L,46L,52L,47L,53L,48L,54L,49L,55L,50L,62L,57L,63L,58L,64L,59L,65L,60L,66L,61L,56L,73L,68L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194875Inst : IEnumerable<long>
{
public static readonly long[] Value=A194875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194875.Bytes);
public long this[int i]=>Value[i];

public static A194875Inst Instance=new A194875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194876
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,6L,8L,10L,7L,9L,12L,14L,11L,13L,15L,17L,19L,21L,16L,18L,20L,23L,25L,27L,22L,24L,26L,28L,30L,32L,34L,36L,29L,31L,33L,35L,38L,40L,42L,44L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,46L,48L,50L,52L,54L,66L,57L,59L,61L,63L,65L,56L,58L,60L,62L,64L,77L,68L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194876Inst : IEnumerable<long>
{
public static readonly long[] Value=A194876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194876.Bytes);
public long this[int i]=>Value[i];

public static A194876Inst Instance=new A194876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194877
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,5L,4L,3L,2L,1L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,7L,1L,6L,5L,4L,3L,8L,2L,7L,1L,6L,5L,4L,9L,3L,8L,2L,7L,1L,6L,5L,10L,4L,9L,3L,8L,2L,7L,1L,6L,11L,5L,10L,4L,9L,3L,8L,2L,7L,1L,6L,11L,5L,10L,4L,9L,3L,8L,2L,7L,1L,12L,6L,11L,5L,10L,4L,9L,3L,8L,2L,13L,7L,1L,12L,6L,11L,5L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194877Inst : IEnumerable<long>
{
public static readonly long[] Value=A194877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194877.Bytes);
public long this[int i]=>Value[i];

public static A194877Inst Instance=new A194877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194878
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,10L,9L,8L,7L,15L,14L,13L,12L,11L,20L,19L,18L,17L,16L,21L,27L,25L,24L,23L,22L,28L,26L,35L,33L,31L,30L,29L,36L,34L,32L,44L,42L,40L,38L,37L,45L,43L,41L,39L,54L,52L,50L,48L,46L,55L,53L,51L,49L,47L,65L,63L,61L,59L,57L,66L,64L,62L,60L,58L,56L,76L,74L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194878Inst : IEnumerable<long>
{
public static readonly long[] Value=A194878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194878.Bytes);
public long this[int i]=>Value[i];

public static A194878Inst Instance=new A194878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194879
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,10L,9L,8L,7L,15L,14L,13L,12L,11L,20L,19L,18L,17L,16L,21L,26L,25L,24L,23L,28L,22L,27L,33L,32L,31L,36L,30L,35L,29L,34L,41L,40L,45L,39L,44L,38L,43L,37L,42L,50L,55L,49L,54L,48L,53L,47L,52L,46L,51L,66L,60L,65L,59L,64L,58L,63L,57L,62L,56L,61L,77L,71L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194879Inst : IEnumerable<long>
{
public static readonly long[] Value=A194879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194879.Bytes);
public long this[int i]=>Value[i];

public static A194879Inst Instance=new A194879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194880
{
public static readonly long[] Value={ 0L,-1L,-1L,-4L,-5L,-2L,-7L,-8L,-3L,-10L,-11L,-4L,-13L,-14L,-5L,-16L,-17L,-6L,-19L,-20L,-7L,-22L,-23L,-8L,-25L,-26L,-9L,-28L,-29L,-10L,-31L,-32L,-11L,-34L,-35L,-12L,-37L,-38L,-13L,-40L,-41L,-14L,-43L,-44L,-15L,-46L,-47L,-16L,-49L,-50L,-17L,-52L,-53L,-18L,-55L,-56L,-19L,-58L,-59L,-20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194880Inst : IEnumerable<long>
{
public static readonly long[] Value=A194880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194880.Bytes);
public long this[int i]=>Value[i];

public static A194880Inst Instance=new A194880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194881
{
public static readonly long[] Value={ 2L,3L,6L,8L,12L,15L,21L,25L,34L,38L,48L,54L,66L,72L,84L,92L,108L,117L,135L,143L,161L,171L,193L,205L,225L,237L,264L,276L,304L,316L,346L,362L,392L,408L,432L,450L,486L,504L,540L,556L,596L,614L,656L,676L,712L,734L,780L,804L,846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194881Inst : IEnumerable<long>
{
public static readonly long[] Value=A194881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194881.Bytes);
public long this[int i]=>Value[i];

public static A194881Inst Instance=new A194881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194882
{
public static readonly long[] Value={ 3L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194882Inst : IEnumerable<long>
{
public static readonly long[] Value=A194882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194882.Bytes);
public long this[int i]=>Value[i];

public static A194882Inst Instance=new A194882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194883
{
public static readonly long[] Value={ 2L,2L,3L,3L,3L,2L,3L,3L,3L,4L,4L,4L,4L,4L,4L,2L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,2L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,2L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194883Inst : IEnumerable<long>
{
public static readonly long[] Value=A194883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194883.Bytes);
public long this[int i]=>Value[i];

public static A194883Inst Instance=new A194883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194884
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,2L,2L,1L,2L,2L,3L,3L,3L,1L,1L,2L,2L,1L,2L,2L,3L,3L,3L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,1L,1L,2L,2L,1L,2L,2L,3L,3L,3L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,5L,1L,1L,2L,2L,1L,2L,2L,3L,3L,3L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,5L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194884Inst : IEnumerable<long>
{
public static readonly long[] Value=A194884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194884.Bytes);
public long this[int i]=>Value[i];

public static A194884Inst Instance=new A194884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194885
{
public static readonly long[] Value={ 3L,2L,1L,0L,4L,2L,1L,0L,4L,3L,1L,0L,4L,3L,2L,0L,4L,3L,2L,1L,5L,2L,1L,0L,5L,3L,1L,0L,5L,3L,2L,0L,5L,3L,2L,1L,5L,4L,1L,0L,5L,4L,2L,0L,5L,4L,2L,1L,5L,4L,3L,0L,5L,4L,3L,1L,5L,4L,3L,2L,6L,2L,1L,0L,6L,3L,1L,0L,6L,3L,2L,0L,6L,3L,2L,1L,6L,4L,1L,0L,6L,4L,2L,0L,6L,4L,2L,1L,6L,4L,3L,0L,6L,4L,3L,1L,6L,4L,3L,2L,6L,5L,1L,0L,6L,5L,2L,0L,6L,5L,2L,1L,6L,5L,3L,0L,6L,5L,3L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194885Inst : IEnumerable<long>
{
public static readonly long[] Value=A194885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194885.Bytes);
public long this[int i]=>Value[i];

public static A194885Inst Instance=new A194885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194886
{
public static readonly long[] Value={ 1L,0L,7L,2L,5L,6L,5L,2L,7L,0L,1L,0L,7L,2L,5L,6L,5L,2L,7L,0L,1L,0L,7L,2L,5L,6L,5L,2L,7L,0L,1L,0L,7L,2L,5L,6L,5L,2L,7L,0L,1L,0L,7L,2L,5L,6L,5L,2L,7L,0L,1L,0L,7L,2L,5L,6L,5L,2L,7L,0L,1L,0L,7L,2L,5L,6L,5L,2L,7L,0L,1L,0L,7L,2L,5L,6L,5L,2L,7L,0L,1L,0L,7L,2L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194886Inst : IEnumerable<long>
{
public static readonly long[] Value=A194886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194886.Bytes);
public long this[int i]=>Value[i];

public static A194886Inst Instance=new A194886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194887
{
public static readonly long[] Value={ 2L,13L,24L,145L,156L,288L,1729L,1740L,1872L,3456L,20737L,20748L,20880L,22464L,41472L,248833L,248844L,248976L,250560L,269568L,497664L,2985985L,2985996L,2986128L,2987712L,3006720L,3234816L,5971968L,35831809L,35831820L,35831952L,35833536L,35852544L,36080640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194887Inst : IEnumerable<long>
{
public static readonly long[] Value=A194887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194887.Bytes);
public long this[int i]=>Value[i];

public static A194887Inst Instance=new A194887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194888
{
public static readonly long[] Value={ 1L,3L,24L,192L,1152L,5760L,26880L,118272L,506880L,2119680L,8761344L,35807232L,145539072L,588349440L,2372075520L,9538240512L,38303170560L,153613762560L,615659864064L,2465854390272L,9873068654592L,39518019256320L,158149336104960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194888Inst : IEnumerable<long>
{
public static readonly long[] Value=A194888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194888.Bytes);
public long this[int i]=>Value[i];

public static A194888Inst Instance=new A194888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194889
{
public static readonly long[] Value={ 1L,3L,33L,1620L,136080L,17962560L,3751608960L,1233597237120L,641473938397440L,526921921428975360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194889Inst : IEnumerable<long>
{
public static readonly long[] Value=A194889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194889.Bytes);
public long this[int i]=>Value[i];

public static A194889Inst Instance=new A194889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194890
{
public static readonly long[] Value={ 1L,3L,34L,3936L,1797696L,2054111040L,5741390328960L,39210440893622016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194890Inst : IEnumerable<long>
{
public static readonly long[] Value=A194890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194890.Bytes);
public long this[int i]=>Value[i];

public static A194890Inst Instance=new A194890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194891
{
public static readonly long[] Value={ 1L,3L,34L,5249L,7418424L,41521783200L,788547395813440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194891Inst : IEnumerable<long>
{
public static readonly long[] Value=A194891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194891.Bytes);
public long this[int i]=>Value[i];

public static A194891Inst Instance=new A194891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194892
{
public static readonly long[] Value={ 1L,3L,34L,5556L,15005952L,282616583760L,24289270603904160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194892Inst : IEnumerable<long>
{
public static readonly long[] Value=A194892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194892.Bytes);
public long this[int i]=>Value[i];

public static A194892Inst Instance=new A194892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194893
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,0L,1L,3L,6L,0L,1L,3L,24L,0L,0L,1L,3L,33L,192L,0L,0L,1L,3L,34L,1620L,1152L,0L,0L,1L,3L,34L,3936L,136080L,5760L,0L,0L,1L,3L,34L,5249L,1797696L,17962560L,26880L,0L,0L,1L,3L,34L,5556L,7418424L,2054111040L,3751608960L,118272L,0L,0L,1L,3L,34L,5586L,15005952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194893Inst : IEnumerable<long>
{
public static readonly long[] Value=A194893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194893.Bytes);
public long this[int i]=>Value[i];

public static A194893Inst Instance=new A194893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194894
{
public static readonly long[] Value={ 0L,0L,24L,0L,120L,24L,336L,0L,648L,120L,1320L,24L,2184L,336L,3024L,0L,4896L,648L,6840L,120L,8424L,1320L,12144L,24L,15000L,2184L,17496L,336L,24360L,3024L,29760L,0L,33024L,4896L,40776L,648L,50616L,6840L,54624L,120L,68880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194894Inst : IEnumerable<long>
{
public static readonly long[] Value=A194894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194894.Bytes);
public long this[int i]=>Value[i];

public static A194894Inst Instance=new A194894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194895
{
public static readonly long[] Value={ 0L,-1L,9L,131L,1396L,13786L,131537L,1239745L,11665803L,109941002L,1038723932L,9841935529L,93518105160L,891022511814L,8510960557278L,81485246876212L,781818951793344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194895Inst : IEnumerable<long>
{
public static readonly long[] Value=A194895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194895.Bytes);
public long this[int i]=>Value[i];

public static A194895Inst Instance=new A194895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194896
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,1L,7L,2L,3L,4L,5L,6L,1L,7L,2L,8L,3L,4L,5L,6L,1L,7L,2L,8L,3L,9L,4L,5L,6L,1L,7L,2L,8L,3L,9L,4L,10L,5L,6L,1L,7L,2L,8L,3L,9L,4L,10L,5L,11L,6L,12L,1L,7L,2L,8L,3L,9L,4L,10L,5L,11L,6L,12L,1L,7L,13L,2L,8L,3L,9L,4L,10L,5L,11L,6L,12L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194896Inst : IEnumerable<long>
{
public static readonly long[] Value=A194896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194896.Bytes);
public long this[int i]=>Value[i];

public static A194896Inst Instance=new A194896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194897
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,16L,23L,25L,26L,27L,28L,22L,24L,30L,32L,34L,35L,36L,29L,31L,33L,38L,40L,42L,44L,45L,37L,39L,41L,43L,47L,49L,51L,53L,55L,46L,48L,50L,52L,54L,57L,59L,61L,63L,65L,56L,58L,60L,62L,64L,66L,69L,71L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194897Inst : IEnumerable<long>
{
public static readonly long[] Value=A194897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194897.Bytes);
public long this[int i]=>Value[i];

public static A194897Inst Instance=new A194897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194898
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,21L,16L,17L,18L,19L,20L,27L,22L,28L,23L,24L,25L,26L,34L,29L,35L,30L,36L,31L,32L,33L,42L,37L,43L,38L,44L,39L,45L,40L,41L,51L,46L,52L,47L,53L,48L,54L,49L,55L,50L,61L,56L,62L,57L,63L,58L,64L,59L,65L,60L,66L,72L,78L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194898Inst : IEnumerable<long>
{
public static readonly long[] Value=A194898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194898.Bytes);
public long this[int i]=>Value[i];

public static A194898Inst Instance=new A194898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194899
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,2L,3L,1L,4L,2L,5L,3L,1L,4L,2L,5L,3L,1L,6L,4L,2L,7L,5L,3L,1L,6L,4L,2L,7L,5L,3L,1L,8L,6L,4L,2L,9L,7L,5L,3L,1L,8L,6L,4L,2L,9L,7L,5L,3L,1L,10L,8L,6L,4L,2L,11L,9L,7L,5L,3L,1L,10L,8L,6L,4L,2L,11L,9L,7L,5L,3L,1L,12L,10L,8L,6L,4L,2L,13L,11L,9L,7L,5L,3L,1L,12L,10L,8L,6L,4L,2L,13L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194899Inst : IEnumerable<long>
{
public static readonly long[] Value=A194899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194899.Bytes);
public long this[int i]=>Value[i];

public static A194899Inst Instance=new A194899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194900
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,4L,8L,10L,7L,9L,13L,15L,12L,14L,11L,18L,21L,17L,20L,16L,19L,25L,28L,24L,27L,23L,26L,22L,32L,36L,31L,35L,30L,34L,29L,33L,41L,45L,40L,44L,39L,43L,38L,42L,37L,50L,55L,49L,54L,48L,53L,47L,52L,46L,51L,61L,66L,60L,65L,59L,64L,58L,63L,57L,62L,56L,72L,78L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194900Inst : IEnumerable<long>
{
public static readonly long[] Value=A194900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194900.Bytes);
public long this[int i]=>Value[i];

public static A194900Inst Instance=new A194900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194901
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,5L,9L,7L,10L,8L,15L,13L,11L,14L,12L,20L,18L,16L,21L,19L,17L,28L,26L,24L,22L,27L,25L,23L,35L,33L,31L,29L,36L,34L,32L,30L,45L,43L,41L,39L,37L,44L,42L,40L,38L,54L,52L,50L,48L,46L,55L,53L,51L,49L,47L,66L,64L,62L,60L,58L,56L,65L,63L,61L,59L,57L,77L,75L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194901Inst : IEnumerable<long>
{
public static readonly long[] Value=A194901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194901.Bytes);
public long this[int i]=>Value[i];

public static A194901Inst Instance=new A194901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194902
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,2L,4L,1L,3L,2L,4L,1L,3L,5L,2L,4L,6L,1L,3L,5L,2L,4L,6L,1L,3L,5L,7L,2L,4L,6L,8L,1L,3L,5L,7L,2L,4L,6L,8L,1L,3L,5L,7L,9L,2L,4L,6L,8L,10L,1L,3L,5L,7L,9L,2L,4L,6L,8L,10L,1L,3L,5L,7L,9L,11L,2L,4L,6L,8L,10L,12L,1L,3L,5L,7L,9L,11L,2L,4L,6L,8L,10L,12L,1L,3L,5L,7L,9L,11L,13L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194902Inst : IEnumerable<long>
{
public static readonly long[] Value=A194902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194902.Bytes);
public long this[int i]=>Value[i];

public static A194902Inst Instance=new A194902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194903
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,6L,9L,7L,10L,8L,13L,11L,14L,12L,15L,19L,16L,20L,17L,21L,18L,25L,22L,26L,23L,27L,24L,28L,33L,29L,34L,30L,35L,31L,36L,32L,41L,37L,42L,38L,43L,39L,44L,40L,45L,51L,46L,52L,47L,53L,48L,54L,49L,55L,50L,61L,56L,62L,57L,63L,58L,64L,59L,65L,60L,66L,73L,67L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194903Inst : IEnumerable<long>
{
public static readonly long[] Value=A194903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194903.Bytes);
public long this[int i]=>Value[i];

public static A194903Inst Instance=new A194903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194904
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,6L,8L,10L,7L,9L,12L,14L,11L,13L,15L,17L,19L,21L,16L,18L,20L,23L,25L,27L,22L,24L,26L,28L,30L,32L,34L,36L,29L,31L,33L,35L,38L,40L,42L,44L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,46L,48L,50L,52L,54L,57L,59L,61L,63L,65L,56L,58L,60L,62L,64L,66L,68L,70L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194904Inst : IEnumerable<long>
{
public static readonly long[] Value=A194904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194904.Bytes);
public long this[int i]=>Value[i];

public static A194904Inst Instance=new A194904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194905
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,1L,9L,2L,3L,4L,5L,6L,7L,8L,1L,9L,2L,10L,3L,4L,5L,6L,7L,8L,1L,9L,2L,10L,3L,11L,4L,5L,6L,7L,8L,1L,9L,2L,10L,3L,11L,4L,12L,5L,6L,7L,8L,1L,9L,2L,10L,3L,11L,4L,12L,5L,13L,6L,7L,8L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194905Inst : IEnumerable<long>
{
public static readonly long[] Value=A194905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194905.Bytes);
public long this[int i]=>Value[i];

public static A194905Inst Instance=new A194905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194906
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,35L,36L,29L,38L,40L,41L,42L,43L,44L,45L,37L,39L,47L,49L,51L,52L,53L,54L,55L,46L,48L,50L,57L,59L,61L,63L,64L,65L,66L,56L,58L,60L,62L,68L,70L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194906Inst : IEnumerable<long>
{
public static readonly long[] Value=A194906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194906.Bytes);
public long this[int i]=>Value[i];

public static A194906Inst Instance=new A194906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194907
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,36L,29L,30L,31L,32L,33L,34L,35L,44L,37L,45L,38L,39L,40L,41L,42L,43L,53L,46L,54L,47L,55L,48L,49L,50L,51L,52L,63L,56L,64L,57L,65L,58L,66L,59L,60L,61L,62L,74L,67L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194907Inst : IEnumerable<long>
{
public static readonly long[] Value=A194907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194907.Bytes);
public long this[int i]=>Value[i];

public static A194907Inst Instance=new A194907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194908
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,7L,6L,5L,4L,3L,2L,1L,7L,6L,5L,4L,3L,2L,1L,8L,7L,6L,5L,4L,3L,2L,9L,1L,8L,7L,6L,5L,4L,3L,10L,2L,9L,1L,8L,7L,6L,5L,4L,11L,3L,10L,2L,9L,1L,8L,7L,6L,5L,12L,4L,11L,3L,10L,2L,9L,1L,8L,7L,6L,13L,5L,12L,4L,11L,3L,10L,2L,9L,1L,8L,7L,14L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194908Inst : IEnumerable<long>
{
public static readonly long[] Value=A194908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194908.Bytes);
public long this[int i]=>Value[i];

public static A194908Inst Instance=new A194908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194909
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,10L,9L,8L,7L,15L,14L,13L,12L,11L,21L,20L,19L,18L,17L,16L,28L,27L,26L,25L,24L,23L,22L,35L,34L,33L,32L,31L,30L,29L,36L,44L,42L,41L,40L,39L,38L,37L,45L,43L,54L,52L,50L,49L,48L,47L,46L,55L,53L,51L,65L,63L,61L,59L,58L,57L,56L,66L,64L,62L,60L,77L,75L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194909Inst : IEnumerable<long>
{
public static readonly long[] Value=A194909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194909.Bytes);
public long this[int i]=>Value[i];

public static A194909Inst Instance=new A194909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194910
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,10L,9L,8L,7L,15L,14L,13L,12L,11L,21L,20L,19L,18L,17L,16L,28L,27L,26L,25L,24L,23L,22L,35L,34L,33L,32L,31L,30L,29L,36L,43L,42L,41L,40L,39L,38L,45L,37L,44L,52L,51L,50L,49L,48L,55L,47L,54L,46L,53L,62L,61L,60L,59L,66L,58L,65L,57L,64L,56L,63L,73L,72L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194910Inst : IEnumerable<long>
{
public static readonly long[] Value=A194910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194910.Bytes);
public long this[int i]=>Value[i];

public static A194910Inst Instance=new A194910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194911
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,4L,1L,2L,3L,4L,1L,5L,2L,3L,4L,1L,5L,2L,6L,3L,4L,1L,5L,2L,6L,3L,7L,4L,8L,1L,5L,2L,6L,3L,7L,4L,8L,1L,5L,9L,2L,6L,3L,7L,4L,8L,1L,5L,9L,2L,6L,10L,3L,7L,4L,8L,1L,5L,9L,2L,6L,10L,3L,7L,11L,4L,8L,12L,1L,5L,9L,2L,6L,10L,3L,7L,11L,4L,8L,12L,1L,5L,9L,13L,2L,6L,10L,3L,7L,11L,4L,8L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194911Inst : IEnumerable<long>
{
public static readonly long[] Value=A194911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194911.Bytes);
public long this[int i]=>Value[i];

public static A194911Inst Instance=new A194911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194912
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,7L,12L,14L,15L,11L,13L,17L,19L,21L,16L,18L,20L,23L,25L,27L,22L,24L,26L,28L,31L,33L,35L,29L,32L,34L,36L,30L,39L,42L,44L,37L,40L,43L,45L,38L,41L,48L,51L,54L,46L,49L,52L,55L,47L,50L,53L,58L,61L,64L,56L,59L,62L,65L,57L,60L,63L,66L,70L,73L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194912Inst : IEnumerable<long>
{
public static readonly long[] Value=A194912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194912.Bytes);
public long this[int i]=>Value[i];

public static A194912Inst Instance=new A194912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194913
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,10L,7L,8L,9L,14L,11L,15L,12L,13L,19L,16L,20L,17L,21L,18L,25L,22L,26L,23L,27L,24L,28L,32L,36L,29L,33L,30L,34L,31L,35L,40L,44L,37L,41L,45L,38L,42L,39L,43L,49L,53L,46L,50L,54L,47L,51L,55L,48L,52L,59L,63L,56L,60L,64L,57L,61L,65L,58L,62L,66L,70L,74L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194913Inst : IEnumerable<long>
{
public static readonly long[] Value=A194913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194913.Bytes);
public long this[int i]=>Value[i];

public static A194913Inst Instance=new A194913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194914
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,2L,4L,3L,1L,2L,5L,4L,3L,1L,2L,5L,6L,4L,3L,1L,2L,5L,7L,6L,4L,3L,1L,2L,5L,8L,7L,6L,4L,3L,1L,2L,5L,8L,9L,7L,6L,4L,3L,1L,2L,5L,8L,10L,9L,7L,6L,4L,3L,1L,2L,5L,8L,11L,10L,9L,7L,6L,4L,3L,1L,2L,5L,8L,11L,12L,10L,9L,7L,6L,4L,3L,1L,2L,5L,8L,11L,13L,12L,10L,9L,7L,6L,4L,3L,1L,2L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194914Inst : IEnumerable<long>
{
public static readonly long[] Value=A194914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194914.Bytes);
public long this[int i]=>Value[i];

public static A194914Inst Instance=new A194914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194915
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,5L,10L,7L,9L,8L,15L,11L,14L,13L,12L,21L,16L,20L,19L,17L,18L,28L,22L,27L,26L,23L,25L,24L,36L,29L,35L,34L,30L,33L,32L,31L,45L,37L,44L,43L,38L,42L,41L,39L,40L,55L,46L,54L,53L,47L,52L,51L,48L,50L,49L,66L,56L,65L,64L,57L,63L,62L,58L,61L,60L,59L,78L,67L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194915Inst : IEnumerable<long>
{
public static readonly long[] Value=A194915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194915.Bytes);
public long this[int i]=>Value[i];

public static A194915Inst Instance=new A194915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194916
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,4L,8L,10L,9L,7L,12L,15L,14L,13L,11L,17L,20L,21L,19L,18L,16L,23L,26L,28L,27L,25L,24L,22L,30L,33L,36L,35L,34L,32L,31L,29L,38L,41L,44L,45L,43L,42L,40L,39L,37L,47L,50L,53L,55L,54L,52L,51L,49L,48L,46L,57L,60L,63L,66L,65L,64L,62L,61L,59L,58L,56L,68L,71L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194916Inst : IEnumerable<long>
{
public static readonly long[] Value=A194916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194916.Bytes);
public long this[int i]=>Value[i];

public static A194916Inst Instance=new A194916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194917
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,2L,4L,3L,1L,2L,5L,4L,3L,1L,2L,5L,6L,4L,3L,1L,2L,5L,7L,6L,4L,3L,1L,2L,5L,7L,8L,6L,4L,3L,1L,2L,5L,7L,9L,8L,6L,4L,3L,1L,2L,5L,7L,10L,9L,8L,6L,4L,3L,1L,2L,5L,7L,10L,11L,9L,8L,6L,4L,3L,1L,2L,5L,7L,10L,12L,11L,9L,8L,6L,4L,3L,1L,2L,5L,7L,10L,13L,12L,11L,9L,8L,6L,4L,3L,1L,2L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194917Inst : IEnumerable<long>
{
public static readonly long[] Value=A194917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194917.Bytes);
public long this[int i]=>Value[i];

public static A194917Inst Instance=new A194917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194918
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,5L,10L,7L,9L,8L,15L,11L,14L,13L,12L,21L,16L,20L,19L,17L,18L,28L,22L,27L,26L,23L,25L,24L,36L,29L,35L,34L,30L,33L,31L,32L,45L,37L,44L,43L,38L,42L,39L,41L,40L,55L,46L,54L,53L,47L,52L,48L,51L,50L,49L,66L,56L,65L,64L,57L,63L,58L,62L,61L,59L,60L,78L,67L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194918Inst : IEnumerable<long>
{
public static readonly long[] Value=A194918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194918.Bytes);
public long this[int i]=>Value[i];

public static A194918Inst Instance=new A194918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194919
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,4L,8L,10L,9L,7L,12L,15L,14L,13L,11L,17L,20L,21L,19L,18L,16L,23L,26L,28L,27L,25L,24L,22L,30L,33L,35L,36L,34L,32L,31L,29L,38L,41L,43L,45L,44L,42L,40L,39L,37L,47L,50L,52L,55L,54L,53L,51L,49L,48L,46L,57L,60L,62L,65L,66L,64L,63L,61L,59L,58L,56L,68L,71L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194919Inst : IEnumerable<long>
{
public static readonly long[] Value=A194919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194919.Bytes);
public long this[int i]=>Value[i];

public static A194919Inst Instance=new A194919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194920
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,19L,19L,19L,20L,20L,20L,20L,21L,21L,21L,22L,22L,22L,22L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194920Inst : IEnumerable<long>
{
public static readonly long[] Value=A194920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194920.Bytes);
public long this[int i]=>Value[i];

public static A194920Inst Instance=new A194920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194921
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,3L,4L,2L,1L,3L,5L,4L,2L,1L,3L,6L,5L,4L,2L,1L,3L,6L,7L,5L,4L,2L,1L,3L,6L,8L,7L,5L,4L,2L,1L,3L,6L,9L,8L,7L,5L,4L,2L,1L,3L,6L,10L,9L,8L,7L,5L,4L,2L,1L,3L,6L,10L,11L,9L,8L,7L,5L,4L,2L,1L,3L,6L,10L,12L,11L,9L,8L,7L,5L,4L,2L,1L,3L,6L,10L,13L,12L,11L,9L,8L,7L,5L,4L,2L,1L,3L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194921Inst : IEnumerable<long>
{
public static readonly long[] Value=A194921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194921.Bytes);
public long this[int i]=>Value[i];

public static A194921Inst Instance=new A194921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194922
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,10L,9L,7L,8L,15L,14L,11L,13L,12L,21L,20L,16L,19L,18L,17L,28L,27L,22L,26L,25L,23L,24L,36L,35L,29L,34L,33L,30L,32L,31L,45L,44L,37L,43L,42L,38L,41L,40L,39L,55L,54L,46L,53L,52L,47L,51L,50L,49L,48L,66L,65L,56L,64L,63L,57L,62L,61L,60L,58L,59L,78L,77L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194922Inst : IEnumerable<long>
{
public static readonly long[] Value=A194922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194922.Bytes);
public long this[int i]=>Value[i];

public static A194922Inst Instance=new A194922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194923
{
public static readonly long[] Value={ 0L,1L,2L,0L,1L,0L,2L,1L,0L,1L,2L,2L,0L,2L,1L,0L,1L,0L,0L,1L,2L,0L,2L,0L,0L,2L,1L,1L,0L,1L,1L,0L,2L,1L,2L,0L,1L,2L,1L,2L,0L,1L,2L,0L,2L,2L,1L,0L,2L,1L,2L,0L,1L,0L,2L,0L,1L,2L,0L,0L,1L,2L,1L,0L,2L,0L,1L,0L,2L,1L,0L,0L,2L,1L,2L,1L,0L,1L,2L,1L,0L,2L,0L,1L,0L,2L,1L,1L,2L,0L,1L,1L,2L,0L,2L,1L,2L,1L,0L,2L,0L,1L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194923Inst : IEnumerable<long>
{
public static readonly long[] Value=A194923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194923.Bytes);
public long this[int i]=>Value[i];

public static A194923Inst Instance=new A194923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194924
{
public static readonly long[] Value={ 1L,3L,4L,15L,6L,63L,64L,171L,130L,1023L,804L,4095L,2380L,7920L,16384L,65535L,40410L,262143L,246640L,582771L,695860L,4194303L,2884776L,13455325L,11576916L,44739243L,65924824L,268435455L,176422980L,1073741823L,1073741824L,2669774811L,3128164186L,11421338075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194924Inst : IEnumerable<long>
{
public static readonly long[] Value=A194924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194924.Bytes);
public long this[int i]=>Value[i];

public static A194924Inst Instance=new A194924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194925
{
public static readonly BigInteger[] Value={ 3L,17L,217L,5873L,344091L,43337009L,11761200209L,6872287575297L,8648230733328339L,BigInteger.Parse("23436303828484483825"),BigInteger.Parse("136773087470228122215081"),BigInteger.Parse("1718926116885238623987854577"),BigInteger.Parse("46522215573069867474481754034859") };
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
public class A194925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194925Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194925.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194925.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194925Inst Instance=new A194925Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194926
{
public static readonly BigInteger[] Value={ 4L,26L,386L,12474L,882318L,136403494L,46128809462L,34125388757746L,55232992212354490L,BigInteger.Parse("195592244264620494970"),BigInteger.Parse("1515477849222357994524778"),BigInteger.Parse("25692027725435091847764127738"),BigInteger.Parse("953019093594286117476472624693750") };
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
public class A194926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194926Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194926.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194926.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194926Inst Instance=new A194926Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194927
{
public static readonly BigInteger[] Value={ 5L,35L,557L,19379L,1481501L,248381815L,91397735301L,73818960495633L,130889487125186283L,BigInteger.Parse("509545270244514585603"),BigInteger.Parse("4355460540545035980173055"),BigInteger.Parse("81748120032524783307283152379"),BigInteger.Parse("3369206664229541719414619846139771") };
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
public class A194927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194927Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194927.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194927.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194927Inst Instance=new A194927Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194928
{
public static readonly BigInteger[] Value={ 6L,44L,728L,26316L,2089736L,364130672L,139323386328L,117075649276412L,216113470259526948L,BigInteger.Parse("876452156097264185188"),BigInteger.Parse("7810016810149997712089700"),BigInteger.Parse("152927733637636192107728580088"),BigInteger.Parse("6580461097392848372314889891440304") };
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
public class A194928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194928Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194928.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194928.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194928Inst Instance=new A194928Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194929
{
public static readonly BigInteger[] Value={ 7L,53L,899L,33255L,2698979L,480403525L,187700534197L,161035011766925L,303461593374854353L,BigInteger.Parse("1256322271164918861739"),BigInteger.Parse("11428194376171669924653051"),BigInteger.Parse("228444866925294986583863447811"),BigInteger.Parse("10035740315100401504962617899482767") };
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
public class A194929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194929Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194929.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194929.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194929Inst Instance=new A194929Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194930
{
public static readonly BigInteger[] Value={ 8L,62L,1070L,40194L,3308286L,596729942L,236134568314L,205098663583642L,391167151610036562L,BigInteger.Parse("1638606240965437583666"),BigInteger.Parse("15079495677916351972815638"),BigInteger.Parse("304904458867761348224836330046"),BigInteger.Parse("13547381816347935357119939144563302") };
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
public class A194930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194930Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194930.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194930.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194930Inst Instance=new A194930Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194931
{
public static readonly long[] Value={ 2L,3L,8L,4L,17L,64L,5L,26L,217L,1024L,6L,35L,386L,5873L,32768L,7L,44L,557L,12474L,344091L,2097152L,8L,53L,728L,19379L,882318L,43337009L,268435456L,9L,62L,899L,26316L,1481501L,136403494L,11761200209L,68719476736L,10L,71L,1070L,33255L,2089736L,248381815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194931Inst : IEnumerable<long>
{
public static readonly long[] Value=A194931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194931.Bytes);
public long this[int i]=>Value[i];

public static A194931Inst Instance=new A194931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194932
{
public static readonly long[] Value={ 64L,217L,386L,557L,728L,899L,1070L,1241L,1412L,1583L,1754L,1925L,2096L,2267L,2438L,2609L,2780L,2951L,3122L,3293L,3464L,3635L,3806L,3977L,4148L,4319L,4490L,4661L,4832L,5003L,5174L,5345L,5516L,5687L,5858L,6029L,6200L,6371L,6542L,6713L,6884L,7055L,7226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194932Inst : IEnumerable<long>
{
public static readonly long[] Value=A194932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194932.Bytes);
public long this[int i]=>Value[i];

public static A194932Inst Instance=new A194932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194933
{
public static readonly long[] Value={ 1024L,5873L,12474L,19379L,26316L,33255L,40194L,47133L,54072L,61011L,67950L,74889L,81828L,88767L,95706L,102645L,109584L,116523L,123462L,130401L,137340L,144279L,151218L,158157L,165096L,172035L,178974L,185913L,192852L,199791L,206730L,213669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194933Inst : IEnumerable<long>
{
public static readonly long[] Value=A194933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194933.Bytes);
public long this[int i]=>Value[i];

public static A194933Inst Instance=new A194933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194934
{
public static readonly long[] Value={ 32768L,344091L,882318L,1481501L,2089736L,2698979L,3308286L,3917595L,4526904L,5136213L,5745522L,6354831L,6964140L,7573449L,8182758L,8792067L,9401376L,10010685L,10619994L,11229303L,11838612L,12447921L,13057230L,13666539L,14275848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194934Inst : IEnumerable<long>
{
public static readonly long[] Value=A194934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194934.Bytes);
public long this[int i]=>Value[i];

public static A194934Inst Instance=new A194934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194935
{
public static readonly long[] Value={ 2097152L,43337009L,136403494L,248381815L,364130672L,480403525L,596729942L,713059915L,829390016L,945720119L,1062050222L,1178380325L,1294710428L,1411040531L,1527370634L,1643700737L,1760030840L,1876360943L,1992691046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194935Inst : IEnumerable<long>
{
public static readonly long[] Value=A194935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194935.Bytes);
public long this[int i]=>Value[i];

public static A194935Inst Instance=new A194935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194936
{
public static readonly long[] Value={ 268435456L,11761200209L,46128809462L,91397735301L,139323386328L,187700534197L,236134568314L,284573981453L,333013734808L,381453501205L,429893267858L,478333034513L,526772801168L,575212567823L,623652334478L,672092101133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194936Inst : IEnumerable<long>
{
public static readonly long[] Value=A194936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194936.Bytes);
public long this[int i]=>Value[i];

public static A194936Inst Instance=new A194936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194937
{
public static readonly BigInteger[] Value={ 1L,1L,3L,31L,1393L,330361L,488337121L,5197945772881L,452395544496860161L,BigInteger.Parse("360573039112103480718721"),BigInteger.Parse("2914843277842193790386417088001"),BigInteger.Parse("262261378512171017948642290003977004801"),BigInteger.Parse("285983731923953608933716749772942709840131379201") };
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
public class A194937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194937Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194937.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194937.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194937Inst Instance=new A194937Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194938
{
public static readonly long[] Value={ 1L,0L,1L,0L,3L,1L,0L,8L,9L,1L,0L,42L,59L,18L,1L,0L,264L,450L,215L,30L,1L,0L,2160L,4114L,2475L,565L,45L,1L,0L,20880L,43512L,30814L,9345L,1225L,63L,1L,0L,236880L,528492L,420756L,154609L,27720L,2338L,84L,1L,0L,3064320L,7235568L,6316316L,2673972L,594489L,69552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194938Inst : IEnumerable<long>
{
public static readonly long[] Value=A194938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194938.Bytes);
public long this[int i]=>Value[i];

public static A194938Inst Instance=new A194938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194939
{
public static readonly long[] Value={ 2L,3L,5L,5L,8L,10L,7L,12L,15L,17L,11L,18L,23L,26L,28L,13L,24L,31L,36L,39L,41L,17L,30L,41L,48L,53L,56L,58L,19L,36L,49L,60L,67L,72L,75L,77L,23L,42L,59L,72L,83L,90L,95L,98L,100L,29L,52L,71L,88L,101L,112L,119L,124L,127L,129L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194939Inst : IEnumerable<long>
{
public static readonly long[] Value=A194939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194939.Bytes);
public long this[int i]=>Value[i];

public static A194939Inst Instance=new A194939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194940
{
public static readonly long[] Value={ 2L,8L,4L,4L,5L,8L,5L,5L,0L,4L,0L,9L,8L,0L,1L,8L,7L,8L,1L,5L,9L,2L,0L,1L,0L,1L,8L,1L,2L,6L,9L,3L,1L,7L,4L,5L,3L,3L,0L,0L,5L,2L,8L,3L,0L,7L,8L,9L,4L,6L,2L,6L,9L,8L,0L,4L,5L,8L,7L,7L,5L,0L,0L,3L,0L,1L,1L,8L,9L,8L,9L,5L,8L,4L,8L,2L,9L,2L,3L,9L,7L,5L,3L,8L,6L,9L,4L,7L,2L,3L,6L,0L,6L,2L,2L,7L,2L,2L,1L,4L,6L,7L,6L,4L,6L,1L,7L,2L,4L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194940Inst : IEnumerable<long>
{
public static readonly long[] Value=A194940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194940.Bytes);
public long this[int i]=>Value[i];

public static A194940Inst Instance=new A194940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194941
{
public static readonly long[] Value={ 36L,28L,45L,66L,91L,160L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194941Inst : IEnumerable<long>
{
public static readonly long[] Value=A194941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194941.Bytes);
public long this[int i]=>Value[i];

public static A194941Inst Instance=new A194941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194942
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,0L,1L,2L,0L,1L,0L,2L,0L,1L,2L,0L,0L,1L,2L,1L,0L,1L,0L,2L,0L,0L,1L,0L,2L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,2L,0L,1L,2L,1L,0L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,1L,0L,0L,1L,0L,2L,1L,2L,0L,1L,2L,0L,1L,0L,0L,1L,2L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194942Inst : IEnumerable<long>
{
public static readonly long[] Value=A194942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194942.Bytes);
public long this[int i]=>Value[i];

public static A194942Inst Instance=new A194942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194943
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,4L,2L,4L,1L,6L,1L,7L,3L,2L,2L,6L,2L,10L,2L,4L,3L,10L,3L,10L,3L,6L,2L,10L,2L,18L,4L,6L,5L,6L,4L,11L,5L,5L,3L,14L,2L,10L,5L,8L,6L,20L,3L,12L,5L,8L,11L,12L,3L,6L,4L,7L,5L,12L,2L,24L,9L,6L,5L,6L,3L,15L,5L,8L,3L,18L,4L,24L,8L,8L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194943Inst : IEnumerable<long>
{
public static readonly long[] Value=A194943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194943.Bytes);
public long this[int i]=>Value[i];

public static A194943Inst Instance=new A194943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194944
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,12L,20L,24L,26L,30L,32L,38L,42L,44L,46L,60L,84L,108L,114L,126L,144L,166L,182L,192L,212L,234L,246L,258L,276L,278L,288L,294L,310L,406L,480L,494L,504L,534L,618L,634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194944Inst : IEnumerable<long>
{
public static readonly long[] Value=A194944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194944.Bytes);
public long this[int i]=>Value[i];

public static A194944Inst Instance=new A194944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194945
{
public static readonly long[] Value={ 1L,3L,7L,17L,19L,59L,159L,227L,317L,361L,521L,1637L,1691L,1997L,2053L,3833L,5207L,21209L,62809L,152351L,170167L,424783L,860831L,1415551L,2679809L,4722079L,6238447L,7050811L,17886697L,27507569L,30581429L,57868997L,127813579L,154641337L,1101795593L,11907340427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194945Inst : IEnumerable<long>
{
public static readonly long[] Value=A194945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194945.Bytes);
public long this[int i]=>Value[i];

public static A194945Inst Instance=new A194945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194946
{
public static readonly long[] Value={ 9L,15L,45L,65L,91L,231L,325L,341L,481L,703L,1541L,1891L,2701L,5461L,6533L,8321L,11041L,12403L,18721L,30889L,38503L,49141L,68101L,79003L,88561L,88831L,104653L,137149L,146611L,176149L,188191L,218791L,226801L,269011L,286903L,385003L,493697L,497503L,563473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194946Inst : IEnumerable<long>
{
public static readonly long[] Value=A194946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194946.Bytes);
public long this[int i]=>Value[i];

public static A194946Inst Instance=new A194946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194947
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,2L,0L,0L,2L,2L,2L,2L,2L,0L,2L,0L,2L,0L,0L,0L,0L,0L,0L,2L,8L,8L,0L,2L,2L,2L,2L,4L,2L,2L,0L,0L,2L,2L,2L,2L,2L,4L,6L,0L,4L,2L,4L,2L,2L,2L,4L,4L,0L,2L,2L,4L,0L,4L,0L,6L,6L,2L,2L,2L,0L,2L,2L,6L,2L,0L,0L,0L,0L,2L,0L,2L,0L,4L,2L,2L,2L,2L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194947Inst : IEnumerable<long>
{
public static readonly long[] Value=A194947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194947.Bytes);
public long this[int i]=>Value[i];

public static A194947Inst Instance=new A194947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194948
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,49L,53L,56L,59L,61L,67L,69L,71L,73L,76L,79L,83L,89L,97L,101L,103L,107L,109L,113L,122L,127L,131L,133L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194948Inst : IEnumerable<long>
{
public static readonly long[] Value=A194948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194948.Bytes);
public long this[int i]=>Value[i];

public static A194948Inst Instance=new A194948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194949
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,6L,4L,4L,6L,20L,10L,12L,10L,20L,72L,30L,28L,28L,30L,72L,260L,102L,84L,104L,84L,102L,260L,996L,362L,260L,268L,268L,260L,362L,996L,3772L,1358L,892L,832L,1144L,832L,892L,1358L,3772L,14852L,5130L,3236L,2928L,2956L,2956L,2928L,3236L,5130L,14852L,58204L,19982L,12044L,10072L,9948L,13736L,9948L,10072L,12044L,19982L,58204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194949Inst : IEnumerable<long>
{
public static readonly long[] Value=A194949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194949.Bytes);
public long this[int i]=>Value[i];

public static A194949Inst Instance=new A194949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194950
{
public static readonly long[] Value={ 1L,1L,2L,6L,20L,72L,260L,996L,3772L,14852L,58204L,234236L,934180L,3825428L,15493292L,64009212L,263052756L,1096235844L,4537607788L,19075092364L,79566093524L,336047432420L,1412387294716L,5993817852300L,25302001904628L,107911381154004L,457634804571804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194950Inst : IEnumerable<long>
{
public static readonly long[] Value=A194950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194950.Bytes);
public long this[int i]=>Value[i];

public static A194950Inst Instance=new A194950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194951
{
public static readonly BigInteger[] Value={ 1L,2L,12L,104L,1144L,13736L,180936L,2524968L,36428808L,549363240L,8453581224L,134086928456L,2142841448200L,35328245141864L,581259305091816L,9814113557287304L,165892448199221064L,2855555645146526760L,BigInteger.Parse("49032490558950500392"),BigInteger.Parse("859559382871581588424") };
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
public class A194951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194951Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194951.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194951.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194951Inst Instance=new A194951Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194952
{
public static readonly long[] Value={ 48L,126L,390L,1014L,2982L,8094L,23646L,66726L,196086L,568302L,1682382L,4954998L,14750310L,43833150L,130942398L,390959430L,1170256854L,3502513038L,10495480494L,31450265622L,94296270918L,282731526366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194952Inst : IEnumerable<long>
{
public static readonly long[] Value=A194952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194952.Bytes);
public long this[int i]=>Value[i];

public static A194952Inst Instance=new A194952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194953
{
public static readonly long[] Value={ 2L,6L,2L,4L,4L,4L,2L,2L,8L,2L,2L,4L,4L,4L,6L,2L,2L,4L,2L,2L,10L,6L,6L,2L,2L,2L,6L,2L,8L,8L,4L,6L,4L,2L,8L,4L,8L,4L,4L,6L,4L,2L,4L,2L,4L,2L,2L,22L,2L,2L,6L,4L,4L,8L,2L,2L,10L,2L,2L,2L,2L,4L,4L,4L,2L,2L,2L,2L,2L,10L,2L,2L,8L,18L,2L,2L,4L,4L,2L,12L,6L,6L,8L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194953Inst : IEnumerable<long>
{
public static readonly long[] Value=A194953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194953.Bytes);
public long this[int i]=>Value[i];

public static A194953Inst Instance=new A194953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194954
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,23L,29L,31L,37L,43L,47L,53L,59L,67L,71L,73L,79L,97L,101L,107L,113L,137L,139L,151L,157L,173L,179L,191L,199L,229L,233L,239L,241L,271L,277L,283L,307L,311L,313L,331L,337L,349L,367L,379L,383L,433L,439L,457L,463L,467L,479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194954Inst : IEnumerable<long>
{
public static readonly long[] Value=A194954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194954.Bytes);
public long this[int i]=>Value[i];

public static A194954Inst Instance=new A194954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194955
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,19L,31L,41L,47L,67L,73L,79L,89L,97L,103L,113L,137L,149L,157L,167L,197L,229L,239L,281L,293L,313L,353L,373L,379L,421L,431L,487L,557L,577L,601L,631L,659L,709L,719L,733L,761L,859L,887L,911L,953L,967L,1009L,1051L,1061L,1069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194955Inst : IEnumerable<long>
{
public static readonly long[] Value=A194955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194955.Bytes);
public long this[int i]=>Value[i];

public static A194955Inst Instance=new A194955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194956
{
public static readonly long[] Value={ 1L,1L,2L,6L,20L,73L,281L,1125L,4636L,19540L,83848L,365107L,1609285L,7166523L,32195965L,145746024L,664165843L,3044370240L,14027289780L,64932957320L,301833739881L,1408338395737L,6593747768053L,30967985680291L,145859467298446L,688805924907628L,3260700755258527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194956Inst : IEnumerable<long>
{
public static readonly long[] Value=A194956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194956.Bytes);
public long this[int i]=>Value[i];

public static A194956Inst Instance=new A194956Inst();

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