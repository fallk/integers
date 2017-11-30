using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A196005
{
public static readonly long[] Value={ 9L,6L,30L,14L,63L,36L,108L,44L,165L,90L,65L,234L,40L,315L,168L,119L,408L,45L,70L,152L,513L,270L,630L,230L,759L,396L,275L,105L,154L,546L,377L,208L,434L,720L,189L,560L,55L,629L,340L,779L,297L,68L,418L,91L,99L,95L,429L,598L,700L,156L,585L,161L,187L,135L,765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196005Inst : IEnumerable<long>
{
public static readonly long[] Value=A196005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196005.Bytes);
public long this[int i]=>Value[i];

public static A196005Inst Instance=new A196005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196006
{
public static readonly long[] Value={ 11L,9L,33L,19L,67L,41L,113L,51L,171L,97L,73L,241L,51L,323L,177L,129L,417L,59L,83L,163L,523L,281L,641L,243L,771L,409L,289L,123L,171L,561L,393L,227L,451L,737L,211L,579L,89L,649L,363L,801L,323L,107L,443L,129L,139L,137L,459L,627L,731L,201L,619L,209L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196006Inst : IEnumerable<long>
{
public static readonly long[] Value=A196006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196006.Bytes);
public long this[int i]=>Value[i];

public static A196006Inst Instance=new A196006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196007
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,10L,12L,15L,16L,17L,21L,22L,23L,24L,25L,26L,29L,32L,36L,37L,39L,42L,45L,49L,50L,51L,54L,58L,59L,60L,61L,64L,67L,68L,71L,72L,73L,75L,77L,78L,79L,80L,84L,86L,89L,91L,92L,94L,101L,105L,106L,108L,112L,113L,114L,115L,117L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196007Inst : IEnumerable<long>
{
public static readonly long[] Value=A196007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196007.Bytes);
public long this[int i]=>Value[i];

public static A196007Inst Instance=new A196007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196008
{
public static readonly long[] Value={ 3L,5L,6L,7L,8L,8L,9L,9L,10L,11L,12L,13L,14L,15L,15L,15L,16L,16L,17L,18L,18L,19L,20L,21L,21L,21L,22L,24L,24L,24L,25L,25L,26L,27L,27L,27L,27L,28L,30L,30L,30L,31L,32L,32L,32L,33L,33L,35L,35L,35L,35L,36L,36L,37L,38L,39L,39L,40L,40L,40L,40L,42L,42L,42L,43L,45L,45L,45L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196008Inst : IEnumerable<long>
{
public static readonly long[] Value=A196008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196008.Bytes);
public long this[int i]=>Value[i];

public static A196008Inst Instance=new A196008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196009
{
public static readonly long[] Value={ 5L,27L,10L,9L,9L,21L,15L,32L,54L,120L,20L,24L,18L,16L,25L,81L,18L,42L,279L,30L,64L,45L,108L,27L,35L,152L,240L,27L,40L,63L,72L,135L,48L,40L,45L,96L,245L,36L,32L,50L,162L,105L,36L,84L,261L,55L,360L,45L,48L,72L,189L,60L,128L,144L,90L,65L,72L,45L,63L,105L,216L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196009Inst : IEnumerable<long>
{
public static readonly long[] Value=A196009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196009.Bytes);
public long this[int i]=>Value[i];

public static A196009Inst Instance=new A196009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196010
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,32L,126L,842L,6594L,50654L,437802L,3962082L,38901699L,398593494L,4291288911L,48518097812L,571756012282L,7011537065184L,89099102516820L,1171925227051470L,15914369767022370L,222668594799098538L,3205203680348068734L,BigInteger.Parse("47392228013770511784") };
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
public class A196010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196010Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196010.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196010.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196010Inst Instance=new A196010Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196011
{
public static readonly long[] Value={ 1L,1L,2L,25L,106L,708L,22711L,670449L,44864449L,5122273171L,1106078073333L,426788297174150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196011Inst : IEnumerable<long>
{
public static readonly long[] Value=A196011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196011.Bytes);
public long this[int i]=>Value[i];

public static A196011Inst Instance=new A196011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196012
{
public static readonly long[] Value={ 1L,1L,2L,7L,13L,16L,32L,65L,125L,211L,390L,732L,1368L,2478L,4555L,8417L,15564L,28583L,52598L,96921L,178684L,328956L,605723L,1115678L,2055336L,3785356L,6971537L,12840292L,23650713L,43560381L,80229677L,147768685L,272167135L,501285666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196012Inst : IEnumerable<long>
{
public static readonly long[] Value=A196012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196012.Bytes);
public long this[int i]=>Value[i];

public static A196012Inst Instance=new A196012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196013
{
public static readonly long[] Value={ 1L,1L,7L,25L,27L,91L,231L,455L,1135L,2693L,6041L,14257L,33349L,76941L,179553L,418345L,971503L,2261807L,5264419L,12243481L,28490729L,66295633L,154236017L,358872825L,835013523L,1942797397L,4520363539L,10517663443L,24471508585L,56938341019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196013Inst : IEnumerable<long>
{
public static readonly long[] Value=A196013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196013.Bytes);
public long this[int i]=>Value[i];

public static A196013Inst Instance=new A196013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196014
{
public static readonly long[] Value={ 1L,3L,13L,27L,106L,316L,835L,2350L,7232L,21846L,63985L,186029L,548387L,1625398L,4800819L,14129048L,41608725L,122724222L,362055916L,1067475979L,3146535362L,9276448225L,27352573231L,80649512515L,237779505381L,701041117758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196014Inst : IEnumerable<long>
{
public static readonly long[] Value=A196014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196014.Bytes);
public long this[int i]=>Value[i];

public static A196014Inst Instance=new A196014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196015
{
public static readonly long[] Value={ 1L,5L,16L,91L,316L,708L,3572L,14607L,54710L,196832L,782926L,3062632L,11714725L,44732791L,173085686L,668753382L,2573295221L,9902406595L,38178807169L,147173375542L,566944981911L,2184078533126L,8416292695545L,32431165832934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196015Inst : IEnumerable<long>
{
public static readonly long[] Value=A196015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196015.Bytes);
public long this[int i]=>Value[i];

public static A196015Inst Instance=new A196015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196016
{
public static readonly long[] Value={ 1L,9L,32L,231L,835L,3572L,22711L,100094L,517009L,2740712L,14291156L,72486659L,375604408L,1948549100L,10070403094L,52010772351L,269069912146L,1391421035119L,7193724490586L,37198028475134L,192356730926735L,994618459574872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196016Inst : IEnumerable<long>
{
public static readonly long[] Value=A196016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196016.Bytes);
public long this[int i]=>Value[i];

public static A196016Inst Instance=new A196016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196017
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,7L,7L,3L,1L,1L,5L,13L,25L,13L,5L,1L,1L,9L,16L,27L,27L,16L,9L,1L,1L,17L,32L,91L,106L,91L,32L,17L,1L,1L,31L,65L,231L,316L,316L,231L,65L,31L,1L,1L,57L,125L,455L,835L,708L,835L,455L,125L,57L,1L,1L,105L,211L,1135L,2350L,3572L,3572L,2350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196017Inst : IEnumerable<long>
{
public static readonly long[] Value=A196017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196017.Bytes);
public long this[int i]=>Value[i];

public static A196017Inst Instance=new A196017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196018
{
public static readonly long[] Value={ 1L,1L,2L,6L,23L,98L,440L,2044L,9742L,47384L,234289L,1174214L,5951877L,30459550L,157168265L,816777857L,4271248777L,22459464722L,118678530165L,629867928597L,3356148860975L,17946684482409L,96280344449069L,518058601390577L,2795121781871727L,15118502434518352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196018Inst : IEnumerable<long>
{
public static readonly long[] Value=A196018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196018.Bytes);
public long this[int i]=>Value[i];

public static A196018Inst Instance=new A196018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196019
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,5L,1L,1L,15L,9L,1L,1L,35L,50L,14L,1L,1L,70L,207L,113L,20L,1L,1L,126L,694L,672L,217L,27L,1L,1L,210L,1986L,3215L,1690L,376L,35L,1L,1L,330L,5028L,12969L,10484L,3663L,606L,44L,1L,1L,495L,11550L,45529L,54588L,28045L,7170L,925L,54L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196019Inst : IEnumerable<long>
{
public static readonly long[] Value=A196019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196019.Bytes);
public long this[int i]=>Value[i];

public static A196019Inst Instance=new A196019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196020
{
public static readonly long[] Value={ 1L,3L,5L,1L,7L,0L,9L,3L,11L,0L,1L,13L,5L,0L,15L,0L,0L,17L,7L,3L,19L,0L,0L,1L,21L,9L,0L,0L,23L,0L,5L,0L,25L,11L,0L,0L,27L,0L,0L,3L,29L,13L,7L,0L,1L,31L,0L,0L,0L,0L,33L,15L,0L,0L,0L,35L,0L,9L,5L,0L,37L,17L,0L,0L,0L,39L,0L,0L,0L,3L,41L,19L,11L,0L,0L,1L,43L,0L,0L,7L,0L,0L,45L,21L,0L,0L,0L,0L,47L,0L,13L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196020Inst : IEnumerable<long>
{
public static readonly long[] Value=A196020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196020.Bytes);
public long this[int i]=>Value[i];

public static A196020Inst Instance=new A196020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196021
{
public static readonly long[] Value={ 1L,1L,4L,5L,16L,22L,64L,109L,283L,486L,1189L,2174L,5097L,9528L,21904L,41549L,92022L,177043L,387715L,754910L,1624543L,3174095L,6751375L,13296454L,27962241L,55173405L,115220461L,228121892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196021Inst : IEnumerable<long>
{
public static readonly long[] Value=A196021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196021.Bytes);
public long this[int i]=>Value[i];

public static A196021Inst Instance=new A196021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196022
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,269L,4676L,106027L,2966909L,98814921L,3818572219L,167999566061L,8292669672343L,453958089569833L,27300462412168531L,1789601591598075179L,BigInteger.Parse("127031469572649790786"),BigInteger.Parse("9709396866317453042033"),BigInteger.Parse("795229841271312470470904"),BigInteger.Parse("69499103185446754949076817") };
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
public class A196022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196022Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196022.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196022.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196022Inst Instance=new A196022Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196023
{
public static readonly long[] Value={ 16661L,76667L,3166613L,3466643L,7466647L,7666667L,145666541L,148666841L,152666251L,155666551L,169666961L,176666671L,181666181L,304666403L,305666503L,307666703L,308666803L,329666923L,347666743L,349666943L,373666373L,374666473L,383666383L,391666193L,397666793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196023Inst : IEnumerable<long>
{
public static readonly long[] Value=A196023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196023.Bytes);
public long this[int i]=>Value[i];

public static A196023Inst Instance=new A196023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196024
{
public static readonly long[] Value={ 1L,2L,8L,13L,21L,55L,233L,1597L,4181L,28657L,121393L,196418L,317811L,1346269L,2178309L,3524578L,9227465L,165580141L,1134903170L,1836311903L,2971215073L,20365011074L,32951280099L,53316291173L,225851433717L,2504730781961L,6557470319842L,17167680177565L,27777890035288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196024Inst : IEnumerable<long>
{
public static readonly long[] Value=A196024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196024.Bytes);
public long this[int i]=>Value[i];

public static A196024Inst Instance=new A196024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196025
{
public static readonly long[] Value={ 0L,0L,0L,2L,5L,16L,30L,63L,108L,189L,298L,483L,720L,1092L,1582L,2297L,3225L,4551L,6244L,8592L,11590L,15622L,20741L,27536L,36066L,47198L,61150L,79077L,101391L,129808L,164934L,209213L,263745L,331807L,415229L,518656L,644719L,799926L,988432L,1218979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196025Inst : IEnumerable<long>
{
public static readonly long[] Value=A196025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196025.Bytes);
public long this[int i]=>Value[i];

public static A196025Inst Instance=new A196025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196026
{
public static readonly long[] Value={ 5L,6L,7L,9L,10L,11L,12L,13L,14L,14L,15L,16L,17L,18L,18L,19L,20L,21L,21L,22L,22L,23L,24L,25L,25L,25L,26L,26L,27L,28L,28L,29L,30L,30L,30L,31L,32L,32L,33L,34L,34L,35L,35L,35L,36L,36L,37L,38L,38L,38L,39L,40L,41L,42L,42L,42L,43L,44L,44L,45L,45L,46L,46L,47L,48L,48L,48L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196026Inst : IEnumerable<long>
{
public static readonly long[] Value=A196026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196026.Bytes);
public long this[int i]=>Value[i];

public static A196026Inst Instance=new A196026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196027
{
public static readonly long[] Value={ 22L,13L,10L,80L,44L,32L,26L,174L,20L,93L,66L,17L,304L,39L,160L,112L,88L,30L,470L,64L,245L,170L,52L,48L,110L,672L,95L,348L,240L,40L,186L,70L,65L,132L,469L,322L,34L,105L,96L,175L,608L,50L,154L,416L,78L,320L,126L,45L,224L,765L,522L,176L,160L,60L,91L,279L,640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196027Inst : IEnumerable<long>
{
public static readonly long[] Value=A196027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196027.Bytes);
public long this[int i]=>Value[i];

public static A196027Inst Instance=new A196027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196028
{
public static readonly long[] Value={ 28L,20L,18L,91L,56L,45L,40L,190L,36L,110L,84L,35L,325L,60L,182L,135L,112L,54L,496L,90L,272L,198L,80L,77L,140L,703L,126L,380L,273L,72L,220L,104L,100L,168L,506L,360L,70L,143L,135L,216L,650L,90L,196L,459L,120L,364L,170L,88L,270L,812L,570L,224L,209L,108L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196028Inst : IEnumerable<long>
{
public static readonly long[] Value=A196028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196028.Bytes);
public long this[int i]=>Value[i];

public static A196028Inst Instance=new A196028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196029
{
public static readonly long[] Value={ 5L,6L,7L,9L,11L,13L,14L,16L,17L,19L,21L,22L,23L,25L,25L,26L,29L,30L,31L,32L,34L,35L,37L,38L,38L,41L,43L,46L,47L,48L,49L,50L,53L,58L,61L,62L,64L,64L,65L,65L,70L,73L,77L,80L,80L,85L,85L,86L,94L,105L,105L,110L,110L,112L,112L,118L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196029Inst : IEnumerable<long>
{
public static readonly long[] Value=A196029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196029.Bytes);
public long this[int i]=>Value[i];

public static A196029Inst Instance=new A196029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196030
{
public static readonly long[] Value={ 22L,13L,10L,80L,32L,174L,93L,17L,304L,112L,470L,245L,170L,48L,672L,95L,70L,469L,322L,105L,175L,416L,126L,45L,765L,160L,640L,77L,770L,265L,240L,407L,286L,559L,390L,165L,115L,497L,112L,448L,221L,576L,646L,129L,203L,222L,798L,357L,437L,128L,368L,141L,621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196030Inst : IEnumerable<long>
{
public static readonly long[] Value=A196030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196030.Bytes);
public long this[int i]=>Value[i];

public static A196030Inst Instance=new A196030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196031
{
public static readonly long[] Value={ 28L,20L,18L,91L,45L,190L,110L,35L,325L,135L,496L,272L,198L,77L,703L,126L,104L,506L,360L,143L,216L,459L,170L,88L,812L,209L,693L,130L,828L,323L,299L,468L,350L,630L,464L,238L,189L,575L,187L,527L,304L,665L,740L,221L,297L,322L,902L,460L,550L,247L,493L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196031Inst : IEnumerable<long>
{
public static readonly long[] Value=A196031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196031.Bytes);
public long this[int i]=>Value[i];

public static A196031Inst Instance=new A196031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196032
{
public static readonly long[] Value={ 4L,8L,12L,16L,17L,18L,19L,20L,24L,28L,32L,33L,34L,35L,36L,40L,44L,48L,49L,50L,51L,52L,56L,60L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,88L,92L,96L,97L,98L,99L,100L,104L,108L,112L,113L,114L,115L,116L,120L,124L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196032Inst : IEnumerable<long>
{
public static readonly long[] Value=A196032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196032.Bytes);
public long this[int i]=>Value[i];

public static A196032Inst Instance=new A196032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196033
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,8L,8L,9L,9L,10L,11L,12L,12L,13L,14L,15L,15L,16L,16L,16L,17L,18L,18L,19L,20L,20L,21L,21L,21L,22L,23L,24L,24L,24L,24L,25L,26L,27L,27L,27L,27L,28L,28L,28L,28L,29L,30L,30L,31L,32L,32L,32L,32L,33L,33L,33L,34L,35L,35L,35L,36L,36L,36L,36L,36L,36L,37L,38L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196033Inst : IEnumerable<long>
{
public static readonly long[] Value=A196033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196033.Bytes);
public long this[int i]=>Value[i];

public static A196033Inst Instance=new A196033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196034
{
public static readonly long[] Value={ 4L,9L,24L,8L,12L,9L,18L,12L,28L,48L,108L,16L,27L,36L,24L,20L,72L,18L,36L,117L,252L,24L,56L,72L,45L,96L,28L,36L,136L,216L,456L,27L,32L,54L,95L,120L,72L,36L,56L,84L,220L,48L,63L,99L,345L,720L,40L,144L,180L,36L,72L,105L,234L,44L,80L,324L,504L,36L,60L,168L,48L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196034Inst : IEnumerable<long>
{
public static readonly long[] Value=A196034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196034.Bytes);
public long this[int i]=>Value[i];

public static A196034Inst Instance=new A196034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196035
{
public static readonly long[] Value={ 3L,7L,21L,6L,9L,7L,14L,9L,23L,42L,101L,12L,21L,29L,18L,15L,63L,14L,28L,107L,241L,18L,46L,61L,35L,84L,21L,27L,123L,202L,441L,21L,24L,42L,81L,105L,58L,27L,43L,69L,203L,36L,49L,83L,327L,701L,30L,126L,161L,28L,56L,87L,214L,33L,63L,303L,482L,29L,45L,147L,36L,41L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196035Inst : IEnumerable<long>
{
public static readonly long[] Value=A196035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196035.Bytes);
public long this[int i]=>Value[i];

public static A196035Inst Instance=new A196035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196036
{
public static readonly long[] Value={ 3L,4L,5L,7L,8L,9L,11L,13L,16L,17L,19L,21L,23L,24L,27L,27L,28L,28L,29L,31L,32L,33L,35L,36L,36L,36L,37L,39L,40L,40L,43L,44L,44L,45L,45L,48L,49L,51L,52L,56L,60L,60L,61L,63L,63L,67L,68L,68L,69L,72L,72L,72L,72L,76L,77L,81L,84L,84L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196036Inst : IEnumerable<long>
{
public static readonly long[] Value=A196036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196036.Bytes);
public long this[int i]=>Value[i];

public static A196036Inst Instance=new A196036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196037
{
public static readonly long[] Value={ 4L,9L,24L,12L,9L,28L,108L,36L,117L,252L,72L,136L,456L,95L,56L,220L,99L,345L,720L,180L,105L,80L,36L,55L,65L,203L,252L,448L,63L,693L,336L,63L,189L,88L,592L,91L,432L,176L,315L,297L,161L,539L,660L,160L,260L,792L,135L,429L,308L,77L,119L,187L,767L,651L,144L,416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196037Inst : IEnumerable<long>
{
public static readonly long[] Value=A196037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196037.Bytes);
public long this[int i]=>Value[i];

public static A196037Inst Instance=new A196037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196038
{
public static readonly long[] Value={ 3L,7L,21L,9L,7L,23L,101L,29L,107L,241L,61L,123L,441L,81L,43L,203L,83L,327L,701L,161L,87L,63L,29L,41L,49L,181L,229L,423L,47L,667L,309L,47L,163L,67L,563L,69L,401L,147L,283L,263L,129L,501L,621L,127L,223L,749L,103L,387L,267L,61L,89L,149L,721L,603L,109L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196038Inst : IEnumerable<long>
{
public static readonly long[] Value=A196038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196038.Bytes);
public long this[int i]=>Value[i];

public static A196038Inst Instance=new A196038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196039
{
public static readonly long[] Value={ 0L,1L,4L,9L,18L,30L,50L,75L,113L,162L,231L,318L,441L,593L,798L,1058L,1399L,1824L,2379L,3066L,3948L,5042L,6422L,8124L,10264L,12884L,16138L,20120L,25027L,30994L,38312L,47168L,57955L,70974L,86733L,105676L,128516L,155850L,188644L,227783L,274541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196039Inst : IEnumerable<long>
{
public static readonly long[] Value=A196039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196039.Bytes);
public long this[int i]=>Value[i];

public static A196039Inst Instance=new A196039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196040
{
public static readonly long[] Value={ 7L,8L,9L,11L,13L,14L,15L,16L,17L,18L,19L,20L,20L,21L,22L,23L,24L,26L,27L,27L,28L,28L,29L,30L,32L,33L,33L,34L,35L,36L,36L,39L,39L,40L,40L,40L,41L,42L,44L,44L,45L,45L,46L,47L,48L,48L,49L,51L,52L,54L,54L,55L,56L,56L,56L,57L,58L,60L,60L,63L,63L,63L,63L,64L,64L,66L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196040Inst : IEnumerable<long>
{
public static readonly long[] Value=A196040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196040.Bytes);
public long this[int i]=>Value[i];

public static A196040Inst Instance=new A196040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196041
{
public static readonly long[] Value={ 36L,21L,16L,12L,132L,72L,52L,42L,36L,32L,288L,27L,153L,108L,24L,72L,63L,264L,48L,184L,45L,144L,120L,104L,84L,36L,280L,72L,180L,64L,155L,56L,396L,54L,105L,306L,252L,216L,48L,171L,80L,156L,144L,336L,126L,287L,252L,108L,189L,96L,368L,60L,90L,147L,288L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196041Inst : IEnumerable<long>
{
public static readonly long[] Value=A196041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196041.Bytes);
public long this[int i]=>Value[i];

public static A196041Inst Instance=new A196041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196042
{
public static readonly long[] Value={ 41L,27L,23L,21L,141L,82L,63L,54L,49L,46L,301L,43L,167L,123L,42L,89L,81L,282L,69L,203L,67L,164L,141L,126L,108L,63L,303L,98L,205L,92L,181L,87L,423L,86L,135L,334L,281L,246L,84L,203L,115L,189L,178L,369L,162L,321L,287L,147L,227L,138L,406L,105L,134L,189L,328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196042Inst : IEnumerable<long>
{
public static readonly long[] Value=A196042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196042.Bytes);
public long this[int i]=>Value[i];

public static A196042Inst Instance=new A196042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196043
{
public static readonly long[] Value={ 7L,8L,9L,11L,13L,15L,17L,19L,20L,20L,23L,25L,27L,28L,29L,31L,32L,33L,36L,39L,41L,44L,44L,45L,47L,48L,51L,52L,53L,57L,59L,63L,63L,64L,68L,71L,72L,72L,76L,81L,84L,88L,92L,93L,96L,99L,99L,104L,108L,108L,111L,117L,117L,124L,129L,132L,133L,144L,144L,148L,152L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196043Inst : IEnumerable<long>
{
public static readonly long[] Value=A196043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196043.Bytes);
public long this[int i]=>Value[i];

public static A196043Inst Instance=new A196043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196044
{
public static readonly long[] Value={ 36L,21L,16L,12L,132L,52L,36L,288L,27L,153L,72L,504L,184L,45L,120L,780L,405L,280L,155L,56L,252L,171L,777L,532L,336L,287L,688L,189L,432L,140L,540L,76L,176L,297L,435L,792L,91L,671L,429L,308L,185L,585L,819L,416L,187L,232L,476L,207L,247L,329L,608L,340L,680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196044Inst : IEnumerable<long>
{
public static readonly long[] Value=A196044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196044.Bytes);
public long this[int i]=>Value[i];

public static A196044Inst Instance=new A196044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196045
{
public static readonly long[] Value={ 41L,27L,23L,21L,141L,63L,49L,301L,43L,167L,89L,521L,203L,67L,141L,801L,427L,303L,181L,87L,281L,203L,807L,563L,369L,321L,723L,227L,469L,183L,581L,127L,223L,343L,483L,841L,149L,721L,483L,367L,249L,647L,883L,483L,261L,307L,547L,287L,329L,409L,687L,427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196045Inst : IEnumerable<long>
{
public static readonly long[] Value=A196045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196045.Bytes);
public long this[int i]=>Value[i];

public static A196045Inst Instance=new A196045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196046
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,2L,3L,3L,2L,2L,2L,3L,3L,3L,2L,4L,3L,3L,4L,3L,3L,2L,3L,4L,2L,3L,3L,3L,3L,3L,2L,5L,2L,3L,3L,4L,4L,4L,3L,4L,3L,3L,3L,3L,3L,3L,3L,5L,3L,3L,3L,3L,5L,4L,2L,4L,4L,3L,3L,4L,4L,2L,3L,6L,3L,3L,4L,3L,3L,3L,4L,5L,3L,4L,3L,4L,3L,3L,3L,5L,4L,3L,3L,4L,3L,3L,3L,4L,5L,4L,3L,3L,2L,3L,4L,6L,3L,3L,3L,4L,3L,3L,4L,4L,3L,5L,4L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196046Inst : IEnumerable<long>
{
public static readonly long[] Value=A196046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196046.Bytes);
public long this[int i]=>Value[i];

public static A196046Inst Instance=new A196046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196047
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,4L,5L,3L,6L,7L,10L,5L,8L,6L,9L,4L,9L,7L,7L,8L,8L,11L,11L,6L,12L,9L,9L,7L,12L,10L,15L,5L,13L,10L,11L,8L,10L,8L,11L,9L,13L,9L,11L,12L,12L,12L,15L,7L,10L,13L,12L,10L,9L,10L,16L,8L,10L,13L,14L,11L,13L,16L,11L,6L,14L,14L,12L,11L,14L,12L,14L,9L,14L,11L,15L,9L,15L,12L,17L,10L,12L,14L,17L,10L,15L,12L,15L,13L,12L,13L,13L,13L,18L,16L,13L,8L,19L,11L,16L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196047Inst : IEnumerable<long>
{
public static readonly long[] Value=A196047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196047.Bytes);
public long this[int i]=>Value[i];

public static A196047Inst Instance=new A196047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196048
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,3L,4L,4L,4L,4L,5L,5L,5L,4L,6L,5L,6L,5L,6L,5L,6L,5L,6L,6L,6L,6L,6L,6L,5L,5L,6L,7L,7L,6L,7L,7L,7L,6L,7L,7L,8L,6L,7L,7L,7L,6L,8L,7L,8L,7L,8L,7L,7L,7L,8L,7L,8L,7L,8L,6L,8L,6L,8L,7L,9L,8L,8L,8L,8L,7L,9L,8L,8L,8L,8L,8L,7L,7L,8L,8L,8L,8L,9L,9L,8L,7L,9L,8L,9L,8L,7L,8L,9L,7L,8L,9L,8L,8L,9L,9L,9L,8L,9L,9L,10L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196048Inst : IEnumerable<long>
{
public static readonly long[] Value=A196048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196048.Bytes);
public long this[int i]=>Value[i];

public static A196048Inst Instance=new A196048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196049
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,2L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,0L,2L,1L,1L,1L,1L,1L,0L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,2L,0L,1L,1L,1L,1L,3L,1L,1L,2L,2L,1L,2L,2L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196049Inst : IEnumerable<long>
{
public static readonly long[] Value=A196049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196049.Bytes);
public long this[int i]=>Value[i];

public static A196049Inst Instance=new A196049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196050
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,4L,4L,5L,4L,5L,5L,5L,5L,5L,6L,5L,6L,5L,5L,6L,5L,5L,6L,5L,6L,6L,5L,5L,6L,6L,5L,6L,5L,6L,7L,6L,6L,6L,6L,7L,6L,6L,5L,7L,7L,6L,6L,6L,5L,7L,6L,6L,7L,6L,7L,7L,5L,6L,7L,7L,6L,7L,6L,6L,8L,6L,7L,7L,6L,7L,8L,6L,6L,7L,7L,6L,7L,7L,6L,8L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,6L,7L,7L,7L,8L,6L,6L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196050Inst : IEnumerable<long>
{
public static readonly long[] Value=A196050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196050.Bytes);
public long this[int i]=>Value[i];

public static A196050Inst Instance=new A196050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196051
{
public static readonly long[] Value={ 0L,1L,4L,4L,10L,10L,9L,9L,20L,20L,20L,18L,18L,18L,35L,16L,18L,31L,16L,32L,32L,35L,31L,28L,56L,31L,48L,29L,32L,50L,35L,25L,56L,32L,52L,44L,28L,28L,50L,46L,31L,46L,29L,52L,72L,48L,50L,40L,48L,75L,52L,46L,25L,64L,84L,42L,46L,50L,32L,67L,44L,56L,67L,36L,76L,76L,28L,48L,72L,70L,46L,59L,46L,44L,102L,42L,79L,68L,52L,62L,88L,50L,48L,62L,79L,46L,75L,71L,40L,92L,71L,67L,84L,72L,71L,54L,75L,65L,104L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196051Inst : IEnumerable<long>
{
public static readonly long[] Value=A196051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196051.Bytes);
public long this[int i]=>Value[i];

public static A196051Inst Instance=new A196051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196052
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,3L,3L,4L,3L,2L,4L,3L,4L,4L,4L,2L,5L,4L,4L,5L,3L,3L,5L,4L,4L,6L,5L,3L,5L,2L,5L,4L,3L,5L,6L,4L,5L,5L,5L,2L,6L,3L,4L,6L,4L,3L,6L,6L,5L,4L,5L,5L,7L,4L,6L,6L,4L,2L,6L,4L,3L,7L,6L,5L,5L,2L,4L,5L,6L,4L,7L,3L,5L,6L,6L,5L,6L,3L,6L,8L,3L,2L,7L,4L,4L,5L,5L,5L,7L,6L,5L,4L,4L,6L,7L,3L,7L,6L,6L,3L,5L,4L,6L,7L,6L,4L,8L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196052Inst : IEnumerable<long>
{
public static readonly long[] Value=A196052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196052.Bytes);
public long this[int i]=>Value[i];

public static A196052Inst Instance=new A196052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196053
{
public static readonly long[] Value={ 0L,2L,6L,6L,10L,10L,12L,12L,14L,14L,14L,16L,16L,16L,18L,20L,16L,20L,20L,20L,20L,18L,20L,24L,22L,20L,24L,22L,20L,24L,18L,30L,22L,20L,24L,28L,24L,24L,24L,28L,20L,26L,22L,24L,28L,24L,24L,34L,26L,28L,24L,26L,30L,32L,26L,30L,28L,24L,20L,32L,28L,22L,30L,42L,28L,28L,24L,26L,28L,30L,28L,38L,26L,28L,32L,30L,28L,30L,24L,38L,36L,24L,24L,34L,28L,26L,28L,32L,34L,36L,30L,30L,26L,28L,32L,46L,28L,32L,32L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196053Inst : IEnumerable<long>
{
public static readonly long[] Value=A196053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196053.Bytes);
public long this[int i]=>Value[i];

public static A196053Inst Instance=new A196053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196054
{
public static readonly long[] Value={ 0L,1L,4L,4L,8L,8L,9L,9L,12L,12L,12L,14L,14L,14L,16L,16L,14L,19L,16L,18L,18L,16L,19L,22L,20L,19L,24L,21L,18L,23L,16L,25L,20L,18L,22L,28L,22L,22L,23L,26L,19L,26L,21L,22L,28L,24L,23L,32L,24L,27L,22L,26L,25L,34L,24L,30L,26L,23L,18L,32L,28L,20L,31L,36L,27L,27L,22L,24L,28L,30L,26L,39L,26L,28L,32L,30L,26L,31L,22L,36L,40L,23L,24L,36L,26L,26L,27L,30L,32L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196054Inst : IEnumerable<long>
{
public static readonly long[] Value=A196054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196054.Bytes);
public long this[int i]=>Value[i];

public static A196054Inst Instance=new A196054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196055
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,6L,6L,4L,4L,4L,8L,8L,8L,5L,12L,8L,10L,12L,10L,10L,5L,10L,15L,6L,10L,12L,16L,10L,12L,5L,20L,6L,10L,12L,18L,15L,15L,12L,18L,10L,19L,16L,12L,14L,12L,12L,24L,20L,14L,12L,19L,20L,21L,7L,26L,18L,12L,10L,21L,18L,6L,22L,30L,14L,14L,15L,20L,14L,22L,18L,28L,19L,18L,16L,26L,14L,22L,12L,28L,24L,12L,12L,30L,14L,19L,14L,21L,24L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196055Inst : IEnumerable<long>
{
public static readonly long[] Value=A196055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196055.Bytes);
public long this[int i]=>Value[i];

public static A196055Inst Instance=new A196055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196056
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,3L,2L,2L,2L,1L,1L,1L,1L,1L,1L,3L,1L,1L,2L,1L,2L,2L,2L,2L,1L,4L,1L,1L,2L,3L,2L,1L,3L,3L,1L,1L,2L,3L,2L,1L,1L,1L,1L,2L,2L,4L,1L,2L,2L,2L,2L,2L,1L,3L,3L,3L,2L,1L,2L,1L,1L,3L,2L,1L,1L,1L,1L,1L,1L,5L,2L,2L,1L,1L,2L,1L,2L,2L,3L,1L,4L,2L,1L,3L,1L,2L,3L,2L,3L,1L,4L,1L,1L,1L,1L,2L,1L,3L,3L,1L,2L,2L,3L,1L,1L,1L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196056Inst : IEnumerable<long>
{
public static readonly long[] Value=A196056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196056.Bytes);
public long this[int i]=>Value[i];

public static A196056Inst Instance=new A196056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196057
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,1L,3L,1L,1L,0L,3L,1L,2L,1L,6L,1L,3L,3L,3L,2L,1L,1L,6L,1L,2L,3L,4L,1L,3L,0L,10L,1L,2L,2L,6L,3L,4L,2L,6L,1L,4L,2L,3L,3L,2L,1L,10L,3L,3L,2L,4L,6L,6L,1L,7L,4L,2L,1L,6L,3L,1L,4L,15L,2L,3L,3L,4L,2L,4L,3L,10L,2L,4L,3L,6L,2L,4L,1L,10L,6L,2L,1L,7L,2L,3L,2L,6L,6L,6L,3L,4L,1L,2L,4L,15L,1L,5L,3L,6L,2L,4L,3L,7L,4L,7L,4L,10L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196057Inst : IEnumerable<long>
{
public static readonly long[] Value=A196057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196057.Bytes);
public long this[int i]=>Value[i];

public static A196057Inst Instance=new A196057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196058
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,2L,2L,4L,4L,4L,3L,3L,3L,5L,2L,3L,4L,2L,4L,4L,5L,4L,3L,6L,4L,4L,3L,4L,5L,5L,2L,6L,4L,5L,4L,3L,3L,5L,4L,4L,4L,3L,5L,5L,4L,5L,3L,4L,6L,5L,4L,2L,4L,7L,3L,4L,5L,4L,5L,4L,6L,4L,2L,6L,6L,3L,4L,5L,5L,4L,4L,4L,4L,6L,3L,6L,5L,5L,4L,4L,5L,4L,4L,6L,4L,6L,5L,3L,5L,5L,4L,7L,5L,5L,3L,6L,4L,6L,6L,4L,5L,4L,4L,5L,3L,3L,4L,5L,7L,5L,3L,5L,4L,6L,5L,5L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196058Inst : IEnumerable<long>
{
public static readonly long[] Value=A196058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196058.Bytes);
public long this[int i]=>Value[i];

public static A196058Inst Instance=new A196058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196059
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,2L,1L,3L,2L,1L,3L,3L,3L,3L,4L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,4L,2L,4L,4L,2L,4L,4L,2L,5L,4L,3L,2L,1L,4L,6L,4L,4L,2L,5L,5L,4L,1L,4L,6L,5L,5L,3L,2L,5L,5L,3L,2L,5L,4L,3L,2L,1L,5L,5L,4L,1L,5L,7L,3L,6L,5L,4L,3L,2L,1L,5L,5L,4L,1L,6L,6L,6L,3L,5L,6L,4L,5L,5L,3L,2L,6L,6L,5L,3L,1L,5L,4L,3L,2L,1L,5L,10L,6L,5L,4L,3L,2L,1L,5L,5L,3L,2L,6L,6L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196059Inst : IEnumerable<long>
{
public static readonly long[] Value=A196059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196059.Bytes);
public long this[int i]=>Value[i];

public static A196059Inst Instance=new A196059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196060
{
public static readonly long[] Value={ 0L,1L,5L,5L,15L,15L,12L,12L,35L,35L,35L,28L,28L,28L,70L,22L,28L,54L,22L,58L,58L,70L,54L,44L,126L,54L,90L,47L,58L,99L,70L,35L,126L,58L,108L,76L,44L,44L,99L,84L,54L,83L,47L,108L,150L,90L,99L,63L,91L,165L,108L,83L,35L,118L,210L,69L,84L,99L,58L,131L,76L,126L,129L,51L,170L,170L,44L,91L,150L,143L,84L,101L,83L,76L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196060Inst : IEnumerable<long>
{
public static readonly long[] Value=A196060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196060.Bytes);
public long this[int i]=>Value[i];

public static A196060Inst Instance=new A196060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196061
{
public static readonly long[] Value={ 1L,2L,2L,12L,12L,8L,8L,288L,288L,288L,144L,144L,144L,34560L,64L,144L,10368L,64L,13824L,13824L,34560L,10368L,3456L,24883200L,10368L,2985984L,5184L,13824L,4976640L,34560L,1024L,24883200L,13824L,8294400L,746496L,3456L,3456L,4976640L,1327104L,10368L,1492992L,5184L,8294400L,7166361600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196061Inst : IEnumerable<long>
{
public static readonly long[] Value=A196061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196061.Bytes);
public long this[int i]=>Value[i];

public static A196061Inst Instance=new A196061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196062
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,2L,2L,2L,1L,1L,3L,1L,2L,2L,2L,2L,2L,2L,3L,3L,2L,2L,3L,1L,1L,2L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,3L,2L,2L,2L,3L,2L,3L,1L,4L,2L,2L,2L,3L,1L,3L,3L,2L,3L,1L,3L,3L,1L,2L,3L,3L,2L,3L,2L,3L,3L,2L,2L,4L,2L,2L,4L,3L,2L,3L,2L,3L,3L,2L,2L,4L,3L,3L,2L,3L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,2L,2L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196062Inst : IEnumerable<long>
{
public static readonly long[] Value=A196062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196062.Bytes);
public long this[int i]=>Value[i];

public static A196062Inst Instance=new A196062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196063
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,4L,3L,3L,8L,8L,8L,6L,6L,6L,16L,4L,6L,12L,4L,12L,12L,16L,12L,8L,32L,12L,24L,9L,12L,24L,16L,5L,32L,12L,24L,16L,8L,8L,24L,16L,12L,18L,9L,24L,48L,24L,24L,10L,18L,48L,24L,18L,5L,32L,64L,12L,16L,24L,12L,32L,16L,32L,36L,6L,48L,48L,8L,18L,48L,36L,16L,20L,18L,16L,96L,12L,48L,36L,24L,20L,64L,24L,24L,24L,48L,18L,48L,32L,10L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196063Inst : IEnumerable<long>
{
public static readonly long[] Value=A196063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196063.Bytes);
public long this[int i]=>Value[i];

public static A196063Inst Instance=new A196063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196064
{
public static readonly long[] Value={ 0L,1L,4L,4L,16L,16L,27L,27L,64L,64L,64L,108L,108L,108L,256L,256L,108L,432L,256L,432L,432L,256L,432L,1024L,1024L,432L,1728L,729L,432L,1728L,256L,3125L,1024L,432L,1728L,4096L,1024L,1024L,1728L,4096L,432L,2916L,729L,1728L,6912L,1728L,1728L,12500L,2916L,6912L,1728L,2916L,3125L,16384L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196064Inst : IEnumerable<long>
{
public static readonly long[] Value=A196064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196064.Bytes);
public long this[int i]=>Value[i];

public static A196064Inst Instance=new A196064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196065
{
public static readonly long[] Value={ 0L,1L,4L,4L,16L,16L,9L,9L,64L,64L,64L,36L,36L,36L,256L,16L,36L,144L,16L,144L,144L,256L,144L,64L,1024L,144L,576L,81L,144L,576L,256L,25L,1024L,144L,576L,256L,64L,64L,576L,256L,144L,324L,81L,576L,2304L,576L,576L,100L,324L,2304L,576L,324L,25L,1024L,4096L,144L,256L,576L,144L,1024L,256L,1024L,1296L,36L,2304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196065Inst : IEnumerable<long>
{
public static readonly long[] Value=A196065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196065.Bytes);
public long this[int i]=>Value[i];

public static A196065Inst Instance=new A196065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196066
{
public static readonly long[] Value={ 0L,0L,2L,2L,8L,8L,3L,3L,20L,20L,20L,12L,12L,12L,40L,4L,12L,29L,4L,28L,28L,40L,29L,17L,70L,29L,36L,16L,28L,55L,40L,5L,70L,28L,53L,40L,17L,17L,55L,38L,29L,38L,16L,53L,68L,36L,55L,23L,36L,93L,53L,38L,5L,48L,112L,21L,38L,55L,28L,73L,40L,70L,45L,6L,92L,92L,17L,36L,68L,70L,38L,53L,38L,40L,114L,21L,89L,72L,53L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196066Inst : IEnumerable<long>
{
public static readonly long[] Value=A196066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196066.Bytes);
public long this[int i]=>Value[i];

public static A196066Inst Instance=new A196066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196067
{
public static readonly long[] Value={ 0L,2L,2L,2L,2L,2L,3L,3L,2L,2L,2L,3L,3L,3L,2L,4L,3L,3L,4L,3L,3L,2L,3L,4L,2L,3L,3L,4L,3L,3L,2L,5L,2L,3L,3L,4L,4L,4L,3L,4L,3L,4L,4L,3L,3L,3L,3L,5L,4L,3L,3L,4L,5L,4L,2L,5L,4L,3L,3L,4L,4L,2L,4L,6L,3L,3L,4L,4L,3L,4L,4L,5L,4L,4L,3L,5L,3L,4L,3L,5L,4L,3L,3L,5L,3L,4L,3L,4L,5L,4L,4L,4L,2L,3L,4L,6L,3L,5L,3L,4L,4L,4L,4L,5L,4L,5L,5L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196067Inst : IEnumerable<long>
{
public static readonly long[] Value=A196067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196067.Bytes);
public long this[int i]=>Value[i];

public static A196067Inst Instance=new A196067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196068
{
public static readonly long[] Value={ 1L,3L,6L,5L,10L,8L,9L,7L,11L,12L,15L,10L,13L,11L,15L,9L,14L,13L,12L,14L,14L,17L,17L,12L,19L,15L,16L,13L,18L,17L,21L,11L,20L,16L,18L,15L,16L,14L,18L,16L,19L,16L,17L,19L,20L,19L,22L,14L,17L,21L,19L,17L,15L,18L,24L,15L,17L,20L,20L,19L,20L,23L,19L,13L,22L,22L,18L,18L,22L,20L,21L,17L,21L,18L,24L,16L,23L,20L,24L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196068Inst : IEnumerable<long>
{
public static readonly long[] Value=A196068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196068.Bytes);
public long this[int i]=>Value[i];

public static A196068Inst Instance=new A196068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196069
{
public static readonly long[] Value={ 1L,5L,13L,25L,45L,72L,115L,166L,235L,327L,428L,548L,709L,874L,1095L,1384L,1651L,1936L,2305L,2783L,3325L,3813L,4369L,5131L,5893L,6746L,7881L,8914L,9920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196069Inst : IEnumerable<long>
{
public static readonly long[] Value=A196069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196069.Bytes);
public long this[int i]=>Value[i];

public static A196069Inst Instance=new A196069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196070
{
public static readonly long[] Value={ 2L,3L,491L,525773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196070Inst : IEnumerable<long>
{
public static readonly long[] Value=A196070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196070.Bytes);
public long this[int i]=>Value[i];

public static A196070Inst Instance=new A196070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196071
{
public static readonly long[] Value={ 1L,1L,1L,8L,77L,1126L,31062L,1430161L,124227477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196071Inst : IEnumerable<long>
{
public static readonly long[] Value=A196071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196071.Bytes);
public long this[int i]=>Value[i];

public static A196071Inst Instance=new A196071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196072
{
public static readonly long[] Value={ 0L,1L,2L,0L,6L,2L,8L,12L,10L,32L,26L,58L,82L,104L,204L,238L,424L,606L,870L,1438L,1952L,3156L,4602L,6848L,10634L,15354L,23794L,35192L,52844L,80254L,118744L,180686L,269382L,405118L,610576L,911988L,1377066L,2061328L,3099290L,4659546L,6984594L,10512968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196072Inst : IEnumerable<long>
{
public static readonly long[] Value=A196072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196072.Bytes);
public long this[int i]=>Value[i];

public static A196072Inst Instance=new A196072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196073
{
public static readonly long[] Value={ 0L,2L,1L,1L,6L,8L,12L,28L,36L,63L,147L,216L,400L,746L,1204L,2234L,4103L,6927L,12582L,22430L,38914L,70334L,124820L,219139L,392271L,694562L,1227704L,2190008L,3878528L,6871416L,12222729L,21659291L,38421292L,68259422L,121017534L,214735198L,381233984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196073Inst : IEnumerable<long>
{
public static readonly long[] Value=A196073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196073.Bytes);
public long this[int i]=>Value[i];

public static A196073Inst Instance=new A196073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196074
{
public static readonly long[] Value={ 0L,0L,1L,8L,39L,60L,111L,343L,861L,2115L,5016L,13734L,35912L,82715L,202744L,522390L,1333539L,3288827L,8106150L,20528101L,51563620L,128020497L,319184841L,801237793L,2009081101L,5009247370L,12506463250L,31323071350L,78380580569L,195823809542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196074Inst : IEnumerable<long>
{
public static readonly long[] Value=A196074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196074.Bytes);
public long this[int i]=>Value[i];

public static A196074Inst Instance=new A196074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196075
{
public static readonly long[] Value={ 0L,6L,6L,39L,77L,296L,931L,2638L,8969L,29941L,99585L,315727L,1074032L,3477361L,11370172L,37477271L,122469356L,399765201L,1309196450L,4286354555L,14003095258L,45836607641L,149994346388L,490592491099L,1605187568492L,5252818092741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196075Inst : IEnumerable<long>
{
public static readonly long[] Value=A196075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196075.Bytes);
public long this[int i]=>Value[i];

public static A196075Inst Instance=new A196075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196076
{
public static readonly long[] Value={ 0L,2L,8L,60L,296L,1126L,4237L,24210L,91541L,440533L,1942297L,8497706L,37987962L,169158221L,750990638L,3344857959L,14827515754L,65958541835L,293291341441L,1303464660150L,5793684155190L,25748199147004L,114445600714047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196076Inst : IEnumerable<long>
{
public static readonly long[] Value=A196076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196076.Bytes);
public long this[int i]=>Value[i];

public static A196076Inst Instance=new A196076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196077
{
public static readonly long[] Value={ 0L,8L,12L,111L,931L,4237L,31062L,156559L,1100005L,6068247L,36690646L,216691051L,1306291763L,7830872051L,46246201736L,276088388127L,1648566730899L,9851802002425L,58646275919149L,349472725050705L,2085510547835213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196077Inst : IEnumerable<long>
{
public static readonly long[] Value=A196077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196077.Bytes);
public long this[int i]=>Value[i];

public static A196077Inst Instance=new A196077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196078
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,2L,2L,0L,0L,0L,1L,0L,0L,0L,6L,1L,1L,6L,0L,0L,2L,6L,8L,6L,2L,0L,0L,8L,8L,39L,39L,8L,8L,0L,0L,12L,12L,60L,77L,60L,12L,12L,0L,0L,10L,28L,111L,296L,296L,111L,28L,10L,0L,0L,32L,36L,343L,931L,1126L,931L,343L,36L,32L,0L,0L,26L,63L,861L,2638L,4237L,4237L,2638L,861L,63L,26L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196078Inst : IEnumerable<long>
{
public static readonly long[] Value=A196078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196078.Bytes);
public long this[int i]=>Value[i];

public static A196078Inst Instance=new A196078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196079
{
public static readonly long[] Value={ 1L,3L,7L,11L,15L,11L,29L,43L,35L,41L,23L,55L,29L,31L,69L,89L,109L,55L,69L,47L,145L,53L,81L,87L,59L,137L,155L,67L,71L,197L,79L,207L,83L,165L,187L,141L,323L,149L,103L,159L,107L,269L,121L,235L,177L,319L,127L,255L,131L,253L,137L,139L,213L,445L,149L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196079Inst : IEnumerable<long>
{
public static readonly long[] Value=A196079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196079.Bytes);
public long this[int i]=>Value[i];

public static A196079Inst Instance=new A196079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196080
{
public static readonly long[] Value={ 2L,2L,3L,3L,37L,37L,1111L,1111L,6913L,6913L,799933L,799933L,739138093L,739138093L,44841044309L,44841044309L,32285551902481L,32285551902481L,9879378882159187L,9879378882159187L,1251387991740163687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196080Inst : IEnumerable<long>
{
public static readonly long[] Value=A196080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196080.Bytes);
public long this[int i]=>Value[i];

public static A196080Inst Instance=new A196080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196081
{
public static readonly long[] Value={ 10L,0L,11L,0L,12L,1L,13L,1L,14L,2L,15L,2L,16L,3L,17L,3L,18L,4L,19L,4L,20L,5L,21L,5L,22L,6L,23L,6L,24L,7L,25L,7L,26L,8L,27L,8L,28L,9L,29L,9L,30L,10L,31L,10L,32L,11L,33L,11L,34L,12L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196081Inst : IEnumerable<long>
{
public static readonly long[] Value=A196081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196081.Bytes);
public long this[int i]=>Value[i];

public static A196081Inst Instance=new A196081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196082
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,4L,6L,1L,8L,9L,10L,9L,12L,11L,14L,1L,16L,10L,18L,16L,20L,20L,22L,16L,24L,25L,26L,25L,28L,25L,30L,1L,32L,33L,34L,28L,36L,36L,38L,25L,40L,36L,42L,37L,44L,41L,46L,33L,48L,49L,50L,48L,52L,28L,54L,49L,56L,57L,58L,45L,60L,59L,62L,1L,64L,64L,66L,64L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196082Inst : IEnumerable<long>
{
public static readonly long[] Value=A196082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196082.Bytes);
public long this[int i]=>Value[i];

public static A196082Inst Instance=new A196082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196083
{
public static readonly long[] Value={ 3L,23L,6L,5L,5L,15L,9L,25L,46L,111L,12L,15L,10L,9L,15L,69L,10L,30L,265L,18L,50L,31L,92L,15L,21L,135L,222L,15L,24L,45L,53L,115L,30L,23L,27L,75L,223L,20L,18L,30L,138L,81L,20L,60L,235L,33L,333L,25L,27L,47L,161L,36L,100L,115L,62L,39L,45L,25L,37L,75L,184L,30L,42L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196083Inst : IEnumerable<long>
{
public static readonly long[] Value=A196083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196083.Bytes);
public long this[int i]=>Value[i];

public static A196083Inst Instance=new A196083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196084
{
public static readonly long[] Value={ 3L,5L,7L,8L,8L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,27L,29L,31L,32L,35L,35L,37L,39L,40L,43L,45L,45L,45L,45L,48L,49L,51L,56L,56L,61L,63L,63L,63L,64L,65L,67L,69L,72L,72L,72L,72L,73L,77L,79L,80L,80L,81L,85L,87L,91L,95L,96L,97L,99L,104L,105L,112L,115L,117L,117L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196084Inst : IEnumerable<long>
{
public static readonly long[] Value=A196084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196084.Bytes);
public long this[int i]=>Value[i];

public static A196084Inst Instance=new A196084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196085
{
public static readonly long[] Value={ 5L,27L,9L,9L,21L,32L,120L,24L,16L,279L,45L,152L,504L,72L,40L,245L,795L,105L,261L,48L,72L,144L,497L,63L,189L,56L,91L,104L,656L,215L,240L,112L,225L,765L,360L,65L,160L,185L,135L,207L,429L,187L,85L,95L,155L,455L,504L,171L,585L,117L,153L,247L,672L,280L,765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196085Inst : IEnumerable<long>
{
public static readonly long[] Value=A196085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196085.Bytes);
public long this[int i]=>Value[i];

public static A196085Inst Instance=new A196085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196086
{
public static readonly long[] Value={ 3L,23L,5L,5L,15L,25L,111L,15L,9L,265L,31L,135L,485L,53L,23L,223L,771L,81L,235L,27L,47L,115L,465L,37L,155L,31L,59L,71L,619L,177L,201L,75L,181L,719L,311L,37L,113L,137L,89L,157L,375L,135L,47L,53L,103L,397L,445L,115L,521L,67L,97L,185L,603L,213L,691L,333L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196086Inst : IEnumerable<long>
{
public static readonly long[] Value=A196086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196086.Bytes);
public long this[int i]=>Value[i];

public static A196086Inst Instance=new A196086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196087
{
public static readonly long[] Value={ 0L,1L,3L,8L,15L,31L,51L,90L,142L,228L,341L,525L,757L,1110L,1572L,2233L,3084L,4286L,5812L,7910L,10580L,14145L,18659L,24626L,32099L,41814L,53976L,69559L,88932L,113557L,143967L,182241L,229353L,288078L,360029L,449158L,557757L,691369L,853628L,1051974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196087Inst : IEnumerable<long>
{
public static readonly long[] Value=A196087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196087.Bytes);
public long this[int i]=>Value[i];

public static A196087Inst Instance=new A196087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196088
{
public static readonly long[] Value={ 7L,9L,13L,14L,15L,16L,18L,19L,21L,23L,25L,26L,27L,27L,28L,29L,30L,32L,33L,35L,35L,36L,39L,40L,40L,41L,42L,45L,45L,45L,46L,47L,48L,49L,52L,53L,54L,54L,55L,56L,58L,59L,60L,63L,63L,63L,64L,65L,69L,70L,70L,71L,72L,72L,75L,75L,77L,80L,80L,81L,81L,81L,82L,83L,84L,85L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196088Inst : IEnumerable<long>
{
public static readonly long[] Value=A196088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196088.Bytes);
public long this[int i]=>Value[i];

public static A196088Inst Instance=new A196088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196089
{
public static readonly long[] Value={ 39L,17L,144L,78L,56L,45L,34L,315L,117L,24L,552L,288L,51L,200L,156L,45L,112L,90L,305L,72L,195L,68L,432L,57L,333L,105L,234L,85L,168L,581L,48L,144L,135L,273L,576L,189L,102L,400L,63L,312L,90L,240L,224L,80L,119L,351L,180L,297L,72L,144L,390L,360L,136L,335L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196089Inst : IEnumerable<long>
{
public static readonly long[] Value=A196089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196089.Bytes);
public long this[int i]=>Value[i];

public static A196089Inst Instance=new A196089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196090
{
public static readonly long[] Value={ 45L,25L,155L,90L,69L,59L,50L,331L,135L,45L,573L,310L,75L,223L,180L,71L,138L,118L,333L,103L,225L,100L,465L,93L,367L,141L,270L,125L,207L,619L,90L,185L,177L,315L,620L,235L,150L,446L,113L,360L,142L,291L,276L,137L,175L,405L,236L,353L,135L,206L,450L,421L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196090Inst : IEnumerable<long>
{
public static readonly long[] Value=A196090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196090.Bytes);
public long this[int i]=>Value[i];

public static A196090Inst Instance=new A196090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196091
{
public static readonly long[] Value={ 7L,9L,13L,15L,16L,19L,23L,25L,27L,29L,33L,35L,40L,40L,41L,45L,47L,51L,53L,55L,59L,63L,65L,71L,72L,75L,81L,83L,85L,88L,89L,93L,95L,96L,99L,101L,104L,111L,115L,117L,117L,128L,129L,133L,135L,145L,147L,152L,153L,153L,168L,171L,175L,183L,195L,200L,208L,216L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196091Inst : IEnumerable<long>
{
public static readonly long[] Value=A196091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196091.Bytes);
public long this[int i]=>Value[i];

public static A196091Inst Instance=new A196091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196092
{
public static readonly long[] Value={ 39L,17L,144L,56L,45L,315L,24L,552L,200L,45L,305L,72L,57L,333L,105L,581L,144L,752L,189L,63L,240L,80L,297L,360L,335L,91L,112L,504L,192L,369L,585L,160L,672L,623L,248L,765L,135L,247L,387L,280L,365L,231L,352L,216L,391L,648L,475L,351L,520L,665L,395L,667L,423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196092Inst : IEnumerable<long>
{
public static readonly long[] Value=A196092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196092.Bytes);
public long this[int i]=>Value[i];

public static A196092Inst Instance=new A196092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196093
{
public static readonly long[] Value={ 45L,25L,155L,69L,59L,331L,45L,573L,223L,71L,333L,103L,93L,367L,141L,619L,185L,795L,235L,113L,291L,137L,353L,421L,397L,159L,185L,575L,267L,445L,661L,243L,753L,705L,335L,851L,229L,345L,487L,383L,467L,345L,465L,335L,509L,773L,603L,485L,653L,797L,543L,815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196093Inst : IEnumerable<long>
{
public static readonly long[] Value=A196093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196093.Bytes);
public long this[int i]=>Value[i];

public static A196093Inst Instance=new A196093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196094
{
public static readonly long[] Value={ 1L,3L,5L,9L,13L,17L,21L,27L,33L,41L,47L,55L,65L,73L,81L,93L,105L,117L,129L,141L,153L,165L,181L,197L,213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196094Inst : IEnumerable<long>
{
public static readonly long[] Value=A196094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196094.Bytes);
public long this[int i]=>Value[i];

public static A196094Inst Instance=new A196094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196095
{
public static readonly long[] Value={ 11L,19L,29L,31L,41L,59L,61L,71L,79L,89L,101L,109L,139L,149L,151L,181L,191L,199L,239L,251L,269L,281L,349L,401L,409L,421L,439L,449L,491L,499L,509L,521L,569L,599L,601L,691L,701L,709L,739L,751L,769L,809L,821L,839L,881L,991L,1009L,1021L,1039L,1049L,1051L,1069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196095Inst : IEnumerable<long>
{
public static readonly long[] Value=A196095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196095.Bytes);
public long this[int i]=>Value[i];

public static A196095Inst Instance=new A196095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196096
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,2L,3L,2L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196096Inst : IEnumerable<long>
{
public static readonly long[] Value=A196096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196096.Bytes);
public long this[int i]=>Value[i];

public static A196096Inst Instance=new A196096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196097
{
public static readonly long[] Value={ 1L,8L,32L,120L,448L,1672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196097Inst : IEnumerable<long>
{
public static readonly long[] Value=A196097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196097.Bytes);
public long this[int i]=>Value[i];

public static A196097Inst Instance=new A196097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196098
{
public static readonly long[] Value={ 3L,4L,6L,8L,9L,10L,11L,12L,12L,14L,15L,15L,16L,17L,18L,19L,20L,20L,20L,21L,22L,22L,23L,24L,24L,25L,26L,27L,28L,28L,28L,29L,30L,30L,30L,31L,32L,32L,33L,33L,33L,34L,35L,35L,36L,36L,36L,37L,38L,39L,40L,40L,40L,42L,42L,42L,44L,44L,44L,45L,45L,46L,47L,48L,48L,50L,51L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196098Inst : IEnumerable<long>
{
public static readonly long[] Value=A196098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196098.Bytes);
public long this[int i]=>Value[i];

public static A196098Inst Instance=new A196098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196099
{
public static readonly long[] Value={ 20L,7L,40L,14L,60L,34L,288L,21L,80L,230L,32L,100L,28L,224L,120L,868L,35L,68L,231L,140L,30L,576L,84L,42L,160L,492L,258L,180L,49L,141L,460L,32L,64L,102L,200L,160L,56L,135L,76L,220L,864L,448L,36L,96L,63L,240L,767L,60L,110L,260L,70L,136L,462L,50L,280L,690L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196099Inst : IEnumerable<long>
{
public static readonly long[] Value=A196099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196099.Bytes);
public long this[int i]=>Value[i];

public static A196099Inst Instance=new A196099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196100
{
public static readonly long[] Value={ 22L,10L,44L,20L,66L,41L,295L,30L,88L,239L,43L,110L,40L,235L,132L,880L,50L,82L,244L,154L,47L,590L,100L,60L,176L,508L,275L,198L,70L,160L,478L,55L,86L,123L,220L,181L,80L,157L,100L,242L,885L,470L,64L,121L,90L,264L,790L,88L,137L,286L,100L,164L,488L,83L,308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196100Inst : IEnumerable<long>
{
public static readonly long[] Value=A196100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196100.Bytes);
public long this[int i]=>Value[i];

public static A196100Inst Instance=new A196100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196101
{
public static readonly long[] Value={ 3L,4L,10L,11L,14L,15L,17L,19L,20L,22L,23L,25L,26L,28L,29L,31L,32L,33L,35L,35L,36L,37L,38L,42L,44L,47L,53L,54L,55L,57L,61L,63L,64L,64L,65L,68L,70L,71L,77L,82L,84L,85L,86L,91L,96L,98L,99L,100L,101L,109L,110L,116L,124L,125L,126L,128L,132L,138L,140L,145L,146L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196101Inst : IEnumerable<long>
{
public static readonly long[] Value=A196101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196101.Bytes);
public long this[int i]=>Value[i];

public static A196101Inst Instance=new A196101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196102
{
public static readonly long[] Value={ 20L,7L,34L,288L,230L,32L,224L,868L,231L,30L,84L,492L,258L,141L,32L,160L,135L,76L,36L,96L,767L,60L,110L,50L,365L,384L,140L,238L,532L,256L,192L,704L,165L,583L,92L,171L,414L,900L,320L,154L,275L,396L,638L,352L,287L,234L,128L,403L,572L,672L,518L,555L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196102Inst : IEnumerable<long>
{
public static readonly long[] Value=A196102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196102.Bytes);
public long this[int i]=>Value[i];

public static A196102Inst Instance=new A196102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196103
{
public static readonly long[] Value={ 22L,10L,41L,295L,239L,43L,235L,880L,244L,47L,100L,508L,275L,160L,55L,181L,157L,100L,64L,121L,790L,88L,137L,83L,394L,415L,178L,275L,568L,295L,235L,745L,211L,625L,142L,220L,461L,946L,373L,215L,334L,454L,695L,415L,355L,305L,205L,472L,640L,745L,593L,634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196103Inst : IEnumerable<long>
{
public static readonly long[] Value=A196103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196103.Bytes);
public long this[int i]=>Value[i];

public static A196103Inst Instance=new A196103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196104
{
public static readonly BigInteger[] Value={ 4L,6L,9L,22L,33L,55L,77L,111L,1111L,11111L,1111111L,11111111111L,11111111111111111L,2222222222222222222L,3333333333333333333L,5555555555555555555L,7777777777777777777L,BigInteger.Parse("22222222222222222222222"),BigInteger.Parse("33333333333333333333333"),BigInteger.Parse("55555555555555555555555") };
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
public class A196104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196104Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196104.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196104.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196104Inst Instance=new A196104Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}