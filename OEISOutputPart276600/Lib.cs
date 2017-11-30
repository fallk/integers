using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A075123
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,14L,17L,22L,25L,30L,33L,38L,41L,46L,49L,54L,57L,62L,65L,70L,73L,78L,81L,86L,89L,94L,97L,102L,105L,110L,113L,118L,121L,126L,129L,134L,137L,142L,145L,150L,153L,158L,161L,166L,169L,174L,177L,182L,185L,190L,193L,198L,201L,206L,209L,214L,217L,222L,225L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075123Inst : IEnumerable<long>
{
public static readonly long[] Value=A075123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075123.Bytes);
public long this[int i]=>Value[i];

public static A075123Inst Instance=new A075123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075156
{
public static readonly long[] Value={ 5L,6L,10L,24L,70L,216L,664L,2008L,5998L,17808L,52770L,156360L,463492L,1374392L,4076222L,12090144L,35859742L,106359928L,315460168L,935639768L,2775057510L,8230670416L,24411730298L,72403913480L,214746249796L,636926269816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075156Inst : IEnumerable<long>
{
public static readonly long[] Value=A075156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075156.Bytes);
public long this[int i]=>Value[i];

public static A075156Inst Instance=new A075156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075157
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,8L,7L,11L,14L,6L,9L,17L,24L,26L,15L,23L,44L,34L,29L,13L,10L,20L,19L,35L,74L,48L,49L,53L,124L,80L,31L,47L,134L,174L,89L,69L,76L,104L,59L,27L,32L,12L,21L,41L,54L,62L,39L,71L,224L,244L,149L,97L,120L,146L,99L,107L,374L,342L,249L,161L,624L,242L,63L,95L,404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075157Inst : IEnumerable<long>
{
public static readonly long[] Value=A075157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075157.Bytes);
public long this[int i]=>Value[i];

public static A075157Inst Instance=new A075157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075158
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,10L,7L,6L,11L,21L,8L,42L,20L,9L,15L,85L,12L,170L,23L,22L,43L,341L,16L,13L,84L,14L,40L,682L,19L,1365L,31L,41L,171L,18L,24L,2730L,340L,86L,47L,5461L,44L,10922L,87L,17L,683L,21845L,32L,26L,27L,169L,168L,43690L,28L,45L,80L,342L,1364L,87381L,39L,174762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075158Inst : IEnumerable<long>
{
public static readonly long[] Value=A075158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075158.Bytes);
public long this[int i]=>Value[i];

public static A075158Inst Instance=new A075158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075159
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,9L,8L,12L,15L,7L,10L,18L,25L,27L,16L,24L,45L,35L,30L,14L,11L,21L,20L,36L,75L,49L,50L,54L,125L,81L,32L,48L,135L,175L,90L,70L,77L,105L,60L,28L,33L,13L,22L,42L,55L,63L,40L,72L,225L,245L,150L,98L,121L,147L,100L,108L,375L,343L,250L,162L,625L,243L,64L,96L,405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075159Inst : IEnumerable<long>
{
public static readonly long[] Value=A075159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075159.Bytes);
public long this[int i]=>Value[i];

public static A075159Inst Instance=new A075159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075160
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,11L,8L,7L,12L,22L,9L,43L,21L,10L,16L,86L,13L,171L,24L,23L,44L,342L,17L,14L,85L,15L,41L,683L,20L,1366L,32L,42L,172L,19L,25L,2731L,341L,87L,48L,5462L,45L,10923L,88L,18L,684L,21846L,33L,27L,28L,170L,169L,43691L,29L,46L,81L,343L,1365L,87382L,40L,174763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075160Inst : IEnumerable<long>
{
public static readonly long[] Value=A075160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075160.Bytes);
public long this[int i]=>Value[i];

public static A075160Inst Instance=new A075160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075161
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,9L,7L,6L,10L,23L,12L,65L,24L,11L,8L,197L,15L,626L,26L,25L,66L,2056L,13L,14L,198L,16L,68L,6918L,29L,23714L,17L,67L,627L,28L,40L,82500L,2057L,199L,27L,290512L,71L,1033412L,200L,30L,6919L,3707852L,31L,37L,38L,628L,629L,13402697L,43L,70L,69L,2058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075161Inst : IEnumerable<long>
{
public static readonly long[] Value=A075161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075161.Bytes);
public long this[int i]=>Value[i];

public static A075161Inst Instance=new A075161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075162
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,7L,15L,6L,9L,14L,11L,23L,24L,17L,26L,31L,63L,80L,511L,255L,65535L,10L,13L,20L,19L,39L,34L,29L,44L,47L,95L,134L,767L,383L,98303L,48L,49L,74L,35L,71L,124L,53L,242L,127L,1023L,728L,32767L,4095L,16777215L,624L,161L,19682L,33554431L,262143L,6560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075162Inst : IEnumerable<long>
{
public static readonly long[] Value=A075162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075162.Bytes);
public long this[int i]=>Value[i];

public static A075162Inst Instance=new A075162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075163
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,10L,8L,7L,11L,24L,13L,66L,25L,12L,9L,198L,16L,627L,27L,26L,67L,2057L,14L,15L,199L,17L,69L,6919L,30L,23715L,18L,68L,628L,29L,41L,82501L,2058L,200L,28L,290513L,72L,1033413L,201L,31L,6920L,3707853L,32L,38L,39L,629L,630L,13402698L,44L,71L,70L,2059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075163Inst : IEnumerable<long>
{
public static readonly long[] Value=A075163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075163.Bytes);
public long this[int i]=>Value[i];

public static A075163Inst Instance=new A075163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075164
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,9L,8L,16L,7L,10L,15L,12L,24L,25L,18L,27L,32L,64L,81L,512L,256L,65536L,11L,14L,21L,20L,40L,35L,30L,45L,48L,96L,135L,768L,384L,98304L,49L,50L,75L,36L,72L,125L,54L,243L,128L,1024L,729L,32768L,4096L,16777216L,625L,162L,19683L,33554432L,262144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075164Inst : IEnumerable<long>
{
public static readonly long[] Value=A075164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075164.Bytes);
public long this[int i]=>Value[i];

public static A075164Inst Instance=new A075164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075165
{
public static readonly long[] Value={ 0L,2L,10L,12L,42L,44L,170L,52L,50L,172L,682L,180L,2730L,684L,178L,56L,10922L,204L,43690L,692L,690L,2732L,174762L,184L,202L,10924L,210L,2740L,699050L,716L,2796202L,212L,2738L,43692L,714L,820L,11184810L,174764L,10930L,696L,44739242L,2764L,178956970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075165Inst : IEnumerable<long>
{
public static readonly long[] Value=A075165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075165.Bytes);
public long this[int i]=>Value[i];

public static A075165Inst Instance=new A075165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075166
{
public static readonly long[] Value={ 0L,10L,1010L,1100L,101010L,101100L,10101010L,110100L,110010L,10101100L,1010101010L,10110100L,101010101010L,1010101100L,10110010L,111000L,10101010101010L,11001100L,1010101010101010L,1010110100L,1010110010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075166Inst : IEnumerable<long>
{
public static readonly long[] Value=A075166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075166.Bytes);
public long this[int i]=>Value[i];

public static A075166Inst Instance=new A075166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075167
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,3L,3L,4L,5L,4L,6L,5L,4L,3L,7L,4L,8L,5L,5L,6L,9L,4L,4L,7L,4L,6L,10L,5L,11L,4L,6L,8L,5L,5L,12L,9L,7L,5L,13L,6L,14L,7L,5L,10L,15L,5L,5L,5L,8L,8L,16L,5L,6L,6L,9L,11L,17L,6L,18L,12L,6L,4L,7L,7L,19L,9L,10L,6L,20L,5L,21L,13L,5L,10L,6L,8L,22L,6L,4L,14L,23L,7L,8L,15L,11L,7L,24L,6L,7L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075167Inst : IEnumerable<long>
{
public static readonly long[] Value=A075167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075167.Bytes);
public long this[int i]=>Value[i];

public static A075167Inst Instance=new A075167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075168
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,6L,7L,12L,11L,9L,10L,15L,14L,16L,8L,13L,30L,28L,29L,24L,23L,25L,26L,40L,39L,37L,38L,43L,42L,19L,18L,32L,33L,84L,85L,80L,79L,81L,82L,68L,67L,65L,66L,71L,70L,72L,27L,41L,114L,112L,113L,108L,107L,109L,110L,124L,123L,121L,122L,52L,51L,47L,17L,31L,89L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075168Inst : IEnumerable<long>
{
public static readonly long[] Value=A075168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075168.Bytes);
public long this[int i]=>Value[i];

public static A075168Inst Instance=new A075168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075169
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,6L,7L,15L,10L,11L,9L,8L,16L,13L,12L,14L,63L,31L,30L,127L,255L,65535L,21L,20L,22L,23L,47L,18L,19L,17L,64L,32L,33L,128L,256L,65536L,26L,27L,25L,24L,48L,29L,28L,126L,2047L,4095L,62L,1023L,511L,131071L,61L,60L,254L,16383L,8191L,510L,32767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075169Inst : IEnumerable<long>
{
public static readonly long[] Value=A075169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075169.Bytes);
public long this[int i]=>Value[i];

public static A075169Inst Instance=new A075169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075170
{
public static readonly long[] Value={ 0L,2L,10L,12L,44L,42L,50L,52L,180L,178L,170L,172L,204L,202L,210L,56L,184L,722L,714L,716L,684L,682L,690L,692L,820L,818L,810L,812L,844L,842L,226L,216L,728L,738L,2890L,2892L,2860L,2858L,2866L,2868L,2740L,2738L,2730L,2732L,2764L,2762L,2770L,696L,824L,3282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075170Inst : IEnumerable<long>
{
public static readonly long[] Value=A075170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075170.Bytes);
public long this[int i]=>Value[i];

public static A075170Inst Instance=new A075170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075171
{
public static readonly long[] Value={ 0L,10L,1010L,1100L,101100L,101010L,110010L,110100L,10110100L,10110010L,10101010L,10101100L,11001100L,11001010L,11010010L,111000L,10111000L,1011010010L,1011001010L,1011001100L,1010101100L,1010101010L,1010110010L,1010110100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075171Inst : IEnumerable<long>
{
public static readonly long[] Value=A075171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075171.Bytes);
public long this[int i]=>Value[i];

public static A075171Inst Instance=new A075171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075252
{
public static readonly long[] Value={ 22L,77L,442L,537L,775L,1066L,1081L,1082L,1085L,1115L,1562L,1575L,1587L,2173L,3355L,3599L,3871L,4099L,4153L,4185L,4193L,4202L,4262L,4285L,4402L,4633L,4666L,6163L,6166L,6374L,9241L,9466L,16544L,16546L,16586L,16601L,16613L,16616L,16720L,16748L,16994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075252Inst : IEnumerable<long>
{
public static readonly long[] Value=A075252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075252.Bytes);
public long this[int i]=>Value[i];

public static A075252Inst Instance=new A075252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075253
{
public static readonly long[] Value={ 77L,166L,267L,684L,897L,1416L,1557L,2904L,3333L,5904L,6189L,11952L,12813L,24096L,24669L,48480L,50205L,97344L,98493L,195264L,198717L,391296L,393597L,783744L,790653L,1569024L,1573629L,3140352L,3154173L,6283776L,6292989L,12572160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075253Inst : IEnumerable<long>
{
public static readonly long[] Value=A075253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075253.Bytes);
public long this[int i]=>Value[i];

public static A075253Inst Instance=new A075253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075254
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,11L,14L,14L,15L,17L,22L,19L,26L,23L,23L,24L,34L,26L,38L,29L,31L,35L,46L,33L,35L,41L,36L,39L,58L,40L,62L,42L,47L,53L,47L,46L,74L,59L,55L,51L,82L,54L,86L,59L,56L,71L,94L,59L,63L,62L,71L,69L,106L,65L,71L,69L,79L,89L,118L,72L,122L,95L,76L,76L,83L,82L,134L,89L,95L,84L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075254Inst : IEnumerable<long>
{
public static readonly long[] Value=A075254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075254.Bytes);
public long this[int i]=>Value[i];

public static A075254Inst Instance=new A075254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075255
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,2L,3L,3L,0L,5L,0L,5L,7L,8L,0L,10L,0L,11L,11L,9L,0L,15L,15L,11L,18L,17L,0L,20L,0L,22L,19L,15L,23L,26L,0L,17L,23L,29L,0L,30L,0L,29L,34L,21L,0L,37L,35L,38L,31L,35L,0L,43L,39L,43L,35L,27L,0L,48L,0L,29L,50L,52L,47L,50L,0L,47L,43L,56L,0L,60L,0L,35L,62L,53L,59L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075255Inst : IEnumerable<long>
{
public static readonly long[] Value=A075255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075255.Bytes);
public long this[int i]=>Value[i];

public static A075255Inst Instance=new A075255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075256
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,3L,1L,6L,3L,5L,2L,9L,6L,7L,1L,18L,3L,17L,9L,14L,5L,27L,15L,22L,7L,45L,21L,38L,17L,63L,46L,51L,5L,138L,15L,133L,45L,118L,73L,135L,62L,219L,157L,186L,29L,471L,87L,442L,261L,355L,94L,783L,282L,689L,407L,846L,439L,1221L,782L,1317L,535L,2346L,1605L,1811L,206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075256Inst : IEnumerable<long>
{
public static readonly long[] Value=A075256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075256.Bytes);
public long this[int i]=>Value[i];

public static A075256Inst Instance=new A075256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075257
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,6L,1L,3L,9L,5L,15L,7L,21L,17L,46L,5L,15L,45L,73L,62L,157L,29L,87L,261L,94L,282L,407L,439L,782L,535L,1605L,206L,618L,1854L,2137L,3425L,2986L,7289L,1669L,5007L,15021L,170L,510L,1530L,4590L,13770L,24493L,16817L,50451L,6211L,18633L,55899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075257Inst : IEnumerable<long>
{
public static readonly long[] Value=A075257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075257.Bytes);
public long this[int i]=>Value[i];

public static A075257Inst Instance=new A075257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075258
{
public static readonly long[] Value={ 2L,3L,3L,6L,5L,9L,7L,18L,17L,14L,27L,22L,45L,38L,63L,51L,138L,133L,118L,135L,219L,186L,471L,442L,355L,783L,689L,846L,1221L,1317L,2346L,1811L,4815L,4609L,3991L,5562L,6411L,10275L,8958L,21867L,20198L,15191L,45063L,44893L,44383L,42853L,38263L,41310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075258Inst : IEnumerable<long>
{
public static readonly long[] Value=A075258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075258.Bytes);
public long this[int i]=>Value[i];

public static A075258Inst Instance=new A075258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075259
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,5L,2L,1L,3L,5L,1L,12L,8L,3L,3L,5L,14L,8L,6L,4L,7L,20L,1L,9L,6L,3L,22L,11L,3L,11L,31L,24L,5L,10L,3L,11L,16L,20L,6L,23L,2L,35L,7L,3L,35L,15L,25L,16L,47L,8L,12L,54L,3L,9L,8L,4L,42L,41L,22L,11L,8L,25L,8L,15L,5L,61L,92L,3L,7L,16L,28L,47L,37L,7L,10L,40L,23L,13L,11L,29L,11L,75L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075259Inst : IEnumerable<long>
{
public static readonly long[] Value=A075259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075259.Bytes);
public long this[int i]=>Value[i];

public static A075259Inst Instance=new A075259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075260
{
public static readonly long[] Value={ 3L,3L,5L,5L,5L,7L,9L,7L,9L,9L,9L,11L,11L,11L,13L,13L,13L,15L,15L,15L,17L,21L,17L,19L,19L,19L,21L,21L,21L,23L,23L,23L,25L,25L,25L,27L,27L,27L,29L,29L,29L,31L,33L,31L,33L,33L,33L,35L,35L,35L,37L,37L,37L,39L,39L,39L,41L,43L,41L,43L,43L,43L,45L,45L,45L,47L,49L,47L,49L,49L,49L,51L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075260Inst : IEnumerable<long>
{
public static readonly long[] Value=A075260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075260.Bytes);
public long this[int i]=>Value[i];

public static A075260Inst Instance=new A075260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075261
{
public static readonly long[] Value={ 5L,11L,9L,15L,33L,21L,17L,67L,33L,69L,113L,51L,87L,171L,77L,115L,241L,99L,155L,323L,129L,63L,417L,171L,265L,523L,201L,315L,641L,243L,375L,771L,299L,445L,913L,339L,525L,1067L,393L,609L,1233L,465L,297L,1411L,513L,785L,1601L,579L,885L,1803L,651L,999L,2017L,723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075261Inst : IEnumerable<long>
{
public static readonly long[] Value=A075261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075261.Bytes);
public long this[int i]=>Value[i];

public static A075261Inst Instance=new A075261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075262
{
public static readonly long[] Value={ 15L,231L,45L,165L,2145L,105L,153L,8911L,693L,207L,25425L,1683L,957L,58311L,1001L,10465L,115921L,6435L,19065L,208335L,10965L,2961L,347361L,2907L,5035L,546535L,26733L,18585L,821121L,39123L,112125L,1188111L,7475L,157975L,1666225L,76275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075262Inst : IEnumerable<long>
{
public static readonly long[] Value=A075262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075262.Bytes);
public long this[int i]=>Value[i];

public static A075262Inst Instance=new A075262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075263
{
public static readonly long[] Value={ 1L,1L,-1L,2L,-3L,1L,6L,-12L,7L,-1L,24L,-60L,50L,-15L,1L,120L,-360L,390L,-180L,31L,-1L,720L,-2520L,3360L,-2100L,602L,-63L,1L,5040L,-20160L,31920L,-25200L,10206L,-1932L,127L,-1L,40320L,-181440L,332640L,-317520L,166824L,-46620L,6050L,-255L,1L,362880L,-1814400L,3780000L,-4233600L,2739240L,-1020600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075263Inst : IEnumerable<long>
{
public static readonly long[] Value=A075263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075263.Bytes);
public long this[int i]=>Value[i];

public static A075263Inst Instance=new A075263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075264
{
public static readonly long[] Value={ 1L,5L,3L,6L,5L,1L,502L,485L,150L,15L,760L,802L,305L,50L,3L,152696L,171150L,73801L,15435L,1575L,63L,252336L,295748L,139020L,33817L,4515L,315L,9L,51360816L,62333204L,31231500L,8437975L,1334760L,124110L,6300L,135L,88864128L,110941776L,58415444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075264Inst : IEnumerable<long>
{
public static readonly long[] Value=A075264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075264.Bytes);
public long this[int i]=>Value[i];

public static A075264Inst Instance=new A075264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075265
{
public static readonly long[] Value={ 1L,2L,24L,48L,5760L,11520L,2903040L,5806080L,1393459200L,2786918400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075265Inst : IEnumerable<long>
{
public static readonly long[] Value=A075265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075265.Bytes);
public long this[int i]=>Value[i];

public static A075265Inst Instance=new A075265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075266
{
public static readonly BigInteger[] Value={ 1L,5L,1L,251L,19L,19087L,751L,1070017L,2857L,26842253L,434293L,703604254357L,8181904909L,1166309819657L,5044289L,8092989203533249L,5026792806787L,12600467236042756559UL,69028763155644023L,BigInteger.Parse("8136836498467582599787") };
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
public class A075266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075266Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075266.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075266.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075266Inst Instance=new A075266Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075267
{
public static readonly BigInteger[] Value={ 2L,24L,8L,2880L,288L,362880L,17280L,29030400L,89600L,958003200L,17418240L,31384184832000L,402361344000L,62768369664000L,295206912L,512189896458240000L,342372925440000L,BigInteger.Parse("919636959090769920000"),5377993912811520000L,BigInteger.Parse("674400436666564608000000"),89903156428800000L };
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
public class A075267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075267Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075267.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075267.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075267Inst Instance=new A075267Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075300
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,7L,11L,9L,6L,15L,23L,19L,13L,8L,31L,47L,39L,27L,17L,10L,63L,95L,79L,55L,35L,21L,12L,127L,191L,159L,111L,71L,43L,25L,14L,255L,383L,319L,223L,143L,87L,51L,29L,16L,511L,767L,639L,447L,287L,175L,103L,59L,33L,18L,1023L,1535L,1279L,895L,575L,351L,207L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075300Inst : IEnumerable<long>
{
public static readonly long[] Value=A075300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075300.Bytes);
public long this[int i]=>Value[i];

public static A075300Inst Instance=new A075300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075301
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,9L,6L,14L,8L,20L,7L,27L,13L,35L,10L,44L,19L,54L,12L,65L,26L,77L,11L,90L,34L,104L,18L,119L,43L,135L,15L,152L,53L,170L,25L,189L,64L,209L,17L,230L,76L,252L,33L,275L,89L,299L,16L,324L,103L,350L,42L,377L,118L,405L,24L,434L,134L,464L,52L,495L,151L,527L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075301Inst : IEnumerable<long>
{
public static readonly long[] Value=A075301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075301.Bytes);
public long this[int i]=>Value[i];

public static A075301Inst Instance=new A075301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075302
{
public static readonly long[] Value={ 0L,2L,1L,4L,5L,3L,6L,9L,11L,7L,8L,13L,19L,23L,15L,10L,17L,27L,39L,47L,31L,12L,21L,35L,55L,79L,95L,63L,14L,25L,43L,71L,111L,159L,191L,127L,16L,29L,51L,87L,143L,223L,319L,383L,255L,18L,33L,59L,103L,175L,287L,447L,639L,767L,511L,20L,37L,67L,119L,207L,351L,575L,895L,1279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075302Inst : IEnumerable<long>
{
public static readonly long[] Value=A075302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075302.Bytes);
public long this[int i]=>Value[i];

public static A075302Inst Instance=new A075302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075303
{
public static readonly long[] Value={ 0L,2L,1L,5L,3L,4L,6L,9L,10L,7L,15L,8L,21L,11L,28L,14L,36L,16L,45L,12L,55L,22L,66L,13L,78L,29L,91L,17L,105L,37L,120L,20L,136L,46L,153L,23L,171L,56L,190L,18L,210L,67L,231L,30L,253L,79L,276L,19L,300L,92L,325L,38L,351L,106L,378L,24L,406L,121L,435L,47L,465L,137L,496L,27L,528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075303Inst : IEnumerable<long>
{
public static readonly long[] Value=A075303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075303.Bytes);
public long this[int i]=>Value[i];

public static A075303Inst Instance=new A075303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075304
{
public static readonly long[] Value={ 5L,7L,17L,19L,31L,37L,43L,61L,97L,109L,181L,211L,331L,337L,401L,443L,487L,617L,631L,641L,661L,919L,1051L,1117L,1217L,1249L,1321L,1429L,1453L,1531L,1657L,1777L,2549L,2551L,2857L,2861L,2917L,2971L,3137L,3307L,3539L,3541L,3659L,3907L,4289L,4421L,4423L,5101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075304Inst : IEnumerable<long>
{
public static readonly long[] Value=A075304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075304.Bytes);
public long this[int i]=>Value[i];

public static A075304Inst Instance=new A075304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075305
{
public static readonly long[] Value={ 5L,7L,17L,19L,11L,13L,29L,31L,97L,37L,41L,43L,23L,73L,101L,53L,109L,113L,61L,193L,67L,103L,71L,181L,191L,79L,241L,127L,89L,271L,47L,337L,197L,151L,307L,157L,163L,331L,281L,229L,59L,421L,311L,379L,257L,131L,199L,137L,139L,211L,433L,149L,601L,457L,463L,313L,401L,487L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075305Inst : IEnumerable<long>
{
public static readonly long[] Value=A075305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075305.Bytes);
public long this[int i]=>Value[i];

public static A075305Inst Instance=new A075305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075306
{
public static readonly BigInteger[] Value={ 3L,25L,91L,2101L,23101L,60061L,510511L,29099071L,3792578791L,84106011991L,2005604901301L,252305096583541L,11561510014033981L,52331045326680121L,BigInteger.Parse("31359378912013061911"),BigInteger.Parse("1792403716245452460151"),BigInteger.Parse("98060777857864844592571") };
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
public class A075306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075306Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075306.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075306.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075306Inst Instance=new A075306Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075307
{
public static readonly BigInteger[] Value={ 3L,5L,23L,53L,1523L,29243L,299513L,4383593L,188677703L,5765999453L,5765999453L,2211931390883L,165468170356703L,8075975022064163L,361310530977154973L,BigInteger.Parse("20037783573808880093"),BigInteger.Parse("1779852341342071295513"),BigInteger.Parse("40235059344426324076913") };
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
public class A075307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075307Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075307.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075307.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075307Inst Instance=new A075307Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075308
{
public static readonly long[] Value={ 4L,8L,28L,84L,242L,744L,2284L,7096L,22179L,69561L,218759L,689206L,2173942L,6862783L,21676671L,68493153L,216477260L,684309327L,2163434093L,6840212693L,21628140126L,68388775913L,216252650605L,683825838922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075308Inst : IEnumerable<long>
{
public static readonly long[] Value=A075308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075308.Bytes);
public long this[int i]=>Value[i];

public static A075308Inst Instance=new A075308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075309
{
public static readonly long[] Value={ 1L,4L,8L,9L,16L,25L,27L,32L,36L,49L,64L,81L,125L,128L,169L,196L,216L,243L,256L,289L,324L,361L,512L,529L,576L,625L,729L,784L,841L,961L,1024L,1089L,1296L,1369L,1728L,1764L,1849L,1936L,2048L,2187L,2197L,2304L,2401L,2601L,2704L,2809L,2916L,3025L,3125L,3249L,3481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075309Inst : IEnumerable<long>
{
public static readonly long[] Value=A075309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075309.Bytes);
public long this[int i]=>Value[i];

public static A075309Inst Instance=new A075309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075310
{
public static readonly long[] Value={ 4L,8L,18L,46L,76L,107L,126L,101L,84L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075310Inst : IEnumerable<long>
{
public static readonly long[] Value=A075310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075310.Bytes);
public long this[int i]=>Value[i];

public static A075310Inst Instance=new A075310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075311
{
public static readonly long[] Value={ 1L,3L,5L,6L,9L,10L,12L,15L,17L,18L,20L,23L,24L,27L,29L,30L,33L,34L,36L,39L,40L,43L,45L,46L,48L,51L,53L,54L,57L,58L,60L,65L,66L,68L,71L,72L,75L,77L,78L,80L,83L,85L,86L,89L,90L,92L,96L,99L,101L,102L,105L,106L,108L,113L,114L,116L,120L,127L,129L,130L,132L,135L,136L,139L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075311Inst : IEnumerable<long>
{
public static readonly long[] Value=A075311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075311.Bytes);
public long this[int i]=>Value[i];

public static A075311Inst Instance=new A075311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075312
{
public static readonly long[] Value={ 2L,15L,28L,60L,104L,135L,198L,240L,322L,416L,476L,589L,714L,792L,936L,1025L,1188L,1363L,1470L,1664L,1782L,1995L,2220L,2356L,2600L,2856L,3010L,3285L,3450L,3744L,4050L,4233L,4558L,4895L,5096L,5452L,5664L,6039L,6426L,6656L,7062L,7303L,7728L,8165L,8424L,8880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075312Inst : IEnumerable<long>
{
public static readonly long[] Value=A075312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075312.Bytes);
public long this[int i]=>Value[i];

public static A075312Inst Instance=new A075312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075313
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,8L,10L,11L,12L,14L,15L,16L,17L,19L,20L,22L,23L,24L,25L,26L,28L,29L,31L,32L,33L,34L,36L,37L,38L,39L,40L,41L,42L,44L,45L,47L,48L,49L,50L,51L,52L,54L,55L,56L,57L,59L,60L,61L,63L,64L,65L,66L,68L,69L,70L,71L,72L,73L,74L,76L,77L,78L,79L,80L,81L,83L,84L,86L,87L,88L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075313Inst : IEnumerable<long>
{
public static readonly long[] Value=A075313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075313.Bytes);
public long this[int i]=>Value[i];

public static A075313Inst Instance=new A075313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075314
{
public static readonly long[] Value={ 3L,5L,9L,13L,18L,21L,27L,30L,35L,43L,46L,53L,58L,62L,67L,75L,82L,85L,92L,97L,101L,108L,114L,121L,130L,135L,139L,144L,147L,152L,167L,172L,179L,183L,194L,198L,205L,212L,217L,224L,231L,235L,246L,249L,254L,258L,271L,284L,290L,293L,298L,305L,309L,320L,327L,334L,341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075314Inst : IEnumerable<long>
{
public static readonly long[] Value=A075314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075314.Bytes);
public long this[int i]=>Value[i];

public static A075314Inst Instance=new A075314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075315
{
public static readonly long[] Value={ 4L,7L,13L,19L,25L,29L,37L,41L,47L,57L,61L,69L,75L,81L,87L,97L,105L,109L,117L,123L,129L,137L,145L,153L,163L,169L,175L,181L,185L,191L,207L,213L,221L,227L,239L,245L,253L,261L,267L,275L,283L,289L,301L,305L,311L,317L,331L,345L,353L,357L,363L,371L,377L,389L,397L,405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075315Inst : IEnumerable<long>
{
public static readonly long[] Value=A075315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075315.Bytes);
public long this[int i]=>Value[i];

public static A075315Inst Instance=new A075315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075396
{
public static readonly long[] Value={ 6L,8L,10L,12L,15L,18L,20L,24L,28L,30L,32L,36L,40L,42L,45L,48L,50L,52L,54L,56L,60L,63L,66L,68L,70L,72L,75L,77L,80L,84L,88L,90L,96L,100L,102L,105L,108L,110L,112L,114L,117L,120L,126L,128L,130L,132L,135L,138L,140L,144L,147L,150L,154L,156L,160L,162L,165L,168L,170L,175L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075396Inst : IEnumerable<long>
{
public static readonly long[] Value=A075396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075396.Bytes);
public long this[int i]=>Value[i];

public static A075396Inst Instance=new A075396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075397
{
public static readonly long[] Value={ 1L,1L,4L,2L,1L,11L,9L,15L,256L,0L,0L,408L,307L,387L,511L,1608L,3821L,43207L,13651L,0L,147897L,115063L,179695L,938500L,133868L,844163L,21955502L,3756136L,9067127L,0L,33861703L,46269686L,177316890L,163959413L,75053719L,6678119984L,1776064204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075397Inst : IEnumerable<long>
{
public static readonly long[] Value=A075397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075397.Bytes);
public long this[int i]=>Value[i];

public static A075397Inst Instance=new A075397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075398
{
public static readonly BigInteger[] Value={ 4L,8L,32L,128L,8192L,131072L,524288L,2147483648L,2305843009213693952L,BigInteger.Parse("618970019642690137449562112"),BigInteger.Parse("162259276829213363391578010288128"),BigInteger.Parse("170141183460469231731687303715884105728") };
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
public class A075398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075398Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075398.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075398.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075398Inst Instance=new A075398Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075399
{
public static readonly BigInteger[] Value={ 1L,2L,111L,112L,5L,11112L,21112L,1111112L,111111111L,0L,0L,11111111112L,21112111111L,112111111112L,11111111115L,11111111112112L,211111111121111L,11111111111111112L,21111111211111111L,0L,BigInteger.Parse("21111111111111111111") };
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
public class A075399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075399Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075399.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075399.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075399Inst Instance=new A075399Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075400
{
public static readonly long[] Value={ 1L,1L,37L,28L,1L,1852L,3016L,138889L,12345679L,0L,0L,925925926L,1624008547L,8007936508L,740740741L,694444444507L,12418300654183L,617283950617284L,1111111116374269L,0L,1005291005291005291L,959595959595959596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075400Inst : IEnumerable<long>
{
public static readonly long[] Value=A075400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075400.Bytes);
public long this[int i]=>Value[i];

public static A075400Inst Instance=new A075400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075401
{
public static readonly long[] Value={ 2L,4L,6L,8L,55L,24L,77L,88L,18L,20L,22L,24L,26L,28L,60L,176L,187L,36L,361L,40L,42L,44L,46L,48L,275L,286L,54L,532L,551L,60L,62L,64L,66L,68L,385L,72L,703L,722L,156L,80L,82L,84L,86L,88L,90L,1702L,1316L,192L,931L,550L,204L,572L,583L,108L,1045L,1064L,228L,1624L,1652L,240L,671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075401Inst : IEnumerable<long>
{
public static readonly long[] Value=A075401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075401.Bytes);
public long this[int i]=>Value[i];

public static A075401Inst Instance=new A075401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075402
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,1L,1L,2L,4L,1L,1L,6L,2L,7L,1L,4L,2L,1L,1L,2L,4L,1L,7L,6L,2L,1L,3L,4L,2L,3L,13L,2L,4L,1L,7L,6L,2L,7L,1L,2L,4L,1L,1L,4L,6L,1L,5L,4L,2L,1L,3L,2L,2L,3L,1L,4L,10L,7L,1L,10L,20L,1L,1L,8L,2L,3L,1L,2L,18L,1L,5L,6L,2L,1L,1L,8L,2L,3L,11L,2L,4L,5L,1L,4L,20L,5L,1L,2L,4L,15L,5L,2L,16L,1L,1L,6L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075402Inst : IEnumerable<long>
{
public static readonly long[] Value=A075402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075402.Bytes);
public long this[int i]=>Value[i];

public static A075402Inst Instance=new A075402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075403
{
public static readonly long[] Value={ 2L,1L,5L,28L,10L,48L,13L,15L,65L,160L,58L,80L,106L,32L,162L,91L,94L,188L,70L,127L,62L,304L,201L,120L,394L,103L,141L,244L,382L,455L,301L,380L,521L,700L,625L,212L,721L,611L,681L,979L,277L,815L,1201L,1275L,569L,4588L,558L,2331L,5113L,1704L,1337L,2551L,2101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075403Inst : IEnumerable<long>
{
public static readonly long[] Value=A075403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075403.Bytes);
public long this[int i]=>Value[i];

public static A075403Inst Instance=new A075403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075404
{
public static readonly long[] Value={ 24L,0L,4L,0L,0L,0L,29L,0L,32L,0L,22908L,0L,108L,0L,111L,0L,39L,28L,0L,21L,116L,80L,0L,0L,48L,0L,59L,77L,0L,198L,0L,609L,0L,0L,0L,0L,0L,48L,0L,0L,0L,0L,0L,67L,0L,0L,0L,0L,0L,171L,0L,147L,0L,0L,3533L,0L,0L,2132L,0L,92L,0L,0L,0L,305L,282L,0L,116L,0L,0L,0L,0L,0L,194L,36554L,0L,99L,0L,0L,0L,0L,0L,0L,276L,0L,0L,0L,136L,0L,0L,0L,332L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075404Inst : IEnumerable<long>
{
public static readonly long[] Value=A075404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075404.Bytes);
public long this[int i]=>Value[i];

public static A075404Inst Instance=new A075404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075405
{
public static readonly long[] Value={ 70L,0L,5L,0L,0L,0L,92L,0L,106L,0L,2001863L,0L,652L,0L,679L,0L,138L,77L,0L,29L,724L,413L,0L,0L,182L,0L,253L,385L,0L,1612L,0L,8687L,0L,0L,0L,0L,0L,143L,0L,0L,0L,0L,0L,274L,0L,0L,0L,0L,0L,1281L,0L,1012L,0L,0L,121268L,0L,0L,56855L,0L,440L,0L,0L,0L,3069L,2725L,0L,655L,0L,0L,0L,0L,0L,1525L,4035066L,0L,430L,0L,0L,0L,0L,0L,0L,2619L,0L,0L,0L,795L,0L,0L,0L,3465L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075405Inst : IEnumerable<long>
{
public static readonly long[] Value=A075405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075405.Bytes);
public long this[int i]=>Value[i];

public static A075405Inst Instance=new A075405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075406
{
public static readonly long[] Value={ 24L,0L,2L,0L,0L,0L,23L,0L,24L,0L,22898L,0L,96L,0L,97L,0L,23L,11L,0L,2L,96L,59L,0L,0L,24L,0L,33L,50L,0L,169L,0L,578L,0L,0L,0L,0L,0L,11L,0L,0L,0L,0L,0L,24L,0L,0L,0L,0L,0L,122L,0L,96L,0L,0L,3479L,0L,0L,2075L,0L,33L,0L,0L,0L,242L,218L,0L,50L,0L,0L,0L,0L,0L,122L,36481L,0L,24L,0L,0L,0L,0L,0L,0L,194L,0L,0L,0L,50L,0L,0L,0L,242L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075406Inst : IEnumerable<long>
{
public static readonly long[] Value=A075406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075406.Bytes);
public long this[int i]=>Value[i];

public static A075406Inst Instance=new A075406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075407
{
public static readonly long[] Value={ 302L,322L,342L,362L,382L,423L,453L,483L,504L,513L,543L,544L,573L,584L,655L,706L,746L,755L,766L,805L,905L,908L,917L,948L,955L,988L,1029L,1030L,1050L,1057L,1059L,1070L,1090L,1119L,1127L,1130L,1149L,1150L,1170L,1190L,1267L,1312L,1313L,1337L,1352L,1434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075407Inst : IEnumerable<long>
{
public static readonly long[] Value=A075407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075407.Bytes);
public long this[int i]=>Value[i];

public static A075407Inst Instance=new A075407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075408
{
public static readonly long[] Value={ 1L,4L,16L,36L,100L,196L,256L,400L,576L,676L,1296L,1600L,2916L,3136L,4356L,5476L,7056L,8100L,8836L,12100L,13456L,14400L,15376L,15876L,16900L,17956L,21316L,22500L,24336L,25600L,28900L,30976L,32400L,33856L,41616L,42436L,44100L,50176L,52900L,55696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075408Inst : IEnumerable<long>
{
public static readonly long[] Value=A075408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075408.Bytes);
public long this[int i]=>Value[i];

public static A075408Inst Instance=new A075408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075409
{
public static readonly long[] Value={ 0L,1L,5L,7L,19L,19L,31L,17L,11L,17L,83L,67L,353L,227L,163L,59L,61L,113L,353L,31L,1447L,571L,389L,191L,337L,883L,101L,1823L,659L,709L,163L,1361L,439L,307L,1093L,1733L,2491L,1063L,1091L,1999L,1439L,109L,2753L,607L,2617L,269L,103L,2663L,337L,14447L,2221L,5471L,2887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075409Inst : IEnumerable<long>
{
public static readonly long[] Value=A075409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075409.Bytes);
public long this[int i]=>Value[i];

public static A075409Inst Instance=new A075409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075410
{
public static readonly long[] Value={ 0L,0L,3L,2L,5L,2L,5L,8L,7L,4L,19L,16L,29L,68L,97L,16L,109L,86L,19L,158L,17L,172L,41L,16L,529L,106L,263L,212L,163L,302L,593L,302L,607L,262L,311L,428L,227L,106L,1271L,8L,229L,386L,1489L,32L,47L,1996L,1097L,2566L,41L,632L,1913L,458L,149L,1244L,2837L,362L,3317L,908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075410Inst : IEnumerable<long>
{
public static readonly long[] Value=A075410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075410.Bytes);
public long this[int i]=>Value[i];

public static A075410Inst Instance=new A075410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075411
{
public static readonly BigInteger[] Value={ 0L,4L,484L,49284L,4937284L,493817284L,49382617284L,4938270617284L,493827150617284L,49382715950617284L,4938271603950617284L,BigInteger.Parse("493827160483950617284"),BigInteger.Parse("49382716049283950617284"),BigInteger.Parse("4938271604937283950617284"),BigInteger.Parse("493827160493817283950617284"),BigInteger.Parse("49382716049382617283950617284") };
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
public class A075411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075411Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075411.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075411.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075411Inst Instance=new A075411Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075476
{
public static readonly long[] Value={ 12L,84L,12L,14L,12L,35L,12L,14L,12L,17L,12L,14L,12L,25L,12L,14L,12L,25L,12L,14L,12L,27L,12L,14L,12L,17L,12L,14L,12L,38L,12L,14L,12L,25L,12L,14L,12L,45L,12L,14L,12L,17L,12L,14L,12L,27L,12L,14L,12L,20L,12L,14L,12L,79L,12L,14L,12L,17L,12L,14L,12L,20L,12L,14L,12L,33L,12L,14L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075476Inst : IEnumerable<long>
{
public static readonly long[] Value=A075476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075476.Bytes);
public long this[int i]=>Value[i];

public static A075476Inst Instance=new A075476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075477
{
public static readonly long[] Value={ 12L,14L,12L,22L,12L,14L,12L,20L,12L,14L,12L,22L,12L,14L,12L,17L,12L,14L,12L,20L,12L,14L,12L,40L,12L,14L,12L,58L,12L,14L,12L,17L,12L,14L,12L,33L,12L,14L,12L,33L,12L,14L,12L,25L,12L,14L,12L,17L,12L,14L,12L,33L,12L,14L,12L,27L,12L,14L,12L,40L,12L,14L,12L,17L,12L,14L,12L,69L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075477Inst : IEnumerable<long>
{
public static readonly long[] Value=A075477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075477.Bytes);
public long this[int i]=>Value[i];

public static A075477Inst Instance=new A075477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075478
{
public static readonly long[] Value={ 97L,74L,66L,14L,40L,17L,25L,14L,22L,27L,40L,14L,45L,27L,17L,14L,40L,38L,27L,14L,56L,17L,20L,14L,22L,27L,30L,14L,100L,30L,17L,14L,22L,33L,20L,14L,22L,17L,30L,14L,20L,30L,53L,14L,38L,20L,17L,14L,51L,25L,66L,14L,35L,17L,22L,14L,25L,20L,64L,14L,38L,40L,17L,14L,45L,25L,22L,14L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075478Inst : IEnumerable<long>
{
public static readonly long[] Value=A075478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075478.Bytes);
public long this[int i]=>Value[i];

public static A075478Inst Instance=new A075478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075479
{
public static readonly long[] Value={ 92L,14L,35L,51L,17L,14L,25L,27L,22L,14L,64L,17L,22L,14L,61L,43L,131L,14L,27L,22L,17L,14L,33L,35L,22L,14L,53L,17L,20L,14L,43L,22L,22L,14L,45L,22L,17L,14L,35L,43L,20L,14L,25L,17L,25L,14L,20L,22L,27L,14L,38L,20L,17L,14L,27L,22L,30L,14L,25L,17L,33L,14L,40L,20L,69L,14L,115L,27L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075479Inst : IEnumerable<long>
{
public static readonly long[] Value=A075479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075479.Bytes);
public long this[int i]=>Value[i];

public static A075479Inst Instance=new A075479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075480
{
public static readonly long[] Value={ 14L,69L,48L,20L,14L,27L,17L,33L,14L,20L,22L,40L,14L,58L,20L,17L,14L,33L,22L,33L,14L,64L,17L,33L,14L,71L,20L,35L,14L,40L,43L,17L,14L,71L,71L,25L,14L,27L,17L,40L,14L,22L,25L,27L,14L,43L,25L,17L,14L,66L,27L,25L,14L,76L,17L,20L,14L,22L,43L,27L,14L,66L,25L,17L,14L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075480Inst : IEnumerable<long>
{
public static readonly long[] Value=A075480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075480.Bytes);
public long this[int i]=>Value[i];

public static A075480Inst Instance=new A075480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075481
{
public static readonly long[] Value={ 89L,51L,14L,33L,22L,17L,14L,45L,27L,22L,14L,35L,17L,20L,14L,35L,22L,22L,14L,43L,22L,17L,14L,27L,128L,20L,14L,25L,17L,25L,14L,20L,22L,30L,14L,82L,20L,17L,14L,45L,22L,27L,14L,25L,17L,27L,14L,48L,20L,30L,14L,43L,30L,17L,14L,58L,61L,27L,14L,53L,17L,56L,14L,22L,30L,58L,14L,27L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075481Inst : IEnumerable<long>
{
public static readonly long[] Value=A075481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075481.Bytes);
public long this[int i]=>Value[i];

public static A075481Inst Instance=new A075481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075482
{
public static readonly long[] Value={ 12L,14L,12L,45L,12L,14L,12L,17L,12L,14L,12L,33L,12L,14L,12L,20L,12L,14L,12L,25L,12L,14L,12L,17L,12L,14L,12L,20L,12L,14L,12L,30L,12L,14L,12L,25L,12L,14L,12L,17L,12L,14L,12L,30L,12L,14L,12L,22L,12L,14L,12L,69L,12L,14L,12L,17L,12L,14L,12L,22L,12L,14L,12L,22L,12L,14L,12L,82L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075482Inst : IEnumerable<long>
{
public static readonly long[] Value=A075482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075482.Bytes);
public long this[int i]=>Value[i];

public static A075482Inst Instance=new A075482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075483
{
public static readonly long[] Value={ 89L,25L,22L,22L,35L,20L,66L,30L,17L,38L,133L,27L,25L,40L,35L,30L,20L,25L,22L,38L,38L,133L,51L,27L,17L,40L,22L,30L,20L,35L,22L,95L,131L,33L,20L,25L,27L,22L,27L,66L,17L,27L,71L,45L,33L,48L,35L,89L,22L,33L,30L,30L,48L,22L,40L,30L,17L,61L,30L,64L,22L,22L,25L,84L,22L,22L,25L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075483Inst : IEnumerable<long>
{
public static readonly long[] Value=A075483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075483.Bytes);
public long this[int i]=>Value[i];

public static A075483Inst Instance=new A075483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075484
{
public static readonly long[] Value={ 1L,6L,24L,109L,26L,124L,147L,139L,100L,92L,115L,337L,135L,277L,181L,261L,240L,219L,286L,322L,451L,337L,303L,432L,243L,540L,408L,444L,304L,464L,438L,554L,484L,582L,517L,677L,462L,617L,1002L,539L,655L,709L,714L,737L,623L,708L,868L,723L,707L,676L,642L,833L,776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075484Inst : IEnumerable<long>
{
public static readonly long[] Value=A075484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075484.Bytes);
public long this[int i]=>Value[i];

public static A075484Inst Instance=new A075484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075485
{
public static readonly long[] Value={ 1L,8L,17L,18L,107L,108L,47L,48L,62L,63L,157L,158L,159L,160L,130L,131L,225L,226L,178L,179L,304L,305L,474L,475L,445L,446L,385L,386L,449L,450L,451L,452L,528L,529L,530L,531L,532L,533L,534L,535L,536L,537L,587L,588L,589L,590L,591L,592L,593L,594L,595L,596L,853L,854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075485Inst : IEnumerable<long>
{
public static readonly long[] Value=A075485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075485.Bytes);
public long this[int i]=>Value[i];

public static A075485Inst Instance=new A075485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075486
{
public static readonly long[] Value={ 8L,6L,20L,13L,27L,28L,122L,123L,36L,37L,157L,114L,53L,54L,99L,100L,101L,102L,103L,73L,167L,168L,169L,170L,171L,172L,248L,174L,188L,189L,252L,253L,179L,180L,318L,244L,196L,197L,154L,155L,156L,157L,401L,327L,496L,497L,162L,163L,332L,333L,409L,472L,411L,412L,338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075486Inst : IEnumerable<long>
{
public static readonly long[] Value=A075486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075486.Bytes);
public long this[int i]=>Value[i];

public static A075486Inst Instance=new A075486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075487
{
public static readonly long[] Value={ 2L,3L,7L,19L,111L,22L,96L,33L,76L,75L,43L,135L,134L,133L,132L,144L,205L,129L,190L,140L,95L,94L,261L,428L,91L,258L,394L,331L,255L,254L,390L,389L,388L,462L,461L,460L,459L,458L,457L,456L,455L,454L,453L,501L,500L,450L,498L,497L,752L,495L,494L,493L,748L,491L,746L,489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075487Inst : IEnumerable<long>
{
public static readonly long[] Value=A075487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075487.Bytes);
public long this[int i]=>Value[i];

public static A075487Inst Instance=new A075487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075488
{
public static readonly long[] Value={ 2L,4L,11L,10L,97L,96L,33L,32L,44L,43L,135L,134L,133L,132L,100L,99L,191L,190L,140L,139L,262L,261L,428L,427L,395L,394L,331L,330L,391L,390L,389L,388L,462L,461L,460L,459L,458L,457L,456L,455L,454L,453L,501L,500L,499L,498L,497L,496L,495L,494L,493L,492L,747L,746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075488Inst : IEnumerable<long>
{
public static readonly long[] Value=A075488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075488.Bytes);
public long this[int i]=>Value[i];

public static A075488Inst Instance=new A075488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075489
{
public static readonly long[] Value={ 1L,10L,76L,570L,4784L,43590L,435004L,4738392L,55972218L,713630736L,9777359856L,143350864898L,2240419421284L,37194276947898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075489Inst : IEnumerable<long>
{
public static readonly long[] Value=A075489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075489.Bytes);
public long this[int i]=>Value[i];

public static A075489Inst Instance=new A075489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075490
{
public static readonly BigInteger[] Value={ 1L,2L,14L,30L,1364L,126L,335922L,87380L,12093234L,1398100L,111111111110L,22369620L,116719860413532L,94036996914L,40210710958664L,321685687669320L,BigInteger.Parse("314824432191309680912"),121871948002098L,BigInteger.Parse("749896248023298716143374") };
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
public class A075490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075490Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075490.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075490.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075490Inst Instance=new A075490Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075491
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,2L,5L,4L,6L,-3L,0L,-3L,2L,1L,2L,2L,6L,3L,8L,-4L,-1L,0L,3L,-2L,4L,4L,5L,4L,9L,-5L,2L,-1L,2L,3L,4L,0L,8L,7L,8L,-4L,3L,-2L,5L,2L,3L,6L,9L,2L,10L,-1L,2L,1L,6L,1L,6L,3L,8L,9L,12L,-6L,5L,4L,3L,3L,7L,4L,11L,8L,11L,-1L,6L,-3L,8L,7L,6L,7L,10L,7L,14L,-2L,4L,6L,9L,0L,9L,10L,11L,8L,15L,-3L,6L,5L,8L,9L,10L,3L,14L,11L,12L,-8L,0L,-5L,2L,-3L,-2L,3L,6L,-3L,8L,-6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075491Inst : IEnumerable<long>
{
public static readonly long[] Value=A075491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075491.Bytes);
public long this[int i]=>Value[i];

public static A075491Inst Instance=new A075491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075508
{
public static readonly BigInteger[] Value={ 1L,1L,10L,109L,1351L,19612L,333451L,6493069L,141264820L,3376695763L,87799365343L,2465959810690L,74353064138749L,2393123710957813L,81812390963020066L,2958191064076428793L,BigInteger.Parse("112727516544416978299"),BigInteger.Parse("4513118224822056822772"),BigInteger.Parse("189305466502867876489519") };
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
public class A075508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075508Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075508.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075508.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075508Inst Instance=new A075508Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075509
{
public static readonly BigInteger[] Value={ 1L,1L,11L,131L,1761L,27601L,506651L,10674211L,251686881L,6524202561L,183991725451L,5605930566051L,183428104316161L,6409252239788881L,237948848526923611L,9346097294356706051UL,BigInteger.Parse("386966245108218203201"),BigInteger.Parse("16836505067572362863361"),BigInteger.Parse("767645305770283165781131") };
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
public class A075509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075509.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075509Inst Instance=new A075509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075510
{
public static readonly long[] Value={ 1L,30L,560L,8400L,111216L,1360800L,15790720L,176563200L,1922176256L,20518417920L,215825326080L,2244998246400L,23153670762496L,237224718704640L,2418102840688640L,24549985173504000L,248464183682727936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075510Inst : IEnumerable<long>
{
public static readonly long[] Value=A075510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075510.Bytes);
public long this[int i]=>Value[i];

public static A075510Inst Instance=new A075510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075511
{
public static readonly long[] Value={ 1L,42L,1064L,21168L,365232L,5743584L,84713728L,1193127936L,16239711488L,215394955776L,2800564795392L,35851775791104L,453374980255744L,5677724481773568L,70550796621971456L,871159544637161472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075511Inst : IEnumerable<long>
{
public static readonly long[] Value=A075511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075511.Bytes);
public long this[int i]=>Value[i];

public static A075511Inst Instance=new A075511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075512
{
public static readonly long[] Value={ 1L,56L,1848L,47040L,1023792L,20076672L,365787136L,6314147840L,104637781248L,1680323893248L,26325099300864L,404403166003200L,6115019304300544L,91287994741981184L,1348582723009708032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075512Inst : IEnumerable<long>
{
public static readonly long[] Value=A075512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075512.Bytes);
public long this[int i]=>Value[i];

public static A075512Inst Instance=new A075512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075513
{
public static readonly long[] Value={ 1L,-1L,2L,1L,-8L,9L,-1L,24L,-81L,64L,1L,-64L,486L,-1024L,625L,-1L,160L,-2430L,10240L,-15625L,7776L,1L,-384L,10935L,-81920L,234375L,-279936L,117649L,-1L,896L,-45927L,573440L,-2734375L,5878656L,-5764801L,2097152L,1L,-2048L,183708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075513Inst : IEnumerable<long>
{
public static readonly long[] Value=A075513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075513.Bytes);
public long this[int i]=>Value[i];

public static A075513Inst Instance=new A075513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075514
{
public static readonly BigInteger[] Value={ 1L,3L,154L,7941L,429036L,24123105L,1399303662L,83176893681L,5041470373624L,310449199290489L,19369215839341710L,1221826010437625703L,BigInteger.Parse("77798300823672280164"),BigInteger.Parse("4993767938470070592261"),BigInteger.Parse("322795606469564782029126") };
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
public class A075514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075514.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075514Inst Instance=new A075514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075515
{
public static readonly ulong[] Value={ 1L,45L,1260L,28350L,563031L,10333575L,179866170L,3016747800L,49263275061L,788796913905L,12445575859080L,194186867360850L,3004103990159091L,46168557763591035L,705914973500103990L,10750288516418083500UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075515Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A075515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075515.Bytes);
public ulong this[int i]=>Value[i];

public static A075515Inst Instance=new A075515Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075516
{
public static readonly BigInteger[] Value={ 1L,63L,2394L,71442L,1848987L,43615341L,964942308L,20385709344L,416206043253L,8280505692459L,161494678323342L,3101091077181006L,58823743379417199L,1104995938593100617L,BigInteger.Parse("20595841868175915096") };
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
public class A075516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075516Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075516.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075516.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075516Inst Instance=new A075516Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075517
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,19L,28L,29L,37L,38L,39L,46L,47L,48L,49L,55L,56L,57L,58L,59L,64L,65L,66L,67L,68L,69L,73L,74L,75L,76L,77L,78L,79L,82L,83L,84L,85L,86L,87L,88L,89L,91L,92L,93L,94L,95L,96L,97L,98L,99L,109L,118L,119L,127L,128L,129L,136L,137L,138L,139L,145L,146L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075517Inst : IEnumerable<long>
{
public static readonly long[] Value=A075517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075517.Bytes);
public long this[int i]=>Value[i];

public static A075517Inst Instance=new A075517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075518
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,3L,4L,4L,5L,7L,7L,9L,10L,10L,11L,13L,14L,15L,16L,17L,18L,19L,20L,22L,24L,25L,25L,26L,27L,28L,31L,32L,34L,34L,37L,37L,39L,40L,41L,43L,44L,45L,47L,48L,49L,49L,52L,55L,56L,57L,58L,59L,60L,62L,64L,65L,67L,67L,69L,70L,70L,73L,76L,77L,78L,79L,82L,84L,86L,87L,88L,89L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075518Inst : IEnumerable<long>
{
public static readonly long[] Value=A075518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075518.Bytes);
public long this[int i]=>Value[i];

public static A075518Inst Instance=new A075518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075519
{
public static readonly long[] Value={ 11L,13L,23L,29L,31L,47L,53L,71L,79L,127L,149L,151L,167L,173L,191L,239L,269L,271L,293L,317L,359L,389L,431L,439L,509L,557L,599L,607L,631L,653L,719L,727L,773L,797L,911L,919L,967L,1031L,1087L,1109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075519Inst : IEnumerable<long>
{
public static readonly long[] Value=A075519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075519.Bytes);
public long this[int i]=>Value[i];

public static A075519Inst Instance=new A075519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075520
{
public static readonly long[] Value={ 10L,15L,21L,31L,47L,53L,69L,79L,95L,117L,127L,149L,165L,175L,191L,213L,239L,245L,271L,287L,293L,319L,335L,357L,389L,405L,415L,431L,437L,453L,511L,527L,549L,559L,597L,607L,629L,655L,671L,693L,719L,725L,767L,773L,789L,799L,847L,895L,911L,917L,933L,959L,965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075520Inst : IEnumerable<long>
{
public static readonly long[] Value=A075520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075520.Bytes);
public long this[int i]=>Value[i];

public static A075520Inst Instance=new A075520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075521
{
public static readonly long[] Value={ 7L,11L,13L,19L,31L,37L,47L,59L,67L,73L,97L,107L,151L,179L,193L,227L,271L,277L,307L,331L,359L,367L,373L,409L,433L,439L,467L,487L,499L,571L,577L,587L,599L,647L,673L,691L,709L,719L,839L,853L,907L,991L,997L,1019L,1031L,1033L,1039L,1093L,1129L,1187L,1259L,1279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075521Inst : IEnumerable<long>
{
public static readonly long[] Value=A075521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075521.Bytes);
public long this[int i]=>Value[i];

public static A075521Inst Instance=new A075521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075522
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,2L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,4L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,1L,1L,1L,3L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075522Inst : IEnumerable<long>
{
public static readonly long[] Value=A075522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075522.Bytes);
public long this[int i]=>Value[i];

public static A075522Inst Instance=new A075522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075523
{
public static readonly long[] Value={ 10L,15L,21L,511L,767L,213L,69L,319L,95L,117L,511L,597L,165L,175L,767L,213L,959L,245L,4351L,287L,1173L,319L,335L,357L,1557L,405L,415L,1727L,437L,453L,511L,527L,549L,559L,597L,2431L,629L,655L,671L,693L,46079L,725L,767L,3093L,789L,799L,847L,895L,3647L,917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075523Inst : IEnumerable<long>
{
public static readonly long[] Value=A075523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075523.Bytes);
public long this[int i]=>Value[i];

public static A075523Inst Instance=new A075523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075540
{
public static readonly long[] Value={ 5L,53L,157L,173L,211L,257L,263L,373L,511L,537L,563L,593L,607L,653L,733L,947L,977L,999L,1073L,1103L,1123L,1187L,1223L,1239L,1367L,1461L,1501L,1511L,1541L,1747L,1753L,1763L,1773L,1899L,1907L,1917L,2071L,2181L,2287L,2401L,2409L,2417L,2449L,2677L,2903L,2963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075540Inst : IEnumerable<long>
{
public static readonly long[] Value=A075540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075540.Bytes);
public long this[int i]=>Value[i];

public static A075540Inst Instance=new A075540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075541
{
public static readonly long[] Value={ 2L,15L,36L,39L,46L,54L,55L,73L,96L,99L,102L,107L,110L,118L,129L,160L,164L,167L,179L,184L,187L,194L,199L,202L,218L,231L,238L,239L,242L,271L,272L,273L,274L,290L,291L,292L,311L,326L,339L,356L,357L,358L,362L,387L,419L,426L,437L,438L,449L,452L,464L,465L,489L,508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075541Inst : IEnumerable<long>
{
public static readonly long[] Value=A075541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075541.Bytes);
public long this[int i]=>Value[i];

public static A075541Inst Instance=new A075541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075542
{
public static readonly long[] Value={ 2L,15L,36L,39L,46L,54L,55L,73L,102L,107L,110L,118L,129L,160L,164L,184L,187L,194L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075542Inst : IEnumerable<long>
{
public static readonly long[] Value=A075542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075542.Bytes);
public long this[int i]=>Value[i];

public static A075542Inst Instance=new A075542Inst();

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