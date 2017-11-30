using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A195305
{
public static readonly long[] Value={ 3L,2L,8L,8L,5L,5L,4L,1L,8L,5L,1L,4L,5L,0L,3L,0L,0L,6L,4L,1L,8L,2L,8L,4L,8L,1L,0L,8L,8L,9L,6L,3L,5L,1L,4L,1L,4L,3L,6L,1L,5L,8L,3L,8L,2L,3L,0L,3L,0L,2L,0L,1L,0L,6L,8L,3L,5L,6L,7L,4L,9L,8L,8L,8L,1L,7L,1L,4L,7L,4L,0L,4L,6L,4L,1L,6L,1L,2L,7L,9L,2L,6L,9L,2L,1L,8L,7L,6L,8L,0L,7L,2L,8L,8L,8L,3L,4L,5L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195305Inst : IEnumerable<long>
{
public static readonly long[] Value=A195305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195305.Bytes);
public long this[int i]=>Value[i];

public static A195305Inst Instance=new A195305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195306
{
public static readonly long[] Value={ 2L,3L,7L,2L,5L,9L,1L,6L,7L,4L,9L,5L,6L,7L,4L,9L,3L,0L,8L,0L,7L,5L,0L,9L,8L,5L,2L,9L,9L,4L,0L,3L,2L,0L,1L,5L,0L,0L,5L,7L,3L,6L,1L,3L,2L,7L,0L,9L,0L,4L,6L,2L,3L,9L,2L,7L,4L,9L,3L,7L,2L,8L,5L,0L,0L,3L,7L,0L,0L,1L,9L,2L,5L,1L,5L,1L,9L,5L,1L,6L,9L,6L,7L,1L,2L,1L,8L,5L,7L,5L,2L,0L,3L,1L,2L,4L,7L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195306Inst : IEnumerable<long>
{
public static readonly long[] Value=A195306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195306.Bytes);
public long this[int i]=>Value[i];

public static A195306Inst Instance=new A195306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195307
{
public static readonly long[] Value={ 1L,2L,6L,12L,60L,180L,360L,420L,840L,1260L,2520L,5040L,13860L,27720L,55440L,83160L,166320L,277200L,360360L,720720L,1081080L,2162160L,2827440L,4324320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195307Inst : IEnumerable<long>
{
public static readonly long[] Value=A195307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195307.Bytes);
public long this[int i]=>Value[i];

public static A195307Inst Instance=new A195307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195308
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,7L,11L,15L,22L,30L,43L,58L,81L,109L,150L,200L,271L,359L,481L,633L,838L,1095L,1438L,1867L,2430L,3136L,4053L,5200L,6676L,8519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195308Inst : IEnumerable<long>
{
public static readonly long[] Value=A195308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195308.Bytes);
public long this[int i]=>Value[i];

public static A195308Inst Instance=new A195308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195309
{
public static readonly long[] Value={ 1L,9L,11L,45L,39L,126L,94L,270L,185L,495L,321L,819L,511L,1260L,764L,1836L,1089L,2565L,1495L,3465L,1991L,4554L,2586L,5850L,3289L,7371L,4109L,9135L,5055L,11160L,6136L,13464L,7361L,16065L,8739L,18981L,10279L,22230L,11990L,25830L,13881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195309Inst : IEnumerable<long>
{
public static readonly long[] Value=A195309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195309.Bytes);
public long this[int i]=>Value[i];

public static A195309Inst Instance=new A195309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195310
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,3L,2L,4L,3L,0L,5L,4L,1L,6L,5L,2L,0L,7L,6L,3L,1L,8L,7L,4L,2L,9L,8L,5L,3L,10L,9L,6L,4L,11L,10L,7L,5L,0L,12L,11L,8L,6L,1L,13L,12L,9L,7L,2L,14L,13L,10L,8L,3L,0L,15L,14L,11L,9L,4L,1L,16L,15L,12L,10L,5L,2L,17L,16L,13L,11L,6L,3L,18L,17L,14L,12L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195310Inst : IEnumerable<long>
{
public static readonly long[] Value=A195310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195310.Bytes);
public long this[int i]=>Value[i];

public static A195310Inst Instance=new A195310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195311
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,10L,13L,17L,21L,25L,29L,33L,38L,43L,48L,54L,60L,66L,72L,78L,84L,90L,97L,104L,111L,118L,126L,134L,142L,150L,158L,166L,174L,182L,190L,199L,208L,217L,226L,235L,245L,255L,265L,275L,285L,295L,305L,315L,325L,335L,345L,356L,367L,378L,389L,400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195311Inst : IEnumerable<long>
{
public static readonly long[] Value=A195311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195311.Bytes);
public long this[int i]=>Value[i];

public static A195311Inst Instance=new A195311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195312
{
public static readonly long[] Value={ 0L,1L,9L,3L,18L,5L,27L,7L,36L,9L,45L,11L,54L,13L,63L,15L,72L,17L,81L,19L,90L,21L,99L,23L,108L,25L,117L,27L,126L,29L,135L,31L,144L,33L,153L,35L,162L,37L,171L,39L,180L,41L,189L,43L,198L,45L,207L,47L,216L,49L,225L,51L,234L,53L,243L,55L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195312Inst : IEnumerable<long>
{
public static readonly long[] Value=A195312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195312.Bytes);
public long this[int i]=>Value[i];

public static A195312Inst Instance=new A195312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195313
{
public static readonly long[] Value={ 0L,1L,10L,13L,31L,36L,63L,70L,106L,115L,160L,171L,225L,238L,301L,316L,388L,405L,486L,505L,595L,616L,715L,738L,846L,871L,988L,1015L,1141L,1170L,1305L,1336L,1480L,1513L,1666L,1701L,1863L,1900L,2071L,2110L,2290L,2331L,2520L,2563L,2761L,2806L,3013L,3060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195313Inst : IEnumerable<long>
{
public static readonly long[] Value=A195313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195313.Bytes);
public long this[int i]=>Value[i];

public static A195313Inst Instance=new A195313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195314
{
public static readonly long[] Value={ 1L,29L,85L,169L,281L,421L,589L,785L,1009L,1261L,1541L,1849L,2185L,2549L,2941L,3361L,3809L,4285L,4789L,5321L,5881L,6469L,7085L,7729L,8401L,9101L,9829L,10585L,11369L,12181L,13021L,13889L,14785L,15709L,16661L,17641L,18649L,19685L,20749L,21841L,22961L,24109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195314Inst : IEnumerable<long>
{
public static readonly long[] Value=A195314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195314.Bytes);
public long this[int i]=>Value[i];

public static A195314Inst Instance=new A195314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195315
{
public static readonly long[] Value={ 1L,33L,97L,193L,321L,481L,673L,897L,1153L,1441L,1761L,2113L,2497L,2913L,3361L,3841L,4353L,4897L,5473L,6081L,6721L,7393L,8097L,8833L,9601L,10401L,11233L,12097L,12993L,13921L,14881L,15873L,16897L,17953L,19041L,20161L,21313L,22497L,23713L,24961L,26241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195315Inst : IEnumerable<long>
{
public static readonly long[] Value=A195315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195315.Bytes);
public long this[int i]=>Value[i];

public static A195315Inst Instance=new A195315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195316
{
public static readonly long[] Value={ 1L,37L,109L,217L,361L,541L,757L,1009L,1297L,1621L,1981L,2377L,2809L,3277L,3781L,4321L,4897L,5509L,6157L,6841L,7561L,8317L,9109L,9937L,10801L,11701L,12637L,13609L,14617L,15661L,16741L,17857L,19009L,20197L,21421L,22681L,23977L,25309L,26677L,28081L,29521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195316Inst : IEnumerable<long>
{
public static readonly long[] Value=A195316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195316.Bytes);
public long this[int i]=>Value[i];

public static A195316Inst Instance=new A195316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195317
{
public static readonly long[] Value={ 1L,41L,121L,241L,401L,601L,841L,1121L,1441L,1801L,2201L,2641L,3121L,3641L,4201L,4801L,5441L,6121L,6841L,7601L,8401L,9241L,10121L,11041L,12001L,13001L,14041L,15121L,16241L,17401L,18601L,19841L,21121L,22441L,23801L,25201L,26641L,28121L,29641L,31201L,32801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195317Inst : IEnumerable<long>
{
public static readonly long[] Value=A195317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195317.Bytes);
public long this[int i]=>Value[i];

public static A195317Inst Instance=new A195317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195318
{
public static readonly long[] Value={ 1L,45L,133L,265L,441L,661L,925L,1233L,1585L,1981L,2421L,2905L,3433L,4005L,4621L,5281L,5985L,6733L,7525L,8361L,9241L,10165L,11133L,12145L,13201L,14301L,15445L,16633L,17865L,19141L,20461L,21825L,23233L,24685L,26181L,27721L,29305L,30933L,32605L,34321L,36081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195318Inst : IEnumerable<long>
{
public static readonly long[] Value=A195318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195318.Bytes);
public long this[int i]=>Value[i];

public static A195318Inst Instance=new A195318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195319
{
public static readonly long[] Value={ 0L,9L,30L,63L,108L,165L,234L,315L,408L,513L,630L,759L,900L,1053L,1218L,1395L,1584L,1785L,1998L,2223L,2460L,2709L,2970L,3243L,3528L,3825L,4134L,4455L,4788L,5133L,5490L,5859L,6240L,6633L,7038L,7455L,7884L,8325L,8778L,9243L,9720L,10209L,10710L,11223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195319Inst : IEnumerable<long>
{
public static readonly long[] Value=A195319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195319.Bytes);
public long this[int i]=>Value[i];

public static A195319Inst Instance=new A195319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195320
{
public static readonly long[] Value={ 0L,7L,42L,105L,196L,315L,462L,637L,840L,1071L,1330L,1617L,1932L,2275L,2646L,3045L,3472L,3927L,4410L,4921L,5460L,6027L,6622L,7245L,7896L,8575L,9282L,10017L,10780L,11571L,12390L,13237L,14112L,15015L,15946L,16905L,17892L,18907L,19950L,21021L,22120L,23247L,24402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195320Inst : IEnumerable<long>
{
public static readonly long[] Value=A195320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195320.Bytes);
public long this[int i]=>Value[i];

public static A195320Inst Instance=new A195320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195321
{
public static readonly long[] Value={ 0L,18L,72L,162L,288L,450L,648L,882L,1152L,1458L,1800L,2178L,2592L,3042L,3528L,4050L,4608L,5202L,5832L,6498L,7200L,7938L,8712L,9522L,10368L,11250L,12168L,13122L,14112L,15138L,16200L,17298L,18432L,19602L,20808L,22050L,23328L,24642L,25992L,27378L,28800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195321Inst : IEnumerable<long>
{
public static readonly long[] Value=A195321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195321.Bytes);
public long this[int i]=>Value[i];

public static A195321Inst Instance=new A195321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195322
{
public static readonly long[] Value={ 0L,20L,80L,180L,320L,500L,720L,980L,1280L,1620L,2000L,2420L,2880L,3380L,3920L,4500L,5120L,5780L,6480L,7220L,8000L,8820L,9680L,10580L,11520L,12500L,13520L,14580L,15680L,16820L,18000L,19220L,20480L,21780L,23120L,24500L,25920L,27380L,28880L,30420L,32000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195322Inst : IEnumerable<long>
{
public static readonly long[] Value=A195322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195322.Bytes);
public long this[int i]=>Value[i];

public static A195322Inst Instance=new A195322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195323
{
public static readonly long[] Value={ 0L,22L,88L,198L,352L,550L,792L,1078L,1408L,1782L,2200L,2662L,3168L,3718L,4312L,4950L,5632L,6358L,7128L,7942L,8800L,9702L,10648L,11638L,12672L,13750L,14872L,16038L,17248L,18502L,19800L,21142L,22528L,23958L,25432L,26950L,28512L,30118L,31768L,33462L,35200L,36982L,38808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195323Inst : IEnumerable<long>
{
public static readonly long[] Value=A195323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195323.Bytes);
public long this[int i]=>Value[i];

public static A195323Inst Instance=new A195323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195324
{
public static readonly long[] Value={ 2L,4L,6L,32L,56L,92L,98L,122L,128L,140L,152L,176L,194L,212L,224L,242L,254L,260L,272L,296L,302L,308L,326L,332L,368L,392L,398L,410L,422L,434L,452L,458L,476L,488L,500L,512L,518L,524L,536L,542L,560L,572L,596L,602L,632L,644L,656L,662L,674L,686L,692L,704L,710L,728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195324Inst : IEnumerable<long>
{
public static readonly long[] Value=A195324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195324.Bytes);
public long this[int i]=>Value[i];

public static A195324Inst Instance=new A195324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195325
{
public static readonly long[] Value={ 2L,59L,71L,29L,59L,149L,191L,641L,149L,347L,809L,461L,3371L,1487L,857L,1301L,1877L,5849L,4721L,9239L,4271L,1619L,1481L,20507L,20981L,32117L,13337L,19379L,24977L,48779L,20441L,25301L,5651L,37991L,17747L,43577L,176777L,145757L,191249L,84809L,150209L,11717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195325Inst : IEnumerable<long>
{
public static readonly long[] Value=A195325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195325.Bytes);
public long this[int i]=>Value[i];

public static A195325Inst Instance=new A195325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195326
{
public static readonly long[] Value={ 0L,2L,2L,7L,7L,47L,47L,5923L,5923L,426457L,426457L,15636757L,15636757L,7318002277L,7318002277L,1536780478171L,1536780478171L,603180793741L,603180793741L,142957467201379447L,142957467201379447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195326Inst : IEnumerable<long>
{
public static readonly long[] Value=A195326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195326.Bytes);
public long this[int i]=>Value[i];

public static A195326Inst Instance=new A195326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195327
{
public static readonly long[] Value={ 2L,4L,8L,16L,36L,40L,48L,100L,144L,324L,484L,900L,1296L,1764L,2116L,2704L,3600L,6084L,9216L,13728L,19044L,24336L,30000L,39204L,39360L,44100L,51984L,63888L,72900L,81648L,93636L,108900L,112896L,133956L,142884L,191844L,229376L,248004L,269568L,298116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195327Inst : IEnumerable<long>
{
public static readonly long[] Value=A195327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195327.Bytes);
public long this[int i]=>Value[i];

public static A195327Inst Instance=new A195327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195328
{
public static readonly long[] Value={ 2L,4L,6L,18L,50L,54L,162L,242L,450L,486L,882L,1058L,1782L,3042L,3078L,4050L,5202L,9522L,19602L,22050L,36450L,46818L,54450L,66978L,71442L,95922L,124002L,149058L,183618L,190962L,238050L,240570L,263538L,277830L,328050L,466578L,684450L,816642L,977202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195328Inst : IEnumerable<long>
{
public static readonly long[] Value=A195328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195328.Bytes);
public long this[int i]=>Value[i];

public static A195328Inst Instance=new A195328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195329
{
public static readonly long[] Value={ 2L,59L,71L,149L,191L,641L,809L,3371L,5849L,9239L,20507L,20981L,32117L,48779L,176777L,191249L,204509L,211061L,223679L,245129L,358877L,654161L,2342771L,3053291L,4297961L,4755347L,6750221L,8019509L,9750371L,10196759L,11237981L,23367077L,34910219L,93929219L,186635747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195329Inst : IEnumerable<long>
{
public static readonly long[] Value=A195329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195329.Bytes);
public long this[int i]=>Value[i];

public static A195329Inst Instance=new A195329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195330
{
public static readonly long[] Value={ 32L,64L,81L,121L,125L,128L,169L,243L,256L,289L,320L,343L,361L,375L,384L,405L,448L,486L,512L,529L,567L,625L,640L,686L,729L,768L,841L,875L,896L,961L,1024L,1029L,1215L,1250L,1280L,1331L,1369L,1458L,1536L,1681L,1701L,1715L,1792L,1849L,1875L,2048L,2187L,2197L,2209L,2401L,2430L,2500L,2560L,2592L,2656L,2662L,2738L,2744L,2752L,2809L,2816L,2848L,2916L,2944L,3008L,3072L,3104L,3125L,3136L,3200L,3328L,3362L,3375L,3392L,3402L,3430L,3456L,3481L,3483L,3584L,3645L,3698L,3712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195330Inst : IEnumerable<long>
{
public static readonly long[] Value=A195330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195330.Bytes);
public long this[int i]=>Value[i];

public static A195330Inst Instance=new A195330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195331
{
public static readonly long[] Value={ 25L,26L,34L,112L,53L,27L,132L,35L,28L,172L,265L,73L,192L,353L,273L,345L,267L,235L,29L,232L,347L,54L,275L,273L,36L,283L,292L,537L,277L,312L,210L,373L,355L,254L,285L,113L,372L,236L,293L,412L,357L,573L,287L,432L,354L,211L,37L,133L,472L,74L,2355L,2254L,295L,2534L,2583L,2113L,2372L,2373L,2643L,532L,2811L,2589L,2236L,2723L,2647L,2103L,2597L,55L,2672L,2752L,2813L,2412L,3353L,2653L,2357L,2573L,2733L,592L,3443L,297L,365L,2432L,2729L,612L,2354L,2659L,3447L,2835L,2435L,2661L,2731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195331Inst : IEnumerable<long>
{
public static readonly long[] Value=A195331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195331.Bytes);
public long this[int i]=>Value[i];

public static A195331Inst Instance=new A195331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195332
{
public static readonly long[] Value={ 9L,18L,36L,72L,121L,144L,242L,288L,484L,576L,968L,1152L,1936L,2304L,3872L,4608L,7744L,9216L,15488L,18432L,30976L,36481L,36864L,61952L,72361L,72962L,73728L,123904L,144722L,145924L,146689L,147456L,247808L,259081L,289444L,291848L,293378L,294912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195332Inst : IEnumerable<long>
{
public static readonly long[] Value=A195332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195332.Bytes);
public long this[int i]=>Value[i];

public static A195332Inst Instance=new A195332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195333
{
public static readonly long[] Value={ 1L,2L,4L,6L,25L,27L,33L,42L,221L,274L,581L,1957L,3125L,11406L,47058L,823543L,1535573L,5056941L,19246541L,19571621L,36861842L,50330577L,2590282517L,45546909393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195333Inst : IEnumerable<long>
{
public static readonly long[] Value=A195333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195333.Bytes);
public long this[int i]=>Value[i];

public static A195333Inst Instance=new A195333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195334
{
public static readonly long[] Value={ 4L,8L,18L,32L,50L,128L,578L,1458L,3362L,4802L,6962L,8192L,10082L,15842L,20402L,31250L,34322L,55778L,57122L,59858L,131072L,167042L,171698L,293378L,524288L,559682L,916658L,982802L,1062882L,1104098L,1158242L,1195058L,1367858L,1407842L,1414562L,1468898L,1659842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195334Inst : IEnumerable<long>
{
public static readonly long[] Value=A195334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195334.Bytes);
public long this[int i]=>Value[i];

public static A195334Inst Instance=new A195334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195335
{
public static readonly BigInteger[] Value={ 2L,211L,211151L,2111511013L,211151101310867L,BigInteger.Parse("211151101310867100673"),BigInteger.Parse("2111511013108671006731000357"),BigInteger.Parse("211151101310867100673100035710000931"),BigInteger.Parse("211151101310867100673100035710000931100000213"),BigInteger.Parse("2111511013108671006731000357100009311000002131000000901"),BigInteger.Parse("211151101310867100673100035710000931100000213100000090110000001797") };
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
public class A195335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195335Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195335.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195335.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195335Inst Instance=new A195335Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195336
{
public static readonly long[] Value={ 8L,6L,2L,150L,96L,324L,6L,1518L,174L,168L,21384L,18L,20754L,2988L,2424L,8196L,3786L,14952L,34056L,48L,1620L,8256L,31344L,1176L,123360L,147456L,28650L,132L,90L,12834L,81126L,11790L,2340L,9702L,11496L,33000L,10716L,66954L,6816L,234L,109956L,3012L,6744L,117654L,19950L,26550L,8226L,40584L,23640L,30660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195336Inst : IEnumerable<long>
{
public static readonly long[] Value=A195336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195336.Bytes);
public long this[int i]=>Value[i];

public static A195336Inst Instance=new A195336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195337
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,38L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195337Inst : IEnumerable<long>
{
public static readonly long[] Value=A195337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195337.Bytes);
public long this[int i]=>Value[i];

public static A195337Inst Instance=new A195337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195338
{
public static readonly long[] Value={ 1L,2L,6L,12L,180L,360L,7560L,15120L,226800L,453600L,14968800L,29937600L,40864824000L,81729648000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195338Inst : IEnumerable<long>
{
public static readonly long[] Value=A195338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195338.Bytes);
public long this[int i]=>Value[i];

public static A195338Inst Instance=new A195338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195339
{
public static readonly long[] Value={ 1L,4L,16L,62L,239L,920L,3540L,13620L,52401L,201604L,775636L,2984122L,11480879L,44170640L,169938680L,653808840L,2515413201L,9677604804L,37232862856L,143246816182L,551116641919L,2120323237160L,8157566453420L,31384785713660L,120747379738401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195339Inst : IEnumerable<long>
{
public static readonly long[] Value=A195339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195339.Bytes);
public long this[int i]=>Value[i];

public static A195339Inst Instance=new A195339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195340
{
public static readonly long[] Value={ 7L,8L,4L,9L,2L,9L,6L,8L,4L,7L,6L,4L,4L,3L,4L,9L,4L,5L,2L,0L,1L,7L,2L,4L,3L,6L,3L,4L,5L,6L,7L,3L,5L,6L,7L,2L,6L,9L,4L,4L,4L,6L,1L,4L,2L,6L,3L,0L,2L,4L,6L,6L,8L,1L,0L,5L,5L,5L,4L,4L,8L,5L,5L,7L,9L,2L,3L,8L,2L,7L,5L,4L,4L,9L,4L,8L,3L,1L,3L,4L,8L,5L,5L,6L,0L,9L,0L,1L,9L,1L,7L,7L,8L,0L,0L,9L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195340Inst : IEnumerable<long>
{
public static readonly long[] Value=A195340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195340.Bytes);
public long this[int i]=>Value[i];

public static A195340Inst Instance=new A195340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195341
{
public static readonly long[] Value={ 8L,9L,8L,0L,5L,5L,9L,5L,3L,1L,5L,9L,1L,7L,0L,7L,4L,4L,8L,8L,3L,8L,9L,0L,3L,0L,3L,5L,9L,5L,0L,5L,3L,5L,7L,5L,1L,5L,8L,4L,2L,4L,9L,6L,4L,6L,4L,2L,1L,6L,7L,0L,3L,8L,7L,8L,8L,9L,5L,7L,2L,6L,8L,3L,3L,7L,6L,1L,5L,1L,1L,2L,9L,5L,8L,0L,4L,1L,6L,5L,3L,1L,9L,2L,8L,6L,1L,1L,5L,5L,0L,1L,8L,6L,8L,5L,1L,6L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195341Inst : IEnumerable<long>
{
public static readonly long[] Value=A195341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195341.Bytes);
public long this[int i]=>Value[i];

public static A195341Inst Instance=new A195341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195342
{
public static readonly long[] Value={ 1L,0L,8L,0L,3L,6L,3L,0L,2L,6L,9L,5L,0L,9L,0L,5L,8L,1L,4L,4L,0L,6L,1L,7L,2L,6L,2L,8L,1L,9L,6L,3L,7L,5L,7L,0L,1L,9L,8L,9L,4L,6L,0L,4L,8L,6L,8L,0L,5L,6L,2L,7L,3L,9L,2L,6L,7L,2L,5L,3L,4L,3L,6L,1L,1L,7L,9L,6L,0L,2L,9L,9L,6L,7L,4L,7L,0L,8L,2L,8L,9L,5L,2L,0L,6L,9L,1L,4L,4L,9L,4L,6L,0L,3L,6L,2L,4L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195342Inst : IEnumerable<long>
{
public static readonly long[] Value=A195342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195342.Bytes);
public long this[int i]=>Value[i];

public static A195342Inst Instance=new A195342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195343
{
public static readonly long[] Value={ 5L,2L,7L,7L,5L,2L,6L,3L,3L,6L,0L,7L,7L,1L,0L,3L,5L,6L,1L,1L,8L,2L,1L,4L,2L,9L,0L,2L,9L,3L,9L,4L,9L,5L,2L,2L,3L,8L,0L,4L,0L,2L,1L,3L,5L,2L,9L,2L,0L,4L,0L,2L,9L,8L,3L,5L,1L,1L,8L,0L,3L,5L,8L,9L,3L,0L,7L,0L,2L,0L,3L,8L,2L,2L,5L,3L,2L,5L,8L,9L,8L,0L,5L,2L,1L,1L,3L,4L,1L,4L,7L,7L,9L,8L,1L,3L,4L,3L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195343Inst : IEnumerable<long>
{
public static readonly long[] Value=A195343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195343.Bytes);
public long this[int i]=>Value[i];

public static A195343Inst Instance=new A195343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195344
{
public static readonly long[] Value={ 8L,4L,8L,6L,8L,0L,9L,6L,8L,7L,9L,3L,4L,1L,5L,9L,6L,8L,1L,3L,0L,9L,8L,9L,7L,4L,8L,3L,0L,2L,9L,8L,5L,1L,5L,9L,3L,8L,1L,8L,4L,6L,1L,8L,5L,1L,2L,0L,2L,0L,1L,5L,9L,0L,5L,2L,1L,4L,8L,4L,9L,1L,9L,7L,6L,6L,5L,2L,5L,4L,9L,2L,3L,5L,6L,3L,9L,4L,4L,0L,4L,6L,2L,4L,5L,2L,5L,0L,3L,4L,5L,3L,0L,8L,9L,5L,4L,3L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195344Inst : IEnumerable<long>
{
public static readonly long[] Value=A195344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195344.Bytes);
public long this[int i]=>Value[i];

public static A195344Inst Instance=new A195344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195345
{
public static readonly long[] Value={ 1L,0L,3L,2L,6L,4L,1L,4L,9L,1L,2L,0L,9L,3L,4L,7L,3L,6L,1L,4L,7L,5L,6L,3L,7L,6L,5L,5L,6L,5L,7L,6L,1L,1L,4L,8L,5L,4L,1L,4L,2L,2L,0L,1L,8L,5L,8L,1L,6L,7L,1L,1L,5L,6L,8L,9L,2L,7L,0L,6L,5L,3L,6L,1L,1L,0L,5L,5L,7L,9L,5L,0L,5L,3L,9L,8L,2L,3L,3L,0L,2L,4L,9L,7L,6L,0L,2L,8L,0L,4L,2L,2L,8L,7L,6L,6L,4L,8L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195345Inst : IEnumerable<long>
{
public static readonly long[] Value=A195345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195345.Bytes);
public long this[int i]=>Value[i];

public static A195345Inst Instance=new A195345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195346
{
public static readonly long[] Value={ 1L,1L,8L,4L,7L,1L,8L,2L,9L,4L,4L,9L,2L,8L,0L,0L,8L,0L,2L,3L,8L,8L,4L,0L,7L,5L,5L,9L,3L,7L,6L,2L,3L,9L,8L,4L,3L,3L,9L,7L,4L,5L,0L,7L,8L,2L,2L,8L,4L,7L,4L,0L,8L,4L,4L,1L,6L,4L,9L,2L,4L,4L,6L,1L,1L,4L,1L,8L,8L,8L,0L,6L,2L,5L,7L,2L,8L,1L,8L,3L,5L,6L,5L,7L,2L,7L,2L,1L,3L,2L,0L,5L,5L,3L,0L,0L,1L,7L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195346Inst : IEnumerable<long>
{
public static readonly long[] Value=A195346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195346.Bytes);
public long this[int i]=>Value[i];

public static A195346Inst Instance=new A195346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195347
{
public static readonly long[] Value={ 4L,2L,8L,0L,8L,1L,8L,0L,5L,8L,1L,2L,5L,2L,1L,9L,3L,5L,0L,2L,5L,2L,6L,7L,1L,5L,1L,7L,0L,3L,6L,9L,8L,0L,9L,0L,1L,5L,6L,8L,4L,4L,3L,6L,5L,5L,7L,9L,1L,6L,1L,2L,6L,4L,4L,4L,1L,3L,4L,3L,5L,9L,8L,2L,0L,8L,3L,7L,1L,5L,1L,0L,6L,3L,2L,7L,9L,2L,1L,5L,9L,8L,0L,0L,9L,5L,9L,6L,4L,6L,1L,4L,6L,2L,9L,7L,1L,1L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195347Inst : IEnumerable<long>
{
public static readonly long[] Value=A195347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195347.Bytes);
public long this[int i]=>Value[i];

public static A195347Inst Instance=new A195347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195348
{
public static readonly long[] Value={ 7L,5L,7L,8L,7L,4L,7L,6L,3L,9L,2L,6L,0L,2L,3L,9L,9L,8L,8L,1L,2L,1L,8L,6L,7L,4L,7L,4L,2L,7L,0L,0L,9L,5L,3L,0L,3L,4L,6L,7L,9L,2L,5L,4L,0L,1L,9L,4L,4L,5L,2L,0L,3L,5L,8L,4L,1L,3L,3L,3L,8L,1L,7L,4L,6L,1L,0L,0L,9L,1L,5L,8L,9L,3L,3L,7L,9L,8L,1L,0L,2L,3L,2L,1L,8L,3L,1L,2L,7L,1L,1L,0L,1L,2L,8L,5L,8L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195348Inst : IEnumerable<long>
{
public static readonly long[] Value=A195348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195348.Bytes);
public long this[int i]=>Value[i];

public static A195348Inst Instance=new A195348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195349
{
public static readonly long[] Value={ 1L,7L,19L,41L,57L,64L,68L,133L,145L,149L,164L,235L,267L,291L,317L,336L,358L,419L,433L,503L,528L,566L,599L,612L,659L,726L,801L,927L,1017L,1035L,1077L,1118L,1190L,1206L,1213L,1281L,1297L,1309L,1320L,1323L,1367L,1446L,1473L,1485L,1516L,1595L,1611L,1634L,1941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195349Inst : IEnumerable<long>
{
public static readonly long[] Value=A195349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195349.Bytes);
public long this[int i]=>Value[i];

public static A195349Inst Instance=new A195349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195350
{
public static readonly long[] Value={ 1L,1L,3L,10L,37L,141L,541L,2080L,8001L,30781L,118423L,455610L,1752877L,6743881L,25945881L,99822160L,384048001L,1477556361L,5684635243L,21870622810L,84143330517L,323726495221L,1245480100021L,4791763116240L,18435456144001L,70927137880741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195350Inst : IEnumerable<long>
{
public static readonly long[] Value=A195350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195350.Bytes);
public long this[int i]=>Value[i];

public static A195350Inst Instance=new A195350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195351
{
public static readonly long[] Value={ 0L,25L,27L,45L,49L,97L,99L,113L,139L,176L,186L,208L,216L,227L,232L,259L,298L,309L,332L,358L,362L,364L,387L,490L,631L,659L,662L,676L,698L,705L,718L,726L,737L,747L,781L,849L,860L,862L,901L,913L,918L,936L,958L,965L,966L,992L,998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195351Inst : IEnumerable<long>
{
public static readonly long[] Value=A195351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195351.Bytes);
public long this[int i]=>Value[i];

public static A195351Inst Instance=new A195351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195352
{
public static readonly long[] Value={ 2L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,3L,7L,2L,2L,3L,5L,2L,3L,2L,2L,3L,2L,3L,7L,2L,3L,7L,2L,2L,3L,5L,2L,3L,2L,2L,3L,5L,2L,3L,2L,3L,19L,2L,3L,7L,5L,2L,3L,2L,2L,3L,2L,2L,3L,2L,3L,7L,5L,11L,7L,11L,2L,3L,2L,3L,13L,2L,2L,3L,5L,5L,7L,2L,2L,3L,5L,2L,3L,7L,2L,3L,2L,3L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195352Inst : IEnumerable<long>
{
public static readonly long[] Value=A195352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195352.Bytes);
public long this[int i]=>Value[i];

public static A195352Inst Instance=new A195352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195353
{
public static readonly long[] Value={ 7L,13L,31L,91L,451L,539L,1397L,1417L,1777L,3139L,14419L,39751L,77507L,96157L,158173L,214979L,263113L,496723L,1046179L,3415297L,3546371L,4306549L,9456677L,18338311L,45521269L,243377803L,766707661L,1023263789L,8032822531L,92635306249L,151318414531L,352799777983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195353Inst : IEnumerable<long>
{
public static readonly long[] Value=A195353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195353.Bytes);
public long this[int i]=>Value[i];

public static A195353Inst Instance=new A195353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195354
{
public static readonly long[] Value={ 2L,3L,7L,19L,31L,41L,47L,67L,79L,139L,181L,229L,233L,277L,307L,383L,421L,463L,619L,643L,659L,691L,743L,967L,1231L,1483L,1609L,1931L,2389L,2719L,2791L,2953L,2971L,3079L,3121L,3217L,3301L,3319L,3617L,3719L,3767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195354Inst : IEnumerable<long>
{
public static readonly long[] Value=A195354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195354.Bytes);
public long this[int i]=>Value[i];

public static A195354Inst Instance=new A195354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195355
{
public static readonly long[] Value={ 1L,4L,5L,6L,9L,6L,4L,1L,0L,1L,6L,1L,4L,4L,8L,5L,9L,8L,3L,8L,5L,1L,0L,9L,1L,5L,8L,7L,1L,3L,9L,2L,6L,6L,9L,8L,4L,0L,8L,2L,2L,8L,5L,1L,6L,8L,1L,0L,7L,3L,1L,9L,3L,6L,3L,0L,0L,6L,4L,7L,6L,5L,1L,5L,1L,9L,0L,4L,9L,9L,9L,7L,4L,5L,4L,4L,3L,1L,3L,1L,3L,0L,1L,6L,3L,5L,6L,0L,8L,8L,9L,8L,2L,8L,3L,4L,4L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195355Inst : IEnumerable<long>
{
public static readonly long[] Value=A195355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195355.Bytes);
public long this[int i]=>Value[i];

public static A195355Inst Instance=new A195355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195356
{
public static readonly long[] Value={ 1L,5L,8L,1L,5L,9L,1L,1L,2L,9L,5L,2L,1L,7L,3L,0L,5L,5L,3L,1L,7L,8L,2L,9L,6L,3L,5L,5L,1L,3L,5L,5L,6L,8L,9L,5L,2L,4L,4L,0L,1L,8L,4L,5L,8L,7L,1L,8L,9L,7L,9L,8L,8L,5L,5L,4L,4L,2L,0L,2L,8L,5L,4L,7L,5L,5L,6L,6L,3L,1L,7L,7L,9L,6L,4L,2L,4L,6L,9L,2L,3L,1L,6L,9L,4L,6L,5L,9L,2L,9L,8L,7L,0L,0L,9L,3L,2L,0L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195356Inst : IEnumerable<long>
{
public static readonly long[] Value=A195356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195356.Bytes);
public long this[int i]=>Value[i];

public static A195356Inst Instance=new A195356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195357
{
public static readonly long[] Value={ 1L,9L,7L,2L,0L,4L,8L,2L,9L,8L,2L,7L,2L,6L,9L,0L,4L,1L,3L,9L,8L,0L,2L,1L,9L,5L,1L,2L,0L,2L,5L,7L,0L,8L,4L,0L,3L,2L,8L,4L,5L,8L,8L,4L,3L,0L,7L,8L,5L,1L,4L,3L,9L,5L,8L,2L,9L,8L,4L,2L,7L,8L,8L,5L,5L,2L,7L,7L,2L,8L,7L,6L,0L,2L,4L,8L,3L,1L,0L,9L,9L,8L,6L,6L,3L,5L,8L,8L,8L,2L,0L,5L,4L,4L,2L,7L,5L,8L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195357Inst : IEnumerable<long>
{
public static readonly long[] Value=A195357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195357.Bytes);
public long this[int i]=>Value[i];

public static A195357Inst Instance=new A195357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195358
{
public static readonly long[] Value={ 5L,8L,2L,2L,5L,2L,4L,7L,5L,0L,6L,1L,6L,5L,6L,9L,9L,2L,6L,4L,7L,3L,2L,2L,5L,5L,2L,4L,7L,7L,4L,9L,0L,5L,1L,0L,4L,8L,9L,8L,0L,6L,4L,4L,4L,1L,1L,5L,6L,7L,0L,1L,2L,1L,2L,4L,4L,8L,2L,9L,2L,1L,7L,2L,0L,3L,2L,9L,1L,2L,3L,8L,5L,6L,7L,8L,0L,4L,2L,1L,2L,2L,1L,4L,0L,2L,4L,9L,7L,8L,8L,3L,7L,7L,0L,7L,4L,6L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195358Inst : IEnumerable<long>
{
public static readonly long[] Value=A195358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195358.Bytes);
public long this[int i]=>Value[i];

public static A195358Inst Instance=new A195358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195359
{
public static readonly long[] Value={ 1L,6L,4L,4L,5L,0L,8L,0L,6L,0L,3L,2L,3L,0L,2L,4L,2L,4L,9L,0L,0L,0L,2L,9L,9L,7L,3L,1L,4L,3L,0L,5L,1L,3L,3L,1L,4L,8L,7L,5L,9L,6L,6L,3L,2L,9L,1L,3L,1L,4L,2L,8L,2L,3L,4L,6L,5L,7L,9L,9L,0L,2L,4L,0L,2L,4L,4L,3L,1L,7L,7L,8L,7L,2L,2L,0L,2L,2L,3L,8L,3L,8L,8L,5L,5L,0L,3L,6L,2L,6L,4L,9L,3L,8L,6L,0L,2L,8L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195359Inst : IEnumerable<long>
{
public static readonly long[] Value=A195359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195359.Bytes);
public long this[int i]=>Value[i];

public static A195359Inst Instance=new A195359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195360
{
public static readonly long[] Value={ 1L,9L,5L,0L,1L,2L,5L,7L,0L,6L,5L,2L,0L,6L,5L,8L,8L,2L,5L,3L,3L,8L,5L,5L,7L,6L,0L,7L,8L,2L,0L,1L,4L,3L,3L,9L,3L,1L,7L,9L,7L,7L,3L,5L,4L,4L,7L,5L,9L,4L,8L,0L,2L,4L,4L,4L,6L,7L,9L,8L,6L,5L,9L,9L,3L,8L,6L,1L,6L,8L,3L,7L,6L,0L,9L,3L,5L,9L,2L,7L,8L,1L,2L,8L,2L,9L,0L,9L,3L,6L,5L,9L,7L,8L,7L,0L,2L,0L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195360Inst : IEnumerable<long>
{
public static readonly long[] Value=A195360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195360.Bytes);
public long this[int i]=>Value[i];

public static A195360Inst Instance=new A195360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195361
{
public static readonly long[] Value={ 2L,2L,8L,3L,7L,2L,1L,8L,3L,0L,7L,4L,7L,7L,5L,7L,0L,5L,5L,9L,5L,0L,4L,1L,0L,0L,4L,2L,3L,0L,9L,5L,6L,3L,5L,4L,4L,6L,2L,6L,9L,9L,7L,5L,3L,5L,0L,9L,2L,0L,3L,8L,0L,4L,3L,2L,8L,6L,2L,7L,3L,9L,2L,5L,4L,1L,4L,7L,7L,5L,1L,9L,1L,8L,6L,1L,7L,4L,8L,0L,2L,7L,3L,1L,0L,4L,4L,3L,0L,2L,5L,9L,0L,6L,3L,3L,9L,3L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195361Inst : IEnumerable<long>
{
public static readonly long[] Value=A195361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195361.Bytes);
public long this[int i]=>Value[i];

public static A195361Inst Instance=new A195361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195362
{
public static readonly long[] Value={ 4L,7L,4L,6L,2L,8L,7L,7L,4L,7L,5L,8L,4L,2L,7L,0L,5L,1L,6L,4L,7L,1L,1L,9L,3L,1L,1L,3L,9L,9L,5L,1L,6L,6L,8L,0L,4L,8L,7L,6L,6L,6L,3L,6L,8L,5L,9L,7L,0L,9L,3L,2L,6L,8L,8L,7L,1L,3L,8L,9L,6L,7L,5L,8L,4L,3L,8L,6L,6L,8L,5L,9L,6L,5L,5L,7L,5L,2L,0L,7L,3L,2L,7L,5L,7L,2L,8L,8L,3L,5L,4L,7L,1L,9L,8L,2L,9L,4L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195362Inst : IEnumerable<long>
{
public static readonly long[] Value=A195362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195362.Bytes);
public long this[int i]=>Value[i];

public static A195362Inst Instance=new A195362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195363
{
public static readonly long[] Value={ 147718L,151522L,154477L,176777L,177147L,184488L,188148L,188188L,191992L,204232L,222222L,222252L,222652L,222722L,222777L,222992L,225522L,225592L,266627L,350303L,353222L,363313L,369638L,379292L,413313L,416118L,418418L,441103L,447577L,477227L,484448L,488488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195363Inst : IEnumerable<long>
{
public static readonly long[] Value=A195363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195363.Bytes);
public long this[int i]=>Value[i];

public static A195363Inst Instance=new A195363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195364
{
public static readonly long[] Value={ 2L,4L,5L,8L,9L,15L,17L,26L,33L,46L,58L,83L,103L,139L,180L,236L,299L,391L,492L,633L,796L,1006L,1257L,1583L,1961L,2440L,3014L,3724L,4567L,5612L,6844L,8355L,10147L,12314L,14887L,17986L,21639L,26019L,31189L,37346L,44585L,53182L,63263L,75181L,89140L,105562L,124756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195364Inst : IEnumerable<long>
{
public static readonly long[] Value=A195364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195364.Bytes);
public long this[int i]=>Value[i];

public static A195364Inst Instance=new A195364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195365
{
public static readonly long[] Value={ 9L,6L,6L,2L,7L,3L,9L,6L,1L,5L,7L,6L,7L,1L,2L,9L,5L,7L,2L,0L,9L,3L,8L,8L,6L,4L,9L,0L,0L,9L,2L,1L,2L,4L,8L,1L,6L,3L,4L,4L,4L,6L,9L,2L,6L,1L,3L,1L,5L,3L,9L,1L,4L,2L,4L,2L,6L,3L,4L,9L,7L,1L,5L,7L,5L,1L,3L,2L,2L,7L,8L,5L,0L,7L,6L,4L,4L,7L,6L,0L,1L,3L,2L,0L,4L,7L,0L,9L,0L,0L,1L,3L,2L,9L,1L,2L,4L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195365Inst : IEnumerable<long>
{
public static readonly long[] Value=A195365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195365.Bytes);
public long this[int i]=>Value[i];

public static A195365Inst Instance=new A195365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195366
{
public static readonly long[] Value={ 1L,0L,0L,7L,4L,6L,3L,7L,4L,8L,0L,3L,0L,0L,5L,1L,5L,9L,4L,2L,9L,2L,1L,1L,8L,8L,4L,0L,2L,6L,7L,0L,6L,6L,1L,8L,1L,5L,8L,0L,2L,2L,0L,5L,4L,3L,3L,8L,2L,5L,6L,7L,3L,4L,0L,1L,3L,7L,1L,2L,8L,8L,4L,0L,9L,4L,8L,0L,1L,7L,9L,2L,9L,6L,1L,7L,9L,3L,4L,2L,6L,5L,0L,5L,1L,2L,8L,2L,9L,8L,5L,7L,3L,6L,4L,7L,6L,6L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195366Inst : IEnumerable<long>
{
public static readonly long[] Value=A195366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195366.Bytes);
public long this[int i]=>Value[i];

public static A195366Inst Instance=new A195366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195367
{
public static readonly long[] Value={ 1L,2L,8L,7L,2L,1L,2L,0L,8L,2L,6L,1L,4L,7L,9L,8L,7L,6L,6L,1L,9L,8L,3L,9L,0L,5L,3L,0L,2L,7L,3L,1L,7L,2L,8L,5L,8L,2L,4L,6L,3L,9L,2L,3L,4L,1L,3L,3L,1L,4L,5L,3L,3L,0L,1L,5L,7L,5L,1L,8L,7L,7L,1L,4L,4L,5L,8L,3L,6L,5L,9L,3L,8L,8L,1L,8L,0L,7L,6L,8L,0L,5L,1L,9L,5L,6L,1L,1L,3L,2L,4L,7L,2L,5L,3L,3L,9L,9L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195367Inst : IEnumerable<long>
{
public static readonly long[] Value=A195367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195367.Bytes);
public long this[int i]=>Value[i];

public static A195367Inst Instance=new A195367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195368
{
public static readonly long[] Value={ 6L,0L,5L,8L,6L,1L,8L,4L,2L,3L,6L,1L,2L,3L,9L,9L,3L,3L,8L,5L,6L,6L,2L,4L,1L,9L,1L,1L,1L,8L,2L,7L,5L,0L,7L,5L,0L,6L,7L,8L,1L,8L,6L,5L,3L,3L,5L,1L,4L,6L,6L,2L,8L,3L,1L,7L,5L,5L,5L,7L,8L,8L,3L,5L,9L,2L,6L,5L,2L,2L,7L,9L,1L,0L,0L,9L,3L,2L,5L,7L,1L,0L,0L,5L,4L,5L,1L,7L,1L,6L,1L,1L,5L,9L,4L,0L,2L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195368Inst : IEnumerable<long>
{
public static readonly long[] Value=A195368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195368.Bytes);
public long this[int i]=>Value[i];

public static A195368Inst Instance=new A195368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195369
{
public static readonly long[] Value={ 7L,1L,5L,7L,9L,0L,1L,3L,5L,9L,8L,9L,9L,1L,4L,9L,5L,4L,5L,9L,5L,4L,9L,2L,6L,7L,2L,3L,3L,3L,4L,3L,2L,4L,9L,4L,5L,6L,6L,3L,6L,8L,3L,0L,6L,5L,6L,7L,0L,5L,1L,1L,4L,4L,1L,8L,8L,8L,6L,9L,2L,2L,0L,1L,8L,3L,4L,5L,3L,8L,4L,6L,2L,9L,2L,9L,5L,3L,1L,9L,3L,5L,2L,3L,4L,0L,5L,2L,5L,0L,1L,4L,2L,2L,0L,5L,7L,7L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195369Inst : IEnumerable<long>
{
public static readonly long[] Value=A195369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195369.Bytes);
public long this[int i]=>Value[i];

public static A195369Inst Instance=new A195369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195370
{
public static readonly long[] Value={ 7L,6L,8L,1L,3L,7L,4L,3L,2L,6L,1L,5L,5L,3L,6L,7L,6L,0L,7L,0L,1L,5L,3L,4L,5L,2L,1L,1L,1L,9L,2L,8L,7L,9L,5L,5L,0L,9L,2L,6L,7L,1L,9L,8L,8L,4L,5L,0L,7L,8L,6L,7L,6L,3L,0L,3L,4L,0L,7L,8L,5L,3L,7L,8L,0L,6L,5L,4L,5L,6L,6L,3L,0L,0L,7L,0L,5L,7L,3L,9L,6L,9L,0L,4L,7L,0L,2L,3L,1L,0L,7L,9L,2L,1L,7L,7L,0L,7L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195370Inst : IEnumerable<long>
{
public static readonly long[] Value=A195370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195370.Bytes);
public long this[int i]=>Value[i];

public static A195370Inst Instance=new A195370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195371
{
public static readonly long[] Value={ 9L,6L,4L,7L,2L,3L,8L,1L,9L,5L,8L,9L,9L,1L,6L,9L,5L,0L,6L,0L,4L,4L,0L,4L,6L,4L,9L,5L,0L,3L,8L,0L,6L,6L,8L,6L,6L,0L,3L,7L,2L,4L,3L,9L,4L,7L,2L,0L,2L,7L,7L,9L,4L,4L,7L,4L,3L,9L,8L,7L,1L,7L,0L,7L,3L,9L,7L,7L,2L,1L,0L,1L,0L,0L,4L,7L,9L,2L,0L,1L,2L,3L,1L,0L,5L,2L,8L,1L,0L,1L,2L,2L,3L,0L,0L,1L,3L,3L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195371Inst : IEnumerable<long>
{
public static readonly long[] Value=A195371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195371.Bytes);
public long this[int i]=>Value[i];

public static A195371Inst Instance=new A195371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195372
{
public static readonly long[] Value={ 5L,9L,0L,5L,6L,8L,0L,8L,0L,0L,1L,5L,9L,9L,7L,1L,3L,4L,3L,7L,4L,7L,0L,4L,6L,4L,4L,1L,6L,4L,6L,5L,0L,5L,6L,6L,9L,4L,4L,1L,0L,3L,2L,9L,4L,1L,9L,3L,4L,2L,2L,8L,8L,8L,7L,8L,2L,6L,1L,4L,8L,0L,1L,3L,7L,9L,5L,6L,6L,0L,0L,7L,2L,4L,2L,4L,6L,8L,5L,7L,1L,9L,9L,1L,0L,8L,4L,5L,3L,9L,5L,3L,6L,8L,5L,5L,6L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195372Inst : IEnumerable<long>
{
public static readonly long[] Value=A195372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195372.Bytes);
public long this[int i]=>Value[i];

public static A195372Inst Instance=new A195372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195373
{
public static readonly long[] Value={ 4L,88L,6969L,19899699L,399996663L,990999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195373Inst : IEnumerable<long>
{
public static readonly long[] Value=A195373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195373.Bytes);
public long this[int i]=>Value[i];

public static A195373Inst Instance=new A195373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195374
{
public static readonly BigInteger[] Value={ 27L,3375L,BigInteger.Parse("2775577757352755375573357273") };
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
public class A195374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195374.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195374Inst Instance=new A195374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195375
{
public static readonly long[] Value={ 13L,21L,27L,693L,3587L,75285L,435365L,437155L,929509L,1731765L,1902599L,1926903L,104916853L,605497891L,1914409189L,4634485093L,12882557131L,112438392323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195375Inst : IEnumerable<long>
{
public static readonly long[] Value=A195375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195375.Bytes);
public long this[int i]=>Value[i];

public static A195375Inst Instance=new A195375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195376
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195376Inst : IEnumerable<long>
{
public static readonly long[] Value=A195376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195376.Bytes);
public long this[int i]=>Value[i];

public static A195376Inst Instance=new A195376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195377
{
public static readonly long[] Value={ 127L,197L,281L,311L,347L,431L,613L,659L,673L,739L,877L,991L,1049L,1229L,1277L,1289L,1367L,1481L,1579L,1613L,1667L,1721L,1787L,1877L,1907L,2027L,2081L,2087L,2141L,2203L,2213L,2237L,2239L,2269L,2287L,2309L,2377L,2383L,2473L,2657L,2689L,2707L,2749L,2767L,2801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195377Inst : IEnumerable<long>
{
public static readonly long[] Value=A195377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195377.Bytes);
public long this[int i]=>Value[i];

public static A195377Inst Instance=new A195377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195378
{
public static readonly long[] Value={ 61L,63L,74L,92L,98L,100L,105L,107L,109L,113L,118L,119L,120L,121L,122L,126L,127L,128L,130L,131L,132L,134L,136L,138L,139L,140L,146L,147L,148L,149L,150L,151L,152L,153L,154L,155L,156L,157L,158L,159L,160L,162L,163L,165L,167L,168L,169L,170L,171L,172L,173L,175L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195378Inst : IEnumerable<long>
{
public static readonly long[] Value=A195378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195378.Bytes);
public long this[int i]=>Value[i];

public static A195378Inst Instance=new A195378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195379
{
public static readonly long[] Value={ 2L,137L,281L,521L,641L,883L,937L,1087L,1151L,1229L,1277L,1301L,1489L,1567L,1607L,1697L,2027L,2081L,2237L,2381L,2543L,2591L,2657L,2687L,2729L,2801L,2851L,2969L,3119L,3257L,3301L,3359L,3463L,3467L,3529L,3673L,3733L,3793L,3821L,3851L,4073L,4217L,4229L,4241L,4259L,4283L,4337L,4421L,4481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195379Inst : IEnumerable<long>
{
public static readonly long[] Value=A195379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195379.Bytes);
public long this[int i]=>Value[i];

public static A195379Inst Instance=new A195379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195380
{
public static readonly long[] Value={ 5L,5L,7L,5L,7L,0L,1L,7L,6L,9L,1L,7L,0L,9L,3L,8L,0L,3L,7L,2L,1L,1L,2L,9L,1L,4L,6L,0L,4L,2L,9L,2L,3L,1L,8L,7L,2L,1L,1L,5L,2L,6L,1L,0L,0L,8L,9L,0L,3L,0L,5L,5L,9L,9L,2L,1L,6L,7L,9L,5L,5L,8L,9L,0L,9L,5L,8L,8L,2L,5L,6L,8L,1L,9L,4L,3L,6L,5L,6L,9L,3L,1L,0L,6L,8L,1L,8L,1L,7L,7L,7L,1L,2L,4L,7L,7L,1L,9L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195380Inst : IEnumerable<long>
{
public static readonly long[] Value=A195380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195380.Bytes);
public long this[int i]=>Value[i];

public static A195380Inst Instance=new A195380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195381
{
public static readonly long[] Value={ 1L,3L,2L,3L,1L,6L,9L,0L,7L,6L,4L,9L,9L,2L,1L,4L,9L,9L,5L,4L,0L,3L,0L,7L,3L,6L,2L,4L,7L,3L,5L,2L,1L,7L,4L,8L,9L,9L,9L,5L,4L,9L,4L,0L,5L,6L,1L,3L,9L,5L,5L,1L,0L,5L,7L,5L,7L,9L,8L,4L,7L,1L,7L,2L,2L,4L,2L,3L,1L,5L,9L,5L,8L,7L,8L,9L,4L,2L,1L,0L,7L,7L,7L,2L,4L,1L,5L,1L,1L,8L,3L,4L,1L,3L,0L,7L,2L,2L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195381Inst : IEnumerable<long>
{
public static readonly long[] Value=A195381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195381.Bytes);
public long this[int i]=>Value[i];

public static A195381Inst Instance=new A195381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195382
{
public static readonly long[] Value={ 4L,8L,16L,18L,32L,50L,256L,512L,578L,1458L,2048L,3362L,4802L,6962L,8192L,10082L,15842L,20402L,31250L,34322L,55778L,57122L,59858L,167042L,171698L,293378L,524288L,559682L,916658L,982802L,1062882L,1104098L,1158242L,1195058L,1367858L,1407842L,1414562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195382Inst : IEnumerable<long>
{
public static readonly long[] Value=A195382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195382.Bytes);
public long this[int i]=>Value[i];

public static A195382Inst Instance=new A195382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195383
{
public static readonly long[] Value={ 1L,3L,5L,4L,0L,4L,4L,6L,2L,7L,7L,7L,2L,8L,4L,5L,8L,7L,1L,2L,8L,3L,3L,4L,4L,5L,0L,9L,1L,0L,4L,2L,8L,7L,1L,2L,4L,0L,6L,0L,4L,5L,8L,0L,9L,0L,6L,6L,0L,7L,0L,3L,6L,1L,9L,9L,7L,8L,9L,0L,3L,6L,6L,7L,7L,8L,5L,9L,7L,3L,8L,2L,3L,2L,1L,1L,8L,6L,9L,5L,5L,8L,9L,3L,8L,1L,4L,2L,5L,6L,0L,7L,7L,6L,8L,9L,8L,9L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195383Inst : IEnumerable<long>
{
public static readonly long[] Value=A195383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195383.Bytes);
public long this[int i]=>Value[i];

public static A195383Inst Instance=new A195383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195384
{
public static readonly long[] Value={ 1L,7L,4L,8L,0L,6L,4L,0L,9L,7L,7L,9L,5L,2L,8L,4L,2L,8L,3L,1L,9L,7L,2L,0L,4L,8L,2L,0L,2L,2L,3L,0L,2L,0L,4L,5L,5L,1L,4L,9L,8L,8L,3L,2L,6L,3L,9L,4L,8L,2L,6L,8L,7L,5L,3L,6L,8L,0L,8L,2L,5L,1L,1L,4L,8L,0L,1L,8L,6L,1L,9L,6L,0L,1L,7L,7L,1L,3L,1L,1L,8L,2L,4L,9L,3L,8L,6L,0L,5L,7L,4L,0L,5L,1L,6L,5L,8L,7L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195384Inst : IEnumerable<long>
{
public static readonly long[] Value=A195384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195384.Bytes);
public long this[int i]=>Value[i];

public static A195384Inst Instance=new A195384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195385
{
public static readonly long[] Value={ 6L,1L,1L,5L,5L,8L,3L,5L,1L,2L,7L,9L,6L,6L,4L,1L,3L,0L,6L,5L,6L,7L,7L,9L,3L,2L,2L,4L,2L,8L,8L,4L,4L,3L,2L,7L,0L,7L,7L,7L,0L,6L,7L,2L,5L,0L,0L,1L,8L,5L,3L,0L,9L,3L,1L,9L,2L,6L,0L,2L,3L,8L,0L,2L,9L,1L,7L,4L,6L,7L,0L,8L,6L,0L,9L,1L,9L,8L,1L,4L,4L,8L,1L,2L,6L,1L,1L,2L,9L,5L,1L,3L,1L,2L,6L,9L,9L,1L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195385Inst : IEnumerable<long>
{
public static readonly long[] Value=A195385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195385.Bytes);
public long this[int i]=>Value[i];

public static A195385Inst Instance=new A195385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195386
{
public static readonly long[] Value={ 1L,0L,4L,5L,8L,3L,1L,3L,7L,9L,9L,7L,9L,9L,5L,5L,8L,7L,4L,9L,4L,8L,7L,2L,0L,5L,7L,5L,7L,0L,3L,4L,1L,1L,6L,8L,1L,4L,2L,4L,8L,5L,2L,0L,4L,7L,4L,4L,8L,0L,2L,4L,4L,0L,9L,4L,4L,5L,3L,8L,9L,4L,5L,8L,9L,0L,4L,0L,7L,2L,1L,2L,7L,2L,0L,5L,8L,6L,7L,2L,9L,0L,3L,5L,6L,3L,1L,8L,0L,3L,1L,7L,9L,4L,4L,5L,7L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195386Inst : IEnumerable<long>
{
public static readonly long[] Value=A195386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195386.Bytes);
public long this[int i]=>Value[i];

public static A195386Inst Instance=new A195386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195387
{
public static readonly long[] Value={ 1L,1L,4L,6L,8L,0L,9L,7L,5L,9L,1L,5L,8L,1L,9L,1L,6L,3L,0L,9L,5L,3L,7L,7L,6L,0L,0L,6L,5L,1L,9L,6L,8L,1L,6L,0L,7L,5L,5L,6L,7L,6L,8L,2L,9L,7L,3L,5L,9L,7L,5L,1L,3L,7L,2L,7L,2L,9L,8L,2L,4L,8L,5L,3L,3L,1L,7L,8L,9L,4L,6L,4L,4L,3L,9L,9L,1L,8L,6L,0L,9L,3L,6L,7L,6L,2L,0L,5L,1L,5L,2L,1L,5L,4L,4L,9L,5L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195387Inst : IEnumerable<long>
{
public static readonly long[] Value=A195387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195387.Bytes);
public long this[int i]=>Value[i];

public static A195387Inst Instance=new A195387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195388
{
public static readonly long[] Value={ 1L,4L,2L,0L,6L,2L,0L,2L,7L,3L,3L,9L,4L,4L,3L,7L,9L,4L,6L,4L,1L,5L,1L,4L,4L,8L,1L,2L,1L,1L,6L,1L,6L,9L,2L,3L,1L,9L,6L,3L,5L,3L,5L,3L,3L,1L,5L,4L,6L,4L,8L,9L,8L,8L,0L,5L,5L,3L,7L,5L,9L,3L,8L,5L,4L,7L,2L,5L,5L,9L,2L,8L,2L,3L,3L,2L,2L,9L,9L,1L,9L,3L,3L,6L,7L,4L,3L,8L,2L,1L,3L,1L,8L,4L,9L,2L,0L,7L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195388Inst : IEnumerable<long>
{
public static readonly long[] Value=A195388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195388.Bytes);
public long this[int i]=>Value[i];

public static A195388Inst Instance=new A195388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195389
{
public static readonly long[] Value={ 5L,7L,3L,8L,9L,4L,9L,4L,2L,7L,4L,8L,6L,8L,2L,3L,0L,6L,8L,5L,9L,4L,1L,0L,2L,1L,1L,4L,2L,6L,4L,4L,0L,2L,2L,8L,6L,9L,3L,9L,8L,0L,8L,1L,9L,5L,3L,5L,4L,9L,9L,1L,1L,5L,0L,5L,7L,5L,2L,0L,9L,5L,2L,0L,9L,2L,4L,5L,4L,7L,0L,8L,0L,9L,5L,1L,8L,9L,1L,7L,5L,0L,5L,0L,8L,1L,2L,7L,6L,3L,1L,2L,8L,9L,1L,0L,5L,0L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195389Inst : IEnumerable<long>
{
public static readonly long[] Value=A195389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195389.Bytes);
public long this[int i]=>Value[i];

public static A195389Inst Instance=new A195389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195390
{
public static readonly BigInteger[] Value={ 1L,720L,479001600L,6402373705728000L,BigInteger.Parse("620448401733239439360000"),BigInteger.Parse("265252859812191058636308480000000"),BigInteger.Parse("371993326789901217467999448150835200000000"),BigInteger.Parse("1405006117752879898543142606244511569936384000000000"),BigInteger.Parse("12413915592536072670862289047373375038521486354677760000000000") };
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
public class A195390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195390Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195390.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195390.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195390Inst Instance=new A195390Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195391
{
public static readonly BigInteger[] Value={ 1L,5040L,87178291200L,BigInteger.Parse("51090942171709440000"),BigInteger.Parse("304888344611713860501504000000"),BigInteger.Parse("10333147966386144929666651337523200000000"),BigInteger.Parse("1405006117752879898543142606244511569936384000000000") };
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
public class A195391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195391Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195391.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195391.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195391Inst Instance=new A195391Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195392
{
public static readonly BigInteger[] Value={ 1L,40320L,20922789888000L,BigInteger.Parse("620448401733239439360000"),BigInteger.Parse("263130836933693530167218012160000000"),BigInteger.Parse("815915283247897734345611269596115894272000000000"),BigInteger.Parse("12413915592536072670862289047373375038521486354677760000000000") };
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
public class A195392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195392Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195392.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195392.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195392Inst Instance=new A195392Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195393
{
public static readonly BigInteger[] Value={ 1L,362880L,6402373705728000L,BigInteger.Parse("10888869450418352160768000000"),BigInteger.Parse("371993326789901217467999448150835200000000"),BigInteger.Parse("119622220865480194561963161495657715064383733760000000000") };
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
public class A195393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195393Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195393.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195393.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195393Inst Instance=new A195393Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195394
{
public static readonly BigInteger[] Value={ 1L,3628800L,2432902008176640000L,BigInteger.Parse("265252859812191058636308480000000"),BigInteger.Parse("815915283247897734345611269596115894272000000000"),BigInteger.Parse("30414093201713378043612608166064768844377641568960512000000000000") };
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
public class A195394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195394Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195394.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195394.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195394Inst Instance=new A195394Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195395
{
public static readonly long[] Value={ 1L,2L,0L,4L,4L,9L,9L,9L,5L,2L,4L,3L,8L,3L,0L,0L,4L,2L,2L,9L,6L,2L,6L,7L,7L,2L,0L,4L,9L,5L,5L,8L,8L,0L,4L,2L,5L,3L,7L,2L,4L,9L,9L,8L,3L,8L,1L,4L,3L,2L,7L,9L,8L,3L,2L,8L,9L,2L,3L,7L,3L,3L,6L,2L,4L,6L,2L,0L,5L,8L,0L,7L,9L,0L,1L,7L,0L,6L,1L,9L,5L,8L,9L,3L,3L,1L,3L,9L,8L,9L,3L,0L,0L,9L,4L,1L,9L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195395Inst : IEnumerable<long>
{
public static readonly long[] Value=A195395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195395.Bytes);
public long this[int i]=>Value[i];

public static A195395Inst Instance=new A195395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195396
{
public static readonly long[] Value={ 1L,2L,6L,9L,3L,1L,5L,7L,9L,8L,8L,6L,2L,5L,6L,0L,6L,6L,9L,2L,8L,7L,2L,7L,6L,7L,3L,2L,7L,3L,8L,9L,4L,5L,3L,9L,8L,4L,5L,1L,4L,1L,2L,8L,2L,1L,3L,5L,8L,1L,0L,2L,7L,4L,6L,3L,2L,9L,7L,6L,8L,8L,0L,1L,3L,5L,3L,3L,3L,4L,3L,2L,3L,8L,8L,1L,6L,1L,5L,3L,8L,4L,7L,1L,0L,3L,8L,3L,9L,2L,5L,9L,5L,2L,6L,3L,5L,2L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195396Inst : IEnumerable<long>
{
public static readonly long[] Value=A195396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195396.Bytes);
public long this[int i]=>Value[i];

public static A195396Inst Instance=new A195396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195397
{
public static readonly long[] Value={ 1L,6L,1L,1L,7L,6L,7L,4L,0L,2L,9L,5L,1L,5L,5L,7L,4L,3L,0L,1L,9L,6L,1L,7L,7L,6L,1L,9L,1L,3L,8L,6L,0L,9L,9L,2L,5L,6L,8L,5L,5L,0L,2L,6L,1L,9L,9L,8L,1L,8L,8L,6L,9L,5L,5L,2L,9L,0L,1L,9L,7L,4L,2L,0L,0L,4L,3L,5L,5L,4L,8L,1L,6L,0L,9L,6L,5L,5L,3L,2L,4L,7L,8L,8L,4L,1L,0L,7L,5L,4L,1L,4L,8L,3L,9L,4L,0L,5L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195397Inst : IEnumerable<long>
{
public static readonly long[] Value=A195397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195397.Bytes);
public long this[int i]=>Value[i];

public static A195397Inst Instance=new A195397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195398
{
public static readonly long[] Value={ 6L,0L,1L,1L,2L,6L,3L,9L,6L,9L,1L,7L,6L,5L,3L,2L,5L,1L,6L,5L,4L,1L,2L,6L,3L,7L,8L,7L,7L,7L,2L,6L,1L,0L,8L,0L,6L,6L,8L,6L,4L,0L,3L,9L,9L,9L,2L,3L,8L,7L,2L,4L,8L,9L,7L,2L,4L,2L,0L,2L,9L,3L,6L,6L,1L,0L,0L,0L,5L,1L,7L,6L,6L,5L,0L,8L,6L,4L,9L,9L,1L,2L,4L,1L,5L,6L,1L,6L,4L,8L,7L,5L,9L,2L,4L,6L,1L,9L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195398Inst : IEnumerable<long>
{
public static readonly long[] Value=A195398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195398.Bytes);
public long this[int i]=>Value[i];

public static A195398Inst Instance=new A195398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195399
{
public static readonly long[] Value={ 1L,7L,5L,9L,3L,8L,2L,1L,5L,7L,0L,9L,6L,4L,9L,2L,5L,5L,8L,8L,6L,5L,1L,6L,3L,5L,2L,4L,9L,0L,0L,3L,8L,2L,0L,7L,0L,9L,2L,3L,3L,3L,8L,0L,9L,1L,3L,8L,8L,5L,4L,5L,5L,9L,0L,2L,6L,6L,5L,7L,5L,0L,5L,6L,7L,4L,7L,1L,6L,9L,1L,9L,7L,9L,7L,9L,3L,7L,4L,3L,5L,5L,4L,2L,1L,6L,8L,6L,5L,2L,7L,1L,7L,1L,1L,7L,4L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195399Inst : IEnumerable<long>
{
public static readonly long[] Value=A195399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195399.Bytes);
public long this[int i]=>Value[i];

public static A195399Inst Instance=new A195399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195400
{
public static readonly long[] Value={ 1L,8L,0L,5L,6L,6L,4L,9L,1L,8L,5L,8L,0L,5L,4L,5L,8L,7L,9L,3L,3L,1L,1L,7L,8L,9L,9L,5L,1L,4L,7L,6L,5L,2L,7L,6L,5L,7L,1L,9L,6L,5L,4L,4L,2L,2L,5L,5L,6L,7L,3L,3L,0L,9L,2L,8L,4L,2L,2L,2L,0L,7L,2L,1L,0L,6L,5L,2L,4L,1L,5L,6L,9L,0L,2L,6L,2L,8L,8L,4L,9L,6L,3L,1L,9L,4L,7L,6L,1L,5L,1L,3L,6L,7L,2L,7L,5L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195400Inst : IEnumerable<long>
{
public static readonly long[] Value=A195400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195400.Bytes);
public long this[int i]=>Value[i];

public static A195400Inst Instance=new A195400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195401
{
public static readonly long[] Value={ 2L,3L,2L,7L,4L,4L,3L,8L,2L,4L,4L,0L,0L,8L,4L,6L,3L,3L,6L,7L,8L,2L,0L,6L,0L,0L,0L,8L,1L,0L,6L,8L,5L,1L,2L,2L,3L,1L,8L,6L,3L,4L,7L,9L,3L,2L,4L,0L,1L,7L,7L,8L,8L,7L,3L,1L,2L,7L,0L,6L,5L,7L,2L,9L,3L,2L,9L,3L,0L,2L,6L,7L,7L,8L,4L,4L,8L,3L,1L,9L,8L,9L,1L,2L,6L,4L,2L,2L,3L,6L,0L,8L,6L,6L,7L,3L,7L,9L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195401Inst : IEnumerable<long>
{
public static readonly long[] Value=A195401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195401.Bytes);
public long this[int i]=>Value[i];

public static A195401Inst Instance=new A195401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195402
{
public static readonly long[] Value={ 6L,1L,0L,8L,8L,9L,7L,8L,0L,3L,8L,6L,3L,8L,0L,0L,0L,7L,4L,4L,2L,4L,1L,2L,8L,8L,8L,6L,7L,4L,0L,4L,2L,2L,3L,3L,0L,2L,5L,7L,0L,5L,2L,7L,6L,9L,0L,4L,5L,9L,2L,0L,9L,4L,1L,1L,5L,0L,6L,5L,9L,3L,5L,1L,6L,6L,1L,7L,2L,9L,2L,4L,7L,9L,6L,2L,1L,7L,7L,0L,5L,9L,3L,1L,4L,8L,2L,1L,9L,7L,9L,6L,3L,6L,3L,8L,7L,7L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195402Inst : IEnumerable<long>
{
public static readonly long[] Value=A195402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195402.Bytes);
public long this[int i]=>Value[i];

public static A195402Inst Instance=new A195402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195403
{
public static readonly long[] Value={ 6L,9L,2L,0L,2L,8L,6L,7L,8L,4L,7L,1L,6L,5L,1L,7L,6L,7L,9L,0L,4L,3L,2L,8L,7L,4L,5L,2L,5L,6L,2L,9L,3L,2L,5L,2L,0L,0L,9L,4L,0L,2L,2L,7L,5L,9L,3L,1L,3L,3L,3L,2L,2L,7L,0L,3L,7L,6L,1L,6L,4L,8L,0L,3L,3L,1L,9L,2L,5L,7L,7L,4L,5L,6L,5L,6L,6L,8L,8L,7L,5L,7L,5L,3L,6L,4L,5L,9L,7L,8L,4L,0L,1L,8L,6L,1L,7L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195403Inst : IEnumerable<long>
{
public static readonly long[] Value=A195403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195403.Bytes);
public long this[int i]=>Value[i];

public static A195403Inst Instance=new A195403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195404
{
public static readonly long[] Value={ 7L,2L,7L,0L,9L,2L,0L,6L,2L,9L,2L,8L,0L,7L,0L,1L,2L,0L,5L,2L,4L,5L,5L,7L,2L,3L,6L,3L,8L,0L,5L,8L,0L,9L,4L,1L,6L,2L,4L,2L,4L,2L,5L,2L,1L,7L,4L,5L,8L,0L,8L,3L,2L,5L,7L,3L,6L,5L,7L,5L,7L,6L,7L,7L,6L,9L,1L,4L,1L,5L,2L,5L,3L,8L,2L,8L,6L,6L,1L,4L,9L,5L,9L,7L,1L,7L,4L,1L,8L,1L,0L,0L,0L,1L,3L,4L,3L,4L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195404Inst : IEnumerable<long>
{
public static readonly long[] Value=A195404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195404.Bytes);
public long this[int i]=>Value[i];

public static A195404Inst Instance=new A195404Inst();

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