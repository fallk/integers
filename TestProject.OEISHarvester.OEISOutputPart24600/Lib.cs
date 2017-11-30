using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A035713
{
public static readonly long[] Value={ 1L,36L,648L,7788L,70416L,511668L,3116952L,16395516L,76117536L,317222212L,1202893992L,4196289420L,13591279920L,41188096980L,117561917880L,317844953628L,818017823808L,2012724468324L,4752575891144L,10805739370668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035713Inst : IEnumerable<long>
{
public static readonly long[] Value=A035713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035713.Bytes);
public long this[int i]=>Value[i];

public static A035713Inst Instance=new A035713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035712
{
public static readonly long[] Value={ 1L,34L,578L,6562L,56066L,385186L,2220098L,11058466L,48663554L,192441122L,693230658L,2300164770L,7094825730L,20501991330L,55871829570L,144411206178L,355761664002L,838944980514L,1900906442306L,4152257037218L,8769652761346L,17955289409186L,35721495233602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035712Inst : IEnumerable<long>
{
public static readonly long[] Value=A035712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035712.Bytes);
public long this[int i]=>Value[i];

public static A035712Inst Instance=new A035712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035711
{
public static readonly long[] Value={ 1L,32L,512L,5472L,44032L,285088L,1549824L,7288544L,30316544L,113461024L,387328512L,1219605600L,3575055360L,9832110240L,25537728000L,63001648608L,148348809216L,334834507296L,727126954496L,1524223640416L,3093172083712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035711Inst : IEnumerable<long>
{
public static readonly long[] Value=A035711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035711.Bytes);
public long this[int i]=>Value[i];

public static A035711Inst Instance=new A035711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035710
{
public static readonly long[] Value={ 1L,30L,450L,4510L,34050L,207006L,1057730L,4680990L,18347010L,64797470L,209070018L,623207070L,1732242690L,4524812190L,11180805570L,26283115038L,59064045570L,127421652510L,264870794690L,532225891230L,1036722552066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035710Inst : IEnumerable<long>
{
public static readonly long[] Value=A035710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035710.Bytes);
public long this[int i]=>Value[i];

public static A035710Inst Instance=new A035710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035709
{
public static readonly long[] Value={ 1L,28L,392L,3668L,25872L,147084L,703640L,2919620L,10746400L,35704060L,108568488L,305568564L,803467056L,1989102444L,4666890936L,10435418532L,22345512000L,46012094940L,91437047240L,175918049300L,328578611536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035709Inst : IEnumerable<long>
{
public static readonly long[] Value=A035709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035709.Bytes);
public long this[int i]=>Value[i];

public static A035709Inst Instance=new A035709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035692
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,2L,2L,0L,2L,3L,0L,4L,3L,3L,4L,4L,4L,6L,4L,8L,6L,9L,9L,8L,11L,13L,8L,19L,14L,15L,21L,18L,19L,30L,19L,32L,32L,29L,38L,41L,36L,53L,43L,56L,59L,59L,67L,75L,70L,93L,81L,102L,105L,105L,122L,133L,123L,165L,145L,170L,189L,183L,203L,237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035692Inst : IEnumerable<long>
{
public static readonly long[] Value=A035692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035692.Bytes);
public long this[int i]=>Value[i];

public static A035692Inst Instance=new A035692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035691
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,3L,1L,1L,3L,1L,3L,3L,2L,6L,3L,4L,7L,4L,8L,7L,6L,13L,8L,10L,15L,10L,17L,17L,14L,24L,19L,22L,30L,23L,33L,34L,31L,46L,39L,44L,56L,47L,63L,65L,61L,82L,75L,84L,101L,90L,113L,118L,115L,145L,137L,151L,176L,165L,197L,207L,206L,246L,242L,264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035691Inst : IEnumerable<long>
{
public static readonly long[] Value=A035691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035691.Bytes);
public long this[int i]=>Value[i];

public static A035691Inst Instance=new A035691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035690
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,3L,1L,1L,3L,4L,1L,3L,4L,7L,3L,4L,8L,10L,4L,8L,11L,15L,8L,11L,18L,21L,11L,19L,24L,30L,19L,25L,37L,42L,25L,40L,50L,56L,41L,53L,70L,79L,54L,77L,95L,103L,80L,103L,129L,141L,106L,144L,172L,183L,151L,189L,228L,246L,197L,257L,301L,314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035690Inst : IEnumerable<long>
{
public static readonly long[] Value=A035690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035690.Bytes);
public long this[int i]=>Value[i];

public static A035690Inst Instance=new A035690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035689
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,3L,1L,3L,1L,3L,1L,4L,3L,7L,3L,8L,3L,8L,4L,10L,8L,14L,9L,16L,9L,18L,11L,22L,17L,28L,19L,32L,21L,36L,25L,44L,35L,52L,40L,60L,44L,68L,52L,82L,66L,95L,76L,108L,85L,123L,100L,145L,122L,166L,140L,188L,157L,214L,182L,250L,215L,283L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035689Inst : IEnumerable<long>
{
public static readonly long[] Value=A035689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035689.Bytes);
public long this[int i]=>Value[i];

public static A035689Inst Instance=new A035689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035688
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,2L,0L,4L,0L,4L,0L,5L,0L,7L,0L,10L,0L,12L,0L,14L,0L,18L,0L,24L,0L,28L,0L,33L,0L,41L,0L,50L,0L,59L,0L,70L,0L,84L,0L,100L,0L,117L,0L,137L,0L,161L,0L,188L,0L,219L,0L,254L,0L,295L,0L,341L,0L,393L,0L,453L,0L,520L,0L,595L,0L,682L,0L,780L,0L,889L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035688Inst : IEnumerable<long>
{
public static readonly long[] Value=A035688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035688.Bytes);
public long this[int i]=>Value[i];

public static A035688Inst Instance=new A035688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035687
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,3L,1L,4L,1L,4L,3L,4L,4L,7L,4L,10L,4L,11L,8L,11L,11L,15L,12L,21L,12L,25L,18L,26L,24L,31L,28L,42L,29L,50L,38L,55L,50L,62L,58L,79L,63L,95L,76L,105L,96L,118L,113L,144L,123L,172L,145L,193L,178L,213L,208L,255L,230L,302L,262L,340L,316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035687Inst : IEnumerable<long>
{
public static readonly long[] Value=A035687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035687.Bytes);
public long this[int i]=>Value[i];

public static A035687Inst Instance=new A035687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035686
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,0L,2L,0L,2L,0L,5L,0L,5L,0L,8L,0L,8L,0L,14L,0L,15L,0L,22L,0L,23L,0L,34L,0L,37L,0L,51L,0L,54L,0L,74L,0L,81L,0L,107L,0L,116L,0L,150L,0L,165L,0L,210L,0L,229L,0L,287L,0L,316L,0L,392L,0L,430L,0L,526L,0L,580L,0L,704L,0L,774L,0L,929L,0L,1024L,0L,1223L,0L,1347L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035686Inst : IEnumerable<long>
{
public static readonly long[] Value=A035686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035686.Bytes);
public long this[int i]=>Value[i];

public static A035686Inst Instance=new A035686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035685
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,2L,1L,4L,2L,4L,4L,5L,4L,7L,5L,10L,7L,12L,11L,14L,13L,18L,15L,24L,19L,28L,27L,33L,31L,42L,36L,51L,45L,60L,58L,71L,68L,87L,79L,103L,96L,120L,118L,141L,137L,169L,159L,197L,189L,228L,226L,266L,262L,314L,302L,362L,355L,416L,416L,482L,478L,561L,550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035685Inst : IEnumerable<long>
{
public static readonly long[] Value=A035685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035685.Bytes);
public long this[int i]=>Value[i];

public static A035685Inst Instance=new A035685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035684
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,2L,4L,4L,4L,4L,4L,4L,5L,7L,10L,11L,11L,11L,11L,12L,14L,18L,23L,25L,26L,26L,27L,29L,33L,40L,47L,52L,54L,56L,58L,62L,70L,81L,93L,101L,107L,111L,116L,124L,137L,155L,172L,188L,199L,208L,218L,233L,255L,282L,311L,336L,357L,374L,393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035684Inst : IEnumerable<long>
{
public static readonly long[] Value=A035684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035684.Bytes);
public long this[int i]=>Value[i];

public static A035684Inst Instance=new A035684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035683
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,2L,2L,4L,4L,4L,4L,5L,5L,7L,7L,10L,11L,12L,12L,14L,14L,18L,19L,24L,26L,29L,29L,33L,34L,41L,43L,51L,55L,61L,63L,71L,73L,85L,90L,102L,110L,122L,126L,141L,146L,164L,174L,194L,207L,230L,239L,263L,275L,304L,322L,355L,377L,414L,433L,473L,495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035683Inst : IEnumerable<long>
{
public static readonly long[] Value=A035683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035683.Bytes);
public long this[int i]=>Value[i];

public static A035683Inst Instance=new A035683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035682
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,2L,2L,2L,4L,4L,5L,5L,5L,7L,7L,8L,11L,12L,14L,14L,15L,19L,20L,22L,26L,29L,34L,35L,37L,43L,46L,51L,57L,63L,72L,76L,81L,91L,98L,107L,117L,128L,144L,153L,163L,179L,192L,210L,226L,245L,272L,290L,310L,336L,360L,391L,418L,450L,494L,527L,564L,605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035682Inst : IEnumerable<long>
{
public static readonly long[] Value=A035682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035682.Bytes);
public long this[int i]=>Value[i];

public static A035682Inst Instance=new A035682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035681
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,1L,2L,2L,2L,2L,5L,5L,5L,5L,8L,8L,8L,8L,14L,15L,15L,15L,22L,23L,23L,23L,34L,37L,38L,38L,51L,54L,55L,55L,74L,81L,84L,85L,108L,116L,119L,120L,151L,165L,172L,175L,214L,230L,238L,241L,291L,317L,332L,339L,402L,434L,451L,459L,538L,584L,613L,628L,727L,784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035681Inst : IEnumerable<long>
{
public static readonly long[] Value=A035681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035681.Bytes);
public long this[int i]=>Value[i];

public static A035681Inst Instance=new A035681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035680
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,2L,2L,2L,3L,3L,5L,6L,6L,8L,9L,9L,11L,12L,15L,18L,19L,23L,26L,27L,31L,34L,39L,45L,49L,56L,62L,66L,74L,80L,89L,101L,109L,123L,136L,144L,160L,173L,187L,210L,227L,249L,275L,293L,319L,346L,371L,408L,442L,480L,525L,562L,608L,655L,701L,763L,822L,887L,963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035680Inst : IEnumerable<long>
{
public static readonly long[] Value=A035680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035680.Bytes);
public long this[int i]=>Value[i];

public static A035680Inst Instance=new A035680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035679
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,7L,7L,10L,10L,13L,13L,16L,16L,22L,23L,30L,31L,38L,39L,46L,47L,58L,61L,75L,78L,93L,96L,111L,114L,134L,141L,167L,176L,204L,213L,242L,251L,286L,301L,346L,365L,416L,436L,489L,509L,570L,599L,676L,714L,802L,844L,937L,980L,1083L,1138L,1265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035679Inst : IEnumerable<long>
{
public static readonly long[] Value=A035679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035679.Bytes);
public long this[int i]=>Value[i];

public static A035679Inst Instance=new A035679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035678
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,3L,0L,0L,0L,0L,0L,1L,3L,6L,0L,0L,0L,0L,1L,3L,7L,11L,0L,0L,0L,1L,3L,7L,14L,18L,0L,0L,1L,3L,7L,15L,25L,29L,0L,1L,3L,7L,15L,28L,43L,44L,1L,3L,7L,15L,29L,50L,69L,67L,3L,7L,15L,29L,53L,84L,110L,99L,7L,15L,29L,54L,91L,138L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035678Inst : IEnumerable<long>
{
public static readonly long[] Value=A035678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035678.Bytes);
public long this[int i]=>Value[i];

public static A035678Inst Instance=new A035678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035677
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,3L,0L,0L,0L,1L,0L,3L,0L,6L,0L,1L,0L,3L,0L,7L,0L,12L,0L,3L,0L,7L,0L,15L,0L,21L,0L,7L,0L,16L,0L,28L,0L,36L,0L,16L,0L,31L,0L,50L,0L,60L,0L,32L,0L,57L,0L,85L,0L,98L,0L,60L,0L,100L,0L,141L,0L,157L,0L,107L,0L,169L,0L,226L,0L,248L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035677Inst : IEnumerable<long>
{
public static readonly long[] Value=A035677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035677.Bytes);
public long this[int i]=>Value[i];

public static A035677Inst Instance=new A035677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035660
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,2L,2L,4L,4L,4L,5L,5L,7L,7L,10L,12L,12L,14L,14L,18L,20L,24L,28L,29L,33L,35L,41L,45L,51L,59L,63L,71L,75L,85L,94L,104L,118L,126L,140L,150L,166L,182L,198L,222L,239L,263L,282L,308L,337L,364L,403L,433L,473L,508L,550L,599L,643L,705L,758L,823L,884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035660Inst : IEnumerable<long>
{
public static readonly long[] Value=A035660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035660.Bytes);
public long this[int i]=>Value[i];

public static A035660Inst Instance=new A035660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035659
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,1L,2L,2L,2L,4L,5L,5L,5L,7L,8L,8L,11L,14L,15L,15L,19L,22L,23L,27L,33L,37L,38L,44L,50L,54L,60L,71L,79L,84L,94L,106L,114L,125L,143L,159L,169L,187L,208L,225L,242L,273L,302L,323L,351L,390L,421L,451L,498L,551L,590L,636L,697L,757L,807L,881L,965L,1039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035659Inst : IEnumerable<long>
{
public static readonly long[] Value=A035659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035659.Bytes);
public long this[int i]=>Value[i];

public static A035659Inst Instance=new A035659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035658
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,2L,2L,2L,3L,5L,5L,6L,8L,8L,9L,11L,14L,16L,18L,22L,24L,26L,30L,36L,40L,45L,53L,57L,62L,71L,80L,89L,100L,114L,124L,135L,151L,167L,184L,205L,229L,249L,271L,299L,327L,358L,395L,436L,474L,515L,564L,612L,666L,730L,798L,864L,937L,1019L,1100L,1192L,1298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035658Inst : IEnumerable<long>
{
public static readonly long[] Value=A035658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035658.Bytes);
public long this[int i]=>Value[i];

public static A035658Inst Instance=new A035658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035657
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,3L,3L,4L,6L,7L,9L,10L,12L,13L,15L,19L,22L,27L,30L,35L,38L,43L,50L,57L,67L,74L,85L,92L,103L,115L,130L,148L,165L,185L,202L,223L,246L,273L,306L,337L,376L,408L,449L,488L,539L,594L,654L,720L,784L,855L,928L,1013L,1109L,1210L,1326L,1436L,1563L,1685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035657Inst : IEnumerable<long>
{
public static readonly long[] Value=A035657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035657.Bytes);
public long this[int i]=>Value[i];

public static A035657Inst Instance=new A035657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035656
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,3L,0L,0L,0L,0L,1L,3L,6L,0L,0L,0L,1L,3L,7L,11L,0L,0L,1L,3L,7L,14L,18L,0L,1L,3L,7L,15L,25L,29L,1L,3L,7L,15L,28L,43L,45L,3L,7L,15L,29L,50L,70L,69L,7L,15L,29L,53L,85L,112L,103L,15L,29L,54L,92L,140L,172L,153L,29L,54L,95L,155L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035656Inst : IEnumerable<long>
{
public static readonly long[] Value=A035656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035656.Bytes);
public long this[int i]=>Value[i];

public static A035656Inst Instance=new A035656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035655
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,3L,0L,0L,1L,0L,3L,0L,6L,1L,0L,3L,0L,7L,1L,11L,3L,0L,7L,1L,14L,3L,18L,7L,1L,15L,3L,25L,7L,30L,15L,3L,28L,7L,44L,15L,47L,29L,7L,51L,15L,72L,29L,73L,54L,15L,87L,29L,116L,55L,111L,94L,29L,144L,55L,180L,97L,167L,159L,55L,230L,98L,276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035655Inst : IEnumerable<long>
{
public static readonly long[] Value=A035655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035655.Bytes);
public long this[int i]=>Value[i];

public static A035655Inst Instance=new A035655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035654
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,3L,1L,0L,0L,3L,1L,0L,6L,3L,1L,0L,7L,3L,1L,11L,7L,3L,1L,14L,7L,3L,19L,15L,7L,3L,26L,15L,7L,32L,29L,15L,7L,46L,30L,15L,51L,53L,30L,15L,76L,56L,30L,81L,91L,57L,30L,124L,98L,57L,126L,152L,101L,57L,195L,167L,102L,195L,245L,174L,102L,304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035654Inst : IEnumerable<long>
{
public static readonly long[] Value=A035654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035654.Bytes);
public long this[int i]=>Value[i];

public static A035654Inst Instance=new A035654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035653
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,3L,0L,1L,3L,0L,1L,3L,6L,1L,3L,7L,1L,3L,7L,12L,3L,7L,15L,3L,7L,16L,21L,7L,16L,28L,7L,16L,31L,36L,16L,32L,50L,16L,32L,57L,60L,32L,60L,85L,32L,61L,100L,98L,61L,107L,141L,61L,110L,169L,157L,111L,184L,226L,111L,191L,276L,249L,194L,305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035653Inst : IEnumerable<long>
{
public static readonly long[] Value=A035653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035653.Bytes);
public long this[int i]=>Value[i];

public static A035653Inst Instance=new A035653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035652
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,3L,1L,3L,1L,3L,1L,3L,7L,3L,8L,3L,8L,3L,8L,14L,8L,17L,8L,18L,8L,18L,26L,18L,33L,18L,36L,18L,37L,47L,37L,61L,37L,68L,37L,71L,81L,72L,106L,72L,121L,72L,128L,138L,131L,181L,132L,209L,132L,224L,228L,231L,297L,234L,347L,235L,376L,373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035652Inst : IEnumerable<long>
{
public static readonly long[] Value=A035652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035652.Bytes);
public long this[int i]=>Value[i];

public static A035652Inst Instance=new A035652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035651
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,4L,4L,4L,4L,4L,4L,4L,10L,11L,11L,11L,11L,11L,11L,22L,25L,26L,26L,26L,26L,26L,44L,51L,54L,55L,55L,55L,55L,84L,98L,105L,108L,109L,109L,109L,153L,178L,193L,200L,203L,204L,204L,270L,313L,341L,356L,363L,366L,367L,463L,532L,582L,611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035651Inst : IEnumerable<long>
{
public static readonly long[] Value=A035651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035651.Bytes);
public long this[int i]=>Value[i];

public static A035651Inst Instance=new A035651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035650
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,3L,0L,1L,3L,1L,3L,6L,1L,3L,8L,3L,7L,12L,3L,9L,16L,7L,15L,22L,9L,19L,30L,16L,29L,40L,20L,38L,54L,32L,54L,69L,41L,70L,93L,61L,95L,118L,78L,124L,156L,110L,163L,195L,141L,211L,255L,192L,271L,317L,245L,349L,409L,323L,441L,506L,412L,562L,644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035650Inst : IEnumerable<long>
{
public static readonly long[] Value=A035650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035650.Bytes);
public long this[int i]=>Value[i];

public static A035650Inst Instance=new A035650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035649
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,3L,1L,1L,3L,3L,1L,7L,3L,3L,8L,8L,3L,14L,9L,8L,16L,17L,9L,27L,19L,18L,32L,34L,20L,49L,40L,37L,58L,63L,43L,87L,74L,70L,104L,113L,82L,149L,135L,128L,177L,195L,152L,249L,232L,224L,298L,327L,266L,407L,392L,380L,485L,535L,455L,654L,639L,628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035649Inst : IEnumerable<long>
{
public static readonly long[] Value=A035649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035649.Bytes);
public long this[int i]=>Value[i];

public static A035649Inst Instance=new A035649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035648
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,3L,1L,3L,1L,4L,3L,7L,3L,8L,4L,10L,8L,14L,9L,17L,11L,22L,17L,28L,20L,34L,25L,43L,35L,53L,42L,64L,51L,80L,67L,96L,80L,115L,98L,142L,123L,168L,147L,200L,178L,244L,217L,286L,257L,339L,310L,407L,371L,475L,439L,559L,523L,664L,618L,772L,726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035648Inst : IEnumerable<long>
{
public static readonly long[] Value=A035648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035648.Bytes);
public long this[int i]=>Value[i];

public static A035648Inst Instance=new A035648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035647
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,0L,2L,0L,4L,0L,5L,0L,7L,0L,11L,0L,14L,0L,19L,0L,26L,0L,33L,0L,43L,0L,55L,0L,70L,0L,88L,0L,111L,0L,137L,0L,170L,0L,208L,0L,256L,0L,311L,0L,378L,0L,456L,0L,551L,0L,658L,0L,790L,0L,940L,0L,1119L,0L,1325L,0L,1570L,0L,1847L,0L,2179L,0L,2554L,0L,2996L,0L,3499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035647Inst : IEnumerable<long>
{
public static readonly long[] Value=A035647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035647.Bytes);
public long this[int i]=>Value[i];

public static A035647Inst Instance=new A035647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035646
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,4L,1L,4L,4L,4L,4L,10L,4L,11L,11L,11L,12L,22L,12L,25L,25L,26L,28L,45L,29L,52L,52L,55L,60L,87L,63L,101L,102L,108L,118L,160L,126L,187L,189L,202L,221L,285L,238L,333L,338L,363L,395L,492L,430L,574L,585L,629L,684L,828L,749L,964L,987L,1061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035646Inst : IEnumerable<long>
{
public static readonly long[] Value=A035646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035646.Bytes);
public long this[int i]=>Value[i];

public static A035646Inst Instance=new A035646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035645
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,2L,4L,4L,4L,4L,5L,7L,10L,11L,11L,12L,14L,18L,23L,25L,27L,29L,33L,40L,47L,53L,57L,62L,70L,81L,94L,104L,113L,123L,137L,156L,175L,194L,211L,230L,255L,285L,317L,348L,379L,413L,454L,502L,552L,604L,657L,715L,782L,857L,937L,1021L,1109L,1203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035645Inst : IEnumerable<long>
{
public static readonly long[] Value=A035645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035645.Bytes);
public long this[int i]=>Value[i];

public static A035645Inst Instance=new A035645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035628
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,3L,1L,3L,1L,3L,7L,3L,8L,3L,8L,14L,8L,17L,8L,18L,26L,18L,33L,18L,36L,47L,37L,61L,37L,68L,81L,71L,106L,72L,121L,138L,128L,181L,131L,209L,228L,224L,297L,231L,347L,372L,376L,482L,391L,566L,592L,619L,760L,648L,898L,934L,989L,1188L,1043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035628Inst : IEnumerable<long>
{
public static readonly long[] Value=A035628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035628.Bytes);
public long this[int i]=>Value[i];

public static A035628Inst Instance=new A035628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035627
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,4L,4L,4L,4L,4L,10L,11L,11L,11L,11L,22L,25L,26L,26L,26L,44L,51L,54L,55L,55L,84L,98L,105L,108L,109L,153L,178L,193L,200L,203L,270L,313L,341L,356L,363L,462L,532L,582L,611L,626L,771L,883L,968L,1021L,1050L,1259L,1431L,1571L,1663L,1717L,2017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035627Inst : IEnumerable<long>
{
public static readonly long[] Value=A035627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035627.Bytes);
public long this[int i]=>Value[i];

public static A035627Inst Instance=new A035627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035626
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,1L,3L,1L,4L,3L,7L,4L,10L,8L,15L,11L,21L,18L,30L,24L,42L,37L,56L,50L,78L,70L,102L,95L,137L,129L,179L,171L,236L,227L,303L,297L,395L,386L,502L,501L,643L,641L,814L,820L,1030L,1041L,1291L,1317L,1622L,1652L,2018L,2075L,2509L,2582L,3107L,3212L,3834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035626Inst : IEnumerable<long>
{
public static readonly long[] Value=A035626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035626.Bytes);
public long this[int i]=>Value[i];

public static A035626Inst Instance=new A035626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035625
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,2L,4L,4L,5L,7L,10L,12L,14L,18L,24L,28L,33L,41L,50L,59L,70L,84L,100L,117L,137L,161L,188L,219L,254L,295L,341L,393L,453L,520L,595L,682L,780L,889L,1011L,1150L,1307L,1481L,1673L,1893L,2140L,2411L,2713L,3053L,3433L,3851L,4313L,4833L,5411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035625Inst : IEnumerable<long>
{
public static readonly long[] Value=A035625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035625.Bytes);
public long this[int i]=>Value[i];

public static A035625Inst Instance=new A035625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035624
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,5L,5L,8L,8L,14L,15L,22L,23L,34L,37L,51L,54L,74L,81L,107L,116L,150L,165L,210L,229L,287L,316L,392L,430L,526L,580L,704L,774L,929L,1024L,1223L,1347L,1593L,1756L,2068L,2278L,2663L,2933L,3416L,3762L,4355L,4793L,5529L,6084L,6985L,7680L,8789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035624Inst : IEnumerable<long>
{
public static readonly long[] Value=A035624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035624.Bytes);
public long this[int i]=>Value[i];

public static A035624Inst Instance=new A035624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035623
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,3L,0L,1L,3L,6L,1L,3L,7L,12L,3L,7L,15L,21L,7L,16L,28L,36L,16L,31L,50L,60L,32L,57L,85L,98L,60L,100L,141L,157L,107L,169L,226L,248L,184L,276L,358L,385L,305L,442L,553L,591L,495L,691L,845L,896L,782L,1063L,1270L,1343L,1216L,1608L,1890L,1993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035623Inst : IEnumerable<long>
{
public static readonly long[] Value=A035623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035623.Bytes);
public long this[int i]=>Value[i];

public static A035623Inst Instance=new A035623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035622
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,4L,0L,4L,0L,10L,0L,11L,0L,22L,0L,25L,0L,44L,0L,51L,0L,83L,0L,98L,0L,149L,0L,177L,0L,259L,0L,309L,0L,436L,0L,521L,0L,716L,0L,857L,0L,1151L,0L,1376L,0L,1816L,0L,2170L,0L,2818L,0L,3361L,0L,4309L,0L,5132L,0L,6502L,0L,7728L,0L,9695L,0L,11501L,0L,14298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035622Inst : IEnumerable<long>
{
public static readonly long[] Value=A035622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035622.Bytes);
public long this[int i]=>Value[i];

public static A035622Inst Instance=new A035622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035621
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,1L,4L,4L,4L,4L,10L,11L,11L,11L,22L,25L,26L,26L,44L,51L,54L,55L,84L,98L,105L,108L,153L,178L,193L,200L,269L,313L,341L,356L,459L,531L,582L,611L,764L,880L,967L,1021L,1244L,1424L,1568L,1662L,1988L,2264L,2494L,2653L,3122L,3536L,3896L,4155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035621Inst : IEnumerable<long>
{
public static readonly long[] Value=A035621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035621.Bytes);
public long this[int i]=>Value[i];

public static A035621Inst Instance=new A035621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035620
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,4L,5L,7L,11L,14L,19L,26L,33L,43L,55L,70L,88L,111L,137L,170L,208L,256L,311L,378L,456L,551L,658L,790L,940L,1119L,1325L,1570L,1847L,2179L,2554L,2996L,3499L,4088L,4753L,5533L,6414L,7436L,8593L,9931L,11439L,13180L,15140L,17391L,19926L,22827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035620Inst : IEnumerable<long>
{
public static readonly long[] Value=A035620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035620.Bytes);
public long this[int i]=>Value[i];

public static A035620Inst Instance=new A035620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035619
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,3L,1L,3L,7L,3L,8L,14L,8L,17L,26L,18L,33L,47L,36L,61L,81L,68L,106L,137L,121L,181L,224L,209L,296L,362L,347L,478L,570L,565L,750L,890L,894L,1166L,1360L,1396L,1774L,2062L,2134L,2677L,3076L,3228L,3973L,4555L,4804L,5854L,6657L,7085L,8513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035619Inst : IEnumerable<long>
{
public static readonly long[] Value=A035619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035619.Bytes);
public long this[int i]=>Value[i];

public static A035619Inst Instance=new A035619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035618
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,4L,4L,4L,10L,11L,11L,22L,25L,26L,44L,51L,54L,84L,98L,105L,152L,178L,193L,266L,312L,341L,452L,528L,581L,749L,873L,964L,1214L,1409L,1561L,1930L,2234L,2479L,3018L,3478L,3866L,4647L,5339L,5937L,7061L,8081L,8991L,10594L,12089L,13447L,15721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035618Inst : IEnumerable<long>
{
public static readonly long[] Value=A035618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035618.Bytes);
public long this[int i]=>Value[i];

public static A035618Inst Instance=new A035618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035617
{
public static readonly long[] Value={ 1L,0L,3L,3L,15L,33L,105L,297L,879L,2631L,7833L,23697L,71385L,216765L,657849L,2003151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035617Inst : IEnumerable<long>
{
public static readonly long[] Value=A035617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035617.Bytes);
public long this[int i]=>Value[i];

public static A035617Inst Instance=new A035617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035616
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,-18L,-10L,0L,0L,0L,135L,-7380L,40L,0L,0L,-540L,-135540L,-56160L,-80L,0L,1215L,-336420L,538380L,-43920L,80L,-1458L,-102060L,-98280L,-20520L,-1440L,697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035616Inst : IEnumerable<long>
{
public static readonly long[] Value=A035616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035616.Bytes);
public long this[int i]=>Value[i];

public static A035616Inst Instance=new A035616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035615
{
public static readonly long[] Value={ 1L,0L,2L,2L,6L,12L,26L,58L,126L,278L,602L,1300L,2774L,5878L,12350L,25778L,53470L,110332L,226610L,463602L,945214L,1921550L,3896642L,7885092L,15927086L,32121582L,64697726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035615Inst : IEnumerable<long>
{
public static readonly long[] Value=A035615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035615.Bytes);
public long this[int i]=>Value[i];

public static A035615Inst Instance=new A035615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035614
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,0L,1L,4L,0L,1L,2L,0L,5L,0L,1L,2L,0L,3L,0L,1L,6L,0L,1L,2L,0L,3L,0L,1L,4L,0L,1L,2L,0L,7L,0L,1L,2L,0L,3L,0L,1L,4L,0L,1L,2L,0L,5L,0L,1L,2L,0L,3L,0L,1L,8L,0L,1L,2L,0L,3L,0L,1L,4L,0L,1L,2L,0L,5L,0L,1L,2L,0L,3L,0L,1L,6L,0L,1L,2L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035614Inst : IEnumerable<long>
{
public static readonly long[] Value=A035614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035614.Bytes);
public long this[int i]=>Value[i];

public static A035614Inst Instance=new A035614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035613
{
public static readonly long[] Value={ 1111111L,111L,21L,13L,12L,11L,10L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035613Inst : IEnumerable<long>
{
public static readonly long[] Value=A035613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035613.Bytes);
public long this[int i]=>Value[i];

public static A035613Inst Instance=new A035613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035596
{
public static readonly long[] Value={ 1L,0L,512L,0L,47872L,92160L,2671104L,9246720L,88632832L,300627968L,1708766720L,5099440128L,21224886528L,55690063872L,187789235712L,440993452032L,1275935628288L,2731242852352L,7030806944256L,13931439616000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035596Inst : IEnumerable<long>
{
public static readonly long[] Value=A035596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035596.Bytes);
public long this[int i]=>Value[i];

public static A035596Inst Instance=new A035596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035595
{
public static readonly long[] Value={ 0L,1L,1L,5L,6L,17L,22L,50L,66L,130L,174L,314L,421L,711L,953L,1535L,2051L,3179L,4232L,6365L,8434L,12369L,16313L,23431L,30750L,43381L,56658L,78712L,102309L,140226L,181418L,245723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035595Inst : IEnumerable<long>
{
public static readonly long[] Value=A035595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035595.Bytes);
public long this[int i]=>Value[i];

public static A035595Inst Instance=new A035595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035594
{
public static readonly long[] Value={ 1L,3L,4L,10L,13L,28L,37L,72L,96L,172L,230L,391L,522L,846L,1129L,1766L,2348L,3564L,4722L,6992L,9226L,13371L,17568L,25006L,32708L,45817L,59668L,82430L,106874L,145830L,188260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035594Inst : IEnumerable<long>
{
public static readonly long[] Value=A035594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035594.Bytes);
public long this[int i]=>Value[i];

public static A035594Inst Instance=new A035594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035593
{
public static readonly long[] Value={ 1L,4L,11L,27L,59L,123L,241L,458L,838L,1498L,2608L,4459L,7473L,12339L,20058L,32197L,51027L,80003L,124092L,190683L,290322L,438392L,656681L,976479L,1441726L,2114700L,3082164L,4465650L,6433177L,9217720L,13138950L,18636135L,26307773L,36969518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035593Inst : IEnumerable<long>
{
public static readonly long[] Value=A035593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035593.Bytes);
public long this[int i]=>Value[i];

public static A035593Inst Instance=new A035593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035592
{
public static readonly long[] Value={ 1L,2L,6L,14L,32L,66L,134L,256L,480L,868L,1540L,2664L,4536L,7574L,12474L,20234L,32428L,51324L,80388L,124582L,191310L,291114L,439394L,657936L,978054L,1443684L,2117136L,3085174L,4469368L,6437742L,9223324L,13145792L,18644484L,26317916L,36981828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035592Inst : IEnumerable<long>
{
public static readonly long[] Value=A035592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035592.Bytes);
public long this[int i]=>Value[i];

public static A035592Inst Instance=new A035592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035591
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,5L,6L,6L,6L,7L,18L,23L,24L,24L,28L,54L,70L,75L,77L,91L,147L,189L,206L,215L,254L,369L,466L,514L,545L,645L,874L,1082L,1200L,1289L,1520L,1967L,2390L,2658L,2884L,3392L,4248L,5078L,5651L,6178L,7233L,8850L,10431L,11606L,12762L,14878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035591Inst : IEnumerable<long>
{
public static readonly long[] Value=A035591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035591.Bytes);
public long this[int i]=>Value[i];

public static A035591Inst Instance=new A035591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035590
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,4L,1L,5L,2L,5L,13L,5L,18L,9L,19L,35L,20L,51L,34L,56L,90L,61L,132L,99L,150L,214L,169L,311L,265L,362L,493L,420L,702L,639L,830L,1082L,985L,1507L,1462L,1802L,2307L,2177L,3143L,3160L,3784L,4749L,4632L,6345L,6593L,7674L,9536L,9484L,12526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035590Inst : IEnumerable<long>
{
public static readonly long[] Value=A035590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035590.Bytes);
public long this[int i]=>Value[i];

public static A035590Inst Instance=new A035590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035589
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,4L,1L,1L,5L,1L,12L,5L,5L,17L,6L,31L,18L,20L,47L,22L,76L,53L,60L,118L,68L,175L,139L,163L,273L,185L,391L,334L,400L,603L,458L,843L,758L,923L,1278L,1062L,1767L,1642L,2015L,2629L,2338L,3602L,3428L,4230L,5263L,4932L,7169L,6942L,8567L,10308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035589Inst : IEnumerable<long>
{
public static readonly long[] Value=A035589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035589.Bytes);
public long this[int i]=>Value[i];

public static A035589Inst Instance=new A035589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035588
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,4L,1L,0L,1L,5L,12L,4L,2L,5L,17L,30L,16L,9L,19L,46L,72L,47L,33L,55L,115L,162L,128L,97L,146L,263L,357L,311L,258L,351L,579L,757L,720L,624L,803L,1219L,1573L,1568L,1429L,1741L,2504L,3178L,3300L,3096L,3655L,4999L,6296L,6686L,6464L,7415L,9792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035588Inst : IEnumerable<long>
{
public static readonly long[] Value=A035588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035588.Bytes);
public long this[int i]=>Value[i];

public static A035588Inst Instance=new A035588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035587
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,2L,3L,6L,8L,12L,14L,18L,26L,34L,48L,57L,72L,91L,116L,152L,184L,226L,274L,337L,425L,511L,622L,736L,888L,1081L,1293L,1550L,1819L,2155L,2572L,3041L,3611L,4203L,4931L,5785L,6783L,7964L,9228L,10724L,12454L,14465L,16844L,19408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035587Inst : IEnumerable<long>
{
public static readonly long[] Value=A035587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035587.Bytes);
public long this[int i]=>Value[i];

public static A035587Inst Instance=new A035587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035586
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,2L,5L,7L,7L,11L,13L,19L,28L,31L,41L,51L,64L,88L,103L,127L,157L,188L,245L,292L,348L,426L,500L,622L,746L,872L,1051L,1227L,1478L,1766L,2048L,2429L,2826L,3331L,3949L,4557L,5334L,6184L,7188L,8440L,9710L,11246L,12984L,14947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035586Inst : IEnumerable<long>
{
public static readonly long[] Value=A035586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035586.Bytes);
public long this[int i]=>Value[i];

public static A035586Inst Instance=new A035586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035585
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,2L,5L,6L,6L,7L,11L,19L,23L,25L,29L,41L,59L,72L,80L,94L,123L,166L,199L,225L,262L,331L,423L,503L,570L,663L,813L,1012L,1188L,1351L,1560L,1880L,2284L,2664L,3022L,3478L,4127L,4940L,5716L,6480L,7415L,8709L,10282L,11835L,13379L,15257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035585Inst : IEnumerable<long>
{
public static readonly long[] Value=A035585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035585.Bytes);
public long this[int i]=>Value[i];

public static A035585Inst Instance=new A035585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035584
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,4L,2L,5L,6L,6L,14L,10L,19L,22L,24L,41L,37L,57L,67L,74L,113L,109L,155L,180L,203L,281L,290L,383L,446L,503L,666L,700L,896L,1033L,1171L,1488L,1600L,1982L,2282L,2578L,3202L,3467L,4221L,4827L,5457L,6628L,7243L,8663L,9881L,11134L,13339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035584Inst : IEnumerable<long>
{
public static readonly long[] Value=A035584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035584.Bytes);
public long this[int i]=>Value[i];

public static A035584Inst Instance=new A035584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035583
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,2L,3L,2L,4L,3L,9L,9L,10L,14L,15L,28L,26L,35L,41L,52L,75L,74L,100L,111L,147L,183L,196L,252L,282L,367L,429L,480L,593L,669L,852L,957L,1109L,1317L,1515L,1857L,2077L,2421L,2822L,3259L,3901L,4344L,5086L,5825L,6772L,7902L,8860L,10288L,11723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035583Inst : IEnumerable<long>
{
public static readonly long[] Value=A035583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035583.Bytes);
public long this[int i]=>Value[i];

public static A035583Inst Instance=new A035583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035582
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,3L,1L,1L,6L,5L,7L,6L,8L,18L,16L,18L,24L,29L,48L,44L,50L,72L,83L,113L,117L,131L,187L,209L,261L,285L,325L,440L,491L,576L,662L,755L,978L,1084L,1245L,1458L,1671L,2068L,2304L,2609L,3096L,3526L,4232L,4730L,5348L,6324L,7187L,8410L,9462L,10665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035582Inst : IEnumerable<long>
{
public static readonly long[] Value=A035582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035582.Bytes);
public long this[int i]=>Value[i];

public static A035582Inst Instance=new A035582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035581
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,3L,3L,3L,4L,6L,8L,9L,9L,13L,17L,21L,23L,25L,36L,46L,54L,59L,65L,92L,115L,132L,143L,162L,220L,274L,310L,336L,385L,505L,619L,698L,757L,876L,1115L,1350L,1515L,1652L,1916L,2383L,2846L,3186L,3487L,4053L,4944L,5836L,6516L,7162L,8311L,9991L,11664L,12998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035581Inst : IEnumerable<long>
{
public static readonly long[] Value=A035581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035581.Bytes);
public long this[int i]=>Value[i];

public static A035581Inst Instance=new A035581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035468
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,2L,1L,0L,0L,1L,1L,2L,3L,2L,1L,1L,1L,2L,3L,5L,4L,4L,2L,2L,3L,5L,7L,8L,7L,5L,4L,5L,7L,12L,12L,13L,11L,9L,8L,12L,16L,19L,21L,20L,17L,16L,17L,24L,28L,33L,33L,33L,28L,29L,34L,41L,48L,54L,53L,50L,48L,52L,58L,72L,79L,85L,83L,81L,80L,88L,100L,116L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035468Inst : IEnumerable<long>
{
public static readonly long[] Value=A035468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035468.Bytes);
public long this[int i]=>Value[i];

public static A035468Inst Instance=new A035468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035467
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,2L,0L,1L,1L,1L,3L,2L,2L,2L,1L,3L,3L,3L,5L,3L,5L,4L,3L,6L,5L,8L,8L,6L,8L,7L,9L,11L,11L,13L,13L,13L,15L,14L,16L,20L,20L,23L,23L,22L,26L,26L,31L,34L,34L,39L,39L,40L,45L,46L,52L,58L,58L,65L,64L,68L,77L,77L,89L,93L,96L,107L,105L,115L,124L,128L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035467Inst : IEnumerable<long>
{
public static readonly long[] Value=A035467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035467.Bytes);
public long this[int i]=>Value[i];

public static A035467Inst Instance=new A035467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035466
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,4L,4L,4L,4L,5L,5L,6L,6L,7L,8L,8L,8L,9L,10L,12L,12L,14L,14L,15L,16L,17L,19L,22L,22L,24L,25L,27L,29L,32L,34L,38L,39L,42L,44L,48L,51L,55L,59L,64L,67L,72L,75L,81L,87L,94L,99L,107L,111L,119L,126L,135L,144L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035466Inst : IEnumerable<long>
{
public static readonly long[] Value=A035466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035466.Bytes);
public long this[int i]=>Value[i];

public static A035466Inst Instance=new A035466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035465
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,2L,0L,1L,2L,2L,0L,1L,3L,3L,1L,2L,4L,4L,1L,3L,6L,6L,2L,5L,8L,7L,3L,7L,12L,10L,5L,10L,15L,13L,7L,15L,21L,17L,11L,20L,27L,22L,16L,28L,36L,29L,22L,37L,46L,38L,31L,50L,60L,50L,42L,65L,77L,64L,57L,86L,99L,82L,76L,111L,125L,106L,101L,144L,159L,135L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035465Inst : IEnumerable<long>
{
public static readonly long[] Value=A035465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035465.Bytes);
public long this[int i]=>Value[i];

public static A035465Inst Instance=new A035465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035464
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,3L,0L,2L,0L,3L,0L,4L,0L,5L,0L,5L,0L,8L,0L,8L,0L,11L,0L,12L,0L,15L,0L,17L,0L,22L,0L,23L,0L,30L,0L,34L,0L,40L,0L,45L,0L,56L,0L,61L,0L,73L,0L,83L,0L,98L,0L,109L,0L,130L,0L,144L,0L,169L,0L,190L,0L,219L,0L,246L,0L,286L,0L,317L,0L,365L,0L,410L,0L,467L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035464Inst : IEnumerable<long>
{
public static readonly long[] Value=A035464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035464.Bytes);
public long this[int i]=>Value[i];

public static A035464Inst Instance=new A035464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035463
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,2L,2L,1L,1L,2L,3L,2L,1L,4L,4L,3L,2L,5L,7L,5L,3L,7L,9L,8L,5L,9L,13L,11L,8L,13L,17L,16L,12L,18L,24L,22L,17L,24L,32L,31L,24L,32L,43L,42L,34L,43L,56L,57L,47L,57L,74L,75L,64L,76L,96L,100L,86L,99L,126L,130L,115L,129L,161L,171L,151L,168L,207L,219L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035463Inst : IEnumerable<long>
{
public static readonly long[] Value=A035463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035463.Bytes);
public long this[int i]=>Value[i];

public static A035463Inst Instance=new A035463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035462
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,2L,2L,1L,2L,3L,2L,2L,4L,4L,3L,4L,5L,5L,5L,6L,7L,8L,7L,8L,11L,10L,10L,13L,14L,14L,15L,17L,19L,20L,20L,24L,27L,26L,28L,33L,35L,35L,39L,44L,46L,48L,52L,58L,62L,63L,69L,78L,80L,83L,93L,100L,104L,111L,120L,130L,137L,143L,156L,169L,175L,185L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035462Inst : IEnumerable<long>
{
public static readonly long[] Value=A035462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035462.Bytes);
public long this[int i]=>Value[i];

public static A035462Inst Instance=new A035462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035461
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,2L,0L,0L,2L,0L,1L,3L,0L,2L,3L,0L,3L,4L,1L,4L,4L,3L,5L,5L,5L,6L,6L,8L,7L,9L,10L,8L,13L,13L,10L,18L,15L,14L,23L,18L,20L,29L,21L,29L,34L,27L,38L,40L,36L,49L,46L,49L,59L,56L,65L,71L,70L,83L,82L,91L,102L,98L,116L,122L,119L,148L,143L,150L,180L,169L,189L,217L,202L,237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035461Inst : IEnumerable<long>
{
public static readonly long[] Value=A035461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035461.Bytes);
public long this[int i]=>Value[i];

public static A035461Inst Instance=new A035461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035460
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,2L,1L,2L,2L,2L,3L,2L,3L,4L,3L,5L,5L,4L,7L,6L,7L,9L,7L,10L,11L,10L,14L,13L,14L,18L,16L,20L,22L,21L,27L,26L,29L,34L,32L,39L,41L,41L,51L,49L,54L,63L,60L,71L,76L,76L,90L,91L,98L,111L,110L,125L,133L,137L,157L,159L,172L,191L,192L,216L,229L,235L,266L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035460Inst : IEnumerable<long>
{
public static readonly long[] Value=A035460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035460.Bytes);
public long this[int i]=>Value[i];

public static A035460Inst Instance=new A035460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035459
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,2L,3L,1L,2L,4L,3L,2L,4L,5L,5L,4L,6L,8L,8L,6L,9L,12L,11L,9L,14L,17L,15L,15L,20L,23L,23L,21L,28L,34L,31L,30L,41L,45L,43L,44L,55L,62L,60L,60L,76L,84L,80L,83L,103L,112L,108L,114L,138L,148L,146L,153L,182L,197L,192L,203L,243L,256L,252L,272L,315L,333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035459Inst : IEnumerable<long>
{
public static readonly long[] Value=A035459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035459.Bytes);
public long this[int i]=>Value[i];

public static A035459Inst Instance=new A035459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035458
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,1L,1L,1L,2L,1L,2L,1L,3L,2L,3L,3L,4L,3L,5L,4L,6L,5L,7L,7L,8L,8L,10L,9L,13L,11L,15L,14L,17L,17L,20L,20L,24L,23L,29L,28L,33L,33L,38L,39L,45L,45L,53L,53L,61L,62L,70L,72L,81L,83L,95L,96L,108L,111L,124L,128L,142L,147L,164L,168L,187L,193L,212L,221L,242L,252L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035458Inst : IEnumerable<long>
{
public static readonly long[] Value=A035458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035458.Bytes);
public long this[int i]=>Value[i];

public static A035458Inst Instance=new A035458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035457
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,0L,2L,0L,3L,0L,4L,0L,5L,0L,6L,0L,8L,0L,10L,0L,12L,0L,15L,0L,18L,0L,22L,0L,27L,0L,32L,0L,38L,0L,46L,0L,54L,0L,64L,0L,76L,0L,89L,0L,104L,0L,122L,0L,142L,0L,165L,0L,192L,0L,222L,0L,256L,0L,296L,0L,340L,0L,390L,0L,448L,0L,512L,0L,585L,0L,668L,0L,760L,0L,864L,0L,982L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035457Inst : IEnumerable<long>
{
public static readonly long[] Value=A035457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035457.Bytes);
public long this[int i]=>Value[i];

public static A035457Inst Instance=new A035457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035456
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,1L,1L,1L,3L,1L,3L,2L,3L,4L,3L,4L,5L,4L,8L,5L,8L,8L,8L,11L,11L,11L,15L,12L,19L,17L,19L,22L,22L,26L,30L,27L,36L,34L,41L,44L,45L,51L,56L,57L,69L,66L,77L,82L,87L,97L,104L,107L,125L,124L,143L,149L,158L,175L,186L,196L,221L,221L,252L,263L,280L,307L,321L,344L,379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035456Inst : IEnumerable<long>
{
public static readonly long[] Value=A035456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035456.Bytes);
public long this[int i]=>Value[i];

public static A035456Inst Instance=new A035456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035455
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,2L,0L,3L,0L,4L,0L,6L,0L,7L,0L,9L,0L,11L,0L,15L,0L,18L,0L,23L,0L,27L,0L,34L,0L,41L,0L,50L,0L,59L,0L,72L,0L,85L,0L,103L,0L,120L,0L,143L,0L,167L,0L,198L,0L,230L,0L,270L,0L,313L,0L,366L,0L,422L,0L,491L,0L,564L,0L,653L,0L,748L,0L,861L,0L,984L,0L,1130L,0L,1287L,0L,1471L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035455Inst : IEnumerable<long>
{
public static readonly long[] Value=A035455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035455.Bytes);
public long this[int i]=>Value[i];

public static A035455Inst Instance=new A035455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035454
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,8L,8L,10L,11L,13L,13L,16L,16L,19L,20L,23L,25L,29L,30L,35L,37L,41L,44L,50L,53L,60L,64L,72L,76L,85L,90L,100L,107L,118L,126L,140L,148L,163L,174L,190L,203L,223L,237L,260L,277L,301L,321L,349L,371L,403L,430L,466L,496L,537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035454Inst : IEnumerable<long>
{
public static readonly long[] Value=A035454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035454.Bytes);
public long this[int i]=>Value[i];

public static A035454Inst Instance=new A035454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035453
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,3L,3L,3L,4L,5L,6L,7L,8L,8L,8L,9L,10L,12L,14L,16L,17L,18L,19L,20L,23L,26L,30L,33L,36L,38L,40L,43L,47L,53L,59L,65L,70L,74L,78L,84L,92L,101L,112L,122L,131L,139L,147L,157L,170L,186L,203L,220L,235L,249L,264L,281L,303L,329L,357L,384L,410L,434L,459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035453Inst : IEnumerable<long>
{
public static readonly long[] Value=A035453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035453.Bytes);
public long this[int i]=>Value[i];

public static A035453Inst Instance=new A035453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035436
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,1L,1L,2L,1L,2L,2L,1L,4L,2L,3L,4L,3L,6L,4L,6L,6L,7L,9L,7L,11L,9L,12L,15L,12L,17L,16L,20L,21L,23L,26L,25L,33L,32L,36L,40L,41L,49L,49L,57L,58L,66L,72L,75L,87L,86L,100L,106L,113L,126L,130L,148L,151L,172L,180L,191L,216L,219L,248L,258L,280L,304L,318L,355L,364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035436Inst : IEnumerable<long>
{
public static readonly long[] Value=A035436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035436.Bytes);
public long this[int i]=>Value[i];

public static A035436Inst Instance=new A035436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035435
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,4L,5L,4L,6L,7L,7L,7L,10L,10L,10L,12L,15L,14L,16L,19L,21L,21L,25L,28L,30L,31L,37L,40L,42L,46L,54L,55L,60L,68L,74L,76L,87L,95L,101L,108L,122L,130L,139L,151L,168L,176L,190L,209L,227L,237L,261L,284L,302L,321L,355L,378L,402L,434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035435Inst : IEnumerable<long>
{
public static readonly long[] Value=A035435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035435.Bytes);
public long this[int i]=>Value[i];

public static A035435Inst Instance=new A035435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035434
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,2L,0L,2L,1L,2L,1L,3L,2L,3L,3L,4L,3L,6L,4L,7L,5L,9L,6L,11L,8L,13L,11L,15L,14L,18L,17L,22L,21L,26L,25L,33L,29L,39L,36L,46L,43L,55L,52L,63L,64L,74L,75L,88L,89L,103L,104L,122L,121L,144L,142L,167L,167L,193L,196L,224L,229L,258L,268L,298L,309L,347L,356L,400L,412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035434Inst : IEnumerable<long>
{
public static readonly long[] Value=A035434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035434.Bytes);
public long this[int i]=>Value[i];

public static A035434Inst Instance=new A035434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035433
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,1L,2L,2L,2L,3L,2L,4L,3L,5L,4L,6L,6L,7L,8L,8L,10L,11L,12L,14L,14L,18L,17L,22L,21L,26L,27L,30L,34L,36L,41L,44L,48L,54L,56L,66L,66L,78L,80L,91L,97L,106L,116L,124L,137L,147L,159L,175L,184L,207L,215L,241L,252L,279L,297L,321L,348L,371L,404L,432L,464L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035433Inst : IEnumerable<long>
{
public static readonly long[] Value=A035433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035433.Bytes);
public long this[int i]=>Value[i];

public static A035433Inst Instance=new A035433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035432
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,2L,0L,3L,1L,3L,2L,4L,3L,4L,4L,6L,5L,8L,6L,11L,7L,14L,9L,17L,12L,20L,17L,23L,22L,27L,28L,33L,34L,41L,40L,52L,47L,63L,56L,76L,69L,88L,85L,103L,105L,119L,126L,142L,149L,169L,173L,203L,201L,241L,236L,282L,279L,326L,332L,375L,392L,433L,460L,504L,532L,589L,612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035432Inst : IEnumerable<long>
{
public static readonly long[] Value=A035432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035432.Bytes);
public long this[int i]=>Value[i];

public static A035432Inst Instance=new A035432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035431
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,3L,3L,3L,5L,4L,5L,6L,7L,7L,10L,10L,12L,13L,15L,16L,19L,20L,24L,26L,29L,32L,37L,38L,45L,49L,54L,59L,68L,71L,80L,88L,97L,104L,118L,126L,139L,151L,167L,179L,199L,214L,236L,254L,278L,300L,329L,352L,387L,417L,452L,487L,533L,568L,619L,668L,722L,774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035431Inst : IEnumerable<long>
{
public static readonly long[] Value=A035431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035431.Bytes);
public long this[int i]=>Value[i];

public static A035431Inst Instance=new A035431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035430
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,3L,3L,4L,5L,6L,7L,8L,8L,9L,10L,12L,14L,16L,17L,19L,20L,23L,26L,30L,33L,37L,39L,43L,47L,53L,59L,66L,71L,77L,83L,92L,101L,113L,123L,134L,144L,156L,169L,187L,204L,223L,240L,259L,278L,303L,329L,360L,389L,420L,449L,485L,522L,567L,613L,663L,710L,763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035430Inst : IEnumerable<long>
{
public static readonly long[] Value=A035430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035430.Bytes);
public long this[int i]=>Value[i];

public static A035430Inst Instance=new A035430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035429
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,3L,3L,4L,4L,5L,6L,6L,8L,9L,10L,11L,12L,15L,16L,18L,20L,23L,26L,28L,32L,35L,39L,44L,48L,54L,58L,65L,72L,79L,87L,95L,105L,115L,126L,138L,150L,165L,180L,197L,213L,233L,254L,276L,300L,325L,354L,383L,415L,451L,487L,528L,569L,618L,666L,718L,776L,836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035429Inst : IEnumerable<long>
{
public static readonly long[] Value=A035429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035429.Bytes);
public long this[int i]=>Value[i];

public static A035429Inst Instance=new A035429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035428
{
public static readonly long[] Value={ 2L,2L,3L,5L,7L,4L,7L,4L,11L,4L,3L,15L,4L,3L,23L,4L,3L,5L,30L,4L,3L,5L,44L,4L,3L,5L,7L,24L,34L,4L,3L,5L,7L,28L,54L,4L,3L,5L,7L,11L,20L,15L,70L,4L,3L,5L,7L,11L,21L,18L,23L,84L,4L,3L,5L,7L,11L,15L,7L,20L,23L,5L,131L,4L,3L,5L,7L,11L,15L,7L,21L,26L,5L,30L,163L,4L,3L,5L,7L,11L,15L,7L,15L,7L,28L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035428Inst : IEnumerable<long>
{
public static readonly long[] Value=A035428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035428.Bytes);
public long this[int i]=>Value[i];

public static A035428Inst Instance=new A035428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035427
{
public static readonly long[] Value={ 4L,3L,5L,7L,11L,15L,7L,15L,7L,23L,7L,5L,30L,7L,5L,44L,7L,5L,7L,58L,7L,5L,7L,82L,7L,5L,7L,11L,105L,7L,5L,7L,11L,62L,84L,7L,5L,7L,11L,15L,55L,131L,7L,5L,7L,11L,15L,59L,30L,163L,7L,5L,7L,11L,15L,22L,40L,35L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035427Inst : IEnumerable<long>
{
public static readonly long[] Value=A035427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035427.Bytes);
public long this[int i]=>Value[i];

public static A035427Inst Instance=new A035427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035426
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,4L,1L,6L,1L,1L,9L,1L,1L,13L,1L,1L,2L,18L,1L,1L,2L,4L,22L,1L,1L,2L,3L,1L,34L,1L,1L,2L,3L,1L,5L,43L,1L,1L,2L,3L,1L,4L,1L,8L,56L,1L,1L,2L,3L,1L,4L,1L,7L,1L,80L,1L,1L,2L,3L,1L,4L,1L,6L,1L,1L,11L,103L,1L,1L,2L,3L,1L,4L,1L,6L,1L,1L,10L,1L,16L,128L,1L,1L,2L,3L,1L,4L,1L,6L,1L,1L,9L,1L,1L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035426Inst : IEnumerable<long>
{
public static readonly long[] Value=A035426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035426.Bytes);
public long this[int i]=>Value[i];

public static A035426Inst Instance=new A035426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035425
{
public static readonly long[] Value={ 2L,2L,3L,5L,7L,2L,9L,2L,13L,2L,2L,18L,2L,2L,26L,2L,2L,3L,35L,2L,2L,3L,49L,2L,2L,3L,5L,9L,56L,2L,2L,3L,5L,9L,80L,2L,2L,3L,5L,7L,2L,11L,103L,2L,2L,3L,5L,7L,2L,11L,16L,128L,2L,2L,3L,5L,7L,2L,9L,2L,15L,2L,182L,2L,2L,3L,5L,7L,2L,9L,2L,15L,2L,21L,229L,2L,3L,5L,7L,2L,9L,2L,13L,2L,2L,20L,2L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035425Inst : IEnumerable<long>
{
public static readonly long[] Value=A035425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035425.Bytes);
public long this[int i]=>Value[i];

public static A035425Inst Instance=new A035425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035424
{
public static readonly long[] Value={ 1L,3L,5L,8L,13L,20L,24L,31L,35L,46L,50L,53L,68L,72L,75L,98L,102L,105L,110L,140L,144L,147L,152L,196L,200L,203L,208L,215L,239L,273L,277L,280L,285L,292L,320L,374L,378L,381L,386L,393L,404L,424L,439L,509L,513L,516L,521L,528L,539L,560L,578L,601L,685L,689L,692L,697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035424Inst : IEnumerable<long>
{
public static readonly long[] Value=A035424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035424.Bytes);
public long this[int i]=>Value[i];

public static A035424Inst Instance=new A035424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035423
{
public static readonly long[] Value={ 1L,5L,8L,13L,20L,31L,46L,53L,68L,75L,98L,105L,110L,140L,147L,152L,196L,203L,208L,215L,273L,280L,285L,292L,374L,381L,386L,393L,404L,509L,516L,521L,528L,539L,601L,685L,692L,697L,704L,715L,730L,785L,916L,923L,928L,935L,946L,961L,1020L,1050L,1213L,1220L,1225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035423Inst : IEnumerable<long>
{
public static readonly long[] Value=A035423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035423.Bytes);
public long this[int i]=>Value[i];

public static A035423Inst Instance=new A035423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035422
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,9L,13L,14L,20L,21L,22L,31L,32L,33L,46L,47L,48L,50L,68L,69L,70L,72L,76L,98L,99L,100L,102L,105L,106L,140L,141L,142L,144L,147L,148L,153L,196L,197L,198L,200L,203L,204L,208L,209L,217L,273L,274L,275L,277L,280L,281L,285L,286L,293L,294L,374L,375L,376L,378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035422Inst : IEnumerable<long>
{
public static readonly long[] Value=A035422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035422.Bytes);
public long this[int i]=>Value[i];

public static A035422Inst Instance=new A035422Inst();

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