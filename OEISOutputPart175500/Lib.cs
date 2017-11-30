using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A218605
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,14L,23L,34L,36L,37L,38L,40L,51L,53L,54L,55L,56L,59L,70L,81L,83L,84L,85L,86L,89L,102L,119L,124L,135L,137L,138L,139L,140L,143L,156L,173L,180L,197L,208L,213L,222L,233L,235L,236L,237L,238L,241L,254L,271L,278L,295L,306L,311L,322L,339L,350L,355L,370L,375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218605Inst : IEnumerable<long>
{
public static readonly long[] Value=A218605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218605.Bytes);
public long this[int i]=>Value[i];

public static A218605Inst Instance=new A218605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218606
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,10L,11L,13L,15L,16L,22L,24L,25L,39L,41L,42L,62L,63L,64L,65L,69L,71L,72L,92L,93L,94L,95L,105L,106L,107L,108L,114L,123L,125L,126L,146L,147L,148L,149L,159L,160L,161L,162L,168L,183L,184L,185L,186L,192L,203L,221L,223L,224L,244L,245L,246L,247L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218606Inst : IEnumerable<long>
{
public static readonly long[] Value=A218606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218606.Bytes);
public long this[int i]=>Value[i];

public static A218606Inst Instance=new A218606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218607
{
public static readonly long[] Value={ 0L,1L,3L,5L,8L,13L,22L,33L,35L,36L,37L,39L,50L,52L,53L,54L,55L,58L,69L,80L,82L,83L,84L,85L,88L,101L,118L,123L,134L,136L,137L,138L,139L,142L,155L,172L,179L,196L,207L,212L,221L,232L,234L,235L,236L,237L,240L,253L,270L,277L,294L,305L,310L,321L,338L,349L,354L,369L,374L,383L,400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218607Inst : IEnumerable<long>
{
public static readonly long[] Value=A218607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218607.Bytes);
public long this[int i]=>Value[i];

public static A218607Inst Instance=new A218607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218608
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,7L,9L,10L,12L,14L,15L,21L,23L,24L,38L,40L,41L,61L,62L,63L,64L,68L,70L,71L,91L,92L,93L,94L,104L,105L,106L,107L,113L,122L,124L,125L,145L,146L,147L,148L,158L,159L,160L,161L,167L,182L,183L,184L,185L,191L,202L,220L,222L,223L,243L,244L,245L,246L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218608Inst : IEnumerable<long>
{
public static readonly long[] Value=A218608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218608.Bytes);
public long this[int i]=>Value[i];

public static A218608Inst Instance=new A218608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218609
{
public static readonly BigInteger[] Value={ 0L,1L,2L,8L,3L,60L,172L,12L,20L,49L,54L,3016L,10096L,125744802L,101035235L,25L,1358590114L,40796719636668219L,70L,19049L,1770L,18L,7L,16261L,82682568533587123L,17L,36L,307L,315899951699378231L,3871315398L,15215587727307698L,59L,BigInteger.Parse("9097520004151634187729920190004140") };
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
public class A218609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218609Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218609.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218609.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218609Inst Instance=new A218609Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218610
{
public static readonly BigInteger[] Value={ 0L,1L,3L,4L,2L,37L,110L,18L,11L,32L,33L,4755L,16127L,73542063L,97105360L,62L,1306632183L,39288694215537689L,193L,8150L,719L,12L,5L,13505L,246941338376004599L,13L,45L,407L,944077158106260984L,4975012595L,5738426278308884L,26L,BigInteger.Parse("27439590092251146768825651348524279") };
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
public class A218610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218610Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218610.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218610.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218610Inst Instance=new A218610Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218611
{
public static readonly long[] Value={ 1L,5L,9L,16L,32L,59L,62L,115L,118L,208L,212L,213L,384L,389L,649L,654L,686L,703L,708L,716L,720L,723L,1310L,1326L,1328L,1338L,2236L,2369L,2422L,2432L,2452L,2458L,2466L,2476L,2486L,2488L,4545L,4601L,4625L,4627L,4637L,7811L,7817L,7819L,7826L,8287L,8511L,8526L,8631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218611Inst : IEnumerable<long>
{
public static readonly long[] Value=A218611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218611.Bytes);
public long this[int i]=>Value[i];

public static A218611Inst Instance=new A218611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218612
{
public static readonly long[] Value={ 2L,10L,22L,47L,105L,208L,224L,471L,486L,943L,966L,974L,1934L,1972L,3509L,3546L,3765L,3893L,3930L,3995L,4027L,4049L,7912L,8041L,8058L,8146L,14291L,15315L,15738L,15827L,15995L,16040L,16122L,16211L,16312L,16334L,31694L,32207L,32440L,32462L,32568L,57145L,57208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218612Inst : IEnumerable<long>
{
public static readonly long[] Value=A218612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218612.Bytes);
public long this[int i]=>Value[i];

public static A218612Inst Instance=new A218612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218613
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,5L,6L,4L,4L,5L,5L,9L,10L,17L,17L,5L,19L,32L,6L,10L,8L,4L,3L,10L,33L,4L,5L,7L,34L,20L,31L,5L,62L,4L,7L,4L,5L,14L,33L,7L,54L,32L,12L,14L,3L,34L,47L,4L,8L,31L,32L,143L,10L,11L,17L,169L,13L,240L,59L,8L,7L,15L,18L,12L,33L,102L,5L,66L,116L,6L,11L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218613Inst : IEnumerable<long>
{
public static readonly long[] Value=A218613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218613.Bytes);
public long this[int i]=>Value[i];

public static A218613Inst Instance=new A218613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218614
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,13L,21L,29L,37L,53L,69L,101L,85L,117L,181L,245L,309L,437L,565L,821L,693L,949L,1205L,1717L,1461L,1973L,2741L,3765L,2485L,3509L,5557L,7605L,9653L,13749L,17845L,26037L,21941L,30133L,38325L,54709L,46517L,62901L,87477L,120245L,79285L,112053L,144821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218614Inst : IEnumerable<long>
{
public static readonly long[] Value=A218614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218614.Bytes);
public long this[int i]=>Value[i];

public static A218614Inst Instance=new A218614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218615
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,14L,10L,26L,18L,58L,42L,122L,90L,106L,74L,202L,138L,458L,330L,970L,714L,842L,586L,1866L,1354L,1610L,1098L,3402L,2378L,3658L,2634L,6730L,4682L,14922L,10826L,31306L,23114L,27210L,19018L,59978L,43594L,51786L,35402L,109130L,76362L,117322L,84554L,248394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218615Inst : IEnumerable<long>
{
public static readonly long[] Value=A218615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218615.Bytes);
public long this[int i]=>Value[i];

public static A218615Inst Instance=new A218615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218616
{
public static readonly long[] Value={ 0L,1L,3L,7L,4L,15L,11L,8L,31L,26L,23L,19L,16L,63L,57L,53L,49L,46L,42L,39L,35L,32L,127L,120L,116L,112L,109L,104L,101L,97L,94L,89L,85L,81L,78L,74L,71L,67L,64L,255L,247L,240L,236L,231L,225L,221L,215L,209L,205L,200L,197L,193L,190L,184L,180L,176L,173L,168L,165L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218616Inst : IEnumerable<long>
{
public static readonly long[] Value=A218616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218616.Bytes);
public long this[int i]=>Value[i];

public static A218616Inst Instance=new A218616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218617
{
public static readonly long[] Value={ 0L,1L,18L,59L,7814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218617Inst : IEnumerable<long>
{
public static readonly long[] Value=A218617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218617.Bytes);
public long this[int i]=>Value[i];

public static A218617Inst Instance=new A218617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218618
{
public static readonly long[] Value={ 0L,1L,-1L,1L,-1L,3L,1L,-1L,3L,5L,-1L,1L,-1L,3L,5L,-1L,-7L,1L,1L,3L,1L,-1L,3L,5L,-1L,-7L,1L,1L,3L,-7L,1L,1L,-5L,1L,-5L,-3L,-1L,1L,-1L,3L,5L,-1L,-7L,1L,1L,3L,-7L,1L,1L,-5L,1L,-5L,-3L,-1L,-7L,1L,1L,-5L,1L,11L,1L,1L,13L,1L,-5L,-1L,3L,1L,-1L,3L,5L,-1L,-7L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218618Inst : IEnumerable<long>
{
public static readonly long[] Value=A218618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218618.Bytes);
public long this[int i]=>Value[i];

public static A218618Inst Instance=new A218618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218619
{
public static readonly BigInteger[] Value={ 1L,1L,11L,72L,734L,6994L,74641L,803196L,8989482L,102192197L,1184211027L,13897707080L,165052834584L,1978844990494L,23924151189858L,291313067897212L,3569576082827250L,43981925261314302L,544590342185545146L,6772925262506494672L,BigInteger.Parse("84567358373934285042") };
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
public class A218619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218619Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218619.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218619.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218619Inst Instance=new A218619Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218620
{
public static readonly long[] Value={ 7L,1L,0L,2L,18L,128L,443L,2666L,1353L,2706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218620Inst : IEnumerable<long>
{
public static readonly long[] Value=A218620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218620.Bytes);
public long this[int i]=>Value[i];

public static A218620Inst Instance=new A218620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218621
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,2L,1L,8L,3L,2L,1L,4L,1L,2L,3L,16L,1L,2L,1L,4L,3L,2L,1L,8L,5L,2L,3L,4L,1L,6L,1L,32L,3L,2L,5L,4L,1L,2L,3L,8L,1L,6L,1L,4L,5L,2L,1L,16L,7L,10L,3L,4L,1L,6L,5L,8L,3L,2L,1L,4L,1L,2L,7L,64L,5L,6L,1L,4L,3L,10L,1L,8L,1L,2L,5L,4L,7L,6L,1L,16L,9L,2L,1L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218621Inst : IEnumerable<long>
{
public static readonly long[] Value=A218621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218621.Bytes);
public long this[int i]=>Value[i];

public static A218621Inst Instance=new A218621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218622
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,0L,2L,2L,2L,2L,1L,1L,1L,2L,1L,1L,0L,0L,2L,2L,2L,0L,2L,2L,2L,2L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,2L,2L,2L,0L,2L,2L,0L,0L,2L,2L,2L,0L,2L,2L,2L,2L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,0L,2L,2L,2L,2L,1L,1L,1L,2L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218622Inst : IEnumerable<long>
{
public static readonly long[] Value=A218622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218622.Bytes);
public long this[int i]=>Value[i];

public static A218622Inst Instance=new A218622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218623
{
public static readonly long[] Value={ 0L,0L,0L,1L,5L,7L,16L,21L,34L,48L,69L,89L,129L,166L,220L,287L,377L,478L,619L,778L,992L,1247L,1565L,1941L,2428L,3000L,3706L,4553L,5594L,6826L,8341L,10129L,12300L,14873L,17962L,21619L,26009L,31175L,37324L,44567L,53164L,63245L,75167L,89118L,105544L,124746L,147261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218623Inst : IEnumerable<long>
{
public static readonly long[] Value=A218623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218623.Bytes);
public long this[int i]=>Value[i];

public static A218623Inst Instance=new A218623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218624
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,5L,17L,22L,39L,57L,85L,107L,162L,208L,273L,360L,474L,597L,774L,970L,1233L,1553L,1937L,2396L,2991L,3694L,4539L,5572L,6822L,8309L,10125L,12278L,14859L,17950L,21605L,25972L,31171L,37312L,44553L,53132L,63241L,75135L,89114L,105522L,124722L,147249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218624Inst : IEnumerable<long>
{
public static readonly long[] Value=A218624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218624.Bytes);
public long this[int i]=>Value[i];

public static A218624Inst Instance=new A218624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218625
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,3L,16L,21L,43L,65L,101L,125L,202L,253L,336L,444L,591L,736L,964L,1193L,1529L,1917L,2390L,2933L,3678L,4519L,5548L,6782L,8303L,10067L,12272L,14819L,17926L,21585L,25946L,31103L,37306L,44533L,53108L,63181L,75129L,89056L,105516L,124682L,147205L,173480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218625Inst : IEnumerable<long>
{
public static readonly long[] Value=A218625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218625.Bytes);
public long this[int i]=>Value[i];

public static A218625Inst Instance=new A218625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218626
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,13L,18L,43L,69L,115L,140L,243L,302L,402L,539L,726L,896L,1183L,1458L,1873L,2356L,2923L,3572L,4489L,5514L,6738L,8231L,10057L,12164L,14809L,17854L,21541L,25912L,31053L,37180L,44523L,53074L,63137L,75017L,89046L,105408L,124672L,147133L,173396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218626Inst : IEnumerable<long>
{
public static readonly long[] Value=A218626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218626.Bytes);
public long this[int i]=>Value[i];

public static A218626Inst Instance=new A218626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218627
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,8L,13L,41L,71L,126L,152L,288L,352L,475L,644L,882L,1077L,1444L,1759L,2286L,2871L,3558L,4317L,5466L,6686L,8161L,9939L,12150L,14632L,17840L,21423L,25842L,31001L,37096L,44313L,53060L,63085L,74947L,88858L,105394L,124492L,147119L,173278L,203994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218627Inst : IEnumerable<long>
{
public static readonly long[] Value=A218627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218627.Bytes);
public long this[int i]=>Value[i];

public static A218627Inst Instance=new A218627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218628
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,4L,8L,35L,67L,132L,158L,330L,399L,547L,755L,1055L,1276L,1737L,2103L,2757L,3476L,4295L,5184L,6605L,8079L,9823L,11956L,14610L,17544L,21401L,25646L,30885L,37014L,44169L,52707L,63063L,74865L,88742L,105074L,124470L,146816L,173256L,203798L,239540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218628Inst : IEnumerable<long>
{
public static readonly long[] Value=A218628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218628.Bytes);
public long this[int i]=>Value[i];

public static A218628Inst Instance=new A218628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218629
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,4L,27L,59L,132L,158L,371L,443L,619L,871L,1246L,1493L,2073L,2485L,3306L,4175L,5154L,6177L,7955L,9703L,11782L,14312L,17514L,20942L,25616L,30583L,36838L,44049L,52479L,62509L,74835L,88622L,104898L,123964L,146786L,172780L,203768L,239236L,280917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218629Inst : IEnumerable<long>
{
public static readonly long[] Value=A218629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218629.Bytes);
public long this[int i]=>Value[i];

public static A218629Inst Instance=new A218629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218630
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,18L,47L,124L,150L,403L,477L,684L,986L,1449L,1719L,2441L,2906L,3921L,4978L,6133L,7310L,9512L,11604L,14046L,17058L,20898L,24906L,30539L,36372L,43777L,52301L,62149L,73968L,88578L,104720L,123692L,145988L,172736L,203019L,239192L,280445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218630Inst : IEnumerable<long>
{
public static readonly long[] Value=A218630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218630.Bytes);
public long this[int i]=>Value[i];

public static A218630Inst Instance=new A218630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218631
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,10L,34L,110L,136L,425L,500L,740L,1097L,1661L,1954L,2846L,3357L,4616L,5885L,7250L,8582L,11324L,13794L,16674L,20228L,24846L,29487L,36312L,43087L,51903L,61895L,73424L,87274L,104660L,123438L,145588L,171526L,202959L,238060L,280385L,328137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218631Inst : IEnumerable<long>
{
public static readonly long[] Value=A218631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218631.Bytes);
public long this[int i]=>Value[i];

public static A218631Inst Instance=new A218631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218632
{
public static readonly ulong[] Value={ 1L,15L,511L,65523L,33546641L,68702054721L,562806164441653L,18442026828339805665UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218632Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A218632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218632.Bytes);
public ulong this[int i]=>Value[i];

public static A218632Inst Instance=new A218632Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218633
{
public static readonly long[] Value={ 7L,63L,511L,4087L,32689L,261505L,2092027L,16736081L,133887639L,1071093011L,8568679227L,68548914887L,548387167731L,4387064131261L,35096247367295L,280767853492265L,2246125824498091L,17968870569494163L,143749876352266497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218633Inst : IEnumerable<long>
{
public static readonly long[] Value=A218633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218633.Bytes);
public long this[int i]=>Value[i];

public static A218633Inst Instance=new A218633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218634
{
public static readonly ulong[] Value={ 15L,255L,4095L,65523L,1048353L,16773633L,268378101L,4294049121L,68704778799L,1099276346403L,17588419711983L,281414686103379L,4502634509040741L,72042144646840065L,1152674194384463589L,18442785190711981653UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218634Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A218634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218634.Bytes);
public ulong this[int i]=>Value[i];

public static A218634Inst Instance=new A218634Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218635
{
public static readonly BigInteger[] Value={ 29L,1017L,32753L,1048363L,33546641L,1073490145L,34351677143L,1099253514899L,35176108628465L,1125635352180227L,36020327300636471L,1152650346591335547L,BigInteger.Parse("36884807025995093735"),BigInteger.Parse("1180313694754197978059"),BigInteger.Parse("37770034069649980076795") };
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
public class A218635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218635Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218635.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218635.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218635Inst Instance=new A218635Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218636
{
public static readonly BigInteger[] Value={ 57L,4065L,262017L,16773477L,1073471633L,68702054721L,4396930705721L,281403528942981L,18009823835462025L,1152628595873880165L,BigInteger.Parse("73768221838169850821"),BigInteger.Parse("4721165666554240664629"),BigInteger.Parse("302154568669832438214889") };
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
public class A218636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218636Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218636.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218636.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218636Inst Instance=new A218636Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218637
{
public static readonly BigInteger[] Value={ 113L,16257L,2096129L,268375113L,34351030657L,4396923919617L,562806164441653L,72039179359935185L,9221013924842933937L,BigInteger.Parse("1180289649641919709529"),BigInteger.Parse("151077058155294314735841"),BigInteger.Parse("19337861267846477086600769") };
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
public class A218637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218637Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218637.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218637.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218637Inst Instance=new A218637Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218638
{
public static readonly long[] Value={ 1L,3L,1L,7L,15L,1L,15L,63L,63L,1L,29L,255L,511L,251L,1L,57L,1017L,4095L,4087L,1001L,1L,113L,4065L,32753L,65523L,32689L,4001L,1L,225L,16257L,262017L,1048363L,1048353L,261505L,16001L,1L,449L,65025L,2096129L,16773477L,33546641L,16773633L,2092027L,63985L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218638Inst : IEnumerable<long>
{
public static readonly long[] Value=A218638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218638.Bytes);
public long this[int i]=>Value[i];

public static A218638Inst Instance=new A218638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218639
{
public static readonly ulong[] Value={ 1L,251L,4087L,65523L,1048363L,16773477L,268375113L,4294000777L,68704008397L,1099264075379L,17588224239783L,281411572315259L,4502584908606667L,72041354562688477L,1152661609402891673L,18442584732844711745UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218639Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A218639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218639.Bytes);
public ulong this[int i]=>Value[i];

public static A218639Inst Instance=new A218639Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218640
{
public static readonly BigInteger[] Value={ 1L,1001L,32689L,1048353L,33546641L,1073471633L,34351030657L,1099232741569L,35175445605065L,1125614194685977L,36019652123390673L,1152628800344096833L,BigInteger.Parse("36884119447102424865"),BigInteger.Parse("1180291753062182528225"),BigInteger.Parse("37769333882150509728449") };
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
public class A218640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218640Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218640.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218640.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218640Inst Instance=new A218640Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218641
{
public static readonly BigInteger[] Value={ 1L,4001L,261505L,16773633L,1073490145L,68702054721L,4396923919617L,281403077821441L,18009795930773137L,1152626873213807201L,BigInteger.Parse("73768115566393606785"),BigInteger.Parse("4721159119167361543169"),BigInteger.Parse("302154165890141908970689") };
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
public class A218641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218641Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218641.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218641.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218641Inst Instance=new A218641Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218642
{
public static readonly long[] Value={ 1L,16001L,2092027L,268378101L,34351677143L,4396930705721L,562806164441653L,72039176523059285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218642Inst : IEnumerable<long>
{
public static readonly long[] Value=A218642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218642.Bytes);
public long this[int i]=>Value[i];

public static A218642Inst Instance=new A218642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218643
{
public static readonly long[] Value={ 2L,4L,11L,8L,14L,23L,16L,12L,21L,31L,32L,16L,27L,33L,41L,64L,32L,24L,42L,46L,53L,128L,64L,32L,36L,42L,51L,61L,256L,128L,64L,32L,54L,52L,62L,71L,512L,256L,128L,64L,48L,54L,63L,74L,83L,1024L,512L,256L,128L,64L,72L,81L,75L,82L,97L,2048L,1024L,512L,256L,128L,64L,72L,81L,92L,91L,101L,4096L,2048L,1024L,512L,256L,128L,64L,72L,81L,92L,106L,113L,8192L,4096L,2048L,1024L,512L,256L,128L,96L,108L,100L,102L,111L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218643Inst : IEnumerable<long>
{
public static readonly long[] Value=A218643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218643.Bytes);
public long this[int i]=>Value[i];

public static A218643Inst Instance=new A218643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218644
{
public static readonly BigInteger[] Value={ 4L,16L,610L,82188L,45453172L,99181510254L,817394844786996L,BigInteger.Parse("26269231937922520406") };
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
public class A218644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218644Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218644.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218644.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218644Inst Instance=new A218644Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218645
{
public static readonly long[] Value={ 4L,16L,66L,292L,1280L,5644L,24782L,108940L,478862L,2104866L,9252000L,40667620L,178756504L,785732636L,3453724976L,15181011874L,66728857148L,293309853452L,1289257359676L,5666991817956L,24909531073894L,109491024206644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218645Inst : IEnumerable<long>
{
public static readonly long[] Value=A218645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218645.Bytes);
public long this[int i]=>Value[i];

public static A218645Inst Instance=new A218645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218646
{
public static readonly long[] Value={ 16L,66L,610L,4946L,44712L,391888L,3441914L,30316230L,266671334L,2346850058L,20652411898L,181738545458L,1599310922692L,14073950030962L,123851052268298L,1089892156540672L,9591074382276762L,84401670396996900L,742736585615588566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218646Inst : IEnumerable<long>
{
public static readonly long[] Value=A218646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218646.Bytes);
public long this[int i]=>Value[i];

public static A218646Inst Instance=new A218646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218647
{
public static readonly BigInteger[] Value={ 36L,292L,4946L,82188L,1374954L,23370578L,394655980L,6688451956L,113330380248L,1919929942392L,32533805101006L,551254991578840L,9340671432312772L,158272966584027210L,2681844781855552786L,BigInteger.Parse("45442423044091925218") };
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
public class A218647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218647Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218647.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218647.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218647Inst Instance=new A218647Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218648
{
public static readonly BigInteger[] Value={ 94L,1280L,44712L,1374954L,45453172L,1519211492L,50119569324L,1664686049742L,55271550032162L,1834389849757758L,60908824469453990L,2022184882918753962L,BigInteger.Parse("67138807540703516826"),BigInteger.Parse("2229116172523577249680"),BigInteger.Parse("74009789156374427379680") };
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
public class A218648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218648Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218648.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218648.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218648Inst Instance=new A218648Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218649
{
public static readonly BigInteger[] Value={ 236L,5644L,391888L,23370578L,1519211492L,99181510254L,6431987350130L,419623464236488L,27357863689722514L,1783200625332610748L,BigInteger.Parse("116285423303246786898"),BigInteger.Parse("7582253123955997499522"),BigInteger.Parse("494404195464186732399198") };
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
public class A218649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218649Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218649.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218649.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218649Inst Instance=new A218649Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218650
{
public static readonly BigInteger[] Value={ 602L,24782L,3441914L,394655980L,50119569324L,6431987350130L,817394844786996L,104563780472177342L,13375235335809957170UL,BigInteger.Parse("1710137926295211991338"),BigInteger.Parse("218764828600351495270866"),BigInteger.Parse("27982536987440234040232618") };
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
public class A218650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218650Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218650.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218650.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218650Inst Instance=new A218650Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218651
{
public static readonly long[] Value={ 4L,4L,4L,16L,16L,16L,36L,66L,66L,36L,94L,292L,610L,292L,94L,236L,1280L,4946L,4946L,1280L,236L,602L,5644L,44712L,82188L,44712L,5644L,602L,1528L,24782L,391888L,1374954L,1374954L,391888L,24782L,1528L,3882L,108940L,3441914L,23370578L,45453172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218651Inst : IEnumerable<long>
{
public static readonly long[] Value=A218651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218651.Bytes);
public long this[int i]=>Value[i];

public static A218651Inst Instance=new A218651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218652
{
public static readonly BigInteger[] Value={ 1L,2L,12L,108L,1320L,20400L,381360L,8366400L,210712320L,5991572160L,189846961920L,6632804344320L,253310120743680L,10498203901785600L,469251125818675200L,BigInteger.Parse("22501933753870771200"),BigInteger.Parse("1152276591132072806400"),BigInteger.Parse("62756742945031098163200"),BigInteger.Parse("3622251744055050294988800") };
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
public class A218652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218652.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218652Inst Instance=new A218652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218653
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,264L,3400L,54480L,1045800L,23412480L,599157216L,17258814720L,552733695360L,19485393903360L,749871707270400L,31283408387911680L,1406370859616923200L,BigInteger.Parse("67780975948945459200"),BigInteger.Parse("3486485719168394342400"),BigInteger.Parse("190644828634476331315200"),BigInteger.Parse("11043310871932837194977280") };
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
public class A218653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218653.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218653Inst Instance=new A218653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218654
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,2L,2L,1L,4L,1L,4L,2L,4L,2L,3L,2L,6L,3L,4L,3L,6L,2L,6L,3L,4L,3L,8L,3L,8L,2L,5L,5L,8L,4L,8L,6L,5L,4L,8L,2L,10L,6L,6L,3L,11L,4L,9L,6L,9L,7L,10L,4L,14L,6L,9L,3L,11L,4L,12L,7L,9L,10L,10L,4L,11L,5L,10L,9L,15L,4L,15L,9L,9L,8L,14L,6L,12L,8L,9L,8L,18L,4L,17L,11L,9L,11L,20L,5L,14L,10L,13L,7L,16L,9L,17L,6L,16L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218654Inst : IEnumerable<long>
{
public static readonly long[] Value=A218654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218654.Bytes);
public long this[int i]=>Value[i];

public static A218654Inst Instance=new A218654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218655
{
public static readonly long[] Value={ 2L,4L,13L,-176L,-786L,-3452L,54483L,237722L,1037569L,-16329149L,-71279530L,-311145495L,4897036897L,21376227709L,93310132523L,-1468582101731L,-6410560285891L,-27982966049682L,440416091468393L,1922476035761802L,8391868916275609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218655Inst : IEnumerable<long>
{
public static readonly long[] Value=A218655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218655.Bytes);
public long this[int i]=>Value[i];

public static A218655Inst Instance=new A218655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218656
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,3L,1L,5L,4L,4L,4L,5L,4L,7L,6L,5L,3L,10L,4L,9L,8L,4L,9L,6L,7L,11L,7L,5L,11L,9L,9L,9L,11L,4L,14L,14L,9L,8L,9L,7L,11L,8L,12L,12L,10L,9L,11L,17L,10L,12L,16L,7L,13L,14L,8L,15L,9L,11L,23L,16L,9L,17L,23L,8L,15L,15L,11L,21L,18L,12L,19L,14L,15L,19L,21L,17L,16L,23L,13L,21L,20L,17L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218656Inst : IEnumerable<long>
{
public static readonly long[] Value=A218656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218656.Bytes);
public long this[int i]=>Value[i];

public static A218656Inst Instance=new A218656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218657
{
public static readonly long[] Value={ 3L,15L,57L,225L,891L,3519L,13905L,54945L,217107L,857871L,3389769L,13394241L,52925643L,209128959L,826346529L,3265203393L,12902036643L,50980759695L,201443999193L,795980386593L,3145215436443L,12427919466687L,49107345869169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218657Inst : IEnumerable<long>
{
public static readonly long[] Value=A218657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218657.Bytes);
public long this[int i]=>Value[i];

public static A218657Inst Instance=new A218657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218658
{
public static readonly long[] Value={ 5L,57L,417L,3249L,25533L,199489L,1560161L,12202673L,95434773L,746388537L,5837454753L,45654295713L,357058903853L,2792531543489L,21840184444225L,170810481722657L,1335896257560101L,10447946710663673L,81712625405191841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218658Inst : IEnumerable<long>
{
public static readonly long[] Value=A218658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218658.Bytes);
public long this[int i]=>Value[i];

public static A218658Inst Instance=new A218658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218659
{
public static readonly ulong[] Value={ 9L,225L,3249L,50625L,793881L,12383361L,193349025L,3018953025L,47135449449L,735942652641L,11490533873361L,179405691966081L,2801123686963449L,43734921492423681L,682848585990347841L,10661553197658712449UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218659Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A218659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218659.Bytes);
public ulong this[int i]=>Value[i];

public static A218659Inst Instance=new A218659Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218660
{
public static readonly BigInteger[] Value={ 17L,891L,25533L,793881L,24879489L,775176415L,24176619049L,754066017977L,23517838102321L,733484062428443L,22876204302519509L,713472099034206097L,BigInteger.Parse("22252052902297965073"),BigInteger.Parse("694005913498881446047"),BigInteger.Parse("21644933495864588983569") };
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
public class A218660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218660Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218660.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218660.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218660Inst Instance=new A218660Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218661
{
public static readonly BigInteger[] Value={ 31L,3519L,199489L,12383361L,775176415L,48231228511L,3004025019009L,187110346460865L,11653760352498463L,725837910289490239L,BigInteger.Parse("45207782461323582145"),BigInteger.Parse("2815700819921566341313"),BigInteger.Parse("175371845132587985115103") };
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
public class A218661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218661Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218661.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218661.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218661Inst Instance=new A218661Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218662
{
public static readonly BigInteger[] Value={ 57L,13905L,1560161L,193349025L,24176619049L,3004025019009L,373654052856545L,46478887982679329L,5781165979795708377L,BigInteger.Parse("719085383719049449649"),BigInteger.Parse("89442819441859188818049"),BigInteger.Parse("11125261930001197817552385") };
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
public class A218662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218662.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218662Inst Instance=new A218662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218663
{
public static readonly long[] Value={ 1L,3L,3L,5L,15L,5L,9L,57L,57L,9L,17L,225L,417L,225L,17L,31L,891L,3249L,3249L,891L,31L,57L,3519L,25533L,50625L,25533L,3519L,57L,105L,13905L,199489L,793881L,793881L,199489L,13905L,105L,193L,54945L,1560161L,12383361L,24879489L,12383361L,1560161L,54945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218663Inst : IEnumerable<long>
{
public static readonly long[] Value=A218663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218663.Bytes);
public long this[int i]=>Value[i];

public static A218663Inst Instance=new A218663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218664
{
public static readonly long[] Value={ 1L,1L,-2L,-1L,1L,4L,3L,-1L,1L,7L,14L,7L,1L,10L,31L,29L,1L,13L,54L,71L,1L,16L,83L,139L,1L,19L,118L,239L,1L,22L,159L,377L,1L,25L,206L,559L,1L,28L,259L,791L,1L,31L,318L,1079L,1L,34L,383L,1429L,1L,37L,454L,1847L,1L,40L,531L,2339L,1L,43L,614L,2911L,1L,46L,703L,3569L,1L,49L,798L,4319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218664Inst : IEnumerable<long>
{
public static readonly long[] Value=A218664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218664.Bytes);
public long this[int i]=>Value[i];

public static A218664Inst Instance=new A218664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218665
{
public static readonly long[] Value={ 1L,2L,4L,10L,16L,20L,41L,44L,55L,67L,76L,548L,751L,1962L,3318L,3760L,5873L,7729L,8074L,15502L,33847L,65888L,89836L,167786L,512688L,1401686L,2520988L,2897654L,5552333L,6352323L,7981750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218665Inst : IEnumerable<long>
{
public static readonly long[] Value=A218665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218665.Bytes);
public long this[int i]=>Value[i];

public static A218665Inst Instance=new A218665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218666
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,2L,4L,1L,2L,4L,4L,9L,1L,3L,7L,8L,9L,20L,1L,3L,9L,16L,18L,20L,48L,1L,4L,12L,30L,36L,40L,48L,115L,1L,4L,18L,38L,81L,80L,96L,115L,286L,1L,5L,21L,64L,144L,180L,192L,230L,286L,719L,1L,5L,27L,92L,216L,400L,432L,460L,572L,719L,1842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218666Inst : IEnumerable<long>
{
public static readonly long[] Value=A218666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218666.Bytes);
public long this[int i]=>Value[i];

public static A218666Inst Instance=new A218666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218667
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,13L,46L,181L,778L,3585L,17566L,91171L,499324L,2873839L,17317743L,108933098L,713481122L,4855161425L,34257461754L,250177938679L,1887886966690L,14699340919293L,117933068390123L,973776266303732L,8265721830953558L,72052688932613079L,644393453082317301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218667Inst : IEnumerable<long>
{
public static readonly long[] Value=A218667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218667.Bytes);
public long this[int i]=>Value[i];

public static A218667Inst Instance=new A218667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218668
{
public static readonly BigInteger[] Value={ 1L,0L,1L,3L,22L,161L,1546L,18857L,270320L,4471693L,85455574L,1865128265L,45735737037L,1247518965519L,37654095184226L,1250673144714138L,45415758777730668L,1792734161930717221L,BigInteger.Parse("76595370803745016626"),BigInteger.Parse("3529261203030717032927"),BigInteger.Parse("174742139545017029583279") };
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
public class A218668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218668Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218668.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218668.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218668Inst Instance=new A218668Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218669
{
public static readonly BigInteger[] Value={ 1L,0L,1L,7L,97L,1561L,41136L,1551814L,72440460L,4281320257L,324623105584L,30086950057627L,3299720918091511L,428431079916572044L,BigInteger.Parse("65637957066642609845"),BigInteger.Parse("11659659637028895337265"),BigInteger.Parse("2367270866164121777222596"),BigInteger.Parse("546795407830461739380895161"),BigInteger.Parse("143176487805296033192642234802") };
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
public class A218669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218669.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218669Inst Instance=new A218669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218670
{
public static readonly long[] Value={ 1L,1L,2L,7L,26L,116L,556L,2927L,16388L,97666L,612136L,4023878L,27579410L,196537134L,1451102836L,11074811191L,87160086800L,706055915318L,5876662642720L,50182337830986L,439036984440316L,3930618736372336L,35970734643745496L,336153100655220126L,3205000520319374116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218670Inst : IEnumerable<long>
{
public static readonly long[] Value=A218670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218670.Bytes);
public long this[int i]=>Value[i];

public static A218670Inst Instance=new A218670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218671
{
public static readonly BigInteger[] Value={ 1L,1L,8L,120L,2635L,76503L,2764957L,119634152L,6030195490L,347037131298L,22453144758980L,1613322276606404L,127466755375275614L,10983423290600347408UL,BigInteger.Parse("1025046637630590359928"),BigInteger.Parse("103004615955568528609200"),BigInteger.Parse("11088429267977228122393005"),BigInteger.Parse("1273093489376335864500416685") };
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
public class A218671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218671Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218671.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218671.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218671Inst Instance=new A218671Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218672
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,63L,659L,9833L,206961L,6133990L,256650268L,15213478000L,1281205909177L,153588353066135L,26245044813624300L,6399076697684238375L,BigInteger.Parse("2227912079081482302977"),BigInteger.Parse("1108302173165578509079527"),BigInteger.Parse("788171767077184315422131588"),BigInteger.Parse("801638519723021288783092512047") };
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
public class A218672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218672Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218672.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218672.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218672Inst Instance=new A218672Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218673
{
public static readonly BigInteger[] Value={ 1L,1L,3L,20L,209L,3173L,67292L,1970761L,79764057L,4490097388L,354111363537L,39360693851404L,6193012446752244L,1383433132321835172L,BigInteger.Parse("439684769985895688173"),BigInteger.Parse("199116777197880585373014"),BigInteger.Parse("128631139424158036273736167"),BigInteger.Parse("118640007280899188486618513612") };
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
public class A218673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218673Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218673.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218673.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218673Inst Instance=new A218673Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218674
{
public static readonly BigInteger[] Value={ 1L,1L,4L,34L,455L,8710L,230077L,8285224L,407456797L,27587687551L,2596034329278L,342275007167359L,63606742005546232L,16730509857101195808UL,BigInteger.Parse("6246818082857455197662"),BigInteger.Parse("3317816101992338134691233"),BigInteger.Parse("2510420393373091580780786808"),BigInteger.Parse("2709148467943025007607468405672") };
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
public class A218674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218674Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218674.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218674.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218674Inst Instance=new A218674Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218675
{
public static readonly BigInteger[] Value={ 1L,1L,5L,51L,817L,18562L,576687L,24203258L,1375038677L,106708683355L,11435867474152L,1708844338589752L,358640659116617571L,BigInteger.Parse("106261016900832212139"),BigInteger.Parse("44607231638918264608274"),BigInteger.Parse("26598477338494285370797703"),BigInteger.Parse("22569718290467849884279856477") };
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
public class A218675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218675Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218675.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218675.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218675Inst Instance=new A218675Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218676
{
public static readonly BigInteger[] Value={ 1L,1L,6L,71L,1311L,34146L,1207717L,57298282L,3653975784L,316252925221L,37596625187796L,6206102367103899L,1434418185304457039L,BigInteger.Parse("466995106832397752352"),BigInteger.Parse("215051811411620578152401"),BigInteger.Parse("140491107719613466192347681"),BigInteger.Parse("130481943378389095603359529403") };
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
public class A218676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218676Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218676.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218676.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218676Inst Instance=new A218676Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218677
{
public static readonly BigInteger[] Value={ 1L,1L,3L,14L,79L,516L,3802L,30668L,268815L,2522594L,25201736L,266014607L,2953171684L,34326755191L,416313253084L,5251970372080L,68737673434847L,931207966502919L,13031639620371226L,188051624603419973L,2793741995189126920L,BigInteger.Parse("42668132798523737471"),BigInteger.Parse("669061042470049870917") };
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
public class A218677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218677Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218677.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218677.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218677Inst Instance=new A218677Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218678
{
public static readonly BigInteger[] Value={ 1L,1L,4L,22L,161L,1321L,12541L,130383L,1482875L,18153076L,237430711L,3295833146L,48274094584L,742868875984L,11963384310515L,200974595790271L,3511980095379727L,63682377891348689L,1195661594431548085L,BigInteger.Parse("23199930176668566579"),BigInteger.Parse("464421513762097397125"),BigInteger.Parse("9576744471125816269165") };
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
public class A218678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218678Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218678.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218678.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218678Inst Instance=new A218678Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218679
{
public static readonly BigInteger[] Value={ 1L,1L,5L,31L,273L,2652L,30071L,375628L,5135649L,75945388L,1202006514L,20243446719L,360517872287L,6758311053521L,132833835618576L,2728019848249377L,58370987166092073L,1297916560174624569L,BigInteger.Parse("29924140267551540116"),BigInteger.Parse("713934350929955200551"),BigInteger.Parse("17594768127940813003452") };
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
public class A218679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218679Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218679.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218679.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218679Inst Instance=new A218679Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218680
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,111L,911L,8622L,91414L,1067579L,13564195L,185687381L,2718184470L,42288343176L,695667651368L,12049465530936L,218945489692574L,4160440403683643L,82448824370010887L,1699889286488298603L,BigInteger.Parse("36384381642357676480"),BigInteger.Parse("806926050321577391347"),BigInteger.Parse("18510872795071148287531") };
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
public class A218680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218680Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218680.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218680.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218680Inst Instance=new A218680Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218681
{
public static readonly BigInteger[] Value={ 1L,1L,2L,17L,248L,8044L,499033L,62625238L,15947986557L,8220983161264L,8675909809528468L,BigInteger.Parse("18709697284980554577"),BigInteger.Parse("82551047593942653184220"),BigInteger.Parse("747564468621251440782891798"),BigInteger.Parse("13885138852461763218258064204207"),BigInteger.Parse("529723356811556257370919794910913765") };
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
public class A218681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218681Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218681.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218681.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218681Inst Instance=new A218681Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218682
{
public static readonly BigInteger[] Value={ 1L,1L,6L,93L,2944L,167685L,16037376L,2481455137L,609371157312L,235171042752105L,141778378915235200L,BigInteger.Parse("132871933962627534741"),BigInteger.Parse("192678752056300896500544"),BigInteger.Parse("430404642833695770472870573"),BigInteger.Parse("1474859949355240010986735351872"),BigInteger.Parse("7723091241704594423130951106689225") };
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
public class A218682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218682Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218682.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218682.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218682Inst Instance=new A218682Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218683
{
public static readonly BigInteger[] Value={ 1L,1L,6L,69L,1432L,52065L,3202176L,324172597L,53099867136L,13888279032129L,5736880791449920L,3710252136325373661L,BigInteger.Parse("3729910949734728414624"),BigInteger.Parse("5792791811385586637686849"),BigInteger.Parse("13826260704559808415109532256"),BigInteger.Parse("50488064853691920270244556417445") };
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
public class A218683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218683Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218683.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218683.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218683Inst Instance=new A218683Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218684
{
public static readonly long[] Value={ 1L,0L,1L,2L,7L,18L,96L,260L,1851L,5270L,46515L,137942L,1447202L,4433772L,53787706L,169169912L,2326986783L,7477418982L,114916173009L,375898894514L,6380455164161L,21185872231238L,393499602818322L,1323362744628080L,26691270481453228L,90755667374332324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218684Inst : IEnumerable<long>
{
public static readonly long[] Value=A218684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218684.Bytes);
public long this[int i]=>Value[i];

public static A218684Inst Instance=new A218684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218685
{
public static readonly BigInteger[] Value={ 1L,0L,1L,6L,34L,270L,3415L,31230L,681026L,6949920L,230637870L,2546120514L,119281951006L,1394371349490L,87612425583018L,1069010047029672L,86763885548985810L,1094149501538197236L,BigInteger.Parse("111443560982774811439"),BigInteger.Parse("1442387644419293694144"),BigInteger.Parse("180179254059921915232864") };
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
public class A218685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218685Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218685.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218685.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218685Inst Instance=new A218685Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218686
{
public static readonly BigInteger[] Value={ 1L,1L,2L,15L,107L,1164L,13932L,207527L,3424441L,65365273L,1366815507L,31899555046L,806153628997L,22260455705106L,659196741236329L,21028295211402871L,713819243969142111L,BigInteger.Parse("25836118882427921161"),BigInteger.Parse("988875977638287049631"),BigInteger.Parse("40043648314495526922945") };
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
public class A218686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218686Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218686.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218686.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218686Inst Instance=new A218686Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218687
{
public static readonly BigInteger[] Value={ 1L,1L,2L,31L,398L,10476L,296407L,12613297L,592445192L,36797742660L,2524966492661L,212912151736648L,19819138754732997L,2155966497948737905L,BigInteger.Parse("259256365067737582615"),BigInteger.Parse("35050667748654756208069"),BigInteger.Parse("5257919606219599751747894"),BigInteger.Parse("858816581875175776426876930") };
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
public class A218687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218687Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218687.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218687.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218687Inst Instance=new A218687Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218688
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,106L,975L,11106L,151501L,2415960L,44221869L,915826600L,21211128411L,544126606992L,15334985416075L,471495297242256L,15719617534811625L,565271886957356416L,BigInteger.Parse("21820620411482896089"),BigInteger.Parse("900398349688515500160"),BigInteger.Parse("39564926462522623540519"),BigInteger.Parse("1845034125763359894240000") };
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
public class A218688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218688Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218688.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218688.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218688Inst Instance=new A218688Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218689
{
public static readonly BigInteger[] Value={ 1L,65L,93313L,795985985L,8178690000001L,93706344780048065L,BigInteger.Parse("1453730786373283012225"),BigInteger.Parse("26552497154713885161031745"),BigInteger.Parse("513912636558068387176582890625"),BigInteger.Parse("10769375530849394271690330588432065"),BigInteger.Parse("243282405272735566295972089793676717313"),BigInteger.Parse("5763401688773271719278313934033057270226625") };
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
public class A218689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218689Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218689.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218689.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218689Inst Instance=new A218689Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218690
{
public static readonly BigInteger[] Value={ 1L,5L,181L,9797L,616501L,45778505L,3678753205L,314352091205L,28154344881205L,2612340741982505L,249415797821914681L,BigInteger.Parse("24374175871569953225"),BigInteger.Parse("2428502737999745059381"),BigInteger.Parse("245952659136011117909897"),BigInteger.Parse("25260608441078125508484181"),BigInteger.Parse("2626023605592369669830217797") };
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
public class A218690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218690Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218690.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218690.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218690Inst Instance=new A218690Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218691
{
public static readonly BigInteger[] Value={ 1L,2L,6L,26L,156L,1242L,12616L,158034L,2372880L,41725106L,843126624L,19277549898L,492447987136L,13907344659210L,430397513894016L,14487404695687298L,527023721684738304L,BigInteger.Parse("20605894357093102434"),BigInteger.Parse("861761850029367846400"),BigInteger.Parse("38387125875316048363386"),BigInteger.Parse("1814541564588778500135936") };
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
public class A218691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218691Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218691.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218691.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218691Inst Instance=new A218691Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218692
{
public static readonly BigInteger[] Value={ 1L,9L,1945L,783657L,333935001L,216152253009L,148273286805001L,112444816742316585L,BigInteger.Parse("93273051852487532953"),BigInteger.Parse("80885382627785790555009"),BigInteger.Parse("73726153308964013326434945"),BigInteger.Parse("69714999360408389332640853105"),BigInteger.Parse("67921574835559806028030517001225"),BigInteger.Parse("67965584346796032477336615843457665") };
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
public class A218692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218692Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218692.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218692.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218692Inst Instance=new A218692Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218693
{
public static readonly BigInteger[] Value={ 1L,9L,271L,11193L,535251L,27854739L,1531656211L,87547358649L,5149886133907L,309721191497259L,18957806551405701L,1177134132932168739L,BigInteger.Parse("73964787438524189871"),BigInteger.Parse("4694347514292389411103"),BigInteger.Parse("300499277330710307643771"),BigInteger.Parse("19378727805024033594228153"),BigInteger.Parse("1257802636907811605342461587") };
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
public class A218693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218693Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218693.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218693.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218693Inst Instance=new A218693Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218694
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,2L,2L,3L,6L,9L,10L,13L,22L,32L,40L,56L,86L,122L,164L,229L,332L,474L,656L,914L,1310L,1867L,2604L,3648L,5184L,7346L,10318L,14506L,20516L,29022L,40880L,57548L,81260L,114810L,161864L,228092L,321892L,454444L,640954L,903715L,1274998L,1799320L,2538218L,3579714L,5049954L,7125359L,10051844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218694Inst : IEnumerable<long>
{
public static readonly long[] Value=A218694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218694.Bytes);
public long this[int i]=>Value[i];

public static A218694Inst Instance=new A218694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218695
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,25L,25L,1L,1L,79L,265L,79L,1L,1L,241L,2161L,2161L,241L,1L,1L,727L,16081L,41503L,16081L,727L,1L,1L,2185L,115465L,693601L,693601L,115465L,2185L,1L,1L,6559L,816985L,10924399L,24997921L,10924399L,816985L,6559L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218695Inst : IEnumerable<long>
{
public static readonly long[] Value=A218695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218695.Bytes);
public long this[int i]=>Value[i];

public static A218695Inst Instance=new A218695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218696
{
public static readonly BigInteger[] Value={ 1L,15L,222L,3680L,69345L,1477182L,35234220L,932070708L,27109785510L,860394764515L,29600058300780L,1097511032533500L,43637308561557074L,1852311640075120980L,BigInteger.Parse("83612841417061582320"),BigInteger.Parse("3999611090385007608840"),BigInteger.Parse("202111299843794061251580"),BigInteger.Parse("10758947714752854861908379") };
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
public class A218696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218696Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218696.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218696.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218696Inst Instance=new A218696Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218697
{
public static readonly long[] Value={ 6L,9L,14L,21L,46L,49L,69L,86L,94L,129L,134L,141L,145L,161L,166L,201L,205L,206L,214L,249L,254L,301L,305L,309L,321L,326L,329L,334L,381L,445L,446L,454L,469L,489L,501L,505L,526L,529L,545L,566L,581L,614L,669L,681L,694L,721L,734L,745L,749L,766L,789L,841L,849L,886L,889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218697Inst : IEnumerable<long>
{
public static readonly long[] Value=A218697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218697.Bytes);
public long this[int i]=>Value[i];

public static A218697Inst Instance=new A218697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218698
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,2L,6L,3L,2L,2L,14L,5L,4L,3L,3L,27L,7L,4L,3L,2L,2L,60L,11L,8L,6L,5L,4L,4L,117L,15L,8L,6L,4L,3L,2L,2L,246L,22L,13L,9L,8L,6L,5L,4L,4L,490L,30L,15L,12L,8L,7L,5L,4L,3L,3L,1002L,42L,22L,14L,12L,9L,8L,6L,5L,4L,4L,1998L,56L,24L,16L,12L,10L,7L,6L,4L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218698Inst : IEnumerable<long>
{
public static readonly long[] Value=A218698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218698.Bytes);
public long this[int i]=>Value[i];

public static A218698Inst Instance=new A218698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218699
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,5L,4L,8L,8L,12L,12L,19L,18L,24L,26L,36L,36L,48L,50L,70L,71L,92L,96L,129L,133L,168L,177L,225L,233L,294L,307L,382L,401L,488L,518L,635L,668L,803L,855L,1027L,1089L,1298L,1381L,1638L,1745L,2047L,2184L,2569L,2734L,3181L,3404L,3953L,4213L,4863L,5203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218699Inst : IEnumerable<long>
{
public static readonly long[] Value=A218699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218699.Bytes);
public long this[int i]=>Value[i];

public static A218699Inst Instance=new A218699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218700
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,4L,3L,6L,7L,9L,10L,15L,15L,19L,23L,26L,28L,36L,37L,48L,52L,62L,67L,85L,93L,110L,122L,144L,157L,194L,205L,241L,265L,304L,338L,391L,422L,483L,533L,607L,661L,760L,822L,933L,1032L,1151L,1260L,1432L,1554L,1751L,1920L,2137L,2333L,2621L,2848L,3176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218700Inst : IEnumerable<long>
{
public static readonly long[] Value=A218700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218700.Bytes);
public long this[int i]=>Value[i];

public static A218700Inst Instance=new A218700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218701
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,4L,2L,5L,5L,8L,7L,14L,11L,16L,19L,23L,22L,32L,29L,38L,40L,48L,48L,67L,63L,81L,85L,106L,106L,141L,138L,174L,180L,219L,224L,284L,282L,342L,356L,422L,431L,530L,532L,631L,660L,765L,789L,948L,965L,1123L,1184L,1356L,1408L,1658L,1703L,1967L,2076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218701Inst : IEnumerable<long>
{
public static readonly long[] Value=A218701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218701.Bytes);
public long this[int i]=>Value[i];

public static A218701Inst Instance=new A218701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218702
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,4L,2L,4L,4L,6L,6L,11L,10L,13L,16L,19L,20L,25L,27L,33L,34L,39L,41L,51L,52L,61L,65L,80L,82L,99L,104L,126L,133L,156L,168L,199L,209L,243L,261L,302L,320L,372L,392L,447L,479L,537L,572L,650L,693L,770L,829L,920L,982L,1096L,1169L,1306L,1396L,1541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218702Inst : IEnumerable<long>
{
public static readonly long[] Value=A218702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218702.Bytes);
public long this[int i]=>Value[i];

public static A218702Inst Instance=new A218702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218703
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,4L,2L,4L,3L,5L,4L,10L,7L,12L,13L,17L,16L,23L,21L,30L,30L,34L,35L,47L,43L,51L,52L,66L,63L,81L,77L,100L,99L,120L,121L,156L,150L,185L,189L,234L,230L,283L,281L,343L,350L,409L,414L,503L,497L,587L,600L,695L,703L,824L,830L,967L,988L,1122L,1148L,1333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218703Inst : IEnumerable<long>
{
public static readonly long[] Value=A218703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218703.Bytes);
public long this[int i]=>Value[i];

public static A218703Inst Instance=new A218703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218704
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,4L,2L,4L,3L,4L,3L,8L,6L,9L,12L,14L,14L,20L,19L,24L,28L,29L,31L,41L,40L,44L,49L,54L,54L,69L,64L,77L,82L,94L,98L,119L,118L,139L,149L,173L,178L,215L,217L,253L,274L,306L,320L,375L,385L,440L,469L,521L,545L,626L,647L,718L,769L,838L,881L,994L,1026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218704Inst : IEnumerable<long>
{
public static readonly long[] Value=A218704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218704.Bytes);
public long this[int i]=>Value[i];

public static A218704Inst Instance=new A218704Inst();

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