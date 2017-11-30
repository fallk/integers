using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A039196
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,8L,9L,10L,11L,12L,13L,14L,15L,17L,19L,20L,21L,22L,23L,24L,25L,26L,28L,30L,31L,32L,33L,34L,35L,36L,37L,39L,41L,42L,43L,44L,45L,46L,47L,48L,50L,52L,53L,54L,62L,66L,67L,68L,69L,70L,72L,74L,75L,76L,82L,88L,89L,90L,91L,92L,94L,96L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039196Inst : IEnumerable<long>
{
public static readonly long[] Value=A039196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039196.Bytes);
public long this[int i]=>Value[i];

public static A039196Inst Instance=new A039196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039229
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,7L,8L,9L,10L,23L,24L,26L,27L,28L,29L,30L,31L,32L,33L,34L,36L,38L,39L,40L,41L,42L,43L,44L,45L,46L,48L,50L,51L,52L,53L,54L,55L,56L,57L,58L,60L,62L,63L,64L,65L,66L,67L,68L,69L,70L,72L,74L,75L,76L,77L,78L,79L,80L,81L,82L,84L,86L,87L,88L,89L,90L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039229Inst : IEnumerable<long>
{
public static readonly long[] Value=A039229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039229.Bytes);
public long this[int i]=>Value[i];

public static A039229Inst Instance=new A039229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039230
{
public static readonly long[] Value={ 0L,1L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,16L,17L,18L,19L,20L,21L,22L,23L,27L,38L,48L,49L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,100L,101L,102L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039230Inst : IEnumerable<long>
{
public static readonly long[] Value=A039230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039230.Bytes);
public long this[int i]=>Value[i];

public static A039230Inst Instance=new A039230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039231
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,7L,8L,9L,10L,11L,12L,13L,15L,17L,18L,19L,20L,21L,22L,23L,28L,36L,37L,39L,41L,42L,43L,44L,45L,46L,47L,50L,60L,61L,63L,65L,66L,67L,68L,69L,70L,71L,72L,73L,75L,77L,78L,79L,80L,81L,82L,83L,84L,85L,87L,89L,90L,91L,92L,93L,94L,95L,96L,97L,99L,101L,102L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039231Inst : IEnumerable<long>
{
public static readonly long[] Value=A039231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039231.Bytes);
public long this[int i]=>Value[i];

public static A039231Inst Instance=new A039231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039232
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,7L,8L,9L,10L,11L,12L,13L,15L,16L,18L,19L,20L,21L,22L,23L,29L,36L,37L,39L,40L,42L,43L,44L,45L,46L,47L,48L,49L,51L,52L,54L,55L,56L,57L,58L,59L,62L,72L,73L,75L,76L,78L,79L,80L,81L,82L,83L,84L,85L,87L,88L,90L,91L,92L,93L,94L,95L,96L,97L,99L,100L,102L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039232Inst : IEnumerable<long>
{
public static readonly long[] Value=A039232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039232.Bytes);
public long this[int i]=>Value[i];

public static A039232Inst Instance=new A039232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039233
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,7L,8L,9L,10L,11L,12L,13L,15L,16L,17L,19L,20L,21L,22L,23L,30L,36L,37L,39L,40L,41L,43L,44L,45L,46L,47L,48L,49L,51L,52L,53L,55L,56L,57L,58L,59L,60L,61L,63L,64L,65L,67L,68L,69L,70L,71L,74L,84L,85L,87L,88L,89L,91L,92L,93L,94L,95L,96L,97L,99L,100L,101L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039233Inst : IEnumerable<long>
{
public static readonly long[] Value=A039233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039233.Bytes);
public long this[int i]=>Value[i];

public static A039233Inst Instance=new A039233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039234
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,8L,9L,10L,11L,12L,13L,15L,16L,17L,18L,20L,21L,22L,23L,31L,36L,37L,39L,40L,41L,42L,44L,45L,46L,47L,48L,49L,51L,52L,53L,54L,56L,57L,58L,59L,60L,61L,63L,64L,65L,66L,68L,69L,70L,71L,72L,73L,75L,76L,77L,78L,80L,81L,82L,83L,86L,96L,97L,99L,100L,101L,102L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039234Inst : IEnumerable<long>
{
public static readonly long[] Value=A039234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039234.Bytes);
public long this[int i]=>Value[i];

public static A039234Inst Instance=new A039234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039235
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,7L,9L,10L,11L,12L,13L,15L,16L,17L,18L,19L,21L,22L,23L,32L,36L,37L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,51L,52L,53L,54L,55L,57L,58L,59L,60L,61L,63L,64L,65L,66L,67L,69L,70L,71L,72L,73L,75L,76L,77L,78L,79L,81L,82L,83L,84L,85L,87L,88L,89L,90L,91L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039235Inst : IEnumerable<long>
{
public static readonly long[] Value=A039235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039235.Bytes);
public long this[int i]=>Value[i];

public static A039235Inst Instance=new A039235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039236
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,7L,8L,10L,11L,12L,13L,15L,16L,17L,18L,19L,20L,22L,23L,33L,36L,37L,39L,40L,41L,42L,43L,44L,46L,47L,48L,49L,51L,52L,53L,54L,55L,56L,58L,59L,60L,61L,63L,64L,65L,66L,67L,68L,70L,71L,72L,73L,75L,76L,77L,78L,79L,80L,82L,83L,84L,85L,87L,88L,89L,90L,91L,92L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039236Inst : IEnumerable<long>
{
public static readonly long[] Value=A039236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039236.Bytes);
public long this[int i]=>Value[i];

public static A039236Inst Instance=new A039236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039237
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,15L,16L,17L,18L,19L,20L,21L,23L,34L,36L,37L,39L,40L,41L,42L,43L,44L,45L,47L,48L,49L,51L,52L,53L,54L,55L,56L,57L,59L,60L,61L,63L,64L,65L,66L,67L,68L,69L,71L,72L,73L,75L,76L,77L,78L,79L,80L,81L,83L,84L,85L,87L,88L,89L,90L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039237Inst : IEnumerable<long>
{
public static readonly long[] Value=A039237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039237.Bytes);
public long this[int i]=>Value[i];

public static A039237Inst Instance=new A039237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039238
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,7L,8L,9L,10L,12L,13L,15L,16L,17L,18L,19L,20L,21L,22L,35L,36L,37L,39L,40L,41L,42L,43L,44L,45L,46L,48L,49L,51L,52L,53L,54L,55L,56L,57L,58L,60L,61L,63L,64L,65L,66L,67L,68L,69L,70L,72L,73L,75L,76L,77L,78L,79L,80L,81L,82L,84L,85L,87L,88L,89L,90L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039238Inst : IEnumerable<long>
{
public static readonly long[] Value=A039238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039238.Bytes);
public long this[int i]=>Value[i];

public static A039238Inst Instance=new A039238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039239
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,29L,30L,31L,32L,33L,34L,35L,40L,51L,60L,61L,62L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,101L,102L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039239Inst : IEnumerable<long>
{
public static readonly long[] Value=A039239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039239.Bytes);
public long this[int i]=>Value[i];

public static A039239Inst Instance=new A039239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039240
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,7L,8L,9L,10L,11L,12L,13L,14L,16L,18L,19L,20L,21L,22L,23L,24L,25L,26L,28L,30L,31L,32L,33L,34L,35L,41L,48L,49L,50L,52L,54L,55L,56L,57L,58L,59L,63L,72L,73L,74L,76L,78L,79L,80L,81L,82L,83L,84L,85L,86L,88L,90L,91L,92L,93L,94L,95L,96L,97L,98L,100L,102L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039240Inst : IEnumerable<long>
{
public static readonly long[] Value=A039240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039240.Bytes);
public long this[int i]=>Value[i];

public static A039240Inst Instance=new A039240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039241
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,7L,8L,9L,10L,11L,12L,13L,14L,16L,17L,19L,20L,21L,22L,23L,24L,25L,26L,28L,29L,31L,32L,33L,34L,35L,42L,48L,49L,50L,52L,53L,55L,56L,57L,58L,59L,60L,61L,62L,64L,65L,67L,68L,69L,70L,71L,75L,84L,85L,86L,88L,89L,91L,92L,93L,94L,95L,96L,97L,98L,100L,101L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039241Inst : IEnumerable<long>
{
public static readonly long[] Value=A039241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039241.Bytes);
public long this[int i]=>Value[i];

public static A039241Inst Instance=new A039241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039242
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,8L,9L,10L,11L,12L,13L,14L,16L,17L,18L,20L,21L,22L,23L,24L,25L,26L,28L,29L,30L,32L,33L,34L,35L,43L,48L,49L,50L,52L,53L,54L,56L,57L,58L,59L,60L,61L,62L,64L,65L,66L,68L,69L,70L,71L,72L,73L,74L,76L,77L,78L,80L,81L,82L,83L,87L,96L,97L,98L,100L,101L,102L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039242Inst : IEnumerable<long>
{
public static readonly long[] Value=A039242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039242.Bytes);
public long this[int i]=>Value[i];

public static A039242Inst Instance=new A039242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039243
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,7L,9L,10L,11L,12L,13L,14L,16L,17L,18L,19L,21L,22L,23L,24L,25L,26L,28L,29L,30L,31L,33L,34L,35L,44L,48L,49L,50L,52L,53L,54L,55L,57L,58L,59L,60L,61L,62L,64L,65L,66L,67L,69L,70L,71L,72L,73L,74L,76L,77L,78L,79L,81L,82L,83L,84L,85L,86L,88L,89L,90L,91L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039243Inst : IEnumerable<long>
{
public static readonly long[] Value=A039243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039243.Bytes);
public long this[int i]=>Value[i];

public static A039243Inst Instance=new A039243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039244
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,7L,8L,10L,11L,12L,13L,14L,16L,17L,18L,19L,20L,22L,23L,24L,25L,26L,28L,29L,30L,31L,32L,34L,35L,45L,48L,49L,50L,52L,53L,54L,55L,56L,58L,59L,60L,61L,62L,64L,65L,66L,67L,68L,70L,71L,72L,73L,74L,76L,77L,78L,79L,80L,82L,83L,84L,85L,86L,88L,89L,90L,91L,92L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039244Inst : IEnumerable<long>
{
public static readonly long[] Value=A039244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039244.Bytes);
public long this[int i]=>Value[i];

public static A039244Inst Instance=new A039244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039245
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,16L,17L,18L,19L,20L,21L,23L,24L,25L,26L,28L,29L,30L,31L,32L,33L,35L,46L,48L,49L,50L,52L,53L,54L,55L,56L,57L,59L,60L,61L,62L,64L,65L,66L,67L,68L,69L,71L,72L,73L,74L,76L,77L,78L,79L,80L,81L,83L,84L,85L,86L,88L,89L,90L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039245Inst : IEnumerable<long>
{
public static readonly long[] Value=A039245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039245.Bytes);
public long this[int i]=>Value[i];

public static A039245Inst Instance=new A039245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039246
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,7L,8L,9L,10L,12L,13L,14L,16L,17L,18L,19L,20L,21L,22L,24L,25L,26L,28L,29L,30L,31L,32L,33L,34L,47L,48L,49L,50L,52L,53L,54L,55L,56L,57L,58L,60L,61L,62L,64L,65L,66L,67L,68L,69L,70L,72L,73L,74L,76L,77L,78L,79L,80L,81L,82L,84L,85L,86L,88L,89L,90L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039246Inst : IEnumerable<long>
{
public static readonly long[] Value=A039246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039246.Bytes);
public long this[int i]=>Value[i];

public static A039246Inst Instance=new A039246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039247
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,42L,43L,44L,45L,46L,47L,53L,64L,72L,73L,74L,75L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,102L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039247Inst : IEnumerable<long>
{
public static readonly long[] Value=A039247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039247.Bytes);
public long this[int i]=>Value[i];

public static A039247Inst Instance=new A039247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039248
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,8L,9L,10L,11L,12L,13L,14L,15L,17L,19L,20L,21L,22L,23L,24L,25L,26L,27L,29L,31L,32L,33L,34L,35L,36L,37L,38L,39L,41L,43L,44L,45L,46L,47L,54L,60L,61L,62L,63L,65L,67L,68L,69L,70L,71L,76L,84L,85L,86L,87L,89L,91L,92L,93L,94L,95L,96L,97L,98L,99L,101L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039248Inst : IEnumerable<long>
{
public static readonly long[] Value=A039248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039248.Bytes);
public long this[int i]=>Value[i];

public static A039248Inst Instance=new A039248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039249
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,8L,9L,10L,11L,12L,13L,14L,15L,17L,18L,20L,21L,22L,23L,24L,25L,26L,27L,29L,30L,32L,33L,34L,35L,36L,37L,38L,39L,41L,42L,44L,45L,46L,47L,55L,60L,61L,62L,63L,65L,66L,68L,69L,70L,71L,72L,73L,74L,75L,77L,78L,80L,81L,82L,83L,88L,96L,97L,98L,99L,101L,102L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039249Inst : IEnumerable<long>
{
public static readonly long[] Value=A039249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039249.Bytes);
public long this[int i]=>Value[i];

public static A039249Inst Instance=new A039249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039250
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,9L,10L,11L,12L,13L,14L,15L,17L,18L,19L,21L,22L,23L,24L,25L,26L,27L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,45L,46L,47L,56L,60L,61L,62L,63L,65L,66L,67L,69L,70L,71L,72L,73L,74L,75L,77L,78L,79L,81L,82L,83L,84L,85L,86L,87L,89L,90L,91L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039250Inst : IEnumerable<long>
{
public static readonly long[] Value=A039250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039250.Bytes);
public long this[int i]=>Value[i];

public static A039250Inst Instance=new A039250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039251
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,8L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,22L,23L,24L,25L,26L,27L,29L,30L,31L,32L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,46L,47L,57L,60L,61L,62L,63L,65L,66L,67L,68L,70L,71L,72L,73L,74L,75L,77L,78L,79L,80L,82L,83L,84L,85L,86L,87L,89L,90L,91L,92L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039251Inst : IEnumerable<long>
{
public static readonly long[] Value=A039251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039251.Bytes);
public long this[int i]=>Value[i];

public static A039251Inst Instance=new A039251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039252
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,29L,30L,31L,32L,33L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,47L,58L,60L,61L,62L,63L,65L,66L,67L,68L,69L,71L,72L,73L,74L,75L,77L,78L,79L,80L,81L,83L,84L,85L,86L,87L,89L,90L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039252Inst : IEnumerable<long>
{
public static readonly long[] Value=A039252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039252.Bytes);
public long this[int i]=>Value[i];

public static A039252Inst Instance=new A039252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039253
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,8L,9L,10L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,24L,25L,26L,27L,29L,30L,31L,32L,33L,34L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,72L,73L,74L,75L,77L,78L,79L,80L,81L,82L,84L,85L,86L,87L,89L,90L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039253Inst : IEnumerable<long>
{
public static readonly long[] Value=A039253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039253.Bytes);
public long this[int i]=>Value[i];

public static A039253Inst Instance=new A039253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039254
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,55L,56L,57L,58L,59L,66L,77L,84L,85L,86L,87L,88L,91L,92L,93L,94L,95L,96L,97L,98L,99L,100L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039254Inst : IEnumerable<long>
{
public static readonly long[] Value=A039254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039254.Bytes);
public long this[int i]=>Value[i];

public static A039254Inst Instance=new A039254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039255
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,8L,9L,10L,11L,12L,13L,14L,15L,16L,18L,20L,21L,22L,23L,24L,25L,26L,27L,28L,30L,32L,33L,34L,35L,36L,37L,38L,39L,40L,42L,44L,45L,46L,47L,48L,49L,50L,51L,52L,54L,56L,57L,58L,59L,67L,72L,73L,74L,75L,76L,78L,80L,81L,82L,83L,89L,96L,97L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039255Inst : IEnumerable<long>
{
public static readonly long[] Value=A039255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039255.Bytes);
public long this[int i]=>Value[i];

public static A039255Inst Instance=new A039255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039256
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,9L,10L,11L,12L,13L,14L,15L,16L,18L,19L,21L,22L,23L,24L,25L,26L,27L,28L,30L,31L,33L,34L,35L,36L,37L,38L,39L,40L,42L,43L,45L,46L,47L,48L,49L,50L,51L,52L,54L,55L,57L,58L,59L,68L,72L,73L,74L,75L,76L,78L,79L,81L,82L,83L,84L,85L,86L,87L,88L,90L,91L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039256Inst : IEnumerable<long>
{
public static readonly long[] Value=A039256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039256.Bytes);
public long this[int i]=>Value[i];

public static A039256Inst Instance=new A039256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039257
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,10L,11L,12L,13L,14L,15L,16L,18L,19L,20L,22L,23L,24L,25L,26L,27L,28L,30L,31L,32L,34L,35L,36L,37L,38L,39L,40L,42L,43L,44L,46L,47L,48L,49L,50L,51L,52L,54L,55L,56L,58L,59L,69L,72L,73L,74L,75L,76L,78L,79L,80L,82L,83L,84L,85L,86L,87L,88L,90L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039257Inst : IEnumerable<long>
{
public static readonly long[] Value=A039257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039257.Bytes);
public long this[int i]=>Value[i];

public static A039257Inst Instance=new A039257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039258
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,18L,19L,20L,21L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,35L,36L,37L,38L,39L,40L,42L,43L,44L,45L,47L,48L,49L,50L,51L,52L,54L,55L,56L,57L,59L,70L,72L,73L,74L,75L,76L,78L,79L,80L,81L,83L,84L,85L,86L,87L,88L,90L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039258Inst : IEnumerable<long>
{
public static readonly long[] Value=A039258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039258.Bytes);
public long this[int i]=>Value[i];

public static A039258Inst Instance=new A039258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039259
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,18L,19L,20L,21L,22L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,36L,37L,38L,39L,40L,42L,43L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,71L,72L,73L,74L,75L,76L,78L,79L,80L,81L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039259Inst : IEnumerable<long>
{
public static readonly long[] Value=A039259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039259.Bytes);
public long this[int i]=>Value[i];

public static A039259Inst Instance=new A039259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039260
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,68L,69L,70L,71L,79L,90L,96L,97L,98L,99L,100L,101L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039260Inst : IEnumerable<long>
{
public static readonly long[] Value=A039260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039260.Bytes);
public long this[int i]=>Value[i];

public static A039260Inst Instance=new A039260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039261
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,9L,10L,11L,12L,13L,14L,15L,16L,17L,19L,21L,22L,23L,24L,25L,26L,27L,28L,29L,31L,33L,34L,35L,36L,37L,38L,39L,40L,41L,43L,45L,46L,47L,48L,49L,50L,51L,52L,53L,55L,57L,58L,59L,60L,61L,62L,63L,64L,65L,67L,69L,70L,71L,80L,84L,85L,86L,87L,88L,89L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039261Inst : IEnumerable<long>
{
public static readonly long[] Value=A039261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039261.Bytes);
public long this[int i]=>Value[i];

public static A039261Inst Instance=new A039261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039262
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,10L,11L,12L,13L,14L,15L,16L,17L,19L,20L,22L,23L,24L,25L,26L,27L,28L,29L,31L,32L,34L,35L,36L,37L,38L,39L,40L,41L,43L,44L,46L,47L,48L,49L,50L,51L,52L,53L,55L,56L,58L,59L,60L,61L,62L,63L,64L,65L,67L,68L,70L,71L,81L,84L,85L,86L,87L,88L,89L,91L,92L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039262Inst : IEnumerable<long>
{
public static readonly long[] Value=A039262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039262.Bytes);
public long this[int i]=>Value[i];

public static A039262Inst Instance=new A039262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039263
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,9L,11L,12L,13L,14L,15L,16L,17L,19L,20L,21L,23L,24L,25L,26L,27L,28L,29L,31L,32L,33L,35L,36L,37L,38L,39L,40L,41L,43L,44L,45L,47L,48L,49L,50L,51L,52L,53L,55L,56L,57L,59L,60L,61L,62L,63L,64L,65L,67L,68L,69L,71L,82L,84L,85L,86L,87L,88L,89L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039263Inst : IEnumerable<long>
{
public static readonly long[] Value=A039263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039263.Bytes);
public long this[int i]=>Value[i];

public static A039263Inst Instance=new A039263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039264
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,9L,10L,12L,13L,14L,15L,16L,17L,19L,20L,21L,22L,24L,25L,26L,27L,28L,29L,31L,32L,33L,34L,36L,37L,38L,39L,40L,41L,43L,44L,45L,46L,48L,49L,50L,51L,52L,53L,55L,56L,57L,58L,60L,61L,62L,63L,64L,65L,67L,68L,69L,70L,83L,84L,85L,86L,87L,88L,89L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039264Inst : IEnumerable<long>
{
public static readonly long[] Value=A039264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039264.Bytes);
public long this[int i]=>Value[i];

public static A039264Inst Instance=new A039264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039265
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,81L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039265Inst : IEnumerable<long>
{
public static readonly long[] Value=A039265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039265.Bytes);
public long this[int i]=>Value[i];

public static A039265Inst Instance=new A039265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039266
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,10L,11L,12L,13L,14L,15L,16L,17L,18L,20L,22L,23L,24L,25L,26L,27L,28L,29L,30L,32L,34L,35L,36L,37L,38L,39L,40L,41L,42L,44L,46L,47L,48L,49L,50L,51L,52L,53L,54L,56L,58L,59L,60L,61L,62L,63L,64L,65L,66L,68L,70L,71L,72L,73L,74L,75L,76L,77L,78L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039266Inst : IEnumerable<long>
{
public static readonly long[] Value=A039266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039266.Bytes);
public long this[int i]=>Value[i];

public static A039266Inst Instance=new A039266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039267
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,20L,21L,23L,24L,25L,26L,27L,28L,29L,30L,32L,33L,35L,36L,37L,38L,39L,40L,41L,42L,44L,45L,47L,48L,49L,50L,51L,52L,53L,54L,56L,57L,59L,60L,61L,62L,63L,64L,65L,66L,68L,69L,71L,72L,73L,74L,75L,76L,77L,78L,80L,81L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039267Inst : IEnumerable<long>
{
public static readonly long[] Value=A039267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039267.Bytes);
public long this[int i]=>Value[i];

public static A039267Inst Instance=new A039267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039268
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,13L,14L,15L,16L,17L,18L,20L,21L,22L,24L,25L,26L,27L,28L,29L,30L,32L,33L,34L,36L,37L,38L,39L,40L,41L,42L,44L,45L,46L,48L,49L,50L,51L,52L,53L,54L,56L,57L,58L,60L,61L,62L,63L,64L,65L,66L,68L,69L,70L,72L,73L,74L,75L,76L,77L,78L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039268Inst : IEnumerable<long>
{
public static readonly long[] Value=A039268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039268.Bytes);
public long this[int i]=>Value[i];

public static A039268Inst Instance=new A039268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039269
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039269Inst : IEnumerable<long>
{
public static readonly long[] Value=A039269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039269.Bytes);
public long this[int i]=>Value[i];

public static A039269Inst Instance=new A039269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039270
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,21L,23L,24L,25L,26L,27L,28L,29L,30L,31L,33L,35L,36L,37L,38L,39L,40L,41L,42L,43L,45L,47L,48L,49L,50L,51L,52L,53L,54L,55L,57L,59L,60L,61L,62L,63L,64L,65L,66L,67L,69L,71L,72L,73L,74L,75L,76L,77L,78L,79L,81L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039270Inst : IEnumerable<long>
{
public static readonly long[] Value=A039270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039270.Bytes);
public long this[int i]=>Value[i];

public static A039270Inst Instance=new A039270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039271
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,10L,12L,13L,14L,15L,16L,17L,18L,19L,21L,22L,24L,25L,26L,27L,28L,29L,30L,31L,33L,34L,36L,37L,38L,39L,40L,41L,42L,43L,45L,46L,48L,49L,50L,51L,52L,53L,54L,55L,57L,58L,60L,61L,62L,63L,64L,65L,66L,67L,69L,70L,72L,73L,74L,75L,76L,77L,78L,79L,81L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039271Inst : IEnumerable<long>
{
public static readonly long[] Value=A039271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039271.Bytes);
public long this[int i]=>Value[i];

public static A039271Inst Instance=new A039271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039272
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039272Inst : IEnumerable<long>
{
public static readonly long[] Value=A039272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039272.Bytes);
public long this[int i]=>Value[i];

public static A039272Inst Instance=new A039272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039273
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,10L,12L,13L,14L,15L,16L,17L,18L,19L,20L,22L,24L,25L,26L,27L,28L,29L,30L,31L,32L,34L,36L,37L,38L,39L,40L,41L,42L,43L,44L,46L,48L,49L,50L,51L,52L,53L,54L,55L,56L,58L,60L,61L,62L,63L,64L,65L,66L,67L,68L,70L,72L,73L,74L,75L,76L,77L,78L,79L,80L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039273Inst : IEnumerable<long>
{
public static readonly long[] Value=A039273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039273.Bytes);
public long this[int i]=>Value[i];

public static A039273Inst Instance=new A039273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039274
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039274Inst : IEnumerable<long>
{
public static readonly long[] Value=A039274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039274.Bytes);
public long this[int i]=>Value[i];

public static A039274Inst Instance=new A039274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039275
{
public static readonly long[] Value={ 3L,11L,15L,19L,21L,28L,30L,35L,36L,47L,51L,59L,61L,65L,69L,73L,75L,86L,88L,92L,96L,100L,102L,107L,110L,114L,126L,136L,138L,143L,144L,155L,159L,166L,172L,174L,179L,185L,187L,190L,192L,197L,198L,209L,213L,221L,223L,227L,231L,235L,237L,247L,253L,255L,260L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039275Inst : IEnumerable<long>
{
public static readonly long[] Value=A039275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039275.Bytes);
public long this[int i]=>Value[i];

public static A039275Inst Instance=new A039275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039276
{
public static readonly long[] Value={ 6L,11L,15L,19L,21L,32L,34L,38L,42L,46L,48L,56L,58L,60L,64L,66L,72L,89L,95L,97L,101L,103L,105L,113L,115L,119L,123L,127L,129L,137L,139L,141L,145L,147L,153L,167L,169L,173L,175L,177L,181L,183L,191L,193L,195L,199L,201L,207L,217L,219L,225L,260L,266L,268L,278L,284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039276Inst : IEnumerable<long>
{
public static readonly long[] Value=A039276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039276.Bytes);
public long this[int i]=>Value[i];

public static A039276Inst Instance=new A039276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039277
{
public static readonly long[] Value={ 4L,18L,19L,24L,28L,33L,36L,49L,52L,65L,68L,74L,75L,78L,79L,80L,98L,99L,104L,108L,114L,115L,120L,124L,134L,135L,137L,141L,146L,147L,152L,156L,161L,164L,177L,180L,198L,199L,201L,205L,210L,211L,216L,220L,225L,228L,241L,244L,262L,263L,265L,269L,274L,275L,280L,284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039277Inst : IEnumerable<long>
{
public static readonly long[] Value=A039277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039277.Bytes);
public long this[int i]=>Value[i];

public static A039277Inst Instance=new A039277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039278
{
public static readonly long[] Value={ 8L,18L,24L,33L,35L,36L,44L,50L,56L,70L,73L,75L,78L,82L,88L,97L,99L,100L,108L,114L,120L,130L,133L,135L,136L,141L,143L,145L,147L,148L,156L,160L,177L,179L,180L,188L,198L,201L,203L,206L,210L,216L,225L,227L,228L,236L,242L,248L,266L,278L,281L,283L,286L,290L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039278Inst : IEnumerable<long>
{
public static readonly long[] Value=A039278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039278.Bytes);
public long this[int i]=>Value[i];

public static A039278Inst Instance=new A039278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039279
{
public static readonly long[] Value={ 12L,19L,28L,35L,44L,49L,50L,52L,56L,71L,75L,77L,78L,83L,92L,99L,108L,113L,114L,116L,120L,135L,139L,141L,142L,147L,156L,163L,172L,177L,178L,180L,184L,195L,197L,198L,201L,202L,204L,209L,210L,212L,216L,225L,226L,228L,232L,240L,271L,279L,283L,285L,286L,295L,299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039279Inst : IEnumerable<long>
{
public static readonly long[] Value=A039279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039279.Bytes);
public long this[int i]=>Value[i];

public static A039279Inst Instance=new A039279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039280
{
public static readonly long[] Value={ 6L,9L,18L,24L,27L,30L,33L,36L,39L,45L,54L,57L,66L,72L,75L,78L,90L,96L,99L,102L,105L,108L,111L,114L,120L,123L,126L,129L,132L,135L,141L,144L,147L,150L,153L,156L,159L,165L,177L,180L,183L,189L,198L,201L,210L,216L,219L,222L,225L,228L,231L,237L,246L,249L,258L,264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039280Inst : IEnumerable<long>
{
public static readonly long[] Value=A039280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039280.Bytes);
public long this[int i]=>Value[i];

public static A039280Inst Instance=new A039280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039281
{
public static readonly long[] Value={ 7L,13L,19L,27L,28L,30L,39L,45L,49L,52L,54L,57L,67L,75L,76L,78L,95L,99L,107L,108L,110L,112L,114L,119L,120L,122L,125L,135L,141L,147L,155L,156L,158L,167L,173L,177L,180L,182L,185L,193L,196L,198L,201L,208L,210L,215L,216L,218L,221L,225L,228L,230L,233L,245L,259L,267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039281Inst : IEnumerable<long>
{
public static readonly long[] Value=A039281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039281.Bytes);
public long this[int i]=>Value[i];

public static A039281Inst Instance=new A039281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039282
{
public static readonly long[] Value={ 11L,14L,27L,30L,35L,39L,44L,45L,50L,54L,56L,57L,75L,78L,91L,94L,99L,103L,108L,109L,114L,118L,120L,121L,131L,135L,140L,141L,147L,151L,156L,157L,175L,176L,177L,180L,181L,187L,190L,194L,198L,200L,201L,210L,214L,216L,217L,224L,225L,228L,229L,235L,238L,250L,267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039282Inst : IEnumerable<long>
{
public static readonly long[] Value=A039282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039282.Bytes);
public long this[int i]=>Value[i];

public static A039282Inst Instance=new A039282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039283
{
public static readonly long[] Value={ 5L,27L,28L,29L,35L,40L,45L,51L,55L,76L,80L,101L,105L,126L,130L,137L,138L,139L,142L,143L,144L,147L,148L,149L,150L,177L,178L,179L,185L,190L,195L,202L,203L,204L,210L,215L,220L,227L,228L,229L,235L,240L,245L,257L,258L,259L,261L,266L,271L,277L,278L,279L,285L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039283Inst : IEnumerable<long>
{
public static readonly long[] Value=A039283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039283.Bytes);
public long this[int i]=>Value[i];

public static A039283Inst Instance=new A039283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039284
{
public static readonly long[] Value={ 10L,27L,35L,51L,53L,54L,55L,65L,70L,77L,85L,102L,110L,132L,136L,138L,139L,142L,147L,152L,160L,176L,178L,179L,180L,190L,195L,202L,210L,227L,235L,252L,256L,258L,259L,260L,266L,268L,269L,271L,273L,274L,276L,278L,279L,280L,290L,295L,300L,326L,328L,329L,330L,340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039284Inst : IEnumerable<long>
{
public static readonly long[] Value=A039284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039284.Bytes);
public long this[int i]=>Value[i];

public static A039284Inst Instance=new A039284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039285
{
public static readonly long[] Value={ 15L,28L,40L,53L,65L,76L,77L,79L,80L,85L,95L,103L,115L,133L,138L,141L,142L,144L,148L,153L,165L,178L,190L,201L,202L,204L,205L,210L,220L,228L,240L,258L,263L,266L,267L,269L,273L,278L,290L,303L,315L,326L,327L,329L,330L,335L,345L,353L,365L,378L,381L,382L,384L,386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039285Inst : IEnumerable<long>
{
public static readonly long[] Value=A039285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039285.Bytes);
public long this[int i]=>Value[i];

public static A039285Inst Instance=new A039285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039286
{
public static readonly long[] Value={ 20L,29L,45L,54L,70L,79L,95L,101L,102L,103L,105L,110L,115L,134L,139L,144L,146L,147L,148L,154L,170L,179L,195L,204L,220L,226L,227L,228L,230L,235L,240L,259L,264L,269L,271L,272L,273L,279L,295L,304L,320L,329L,345L,351L,352L,353L,355L,360L,365L,384L,389L,394L,396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039286Inst : IEnumerable<long>
{
public static readonly long[] Value=A039286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039286.Bytes);
public long this[int i]=>Value[i];

public static A039286Inst Instance=new A039286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039287
{
public static readonly long[] Value={ 7L,11L,27L,35L,38L,39L,42L,47L,51L,55L,58L,59L,66L,71L,82L,86L,107L,111L,127L,135L,138L,139L,142L,147L,162L,175L,178L,179L,182L,186L,190L,193L,194L,195L,198L,199L,202L,210L,213L,214L,217L,222L,227L,235L,238L,239L,242L,247L,251L,255L,258L,259L,266L,271L,275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039287Inst : IEnumerable<long>
{
public static readonly long[] Value=A039287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039287.Bytes);
public long this[int i]=>Value[i];

public static A039287Inst Instance=new A039287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039288
{
public static readonly long[] Value={ 8L,16L,28L,38L,40L,42L,44L,48L,58L,66L,76L,80L,82L,84L,86L,96L,108L,116L,128L,138L,140L,142L,144L,148L,168L,178L,188L,190L,192L,194L,198L,200L,202L,204L,208L,210L,212L,214L,216L,220L,222L,224L,228L,238L,240L,242L,244L,248L,258L,266L,278L,288L,290L,292L,294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039288Inst : IEnumerable<long>
{
public static readonly long[] Value=A039288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039288.Bytes);
public long this[int i]=>Value[i];

public static A039288Inst Instance=new A039288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039289
{
public static readonly long[] Value={ 9L,21L,29L,39L,44L,45L,47L,48L,59L,71L,84L,96L,101L,105L,107L,108L,111L,116L,129L,139L,144L,145L,147L,148L,174L,179L,189L,194L,195L,197L,198L,204L,214L,219L,220L,222L,223L,225L,227L,228L,234L,235L,237L,238L,240L,242L,243L,246L,259L,271L,279L,289L,294L,295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039289Inst : IEnumerable<long>
{
public static readonly long[] Value=A039289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039289.Bytes);
public long this[int i]=>Value[i];

public static A039289Inst Instance=new A039289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039290
{
public static readonly long[] Value={ 13L,17L,38L,42L,53L,58L,65L,66L,69L,73L,77L,82L,85L,86L,89L,97L,113L,117L,138L,142L,163L,167L,178L,183L,190L,191L,194L,198L,202L,207L,210L,211L,214L,222L,238L,242L,253L,258L,265L,266L,269L,273L,278L,283L,290L,291L,294L,298L,318L,325L,326L,329L,330L,331L,334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039290Inst : IEnumerable<long>
{
public static readonly long[] Value=A039290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039290.Bytes);
public long this[int i]=>Value[i];

public static A039290Inst Instance=new A039290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039291
{
public static readonly long[] Value={ 14L,22L,39L,47L,54L,59L,69L,70L,71L,73L,89L,97L,102L,107L,110L,111L,113L,117L,139L,147L,164L,172L,179L,184L,194L,195L,196L,198L,214L,222L,227L,232L,235L,236L,238L,242L,254L,259L,269L,270L,271L,273L,279L,284L,294L,295L,296L,298L,324L,329L,334L,344L,345L,346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039291Inst : IEnumerable<long>
{
public static readonly long[] Value=A039291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039291.Bytes);
public long this[int i]=>Value[i];

public static A039291Inst Instance=new A039291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039292
{
public static readonly long[] Value={ 19L,23L,44L,48L,69L,73L,79L,84L,89L,95L,96L,97L,103L,108L,113L,115L,116L,117L,144L,148L,169L,173L,194L,198L,204L,209L,214L,220L,221L,222L,228L,233L,238L,240L,241L,242L,269L,273L,294L,298L,319L,323L,329L,334L,339L,345L,346L,347L,353L,358L,363L,365L,366L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039292Inst : IEnumerable<long>
{
public static readonly long[] Value=A039292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039292.Bytes);
public long this[int i]=>Value[i];

public static A039292Inst Instance=new A039292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039293
{
public static readonly long[] Value={ 6L,38L,39L,40L,41L,48L,54L,60L,66L,73L,78L,109L,114L,145L,150L,181L,186L,217L,222L,230L,231L,232L,233L,236L,237L,238L,239L,242L,243L,244L,245L,248L,249L,250L,251L,252L,290L,291L,292L,293L,300L,306L,312L,318L,326L,327L,328L,329L,336L,342L,348L,354L,362L,363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039293Inst : IEnumerable<long>
{
public static readonly long[] Value=A039293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039293.Bytes);
public long this[int i]=>Value[i];

public static A039293Inst Instance=new A039293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039294
{
public static readonly long[] Value={ 12L,38L,48L,73L,75L,76L,77L,78L,90L,96L,102L,110L,120L,146L,156L,182L,192L,224L,229L,231L,232L,233L,236L,242L,248L,254L,264L,289L,291L,292L,293L,294L,306L,312L,318L,326L,336L,362L,372L,398L,408L,434L,439L,441L,442L,443L,444L,451L,453L,454L,455L,457L,459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039294Inst : IEnumerable<long>
{
public static readonly long[] Value=A039294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039294.Bytes);
public long this[int i]=>Value[i];

public static A039294Inst Instance=new A039294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039295
{
public static readonly long[] Value={ 18L,39L,54L,75L,90L,109L,110L,112L,113L,114L,120L,132L,138L,147L,162L,183L,198L,225L,231L,235L,236L,238L,239L,243L,249L,255L,270L,291L,306L,325L,326L,328L,329L,330L,336L,348L,354L,363L,378L,399L,414L,441L,447L,451L,452L,454L,455L,459L,465L,471L,486L,507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039295Inst : IEnumerable<long>
{
public static readonly long[] Value=A039295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039295.Bytes);
public long this[int i]=>Value[i];

public static A039295Inst Instance=new A039295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039296
{
public static readonly long[] Value={ 24L,40L,60L,76L,96L,112L,132L,145L,146L,147L,149L,150L,156L,162L,174L,184L,204L,226L,232L,238L,241L,242L,243L,245L,250L,256L,276L,292L,312L,328L,348L,361L,362L,363L,365L,366L,372L,378L,390L,400L,420L,442L,448L,454L,457L,458L,459L,461L,466L,472L,492L,508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039296Inst : IEnumerable<long>
{
public static readonly long[] Value=A039296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039296.Bytes);
public long this[int i]=>Value[i];

public static A039296Inst Instance=new A039296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039297
{
public static readonly long[] Value={ 30L,41L,66L,77L,102L,113L,138L,149L,174L,181L,182L,183L,184L,186L,192L,198L,204L,227L,233L,239L,245L,247L,248L,249L,250L,257L,282L,293L,318L,329L,354L,365L,390L,397L,398L,399L,400L,402L,408L,414L,420L,443L,449L,455L,461L,463L,464L,465L,466L,473L,498L,509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039297Inst : IEnumerable<long>
{
public static readonly long[] Value=A039297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039297.Bytes);
public long this[int i]=>Value[i];

public static A039297Inst Instance=new A039297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039298
{
public static readonly long[] Value={ 8L,13L,38L,48L,51L,52L,53L,56L,62L,68L,73L,78L,81L,82L,83L,91L,97L,103L,116L,121L,152L,157L,188L,193L,218L,228L,231L,232L,233L,236L,242L,248L,266L,288L,291L,292L,293L,296L,301L,306L,309L,310L,311L,312L,315L,316L,317L,318L,321L,322L,323L,326L,336L,339L,340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039298Inst : IEnumerable<long>
{
public static readonly long[] Value=A039298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039298.Bytes);
public long this[int i]=>Value[i];

public static A039298Inst Instance=new A039298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039299
{
public static readonly long[] Value={ 9L,19L,39L,51L,54L,56L,58L,59L,63L,69L,81L,91L,109L,114L,116L,118L,119L,121L,133L,139L,153L,163L,189L,199L,219L,231L,234L,236L,238L,239L,243L,249L,273L,291L,303L,306L,308L,310L,311L,315L,321L,324L,326L,328L,329L,333L,336L,338L,340L,341L,343L,348L,350L,352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039299Inst : IEnumerable<long>
{
public static readonly long[] Value=A039299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039299.Bytes);
public long this[int i]=>Value[i];

public static A039299Inst Instance=new A039299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039300
{
public static readonly long[] Value={ 1L,2L,4L,11L,31L,92L,274L,821L,2461L,7382L,22144L,66431L,199291L,597872L,1793614L,5380841L,16142521L,48427562L,145282684L,435848051L,1307544151L,3922632452L,11767897354L,35303692061L,105911076181L,317733228542L,953199685624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039300Inst : IEnumerable<long>
{
public static readonly long[] Value=A039300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039300.Bytes);
public long this[int i]=>Value[i];

public static A039300Inst Instance=new A039300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039301
{
public static readonly long[] Value={ 1L,2L,4L,12L,44L,172L,684L,2732L,10924L,43692L,174764L,699052L,2796204L,11184812L,44739244L,178956972L,715827884L,2863311532L,11453246124L,45812984492L,183251937964L,733007751852L,2932031007404L,11728124029612L,46912496118444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039301Inst : IEnumerable<long>
{
public static readonly long[] Value=A039301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039301.Bytes);
public long this[int i]=>Value[i];

public static A039301Inst Instance=new A039301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039302
{
public static readonly long[] Value={ 1L,3L,11L,53L,261L,1303L,6511L,32553L,162761L,813803L,4069011L,20345053L,101725261L,508626303L,2543131511L,12715657553L,63578287761L,317891438803L,1589457194011L,7947285970053L,39736429850261L,198682149251303L,993410746256511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039302Inst : IEnumerable<long>
{
public static readonly long[] Value=A039302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039302.Bytes);
public long this[int i]=>Value[i];

public static A039302Inst Instance=new A039302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039303
{
public static readonly long[] Value={ 1L,4L,8L,33L,124L,644L,3288L,18883L,108284L,642234L,3808768L,22785833L,136315044L,817291024L,4900153448L,29395534383L,176340899404L,1057996947014L,6347691029328L,38085710240533L,228511646005364L,1371065953050204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039303Inst : IEnumerable<long>
{
public static readonly long[] Value=A039303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039303.Bytes);
public long this[int i]=>Value[i];

public static A039303Inst Instance=new A039303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039304
{
public static readonly long[] Value={ 1L,4L,22L,151L,1051L,7354L,51472L,360301L,2522101L,17654704L,123582922L,865080451L,6055563151L,42388942054L,296722594372L,2077058160601L,14539407124201L,101775849869404L,712430949085822L,4987016643600751L,34909116505205251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039304Inst : IEnumerable<long>
{
public static readonly long[] Value=A039304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039304.Bytes);
public long this[int i]=>Value[i];

public static A039304Inst Instance=new A039304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039305
{
public static readonly long[] Value={ 1L,3L,12L,87L,684L,5463L,43692L,349527L,2796204L,22369623L,178956972L,1431655767L,11453246124L,91625968983L,733007751852L,5864062014807L,46912496118444L,375299968947543L,3002399751580332L,24019198012642647L,192153584101141164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039305Inst : IEnumerable<long>
{
public static readonly long[] Value=A039305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039305.Bytes);
public long this[int i]=>Value[i];

public static A039305Inst Instance=new A039305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039306
{
public static readonly long[] Value={ 1L,4L,31L,274L,2461L,22144L,199291L,1793614L,16142521L,145282684L,1307544151L,11767897354L,105911076181L,953199685624L,8578797170611L,77209174535494L,694882570819441L,6253943137374964L,56285488236374671L,506569394127372034L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039306Inst : IEnumerable<long>
{
public static readonly long[] Value=A039306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039306.Bytes);
public long this[int i]=>Value[i];

public static A039306Inst Instance=new A039306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039307
{
public static readonly long[] Value={ 29L,34L,65L,70L,101L,106L,137L,142L,149L,155L,161L,167L,174L,175L,176L,177L,184L,190L,196L,202L,204L,205L,206L,207L,245L,250L,281L,286L,317L,322L,353L,358L,365L,371L,377L,383L,390L,391L,392L,393L,400L,406L,412L,418L,420L,421L,422L,423L,461L,466L,497L,502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039307Inst : IEnumerable<long>
{
public static readonly long[] Value=A039307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039307.Bytes);
public long this[int i]=>Value[i];

public static A039307Inst Instance=new A039307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039308
{
public static readonly long[] Value={ 7L,51L,52L,53L,54L,55L,63L,70L,77L,84L,91L,99L,105L,148L,154L,197L,203L,246L,252L,295L,301L,344L,350L,359L,360L,361L,362L,363L,366L,367L,368L,369L,370L,373L,374L,375L,376L,377L,380L,381L,382L,383L,384L,387L,388L,389L,390L,391L,392L,443L,444L,445L,446L,447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039308Inst : IEnumerable<long>
{
public static readonly long[] Value=A039308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039308.Bytes);
public long this[int i]=>Value[i];

public static A039308Inst Instance=new A039308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039325
{
public static readonly long[] Value={ 27L,45L,76L,94L,125L,143L,153L,160L,167L,181L,188L,189L,190L,191L,193L,194L,223L,241L,272L,290L,297L,304L,311L,315L,316L,317L,319L,320L,325L,332L,370L,388L,419L,437L,468L,486L,496L,503L,510L,524L,531L,532L,533L,534L,536L,537L,566L,584L,615L,633L,640L,647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039325Inst : IEnumerable<long>
{
public static readonly long[] Value=A039325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039325.Bytes);
public long this[int i]=>Value[i];

public static A039325Inst Instance=new A039325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039326
{
public static readonly long[] Value={ 33L,39L,82L,88L,131L,137L,180L,186L,201L,208L,215L,222L,231L,232L,233L,234L,237L,243L,249L,256L,263L,270L,273L,274L,275L,276L,279L,291L,327L,333L,376L,382L,425L,431L,474L,480L,523L,529L,544L,551L,558L,565L,574L,575L,576L,577L,580L,586L,592L,599L,606L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039326Inst : IEnumerable<long>
{
public static readonly long[] Value=A039326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039326.Bytes);
public long this[int i]=>Value[i];

public static A039326Inst Instance=new A039326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039327
{
public static readonly long[] Value={ 34L,46L,83L,95L,132L,144L,181L,193L,202L,209L,216L,223L,237L,238L,239L,240L,241L,243L,279L,291L,298L,305L,312L,319L,322L,323L,324L,325L,327L,333L,377L,389L,426L,438L,475L,487L,524L,536L,545L,552L,559L,566L,580L,581L,582L,583L,584L,586L,622L,634L,641L,648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039327Inst : IEnumerable<long>
{
public static readonly long[] Value=A039327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039327.Bytes);
public long this[int i]=>Value[i];

public static A039327Inst Instance=new A039327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039328
{
public static readonly long[] Value={ 41L,47L,90L,96L,139L,145L,188L,194L,237L,243L,251L,258L,265L,272L,279L,287L,288L,289L,290L,291L,299L,306L,313L,320L,327L,329L,330L,331L,332L,333L,384L,390L,433L,439L,482L,488L,531L,537L,580L,586L,594L,601L,608L,615L,622L,630L,631L,632L,633L,634L,642L,649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039328Inst : IEnumerable<long>
{
public static readonly long[] Value=A039328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039328.Bytes);
public long this[int i]=>Value[i];

public static A039328Inst Instance=new A039328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039329
{
public static readonly long[] Value={ 8L,66L,67L,68L,69L,70L,71L,80L,88L,96L,104L,112L,120L,129L,136L,193L,200L,257L,264L,321L,328L,385L,392L,449L,456L,513L,520L,530L,531L,532L,533L,534L,535L,538L,539L,540L,541L,542L,543L,546L,547L,548L,549L,550L,551L,554L,555L,556L,557L,558L,559L,562L,563L,564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039329Inst : IEnumerable<long>
{
public static readonly long[] Value=A039329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039329.Bytes);
public long this[int i]=>Value[i];

public static A039329Inst Instance=new A039329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039330
{
public static readonly long[] Value={ 16L,66L,80L,129L,131L,132L,133L,134L,135L,136L,152L,160L,168L,176L,184L,194L,208L,258L,272L,322L,336L,386L,400L,450L,464L,522L,529L,531L,532L,533L,534L,535L,538L,546L,554L,562L,570L,578L,592L,641L,643L,644L,645L,646L,647L,648L,664L,672L,680L,688L,696L,706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039330Inst : IEnumerable<long>
{
public static readonly long[] Value=A039330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039330.Bytes);
public long this[int i]=>Value[i];

public static A039330Inst Instance=new A039330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039331
{
public static readonly long[] Value={ 24L,67L,88L,131L,152L,193L,194L,196L,197L,198L,199L,200L,208L,224L,232L,240L,248L,259L,280L,323L,344L,387L,408L,451L,472L,523L,531L,537L,538L,540L,541L,542L,543L,547L,555L,563L,571L,579L,600L,643L,664L,705L,706L,708L,709L,710L,711L,712L,720L,736L,744L,752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039331Inst : IEnumerable<long>
{
public static readonly long[] Value=A039331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039331.Bytes);
public long this[int i]=>Value[i];

public static A039331Inst Instance=new A039331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039332
{
public static readonly long[] Value={ 32L,68L,96L,132L,160L,196L,224L,257L,258L,259L,261L,262L,263L,264L,272L,280L,296L,304L,312L,324L,352L,388L,416L,452L,480L,524L,532L,540L,545L,546L,547L,549L,550L,551L,556L,564L,572L,580L,608L,644L,672L,708L,736L,769L,770L,771L,773L,774L,775L,776L,784L,792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039332Inst : IEnumerable<long>
{
public static readonly long[] Value=A039332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039332.Bytes);
public long this[int i]=>Value[i];

public static A039332Inst Instance=new A039332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039333
{
public static readonly long[] Value={ 40L,69L,104L,133L,168L,197L,232L,261L,296L,321L,322L,323L,324L,326L,327L,328L,336L,344L,352L,368L,376L,389L,424L,453L,488L,525L,533L,541L,549L,553L,554L,555L,556L,558L,559L,565L,573L,581L,616L,645L,680L,709L,744L,773L,808L,833L,834L,835L,836L,838L,839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039333Inst : IEnumerable<long>
{
public static readonly long[] Value=A039333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039333.Bytes);
public long this[int i]=>Value[i];

public static A039333Inst Instance=new A039333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039334
{
public static readonly long[] Value={ 48L,70L,112L,134L,176L,198L,240L,262L,304L,326L,368L,385L,386L,387L,388L,389L,391L,392L,400L,408L,416L,424L,440L,454L,496L,526L,534L,542L,550L,558L,561L,562L,563L,564L,565L,567L,574L,582L,624L,646L,688L,710L,752L,774L,816L,838L,880L,897L,898L,899L,900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039334Inst : IEnumerable<long>
{
public static readonly long[] Value=A039334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039334.Bytes);
public long this[int i]=>Value[i];

public static A039334Inst Instance=new A039334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039335
{
public static readonly long[] Value={ 56L,71L,120L,135L,184L,199L,248L,263L,312L,327L,376L,391L,440L,449L,450L,451L,452L,453L,454L,456L,464L,472L,480L,488L,496L,527L,535L,543L,551L,559L,567L,569L,570L,571L,572L,573L,574L,583L,632L,647L,696L,711L,760L,775L,824L,839L,888L,903L,952L,961L,962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039335Inst : IEnumerable<long>
{
public static readonly long[] Value=A039335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039335.Bytes);
public long this[int i]=>Value[i];

public static A039335Inst Instance=new A039335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039336
{
public static readonly long[] Value={ 10L,17L,66L,80L,83L,84L,85L,86L,87L,90L,98L,106L,114L,122L,129L,136L,139L,140L,141L,142L,143L,153L,161L,169L,177L,185L,202L,209L,266L,273L,330L,337L,394L,401L,458L,465L,514L,528L,531L,532L,533L,534L,535L,538L,546L,554L,562L,570L,594L,640L,643L,644L,645L,646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039336Inst : IEnumerable<long>
{
public static readonly long[] Value=A039336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039336.Bytes);
public long this[int i]=>Value[i];

public static A039336Inst Instance=new A039336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039337
{
public static readonly long[] Value={ 11L,25L,67L,83L,88L,90L,92L,93L,94L,95L,99L,107L,115L,123L,139L,153L,193L,200L,202L,204L,205L,206L,207L,209L,225L,233L,241L,249L,267L,281L,331L,345L,395L,409L,459L,473L,515L,531L,536L,538L,540L,541L,542L,543L,547L,555L,563L,571L,603L,643L,659L,664L,666L,668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039337Inst : IEnumerable<long>
{
public static readonly long[] Value=A039337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039337.Bytes);
public long this[int i]=>Value[i];

public static A039337Inst Instance=new A039337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039338
{
public static readonly long[] Value={ 12L,33L,68L,84L,92L,96L,98L,99L,101L,102L,103L,108L,116L,124L,140L,161L,204L,225L,257L,264L,266L,267L,269L,270L,271L,273L,281L,297L,305L,313L,332L,353L,396L,417L,460L,481L,516L,532L,540L,544L,546L,547L,549L,550L,551L,556L,564L,572L,612L,644L,660L,668L,672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039338Inst : IEnumerable<long>
{
public static readonly long[] Value=A039338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039338.Bytes);
public long this[int i]=>Value[i];

public static A039338Inst Instance=new A039338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039339
{
public static readonly long[] Value={ 13L,41L,69L,85L,93L,101L,104L,106L,107L,108L,110L,111L,117L,125L,141L,169L,205L,233L,269L,297L,321L,328L,330L,331L,332L,334L,335L,337L,345L,353L,369L,377L,397L,425L,461L,489L,517L,533L,541L,549L,552L,554L,555L,556L,558L,559L,565L,573L,621L,645L,661L,669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039339Inst : IEnumerable<long>
{
public static readonly long[] Value=A039339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039339.Bytes);
public long this[int i]=>Value[i];

public static A039339Inst Instance=new A039339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039340
{
public static readonly long[] Value={ 14L,49L,70L,86L,94L,102L,110L,112L,114L,115L,116L,117L,119L,126L,142L,177L,206L,241L,270L,305L,334L,369L,385L,392L,394L,395L,396L,397L,399L,401L,409L,417L,425L,441L,462L,497L,518L,534L,542L,550L,558L,560L,562L,563L,564L,565L,567L,574L,630L,646L,662L,670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039340Inst : IEnumerable<long>
{
public static readonly long[] Value=A039340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039340.Bytes);
public long this[int i]=>Value[i];

public static A039340Inst Instance=new A039340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039357
{
public static readonly long[] Value={ 9L,83L,84L,85L,86L,87L,88L,89L,99L,108L,117L,126L,135L,144L,153L,163L,171L,244L,252L,325L,333L,406L,414L,487L,495L,568L,576L,649L,657L,730L,738L,749L,750L,751L,752L,753L,754L,755L,758L,759L,760L,761L,762L,763L,764L,767L,768L,769L,770L,771L,772L,773L,776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039357Inst : IEnumerable<long>
{
public static readonly long[] Value=A039357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039357.Bytes);
public long this[int i]=>Value[i];

public static A039357Inst Instance=new A039357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039358
{
public static readonly long[] Value={ 18L,83L,99L,163L,165L,166L,167L,168L,169L,170L,171L,189L,198L,207L,216L,225L,234L,245L,261L,326L,342L,407L,423L,488L,504L,569L,585L,650L,666L,740L,748L,750L,751L,752L,753L,754L,755L,758L,767L,776L,785L,794L,803L,812L,828L,892L,894L,895L,896L,897L,898L,899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039358Inst : IEnumerable<long>
{
public static readonly long[] Value=A039358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039358.Bytes);
public long this[int i]=>Value[i];

public static A039358Inst Instance=new A039358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039359
{
public static readonly long[] Value={ 27L,84L,108L,165L,189L,244L,245L,247L,248L,249L,250L,251L,252L,261L,279L,288L,297L,306L,315L,327L,351L,408L,432L,489L,513L,570L,594L,651L,675L,741L,750L,757L,758L,760L,761L,762L,763L,764L,768L,777L,786L,795L,804L,813L,837L,894L,918L,973L,974L,976L,977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039359Inst : IEnumerable<long>
{
public static readonly long[] Value=A039359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039359.Bytes);
public long this[int i]=>Value[i];

public static A039359Inst Instance=new A039359Inst();

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