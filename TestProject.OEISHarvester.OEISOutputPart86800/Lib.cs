using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A106441
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,7L,2L,3L,2L,3L,4L,4L,7L,6L,2L,12L,3L,19L,2L,7L,11L,23L,4L,5L,5L,3L,8L,29L,6L,28L,2L,7L,12L,8L,6L,7L,19L,4L,6L,41L,7L,43L,12L,6L,4L,15L,4L,7L,5L,6L,4L,15L,3L,5L,8L,19L,11L,4L,6L,61L,31L,7L,2L,13L,3L,62L,8L,10L,7L,71L,4L,34L,8L,10L,17L,22L,13L,64L,2L,3L,18L,47L,21L,17L,12L,18L,6L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106441Inst : IEnumerable<long>
{
public static readonly long[] Value=A106441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106441.Bytes);
public long this[int i]=>Value[i];

public static A106441Inst Instance=new A106441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106442
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,6L,11L,8L,5L,14L,13L,12L,19L,22L,9L,16L,25L,10L,31L,28L,29L,26L,37L,24L,21L,38L,15L,44L,41L,18L,47L,128L,23L,50L,49L,20L,55L,62L,53L,56L,59L,58L,61L,52L,27L,74L,67L,192L,69L,42L,43L,76L,73L,30L,35L,88L,33L,82L,87L,36L,91L,94L,39L,64L,121L,46L,97L,100L,111L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106442Inst : IEnumerable<long>
{
public static readonly long[] Value=A106442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106442.Bytes);
public long this[int i]=>Value[i];

public static A106442Inst Instance=new A106442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106443
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,9L,6L,5L,8L,15L,18L,7L,12L,11L,10L,27L,16L,81L,30L,13L,36L,25L,14L,33L,24L,17L,22L,45L,20L,21L,54L,19L,512L,57L,162L,55L,60L,23L,26L,63L,72L,29L,50L,51L,28L,135L,66L,31L,768L,35L,34L,19683L,44L,39L,90L,37L,40L,99L,42L,41L,108L,43L,38L,75L,64L,225L,114L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106443Inst : IEnumerable<long>
{
public static readonly long[] Value=A106443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106443.Bytes);
public long this[int i]=>Value[i];

public static A106443Inst Instance=new A106443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106444
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,6L,11L,8L,5L,14L,13L,12L,19L,22L,9L,16L,25L,10L,31L,28L,29L,26L,37L,24L,21L,38L,15L,44L,41L,18L,47L,128L,23L,50L,49L,20L,55L,62L,53L,56L,59L,58L,61L,52L,27L,74L,67L,48L,69L,42L,43L,76L,73L,30L,35L,88L,33L,82L,87L,36L,91L,94L,39L,64L,121L,46L,97L,100L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106444Inst : IEnumerable<long>
{
public static readonly long[] Value=A106444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106444.Bytes);
public long this[int i]=>Value[i];

public static A106444Inst Instance=new A106444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106445
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,9L,6L,5L,8L,15L,18L,7L,12L,11L,10L,27L,16L,81L,30L,13L,36L,25L,14L,33L,24L,17L,22L,45L,20L,21L,54L,19L,512L,57L,162L,55L,60L,23L,26L,63L,72L,29L,50L,51L,28L,135L,66L,31L,48L,35L,34L,19683L,44L,39L,90L,37L,40L,99L,42L,41L,108L,43L,38L,75L,64L,225L,114L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106445Inst : IEnumerable<long>
{
public static readonly long[] Value=A106445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106445.Bytes);
public long this[int i]=>Value[i];

public static A106445Inst Instance=new A106445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106446
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,6L,11L,8L,5L,14L,25L,12L,19L,22L,9L,16L,47L,10L,31L,28L,29L,50L,13L,24L,21L,38L,15L,44L,61L,18L,137L,128L,43L,94L,49L,20L,55L,62L,53L,56L,97L,58L,115L,100L,27L,26L,37L,48L,69L,42L,113L,76L,73L,30L,79L,88L,33L,122L,319L,36L,41L,274L,39L,64L,121L,86L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106446Inst : IEnumerable<long>
{
public static readonly long[] Value=A106446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106446.Bytes);
public long this[int i]=>Value[i];

public static A106446Inst Instance=new A106446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106447
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,9L,6L,5L,8L,15L,18L,7L,12L,23L,10L,27L,16L,81L,30L,13L,36L,25L,14L,69L,24L,11L,46L,45L,20L,21L,54L,19L,512L,57L,162L,115L,60L,47L,26L,63L,72L,61L,50L,33L,28L,135L,138L,17L,48L,35L,22L,19683L,92L,39L,90L,37L,40L,207L,42L,83L,108L,29L,38L,75L,64L,225L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106447Inst : IEnumerable<long>
{
public static readonly long[] Value=A106447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106447.Bytes);
public long this[int i]=>Value[i];

public static A106447Inst Instance=new A106447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106448
{
public static readonly long[] Value={ 2L,3L,3L,4L,2L,4L,5L,5L,5L,5L,6L,3L,2L,3L,6L,7L,7L,7L,7L,7L,7L,8L,4L,8L,2L,8L,4L,8L,9L,9L,3L,9L,9L,3L,9L,9L,10L,5L,10L,5L,2L,5L,10L,5L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,12L,6L,4L,3L,12L,2L,12L,3L,4L,6L,12L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,14L,7L,14L,7L,14L,7L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106448Inst : IEnumerable<long>
{
public static readonly long[] Value=A106448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106448.Bytes);
public long this[int i]=>Value[i];

public static A106448Inst Instance=new A106448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106449
{
public static readonly long[] Value={ 0L,3L,3L,2L,0L,2L,5L,1L,1L,5L,4L,3L,0L,3L,4L,7L,7L,7L,7L,7L,7L,6L,2L,2L,0L,2L,2L,6L,9L,5L,3L,1L,1L,3L,5L,9L,8L,5L,4L,1L,0L,1L,4L,5L,8L,11L,11L,11L,3L,1L,1L,3L,11L,11L,11L,10L,4L,6L,3L,2L,0L,2L,3L,6L,4L,10L,13L,9L,7L,13L,13L,1L,1L,13L,13L,7L,9L,13L,12L,7L,8L,7L,4L,7L,0L,7L,4L,7L,8L,7L,12L,15L,15L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106449Inst : IEnumerable<long>
{
public static readonly long[] Value=A106449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106449.Bytes);
public long this[int i]=>Value[i];

public static A106449Inst Instance=new A106449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106450
{
public static readonly long[] Value={ 2L,3L,0L,1L,3L,7L,2L,5L,5L,11L,4L,9L,7L,15L,6L,13L,9L,19L,8L,17L,11L,23L,10L,21L,13L,27L,12L,25L,15L,31L,14L,29L,17L,35L,16L,33L,19L,39L,18L,37L,21L,43L,20L,41L,23L,47L,22L,45L,25L,51L,24L,49L,27L,55L,26L,53L,29L,59L,28L,57L,31L,63L,30L,61L,33L,67L,32L,65L,35L,71L,34L,69L,37L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106450Inst : IEnumerable<long>
{
public static readonly long[] Value=A106450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106450.Bytes);
public long this[int i]=>Value[i];

public static A106450Inst Instance=new A106450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106451
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,5L,4L,7L,11L,15L,9L,12L,23L,10L,16L,8L,19L,29L,65L,40L,14L,24L,67L,13L,197L,66L,30L,26L,25L,43L,626L,20L,2058L,52L,70L,82L,2056L,198L,72L,41L,6918L,38L,628L,68L,33L,203L,23714L,34L,28L,627L,53L,200L,199L,85L,82500L,27L,204L,71L,290512L,124L,1033412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106451Inst : IEnumerable<long>
{
public static readonly long[] Value=A106451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106451.Bytes);
public long this[int i]=>Value[i];

public static A106451Inst Instance=new A106451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106452
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,5L,4L,7L,15L,10L,13L,8L,11L,23L,20L,9L,14L,127L,63L,16L,31L,255L,65535L,12L,21L,28L,27L,55L,48L,17L,26L,191L,95L,44L,47L,383L,98303L,68L,41L,62L,19L,39L,106L,29L,254L,2047L,16383L,84L,511L,4095L,16777215L,272L,33L,50L,2097151L,1023L,256L,32767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106452Inst : IEnumerable<long>
{
public static readonly long[] Value=A106452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106452.Bytes);
public long this[int i]=>Value[i];

public static A106452Inst Instance=new A106452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106453
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,6L,5L,8L,12L,16L,10L,13L,24L,11L,17L,9L,20L,30L,66L,41L,15L,25L,68L,14L,198L,67L,31L,27L,26L,44L,627L,21L,2059L,53L,71L,83L,2057L,199L,73L,42L,6919L,39L,629L,69L,34L,204L,23715L,35L,29L,628L,54L,201L,200L,86L,82501L,28L,205L,72L,290513L,125L,1033413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106453Inst : IEnumerable<long>
{
public static readonly long[] Value=A106453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106453.Bytes);
public long this[int i]=>Value[i];

public static A106453Inst Instance=new A106453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106454
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,6L,5L,8L,16L,11L,14L,9L,12L,24L,21L,10L,15L,128L,64L,17L,32L,256L,65536L,13L,22L,29L,28L,56L,49L,18L,27L,192L,96L,45L,48L,384L,98304L,69L,42L,63L,20L,40L,107L,30L,255L,2048L,16384L,85L,512L,4096L,16777216L,273L,34L,51L,2097152L,1024L,257L,32768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106454Inst : IEnumerable<long>
{
public static readonly long[] Value=A106454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106454.Bytes);
public long this[int i]=>Value[i];

public static A106454Inst Instance=new A106454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106455
{
public static readonly long[] Value={ 0L,2L,10L,12L,50L,44L,42L,52L,178L,204L,170L,180L,682L,172L,210L,56L,226L,716L,2730L,820L,202L,684L,2738L,184L,10922L,2732L,722L,692L,690L,844L,43690L,228L,174770L,908L,2762L,2868L,174762L,10924L,2770L,824L,699050L,812L,43698L,2740L,738L,10956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106455Inst : IEnumerable<long>
{
public static readonly long[] Value=A106455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106455.Bytes);
public long this[int i]=>Value[i];

public static A106455Inst Instance=new A106455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106456
{
public static readonly long[] Value={ 0L,10L,1010L,1100L,110010L,101100L,101010L,110100L,10110010L,11001100L,10101010L,10110100L,1010101010L,10101100L,11010010L,111000L,11100010L,1011001100L,101010101010L,1100110100L,11001010L,1010101100L,101010110010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106456Inst : IEnumerable<long>
{
public static readonly long[] Value=A106456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106456.Bytes);
public long this[int i]=>Value[i];

public static A106456Inst Instance=new A106456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106457
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,5L,4L,4L,3L,4L,5L,6L,5L,4L,5L,6L,4L,7L,6L,5L,5L,5L,5L,8L,4L,9L,5L,6L,6L,9L,7L,6L,5L,10L,5L,8L,6L,5L,7L,11L,5L,5L,8L,5L,7L,7L,6L,12L,5L,7L,6L,13L,6L,14L,9L,5L,4L,6L,10L,15L,6L,5L,7L,15L,6L,16L,10L,7L,8L,14L,7L,8L,6L,6L,11L,6L,6L,5L,9L,17L,6L,13L,6L,18L,8L,9L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106457Inst : IEnumerable<long>
{
public static readonly long[] Value=A106457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106457.Bytes);
public long this[int i]=>Value[i];

public static A106457Inst Instance=new A106457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106458
{
public static readonly long[] Value={ 1L,2L,6L,0L,30L,0L,42L,0L,30L,0L,66L,0L,2730L,0L,6L,0L,510L,0L,798L,0L,330L,0L,138L,0L,2730L,0L,6L,0L,870L,0L,14322L,0L,510L,0L,6L,0L,1919190L,0L,6L,0L,13530L,0L,1806L,0L,690L,0L,282L,0L,46410L,0L,66L,0L,1590L,0L,798L,0L,870L,0L,354L,0L,56786730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106458Inst : IEnumerable<long>
{
public static readonly long[] Value=A106458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106458.Bytes);
public long this[int i]=>Value[i];

public static A106458Inst Instance=new A106458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106459
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106459Inst : IEnumerable<long>
{
public static readonly long[] Value=A106459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106459.Bytes);
public long this[int i]=>Value[i];

public static A106459Inst Instance=new A106459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106460
{
public static readonly long[] Value={ 1L,3L,11L,42L,161L,611L,2298L,8596L,32062L,119413L,444416L,1653314L,6149281L,22868510L,85039306L,316215941L,1175812311L,4372067762L,16256716467L,60447335192L,224760809887L,835725230965L,3107464378235L,11554433256642L,42962649080798L,159747256982142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106460Inst : IEnumerable<long>
{
public static readonly long[] Value=A106460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106460.Bytes);
public long this[int i]=>Value[i];

public static A106460Inst Instance=new A106460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106461
{
public static readonly long[] Value={ 1L,3L,6L,13L,28L,58L,116L,229L,456L,924L,1896L,3898L,7960L,16084L,32168L,63845L,126160L,248968L,491952L,975388L,1943536L,3895336L,7852688L,15906874L,32321264L,65736728L,133549136L,270550228L,545928688L,1096685608L,2193371216L,4369711461L,8679052960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106461Inst : IEnumerable<long>
{
public static readonly long[] Value=A106461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106461.Bytes);
public long this[int i]=>Value[i];

public static A106461Inst Instance=new A106461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106462
{
public static readonly long[] Value={ 1L,2L,4L,8L,17L,37L,79L,165L,344L,728L,1564L,3371L,7206L,15215L,31844L,66558L,139864L,296253L,631147L,1345776L,2858121L,6029016L,12631491L,26344768L,54888571L,114623196L,240410003L,506509217L,1070284645L,2262539843L,4772831688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106462Inst : IEnumerable<long>
{
public static readonly long[] Value=A106462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106462.Bytes);
public long this[int i]=>Value[i];

public static A106462Inst Instance=new A106462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106463
{
public static readonly long[] Value={ 1L,3L,7L,16L,36L,79L,170L,362L,768L,1629L,3458L,7344L,15590L,33039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106463Inst : IEnumerable<long>
{
public static readonly long[] Value=A106463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106463.Bytes);
public long this[int i]=>Value[i];

public static A106463Inst Instance=new A106463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106464
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,4L,6L,6L,5L,11L,6L,9L,15L,12L,8L,18L,9L,21L,22L,15L,11L,32L,20L,18L,27L,31L,14L,45L,15L,32L,36L,24L,41L,57L,18L,27L,43L,60L,20L,66L,21L,51L,72L,33L,23L,84L,42L,60L,57L,61L,26L,81L,67L,88L,64L,42L,29L,135L,30L,45L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106464Inst : IEnumerable<long>
{
public static readonly long[] Value=A106464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106464.Bytes);
public long this[int i]=>Value[i];

public static A106464Inst Instance=new A106464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106465
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106465Inst : IEnumerable<long>
{
public static readonly long[] Value=A106465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106465.Bytes);
public long this[int i]=>Value[i];

public static A106465Inst Instance=new A106465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106466
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,4L,2L,5L,3L,6L,3L,7L,4L,8L,4L,9L,5L,10L,5L,11L,6L,12L,6L,13L,7L,14L,7L,15L,8L,16L,8L,17L,9L,18L,9L,19L,10L,20L,10L,21L,11L,22L,11L,23L,12L,24L,12L,25L,13L,26L,13L,27L,14L,28L,14L,29L,15L,30L,15L,31L,16L,32L,16L,33L,17L,34L,17L,35L,18L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106466Inst : IEnumerable<long>
{
public static readonly long[] Value=A106466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106466.Bytes);
public long this[int i]=>Value[i];

public static A106466Inst Instance=new A106466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106467
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,0L,1L,1L,-1L,-1L,1L,0L,0L,-1L,0L,1L,0L,0L,1L,-1L,-1L,1L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,1L,-1L,-1L,1L,0L,0L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,-1L,-1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,-1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106467Inst : IEnumerable<long>
{
public static readonly long[] Value=A106467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106467.Bytes);
public long this[int i]=>Value[i];

public static A106467Inst Instance=new A106467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106468
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106468Inst : IEnumerable<long>
{
public static readonly long[] Value=A106468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106468.Bytes);
public long this[int i]=>Value[i];

public static A106468Inst Instance=new A106468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106469
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106469Inst : IEnumerable<long>
{
public static readonly long[] Value=A106469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106469.Bytes);
public long this[int i]=>Value[i];

public static A106469Inst Instance=new A106469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106470
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,0L,1L,1L,-1L,-1L,1L,1L,0L,-1L,0L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,0L,1L,0L,-1L,0L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,0L,-1L,0L,1L,0L,-1L,0L,1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,1L,-1L,1L,1L,-1L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106470Inst : IEnumerable<long>
{
public static readonly long[] Value=A106470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106470.Bytes);
public long this[int i]=>Value[i];

public static A106470Inst Instance=new A106470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106471
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,1L,8L,4L,4L,1L,16L,8L,11L,4L,1L,32L,16L,26L,11L,6L,1L,64L,32L,57L,26L,22L,6L,1L,128L,64L,120L,57L,64L,22L,8L,1L,256L,128L,247L,120L,163L,64L,37L,8L,1L,512L,256L,502L,247L,382L,163L,130L,37L,10L,1L,1024L,512L,1013L,502L,848L,382L,386L,130L,56L,10L,1L,2048L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106471Inst : IEnumerable<long>
{
public static readonly long[] Value=A106471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106471.Bytes);
public long this[int i]=>Value[i];

public static A106471Inst Instance=new A106471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106472
{
public static readonly long[] Value={ 1L,3L,7L,17L,40L,92L,208L,464L,1024L,2240L,4864L,10496L,22528L,48128L,102400L,217088L,458752L,966656L,2031616L,4259840L,8912896L,18612224L,38797312L,80740352L,167772160L,348127232L,721420288L,1493172224L,3087007744L,6375342080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106472Inst : IEnumerable<long>
{
public static readonly long[] Value=A106472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106472.Bytes);
public long this[int i]=>Value[i];

public static A106472Inst Instance=new A106472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106473
{
public static readonly long[] Value={ 1L,11L,121L,1111L,12321L,111111L,1214121L,11311311L,121252121L,1111111111L,12341614321L,111111111111L,1212127212121L,11315311351311L,121412181214121L,1111111111111111L,12321612921612321L,111111111111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106473Inst : IEnumerable<long>
{
public static readonly long[] Value=A106473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106473.Bytes);
public long this[int i]=>Value[i];

public static A106473Inst Instance=new A106473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106474
{
public static readonly long[] Value={ 1L,3L,7L,8L,13L,19L,19L,20L,33L,35L,31L,48L,37L,51L,75L,48L,49L,87L,55L,88L,109L,83L,67L,116L,105L,99L,135L,128L,85L,195L,91L,112L,177L,131L,199L,216L,109L,147L,211L,212L,121L,283L,127L,208L,333L,179L,139L,272L,217L,275L,279L,248L,157L,351L,323L,308L,313L,227L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106474Inst : IEnumerable<long>
{
public static readonly long[] Value=A106474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106474.Bytes);
public long this[int i]=>Value[i];

public static A106474Inst Instance=new A106474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106475
{
public static readonly long[] Value={ 1L,0L,1L,-4L,1L,-8L,1L,-16L,-3L,-16L,1L,-36L,1L,-24L,-15L,-48L,1L,-48L,1L,-68L,-23L,-40L,1L,-112L,-15L,-48L,-27L,-100L,1L,-120L,1L,-128L,-39L,-64L,-47L,-180L,1L,-72L,-47L,-208L,1L,-176L,1L,-164L,-99L,-88L,1L,-304L,-35L,-160L,-63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106475Inst : IEnumerable<long>
{
public static readonly long[] Value=A106475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106475.Bytes);
public long this[int i]=>Value[i];

public static A106475Inst Instance=new A106475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106476
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,4L,2L,2L,1L,1L,2L,4L,2L,2L,1L,1L,6L,2L,4L,2L,2L,1L,1L,4L,6L,2L,4L,2L,2L,1L,1L,6L,4L,6L,2L,4L,2L,2L,1L,1L,4L,6L,4L,6L,2L,4L,2L,2L,1L,1L,10L,4L,6L,4L,6L,2L,4L,2L,2L,1L,1L,4L,10L,4L,6L,4L,6L,2L,4L,2L,2L,1L,1L,12L,4L,10L,4L,6L,4L,6L,2L,4L,2L,2L,1L,1L,6L,12L,4L,10L,4L,6L,4L,6L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106476Inst : IEnumerable<long>
{
public static readonly long[] Value=A106476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106476.Bytes);
public long this[int i]=>Value[i];

public static A106476Inst Instance=new A106476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106477
{
public static readonly long[] Value={ 1L,1L,3L,3L,7L,5L,13L,9L,19L,13L,29L,17L,41L,23L,49L,31L,65L,37L,83L,45L,95L,55L,117L,63L,137L,75L,155L,87L,183L,95L,213L,111L,233L,127L,257L,139L,293L,157L,317L,173L,357L,185L,399L,205L,423L,227L,469L,243L,511L,263L,543L,287L,595L,305L,635L,329L,671L,357L,729L,373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106477Inst : IEnumerable<long>
{
public static readonly long[] Value=A106477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106477.Bytes);
public long this[int i]=>Value[i];

public static A106477Inst Instance=new A106477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106478
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,3L,-1L,1L,-1L,-1L,1L,-3L,3L,-1L,1L,-1L,-1L,1L,-1L,-3L,3L,-1L,1L,-1L,-1L,1L,7L,-1L,-3L,3L,-1L,1L,-1L,-1L,1L,-9L,7L,-1L,-3L,3L,-1L,1L,-1L,-1L,1L,5L,-9L,7L,-1L,-3L,3L,-1L,1L,-1L,-1L,1L,-1L,5L,-9L,7L,-1L,-3L,3L,-1L,1L,-1L,-1L,1L,-7L,-1L,5L,-9L,7L,-1L,-3L,3L,-1L,1L,-1L,-1L,1L,25L,-7L,-1L,5L,-9L,7L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106478Inst : IEnumerable<long>
{
public static readonly long[] Value=A106478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106478.Bytes);
public long this[int i]=>Value[i];

public static A106478Inst Instance=new A106478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106479
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,-1L,3L,-3L,-1L,7L,-9L,5L,-1L,-7L,25L,-27L,-3L,29L,-41L,55L,-25L,-73L,161L,-143L,-11L,217L,-387L,447L,-99L,-737L,1377L,-1219L,209L,1761L,-3999L,4357L,-1087L,-5311L,11463L,-12475L,4723L,12705L,-33133L,38839L,-15005L,-35001L,90485L,-112395L,54269L,92435L,-262555L,328759L,-165839L,-244533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106479Inst : IEnumerable<long>
{
public static readonly long[] Value=A106479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106479.Bytes);
public long this[int i]=>Value[i];

public static A106479Inst Instance=new A106479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106480
{
public static readonly long[] Value={ 1L,0L,-1L,0L,-1L,2L,-1L,-2L,5L,-4L,1L,0L,-7L,18L,-9L,-12L,17L,-24L,31L,6L,-67L,94L,-49L,-60L,157L,-230L,217L,118L,-619L,758L,-461L,-252L,1509L,-2490L,1867L,780L,-4531L,6932L,-5543L,-820L,11885L,-21248L,17591L,2586L,-32415L,58070L,-54325L,-56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106480Inst : IEnumerable<long>
{
public static readonly long[] Value=A106480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106480.Bytes);
public long this[int i]=>Value[i];

public static A106480Inst Instance=new A106480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106481
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,7L,5L,13L,9L,19L,13L,29L,17L,41L,23L,49L,31L,65L,37L,83L,45L,95L,55L,117L,63L,137L,75L,155L,87L,183L,95L,213L,111L,233L,127L,257L,139L,293L,157L,317L,173L,357L,185L,399L,205L,423L,227L,469L,243L,511L,263L,543L,287L,595L,305L,635L,329L,671L,357L,729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106481Inst : IEnumerable<long>
{
public static readonly long[] Value=A106481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106481.Bytes);
public long this[int i]=>Value[i];

public static A106481Inst Instance=new A106481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106482
{
public static readonly long[] Value={ 0L,0L,2L,2L,3L,3L,3L,2L,4L,4L,3L,2L,5L,2L,4L,3L,6L,2L,4L,3L,5L,3L,3L,3L,5L,3L,4L,5L,4L,3L,5L,3L,7L,4L,3L,4L,5L,4L,3L,3L,6L,2L,4L,2L,6L,4L,3L,3L,7L,3L,4L,4L,4L,3L,8L,4L,5L,4L,5L,2L,6L,3L,3L,4L,7L,5L,5L,3L,5L,3L,5L,3L,7L,2L,4L,5L,4L,4L,5L,3L,6L,5L,5L,3L,6L,3L,4L,3L,6L,4L,6L,3L,4L,5L,4L,3L,8L,3L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106482Inst : IEnumerable<long>
{
public static readonly long[] Value=A106482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106482.Bytes);
public long this[int i]=>Value[i];

public static A106482Inst Instance=new A106482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106483
{
public static readonly long[] Value={ 2L,3L,7L,11L,13L,17L,41L,43L,59L,73L,109L,113L,127L,137L,157L,179L,181L,197L,199L,211L,251L,263L,277L,293L,311L,353L,367L,379L,409L,419L,433L,487L,563L,571L,577L,617L,619L,659L,701L,739L,743L,757L,797L,811L,827L,829L,839L,857L,937L,941L,1009L,1039L,1063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106483Inst : IEnumerable<long>
{
public static readonly long[] Value=A106483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106483.Bytes);
public long this[int i]=>Value[i];

public static A106483Inst Instance=new A106483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106484
{
public static readonly BigInteger[] Value={ 2L,14L,5474L,328053267374L,BigInteger.Parse("70609493887317824553444331216711874"),BigInteger.Parse("704075595895578790602913140874091028795793004193695613020210569466609876113017694526357948165550233559374") };
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
public class A106484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106484Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A106484.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A106484.Bytes);
public BigInteger this[int i]=>Value[i];

public static A106484Inst Instance=new A106484Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106485
{
public static readonly long[] Value={ 0L,2L,1L,3L,32L,34L,33L,35L,16L,18L,17L,19L,48L,50L,49L,51L,8L,10L,9L,11L,40L,42L,41L,43L,24L,26L,25L,27L,56L,58L,57L,59L,4L,6L,5L,7L,36L,38L,37L,39L,20L,22L,21L,23L,52L,54L,53L,55L,12L,14L,13L,15L,44L,46L,45L,47L,28L,30L,29L,31L,60L,62L,61L,63L,128L,130L,129L,131L,160L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106485Inst : IEnumerable<long>
{
public static readonly long[] Value=A106485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106485.Bytes);
public long this[int i]=>Value[i];

public static A106485Inst Instance=new A106485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106486
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,4L,2L,3L,3L,4L,4L,5L,5L,6L,2L,3L,3L,4L,4L,5L,5L,6L,4L,5L,5L,6L,6L,7L,7L,8L,2L,3L,3L,4L,4L,5L,5L,6L,4L,5L,5L,6L,6L,7L,7L,8L,4L,5L,5L,6L,6L,7L,7L,8L,6L,7L,7L,8L,8L,9L,9L,10L,3L,4L,4L,5L,5L,6L,6L,7L,5L,6L,6L,7L,7L,8L,8L,9L,5L,6L,6L,7L,7L,8L,8L,9L,7L,8L,8L,9L,9L,10L,10L,11L,5L,6L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106486Inst : IEnumerable<long>
{
public static readonly long[] Value=A106486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106486.Bytes);
public long this[int i]=>Value[i];

public static A106486Inst Instance=new A106486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106487
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,3L,1L,2L,2L,3L,2L,3L,3L,4L,1L,2L,2L,3L,2L,3L,3L,4L,2L,3L,3L,4L,3L,4L,4L,5L,1L,2L,2L,3L,2L,3L,3L,4L,2L,3L,3L,4L,3L,4L,4L,5L,2L,3L,3L,4L,3L,4L,4L,5L,3L,4L,4L,5L,4L,5L,5L,6L,2L,3L,3L,4L,3L,4L,4L,5L,3L,4L,4L,5L,4L,5L,5L,6L,3L,4L,4L,5L,4L,5L,5L,6L,4L,5L,5L,6L,5L,6L,6L,7L,3L,4L,4L,5L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106487Inst : IEnumerable<long>
{
public static readonly long[] Value=A106487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106487.Bytes);
public long this[int i]=>Value[i];

public static A106487Inst Instance=new A106487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106488
{
public static readonly long[] Value={ 641L,1788L,1918L,3731L,7093L,8009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106488Inst : IEnumerable<long>
{
public static readonly long[] Value=A106488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106488.Bytes);
public long this[int i]=>Value[i];

public static A106488Inst Instance=new A106488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106489
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,9L,5L,1L,21L,12L,3L,51L,30L,9L,1L,127L,76L,25L,4L,323L,196L,69L,14L,1L,835L,512L,189L,44L,5L,2188L,1353L,518L,133L,20L,1L,5798L,3610L,1422L,392L,70L,6L,15511L,9713L,3915L,1140L,230L,27L,1L,41835L,26324L,10813L,3288L,726L,104L,7L,113634L,71799L,29964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106489Inst : IEnumerable<long>
{
public static readonly long[] Value=A106489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106489.Bytes);
public long this[int i]=>Value[i];

public static A106489Inst Instance=new A106489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106490
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,2L,2L,2L,1L,3L,1L,2L,2L,3L,1L,3L,1L,3L,2L,2L,1L,3L,2L,2L,2L,3L,1L,3L,1L,2L,2L,2L,2L,4L,1L,2L,2L,3L,1L,3L,1L,3L,3L,2L,1L,4L,2L,3L,2L,3L,1L,3L,2L,3L,2L,2L,1L,4L,1L,2L,3L,3L,2L,3L,1L,3L,2L,3L,1L,4L,1L,2L,3L,3L,2L,3L,1L,4L,3L,2L,1L,4L,2L,2L,2L,3L,1L,4L,2L,3L,2L,2L,2L,3L,1L,3L,3L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106490Inst : IEnumerable<long>
{
public static readonly long[] Value=A106490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106490.Bytes);
public long this[int i]=>Value[i];

public static A106490Inst Instance=new A106490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106491
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,2L,3L,3L,4L,2L,5L,2L,4L,4L,4L,2L,5L,2L,5L,4L,4L,2L,5L,3L,4L,3L,5L,2L,6L,2L,3L,4L,4L,4L,6L,2L,4L,4L,5L,2L,6L,2L,5L,5L,4L,2L,6L,3L,5L,4L,5L,2L,5L,4L,5L,4L,4L,2L,7L,2L,4L,5L,5L,4L,6L,2L,5L,4L,6L,2L,6L,2L,4L,5L,5L,4L,6L,2L,6L,4L,4L,2L,7L,4L,4L,4L,5L,2L,7L,4L,5L,4L,4L,4L,5L,2L,5L,5L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106491Inst : IEnumerable<long>
{
public static readonly long[] Value=A106491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106491.Bytes);
public long this[int i]=>Value[i];

public static A106491Inst Instance=new A106491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106492
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,5L,7L,5L,5L,7L,11L,7L,13L,9L,8L,6L,17L,7L,19L,9L,10L,13L,23L,8L,7L,15L,6L,11L,29L,10L,31L,7L,14L,19L,12L,9L,37L,21L,16L,10L,41L,12L,43L,15L,10L,25L,47L,9L,9L,9L,20L,17L,53L,8L,16L,12L,22L,31L,59L,12L,61L,33L,12L,7L,18L,16L,67L,21L,26L,14L,71L,10L,73L,39L,10L,23L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106492Inst : IEnumerable<long>
{
public static readonly long[] Value=A106492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106492.Bytes);
public long this[int i]=>Value[i];

public static A106492Inst Instance=new A106492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106493
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,1L,2L,2L,3L,1L,3L,1L,2L,2L,3L,3L,3L,1L,4L,2L,2L,2L,3L,1L,2L,3L,3L,2L,3L,1L,3L,2L,4L,2L,4L,1L,2L,3L,4L,1L,3L,2L,3L,3L,3L,1L,4L,2L,2L,3L,3L,2L,4L,1L,3L,3L,3L,1L,4L,1L,2L,3L,3L,4L,3L,1L,5L,2L,3L,2L,4L,1L,2L,3L,3L,2L,4L,2L,5L,2L,2L,3L,4L,3L,3L,1L,3L,2L,4L,1L,4L,2L,2L,3L,4L,1L,3L,3L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106493Inst : IEnumerable<long>
{
public static readonly long[] Value=A106493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106493.Bytes);
public long this[int i]=>Value[i];

public static A106493Inst Instance=new A106493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106494
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,2L,3L,4L,5L,2L,5L,2L,4L,3L,4L,4L,6L,2L,6L,3L,4L,4L,5L,2L,4L,5L,5L,4L,5L,2L,4L,4L,6L,4L,7L,2L,4L,5L,6L,2L,5L,4L,5L,5L,6L,2L,6L,4L,4L,4L,5L,4L,7L,2L,5L,5L,6L,2L,6L,2L,4L,5L,5L,6L,6L,2L,7L,3L,6L,4L,7L,2L,4L,5L,5L,4L,7L,4L,7L,3L,4L,6L,6L,5L,6L,2L,5L,4L,7L,2L,7L,4L,4L,5L,6L,2L,6L,5L,5L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106494Inst : IEnumerable<long>
{
public static readonly long[] Value=A106494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106494.Bytes);
public long this[int i]=>Value[i];

public static A106494Inst Instance=new A106494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106495
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,1L,1L,1L,3L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,1L,2L,2L,2L,3L,1L,2L,2L,2L,1L,2L,2L,2L,2L,3L,1L,2L,2L,2L,1L,2L,2L,3L,1L,2L,2L,3L,1L,2L,1L,2L,2L,2L,2L,3L,1L,2L,1L,3L,2L,3L,1L,2L,2L,2L,2L,3L,2L,2L,1L,2L,3L,2L,2L,3L,1L,2L,2L,3L,1L,3L,2L,2L,2L,2L,1L,3L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106495Inst : IEnumerable<long>
{
public static readonly long[] Value=A106495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106495.Bytes);
public long this[int i]=>Value[i];

public static A106495Inst Instance=new A106495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106496
{
public static readonly long[] Value={ 1L,3L,6L,13L,29L,62L,128L,263L,547L,1148L,2403L,4977L,10196L,20763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106496Inst : IEnumerable<long>
{
public static readonly long[] Value=A106496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106496.Bytes);
public long this[int i]=>Value[i];

public static A106496Inst Instance=new A106496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106497
{
public static readonly BigInteger[] Value={ 36363636364L,45454545455L,54545454546L,63636363637L,72727272728L,81818181819L,90909090910L,BigInteger.Parse("428571428571428571429"),BigInteger.Parse("571428571428571428572"),BigInteger.Parse("714285714285714285715"),BigInteger.Parse("857142857142857142858") };
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
public class A106497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106497Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A106497.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A106497.Bytes);
public BigInteger this[int i]=>Value[i];

public static A106497Inst Instance=new A106497Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106498
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,4L,5L,5L,4L,2L,1L,1L,1L,1L,2L,4L,10L,13L,23L,26L,32L,26L,23L,13L,10L,4L,2L,1L,1L,1L,1L,2L,4L,10L,20L,39L,72L,128L,198L,280L,353L,399L,399L,353L,280L,198L,128L,72L,39L,20L,10L,4L,2L,1L,1L,1L,1L,2L,4L,10L,20L,50L,99L,227L,458L,934L,1711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106498Inst : IEnumerable<long>
{
public static readonly long[] Value=A106498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106498.Bytes);
public long this[int i]=>Value[i];

public static A106498Inst Instance=new A106498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106499
{
public static readonly long[] Value={ 15L,28L,40L,45L,66L,77L,84L,91L,104L,120L,126L,144L,153L,170L,187L,190L,198L,209L,220L,228L,231L,260L,273L,276L,286L,299L,312L,322L,325L,345L,350L,378L,390L,400L,420L,432L,435L,442L,459L,464L,476L,493L,496L,510L,522L,527L,544L,551L,558L,561L,570L,589L,608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106499Inst : IEnumerable<long>
{
public static readonly long[] Value=A106499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106499.Bytes);
public long this[int i]=>Value[i];

public static A106499Inst Instance=new A106499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106500
{
public static readonly long[] Value={ 2L,3L,3L,4L,5L,4L,5L,6L,5L,7L,5L,7L,8L,7L,6L,9L,7L,8L,9L,7L,10L,7L,8L,11L,9L,10L,11L,9L,12L,8L,11L,13L,11L,9L,13L,11L,14L,9L,10L,13L,11L,12L,15L,13L,11L,14L,15L,10L,13L,16L,11L,12L,13L,11L,14L,17L,15L,13L,16L,11L,17L,18L,13L,17L,13L,16L,19L,17L,12L,15L,13L,19L,14L,17L,20L,15L,13L,16L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106500Inst : IEnumerable<long>
{
public static readonly long[] Value=A106500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106500.Bytes);
public long this[int i]=>Value[i];

public static A106500Inst Instance=new A106500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106501
{
public static readonly long[] Value={ 3L,4L,5L,5L,6L,7L,7L,7L,8L,8L,9L,9L,9L,10L,11L,10L,11L,11L,11L,12L,11L,13L,13L,12L,13L,13L,13L,14L,13L,15L,14L,14L,15L,16L,15L,16L,15L,17L,17L,16L,17L,17L,16L,17L,18L,17L,17L,19L,18L,17L,19L,19L,19L,20L,19L,18L,19L,20L,19L,21L,19L,19L,21L,20L,22L,21L,20L,21L,23L,22L,23L,21L,23L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106501Inst : IEnumerable<long>
{
public static readonly long[] Value=A106501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106501.Bytes);
public long this[int i]=>Value[i];

public static A106501Inst Instance=new A106501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106502
{
public static readonly long[] Value={ 4L,7L,9L,9L,11L,16L,24L,13L,25L,15L,25L,32L,17L,49L,36L,19L,49L,57L,40L,49L,21L,49L,64L,23L,81L,69L,48L,81L,25L,64L,75L,27L,104L,81L,56L,121L,29L,81L,100L,87L,121L,144L,31L,120L,121L,93L,64L,100L,155L,33L,121L,144L,169L,121L,165L,35L,136L,169L,105L,121L,72L,37L,169L,111L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106502Inst : IEnumerable<long>
{
public static readonly long[] Value=A106502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106502.Bytes);
public long this[int i]=>Value[i];

public static A106502Inst Instance=new A106502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106503
{
public static readonly long[] Value={ 5L,9L,15L,16L,25L,28L,25L,36L,39L,49L,45L,49L,64L,51L,66L,81L,72L,64L,81L,84L,100L,91L,104L,121L,88L,100L,121L,115L,144L,120L,121L,169L,121L,144L,169L,135L,196L,153L,170L,169L,168L,145L,225L,169L,198L,196L,225L,190L,169L,256L,209L,217L,192L,220L,196L,289L,225L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106503Inst : IEnumerable<long>
{
public static readonly long[] Value=A106503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106503.Bytes);
public long this[int i]=>Value[i];

public static A106503Inst Instance=new A106503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106504
{
public static readonly long[] Value={ 6L,12L,16L,20L,30L,33L,35L,42L,40L,56L,56L,63L,72L,70L,85L,90L,77L,88L,99L,95L,110L,120L,105L,132L,117L,130L,143L,126L,156L,161L,154L,182L,165L,175L,195L,176L,210L,208L,189L,208L,187L,204L,240L,221L,203L,238L,255L,261L,234L,272L,240L,228L,247L,279L,266L,306L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106504Inst : IEnumerable<long>
{
public static readonly long[] Value=A106504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106504.Bytes);
public long this[int i]=>Value[i];

public static A106504Inst Instance=new A106504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106505
{
public static readonly long[] Value={ 5L,7L,9L,11L,13L,15L,16L,17L,19L,21L,23L,24L,25L,27L,29L,31L,32L,33L,35L,37L,39L,40L,41L,43L,45L,47L,48L,49L,51L,53L,55L,56L,57L,59L,61L,63L,64L,65L,67L,69L,71L,72L,73L,75L,77L,79L,80L,81L,83L,85L,87L,88L,89L,91L,93L,95L,96L,97L,99L,101L,103L,104L,105L,107L,109L,111L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106505Inst : IEnumerable<long>
{
public static readonly long[] Value=A106505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106505.Bytes);
public long this[int i]=>Value[i];

public static A106505Inst Instance=new A106505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106506
{
public static readonly long[] Value={ 5L,7L,16L,9L,11L,33L,24L,13L,39L,15L,56L,32L,17L,51L,85L,19L,72L,57L,40L,95L,21L,120L,105L,23L,88L,69L,48L,115L,25L,161L,75L,27L,104L,175L,56L,135L,29L,208L,189L,87L,168L,145L,31L,120L,203L,93L,64L,261L,155L,33L,240L,217L,192L,279L,165L,35L,136L,231L,105L,320L,72L,37L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106506Inst : IEnumerable<long>
{
public static readonly long[] Value=A106506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106506.Bytes);
public long this[int i]=>Value[i];

public static A106506Inst Instance=new A106506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106507
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,3L,-4L,5L,-7L,10L,-13L,16L,-21L,28L,-35L,43L,-55L,70L,-86L,105L,-130L,161L,-196L,236L,-287L,350L,-420L,501L,-602L,722L,-858L,1016L,-1206L,1431L,-1687L,1981L,-2331L,2741L,-3206L,3740L,-4368L,5096L,-5922L,6868L,-7967L,9233L,-10670L,12306L,-14193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106507Inst : IEnumerable<long>
{
public static readonly long[] Value=A106507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106507.Bytes);
public long this[int i]=>Value[i];

public static A106507Inst Instance=new A106507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106508
{
public static readonly long[] Value={ 1L,4L,4L,0L,2L,0L,-8L,0L,-5L,-16L,4L,0L,-10L,0L,-8L,0L,9L,8L,0L,0L,14L,0L,16L,0L,-10L,32L,4L,0L,0L,0L,8L,0L,14L,-20L,-20L,0L,2L,0L,0L,0L,-11L,-16L,-20L,0L,-32L,0L,16L,0L,0L,-40L,4L,0L,14L,0L,-8L,0L,-9L,32L,-20L,0L,26L,0L,0L,0L,2L,36L,28L,0L,0L,0L,16L,0L,16L,0L,28L,0L,-22L,0L,0L,0L,14L,56L,-16L,0L,0L,0L,-40L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106508Inst : IEnumerable<long>
{
public static readonly long[] Value=A106508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106508.Bytes);
public long this[int i]=>Value[i];

public static A106508Inst Instance=new A106508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106509
{
public static readonly long[] Value={ 1L,0L,1L,-1L,-1L,1L,1L,0L,-2L,1L,0L,1L,2L,-3L,1L,-1L,-1L,-1L,5L,-4L,1L,1L,0L,0L,-6L,9L,-5L,1L,0L,1L,0L,6L,-15L,14L,-6L,1L,-1L,-1L,1L,-6L,21L,-29L,20L,-7L,1L,1L,0L,-2L,7L,-27L,50L,-49L,27L,-8L,1L,0L,1L,2L,-9L,34L,-77L,99L,-76L,35L,-9L,1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106509Inst : IEnumerable<long>
{
public static readonly long[] Value=A106509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106509.Bytes);
public long this[int i]=>Value[i];

public static A106509Inst Instance=new A106509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106510
{
public static readonly long[] Value={ 1L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106510Inst : IEnumerable<long>
{
public static readonly long[] Value=A106510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106510.Bytes);
public long this[int i]=>Value[i];

public static A106510Inst Instance=new A106510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106511
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,-2L,3L,-4L,6L,-10L,17L,-28L,45L,-72L,116L,-188L,305L,-494L,799L,-1292L,2090L,-3382L,5473L,-8856L,14329L,-23184L,37512L,-60696L,98209L,-158906L,257115L,-416020L,673134L,-1089154L,1762289L,-2851444L,4613733L,-7465176L,12078908L,-19544084L,31622993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106511Inst : IEnumerable<long>
{
public static readonly long[] Value=A106511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106511.Bytes);
public long this[int i]=>Value[i];

public static A106511Inst Instance=new A106511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106512
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,6L,0L,0L,0L,12L,6L,2L,0L,0L,20L,24L,18L,0L,0L,0L,30L,60L,84L,30L,2L,0L,0L,42L,120L,260L,240L,66L,0L,0L,0L,56L,210L,630L,1020L,732L,126L,2L,0L,0L,72L,336L,1302L,3120L,4100L,2184L,258L,0L,0L,0L,90L,504L,2408L,7770L,15630L,16380L,6564L,510L,2L,0L,0L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106512Inst : IEnumerable<long>
{
public static readonly long[] Value=A106512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106512.Bytes);
public long this[int i]=>Value[i];

public static A106512Inst Instance=new A106512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106513
{
public static readonly long[] Value={ 1L,2L,1L,5L,3L,1L,12L,8L,4L,1L,29L,20L,12L,5L,1L,70L,49L,32L,17L,6L,1L,169L,119L,81L,49L,23L,7L,1L,408L,288L,200L,130L,72L,30L,8L,1L,985L,696L,488L,330L,202L,102L,38L,9L,1L,2378L,1681L,1184L,818L,532L,304L,140L,47L,10L,1L,5741L,4059L,2865L,2002L,1350L,836L,444L,187L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106513Inst : IEnumerable<long>
{
public static readonly long[] Value=A106513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106513.Bytes);
public long this[int i]=>Value[i];

public static A106513Inst Instance=new A106513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106514
{
public static readonly long[] Value={ 1L,3L,9L,25L,67L,175L,449L,1137L,2851L,7095L,17553L,43225L,106051L,259423L,633089L,1541985L,3749827L,9107175L,22095249L,53559817L,129739171L,314086735L,760009793L,1838300625L,4444999651L,10745077143L,25968708369L,62749602745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106514Inst : IEnumerable<long>
{
public static readonly long[] Value=A106514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106514.Bytes);
public long this[int i]=>Value[i];

public static A106514Inst Instance=new A106514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106515
{
public static readonly long[] Value={ 1L,2L,6L,15L,38L,94L,231L,564L,1372L,3329L,8064L,19512L,47177L,114010L,275430L,665247L,1606534L,3879302L,9366735L,22615356L,54601628L,131825377L,318263328L,768369744L,1855031473L,4478479058L,10812064614L,26102729679L,63017720390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106515Inst : IEnumerable<long>
{
public static readonly long[] Value=A106515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106515.Bytes);
public long this[int i]=>Value[i];

public static A106515Inst Instance=new A106515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106516
{
public static readonly long[] Value={ 1L,3L,1L,9L,4L,1L,27L,13L,5L,1L,81L,40L,18L,6L,1L,243L,121L,58L,24L,7L,1L,729L,364L,179L,82L,31L,8L,1L,2187L,1093L,543L,261L,113L,39L,9L,1L,6561L,3280L,1636L,804L,374L,152L,48L,10L,1L,19683L,9841L,4916L,2440L,1178L,526L,200L,58L,11L,1L,59049L,29524L,14757L,7356L,3618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106516Inst : IEnumerable<long>
{
public static readonly long[] Value=A106516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106516.Bytes);
public long this[int i]=>Value[i];

public static A106516Inst Instance=new A106516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106517
{
public static readonly long[] Value={ 1L,3L,10L,31L,95L,288L,869L,2615L,7858L,23595L,70819L,212512L,637625L,1913019L,5739290L,17218247L,51655351L,154967040L,464902717L,1394710735L,4184136386L,12552415923L,37657258715L,112971793856L,338915410225L,1016746277043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106517Inst : IEnumerable<long>
{
public static readonly long[] Value=A106517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106517.Bytes);
public long this[int i]=>Value[i];

public static A106517Inst Instance=new A106517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106518
{
public static readonly long[] Value={ 2L,10L,11L,12L,15L,16L,20L,22L,25L,26L,32L,38L,41L,42L,46L,67L,72L,82L,86L,91L,95L,100L,101L,102L,103L,105L,107L,110L,111L,112L,113L,115L,116L,120L,121L,122L,123L,124L,125L,130L,131L,132L,134L,136L,138L,141L,142L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106518Inst : IEnumerable<long>
{
public static readonly long[] Value=A106518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106518.Bytes);
public long this[int i]=>Value[i];

public static A106518Inst Instance=new A106518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106519
{
public static readonly long[] Value={ 1L,1L,2L,3L,9L,19L,58L,160L,499L,1527L,4940L,16001L,53187L,178305L,606330L,2079863L,7203864L,25138879L,88367780L,312577245L,1112119079L,3977502767L,14294207172L,51596165898L,186998138529L,680272336906L,2483341820512L,9094756956909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106519Inst : IEnumerable<long>
{
public static readonly long[] Value=A106519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106519.Bytes);
public long this[int i]=>Value[i];

public static A106519Inst Instance=new A106519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106520
{
public static readonly long[] Value={ 2L,4L,18L,48L,156L,472L,1526L,4852L,16000L,52940L,178276L,605520L,2079862L,7201084L,25138878L,88358520L,312576996L,1112087012L,3977502766L,14294093652L,51596165872L,186997738504L,680272334202L,2483340387644L,9094756956908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106520Inst : IEnumerable<long>
{
public static readonly long[] Value=A106520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106520.Bytes);
public long this[int i]=>Value[i];

public static A106520Inst Instance=new A106520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106521
{
public static readonly long[] Value={ 18L,38L,456L,854L,9192L,17132L,183474L,341876L,3660378L,6820478L,73024176L,136067774L,1456823232L,2714535092L,29063440554L,54154634156L,579811987938L,1080378148118L,11567176318296L,21553408328294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106521Inst : IEnumerable<long>
{
public static readonly long[] Value=A106521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106521.Bytes);
public long this[int i]=>Value[i];

public static A106521Inst Instance=new A106521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106522
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,4L,4L,3L,1L,7L,8L,7L,4L,1L,13L,15L,15L,11L,5L,1L,24L,28L,30L,26L,16L,6L,1L,44L,52L,58L,56L,42L,22L,7L,1L,81L,96L,110L,114L,98L,64L,29L,8L,1L,149L,177L,206L,224L,212L,162L,93L,37L,9L,1L,274L,326L,383L,430L,436L,374L,255L,130L,46L,10L,1L,504L,600L,709L,813L,866L,810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106522Inst : IEnumerable<long>
{
public static readonly long[] Value=A106522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106522.Bytes);
public long this[int i]=>Value[i];

public static A106522Inst Instance=new A106522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106523
{
public static readonly long[] Value={ 1L,1L,3L,4L,10L,14L,33L,49L,109L,170L,362L,586L,1207L,2011L,4037L,6878L,13536L,23464L,45475L,79891L,153011L,271612L,515460L,922372L,1738101L,3129565L,5865063L,10611336L,19802382L,35960970L,66888917L,121820229L,226016385L,412547222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106523Inst : IEnumerable<long>
{
public static readonly long[] Value=A106523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106523.Bytes);
public long this[int i]=>Value[i];

public static A106523Inst Instance=new A106523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106524
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,6L,1L,2L,3L,6L,3L,6L,7L,14L,1L,2L,3L,6L,3L,6L,7L,14L,3L,6L,7L,14L,7L,14L,15L,30L,1L,2L,3L,6L,3L,6L,7L,14L,3L,6L,7L,14L,7L,14L,15L,30L,3L,6L,7L,14L,7L,14L,15L,30L,7L,14L,15L,30L,15L,30L,31L,62L,1L,2L,3L,6L,3L,6L,7L,14L,3L,6L,7L,14L,7L,14L,15L,30L,3L,6L,7L,14L,7L,14L,15L,30L,7L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106524Inst : IEnumerable<long>
{
public static readonly long[] Value=A106524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106524.Bytes);
public long this[int i]=>Value[i];

public static A106524Inst Instance=new A106524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106525
{
public static readonly long[] Value={ 9L,11L,21L,43L,57L,119L,249L,331L,693L,1451L,1929L,4039L,8457L,11243L,23541L,49291L,65529L,137207L,287289L,381931L,799701L,1674443L,2226057L,4660999L,9759369L,12974411L,27166293L,56881771L,75620409L,158336759L,331531257L,440748043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106525Inst : IEnumerable<long>
{
public static readonly long[] Value=A106525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106525.Bytes);
public long this[int i]=>Value[i];

public static A106525Inst Instance=new A106525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106526
{
public static readonly long[] Value={ 4L,6L,14L,30L,40L,84L,176L,234L,490L,1026L,1364L,2856L,5980L,7950L,16646L,34854L,46336L,97020L,203144L,270066L,565474L,1184010L,1574060L,3295824L,6900916L,9174294L,19209470L,40221486L,53471704L,111960996L,234428000L,311655930L,652556506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106526Inst : IEnumerable<long>
{
public static readonly long[] Value=A106526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106526.Bytes);
public long this[int i]=>Value[i];

public static A106526Inst Instance=new A106526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106527
{
public static readonly long[] Value={ 19L,33L,51L,81L,179L,289L,467L,1041L,1683L,2721L,6067L,9809L,15859L,35361L,57171L,92433L,206099L,333217L,538739L,1201233L,1942131L,3140001L,7001299L,11319569L,18301267L,40806561L,65975283L,106667601L,237838067L,384532129L,621704339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106527Inst : IEnumerable<long>
{
public static readonly long[] Value=A106527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106527.Bytes);
public long this[int i]=>Value[i];

public static A106527Inst Instance=new A106527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106528
{
public static readonly long[] Value={ 6L,20L,34L,56L,126L,204L,330L,736L,1190L,1924L,4290L,6936L,11214L,25004L,40426L,65360L,145734L,235620L,380946L,849400L,1373294L,2220316L,4950666L,8004144L,12940950L,28854596L,46651570L,75425384L,168176910L,271905276L,439611354L,980206864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106528Inst : IEnumerable<long>
{
public static readonly long[] Value=A106528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106528.Bytes);
public long this[int i]=>Value[i];

public static A106528Inst Instance=new A106528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106529
{
public static readonly long[] Value={ 2L,6L,9L,20L,30L,45L,50L,56L,75L,84L,125L,126L,140L,176L,189L,196L,210L,264L,294L,315L,350L,396L,416L,440L,441L,490L,525L,594L,616L,624L,660L,686L,735L,875L,891L,924L,936L,968L,990L,1029L,1040L,1088L,1100L,1225L,1386L,1404L,1452L,1456L,1485L,1540L,1560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106529Inst : IEnumerable<long>
{
public static readonly long[] Value=A106529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106529.Bytes);
public long this[int i]=>Value[i];

public static A106529Inst Instance=new A106529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106530
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,5L,10L,8L,8L,8L,24L,24L,13L,13L,26L,39L,39L,65L,65L,130L,21L,21L,42L,21L,21L,105L,105L,210L,168L,168L,168L,168L,168L,34L,34L,34L,102L,102L,170L,170L,170L,136L,136L,136L,408L,408L,442L,442L,442L,1326L,1326L,2210L,2210L,2210L,55L,55L,110L,165L,165L,55L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106530Inst : IEnumerable<long>
{
public static readonly long[] Value=A106530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106530.Bytes);
public long this[int i]=>Value[i];

public static A106530Inst Instance=new A106530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106531
{
public static readonly long[] Value={ 1L,2L,3L,5L,10L,24L,26L,39L,65L,130L,210L,408L,442L,1326L,2210L,2310L,9240L,11570L,18690L,36312L,39338L,118014L,196690L,308958L,514930L,538230L,2152920L,2695810L,4354770L,8460696L,9165754L,27497262L,45828770L,94232190L,131328120L,151794840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106531Inst : IEnumerable<long>
{
public static readonly long[] Value=A106531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106531.Bytes);
public long this[int i]=>Value[i];

public static A106531Inst Instance=new A106531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106532
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,15L,16L,18L,20L,28L,45L,47L,50L,52L,78L,84L,109L,117L,134L,136L,139L,141L,283L,285L,311L,317L,342L,350L,367L,369L,372L,374L,893L,927L,943L,945L,948L,961L,977L,979L,982L,1356L,1361L,1971L,2490L,2524L,2540L,2542L,2545L,2558L,2574L,2576L,2579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106532Inst : IEnumerable<long>
{
public static readonly long[] Value=A106532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106532.Bytes);
public long this[int i]=>Value[i];

public static A106532Inst Instance=new A106532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106533
{
public static readonly long[] Value={ 2L,0L,3L,1L,8L,7L,8L,6L,9L,9L,7L,9L,9L,7L,9L,9L,5L,3L,8L,3L,8L,4L,7L,9L,0L,6L,2L,0L,6L,2L,4L,1L,9L,8L,7L,9L,1L,0L,5L,4L,9L,8L,7L,8L,7L,5L,9L,0L,5L,7L,0L,3L,1L,7L,5L,0L,0L,2L,4L,7L,7L,4L,4L,1L,5L,1L,9L,5L,7L,5L,0L,7L,5L,9L,1L,9L,0L,6L,0L,2L,4L,8L,8L,3L,6L,2L,5L,0L,3L,6L,1L,6L,9L,0L,7L,7L,9L,6L,4L,2L,9L,1L,4L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106533Inst : IEnumerable<long>
{
public static readonly long[] Value=A106533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106533.Bytes);
public long this[int i]=>Value[i];

public static A106533Inst Instance=new A106533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106534
{
public static readonly long[] Value={ 1L,2L,1L,5L,3L,2L,15L,10L,7L,5L,51L,36L,26L,19L,14L,188L,137L,101L,75L,56L,42L,731L,543L,406L,305L,230L,174L,132L,2950L,2219L,1676L,1270L,965L,735L,561L,429L,12235L,9285L,7066L,5390L,4120L,3155L,2420L,1859L,1430L,51822L,39587L,30302L,23236L,17846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106534Inst : IEnumerable<long>
{
public static readonly long[] Value=A106534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106534.Bytes);
public long this[int i]=>Value[i];

public static A106534Inst Instance=new A106534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106535
{
public static readonly long[] Value={ 11L,19L,31L,59L,71L,79L,131L,179L,191L,239L,251L,271L,311L,359L,379L,419L,431L,439L,479L,491L,499L,571L,599L,631L,659L,719L,739L,751L,839L,971L,1019L,1039L,1051L,1091L,1171L,1259L,1319L,1399L,1439L,1451L,1459L,1499L,1531L,1559L,1571L,1619L,1759L,1811L,1831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106535Inst : IEnumerable<long>
{
public static readonly long[] Value=A106535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106535.Bytes);
public long this[int i]=>Value[i];

public static A106535Inst Instance=new A106535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106536
{
public static readonly BigInteger[] Value={ 27L,1828182L,8L,45904523L,53L,60287471L,3L,52662497L,75L,72470936L,9995L,95749L,BigInteger.Parse("669676277240766303535475945713821785251664274274663919320030599218174135966290435729003342"),BigInteger.Parse("952605956307381323286279434907632338298807531"),95L };
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
public class A106536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A106536.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A106536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A106536Inst Instance=new A106536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106537
{
public static readonly BigInteger[] Value={ 1L,4142L,1L,3562L,37L,3095048801688L,72420L,969807L,85L,696L,7187537L,BigInteger.Parse("694807317667973799073247846210"),703885038L,BigInteger.Parse("75343276415727350138462309122970249248360558507372"),1264L };
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
public class A106537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A106537.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A106537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A106537Inst Instance=new A106537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106538
{
public static readonly BigInteger[] Value={ 1L,1L,23L,581L,32134L,55891442L,3L,337L,76L,1098715972584L,4181L,BigInteger.Parse("6765109461771128657463687502512139319641831781151422983"),20401346L,269217830L,9L,3524L,5785L,70L,288L,792L,274L,6514930L,3522415L };
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
public class A106538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A106538.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A106538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A106538Inst Instance=new A106538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106539
{
public static readonly BigInteger[] Value={ 1L,1L,1L,0L,-6L,-36L,-192L,-1104L,-7248L,-54816L,-472512L,-4573824L,-49064448L,-577130496L,-7381281792L,-101940854784L,-1511556077568L,-23945902043136L,-403579232182272L,-7209532170092544L,-136064164749017088L,-2705030337674674176L,BigInteger.Parse("-56501002847058788352") };
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
public class A106539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106539Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A106539.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A106539.Bytes);
public BigInteger this[int i]=>Value[i];

public static A106539Inst Instance=new A106539Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106540
{
public static readonly long[] Value={ 1L,1L,-1L,-6L,-11L,-5L,28L,87L,111L,-46L,-519L,-1105L,-812L,2051L,8003L,12130L,477L,-43213L,-107764L,-106273L,133575L,716562L,1269265L,492135L,-3436796L,-10232533L,-12529349L,6701026L,62284757L,128290443L,86849596L,-256333913L,-946668833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106540Inst : IEnumerable<long>
{
public static readonly long[] Value=A106540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106540.Bytes);
public long this[int i]=>Value[i];

public static A106540Inst Instance=new A106540Inst();

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