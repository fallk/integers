using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A264982
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,4L,3L,4L,4L,4L,5L,4L,5L,4L,6L,4L,5L,5L,5L,6L,4L,6L,5L,7L,5L,5L,6L,5L,7L,5L,7L,5L,6L,6L,7L,6L,6L,6L,7L,5L,8L,5L,8L,5L,8L,5L,8L,5L,9L,6L,7L,6L,7L,6L,8L,6L,7L,7L,8L,7L,7L,7L,8L,7L,8L,8L,8L,6L,8L,7L,8L,7L,9L,6L,9L,6L,9L,6L,9L,6L,10L,6L,9L,6L,9L,6L,10L,6L,10L,6L,9L,7L,8L,7L,9L,7L,10L,6L,10L,6L,10L,6L,11L,6L,11L,6L,11L,6L,11L,6L,11L,6L,11L,6L,12L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264982Inst : IEnumerable<long>
{
public static readonly long[] Value=A264982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264982.Bytes);
public long this[int i]=>Value[i];

public static A264982Inst Instance=new A264982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264983
{
public static readonly long[] Value={ 1L,3L,7L,5L,9L,19L,13L,21L,25L,11L,15L,23L,17L,27L,55L,37L,57L,73L,31L,39L,67L,49L,63L,61L,43L,75L,79L,29L,33L,65L,47L,45L,59L,41L,69L,77L,35L,51L,71L,53L,81L,163L,109L,165L,217L,91L,111L,199L,145L,171L,181L,127L,219L,235L,85L,93L,193L,139L,117L,175L,121L,201L,229L,103L,147L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264983Inst : IEnumerable<long>
{
public static readonly long[] Value=A264983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264983.Bytes);
public long this[int i]=>Value[i];

public static A264983Inst Instance=new A264983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264984
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,10L,12L,22L,16L,18L,20L,14L,24L,26L,28L,30L,64L,46L,36L,58L,40L,66L,76L,34L,48L,70L,52L,54L,56L,38L,60L,74L,32L,42L,68L,50L,72L,62L,44L,78L,80L,82L,84L,190L,136L,90L,172L,118L,192L,226L,100L,138L,208L,154L,108L,166L,112L,174L,220L,94L,120L,202L,148L,198L,184L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264984Inst : IEnumerable<long>
{
public static readonly long[] Value=A264984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264984.Bytes);
public long this[int i]=>Value[i];

public static A264984Inst Instance=new A264984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264985
{
public static readonly long[] Value={ 0L,1L,3L,2L,4L,9L,6L,10L,12L,5L,7L,11L,8L,13L,27L,18L,28L,36L,15L,19L,33L,24L,31L,30L,21L,37L,39L,14L,16L,32L,23L,22L,29L,20L,34L,38L,17L,25L,35L,26L,40L,81L,54L,82L,108L,45L,55L,99L,72L,85L,90L,63L,109L,117L,42L,46L,96L,69L,58L,87L,60L,100L,114L,51L,73L,105L,78L,94L,84L,57L,91L,111L,48L,64L,102L,75L,112L,93L,66L,118L,120L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264985Inst : IEnumerable<long>
{
public static readonly long[] Value=A264985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264985.Bytes);
public long this[int i]=>Value[i];

public static A264985Inst Instance=new A264985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264986
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,10L,12L,14L,32L,18L,20L,38L,24L,26L,28L,30L,16L,34L,36L,22L,40L,42L,68L,86L,96L,50L,104L,54L,56L,110L,60L,74L,92L,114L,44L,98L,72L,62L,116L,78L,80L,82L,84L,46L,100L,90L,64L,118L,48L,70L,88L,102L,52L,106L,108L,58L,112L,66L,76L,94L,120L,122L,284L,126L,176L,338L,204L,230L,248L,258L,140L,302L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264986Inst : IEnumerable<long>
{
public static readonly long[] Value=A264986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264986.Bytes);
public long this[int i]=>Value[i];

public static A264986Inst Instance=new A264986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264987
{
public static readonly long[] Value={ 1L,3L,5L,11L,9L,7L,13L,15L,23L,29L,33L,17L,35L,27L,19L,37L,21L,25L,31L,39L,41L,95L,45L,59L,113L,69L,77L,83L,87L,47L,101L,99L,65L,119L,51L,71L,89L,105L,53L,107L,81L,55L,109L,57L,73L,91L,111L,43L,97L,63L,61L,115L,75L,79L,85L,93L,49L,103L,117L,67L,121L,123L,203L,257L,285L,149L,311L,135L,167L,329L,177L,221L,275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264987Inst : IEnumerable<long>
{
public static readonly long[] Value=A264987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264987.Bytes);
public long this[int i]=>Value[i];

public static A264987Inst Instance=new A264987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264988
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,13L,17L,19L,23L,27L,29L,31L,35L,37L,41L,43L,51L,53L,57L,59L,61L,65L,67L,71L,73L,77L,79L,143L,149L,151L,155L,157L,161L,163L,173L,177L,179L,181L,185L,191L,193L,199L,203L,209L,211L,215L,219L,223L,231L,233L,237L,239L,241L,249L,251L,263L,267L,269L,271L,277L,285L,291L,293L,299L,303L,315L,317L,321L,327L,333L,335L,337L,341L,347L,349L,357L,359L,369L,517L,531L,535L,523L,527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264988Inst : IEnumerable<long>
{
public static readonly long[] Value=A264988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264988.Bytes);
public long this[int i]=>Value[i];

public static A264988Inst Instance=new A264988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264989
{
public static readonly long[] Value={ 0L,1L,2L,5L,4L,3L,6L,7L,11L,14L,16L,8L,17L,13L,9L,18L,10L,12L,15L,19L,20L,47L,22L,29L,56L,34L,38L,41L,43L,23L,50L,49L,32L,59L,25L,35L,44L,52L,26L,53L,40L,27L,54L,28L,36L,45L,55L,21L,48L,31L,30L,57L,37L,39L,42L,46L,24L,51L,58L,33L,60L,61L,101L,128L,142L,74L,155L,67L,83L,164L,88L,110L,137L,169L,65L,146L,103L,92L,173L,115L,119L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264989Inst : IEnumerable<long>
{
public static readonly long[] Value=A264989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264989.Bytes);
public long this[int i]=>Value[i];

public static A264989Inst Instance=new A264989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264990
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,1L,2L,2L,3L,1L,2L,1L,1L,1L,2L,2L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,3L,1L,2L,2L,3L,3L,4L,2L,3L,1L,2L,2L,3L,2L,2L,1L,2L,2L,3L,1L,2L,1L,1L,1L,2L,2L,2L,1L,2L,2L,3L,2L,2L,2L,2L,2L,2L,3L,3L,1L,1L,1L,2L,2L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,3L,1L,2L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,3L,1L,2L,1L,1L,1L,2L,2L,2L,1L,1L,1L,2L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264990Inst : IEnumerable<long>
{
public static readonly long[] Value=A264990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264990.Bytes);
public long this[int i]=>Value[i];

public static A264990Inst Instance=new A264990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264991
{
public static readonly long[] Value={ 0L,1L,5L,2L,4L,14L,6L,16L,17L,3L,7L,8L,11L,13L,41L,15L,43L,44L,18L,19L,59L,56L,49L,50L,47L,52L,53L,9L,10L,32L,29L,22L,23L,20L,25L,26L,12L,34L,35L,38L,40L,122L,42L,124L,125L,45L,46L,140L,137L,130L,131L,128L,133L,134L,54L,55L,167L,164L,58L,176L,60L,178L,179L,57L,169L,170L,173L,148L,149L,51L,151L,152L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264991Inst : IEnumerable<long>
{
public static readonly long[] Value=A264991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264991.Bytes);
public long this[int i]=>Value[i];

public static A264991Inst Instance=new A264991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264992
{
public static readonly long[] Value={ 0L,1L,3L,9L,4L,2L,6L,10L,11L,27L,28L,12L,36L,13L,5L,15L,7L,8L,18L,19L,33L,99L,31L,32L,96L,34L,35L,81L,82L,30L,90L,85L,29L,87L,37L,38L,108L,109L,39L,117L,40L,14L,42L,16L,17L,45L,46L,24L,72L,22L,23L,69L,25L,26L,54L,55L,21L,63L,58L,20L,60L,100L,101L,297L,298L,102L,306L,94L,95L,285L,97L,98L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264992Inst : IEnumerable<long>
{
public static readonly long[] Value=A264992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264992.Bytes);
public long this[int i]=>Value[i];

public static A264992Inst Instance=new A264992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264993
{
public static readonly long[] Value={ 0L,1L,3L,2L,4L,5L,11L,7L,12L,19L,15L,6L,8L,18L,14L,10L,16L,17L,13L,9L,20L,21L,43L,27L,44L,75L,59L,23L,28L,71L,55L,39L,48L,67L,51L,35L,76L,83L,47L,31L,60L,79L,63L,22L,24L,70L,54L,38L,32L,66L,50L,34L,72L,82L,46L,30L,56L,78L,62L,26L,40L,74L,58L,42L,64L,65L,49L,33L,68L,81L,45L,29L,52L,77L,61L,25L,36L,73L,57L,41L,80L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264993Inst : IEnumerable<long>
{
public static readonly long[] Value=A264993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264993.Bytes);
public long this[int i]=>Value[i];

public static A264993Inst Instance=new A264993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264994
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,9L,13L,8L,6L,10L,14L,12L,7L,11L,15L,16L,17L,33L,49L,20L,21L,37L,53L,36L,25L,41L,57L,52L,29L,45L,61L,32L,18L,34L,50L,24L,22L,38L,54L,40L,26L,42L,58L,56L,30L,46L,62L,48L,19L,35L,51L,28L,23L,39L,55L,44L,27L,43L,59L,60L,31L,47L,63L,64L,65L,129L,193L,68L,81L,145L,209L,132L,97L,161L,225L,196L,113L,177L,241L,80L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264994Inst : IEnumerable<long>
{
public static readonly long[] Value=A264994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264994.Bytes);
public long this[int i]=>Value[i];

public static A264994Inst Instance=new A264994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264995
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,11L,16L,21L,10L,7L,12L,17L,22L,15L,8L,13L,18L,23L,20L,9L,14L,19L,24L,25L,26L,51L,76L,101L,30L,31L,56L,81L,106L,55L,36L,61L,86L,111L,80L,41L,66L,91L,116L,105L,46L,71L,96L,121L,50L,27L,52L,77L,102L,35L,32L,57L,82L,107L,60L,37L,62L,87L,112L,85L,42L,67L,92L,117L,110L,47L,72L,97L,122L,75L,28L,53L,78L,103L,40L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264995Inst : IEnumerable<long>
{
public static readonly long[] Value=A264995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264995.Bytes);
public long this[int i]=>Value[i];

public static A264995Inst Instance=new A264995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264996
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,10L,7L,11L,13L,6L,8L,12L,9L,14L,28L,19L,29L,37L,16L,20L,34L,25L,32L,31L,22L,38L,40L,15L,17L,33L,24L,23L,30L,21L,35L,39L,18L,26L,36L,27L,41L,82L,55L,83L,109L,46L,56L,100L,73L,86L,91L,64L,110L,118L,43L,47L,97L,70L,59L,88L,61L,101L,115L,52L,74L,106L,79L,95L,85L,58L,92L,112L,49L,65L,103L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264996Inst : IEnumerable<long>
{
public static readonly long[] Value=A264996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264996.Bytes);
public long this[int i]=>Value[i];

public static A264996Inst Instance=new A264996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264997
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,0L,1L,2L,1L,0L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,0L,1L,2L,2L,1L,2L,3L,2L,3L,2L,2L,3L,2L,2L,2L,2L,1L,2L,3L,2L,3L,3L,2L,4L,3L,1L,3L,3L,3L,3L,3L,3L,4L,4L,2L,4L,3L,2L,4L,3L,2L,2L,2L,2L,2L,2L,2L,3L,4L,2L,3L,4L,2L,5L,5L,3L,4L,4L,4L,5L,4L,2L,6L,6L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264997Inst : IEnumerable<long>
{
public static readonly long[] Value=A264997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264997.Bytes);
public long this[int i]=>Value[i];

public static A264997Inst Instance=new A264997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264998
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,3L,2L,3L,3L,2L,3L,2L,1L,2L,2L,3L,3L,4L,4L,4L,6L,4L,5L,5L,4L,5L,4L,4L,3L,4L,4L,4L,6L,5L,5L,7L,5L,5L,6L,4L,6L,6L,6L,6L,7L,7L,6L,8L,5L,6L,7L,5L,6L,5L,4L,4L,4L,4L,4L,5L,6L,5L,7L,6L,5L,9L,7L,8L,9L,7L,8L,9L,8L,7L,10L,8L,9L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264998Inst : IEnumerable<long>
{
public static readonly long[] Value=A264998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264998.Bytes);
public long this[int i]=>Value[i];

public static A264998Inst Instance=new A264998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A264999
{
public static readonly long[] Value={ 1L,2L,7L,112L,4919L,1268728L,1001060834L,4031708477982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A264999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A264999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A264999Inst : IEnumerable<long>
{
public static readonly long[] Value=A264999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A264999.Bytes);
public long this[int i]=>Value[i];

public static A264999Inst Instance=new A264999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265000
{
public static readonly long[] Value={ 1L,2L,7L,29L,140L,758L,4448L,27782L,182322L,1245399L,8793649L,63844600L,474662243L,3601895485L,27823860424L,218325937188L,1737070192604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265000Inst : IEnumerable<long>
{
public static readonly long[] Value=A265000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265000.Bytes);
public long this[int i]=>Value[i];

public static A265000Inst Instance=new A265000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265001
{
public static readonly long[] Value={ 1L,3L,14L,112L,1095L,13009L,175865L,2647438L,43347498L,760869739L,14150265025L,276374334318L,5629364791202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265001Inst : IEnumerable<long>
{
public static readonly long[] Value=A265001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265001.Bytes);
public long this[int i]=>Value[i];

public static A265001Inst Instance=new A265001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265002
{
public static readonly long[] Value={ 1L,3L,21L,261L,4919L,120096L,3558888L,123026475L,4817478608L,209081118730L,9892111117243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265002Inst : IEnumerable<long>
{
public static readonly long[] Value=A265002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265002.Bytes);
public long this[int i]=>Value[i];

public static A265002Inst Instance=new A265002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265003
{
public static readonly long[] Value={ 1L,4L,41L,846L,27000L,1268728L,76714325L,5732148226L,507120480166L,51689513352516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265003Inst : IEnumerable<long>
{
public static readonly long[] Value=A265003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265003.Bytes);
public long this[int i]=>Value[i];

public static A265003Inst Instance=new A265003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265004
{
public static readonly long[] Value={ 1L,4L,54L,1720L,97341L,8360853L,1001060834L,155796077603L,30055866217955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265004Inst : IEnumerable<long>
{
public static readonly long[] Value=A265004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265004.Bytes);
public long this[int i]=>Value[i];

public static A265004Inst Instance=new A265004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265005
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,4L,1L,1L,3L,7L,9L,1L,1L,3L,14L,29L,21L,1L,1L,4L,21L,112L,140L,51L,1L,1L,4L,41L,261L,1095L,758L,127L,1L,1L,5L,54L,846L,4919L,13009L,4448L,323L,1L,1L,5L,86L,1720L,27000L,120096L,175865L,27782L,835L,1L,1L,6L,120L,4193L,97341L,1268728L,3558888L,2647438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265005Inst : IEnumerable<long>
{
public static readonly long[] Value=A265005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265005.Bytes);
public long this[int i]=>Value[i];

public static A265005Inst Instance=new A265005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265006
{
public static readonly long[] Value={ 5L,7L,11L,13L,29L,31L,41L,43L,71L,73L,239L,241L,419L,421L,461L,463L,599L,601L,1481L,1483L,1721L,1723L,2549L,2551L,2969L,2971L,3539L,3541L,4421L,4423L,8009L,8011L,10301L,10303L,17291L,17293L,19181L,19183L,20021L,20023L,23561L,23563L,24179L,24181L,27059L,27061L,31151L,31153L,35531L,35533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265006Inst : IEnumerable<long>
{
public static readonly long[] Value=A265006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265006.Bytes);
public long this[int i]=>Value[i];

public static A265006Inst Instance=new A265006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265007
{
public static readonly long[] Value={ 1L,1L,3L,7L,18L,40L,97L,216L,499L,1112L,2502L,5503L,12197L,26582L,58088L,125619L,271713L,583228L,1251115L,2668651L,5685053L,12059993L,25544291L,53926003L,113666195L,238946232L,501546514L,1050430420L,2196869731L,4586021745L,9560876381L,19900839742L,41373446190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265007Inst : IEnumerable<long>
{
public static readonly long[] Value=A265007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265007.Bytes);
public long this[int i]=>Value[i];

public static A265007Inst Instance=new A265007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265008
{
public static readonly long[] Value={ 1L,3L,3L,6L,5L,9L,5L,10L,8L,9L,9L,18L,13L,15L,7L,15L,12L,12L,13L,18L,11L,17L,13L,30L,23L,21L,17L,30L,21L,21L,9L,21L,17L,16L,16L,18L,16L,21L,17L,30L,22L,15L,17L,32L,21L,25L,19L,45L,34L,33L,27L,36L,25L,25L,25L,50L,37L,33L,27L,42L,33L,27L,11L,28L,23L,21L,21L,22L,20L,24L,20L,30L,20L,24L,23L,33L,27L,29L,21L,45L,34L,30L,29L,30L,17L,29L,25L,52L,40L,33L,25L,46L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265008Inst : IEnumerable<long>
{
public static readonly long[] Value=A265008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265008.Bytes);
public long this[int i]=>Value[i];

public static A265008Inst Instance=new A265008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265009
{
public static readonly BigInteger[] Value={ 3L,2L,7L,41L,1723L,5L,14835031L,220078129935929L,241L,23L,79L,101L,23291L,11L,223L,BigInteger.Parse("122386298896281959929015788890561251765109069"),38803L,17L,8209L,59L,199L,3340389589L,11527L,13L,47939L,1163L,599L,BigInteger.Parse("27198087874669514440553"),181936481L,31L,383L,9623L,739L,33287L,1061L,6493520653L,587L,709L,6548057L,1823L,361789L,20183L };
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
public class A265009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265009Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265009.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A265009.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265009Inst Instance=new A265009Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265010
{
public static readonly long[] Value={ 0L,1L,4L,10L,16L,20L,35L,40L,56L,80L,84L,100L,120L,140L,165L,200L,220L,224L,286L,336L,350L,364L,400L,455L,480L,560L,660L,680L,700L,816L,840L,880L,969L,1120L,1140L,1144L,1200L,1225L,1330L,1456L,1540L,1650L,1680L,1771L,1820L,1960L,2024L,2200L,2240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265010Inst : IEnumerable<long>
{
public static readonly long[] Value=A265010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265010.Bytes);
public long this[int i]=>Value[i];

public static A265010Inst Instance=new A265010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265011
{
public static readonly long[] Value={ 5L,0L,6L,6L,7L,0L,9L,0L,3L,2L,1L,6L,6L,2L,2L,9L,8L,1L,9L,8L,5L,2L,5L,5L,8L,0L,4L,7L,8L,3L,5L,8L,1L,5L,1L,2L,4L,7L,2L,8L,4L,3L,5L,4L,7L,3L,4L,7L,0L,2L,0L,5L,8L,2L,9L,2L,0L,0L,0L,2L,4L,5L,8L,6L,5L,9L,4L,7L,0L,5L,1L,4L,5L,1L,3L,2L,2L,6L,9L,3L,1L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265011Inst : IEnumerable<long>
{
public static readonly long[] Value=A265011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265011.Bytes);
public long this[int i]=>Value[i];

public static A265011Inst Instance=new A265011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265012
{
public static readonly long[] Value={ 2L,1L,0L,8L,12L,53L,137L,286L,185L,378L,466L,1037L,1518L,1033L,2022L,637L,532L,794L,2011L,3551L,1169L,1660L,2574L,3561L,6597L,5152L,7829L,4816L,10356L,9041L,382L,7206L,16578L,17932L,19073L,12383L,20725L,11248L,21377L,16609L,21660L,21178L,20820L,4826L,37234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265012Inst : IEnumerable<long>
{
public static readonly long[] Value=A265012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265012.Bytes);
public long this[int i]=>Value[i];

public static A265012Inst Instance=new A265012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265013
{
public static readonly long[] Value={ 2L,12382L,27608L,31330L,117852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265013Inst : IEnumerable<long>
{
public static readonly long[] Value=A265013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265013.Bytes);
public long this[int i]=>Value[i];

public static A265013Inst Instance=new A265013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265014
{
public static readonly long[] Value={ 2L,4L,8L,6L,18L,26L,8L,32L,64L,80L,10L,50L,130L,210L,242L,12L,72L,232L,472L,664L,728L,14L,98L,378L,938L,1610L,2058L,2186L,16L,128L,576L,1696L,3488L,5280L,6304L,6560L,18L,162L,834L,2850L,6882L,12258L,16866L,19170L,19682L,20L,200L,1160L,4520L,12584L,26024L,41384L,52904L,58024L,59048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265014Inst : IEnumerable<long>
{
public static readonly long[] Value=A265014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265014.Bytes);
public long this[int i]=>Value[i];

public static A265014Inst Instance=new A265014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265015
{
public static readonly BigInteger[] Value={ 1L,2L,16L,512L,38416L,7962624L,4096000000L,4398046511104L,10000000000000000L,BigInteger.Parse("48717667557975775744"),BigInteger.Parse("451730952053751361306624"),BigInteger.Parse("7982572438812891719395180544"),BigInteger.Parse("268637376395543538746286686601216"),BigInteger.Parse("16132732437821617561429013924830773248") };
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
public class A265015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265015Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265015.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A265015.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265015Inst Instance=new A265015Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265016
{
public static readonly long[] Value={ 1L,1L,2L,6L,9L,20L,43L,74L,130L,241L,493L,774L,1413L,2286L,3987L,7287L,11650L,19235L,31581L,50852L,80867L,141615L,214538L,349179L,541603L,859759L,1303221L,2054700L,3277493L,4960397L,7652897L,11662457L,17703655L,26603187L,40043433L,59384901L,92234897L,134538472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265016Inst : IEnumerable<long>
{
public static readonly long[] Value=A265016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265016.Bytes);
public long this[int i]=>Value[i];

public static A265016Inst Instance=new A265016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265017
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,3L,0L,3L,0L,5L,0L,0L,4L,0L,7L,8L,0L,0L,5L,0L,25L,12L,0L,0L,0L,6L,0L,36L,16L,15L,0L,0L,0L,7L,0L,81L,20L,21L,0L,0L,0L,0L,8L,0L,107L,74L,27L,24L,0L,0L,0L,0L,9L,0L,316L,102L,33L,32L,0L,0L,0L,0L,0L,10L,0L,427L,222L,39L,40L,35L,0L,0L,0L,0L,0L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265017Inst : IEnumerable<long>
{
public static readonly long[] Value=A265017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265017.Bytes);
public long this[int i]=>Value[i];

public static A265017Inst Instance=new A265017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265018
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,4L,8L,7L,5L,16L,12L,9L,6L,40L,16L,11L,7L,34L,55L,20L,13L,8L,50L,73L,70L,24L,15L,9L,125L,132L,96L,85L,28L,17L,10L,281L,212L,119L,100L,32L,19L,11L,351L,469L,267L,142L,115L,36L,21L,12L,307L,642L,644L,322L,165L,130L,40L,23L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265018Inst : IEnumerable<long>
{
public static readonly long[] Value=A265018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265018.Bytes);
public long this[int i]=>Value[i];

public static A265018Inst Instance=new A265018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265019
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,8L,16L,4L,7L,12L,40L,34L,50L,125L,5L,9L,16L,55L,73L,132L,281L,351L,307L,432L,1296L,6L,11L,20L,70L,96L,212L,469L,642L,1020L,1361L,3294L,3305L,3910L,3506L,4802L,16807L,7L,13L,24L,85L,119L,267L,644L,959L,1567L,2686L,5570L,7109L,11890L,13234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265019Inst : IEnumerable<long>
{
public static readonly long[] Value=A265019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265019.Bytes);
public long this[int i]=>Value[i];

public static A265019Inst Instance=new A265019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265020
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,3L,3L,0L,4L,5L,0L,5L,15L,0L,6L,21L,16L,0L,7L,42L,25L,0L,8L,54L,68L,0L,9L,90L,142L,0L,10L,110L,248L,125L,0L,11L,165L,409L,189L,0L,12L,195L,710L,496L,0L,13L,273L,1033L,967L,0L,14L,315L,1562L,2096L,0L,15L,420L,2291L,3265L,1296L,0L,16L,476L,3180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265020Inst : IEnumerable<long>
{
public static readonly long[] Value=A265020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265020.Bytes);
public long this[int i]=>Value[i];

public static A265020Inst Instance=new A265020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265021
{
public static readonly long[] Value={ 0L,32L,1056L,8832L,41600L,141600L,390432L,928256L,1976832L,3866400L,7066400L,12220032L,20182656L,32064032L,49274400L,73574400L,107128832L,152564256L,213030432L,292265600L,394665600L,525356832L,690273056L,896236032L,1151040000L,1463540000L,1843744032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265021Inst : IEnumerable<long>
{
public static readonly long[] Value=A265021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265021.Bytes);
public long this[int i]=>Value[i];

public static A265021Inst Instance=new A265021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265022
{
public static readonly long[] Value={ 1L,1L,0L,-2L,-1L,12L,20L,-113L,-430L,1278L,10821L,-10234L,-317048L,-384915L,10352420L,42836466L,-340348905L,-3180089128L,8045616512L,219303897655L,301713947470L,-14401913182942L,-84197219028827L,824481606288554L,11426928115546036L,-23133559937561187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265022Inst : IEnumerable<long>
{
public static readonly long[] Value=A265022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265022.Bytes);
public long this[int i]=>Value[i];

public static A265022Inst Instance=new A265022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265023
{
public static readonly long[] Value={ 1L,-1L,2L,-4L,9L,-22L,54L,-139L,372L,-948L,2607L,-7388L,16058L,-58957L,174854L,210448L,4345025L,-2008714L,-165872030L,-1756557123L,-6144936528L,60244093040L,1164910003567L,8228177887688L,-10562519450714L,-967088274083133L,-11322641425582454L,-37483806372774364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265023Inst : IEnumerable<long>
{
public static readonly long[] Value=A265023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265023.Bytes);
public long this[int i]=>Value[i];

public static A265023Inst Instance=new A265023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265024
{
public static readonly BigInteger[] Value={ 1L,1L,8L,6L,144L,480L,5760L,5040L,524160L,2177280L,43545600L,159667200L,6706022400L,49816166400L,2092278988800L,1307674368000L,376610217984000L,4623936565248000L,128047474114560000L,729870602452992000L,BigInteger.Parse("77852864261652480000"),BigInteger.Parse("613091306060513280000") };
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
public class A265024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265024Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265024.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A265024.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265024Inst Instance=new A265024Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265025
{
public static readonly long[] Value={ 1L,1L,-1L,-3L,1L,1L,-1L,-15L,1L,1L,-1L,-3L,1L,1L,-9L,-495L,9L,1L,-1L,-3L,1L,1L,-1L,-15L,1L,1L,-1L,-3L,9L,81L,-2025L,-467775L,2025L,81L,-9L,-3L,1L,1L,-1L,-15L,1L,1L,-1L,-3L,1L,1L,-9L,-495L,9L,1L,-1L,-3L,1L,1L,-1L,-15L,9L,81L,-729L,-19683L,164025L,4100625L,-496175625L,-448046589375L,496175625L,4100625L,-164025L,-19683L,729L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265025Inst : IEnumerable<long>
{
public static readonly long[] Value=A265025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265025.Bytes);
public long this[int i]=>Value[i];

public static A265025Inst Instance=new A265025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265026
{
public static readonly long[] Value={ 3L,6L,6L,18L,12L,6L,12L,66L,24L,12L,24L,6L,24L,12L,24L,258L,48L,24L,48L,12L,48L,24L,48L,6L,48L,24L,48L,12L,48L,24L,48L,1026L,96L,48L,96L,24L,96L,48L,96L,12L,96L,48L,96L,24L,96L,48L,96L,6L,96L,48L,96L,24L,96L,48L,96L,12L,96L,48L,96L,24L,96L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265026Inst : IEnumerable<long>
{
public static readonly long[] Value=A265026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265026.Bytes);
public long this[int i]=>Value[i];

public static A265026Inst Instance=new A265026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265027
{
public static readonly long[] Value={ 1L,1L,3L,2L,1L,2L,11L,4L,2L,4L,1L,4L,2L,4L,43L,8L,4L,8L,2L,8L,4L,8L,1L,8L,4L,8L,2L,8L,4L,8L,171L,16L,8L,16L,4L,16L,8L,16L,2L,16L,8L,16L,4L,16L,8L,16L,1L,16L,8L,16L,4L,16L,8L,16L,2L,16L,8L,16L,4L,16L,8L,16L,683L,32L,16L,32L,8L,32L,16L,32L,4L,32L,16L,32L,8L,32L,16L,32L,2L,32L,16L,32L,8L,32L,16L,32L,4L,32L,16L,32L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265027Inst : IEnumerable<long>
{
public static readonly long[] Value=A265027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265027.Bytes);
public long this[int i]=>Value[i];

public static A265027Inst Instance=new A265027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265028
{
public static readonly long[] Value={ 5L,12L,10L,38L,20L,14L,20L,138L,40L,28L,40L,22L,40L,28L,40L,530L,80L,56L,80L,44L,80L,56L,80L,38L,80L,56L,80L,44L,80L,56L,80L,2082L,160L,112L,160L,88L,160L,112L,160L,76L,160L,112L,160L,88L,160L,112L,160L,70L,160L,112L,160L,88L,160L,112L,160L,76L,160L,112L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265028Inst : IEnumerable<long>
{
public static readonly long[] Value=A265028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265028.Bytes);
public long this[int i]=>Value[i];

public static A265028Inst Instance=new A265028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265029
{
public static readonly long[] Value={ 6L,14L,10L,42L,20L,14L,20L,146L,40L,28L,40L,22L,40L,28L,40L,546L,80L,56L,80L,44L,80L,56L,80L,38L,80L,56L,80L,44L,80L,56L,80L,2114L,160L,112L,160L,88L,160L,112L,160L,76L,160L,112L,160L,88L,160L,112L,160L,70L,160L,112L,160L,88L,160L,112L,160L,76L,160L,112L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265029Inst : IEnumerable<long>
{
public static readonly long[] Value=A265029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265029.Bytes);
public long this[int i]=>Value[i];

public static A265029Inst Instance=new A265029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265030
{
public static readonly long[] Value={ 1L,5L,71L,214L,11725L,6031L,415177L,140972L,1305393L,14793725L,289997917L,57882242L,6527639365L,7542845429L,1833039251L,19332937048L,2753465251825L,337099968813L,53020154848357L,28728290846950L,329717936541119L,1057437743438813L,17980324175708377L,1583743732945924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265030Inst : IEnumerable<long>
{
public static readonly long[] Value=A265030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265030.Bytes);
public long this[int i]=>Value[i];

public static A265030Inst Instance=new A265030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265031
{
public static readonly long[] Value={ 1L,1L,5L,7L,209L,65L,2911L,679L,4505L,37829L,564719L,87815L,7865521L,7338631L,1460701L,12776743L,1525870529L,158184065L,21252634831L,9914489123L,98670339035L,276182038859L,4122901604639L,320559963815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265031Inst : IEnumerable<long>
{
public static readonly long[] Value=A265031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265031.Bytes);
public long this[int i]=>Value[i];

public static A265031Inst Instance=new A265031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265032
{
public static readonly long[] Value={ 1L,1L,4L,16L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265032Inst : IEnumerable<long>
{
public static readonly long[] Value=A265032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265032.Bytes);
public long this[int i]=>Value[i];

public static A265032Inst Instance=new A265032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265033
{
public static readonly BigInteger[] Value={ 1L,1L,7L,69L,794L,9976L,132657L,1835406L,26149390L,381047316L,5652729938L,85083226696L,1296149152770L,19946485967765L,309623839343190L,4842246124795062L,76223652657288606L,1206767364167388590L,BigInteger.Parse("19202880705976262634"),BigInteger.Parse("306959907226679676021"),BigInteger.Parse("4926844631755358159974") };
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
public class A265033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265033Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A265033.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A265033.Bytes);
public BigInteger this[int i]=>Value[i];

public static A265033Inst Instance=new A265033Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265034
{
public static readonly long[] Value={ 266L,6590L,65601L,390750L,1679831L,5765085L,16777579L,43047173L,100000551L,214359541L,429982475L,815731628L,1475790101L,2562891818L,4294968647L,6975758960L,11019962273L,16983564926L,25600002083L,37822861652L,54875876045L,78310988018L,110075317151L,152587893847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265034Inst : IEnumerable<long>
{
public static readonly long[] Value=A265034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265034.Bytes);
public long this[int i]=>Value[i];

public static A265034Inst Instance=new A265034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265035
{
public static readonly long[] Value={ 1L,3L,6L,9L,11L,14L,17L,21L,25L,28L,30L,32L,35L,39L,43L,46L,48L,50L,53L,57L,61L,64L,66L,68L,71L,75L,79L,82L,84L,86L,89L,93L,97L,100L,102L,104L,107L,111L,115L,118L,120L,122L,125L,129L,133L,136L,138L,140L,143L,147L,151L,154L,156L,158L,161L,165L,169L,172L,174L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265035Inst : IEnumerable<long>
{
public static readonly long[] Value=A265035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265035.Bytes);
public long this[int i]=>Value[i];

public static A265035Inst Instance=new A265035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265036
{
public static readonly long[] Value={ 1L,4L,6L,7L,10L,14L,20L,24L,24L,23L,26L,34L,42L,44L,40L,37L,42L,54L,64L,64L,56L,51L,58L,74L,86L,84L,72L,65L,74L,94L,108L,104L,88L,79L,90L,114L,130L,124L,104L,93L,106L,134L,152L,144L,120L,107L,122L,154L,174L,164L,136L,121L,138L,174L,196L,184L,152L,135L,154L,194L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265036Inst : IEnumerable<long>
{
public static readonly long[] Value=A265036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265036.Bytes);
public long this[int i]=>Value[i];

public static A265036Inst Instance=new A265036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265037
{
public static readonly long[] Value={ 1L,30L,185L,886L,3855L,16064L,65569L,264930L,1065059L,4270948L,17105253L,68463974L,273941863L,1095939432L,4384101737L,17537095018L,70149756267L,280601777516L,1122412615021L,4489661470062L,17958667900271L,71834715641200L,287338950645105L,1149355978741106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265037Inst : IEnumerable<long>
{
public static readonly long[] Value=A265037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265037.Bytes);
public long this[int i]=>Value[i];

public static A265037Inst Instance=new A265037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265038
{
public static readonly long[] Value={ 1L,13L,63L,183L,401L,745L,1291L,2019L,2921L,4133L,5659L,7443L,9597L,12149L,15103L,18535L,22389L,26729L,31727L,37231L,43233L,50001L,57443L,65467L,74281L,83853L,94187L,105419L,117397L,130221L,144159L,158927L,174517L,191329L,209175L,227927L,247889L,268969L,291171L,314691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265038Inst : IEnumerable<long>
{
public static readonly long[] Value=A265038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265038.Bytes);
public long this[int i]=>Value[i];

public static A265038Inst Instance=new A265038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265039
{
public static readonly long[] Value={ 1L,15L,51L,101L,169L,331L,531L,737L,1013L,1435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265039Inst : IEnumerable<long>
{
public static readonly long[] Value=A265039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265039.Bytes);
public long this[int i]=>Value[i];

public static A265039Inst Instance=new A265039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265040
{
public static readonly long[] Value={ 12L,48L,132L,300L,576L,960L,1488L,2184L,3120L,4224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265040Inst : IEnumerable<long>
{
public static readonly long[] Value=A265040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265040.Bytes);
public long this[int i]=>Value[i];

public static A265040Inst Instance=new A265040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265041
{
public static readonly long[] Value={ 1L,120L,600L,720L,3600L,1440L,6000L,9600L,2520L,14400L,4800L,14400L,28800L,3600L,50400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265041Inst : IEnumerable<long>
{
public static readonly long[] Value=A265041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265041.Bytes);
public long this[int i]=>Value[i];

public static A265041Inst Instance=new A265041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265042
{
public static readonly long[] Value={ 2L,7L,51L,634L,12623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265042Inst : IEnumerable<long>
{
public static readonly long[] Value=A265042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265042.Bytes);
public long this[int i]=>Value[i];

public static A265042Inst Instance=new A265042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265043
{
public static readonly long[] Value={ 10L,12L,17L,115L,971L,1364L,9711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265043Inst : IEnumerable<long>
{
public static readonly long[] Value=A265043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265043.Bytes);
public long this[int i]=>Value[i];

public static A265043Inst Instance=new A265043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265044
{
public static readonly long[] Value={ 1L,4L,9L,16L,26L,41L,62L,90L,128L,181L,254L,352L,483L,660L,900L,1224L,1661L,2252L,3052L,4133L,5592L,7562L,10224L,13821L,18680L,25244L,34113L,46096L,62284L,84152L,113695L,153608L,207530L,280377L,378792L,511750L,691374L,934041L,1261878L,1704780L,2303133L,3111496L,4203578L,5678960L,7672173L,10364964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265044Inst : IEnumerable<long>
{
public static readonly long[] Value=A265044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265044.Bytes);
public long this[int i]=>Value[i];

public static A265044Inst Instance=new A265044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265045
{
public static readonly long[] Value={ 1L,3L,7L,11L,14L,18L,23L,28L,32L,36L,40L,44L,48L,52L,56L,60L,64L,68L,72L,76L,80L,84L,88L,92L,96L,100L,104L,108L,112L,116L,120L,124L,128L,132L,136L,140L,144L,148L,152L,156L,160L,164L,168L,172L,176L,180L,184L,188L,192L,196L,200L,204L,208L,212L,216L,220L,224L,228L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265045Inst : IEnumerable<long>
{
public static readonly long[] Value=A265045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265045.Bytes);
public long this[int i]=>Value[i];

public static A265045Inst Instance=new A265045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265046
{
public static readonly long[] Value={ 1L,3L,5L,8L,13L,18L,23L,28L,32L,36L,40L,44L,48L,52L,56L,60L,64L,68L,72L,76L,80L,84L,88L,92L,96L,100L,104L,108L,112L,116L,120L,124L,128L,132L,136L,140L,144L,148L,152L,156L,160L,164L,168L,172L,176L,180L,184L,188L,192L,196L,200L,204L,208L,212L,216L,220L,224L,228L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265046Inst : IEnumerable<long>
{
public static readonly long[] Value=A265046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265046.Bytes);
public long this[int i]=>Value[i];

public static A265046Inst Instance=new A265046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265047
{
public static readonly long[] Value={ 1L,4L,9L,17L,29L,46L,70L,103L,148L,210L,295L,411L,569L,783L,1074L,1470L,2008L,2740L,3736L,5091L,6934L,9440L,12848L,17483L,23786L,32358L,44016L,59871L,81435L,110762L,150646L,204888L,278657L,378983L,515426L,700988L,953353L,1296570L,1763345L,2398159L,3261505L,4435655L,6032499L,8204206L,11157727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265047Inst : IEnumerable<long>
{
public static readonly long[] Value=A265047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265047.Bytes);
public long this[int i]=>Value[i];

public static A265047Inst Instance=new A265047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265048
{
public static readonly long[] Value={ 1L,4L,9L,17L,30L,50L,80L,125L,193L,296L,450L,680L,1025L,1541L,2312L,3466L,5194L,7781L,11653L,17448L,26122L,39104L,58533L,87613L,131138L,196282L,293784L,439717L,658137L,985048L,1474338L,2206664L,3302745L,4943261L,7398640L,11073634L,16574038L,24806553L,37128249L,55570268L,83172642L,124485420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265048Inst : IEnumerable<long>
{
public static readonly long[] Value=A265048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265048.Bytes);
public long this[int i]=>Value[i];

public static A265048Inst Instance=new A265048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265049
{
public static readonly long[] Value={ 1L,4L,9L,17L,29L,47L,74L,113L,170L,253L,374L,550L,804L,1171L,1702L,2472L,3588L,5204L,7545L,10936L,15848L,22962L,33265L,48188L,69803L,101112L,146461L,212145L,307283L,445083L,644676L,933770L,1352500L,1958999L,2837467L,4109861L,5952825L,8622216L,12488623L,18088816L,26200265L,37949074L,54966320L,79614492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265049Inst : IEnumerable<long>
{
public static readonly long[] Value=A265049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265049.Bytes);
public long this[int i]=>Value[i];

public static A265049Inst Instance=new A265049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265050
{
public static readonly long[] Value={ 1L,4L,10L,21L,39L,68L,114L,186L,298L,472L,743L,1165L,1822L,2844L,4434L,6908L,10758L,16749L,26071L,40576L,63146L,98266L,152914L,237948L,370263L,576149L,896514L,1395012L,2170690L,3377668L,5255762L,8178133L,12725431L,19801164L,30811218L,47943194L,74601066L,116081520L,180626359L,281060077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265050Inst : IEnumerable<long>
{
public static readonly long[] Value=A265050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265050.Bytes);
public long this[int i]=>Value[i];

public static A265050Inst Instance=new A265050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265051
{
public static readonly long[] Value={ 1L,4L,10L,22L,44L,84L,156L,284L,512L,918L,1642L,2932L,5230L,9324L,16618L,29614L,52768L,94020L,167516L,298460L,531756L,947406L,1687946L,3007324L,5357986L,9546028L,17007626L,30301534L,53986540L,96184780L,171367004L,305314932L,543962400L,969147134L,1726674794L,3076319100L,5480904238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265051Inst : IEnumerable<long>
{
public static readonly long[] Value=A265051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265051.Bytes);
public long this[int i]=>Value[i];

public static A265051Inst Instance=new A265051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265052
{
public static readonly long[] Value={ 1L,4L,10L,22L,45L,89L,172L,328L,622L,1176L,2220L,4186L,7888L,14859L,27987L,52710L,99268L,186946L,352062L,663010L,1248588L,2351350L,4428075L,8338971L,15703984L,29573802L,55693492L,104882184L,197514502L,371960008L,700476396L,1319139609L,2484208341L,4678269862L,8810134210L,16591275636L,31244748450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265052Inst : IEnumerable<long>
{
public static readonly long[] Value=A265052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265052.Bytes);
public long this[int i]=>Value[i];

public static A265052Inst Instance=new A265052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265053
{
public static readonly long[] Value={ 1L,4L,10L,21L,40L,73L,130L,228L,396L,684L,1178L,2025L,3476L,5961L,10218L,17512L,30010L,51424L,88114L,150977L,258684L,443225L,759410L,1301148L,2229340L,3819668L,6544474L,11213049L,19212000L,32917085L,56398834L,96631532L,165564642L,283671900L,486032194L,832748301L,1426797936L,2444619033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265053Inst : IEnumerable<long>
{
public static readonly long[] Value=A265053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265053.Bytes);
public long this[int i]=>Value[i];

public static A265053Inst Instance=new A265053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265054
{
public static readonly long[] Value={ 1L,4L,10L,22L,46L,94L,188L,372L,734L,1446L,2844L,5588L,10976L,21556L,42330L,83120L,163214L,320484L,629292L,1235652L,2426272L,4764118L,9354602L,18368260L,36067056L,70819582L,139058010L,273047782L,536143806L,1052746804L,2067124190L,4058907988L,7969881118L,15649284294L,30728199738L,60336449982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265054Inst : IEnumerable<long>
{
public static readonly long[] Value=A265054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265054.Bytes);
public long this[int i]=>Value[i];

public static A265054Inst Instance=new A265054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265055
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,37L,53L,74L,101L,135L,179L,237L,313L,411L,537L,700L,912L,1188L,1546L,2009L,2608L,3385L,4394L,5703L,7399L,9596L,12444L,16138L,20929L,27140L,35190L,45625L,59155L,76699L,99445L,128932L,167158L,216717L,280972L,364279L,472282L,612300L,793827L,1029174L,1334298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265055Inst : IEnumerable<long>
{
public static readonly long[] Value=A265055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265055.Bytes);
public long this[int i]=>Value[i];

public static A265055Inst Instance=new A265055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265056
{
public static readonly long[] Value={ 1L,5L,21L,45L,77L,117L,165L,221L,285L,357L,437L,525L,621L,725L,837L,957L,1085L,1221L,1365L,1517L,1677L,1845L,2021L,2205L,2397L,2597L,2805L,3021L,3245L,3477L,3717L,3965L,4221L,4485L,4757L,5037L,5325L,5621L,5925L,6237L,6557L,6885L,7221L,7565L,7917L,8277L,8645L,9021L,9405L,9797L,10197L,10605L,11021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265056Inst : IEnumerable<long>
{
public static readonly long[] Value=A265056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265056.Bytes);
public long this[int i]=>Value[i];

public static A265056Inst Instance=new A265056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265057
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,12L,16L,20L,24L,28L,33L,40L,48L,57L,67L,78L,92L,109L,129L,152L,178L,209L,246L,290L,342L,402L,472L,555L,653L,769L,905L,1064L,1251L,1471L,1731L,2037L,2396L,2818L,3314L,3898L,4586L,5395L,6346L,7464L,8779L,10327L,12148L,14290L,16809L,19771L,23256L,27356L,32179L,37852L,44524L,52372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265057Inst : IEnumerable<long>
{
public static readonly long[] Value=A265057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265057.Bytes);
public long this[int i]=>Value[i];

public static A265057Inst Instance=new A265057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265058
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,12L,16L,21L,27L,33L,40L,49L,61L,76L,94L,116L,142L,174L,214L,264L,326L,401L,493L,606L,745L,917L,1129L,1390L,1710L,2103L,2587L,3183L,3917L,4820L,5931L,7297L,8977L,11045L,13590L,16722L,20575L,25315L,31147L,38322L,47151L,58015L,71382L,87828L,108062L,132958L,163590L,201280L,247654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265058Inst : IEnumerable<long>
{
public static readonly long[] Value=A265058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265058.Bytes);
public long this[int i]=>Value[i];

public static A265058Inst Instance=new A265058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265059
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,12L,16L,21L,28L,36L,45L,56L,70L,89L,113L,143L,181L,228L,287L,361L,455L,575L,726L,916L,1155L,1456L,1836L,2315L,2920L,3684L,4647L,5861L,7391L,9321L,11756L,14827L,18701L,23587L,29749L,37520L,47320L,59681L,75272L,94936L,119737L,151016L,190466L,240221L,302973L,382119L,481941L,607840L,766627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265059Inst : IEnumerable<long>
{
public static readonly long[] Value=A265059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265059.Bytes);
public long this[int i]=>Value[i];

public static A265059Inst Instance=new A265059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265060
{
public static readonly long[] Value={ 1L,3L,5L,8L,12L,16L,21L,28L,36L,46L,60L,77L,98L,126L,162L,207L,265L,340L,435L,557L,714L,914L,1170L,1499L,1920L,2458L,3148L,4032L,5163L,6612L,8468L,10844L,13887L,17785L,22776L,29167L,37353L,47836L,61260L,78452L,100469L,128664L,164772L,211014L,270232L,346069L,443190L,567566L,726846L,930827L,1192053L,1526588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265060Inst : IEnumerable<long>
{
public static readonly long[] Value=A265060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265060.Bytes);
public long this[int i]=>Value[i];

public static A265060Inst Instance=new A265060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265061
{
public static readonly long[] Value={ 1L,3L,5L,8L,12L,17L,24L,33L,45L,61L,83L,114L,155L,210L,286L,389L,529L,720L,979L,1331L,1810L,2462L,3349L,4554L,6193L,8423L,11455L,15579L,21188L,28815L,39188L,53296L,72483L,98577L,134064L,182327L,247965L,337232L,458636L,623745L,848292L,1153677L,1569001L,2133841L,2902023L,3946750L,5367579L,7299906L,9927870L,13501901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265061Inst : IEnumerable<long>
{
public static readonly long[] Value=A265061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265061.Bytes);
public long this[int i]=>Value[i];

public static A265061Inst Instance=new A265061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265062
{
public static readonly long[] Value={ 1L,3L,5L,8L,12L,17L,25L,36L,50L,70L,98L,137L,193L,271L,379L,531L,744L,1042L,1461L,2048L,2869L,4020L,5633L,7893L,11061L,15500L,21719L,30434L,42646L,59758L,83738L,117340L,164424L,230402L,322855L,452406L,633943L,888325L,1244781L,1744272L,2444193L,3424970L,4799303L,6725112L,9423686L,13205113L,18503907L,25928939L,36333403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265062Inst : IEnumerable<long>
{
public static readonly long[] Value=A265062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265062.Bytes);
public long this[int i]=>Value[i];

public static A265062Inst Instance=new A265062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265063
{
public static readonly long[] Value={ 1L,3L,5L,8L,12L,17L,25L,37L,53L,75L,107L,152L,216L,309L,441L,628L,895L,1275L,1816L,2588L,3689L,5257L,7491L,10675L,15211L,21675L,30888L,44016L,62723L,89381L,127368L,181499L,258637L,368560L,525200L,748413L,1066493L,1519757L,2165661L,3086079L,4397679L,6266716L,8930104L,12725445L,18133825L,25840796L,36823271L,52473355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265063Inst : IEnumerable<long>
{
public static readonly long[] Value=A265063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265063.Bytes);
public long this[int i]=>Value[i];

public static A265063Inst Instance=new A265063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265064
{
public static readonly long[] Value={ 1L,3L,5L,8L,13L,19L,26L,37L,53L,74L,103L,145L,204L,285L,399L,560L,785L,1099L,1540L,2159L,3025L,4238L,5939L,8323L,11662L,16341L,22899L,32088L,44963L,63005L,88288L,123715L,173357L,242920L,340397L,476987L,668386L,936589L,1312413L,1839042L,2576991L,3611057L,5060060L,7090501L,9935695L,13922576L,19509265L,27337715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265064Inst : IEnumerable<long>
{
public static readonly long[] Value=A265064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265064.Bytes);
public long this[int i]=>Value[i];

public static A265064Inst Instance=new A265064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265065
{
public static readonly long[] Value={ 1L,3L,5L,8L,13L,20L,29L,42L,62L,91L,132L,192L,281L,410L,597L,870L,1269L,1851L,2698L,3933L,5735L,8362L,12191L,17774L,25915L,37784L,55088L,80317L,117102L,170734L,248927L,362932L,529151L,771496L,1124831L,1639989L,2391084L,3486171L,5082793L,7410648L,10804633L,15753020L,22967705L,33486626L,48823082L,71183443L,103784568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265065Inst : IEnumerable<long>
{
public static readonly long[] Value=A265065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265065.Bytes);
public long this[int i]=>Value[i];

public static A265065Inst Instance=new A265065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265066
{
public static readonly long[] Value={ 1L,3L,5L,8L,13L,20L,30L,45L,67L,100L,149L,221L,329L,491L,731L,1087L,1618L,2409L,3586L,5338L,7946L,11828L,17607L,26209L,39013L,58074L,86448L,128683L,191552L,285138L,424447L,631817L,940501L,1399997L,2083987L,3102151L,4617754L,6873828L,10232143L,15231214L,22672656L,33749729L,50238677L,74783553L,111320204L,165707396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265066Inst : IEnumerable<long>
{
public static readonly long[] Value=A265066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265066.Bytes);
public long this[int i]=>Value[i];

public static A265066Inst Instance=new A265066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265067
{
public static readonly long[] Value={ 1L,3L,5L,8L,13L,20L,30L,46L,70L,105L,158L,238L,358L,539L,813L,1225L,1844L,2777L,4183L,6300L,9488L,14291L,21525L,32419L,48827L,73540L,110761L,166821L,251256L,378426L,569960L,858437L,1292923L,1947317L,2932923L,4417381L,6653176L,10020585L,15092360L,22731142L,34236184L,51564338L,77662890L,116970850L,176173970L,265341902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265067Inst : IEnumerable<long>
{
public static readonly long[] Value=A265067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265067.Bytes);
public long this[int i]=>Value[i];

public static A265067Inst Instance=new A265067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265068
{
public static readonly long[] Value={ 1L,3L,5L,8L,13L,20L,30L,46L,71L,109L,167L,256L,393L,603L,925L,1419L,2177L,3340L,5124L,7861L,12060L,18502L,28385L,43547L,66808L,102494L,157242L,241234L,370091L,567778L,871061L,1336345L,2050164L,3145275L,4825348L,7402845L,11357132L,17423632L,26730600L,41008957L,62914209L,96520321L,148077398L,227174087L,348520885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265068Inst : IEnumerable<long>
{
public static readonly long[] Value=A265068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265068.Bytes);
public long this[int i]=>Value[i];

public static A265068Inst Instance=new A265068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265069
{
public static readonly long[] Value={ 1L,3L,5L,8L,13L,21L,32L,47L,71L,108L,163L,245L,368L,555L,837L,1260L,1897L,2857L,4304L,6483L,9763L,14704L,22147L,33357L,50240L,75667L,113965L,171648L,258525L,389373L,586448L,883271L,1330327L,2003652L,3017771L,4545173L,6845648L,10310475L,15528973L,23388740L,35226617L,53056065L,79909632L,120354747L,181270579L,273018088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265069Inst : IEnumerable<long>
{
public static readonly long[] Value=A265069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265069.Bytes);
public long this[int i]=>Value[i];

public static A265069Inst Instance=new A265069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265070
{
public static readonly long[] Value={ 1L,3L,5L,8L,13L,21L,33L,51L,80L,126L,198L,311L,488L,766L,1203L,1889L,2966L,4657L,7312L,11481L,18027L,28305L,44443L,69782L,109568L,172038L,270125L,424136L,665956L,1045649L,1641823L,2577904L,4047689L,6355468L,9979021L,15668533L,24601905L,38628615L,60652616L,95233542L,149530690L,234785211L,368647368L,578830674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265070Inst : IEnumerable<long>
{
public static readonly long[] Value=A265070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265070.Bytes);
public long this[int i]=>Value[i];

public static A265070Inst Instance=new A265070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265071
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,22L,31L,44L,62L,87L,122L,171L,240L,336L,471L,660L,925L,1296L,1816L,2545L,3566L,4997L,7002L,9812L,13749L,19266L,26997L,37830L,53010L,74281L,104088L,145855L,204382L,286394L,401315L,562350L,788003L,1104204L,1547286L,2168163L,3038178L,4257303L,5965624L,8359440L,11713819L,16414204L,23000705L,32230160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265071Inst : IEnumerable<long>
{
public static readonly long[] Value=A265071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265071.Bytes);
public long this[int i]=>Value[i];

public static A265071Inst Instance=new A265071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265072
{
public static readonly long[] Value={ 1L,3L,6L,10L,16L,25L,38L,57L,86L,130L,196L,295L,444L,669L,1008L,1518L,2286L,3443L,5186L,7811L,11764L,17718L,26686L,40193L,60536L,91175L,137322L,206826L,311508L,469173L,706638L,1064293L,1602970L,2414290L,3636248L,5476683L,8248628L,12423553L,18711556L,28182142L,42446130L,63929631L,96286698L,145020831L,218421048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265072Inst : IEnumerable<long>
{
public static readonly long[] Value=A265072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265072.Bytes);
public long this[int i]=>Value[i];

public static A265072Inst Instance=new A265072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265073
{
public static readonly long[] Value={ 1L,3L,6L,10L,16L,26L,41L,64L,99L,154L,240L,374L,582L,905L,1408L,2191L,3410L,5306L,8256L,12846L,19989L,31104L,48399L,75310L,117184L,182342L,283730L,441493L,686976L,1068955L,1663326L,2588186L,4027296L,6266594L,9751009L,15172864L,23609435L,36736994L,57163872L,88948710L,138406878L,215365281L,335114880L,521448871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265073Inst : IEnumerable<long>
{
public static readonly long[] Value=A265073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265073.Bytes);
public long this[int i]=>Value[i];

public static A265073Inst Instance=new A265073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265074
{
public static readonly long[] Value={ 1L,3L,6L,10L,16L,26L,42L,67L,106L,167L,264L,418L,662L,1048L,1658L,2623L,4150L,6567L,10392L,16444L,26020L,41172L,65148L,103087L,163120L,258113L,408424L,646268L,1022620L,1618140L,2560460L,4051537L,6410938L,10144329L,16051850L,25399600L,40190986L,63596094L,100631100L,159233337L,251962422L,398692029L,630869210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265074Inst : IEnumerable<long>
{
public static readonly long[] Value=A265074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265074.Bytes);
public long this[int i]=>Value[i];

public static A265074Inst Instance=new A265074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265075
{
public static readonly long[] Value={ 1L,3L,6L,11L,18L,29L,46L,73L,116L,183L,290L,459L,726L,1149L,1818L,2877L,4552L,7203L,11398L,18035L,28538L,45157L,71454L,113065L,178908L,283095L,447954L,708819L,1121598L,1774757L,2808282L,4443677L,7031440L,11126179L,17605478L,27857979L,44080994L,69751437L,110370990L,174645225L,276349380L,437280663L,691929826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265075Inst : IEnumerable<long>
{
public static readonly long[] Value=A265075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265075.Bytes);
public long this[int i]=>Value[i];

public static A265075Inst Instance=new A265075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265076
{
public static readonly long[] Value={ 1L,3L,6L,11L,20L,35L,60L,103L,178L,307L,528L,909L,1566L,2697L,4644L,7997L,13772L,23717L,40842L,70333L,121120L,208579L,359190L,618555L,1065204L,1834371L,3158940L,5439959L,9368066L,16132595L,27781680L,47842381L,82388590L,141880057L,244329348L,420755613L,724576428L,1247781333L,2148784026L,3700386173L,6372375104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265076Inst : IEnumerable<long>
{
public static readonly long[] Value=A265076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265076.Bytes);
public long this[int i]=>Value[i];

public static A265076Inst Instance=new A265076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265077
{
public static readonly long[] Value={ 1L,3L,6L,11L,20L,37L,66L,117L,208L,371L,662L,1179L,2100L,3741L,6666L,11877L,21160L,37699L,67166L,119667L,213204L,379853L,676762L,1205749L,2148216L,3827355L,6818982L,12148995L,21645180L,38563997L,68707298L,122411917L,218094408L,388566507L,692287030L,1233408755L,2197494812L,3915152565L,6975406506L,12427688349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265077Inst : IEnumerable<long>
{
public static readonly long[] Value=A265077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265077.Bytes);
public long this[int i]=>Value[i];

public static A265077Inst Instance=new A265077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265078
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,37L,52L,69L,88L,109L,133L,160L,189L,220L,253L,289L,328L,369L,412L,457L,505L,556L,609L,664L,721L,781L,844L,909L,976L,1045L,1117L,1192L,1269L,1348L,1429L,1513L,1600L,1689L,1780L,1873L,1969L,2068L,2169L,2272L,2377L,2485L,2596L,2709L,2824L,2941L,3061L,3184L,3309L,3436L,3565L,3697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265078Inst : IEnumerable<long>
{
public static readonly long[] Value=A265078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265078.Bytes);
public long this[int i]=>Value[i];

public static A265078Inst Instance=new A265078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265079
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,33L,36L,49L,453L,727L,1560L,1569L,1627L,5078L,6605L,17663L,27281L,29298L,29708L,39509L,98653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265079Inst : IEnumerable<long>
{
public static readonly long[] Value=A265079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265079.Bytes);
public long this[int i]=>Value[i];

public static A265079Inst Instance=new A265079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265080
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,2L,2L,0L,0L,3L,6L,3L,0L,0L,4L,12L,18L,4L,0L,0L,5L,20L,51L,44L,5L,0L,0L,6L,30L,108L,192L,110L,6L,0L,0L,7L,42L,195L,544L,675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265080Inst : IEnumerable<long>
{
public static readonly long[] Value=A265080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265080.Bytes);
public long this[int i]=>Value[i];

public static A265080Inst Instance=new A265080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A265081
{
public static readonly long[] Value={ 0L,4L,44L,192L,544L,1220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A265081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A265081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A265081Inst : IEnumerable<long>
{
public static readonly long[] Value=A265081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A265081.Bytes);
public long this[int i]=>Value[i];

public static A265081Inst Instance=new A265081Inst();

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